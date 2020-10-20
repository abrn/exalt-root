using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Resources;
using System.Runtime.CompilerServices;
using ExaltMultiTool.Properties;

// Token: 0x020000B6 RID: 182
internal class MapHack
{
	// Token: 0x060004F0 RID: 1264 RVA: 0x0001CAF4 File Offset: 0x0001ACF4
	static MapHack()
	{
		MapHack.ParseMapFiles();
	}

	// Token: 0x060004F1 RID: 1265 RVA: 0x0001CB28 File Offset: 0x0001AD28
	public MapHack(Client client)
	{
		this.client = client;
	}

	// Token: 0x060004F2 RID: 1266 RVA: 0x0001CB50 File Offset: 0x0001AD50
	private static void ParseMapFiles()
	{
		if (MapHack._maps != null)
		{
			return;
		}
		Dictionary<string, Tile[]> dictionary = new Dictionary<string, Tile[]>();
		foreach (object obj in new ResourceManager(typeof(Resources)).GetResourceSet(CultureInfo.CurrentUICulture, true, true))
		{
			DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
			string text = dictionaryEntry.Key.ToString();
			if (text.StartsWith("map_"))
			{
				byte[] array = dictionaryEntry.Value as byte[];
				if (array != null)
				{
					using (MemoryStream memoryStream = new MemoryStream(MapHack.Unzip(array)))
					{
						BinaryReader binaryReader = new BinaryReader(memoryStream);
						List<Tile> list = new List<Tile>();
						while (binaryReader.BaseStream.Position != binaryReader.BaseStream.Length)
						{
							ushort type = binaryReader.ReadUInt16();
							int num = binaryReader.ReadInt32();
							for (int i = 0; i < num; i++)
							{
								byte[] array2 = binaryReader.ReadBytes(3);
								if (array2.Length == 3)
								{
									MapHack.ShortPos shortPos = MapHack.ShortPos.Decompress(array2);
									list.Add(new Tile(shortPos.X, shortPos.Y, type));
								}
							}
						}
						dictionary.Add(text.Replace('_', ' '), list.ToArray());
					}
				}
			}
		}
		MapHack._maps = new Dictionary<string, Tile[]>(dictionary.Count);
		MapHack._realms = new Dictionary<byte, Dictionary<MapHack.ShortPos, ushort>>();
		foreach (KeyValuePair<string, Tile[]> keyValuePair in dictionary)
		{
			if (keyValuePair.Key.StartsWith("Realm of the Mad God World ") && keyValuePair.Key.EndsWith(" sand"))
			{
				string text2 = keyValuePair.Key.Substring(27);
				byte key = byte.Parse(text2.Substring(0, (text2[1] != ' ') ? 2 : 1));
				Dictionary<MapHack.ShortPos, ushort> value = keyValuePair.Value.ToDictionary((Tile tile) => new MapHack.ShortPos(tile.X, tile.Y), (Tile tile) => tile.Type);
				MapHack._realms.Add(key, value);
			}
			else
			{
				Tile[] value2 = keyValuePair.Value.ToArray<Tile>();
				string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(keyValuePair.Key);
				MapHack._maps.Add(fileNameWithoutExtension, value2);
			}
		}
	}

	// Token: 0x060004F3 RID: 1267 RVA: 0x0001CE34 File Offset: 0x0001B034
	public void MapInfo(MapInfoPacket mapInfo)
	{
		this._index = 0;
		if (MapHack._maps != null)
		{
			this._needsNewTiles = (this._needsScan = (mapInfo.Name == "Realm of the Mad God"));
			foreach (KeyValuePair<string, Tile[]> keyValuePair in MapHack._maps)
			{
				if (keyValuePair.Key == mapInfo.Name)
				{
					this._mapToReplace = keyValuePair.Value;
					this._needsNewTiles = true;
					this._needsScan = false;
					break;
				}
			}
			this._fp = mapInfo.Fp.ToString();
			if (mapInfo.Name == "Realm of the Mad God")
			{
				if (MapHack._fpMap.ContainsKey(this._fp))
				{
					Console.WriteLine(string.Format("Using map {0} {1}", this._fp, MapHack._fpMap[this._fp]));
					this._mapToReplace = MapHack._maps[string.Format("Realm of the Mad God World {0}", MapHack._fpMap[this._fp])];
					this._needsNewTiles = true;
					this._needsScan = false;
					return;
				}
				this._realmTiles = new List<Tile>();
				this._mapScores = new Dictionary<int, int>();
				foreach (KeyValuePair<byte, Dictionary<MapHack.ShortPos, ushort>> keyValuePair2 in MapHack._realms)
				{
					this._mapScores.Add((int)keyValuePair2.Key, 0);
				}
			}
			return;
		}
		Console.WriteLine("Maps list is null, unable to replace maps, trying to parse again");
		MapHack.ParseMapFiles();
	}

