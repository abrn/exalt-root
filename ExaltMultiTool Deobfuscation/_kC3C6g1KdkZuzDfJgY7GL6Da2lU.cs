using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000048 RID: 72
internal class _kC3C6g1KdkZuzDfJgY7GL6Da2lU : Packet
{
	// Token: 0x170000E1 RID: 225
	// (get) Token: 0x060002F4 RID: 756 RVA: 0x0001390C File Offset: 0x00011B0C
	public override PacketType Type
	{
		get
		{
			return PacketType.CHECKCREDITS;
		}
	}

	// Token: 0x060002F5 RID: 757 RVA: 0x0001391C File Offset: 0x00011B1C
	public override void Read(PacketReader r)
	{
	}

	// Token: 0x060002F6 RID: 758 RVA: 0x0001392C File Offset: 0x00011B2C
	public override void Write(PacketWriter w)
	{
	}
}
