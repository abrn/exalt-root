using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000051 RID: 81
internal class GotoAckPacket : Packet
{
	// Token: 0x170000EA RID: 234
	// (get) Token: 0x06000318 RID: 792 RVA: 0x00013CD8 File Offset: 0x00011ED8
	public override PacketType Type
	{
		get
		{
			return PacketType.GOTOACK;
		}
	}

	// Token: 0x06000319 RID: 793 RVA: 0x00013CE8 File Offset: 0x00011EE8
	public override void Read(PacketReader r)
	{
		this.Time = r.ReadInt32();
	}

	// Token: 0x0600031A RID: 794 RVA: 0x00013D04 File Offset: 0x00011F04
	public override void Write(PacketWriter w)
	{
		w.Write(this.Time);
	}

	// Token: 0x04000480 RID: 1152
	public int Time;
}
