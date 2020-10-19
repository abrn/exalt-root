using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x020000A2 RID: 162
internal class VerifyMailDialogPacket : Packet
{
	// Token: 0x1700013A RID: 314
	// (get) Token: 0x06000460 RID: 1120 RVA: 0x000172F8 File Offset: 0x000154F8
	public override PacketType Type
	{
		get
		{
			return PacketType.VERIFYEMAIL;
		}
	}

	// Token: 0x06000461 RID: 1121 RVA: 0x00017308 File Offset: 0x00015508
	public override void Read(PacketReader r)
	{
	}

	// Token: 0x06000462 RID: 1122 RVA: 0x00017318 File Offset: 0x00015518
	public override void Write(PacketWriter w)
	{
	}
}
