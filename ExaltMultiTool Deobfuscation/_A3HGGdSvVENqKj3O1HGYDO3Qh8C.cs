using System;

// Token: 0x02000036 RID: 54
internal class SlotObject : IDataObject, ICloneable
{
	// Token: 0x0600029D RID: 669 RVA: 0x000125AC File Offset: 0x000107AC
	public SlotObject()
	{
	}

	// Token: 0x0600029E RID: 670 RVA: 0x000125C0 File Offset: 0x000107C0
	public SlotObject(int objectId, int slotId, int objectType)
	{
		this.objectId = objectId;
		this.SlotId = slotId;
		this.ObjectType = objectType;
	}

	// Token: 0x0600029F RID: 671 RVA: 0x000125E8 File Offset: 0x000107E8
	public SlotObject(PacketReader r)
	{
		this.objectId = r.ReadInt32();
		this.SlotId = r.ReadInt32();
		this.ObjectType = r.ReadInt32();
	}

	// Token: 0x060002A0 RID: 672 RVA: 0x00012620 File Offset: 0x00010820
	public IDataObject Read(PacketReader r)
	{
		this.objectId = r.ReadInt32();
		this.SlotId = r.ReadInt32();
		this.ObjectType = r.ReadInt32();
		return this;
	}

	// Token: 0x060002A1 RID: 673 RVA: 0x00012654 File Offset: 0x00010854
	public void Write(PacketWriter w)
	{
		w.Write(this.objectId);
		w.Write(this.SlotId);
		w.Write(this.ObjectType);
	}

	// Token: 0x060002A2 RID: 674 RVA: 0x00012688 File Offset: 0x00010888
	public object Clone()
	{
		return new SlotObject
		{
			objectId = this.objectId,
			ObjectType = this.ObjectType,
			SlotId = this.SlotId
		};
	}

	// Token: 0x060002A3 RID: 675 RVA: 0x000126C0 File Offset: 0x000108C0
	public virtual string _Ye7Bzeo9ipi3HJQJeW2fYB88LbJ()
	{
		return string.Format("{{ ObjectId={0}, SlotId={1}, ObjectType={2} }}", this.objectId, this.SlotId, this.ObjectType);
	}

	// Token: 0x04000366 RID: 870
	public int objectId;

	// Token: 0x04000367 RID: 871
	public int SlotId;

	// Token: 0x04000368 RID: 872
	public int ObjectType;
}
