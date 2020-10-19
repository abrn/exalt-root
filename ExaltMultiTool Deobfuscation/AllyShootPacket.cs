using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x0200006F RID: 111
internal class AllyShootPacket : Packet
{
	// Token: 0x17000108 RID: 264
	// (get) Token: 0x06000390 RID: 912 RVA: 0x00014C88 File Offset: 0x00012E88
	public override PacketType Type
	{
		get
		{
			return PacketType.ALLYSHOOT;
		}
	}

	// Token: 0x06000391 RID: 913 RVA: 0x00014C98 File Offset: 0x00012E98
	public override void Read(PacketReader r)
	{
		this.BulletId = r.ReadByte();
		this.OwnerId = r.ReadInt32();
		this.ContainerType = r.ReadInt16();
		this.Angle = r.ReadSingle();
		this.Bard = r.ReadBoolean();
	}

	// Token: 0x06000392 RID: 914 RVA: 0x00014CE4 File Offset: 0x00012EE4
	public override void Write(PacketWriter w)
	{
		w.Write(this.BulletId);
		w.Write(this.OwnerId);
		w.Write(this.ContainerType);
		w.Write(this.Angle);
		w.Write(this.Bard);
	}

	// Token: 0x040004D1 RID: 1233
	public byte BulletId;

	// Token: 0x040004D2 RID: 1234
	public int OwnerId;

	// Token: 0x040004D3 RID: 1235
	public short ContainerType;

	// Token: 0x040004D4 RID: 1236
	public float Angle;

	// Token: 0x040004D5 RID: 1237
	public bool Bard;
}
