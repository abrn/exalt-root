using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000061 RID: 97
internal class PlayerShootPacket : Packet
{
	// Token: 0x170000FA RID: 250
	// (get) Token: 0x06000358 RID: 856 RVA: 0x000145EC File Offset: 0x000127EC
	public override PacketType Type
	{
		get
		{
			return PacketType.PLAYERSHOOT;
		}
	}

	// Token: 0x06000359 RID: 857 RVA: 0x000145FC File Offset: 0x000127FC
	public override void Read(PacketReader r)
	{
		this.Time = r.ReadInt32();
		this.BulletId = r.ReadByte();
		this.ContainerType = r.ReadInt16();
		this.Position = new Location(r);
		this.Angle = r.ReadSingle();
		this.SpeedMult = r.ReadInt16();
		this.LifeMult = r.ReadInt16();
		this.Unk = r.ReadByte();
	}

	// Token: 0x0600035A RID: 858 RVA: 0x0001466C File Offset: 0x0001286C
	public override void Write(PacketWriter w)
	{
		w.Write(this.Time);
		w.Write(this.BulletId);
		w.Write(this.ContainerType);
		this.Position.Write(w);
		w.Write(this.Angle);
		w.Write(this.SpeedMult);
		w.Write(this.LifeMult);
		w.Write(this.Unk);
	}

	// Token: 0x040004B5 RID: 1205
	public int Time;

	// Token: 0x040004B6 RID: 1206
	public byte BulletId;

	// Token: 0x040004B7 RID: 1207
	public short ContainerType;

	// Token: 0x040004B8 RID: 1208
	public Location Position;

	// Token: 0x040004B9 RID: 1209
	public float Angle;

	// Token: 0x040004BA RID: 1210
	public short SpeedMult;

	// Token: 0x040004BB RID: 1211
	public short LifeMult;

	// Token: 0x040004BC RID: 1212
	public byte Unk;
}
