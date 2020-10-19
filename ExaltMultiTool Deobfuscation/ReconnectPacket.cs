using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000092 RID: 146
internal class ReconnectPacket : Packet
{
	// Token: 0x1700012B RID: 299
	// (get) Token: 0x0600041E RID: 1054 RVA: 0x000162F0 File Offset: 0x000144F0
	public override PacketType Type
	{
		get
		{
			return PacketType.RECONNECT;
		}
	}

	// Token: 0x0600041F RID: 1055 RVA: 0x00016300 File Offset: 0x00014500
	public override void Read(PacketReader r)
	{
		this.Name = r.ReadString();
		this.Host = r.ReadString();
		this.State = r.ReadString();
		this.Port = r.ReadInt32();
		this.GameId = r.ReadInt32();
		this.KeyTime = r.ReadInt32();
		this.isFromArena = r.ReadBoolean();
		this.Key = r.ReadBytes((int)r.ReadInt16());
	}

	// Token: 0x06000420 RID: 1056 RVA: 0x00016374 File Offset: 0x00014574
	public override void Write(PacketWriter w)
	{
		w.Write(this.Name);
		w.Write(this.Host);
		w.Write(this.State);
		w.Write(this.Port);
		w.Write(this.GameId);
		w.Write(this.KeyTime);
		w.Write(this.isFromArena);
		w.Write((short)this.Key.Length);
		w.Write(this.Key);
	}

	// Token: 0x04000544 RID: 1348
	public string Name;

	// Token: 0x04000545 RID: 1349
	public string Host;

	// Token: 0x04000546 RID: 1350
	public string State;

	// Token: 0x04000547 RID: 1351
	public int Port;

	// Token: 0x04000548 RID: 1352
	public int GameId;

	// Token: 0x04000549 RID: 1353
	public int KeyTime;

	// Token: 0x0400054A RID: 1354
	public bool isFromArena;

	// Token: 0x0400054B RID: 1355
	public byte[] Key;
}
