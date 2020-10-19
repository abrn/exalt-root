using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000045 RID: 69
internal class _1CIg3wzYCcg5uacCpPXB4tLVCKe : Packet
{
	// Token: 0x170000DE RID: 222
	// (get) Token: 0x060002E8 RID: 744 RVA: 0x000137B4 File Offset: 0x000119B4
	public override PacketType Type
	{
		get
		{
			return PacketType.CANCELTRADE;
		}
	}

	// Token: 0x060002E9 RID: 745 RVA: 0x000137C4 File Offset: 0x000119C4
	public override void Read(PacketReader r)
	{
	}

	// Token: 0x060002EA RID: 746 RVA: 0x000137D4 File Offset: 0x000119D4
	public override void Write(PacketWriter w)
	{
	}
}
