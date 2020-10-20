using System;
using System.Text;
using ExaltMultiTool.Properties;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x020000B5 RID: 181
internal class IpJoin
{
	// Token: 0x060004EA RID: 1258 RVA: 0x0001C7FC File Offset: 0x0001A9FC
	public IpJoin(Client client)
	{
		this.client = client;
	}

	// Token: 0x060004EB RID: 1259 RVA: 0x0001C818 File Offset: 0x0001AA18
	public void SetIp(string ip)
	{
		this._ip = ip;
	}

	// Token: 0x060004EC RID: 1260 RVA: 0x0001C82C File Offset: 0x0001AA2C
	public void text(PlayerTextPacket text)
	{
		if (!Settings.Default.EnableGotoCommand)
		{
			return;
		}
		if (!text.Text.StartsWith("/"))
		{
			return;
		}
		string[] array = text.Text.Split(new char[]
		{
			' '
		});
		string a = array[0].ToLower();
		if (a == "/ip")
		{
			text.Send = false;
			this.SendTextToClient("Server IP: " + this._ip);
			return;
		}
		if (a == "/iunderstandthiswarning")
		{
			text.Send = false;
			this.SendTextToClient("Warning acknowledged and disabled, you are free to use /goto now.");
			Settings.Default.EnableGotoCommandWarningAcknowledged = true;
			Settings.Default.Save();
			return;
		}
		if (!(a == "/goto"))
		{
			return;
		}
		text.Send = false;
		if (!Settings.Default.EnableGotoCommandWarningAcknowledged)
		{
			this.SendTextToClient("WARNING! People can effectively steal your login credentials with /goto and gain access to your account. If someone told you to paste this in, you probably don't want to do it. They can host a malicious server that saves your encrypted email and password when you connect, which lets them login to your account in game. YOU HAVE BEEN WARNED! Type /iUnderstandThisWarning to disable this warning.");
			return;
		}
		if (array.Length >= 2 && !string.IsNullOrEmpty(array[1]))
		{
			this.SendClientToIp(array[1]);
		}
	}

	// Token: 0x060004EE RID: 1262 RVA: 0x0001C970 File Offset: 0x0001AB70
	private void SendTextToClient(string text)
	{
		TextPacket textPacket = (TextPacket)Packet.Create(PacketType.TEXT);
		textPacket.CleanText = text;
		textPacket.Text = textPacket.CleanText;
		textPacket.NumStars = -1;
		textPacket.Name = "";
		textPacket.Recipient = "";
		this.client.SendToClient(textPacket);
	}

	// Token: 0x060004EF RID: 1263 RVA: 0x0001C9CC File Offset: 0x0001ABCC
	private void SendClientToIp(string ip)
	{
		string s = Guid.NewGuid().ToString();
		byte[] bytes = Encoding.ASCII.GetBytes(s);
		string key = Client.ByteArrayToString(bytes);
		ReconnectPacket reconnectPacket = (ReconnectPacket)Packet.Create(PacketType.RECONNECT);
		reconnectPacket.GameId = -2;
		reconnectPacket.Host = ip;
		reconnectPacket.Port = 2050;
		reconnectPacket.isFromArena = false;
		reconnectPacket.Key = new byte[0];
		reconnectPacket.KeyTime = -1;
		reconnectPacket.Name = "Recon";
		reconnectPacket.State = string.Empty;
		ReconnectPacket reconnectPacket2 = (ReconnectPacket)Packet.Create(PacketType.RECONNECT);
		reconnectPacket2.GameId = -2;
		reconnectPacket2.Host = "127.0.0.1";
		reconnectPacket2.Port = 2050;
		reconnectPacket2.isFromArena = false;
		reconnectPacket2.Key = bytes;
		reconnectPacket2.KeyTime = -1;
		reconnectPacket2.Name = "Realm";
		reconnectPacket2.State = string.Empty;
		this.client.Proxy.ClientDestinations.TryAdd(key, reconnectPacket);
		this.client.SendToClient("Connecting to: " + ip);
		this.client.SendToClient(reconnectPacket2);
	}

	// Token: 0x040005ED RID: 1517
	private Client client;

	// Token: 0x040005EE RID: 1518
	private string _ip;
}
