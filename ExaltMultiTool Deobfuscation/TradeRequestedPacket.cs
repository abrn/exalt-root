using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x0200009B RID: 155
internal class TradeRequestedPacket : Packet
{
	// Token: 0x17000134 RID: 308
	// (get) Token: 0x06000445 RID: 1093 RVA: 0x00016CE0 File Offset: 0x00014EE0
	public override PacketType Type
	{
		get
		{
			return PacketType.TRADEREQUESTED;
		}
	}

	// Token: 0x06000446 RID: 1094 RVA: 0x00016CF0 File Offset: 0x00014EF0
	public override void Read(PacketReader r)
	{
		this.Name = r.ReadString();
	}

	// Token: 0x06000447 RID: 1095 RVA: 0x00016D0C File Offset: 0x00014F0C
	public override void Write(PacketWriter w)
	{
		w.Write(this.Name);
	}

	// Token: 0x04000575 RID: 1397
	public string Name;
}
