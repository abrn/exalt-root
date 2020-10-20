using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x0200004F RID: 79
internal class EnterArenaPacket : Packet
{
	// Token: 0x170000E8 RID: 232
	// (get) Token: 0x06000310 RID: 784 RVA: 0x00013C38 File Offset: 0x00011E38
	public override PacketType Type
	{
		get
		{
			return PacketType.ENTERARENA;
		}
	}

	// Token: 0x06000311 RID: 785 RVA: 0x00013C48 File Offset: 0x00011E48
	public override void Read(PacketReader r)
	{
		this.Currency = r.ReadInt32();
	}

	// Token: 0x06000312 RID: 786 RVA: 0x00013C64 File Offset: 0x00011E64
	public override void Write(PacketWriter w)
	{
		w.Write(this.Currency);
	}

	// Token: 0x0400047F RID: 1151
	public int Currency;
}
