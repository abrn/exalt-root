using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000044 RID: 68
internal class BuyPacket : Packet
{
	// Token: 0x170000DD RID: 221
	// (get) Token: 0x060002E4 RID: 740 RVA: 0x00013740 File Offset: 0x00011940
	public override PacketType Type
	{
		get
		{
			return PacketType.BUY;
		}
	}

	// Token: 0x060002E5 RID: 741 RVA: 0x00013750 File Offset: 0x00011950
	public override void Read(PacketReader r)
	{
		this.ObjectId = r.ReadInt32();
		this.Quantity = r.ReadInt32();
	}

	// Token: 0x060002E6 RID: 742 RVA: 0x00013778 File Offset: 0x00011978
	public override void Write(PacketWriter w)
	{
		w.Write(this.ObjectId);
		w.Write(this.Quantity);
	}

	// Token: 0x0400046C RID: 1132
	public int ObjectId;

	// Token: 0x0400046D RID: 1133
	public int Quantity;
}
