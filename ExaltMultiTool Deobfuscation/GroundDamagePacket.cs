using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000053 RID: 83
internal class GroundDamagePacket : Packet
{
	// Token: 0x170000EC RID: 236
	// (get) Token: 0x06000320 RID: 800 RVA: 0x00013D78 File Offset: 0x00011F78
	public override PacketType Type
	{
		get
		{
			return PacketType.GROUNDDAMAGE;
		}
	}

	// Token: 0x06000321 RID: 801 RVA: 0x00013D88 File Offset: 0x00011F88
	public override void Read(PacketReader r)
	{
		this.Time = r.ReadInt32();
		this.Position = new Location(r);
	}

	// Token: 0x06000322 RID: 802 RVA: 0x00013DB0 File Offset: 0x00011FB0
	public override void Write(PacketWriter w)
	{
		w.Write(this.Time);
		this.Position.Write(w);
	}

	// Token: 0x04000481 RID: 1153
	public int Time;

	// Token: 0x04000482 RID: 1154
	public Location Position;
}
