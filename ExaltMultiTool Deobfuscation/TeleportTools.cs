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
		this.client = client;
	}

	// Token: 0x0600051F RID: 1311 RVA: 0x0001E830 File Offset: 0x0001CA30
	public void QuestObjId(QuestObjIdPacket questObjId)
	{
		this._lastQuest = questObjId.ObjectId;
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
								this.client.SendToClient("Teleporting to self!");
								TeleportPacket teleportPacket = (TeleportPacket)Packet.Create(PacketType.TELEPORT);
								teleportPacket.ObjectId = this.client.Player.ObjectId;
								this.client.SendToServer(teleportPacket);
								return;
							}
						}
						if (array.Length == 2)
						{
							string text = array[1].ToLower();
							foreach (GameObject gameObject in this.client.Players.Values)
							{
								if (!gameObject.isInvisible() && gameObject.Name.ToLower().Contains(text))
								{
									this.client.SendToClient("Teleporting to " + gameObject.Name + "!");
									TeleportPacket teleportPacket = (TeleportPacket)Packet.Create(PacketType.TELEPORT);
									teleportPacket.ObjectId = gameObject.ObjectId;
									this.client.SendToServer(teleportPacket);
									return;
								}
							}
							this.client.SendToClient("Player with the name similar to " + text + " not found!");
							return;
						}
						this.client.SendToClient("Usage: /tp [partial or full player name]");
						return;
					}
					else if (array[0] == "/tpq")
					{
						if (!Settings.Default.EnableTeleportToPlayerClosestToQuestCommand || Settings.Default.FameBlockTeleports)
						{
							return;
						}
						playerText.Send = false;
						IEnumerable<GameObject> source = from enemy in this.client.Enemies.Values
														 where enemy.ObjectId == this._lastQuest
														 select enemy;
						if (!source.Any<GameObject>())
						{
							this.client.SendToClient("Quest not found!");
							return;
						}
						GameObject gameObject2 = null;
						double num = 0.0;
						GameObject gameObject3 = source.First<GameObject>();
						foreach (GameObject gameObject4 in this.client.Players.Values)
						{
							if (gameObject4 != this.client.Player && !gameObject4.isInvisible() && (gameObject2 == null || gameObject4.ClientPosition.DistanceSquaredTo(gameObject3.ClientPosition) < num))
							{
								gameObject2 = gameObject4;
								num = gameObject4.ClientPosition.DistanceSquaredTo(gameObject3.ClientPosition);
							}
						}
						if (gameObject2 == null)
						{
							this.client.SendToClient("No players found to teleport to!");
							return;
						}
						this.client.SendToClient("Teleporting to " + gameObject2.Name + "!");
						TeleportPacket teleportPacket2 = (TeleportPacket)Packet.Create(PacketType.TELEPORT);
						teleportPacket2.ObjectId = gameObject2.ObjectId;
						this.client.SendToServer(teleportPacket2);
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
							this.client.SendToClient("Usage: /connect [server name]");
						}
						else
						{
							string text2;
							if (!ServerParser.ServerAbbreviations.TryGetValue(array[1].ToLower(), out text2))
							{
								this.client.SendToClient("Unknown server!");
								return;
							}
							ReconnectPacket reconnectPacket = (ReconnectPacket)Packet.Create(PacketType.RECONNECT);
							reconnectPacket.GameId = -2;
							reconnectPacket.Host = "127.0.0.1";
							reconnectPacket.Port = 2050;
							reconnectPacket.isFromArena = false;
							reconnectPacket.Key = new byte[0];
							reconnectPacket.KeyTime = -1;
							reconnectPacket.Name = text2 + " Nexus";
							reconnectPacket.State = string.Empty;
							Settings.Default.CurrentServer = text2;
							this.client.SendToClient("Connecting to: " + text2);
							this.client.SendToClient(reconnectPacket);
							return;
						}
					}
				}
				return;
			}
		}
	}


	// Token: 0x0400062C RID: 1580
	private Client client;

	// Token: 0x0400062D RID: 1581
	private int _lastQuest = -1;
}
