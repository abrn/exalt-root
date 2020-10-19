using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000052 RID: 82
internal class QuestRoomMsgPacket : Packet
{
	// Token: 0x170000EB RID: 235
	// (get) Token: 0x0600031C RID: 796 RVA: 0x00013D34 File Offset: 0x00011F34
	public override PacketType Type
	{
		get
		{
			return PacketType.QUESTROOMMSG;
		}
	}

	// Token: 0x0600031D RID: 797 RVA: 0x00013D44 File Offset: 0x00011F44
	public override void Read(PacketReader r)
	{
	}

	// Token: 0x0600031E RID: 798 RVA: 0x00013D54 File Offset: 0x00011F54
	public override void Write(PacketWriter w)
	{
	}
}
