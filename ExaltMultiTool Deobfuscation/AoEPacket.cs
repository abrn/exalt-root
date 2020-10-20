using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000070 RID: 112
internal class AoEPacket : Packet
{
	// Token: 0x17000109 RID: 265
	// (get) Token: 0x06000394 RID: 916 RVA: 0x00014D44 File Offset: 0x00012F44
	public override PacketType Type
	{
		get
		{
			return PacketType.AOE;
		}
	}

	// Token: 0x06000395 RID: 917 RVA: 0x00014D54 File Offset: 0x00012F54
	public override void Read(PacketReader r)
	{
		this.Location = new Location(r);
		this.Radius = r.ReadSingle();
		this.Damage = r.ReadUInt16();
		this.Effects = (ConditionEffectIndex)r.ReadByte();
		this.EffectDuration = r.ReadSingle();
		this.OriginType = r.ReadUInt16();
		this.Color = r.ReadInt32();
		this.ArmorPierce = r.ReadBoolean();
	}

	// Token: 0x06000396 RID: 918 RVA: 0x00014DC4 File Offset: 0x00012FC4
	public override void Write(PacketWriter w)
	{
		this.Location.Write(w);
		w.Write(this.Radius);
		w.Write(this.Damage);
		w.Write((byte)this.Effects);
		w.Write(this.EffectDuration);
		w.Write(this.OriginType);
		w.Write(this.Color);
		w.Write(this.ArmorPierce);
	}

	// Token: 0x040004D6 RID: 1238
	public Location Location;

	// Token: 0x040004D7 RID: 1239
	public float Radius;

	// Token: 0x040004D8 RID: 1240
	public ushort Damage;

	// Token: 0x040004D9 RID: 1241
	public ConditionEffectIndex Effects;

	// Token: 0x040004DA RID: 1242
	public float EffectDuration;

	// Token: 0x040004DB RID: 1243
	public ushort OriginType;

	// Token: 0x040004DC RID: 1244
	public int Color;

	// Token: 0x040004DD RID: 1245
	public bool ArmorPierce;
}