	// Token: 0x060004F4 RID: 1268 RVA: 0x0001CFF8 File Offset: 0x0001B1F8
	public void Update(UpdatePacket update)
	{
		if (!Settings.Default.EnableMapHack)
		{
			return;
		}
		if (this._needsNewTiles && MapHack._maps != null)
		{
			if (this._needsScan && this.client.MapName == "Realm of the Mad God")
			{
				this._realmTiles.AddRange(update.Tiles);
				foreach (KeyValuePair<byte, Dictionary<MapHack.ShortPos, ushort>> keyValuePair in MapHack._realms)
				{
					int num = this._mapScores[(int)keyValuePair.Key];
					foreach (Tile tile in this._realmTiles)
					{
						MapHack.ShortPos key = new MapHack.ShortPos(tile.X, tile.Y);
						if (keyValuePair.Value.ContainsKey(key) && keyValuePair.Value[key] == tile.Type)
						{
							num++;
						}
					}
					this._mapScores[(int)keyValuePair.Key] = num;
					if (num > 250)
					{
						this._realmTiles.Clear();
						if (!MapHack._fpMap.ContainsKey(this._fp))
						{
							MapHack._fpMap.Add(this._fp, (int)keyValuePair.Key);
						}
						else
						{
							MapHack._fpMap[this._fp] = (int)keyValuePair.Key;
						}
						this._needsScan = false;
						this._mapToReplace = MapHack._maps[string.Format("Realm of the Mad God World {0}", keyValuePair.Key)];
						break;
					}
				}
			}
			if (this._mapToReplace == null)
			{
				return;
			}
			List<Tile> list = new List<Tile>(Math.Min(this._mapToReplace.Length + update.Tiles.Length, 2048));
			list.AddRange(update.Tiles);
			int i;
			for (i = this._index; i < this._mapToReplace.Length; i++)
			{
				list.Add(this._mapToReplace[i]);
				if (list.Count == 2048)
				{
					break;
				}
			}
			this._index = i;
			update.Tiles = list.ToArray();
			if (i == this._mapToReplace.Length)
			{
				Console.WriteLine(string.Format("Finished replacing whole map! {0} total tiles replaced", this._index));
				this._needsNewTiles = false;
			}
		}
	}

