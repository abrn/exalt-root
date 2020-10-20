using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x0200006B RID: 107
internal class UpdateAckPacket : Packet
{
	// Token: 0x17000104 RID: 260
	// (get) Token: 0x06000380 RID: 896 RVA: 0x00014A74 File Offset: 0x00012C74
	public override PacketType Type
	{
		get
		{
			return PacketType.UPDATEACK;
		}
	}

	// Token: 0x06000381 RID: 897 RVA: 0x00014A84 File Offset: 0x00012C84
	public override void Read(PacketReader r)
	{
	}

	// Token: 0x06000382 RID: 898 RVA: 0x00014A94 File Offset: 0x00012C94
	public override void Write(PacketWriter w)
	{
	}
}
