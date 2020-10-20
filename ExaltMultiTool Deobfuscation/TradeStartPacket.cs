using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x0200009C RID: 156
internal class TradeStartPacket : Packet
{
	// Token: 0x17000135 RID: 309
	// (get) Token: 0x06000449 RID: 1097 RVA: 0x00016D3C File Offset: 0x00014F3C
	public override PacketType Type
	{
		get
		{
			return PacketType.TRADESTART;
		}
	}

	// Token: 0x0600044A RID: 1098 RVA: 0x00016D4C File Offset: 0x00014F4C
	public override void Read(PacketReader r)
	{
		this.MyItems = new Item[(int)r.ReadInt16()];
		for (int i = 0; i < this.MyItems.Length; i++)
		{
			this.MyItems[i] = new Item(r);
		}
		this.YourName = r.ReadString();
		this.YourItems = new Item[(int)r.ReadInt16()];
		for (int j = 0; j < this.YourItems.Length; j++)
		{
			this.YourItems[j] = new Item(r);
		}
		this.PartnerObjectId = r.ReadInt32();
	}

	// Token: 0x0600044B RID: 1099 RVA: 0x00016DD8 File Offset: 0x00014FD8
	public override void Write(PacketWriter w)
	{
		w.Write((ushort)this.MyItems.Length);
		Item[] array = this.MyItems;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].Write(w);
		}
		w.Write(this.YourName);
		w.Write((ushort)this.YourItems.Length);
		array = this.YourItems;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].Write(w);
		}
		w.Write(this.PartnerObjectId);
	}

	// Token: 0x04000576 RID: 1398
	public Item[] MyItems;

	// Token: 0x04000577 RID: 1399
	public string YourName;

	// Token: 0x04000578 RID: 1400
	public Item[] YourItems;

	// Token: 0x04000579 RID: 1401
	public int PartnerObjectId;
}
