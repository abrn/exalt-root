using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ExaltMultiTool.Properties;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x020000BF RID: 191
internal class TeleportTools
{
	// Token: 0x0600051E RID: 1310 RVA: 0x0001E80C File Offset: 0x0001CA0C
	public TeleportTools(Client client)
	{
		this._W6Ov6AArxzTTDnCyBtZPqkqNaKf = client;
	}

	// Token: 0x0600051F RID: 1311 RVA: 0x0001E830 File Offset: 0x0001CA30
	public void _FMTVFcTfzNRteqoB3XiUkaNps7l(_6lHFncsY9352Wg3pNnnFZ49g5xA questObjId)
	{
		this._Gf5dMMvKN7GRcuWlZy0DgsGYZNl = questObjId._605Ligxeaj9k9kBV8zQhhFhgTGl;
	}

	// Token: 0x06000520 RID: 1312 RVA: 0x0001E84C File Offset: 0x0001CA4C
	public void text(PlayerTextPacket playerText)
	{
		if (!string.IsNullOrEmpty(playerText.Text))
		{
			if (playerText.Text[0] == '/')
			{
				string[] array = playerText.Text.Split(new char[]
				{
					' '
				});
				if (array.Length != 0)
				{
					if (array[0] == "/tp")
					{
						if (!Settings.Default.EnableTeleportToPlayerCommand || Settings.Default.FameBlockTeleports)
						{
							return;
						}
						playerText.Send = false;
						if (array.Length == 1)
						{
							if (Settings.Default.EnableTeleportToSelf)
							{
								this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._RUDdpffUqrc18m4ldj2l3yrb1t9("Teleporting to self!");
								TeleportPacket rvckmor8bw91EVaRfdwc25aHYbc = (TeleportPacket)Packet.Create(PacketType.TELEPORT);
								rvckmor8bw91EVaRfdwc25aHYbc._605Ligxeaj9k9kBV8zQhhFhgTGl = this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player.ObjectId;
								this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.SendToServer(rvckmor8bw91EVaRfdwc25aHYbc);
								return;
							}
						}
						if (array.Length == 2)
						{
							string text = array[1].ToLower();
							foreach (GameObject dbvvb43n9c5uNQ7JklPD1fnCEnv in this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Players.Values)
							{
								if (!dbvvb43n9c5uNQ7JklPD1fnCEnv._DNFzFHWP3TyhP6MrRvhgRAnZOM() && dbvvb43n9c5uNQ7JklPD1fnCEnv._Jp3DtIV4aAYZY26sVsXpPQjBRGO.ToLower().Contains(text))
								{
									this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._RUDdpffUqrc18m4ldj2l3yrb1t9("Teleporting to " + dbvvb43n9c5uNQ7JklPD1fnCEnv._Jp3DtIV4aAYZY26sVsXpPQjBRGO + "!");
									TeleportPacket rvckmor8bw91EVaRfdwc25aHYbc2 = (TeleportPacket)Packet.Create(PacketType.TELEPORT);
									rvckmor8bw91EVaRfdwc25aHYbc2._605Ligxeaj9k9kBV8zQhhFhgTGl = dbvvb43n9c5uNQ7JklPD1fnCEnv.ObjectId;
									this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.SendToServer(rvckmor8bw91EVaRfdwc25aHYbc2);
									return;
								}
							}
							this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._RUDdpffUqrc18m4ldj2l3yrb1t9("Player with the name similar to " + text + " not found!");
							return;
						}
						this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._RUDdpffUqrc18m4ldj2l3yrb1t9("Usage: /tp [partial or full player name]");
						return;
					}
					else if (array[0] == "/tpq")
					{
						if (!Settings.Default.EnableTeleportToPlayerClosestToQuestCommand || Settings.Default.FameBlockTeleports)
						{
							return;
						}
						playerText.Send = false;
						IEnumerable<GameObject> source = this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Enemies.Values.Where(new Func<GameObject, bool>(this._nsYhE8xue6OmDVzj11MotaYEnMN));
						if (!source.Any<GameObject>())
						{
							this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._RUDdpffUqrc18m4ldj2l3yrb1t9("Quest not found!");
							return;
						}
						GameObject dbvvb43n9c5uNQ7JklPD1fnCEnv2 = null;
						double num = 0.0;
						GameObject dbvvb43n9c5uNQ7JklPD1fnCEnv3 = source.First<GameObject>();
						foreach (GameObject dbvvb43n9c5uNQ7JklPD1fnCEnv4 in this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Players.Values)
						{
							if (dbvvb43n9c5uNQ7JklPD1fnCEnv4 != this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player && !dbvvb43n9c5uNQ7JklPD1fnCEnv4._DNFzFHWP3TyhP6MrRvhgRAnZOM() && (dbvvb43n9c5uNQ7JklPD1fnCEnv2 == null || dbvvb43n9c5uNQ7JklPD1fnCEnv4._G6mmnFaa6rCvH24Jwj69ERi78ww.DistanceSquaredTo(dbvvb43n9c5uNQ7JklPD1fnCEnv3._G6mmnFaa6rCvH24Jwj69ERi78ww) < num))
							{
								dbvvb43n9c5uNQ7JklPD1fnCEnv2 = dbvvb43n9c5uNQ7JklPD1fnCEnv4;
								num = dbvvb43n9c5uNQ7JklPD1fnCEnv4._G6mmnFaa6rCvH24Jwj69ERi78ww.DistanceSquaredTo(dbvvb43n9c5uNQ7JklPD1fnCEnv3._G6mmnFaa6rCvH24Jwj69ERi78ww);
							}
						}
						if (dbvvb43n9c5uNQ7JklPD1fnCEnv2 == null)
						{
							this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._RUDdpffUqrc18m4ldj2l3yrb1t9("No players found to teleport to!");
							return;
						}
						this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._RUDdpffUqrc18m4ldj2l3yrb1t9("Teleporting to " + dbvvb43n9c5uNQ7JklPD1fnCEnv2._Jp3DtIV4aAYZY26sVsXpPQjBRGO + "!");
						TeleportPacket rvckmor8bw91EVaRfdwc25aHYbc3 = (TeleportPacket)Packet.Create(PacketType.TELEPORT);
						rvckmor8bw91EVaRfdwc25aHYbc3._605Ligxeaj9k9kBV8zQhhFhgTGl = dbvvb43n9c5uNQ7JklPD1fnCEnv2.ObjectId;
						this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.SendToServer(rvckmor8bw91EVaRfdwc25aHYbc3);
						return;
					}
					else if (array[0] == "/c" || array[0] == "/con" || array[0] == "/connect")
					{
						if (!Settings.Default.EnableConnectCommand)
						{
							return;
						}
						playerText.Send = false;
						if (array.Length != 2)
						{
							this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._RUDdpffUqrc18m4ldj2l3yrb1t9("Usage: /connect [server name]");
						}
						else
						{
							string text2;
							if (!ServerParser._vw3jHhqvDKaEhpR5kZI8dnnJNXB.TryGetValue(array[1].ToLower(), out text2))
							{
								this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._RUDdpffUqrc18m4ldj2l3yrb1t9("Unknown server!");
								return;
							}
							ReconnectPacket u9Kj4tAStSlt3Dcm6rdEl60w8MG = (ReconnectPacket)Packet.Create(PacketType.RECONNECT);
							u9Kj4tAStSlt3Dcm6rdEl60w8MG.GameId = -2;
							u9Kj4tAStSlt3Dcm6rdEl60w8MG.Host = "127.0.0.1";
							u9Kj4tAStSlt3Dcm6rdEl60w8MG.Port = 2050;
							u9Kj4tAStSlt3Dcm6rdEl60w8MG.isFromArena = false;
							u9Kj4tAStSlt3Dcm6rdEl60w8MG.Key = new byte[0];
							u9Kj4tAStSlt3Dcm6rdEl60w8MG.KeyTime = -1;
							u9Kj4tAStSlt3Dcm6rdEl60w8MG.Name = text2 + " Nexus";
							u9Kj4tAStSlt3Dcm6rdEl60w8MG.State = string.Empty;
							Settings.Default.CurrentServer = text2;
							this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._RUDdpffUqrc18m4ldj2l3yrb1t9("Connecting to: " + text2);
							this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.SendToClient(u9Kj4tAStSlt3Dcm6rdEl60w8MG);
							return;
						}
					}
				}
				return;
			}
		}
	}

	// Token: 0x06000521 RID: 1313 RVA: 0x0001ECC8 File Offset: 0x0001CEC8
	[CompilerGenerated]
	private bool _nsYhE8xue6OmDVzj11MotaYEnMN(GameObject enemy)
	{
		return enemy.ObjectId == this._Gf5dMMvKN7GRcuWlZy0DgsGYZNl;
	}

	// Token: 0x0400062C RID: 1580
	private Client _W6Ov6AArxzTTDnCyBtZPqkqNaKf;

	// Token: 0x0400062D RID: 1581
	private int _Gf5dMMvKN7GRcuWlZy0DgsGYZNl = -1;
}
