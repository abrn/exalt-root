using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x0200005D RID: 93
internal class ClaimLoginRewardResponse : Packet
{
	// Token: 0x170000F6 RID: 246
	// (get) Token: 0x06000348 RID: 840 RVA: 0x00014360 File Offset: 0x00012560
	public override PacketType Type
	{
		get
		{
			return PacketType.LOGINREWARDMSG;
		}
	}

	// Token: 0x06000349 RID: 841 RVA: 0x00014370 File Offset: 0x00012570
	public override void Read(PacketReader r)
	{
		this.ItemId = r.ReadInt32();
		this.Quantity = r.ReadInt32();
		this.Gold = r.ReadInt32();
	}

	// Token: 0x0600034A RID: 842 RVA: 0x000143A4 File Offset: 0x000125A4
	public override void Write(PacketWriter w)
	{
		w.Write(this.ItemId);
		w.Write(this.Quantity);
		w.Write(this.Gold);
	}

	// Token: 0x040004A2 RID: 1186
	public int ItemId;

	// Token: 0x040004A3 RID: 1187
	public int Quantity;

	// Token: 0x040004A4 RID: 1188
	public int Gold;
}
