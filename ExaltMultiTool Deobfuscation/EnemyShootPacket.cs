using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000079 RID: 121
internal class EnemyShootPacket : Packet
{
	// Token: 0x17000112 RID: 274
	// (get) Token: 0x060003B8 RID: 952 RVA: 0x00015340 File Offset: 0x00013540
	public override PacketType Type
	{
		get
		{
			return PacketType.ENEMYSHOOT;
		}
	}

	// Token: 0x060003B9 RID: 953 RVA: 0x00015350 File Offset: 0x00013550
	public override void Read(PacketReader r)
	{
		this.BulletId = r.ReadByte();
		this.OwnerId = r.ReadInt32();
		this.BulletType = r.ReadByte();
		this.Location = new Location(r);
		this.Angle = r.ReadSingle();
		this.Damage = r.ReadInt16();
		if (r.BaseStream.Position >= r.BaseStream.Length)
		{
			this.NumShots = 1;
			this.AngleInc = 0f;
			return;
		}
		this.NumShots = r.ReadByte();
		this.AngleInc = r.ReadSingle();
	}

	// Token: 0x060003BA RID: 954 RVA: 0x000153E8 File Offset: 0x000135E8
	public override void Write(PacketWriter w)
	{
		w.Write(this.BulletId);
		w.Write(this.OwnerId);
		w.Write(this.BulletType);
		this.Location.Write(w);
		w.Write(this.Angle);
		w.Write(this.Damage);
		if (this.NumShots != 1)
		{
			w.Write(this.NumShots);
			w.Write(this.AngleInc);
		}
	}

	// Token: 0x040004FA RID: 1274
	public byte BulletId;

	// Token: 0x040004FB RID: 1275
	public int OwnerId;

	// Token: 0x040004FC RID: 1276
	public byte BulletType;

	// Token: 0x040004FD RID: 1277
	public Location Location;

	// Token: 0x040004FE RID: 1278
	public float Angle;

	// Token: 0x040004FF RID: 1279
	public short Damage;

	// Token: 0x04000500 RID: 1280
	public byte NumShots;

	// Token: 0x04000501 RID: 1281
	public float AngleInc;
}
