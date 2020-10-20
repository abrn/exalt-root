using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using ExaltMultiTool.Proxy.DataStructures;

// Token: 0x0200001C RID: 28
internal static class GameData
{
	// Token: 0x06000150 RID: 336 RVA: 0x0000CE3C File Offset: 0x0000B03C
	public static Task Load()
	{
		GameData.< Load > d__7 < Load > d__;
			< Load > d__.<> t__builder = AsyncTaskMethodBuilder.Create();
			< Load > d__.<> 1__state = -1;
			< Load > d__.<> t__builder.Start < GameData.< Load > d__7 > (ref < Load > d__);
		return < Load > d__.<> t__builder.Task;
	}

	// Token: 0x04000212 RID: 530
	public static GameDataMap<ushort, /*ItemStucture*/ItemStructure> Items;

	// Token: 0x04000213 RID: 531
	public static GameDataMap<ushort, TileStructure> Tiles;

	// Token: 0x04000214 RID: 532
	public static GameDataMap<ushort, ObjectStructure> Objects;

	// Token: 0x04000215 RID: 533
	public static GameDataMap<byte, PacketStructure> Packets;

	// Token: 0x04000216 RID: 534
	private const string PACKETS = "https://realmstock.network/Public/PacketsExalt";

	// Token: 0x04000217 RID: 535
	private const string TILES = "https://static.drips.pw/rotmg/production/current/xmlc/GroundTypes.xml";

	// Token: 0x04000218 RID: 536
	private const string OBJECTS = "https://static.drips.pw/rotmg/production/current/xmlc/Objects.xml";
}
