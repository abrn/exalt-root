using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using ExaltMultiTool.Properties;
using ExaltMultiTool.Proxy.Mods;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000026 RID: 38
internal class Client
{
	// Token: 0x170000CE RID: 206
	// (get) Token: 0x06000224 RID: 548 RVA: 0x0000F69C File Offset: 0x0000D89C
	public int Time
	{
		get
		{
			return this.PreviousTime + (Environment.TickCount - this.LastUpdate);
		}
	}

	// Token: 0x170000CF RID: 207
	// (get) Token: 0x06000225 RID: 549 RVA: 0x0000F6BC File Offset: 0x0000D8BC
	public int PreciseTimeMS
	{
		get
		{
			return (int)(DateTime.Now - this._startDate).TotalMilliseconds;
		}
	}

	// Token: 0x170000D0 RID: 208
	// (get) Token: 0x06000226 RID: 550 RVA: 0x0000F6E4 File Offset: 0x0000D8E4
	public int ObjectId
	{
		get
		{
			return this.Player.ObjectId;
		}
	}

	// Token: 0x170000D1 RID: 209
	// (get) Token: 0x06000227 RID: 551 RVA: 0x0000F6FC File Offset: 0x0000D8FC
	// (set) Token: 0x06000228 RID: 552 RVA: 0x0000F710 File Offset: 0x0000D910
	public GameObject Player { get; set; }

	// Token: 0x170000D2 RID: 210
	// (get) Token: 0x06000229 RID: 553 RVA: 0x0000F724 File Offset: 0x0000D924
	public bool Connected
	{
		get
		{
			return !this._closed;
		}
	}

	// Token: 0x0600022A RID: 554 RVA: 0x0000F73C File Offset: 0x0000D93C
	public Client(Proxy proxy, TcpClient client)
	{
		this.Proxy = proxy;
		this._clientConnection = client;
		this._clientStream = this._clientConnection.GetStream();
		this._clientConnection.NoDelay = true;
		this.AntiAfk = new AntiAFK(this);
		this._antiDebuffs = new AntiDebuffs(this);
		this._antiLag = new AntiLag(this);
		this._antiSpam = new AntiSpam(this);
		this._autoNexus2 = new AutoNexus2(this);
		this._autoLoot = new AutoLoot(this);
		this._autoNexus = new AutoNexus(this);
		this._objectTracker = new ObjectTracker(this);
		this.SafeWalk = new SafeWalk(this);
		this._teleportTools = new TeleportTools(this);
		this._antiDdos = new AntiDdos();
		this._ipJoin = new IpJoin(this);
		this._fameHelper = new FameHelper(this);
		this._bazaarTimer = new BazaarTimer(this);
		this._accuracyFarm = new AccuracyFarm(this);
		this._mapHack = new MapHack(this);
		this._o3Helper = new o3Helper(this);
		this._showLHPot = new ShowRealLHPot();
		this.BeginRead(0, 4, true);
	}

	// Token: 0x0600022B RID: 555 RVA: 0x0000F92C File Offset: 0x0000DB2C
	private void ServerConnected(IAsyncResult ar)
	{
		try
		{
			this._serverConnection.EndConnect(ar);
			this._serverStream = this._serverConnection.GetStream();
			string text = (this._serverConnection.Client.RemoteEndPoint as IPEndPoint).Address.ToString();
			this._ipJoin.SetIp(text);
			this.SendToServer(ar.AsyncState as Packet);
			this.BeginRead(0, 4, false);
			this.Proxy.FireClientConnected(this);
			Console.WriteLine("Client: Connected to remote host " + text);
		}
		catch (Exception reason)
		{
			this.Dispose(reason);
		}
	}

	// Token: 0x0600022C RID: 556 RVA: 0x0000F9D4 File Offset: 0x0000DBD4
	public void Dispose(Exception reason = null)
	{
		if (!this._closed)
		{
			this._closed = true;
			this.Proxy.FireClientDisconnected(this);
			NetworkStream clientStream = this._clientStream;
			if (clientStream != null)
			{
				clientStream.Close();
			}
			else
			{
				NetworkStream serverStream = this._serverStream;
				if (serverStream != null)
				{
					serverStream.Close();
				}
				TcpClient clientConnection = this._clientConnection;
				if (clientConnection != null)
				{
					clientConnection.Close();
				}
				TcpClient serverConnection = this._serverConnection;
				if (serverConnection != null)
				{
					serverConnection.Close();
				}
				PacketBuffer clientBuffer = this._clientBuffer;
				if (clientBuffer != null)
				{
					clientBuffer.Dispose();
				}
			}
			PacketBuffer serverBuffer = this._serverBuffer;
			if (serverBuffer != null)
			{
				serverBuffer.Dispose();
			}
			if (reason != null && !(reason is SocketException) && !(reason is IOException))
			{
				Console.WriteLine(string.Format("Client: Disposed\n{0}", reason));
				return;
			}
			Console.WriteLine("Client: Disconnected");
		}
	}