	// Token: 0x060004F6 RID: 1270 RVA: 0x0001D2CC File Offset: 0x0001B4CC
	public void text(PlayerTextPacket playerText)
	{
		if (Settings.Default.EnableMapHack && playerText.Text == "/world" && this.client.MapName == "Realm of the Mad God")
		{
			playerText.Send = false;
			this.client._RUDdpffUqrc18m4ldj2l3yrb1t9(MapHack._fpMap.ContainsKey(this._fp) ? ("World: " + MapHack._fpMap[this._fp].ToString()) : "Unknown world");
			return;
		}
		if (playerText.Text == "/savemap")
		{
			playerText.Send = false;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
				Dictionary<ushort, List<byte[]>> dictionary = new Dictionary<ushort, List<byte[]>>();
				foreach (Square tiles in this.client.Tiles)
				{
					if (tiles != null)
					{
						if (!dictionary.ContainsKey(tiles.Type))
						{
							dictionary.Add(tiles.Type, new List<byte[]>());
						}
						dictionary[tiles.Type].Add(MapHack.ShortPos.Compress(tiles.X, tiles.Y));
					}
				}
				foreach (KeyValuePair<ushort, List<byte[]>> keyValuePair in dictionary)
				{
					binaryWriter.Write(keyValuePair.Key);
					binaryWriter.Write(keyValuePair.Value.Count);
					foreach (byte[] buffer in keyValuePair.Value)
					{
						binaryWriter.Write(buffer);
					}
				}
				byte[] bytes = MapHack.Zip(memoryStream.ToArray());
				File.WriteAllBytes(string.Concat(new string[]
				{
					"map_",
					this.client.MapName,
					" ",
					Environment.TickCount.ToString(),
					".gz"
				}), bytes);
			}
		}
	}

	// Token: 0x060004F7 RID: 1271 RVA: 0x0001D52C File Offset: 0x0001B72C
	public static byte[] Zip(byte[] bytes)
	{
		MemoryStream memoryStream2;
		using (MemoryStream memoryStream = new MemoryStream(bytes))
		{
			MemoryStream memoryStream3;
			memoryStream2 = (memoryStream3 = new MemoryStream());
			try
			{
				using (GZipStream gzipStream = new GZipStream(memoryStream2, CompressionMode.Compress))
				{
					memoryStream.CopyTo(gzipStream);
				}
			}
			finally
			{
				if (memoryStream3 != null)
				{
					((IDisposable)memoryStream3).Dispose();
				}
			}
		}
		return memoryStream2.ToArray();
	}

	// Token: 0x060004F8 RID: 1272 RVA: 0x0001D5A8 File Offset: 0x0001B7A8
	public static byte[] Unzip(byte[] bytes)
	{
		MemoryStream memoryStream2;
		using (MemoryStream memoryStream = new MemoryStream(bytes))
		{
			MemoryStream memoryStream3;
			memoryStream2 = (memoryStream3 = new MemoryStream());
			try
			{
				using (GZipStream gzipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
				{
					gzipStream.CopyTo(memoryStream2);
				}
			}
			finally
			{
				if (memoryStream3 != null)
				{
					((IDisposable)memoryStream3).Dispose();
				}
			}
		}
		return memoryStream2.ToArray();
	}

	// Token: 0x040005EF RID: 1519
	private const bool _LoNEZAqw3STKLFuKKxwVBumwbAh = false;

	// Token: 0x040005F0 RID: 1520
	private const int SUMMER_NEXUS_SUNRISE_TILE = 14953;

	// Token: 0x040005F1 RID: 1521
	private const int SUMMER_NEXUS_NOON_TILE = 26;

	// Token: 0x040005F2 RID: 1522
	private const int SUMMER_NEXUS_SUNSET_TILE = 14607;

	// Token: 0x040005F3 RID: 1523
	private const int SUMMER_NEXUS_NIGHT_TILE = 14773;

	// Token: 0x040005F6 RID: 1526
	private static Dictionary<string, Tile[]> _maps = null;

	// Token: 0x040005F7 RID: 1527
	private static Dictionary<byte, Dictionary<MapHack.ShortPos, ushort>> _realms = null;

	// Token: 0x040005F8 RID: 1528
	private static Dictionary<string, int> _fpMap = new Dictionary<string, int>();

	// Token: 0x040005F9 RID: 1529
	private Client client;

	// Token: 0x040005FA RID: 1530
	private bool _needsNewTiles;

	// Token: 0x040005FB RID: 1531
	private bool _needsScan;

	// Token: 0x040005FC RID: 1532
	private Tile[] _mapToReplace;

	// Token: 0x040005FD RID: 1533
	private int _index;

	// Token: 0x040005FE RID: 1534
	private List<Tile> _realmTiles;

	// Token: 0x040005FF RID: 1535
	private Dictionary<int, int> _mapScores;

	// Token: 0x04000600 RID: 1536
	private string _fp = "";

	// Token: 0x020000B7 RID: 183
	private struct ShortPos
	{
		// Token: 0x060004F9 RID: 1273 RVA: 0x0001D624 File Offset: 0x0001B824
		public ShortPos(short x, short y)
		{
			this.X = x;
			this.Y = y;
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x0001D640 File Offset: 0x0001B840
		public static byte[] Compress(short X, short Y)
		{
			ulong num = (ulong)((long)((int)X << 12 | (int)Y));
			return new byte[]
			{
				(byte)(num & 255UL),
				(byte)((num & 65280UL) >> 8),
				(byte)((num & 16711680UL) >> 16)
			};
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x0001D690 File Offset: 0x0001B890
		public static MapHack.ShortPos Decompress(byte[] bytes)
		{
			uint num = (uint)((int)bytes[0] | (int)bytes[1] << 8 | (int)bytes[2] << 16);
			return new MapHack.ShortPos((short)(num >> 12), (short)(num & 4095u));
		}

		// Token: 0x04000601 RID: 1537
		public readonly short X;

		// Token: 0x04000602 RID: 1538
		public readonly short Y;
	}

	// Token: 0x020000B8 RID: 184
	[CompilerGenerated]
	[Serializable]
	private sealed class _WEZhi8KRNQtER3xcz2RhdlI2jce
	{
		// Token: 0x060004FE RID: 1278 RVA: 0x0001D6EC File Offset: 0x0001B8EC
		internal MapHack.ShortPos _8RBFdEMGYBXi1tKh0OG11HV4pTH(Tile tile)
		{
			return new MapHack.ShortPos(tile.X, tile.Y);
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x0001D70C File Offset: 0x0001B90C
		internal ushort _KArchRWH5DtgRfJdG7qdZscL88p(Tile tile)
		{
			return tile.Type;
		}

		// Token: 0x04000603 RID: 1539
		public static readonly MapHack._WEZhi8KRNQtER3xcz2RhdlI2jce <>9 = new MapHack._WEZhi8KRNQtER3xcz2RhdlI2jce();

		// Token: 0x04000604 RID: 1540
		public static Func<Tile, MapHack.ShortPos> <>9__21_0;

		// Token: 0x04000605 RID: 1541
		public static Func<Tile, ushort> <>9__21_1;
	}
}
