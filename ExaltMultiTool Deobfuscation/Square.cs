using System;
using ExaltMultiTool.Proxy.DataStructures;

// Token: 0x02000025 RID: 37
internal class Square
{
	// Token: 0x06000223 RID: 547 RVA: 0x0000F66C File Offset: 0x0000D86C
	public Square(TileStructure tile, short x, short y, ushort type)
	{
		this.Tile = tile;
		this.X = x;
		this.Y = y;
		this.Type = type;
	}

	// Token: 0x04000276 RID: 630
	public TileStructure Tile;

	// Token: 0x04000277 RID: 631
	public short X;

	// Token: 0x04000278 RID: 632
	public short Y;

	// Token: 0x04000279 RID: 633
	public ushort Type;
}