	// Token: 0x0600022D RID: 557 RVA: 0x0000FA94 File Offset: 0x0000DC94
	public void SendToClient(Packet packet)
	{
		this.Send(packet, true);
	}

	// Token: 0x0600022E RID: 558 RVA: 0x0000FAAC File Offset: 0x0000DCAC
	public void SendToServer(Packet packet)
	{
		this.Send(packet, false);
	}

	// Token: 0x0600022F RID: 559 RVA: 0x0000FAC4 File Offset: 0x0000DCC4
	private void Send(Packet packet, bool client)
	{
		object obj = client ? this._clientLock : this._serverLock;
		lock (obj)
		{
			try
			{
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (PacketWriter packetWriter = new PacketWriter(memoryStream))
					{
						packetWriter.Write(0);
						packetWriter.Write(packet.Id);
						packet.Write(packetWriter);
					}
					byte[] array = memoryStream.ToArray();
					PacketWriter.BlockCopyInt32(array, array.Length);
					if (client)
					{
						this._clientSendState.Cipher(array);
						this._clientStream.Write(array, 0, array.Length);
					}
					else
					{
						this._serverSendState.Cipher(array);
						this._serverStream.Write(array, 0, array.Length);
					}
				}
			}
			catch (Exception reason)
			{
				this.Dispose(reason);
			}
		}
	}

	// Token: 0x06000230 RID: 560 RVA: 0x0000FBE4 File Offset: 0x0000DDE4
	private void BeginRead(int offset, int amount, bool client)
	{
		PacketBuffer packetBuffer = client ? this._clientBuffer : this._serverBuffer;
		NetworkStream networkStream = client ? this._clientStream : this._serverStream;
		try
		{
			networkStream.BeginRead(packetBuffer.Bytes, offset, amount, new AsyncCallback(this.RemoteRead), client);
		}
		catch (Exception reason)
		{
			this.Dispose(reason);
		}
	}

	// Token: 0x06000231 RID: 561 RVA: 0x0000FC54 File Offset: 0x0000DE54
	private void RemoteRead(IAsyncResult ar)
	{
		bool flag = (bool)ar.AsyncState;
		PacketBuffer packetBuffer = flag ? this._clientBuffer : this._serverBuffer;
		NetworkStream networkStream = flag ? this._clientStream : this._serverStream;
		bool flag2;
		RC4Cipher rc4Cipher = (flag2 = (networkStream == this._clientStream)) ? this._clientReceiveState : this._serverReceiveState;
		try
		{
			if (networkStream.CanRead)
			{
				int num = networkStream.EndRead(ar);
				packetBuffer.Advance(num);
				if (num == 0)
				{
					this.Dispose(null);
				}
				else if (packetBuffer.Index == 4)
				{
					packetBuffer.Resize(IPAddress.NetworkToHostOrder(BitConverter.ToInt32(packetBuffer.Bytes, 0)));
					this.BeginRead(packetBuffer.Index, packetBuffer.BytesRemaining(), flag2);
				}
				else if (packetBuffer.BytesRemaining() > 0)
				{
					this.BeginRead(packetBuffer.Index, packetBuffer.BytesRemaining(), flag2);
				}
				else
				{
					rc4Cipher.Cipher(packetBuffer.Bytes);
					Packet packet = Packet.Create(packetBuffer.Bytes);
					object handleLock = this._handleLock;
					lock (handleLock)
					{
						this.HandlePacket(packet);
					}
					if (packet.Send)
					{
						this.Send(packet, !flag2);
					}
					packetBuffer.Reset();
					this.BeginRead(0, 4, flag2);
				}
			}
		}
		catch (Exception reason)
		{
			this.Dispose(reason);
		}
	}

	// Token: 0x06000232 RID: 562 RVA: 0x0000FDC0 File Offset: 0x0000DFC0
	private void HandlePacket(Packet packet)
	{
		UpdatePacket updatePacket = packet as UpdatePacket;
		if (updatePacket != null)
		{
			this._objectTracker.Update(updatePacket);
			this.SafeWalk.Update(updatePacket);
			this._autoNexus.Update(updatePacket);
			this._fameHelper.Update(updatePacket);
			this._accuracyFarm.Update(updatePacket);
			this._antiLag.Update(updatePacket);
			this._autoLoot.Update(updatePacket);
			this._mapHack.Update(updatePacket);
			this._o3Helper.Update(updatePacket);
			this._showLHPot.Update(updatePacket);
			return;
		}
		NewTickPacket newTickPacket = packet as NewTickPacket;
		if (newTickPacket != null)
		{
			this._objectTracker.NewTick(newTickPacket);
			this._antiDebuffs.NewTick(newTickPacket);
			this._autoNexus.NewTick(newTickPacket);
			this._antiDdos.NewTick();
			this._fameHelper.NewTick(newTickPacket);
			this._accuracyFarm.NewTick(newTickPacket);
			this._antiLag.NewTick(newTickPacket);
			this._o3Helper.NewTick(newTickPacket);
			this._autoNexus2.NewTick(newTickPacket);
			return;
		}
		MovePacket movePacket = packet as MovePacket;
		if (movePacket != null)
		{
			this.PreviousTime = movePacket._Nx46RcGIU0H1BCGWaJXjN1ieopt;
			this._objectTracker.move(movePacket);
			this._antiDebuffs.move(movePacket);
			this._autoLoot.move(movePacket);
			this.AntiAfk.move(movePacket);
			this._autoNexus.move(movePacket);
			this._autoNexus2.move(movePacket);
			return;
		}
		MapInfoPacket mapInfoPacket = packet as MapInfoPacket;
		if (mapInfoPacket != null)
		{
			Console.WriteLine("Client: Map is " + mapInfoPacket._Jp3DtIV4aAYZY26sVsXpPQjBRGO);
			this._objectTracker.MapInfo(mapInfoPacket);
			this._autoNexus2.MapInfo(mapInfoPacket);
			this.SafeWalk.MapInfo(mapInfoPacket);
			this._autoNexus.MapInfo(mapInfoPacket);
			this._autoLoot.MapInfo(mapInfoPacket);
			this._fameHelper.MapInfo();
			_accuracyFarm.MapInfo();
			this._antiLag.MapInfo(mapInfoPacket);
			this._mapHack.MapInfo(mapInfoPacket);
			this._o3Helper.MapInfo(mapInfoPacket);
			this._showLHPot.MapInfo(mapInfoPacket);
			return;
		}
		PlayerTextPacket playerTextPacket = packet as PlayerTextPacket;
		if (playerTextPacket != null)
		{
			this._teleportTools.text(playerTextPacket);
			this._ipJoin.text(playerTextPacket);
			this._fameHelper._QrK9KtR4xguWgEYrBE9xnEwwcqd(playerTextPacket);
			this._antiLag.text(playerTextPacket);
			this._mapHack.text(playerTextPacket);
			this._autoNexus._QrK9KtR4xguWgEYrBE9xnEwwcqd(playerTextPacket);
			return;
		}
		_5Qyhf9ImNgkDzh4BmaDRKP646iH createSuccessPacket = packet as _5Qyhf9ImNgkDzh4BmaDRKP646iH;
		if (createSuccessPacket != null)
		{
			this.PlayerId = createSuccessPacket.ObjectId;
			this._objectTracker._1lYB9SyYVs1zUAIHgLGbUs7pmeb();
			this._bazaarTimer._1lYB9SyYVs1zUAIHgLGbUs7pmeb();
			this._autoNexus2._1lYB9SyYVs1zUAIHgLGbUs7pmeb();
			return;
		}
		FailurePacket failurePacket = packet as FailurePacket;
		if (failurePacket != null)
		{
			Console.WriteLine(string.Format("Client: Got failure {0}, {1} ({2})", failurePacket.ErrorId, failurePacket.ErrorMessage, failurePacket.ErrorPlace));
			return;
		}
		ReconnectPacket reconnectPacket = packet as ReconnectPacket;
		if (reconnectPacket != null)
		{
			this.Reconnect(reconnectPacket);
			return;
		}
		HelloPacket helloPacket = packet as HelloPacket;
		if (helloPacket != null)
		{
			this.Hello(helloPacket);
			return;
		}
		PlayerHitPacket playerHitPacket = packet as PlayerHitPacket;
		if (playerHitPacket != null)
		{
			this._autoNexus.PlayerHit(playerHitPacket);
			this._antiDebuffs.PlayerHit(playerHitPacket);
			return;
		}
		_PQHQze9k9pObME2LmlIcbfEeSYS pqhqze9k9pObME2LmlIcbfEeSYS = packet as _PQHQze9k9pObME2LmlIcbfEeSYS;
		if (pqhqze9k9pObME2LmlIcbfEeSYS != null)
		{
			this._autoNexus._M1PxW31jx87SGG4gvOYAwe86vjg(pqhqze9k9pObME2LmlIcbfEeSYS);
			this._antiDebuffs._M1PxW31jx87SGG4gvOYAwe86vjg(pqhqze9k9pObME2LmlIcbfEeSYS);
			return;
		}
		AoEAckPacket x7UwVkbcYG7VnZWu4HCA8hCeQtS = packet as AoEAckPacket;
		if (x7UwVkbcYG7VnZWu4HCA8hCeQtS != null)
		{
			this._autoNexus._iKqf12lpU2ifSlxUxUegqEC5CVe(x7UwVkbcYG7VnZWu4HCA8hCeQtS);
			return;
		}
		_HLlcDvAIxPBOvJZP4BFTFQUoryN hllcDvAIxPBOvJZP4BFTFQUoryN = packet as _HLlcDvAIxPBOvJZP4BFTFQUoryN;
		if (hllcDvAIxPBOvJZP4BFTFQUoryN != null)
		{
			this._autoNexus._524YRDmz9HCOj575eu5oeD5ruJb(hllcDvAIxPBOvJZP4BFTFQUoryN);
			return;
		}
		_6lHFncsY9352Wg3pNnnFZ49g5xA 6lHFncsY9352Wg3pNnnFZ49g5xA = packet as _6lHFncsY9352Wg3pNnnFZ49g5xA;
		if (6lHFncsY9352Wg3pNnnFZ49g5xA != null)
		{
			this._teleportTools._FMTVFcTfzNRteqoB3XiUkaNps7l(6lHFncsY9352Wg3pNnnFZ49g5xA);
			return;
		}
		ShowEffectPacket showEffectPacket = packet as ShowEffectPacket;
		if (showEffectPacket != null)
		{
			this._antiLag._1nwhQXngJ6rNjd7Ufx1bWeF0vhM(showEffectPacket);
			this._autoNexus._1nwhQXngJ6rNjd7Ufx1bWeF0vhM(showEffectPacket);
			this._o3Helper._1nwhQXngJ6rNjd7Ufx1bWeF0vhM(showEffectPacket);
			return;
		}
		_4wU9AwmH67XtmNygsXuDz9DUXYm 4wU9AwmH67XtmNygsXuDz9DUXYm = packet as _4wU9AwmH67XtmNygsXuDz9DUXYm;
		if (4wU9AwmH67XtmNygsXuDz9DUXYm != null)
		{
			this._antiLag._Q1PiJQ99KBCJeLcZ0HOk3AUAjIP(4wU9AwmH67XtmNygsXuDz9DUXYm);
			return;
		}
		_FbqBESNaaIBpK5dNK9X5lWOOll5 fbqBESNaaIBpK5dNK9X5lWOOll = packet as _FbqBESNaaIBpK5dNK9X5lWOOll5;
		if (fbqBESNaaIBpK5dNK9X5lWOOll != null)
		{
			this._autoNexus2._Khyl0TTBfDtVskFpnw4HUKIFLHj(fbqBESNaaIBpK5dNK9X5lWOOll);
			return;
		}
		_CBwOjnzusZzuPkHfx7wuwePHqrf cbwOjnzusZzuPkHfx7wuwePHqrf = packet as _CBwOjnzusZzuPkHfx7wuwePHqrf;
		if (cbwOjnzusZzuPkHfx7wuwePHqrf != null)
		{
			this._antiSpam._IDtpCgDjmC1AQOcZCJSFNAYjlbH(cbwOjnzusZzuPkHfx7wuwePHqrf);
			this._antiLag._IDtpCgDjmC1AQOcZCJSFNAYjlbH(cbwOjnzusZzuPkHfx7wuwePHqrf);
			this._o3Helper._IDtpCgDjmC1AQOcZCJSFNAYjlbH(cbwOjnzusZzuPkHfx7wuwePHqrf);
			return;
		}
		UseItemPacket lylWoxWrca2h31SiYiDb8gyQP0o = packet as UseItemPacket;
		if (lylWoxWrca2h31SiYiDb8gyQP0o != null)
		{
			this._autoNexus2._byANTPGcPV95u6KbP2GDQqgUZ1f(lylWoxWrca2h31SiYiDb8gyQP0o);
			this._fameHelper.UseItem(lylWoxWrca2h31SiYiDb8gyQP0o);
			return;
		}
		_CBWrHXLbrCktla3qkqXNmNymbvH cbwrHXLbrCktla3qkqXNmNymbvH = packet as _CBWrHXLbrCktla3qkqXNmNymbvH;
		if (cbwrHXLbrCktla3qkqXNmNymbvH != null)
		{
			this._objectTracker._Qz49aY7UXgmnBNNMA6Q6IEQtadk(cbwrHXLbrCktla3qkqXNmNymbvH);
			return;
		}
		_maJp2qic3r54gk5Eg1eeMowxvXh maJp2qic3r54gk5Eg1eeMowxvXh = packet as _maJp2qic3r54gk5Eg1eeMowxvXh;
		if (maJp2qic3r54gk5Eg1eeMowxvXh != null)
		{
			this._autoLoot._ZHfjECn2B9JJHnVF67eBaO57JUp(maJp2qic3r54gk5Eg1eeMowxvXh);
			this._autoNexus._ZHfjECn2B9JJHnVF67eBaO57JUp(maJp2qic3r54gk5Eg1eeMowxvXh);
			return;
		}
		EscapePacket m74ADSrj0VfuNwRBO916gAw0Nu = packet as EscapePacket;
		if (m74ADSrj0VfuNwRBO916gAw0Nu != null)
		{
			this.Escape(m74ADSrj0VfuNwRBO916gAw0Nu);
			return;
		}
		_tJHGMoVf7DhHyQm8a6SCuL1cSWl tJHGMoVf7DhHyQm8a6SCuL1cSWl = packet as _tJHGMoVf7DhHyQm8a6SCuL1cSWl;
		if (tJHGMoVf7DhHyQm8a6SCuL1cSWl != null)
		{
			this._antiDdos._UJngUa38CFZ8xbFYYDNCQi7pMAg(tJHGMoVf7DhHyQm8a6SCuL1cSWl);
			return;
		}
		TeleportPacket rvckmor8bw91EVaRfdwc25aHYbc = packet as TeleportPacket;
		if (rvckmor8bw91EVaRfdwc25aHYbc != null)
		{
			this._fameHelper.Teleport(rvckmor8bw91EVaRfdwc25aHYbc);
			this._accuracyFarm.Teleport(rvckmor8bw91EVaRfdwc25aHYbc);
			return;
		}
		_6UIiGxMChbVinHsvx5uqg8WrMRc 6UIiGxMChbVinHsvx5uqg8WrMRc = packet as _6UIiGxMChbVinHsvx5uqg8WrMRc;
		if (6UIiGxMChbVinHsvx5uqg8WrMRc != null)
		{
			this._autoLoot._yOjSn1WKSXsXVziJpL1eH5gSoWg(6UIiGxMChbVinHsvx5uqg8WrMRc);
			return;
		}
		NotificationPacket zIBPB6zZVww7yGWtjJqRMmACh1q = packet as NotificationPacket;
		if (zIBPB6zZVww7yGWtjJqRMmACh1q != null)
		{
			this._autoNexus._4GSfC8bADOwIwOXLYze8EOUBQxJ(zIBPB6zZVww7yGWtjJqRMmACh1q);
			return;
		}
		_K4pBHmoGRyaE6dWf1FIvL0dcuzKA k4pBHmoGRyaE6dWf1FIvL0dcuzKA = packet as _K4pBHmoGRyaE6dWf1FIvL0dcuzKA;
		if (k4pBHmoGRyaE6dWf1FIvL0dcuzKA != null)
		{
			this._antiLag._3MuNCSmlbmV0iTAc8Xn9gqokJ3N(k4pBHmoGRyaE6dWf1FIvL0dcuzKA);
			return;
		}
		_CO7ACSeK1WWaCGAPAqLaov37Wqdb co7ACSeK1WWaCGAPAqLaov37Wqdb = packet as _CO7ACSeK1WWaCGAPAqLaov37Wqdb;
		if (co7ACSeK1WWaCGAPAqLaov37Wqdb != null)
		{
			this._antiLag._sQE0wot2EaQSiJuOdoBQMHZLdjC(co7ACSeK1WWaCGAPAqLaov37Wqdb);
			return;
		}
		_7k8aOfI7MhNrVnHioUXbsPAxkbm 7k8aOfI7MhNrVnHioUXbsPAxkbm = packet as _7k8aOfI7MhNrVnHioUXbsPAxkbm;
		if (7k8aOfI7MhNrVnHioUXbsPAxkbm != null)
		{
			this._o3Helper._9BgsXisaUbFFlj5HLRd76sERUUX(7k8aOfI7MhNrVnHioUXbsPAxkbm);
			return;
		}
		DeathPacket wOmvsGmaE1PheZ2fPjD9V16UEseb = packet as DeathPacket;
		if (wOmvsGmaE1PheZ2fPjD9V16UEseb != null)
		{
			this._autoNexus._qQsqaOxgCR9yg9ky7erATaKrgCC(wOmvsGmaE1PheZ2fPjD9V16UEseb);
			return;
		}
	}

	// Token: 0x06000233 RID: 563 RVA: 0x000103AC File Offset: 0x0000E5AC
	private void Hello(HelloPacket hello)
	{
		this._serverConnection = new TcpClient();
		this._serverConnection.NoDelay = true;
		string key = Client.ByteArrayToString(hello._xXzOsvNNNch6IVvOFHUSv8Y0L8c);
		if (hello._xXzOsvNNNch6IVvOFHUSv8Y0L8c.Length != 0 && this.Proxy._15LfsipxJm1I78mh9UGesTHpsVC.ContainsKey(key))
		{
			ReconnectPacket u9Kj4tAStSlt3Dcm6rdEl60w8MG = this.Proxy._15LfsipxJm1I78mh9UGesTHpsVC[key];
			hello._ojOP4UJkvpLb2pFVOLoW9ZfpS9b = u9Kj4tAStSlt3Dcm6rdEl60w8MG.GameId;
			hello._xXzOsvNNNch6IVvOFHUSv8Y0L8c = u9Kj4tAStSlt3Dcm6rdEl60w8MG.Key;
			hello._KGn7ld0wsUeBW3EMI4gXwdHM01K = u9Kj4tAStSlt3Dcm6rdEl60w8MG.KeyTime;
			this._serverConnection.BeginConnect(u9Kj4tAStSlt3Dcm6rdEl60w8MG.Host, u9Kj4tAStSlt3Dcm6rdEl60w8MG.Port, new AsyncCallback(this.ServerConnected), hello);
			Console.WriteLine("Client: Restored reconnect info.");
		}
		else
		{
			string host = (!ServerParser._IOpSuG4guyYLeez9LywVYmMYQtG.ContainsKey(Settings.Default.CurrentServer)) ? ServerParser._IOpSuG4guyYLeez9LywVYmMYQtG.First<KeyValuePair<string, string>>().Value : ServerParser._IOpSuG4guyYLeez9LywVYmMYQtG[Settings.Default.CurrentServer];
			this._serverConnection.BeginConnect(host, 2050, new AsyncCallback(this.ServerConnected), hello);
			Console.WriteLine("Client: Used default connect info.");
		}
		hello.Send = false;
	}

	// Token: 0x06000234 RID: 564 RVA: 0x000104D0 File Offset: 0x0000E6D0
	private void Reconnect(ReconnectPacket reconnect)
	{
		if (reconnect.Key.Length != 0)
		{
			if (reconnect.Host.Contains(".com"))
			{
				reconnect.Host = Dns.GetHostEntry(reconnect.Host).AddressList[0].ToString();
			}
			ReconnectPacket u9Kj4tAStSlt3Dcm6rdEl60w8MG = (ReconnectPacket)Packet.Create(PacketType.RECONNECT);
			u9Kj4tAStSlt3Dcm6rdEl60w8MG.GameId = reconnect.GameId;
			u9Kj4tAStSlt3Dcm6rdEl60w8MG.Host = (string.IsNullOrWhiteSpace(reconnect.Host) ? (this._serverConnection.Client.RemoteEndPoint as IPEndPoint).Address.ToString() : reconnect.Host);
			u9Kj4tAStSlt3Dcm6rdEl60w8MG.Port = ((reconnect.Port == -1) ? (this._serverConnection.Client.RemoteEndPoint as IPEndPoint).Port : reconnect.Port);
			u9Kj4tAStSlt3Dcm6rdEl60w8MG.isFromArena = reconnect.isFromArena;
			u9Kj4tAStSlt3Dcm6rdEl60w8MG.Key = reconnect.Key;
			u9Kj4tAStSlt3Dcm6rdEl60w8MG.KeyTime = reconnect.KeyTime;
			u9Kj4tAStSlt3Dcm6rdEl60w8MG.Name = reconnect.Name;
			u9Kj4tAStSlt3Dcm6rdEl60w8MG.State = reconnect.State;
			string key = Client.ByteArrayToString(reconnect.Key);
			if (this.Proxy._15LfsipxJm1I78mh9UGesTHpsVC.ContainsKey(key))
			{
				ReconnectPacket u9Kj4tAStSlt3Dcm6rdEl60w8MG2;
				this.Proxy._15LfsipxJm1I78mh9UGesTHpsVC.TryRemove(key, out u9Kj4tAStSlt3Dcm6rdEl60w8MG2);
			}
			this.Proxy._15LfsipxJm1I78mh9UGesTHpsVC.TryAdd(key, u9Kj4tAStSlt3Dcm6rdEl60w8MG);
			reconnect.Host = "127.0.0.1";
			reconnect.Port = 2050;
			Console.WriteLine("Client: Stored reconnect info.");
		}
	}

	// Token: 0x06000235 RID: 565 RVA: 0x00010640 File Offset: 0x0000E840
	private void Escape(EscapePacket escape)
	{
		ReconnectPacket reconnectPacket = (ReconnectPacket)Packet.Create(PacketType.RECONNECT);
		reconnectPacket.GameId = -2;
		reconnectPacket.Host = string.Empty;
		reconnectPacket.Port = -1;
		reconnectPacket.IsFromArena = false;
		reconnectPacket.Key = new byte[0];
		reconnectPacket.KeyTime = -1;
		reconnectPacket.Name = "Nexus";
		reconnectPacket.Stats = string.Empty;
		this.SendToClient(reconnectPacket);
		Console.WriteLine("Client: Sent nexus reconnect.");
		/*
An exception occurred when decompiling this method (06000235)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void _U5AaPl8DapnIJVdc80Ay29WdWR4::_j6HWhGC4110gXDRHhj0Ik2ikJ8G(_m74ADSrj0VfuNwRBO916gAw0Nu0)
 ---> System.OverflowException: Array dimensions exceeded supported range.
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackSlot.ModifyStack(StackSlot[] stack, Int32 popCount, Int32 pushCount, ByteCode pushDefinition) in C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 47
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 387
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 269
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1545
*/
		;
	}

	// Token: 0x06000236 RID: 566 RVA: 0x000106B8 File Offset: 0x0000E8B8
	public static string ByteArrayToString(byte[] ba)
	{
		StringBuilder stringBuilder = new StringBuilder(ba.Length * 2);
		foreach (byte b in ba)
		{
			stringBuilder.AppendFormat("{0:x2}", b);
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06000237 RID: 567 RVA: 0x000106FC File Offset: 0x0000E8FC
	public byte GetBulletId()
	{
		byte bulletId = this._bulletId;
		this._bulletId = (byte)((this._bulletId + 1) % 128);
		return bulletId;
	}

	// Token: 0x06000238 RID: 568 RVA: 0x00010724 File Offset: 0x0000E924
	public Square TileAt(Location loc)
	{
		return this.TileAt((int)loc.x, (int)loc.y);
	}

	// Token: 0x06000239 RID: 569 RVA: 0x00010748 File Offset: 0x0000E948
	public Square TileAt(int x, int y)
	{
		int num = x * this.MapWidth + y;
		return this.Tiles[num];
	}


	// Token: 0x0400027A RID: 634
	private static string Key0 = "5a4d2016bc16dc64883194ffd9";

	// Token: 0x0400027B RID: 635
	private static string Key1 = "c91d9eec420160730d825604e0";

	// Token: 0x0400027C RID: 636
	public int LastUpdate;

	// Token: 0x0400027D RID: 637
	public int PreviousTime;

	// Token: 0x0400027E RID: 638
	private object _serverLock = new object();

	// Token: 0x0400027F RID: 639
	private object _clientLock = new object();

	// Token: 0x04000280 RID: 640
	private object _handleLock = new object();

	// Token: 0x04000281 RID: 641
	private RC4Cipher _clientReceiveState = new RC4Cipher(Client.Key0);

	// Token: 0x04000282 RID: 642
	private RC4Cipher _serverReceiveState = new RC4Cipher(Client.Key1);

	// Token: 0x04000283 RID: 643
	private RC4Cipher _clientSendState = new RC4Cipher(Client.Key1);

	// Token: 0x04000284 RID: 644
	private RC4Cipher _serverSendState = new RC4Cipher(Client.Key0);

	// Token: 0x04000285 RID: 645
	private PacketBuffer _clientBuffer = new PacketBuffer();

	// Token: 0x04000286 RID: 646
	private PacketBuffer _serverBuffer = new PacketBuffer();

	// Token: 0x04000287 RID: 647
	private TcpClient _clientConnection;

	// Token: 0x04000288 RID: 648
	private TcpClient _serverConnection;

	// Token: 0x04000289 RID: 649
	private NetworkStream _clientStream;

	// Token: 0x0400028A RID: 650
	private NetworkStream _serverStream;

	// Token: 0x0400028B RID: 651
	private bool _closed;

	// Token: 0x0400028C RID: 652
	public Proxy Proxy;

	// Token: 0x0400028D RID: 653
	public int PlayerId = -1;

	// Token: 0x0400028E RID: 654
	public int MapWidth;

	// Token: 0x0400028F RID: 655
	public int MapHeight;

	// Token: 0x04000290 RID: 656
	public string MapName = "";

	// Token: 0x04000291 RID: 657
	private byte _bulletId = 1;

	// Token: 0x04000292 RID: 658
	public Square[] Tiles = new Square[0];

	// Token: 0x04000293 RID: 659
	public Dictionary<int, GameObject> Players = new Dictionary<int, GameObject>();

	// Token: 0x04000294 RID: 660
	public Dictionary<int, GameObject> Enemies = new Dictionary<int, GameObject>();

	// Token: 0x04000295 RID: 661
	public Dictionary<int, GameObject> Objects = new Dictionary<int, GameObject>();

	// Token: 0x04000296 RID: 662
	public Dictionary<int, Dictionary<int, Projectile>> projectiles = new Dictionary<int, Dictionary<int, Projectile>>();

	// Token: 0x04000297 RID: 663
	private AntiAFK AntiAfk;

	// Token: 0x04000298 RID: 664
	private AntiDebuffs _antiDebuffs;

	// Token: 0x04000299 RID: 665
	private AntiDdos _antiDdos;

	// Token: 0x0400029A RID: 666
	private AntiLag _antiLag;

	// Token: 0x0400029B RID: 667
	private AntiSpam _antiSpam;

	// Token: 0x0400029C RID: 668
	private AutoNexus2 _autoNexus2;

	// Token: 0x0400029D RID: 669
	private AutoLoot _autoLoot;

	// Token: 0x0400029E RID: 670
	private AutoNexus _autoNexus;

	// Token: 0x0400029F RID: 671
	private ObjectTracker _objectTracker;

	// Token: 0x040002A0 RID: 672
	private SafeWalk SafeWalk;

	// Token: 0x040002A1 RID: 673
	private TeleportTools _teleportTools;

	// Token: 0x040002A2 RID: 674
	private IpJoin _ipJoin;

	// Token: 0x040002A3 RID: 675
	private FameHelper _fameHelper;

	// Token: 0x040002A4 RID: 676
	private BazaarTimer _bazaarTimer;

	// Token: 0x040002A5 RID: 677
	private AccuracyFarm _accuracyFarm;

	// Token: 0x040002A6 RID: 678
	private MapHack _mapHack;

	// Token: 0x040002A7 RID: 679
	private o3Helper _o3Helper;

	// Token: 0x040002A8 RID: 680
	private ShowRealLHPot _showLHPot;

	// Token: 0x040002A9 RID: 681
	private DateTime _startDate = DateTime.Now;

	// Token: 0x040002AA RID: 682
	[CompilerGenerated]
	private GameObject _mxk4XWLKtoXOqWaRinpDeNp2PQh;
}
