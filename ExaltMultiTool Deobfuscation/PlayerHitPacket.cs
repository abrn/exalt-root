using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000060 RID: 96
internal class PlayerHitPacket : Packet
{
	// Token: 0x170000F9 RID: 249
	// (get) Token: 0x06000354 RID: 852 RVA: 0x00014578 File Offset: 0x00012778
	public override PacketType Type
	{
		get
		{
			return PacketType.PLAYERHIT;
		}
	}

	// Token: 0x06000355 RID: 853 RVA: 0x00014588 File Offset: 0x00012788
	public override void Read(PacketReader r)
	{
		this.BulletId = r.ReadByte();
		this.ObjectId = r.ReadInt32();
	}

	// Token: 0x06000356 RID: 854 RVA: 0x000145B0 File Offset: 0x000127B0
	public override void Write(PacketWriter w)
	{
		w.Write(this.BulletId);
		w.Write(this.ObjectId);
	}

	// Token: 0x040004B3 RID: 1203
	public byte BulletId;

	// Token: 0x040004B4 RID: 1204
	public int ObjectId;
}
