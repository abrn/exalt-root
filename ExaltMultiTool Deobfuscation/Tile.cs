using System;

// Token: 0x0200003B RID: 59
internal class Tile : IDataObject, ICloneable
{
	// Token: 0x060002BE RID: 702 RVA: 0x000130FC File Offset: 0x000112FC
	public Tile()
	{
	}

	// Token: 0x060002BF RID: 703 RVA: 0x00013110 File Offset: 0x00011310
	public Tile(short x, short y, ushort type)
	{
		this.X = x;
		this.Y = y;
		this.Type = type;
	}

	// Token: 0x060002C0 RID: 704 RVA: 0x00013138 File Offset: 0x00011338
	public IDataObject Read(PacketReader r)
	{
		this.X = r.ReadInt16();
		this.Y = r.ReadInt16();
		this.Type = r.ReadUInt16();
		return this;
	}

	// Token: 0x060002C1 RID: 705 RVA: 0x0001316C File Offset: 0x0001136C
	public void Write(PacketWriter w)
	{
		w.Write(this.X);
		w.Write(this.Y);
		w.Write(this.Type);
	}

	// Token: 0x060002C2 RID: 706 RVA: 0x000131A0 File Offset: 0x000113A0
	public object Clone()
	{
		return new Tile(this.X, this.Y, this.Type);
	}

	// Token: 0x060002C3 RID: 707 RVA: 0x000131C4 File Offset: 0x000113C4
	public override string ToString()
	{
		return string.Format("{{ X={0}, Y={1}, Type={2} }}", this.X, this.Y, this.Type);
	}

	// Token: 0x04000453 RID: 1107
	public short X;

	// Token: 0x04000454 RID: 1108
	public short Y;

	// Token: 0x04000455 RID: 1109
	public ushort Type;
}
