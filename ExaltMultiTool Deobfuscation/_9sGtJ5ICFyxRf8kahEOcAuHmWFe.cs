using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x0200003F RID: 63
internal class _9sGtJ5ICFyxRf8kahEOcAuHmWFe : Packet
{
	// Token: 0x170000D8 RID: 216
	// (get) Token: 0x060002D0 RID: 720 RVA: 0x0001342C File Offset: 0x0001162C
	public override PacketType Type
	{
		get
		{
			return PacketType.QUESTFETCHASK;
		}
	}

	// Token: 0x060002D1 RID: 721 RVA: 0x0001343C File Offset: 0x0001163C
	public override void Read(PacketReader r)
	{
	}

	// Token: 0x060002D2 RID: 722 RVA: 0x0001344C File Offset: 0x0001164C
	public override void Write(PacketWriter w)
	{
	}
}
