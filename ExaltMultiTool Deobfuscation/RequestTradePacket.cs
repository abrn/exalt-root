using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000064 RID: 100
internal class RequestTradePacket : Packet
{
	// Token: 0x170000FD RID: 253
	// (get) Token: 0x06000364 RID: 868 RVA: 0x000147C0 File Offset: 0x000129C0
	public override PacketType Type
	{
		get
		{
			return PacketType.REQUESTTRADE;
		}
	}

	// Token: 0x06000365 RID: 869 RVA: 0x000147D0 File Offset: 0x000129D0
	public override void Read(PacketReader r)
	{
		this.Name = r.ReadString();
	}

	// Token: 0x06000366 RID: 870 RVA: 0x000147EC File Offset: 0x000129EC
	public override void Write(PacketWriter w)
	{
		w.Write(this.Name);
	}

	// Token: 0x040004C0 RID: 1216
	public string Name;
}
