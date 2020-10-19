using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000043 RID: 67
internal class AoEAckPacket : Packet
{
	// Token: 0x170000DC RID: 220
	// (get) Token: 0x060002E0 RID: 736 RVA: 0x000136CC File Offset: 0x000118CC
	public override PacketType Type
	{
		get
		{
			return PacketType.AOEACK;
		}
	}

	// Token: 0x060002E1 RID: 737 RVA: 0x000136DC File Offset: 0x000118DC
	public override void Read(PacketReader r)
	{
		this.Time = r.ReadInt32();
		this.Pos = new Location(r);
	}

	// Token: 0x060002E2 RID: 738 RVA: 0x00013704 File Offset: 0x00011904
	public override void Write(PacketWriter w)
	{
		w.Write(this.Time);
		this.Pos.Write(w);
	}

	// Token: 0x0400046A RID: 1130
	public int Time;

	// Token: 0x0400046B RID: 1131
	public Location Pos;
}
