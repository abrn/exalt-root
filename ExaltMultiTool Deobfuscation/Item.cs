using System;

// Token: 0x02000030 RID: 48
internal class Item : IDataObject, ICloneable
{
	// Token: 0x0600026A RID: 618 RVA: 0x00011140 File Offset: 0x0000F340
	public Item()
	{
	}

	// Token: 0x0600026B RID: 619 RVA: 0x00011154 File Offset: 0x0000F354
	public Item(PacketReader r)
	{
		this.ItemItem = r.ReadInt32();
		this.SlotType = r.ReadInt32();
		this.isTradeable = r.ReadBoolean();
		this.Included = r.ReadBoolean();
	}

	// Token: 0x0600026C RID: 620 RVA: 0x00011198 File Offset: 0x0000F398
	public IDataObject Read(PacketReader r)
	{
		this.ItemItem = r.ReadInt32();
		this.SlotType = r.ReadInt32();
		this.isTradeable = r.ReadBoolean();
		this.Included = r.ReadBoolean();
		return this;
	}

	// Token: 0x0600026D RID: 621 RVA: 0x000111D8 File Offset: 0x0000F3D8
	public void Write(PacketWriter w)
	{
		w.Write(this.ItemItem);
		w.Write(this.SlotType);
		w.Write(this.isTradeable);
		w.Write(this.Included);
	}

	// Token: 0x0600026E RID: 622 RVA: 0x00011218 File Offset: 0x0000F418
	public object Clone()
	{
		return new Item
		{
			ItemItem = this.ItemItem,
			SlotType = this.SlotType,
			isTradeable = this.isTradeable,
			Included = this.Included
		};
	}

	// Token: 0x0600026F RID: 623 RVA: 0x0001125C File Offset: 0x0000F45C
	public virtual string _Ye7Bzeo9ipi3HJQJeW2fYB88LbJ()
	{
		return string.Concat(new string[]
		{
			"{ ItemItem=",
			this.ItemItem.ToString(),
			", SlotType=",
			this.SlotType.ToString(),
			", Tradable=",
			this.isTradeable.ToString(),
			", Included=",
			this.Included.ToString(),
			" }"
		});
	}

	// Token: 0x0400031F RID: 799
	public int ItemItem;

	// Token: 0x04000320 RID: 800
	public int SlotType;

	// Token: 0x04000321 RID: 801
	public bool isTradeable;

	// Token: 0x04000322 RID: 802
	public bool Included;
}
