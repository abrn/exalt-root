using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000050 RID: 80
internal class EscapePacket : Packet
{
	// Token: 0x170000E9 RID: 233
	// (get) Token: 0x06000314 RID: 788 RVA: 0x00013C94 File Offset: 0x00011E94
	public override PacketType Type
	{
		get
		{
			return PacketType.ESCAPE;
		}
	}

	// Token: 0x06000315 RID: 789 RVA: 0x00013CA4 File Offset: 0x00011EA4
	public override void Read(PacketReader r)
	{
	}

	// Token: 0x06000316 RID: 790 RVA: 0x00013CB4 File Offset: 0x00011EB4
	public override void Write(PacketWriter w)
	{
	}
}
