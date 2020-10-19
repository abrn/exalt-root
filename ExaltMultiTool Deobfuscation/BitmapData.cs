using System;

// Token: 0x0200002C RID: 44
internal class BitmapData : IDataObject, ICloneable
{
	// Token: 0x0600025C RID: 604 RVA: 0x00010E7C File Offset: 0x0000F07C
	public IDataObject Read(PacketReader r)
	{
		this.Width = r.ReadInt32();
		this.Height = r.ReadInt32();
		this.Bytes = new byte[this.Width * this.Height * 4];
		this.Bytes = r.ReadBytes(this.Bytes.Length);
		return this;
	}

	// Token: 0x0600025D RID: 605 RVA: 0x00010ED0 File Offset: 0x0000F0D0
	public void Write(PacketWriter w)
	{
		w.Write(this.Width);
		w.Write(this.Height);
		w.Write(this.Bytes);
	}

	// Token: 0x0600025E RID: 606 RVA: 0x00010F04 File Offset: 0x0000F104
	public object Clone()
	{
		byte[] array = new byte[this.Width * this.Height * 4];
		Array.Copy(this.Bytes, array, this.Bytes.Length);
		return new BitmapData
		{
			Width = this.Width,
			Height = this.Height,
			Bytes = array
		};
	}

	// Token: 0x0600025F RID: 607 RVA: 0x00010F60 File Offset: 0x0000F160
	public override string ToString()
	{
		return string.Concat(new string[]
		{
			"{ Width=",
			this.Width.ToString(),
			", Height=",
			this.Height.ToString(),
			" }"
		});
	}

	// Token: 0x0400031A RID: 794
	public int Width;

	// Token: 0x0400031B RID: 795
	public int Height;

	// Token: 0x0400031C RID: 796
	public byte[] Bytes = new byte[0];
}
