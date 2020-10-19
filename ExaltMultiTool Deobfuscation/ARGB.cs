using System;
using System.Drawing;
using System.IO;

// Token: 0x02000015 RID: 21
internal struct ARGB
{
	// Token: 0x0600013F RID: 319 RVA: 0x0000CB3C File Offset: 0x0000AD3C
	public ARGB(uint argb)
	{
		this.A = (byte)((argb & 4278190080u) >> 24);
		this.R = (byte)((argb & 16711680u) >> 16);
		this.G = (byte)((argb & 65280u) >> 8);
		this.B = (byte)(argb & 255u);
	}

	// Token: 0x06000140 RID: 320 RVA: 0x0000CB8C File Offset: 0x0000AD8C
	public ARGB(byte a, byte r, byte g, byte b)
	{
		this.A = a;
		this.R = r;
		this.G = g;
		this.B = b;
	}

	// Token: 0x06000141 RID: 321 RVA: 0x0000CBB8 File Offset: 0x0000ADB8
	public static ARGB Read(PacketReader r)
	{
		return new ARGB
		{
			A = r.ReadByte(),
			R = r.ReadByte(),
			G = r.ReadByte(),
			B = r.ReadByte()
		};
	}

	// Token: 0x06000142 RID: 322 RVA: 0x0000CC04 File Offset: 0x0000AE04
	public void Write(PacketWriter w)
	{
		w.Write(this.A);
		w.Write(this.R);
		w.Write(this.G);
		w.Write(this.B);
	}

	// Token: 0x06000143 RID: 323 RVA: 0x0000CC44 File Offset: 0x0000AE44
	public void Write(BinaryWriter w)
	{
		w.Write(this.A);
		w.Write(this.R);
		w.Write(this.G);
		w.Write(this.B);
	}

	// Token: 0x06000144 RID: 324 RVA: 0x0000CC84 File Offset: 0x0000AE84
	public override string ToString()
	{
		return Color.FromArgb((int)this.A, (int)this.R, (int)this.G, (int)this.B).Name;
	}

	// Token: 0x040001D8 RID: 472
	public byte A;

	// Token: 0x040001D9 RID: 473
	public byte B;

	// Token: 0x040001DA RID: 474
	public byte G;

	// Token: 0x040001DB RID: 475
	public byte R;
}
