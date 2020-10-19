using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x020000A1 RID: 161
internal class PetyardUpgradePacket : Packet
{
	// Token: 0x17000139 RID: 313
	// (get) Token: 0x0600045C RID: 1116 RVA: 0x0001729C File Offset: 0x0001549C
	public override PacketType Type
	{
		get
		{
			return PacketType.PETYARDUPDATE;
		}
	}

	// Token: 0x0600045D RID: 1117 RVA: 0x000172AC File Offset: 0x000154AC
	public override void Read(PacketReader r)
	{
		this.TypeId = r.ReadInt32();
	}

	// Token: 0x0600045E RID: 1118 RVA: 0x000172C8 File Offset: 0x000154C8
	public override void Write(PacketWriter w)
	{
		w.Write(this.TypeId);
	}

	// Token: 0x0400058A RID: 1418
	public int TypeId;
}
