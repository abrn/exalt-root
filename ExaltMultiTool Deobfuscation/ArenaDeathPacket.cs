using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000071 RID: 113
internal class ArenaDeathPacket : Packet
{
	// Token: 0x1700010A RID: 266
	// (get) Token: 0x06000398 RID: 920 RVA: 0x00014E48 File Offset: 0x00013048
	public override PacketType Type
	{
		get
		{
			return PacketType.ARENADEATH;
		}
	}

	// Token: 0x06000399 RID: 921 RVA: 0x00014E58 File Offset: 0x00013058
	public override void Read(PacketReader r)
	{
		this.RestartPrice = r.ReadInt32();
	}

	// Token: 0x0600039A RID: 922 RVA: 0x00014E74 File Offset: 0x00013074
	public override void Write(PacketWriter w)
	{
		w.Write(this.RestartPrice);
	}

	// Token: 0x040004DE RID: 1246
	public int RestartPrice;
}
