using System;

// Token: 0x0200002E RID: 46
internal class Entity : IDataObject, ICloneable
{
	// Token: 0x06000264 RID: 612 RVA: 0x0001109C File Offset: 0x0000F29C
	public IDataObject Read(PacketReader r)
	{
		this.ObjectType = r.ReadUInt16();
		this.Status.Read(r);
		return this;
	}

	// Token: 0x06000265 RID: 613 RVA: 0x000110C4 File Offset: 0x0000F2C4
	public void Write(PacketWriter w)
	{
		w.Write(this.ObjectType);
		this.Status.Write(w);
	}

	// Token: 0x06000266 RID: 614 RVA: 0x000110EC File Offset: 0x0000F2EC
	public object Clone()
	{
		return new Entity
		{
			ObjectType = this.ObjectType,
			Status = (Status)this.Status.Clone()
		};
	}

	// Token: 0x0400031D RID: 797
	public ushort ObjectType;

	// Token: 0x0400031E RID: 798
	public Status Status = new Status();

    public object Objects { get; internal set; }
}
