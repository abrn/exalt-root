using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000046 RID: 70
internal class ChangeGuildRankPacket : Packet
{
	// Token: 0x170000DF RID: 223
	// (get) Token: 0x060002EC RID: 748 RVA: 0x000137F8 File Offset: 0x000119F8
	public override PacketType Type
	{
		get
		{
			return PacketType.CHANGEGUILDRANK;
		}
	}

	// Token: 0x060002ED RID: 749 RVA: 0x00013808 File Offset: 0x00011A08
	public override void Read(PacketReader r)
	{
		this.Name = r.ReadString();
		this.GuildRank = r.ReadInt32();
	}

	// Token: 0x060002EE RID: 750 RVA: 0x00013830 File Offset: 0x00011A30
	public override void Write(PacketWriter w)
	{
		w.Write(this.Name);
		w.Write(this.GuildRank);
	}

	// Token: 0x0400046E RID: 1134
	public string Name;

	// Token: 0x0400046F RID: 1135
	public int GuildRank;
}
