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
		MapHack._ho8Vd9FnbI87aiTjOKiAlOGOezU();
	}

	// Token: 0x060004F1 RID: 1265 RVA: 0x0001CB28 File Offset: 0x0001AD28
	public MapHack(Client client)
	{
		this._W6Ov6AArxzTTDnCyBtZPqkqNaKf = client;
	}

	// Token: 0x060004F2 RID: 1266 RVA: 0x0001CB50 File Offset: 0x0001AD50
	private static void _ho8Vd9FnbI87aiTjOKiAlOGOezU()
	{
		if (MapHack._0XLBaQ99meaD7tjmEnrMOvdVgqFA != null)
		{
			return;
		}
		Dictionary<string, _hVYZnKlD1p4NKgHvEIulwTgi91f[]> dictionary = new Dictionary<string, _hVYZnKlD1p4NKgHvEIulwTgi91f[]>();
		foreach (object obj in new ResourceManager(typeof(_VIgCTVMa1A4g21SK8I7wH9AJhr8A)).GetResourceSet(CultureInfo.CurrentUICulture, true, true))
		{
			DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
			string text = dictionaryEntry.Key.ToString();
			if (text.StartsWith("map_"))
			{
				text = text.Substring(MapHack._NiW4dFJrbOxV0EgOv8s4ohmj3gc).Replace('_', ' ');
				byte[] array = dictionaryEntry.Value as byte[];
				if (array != null)
				{
					using (MemoryStream memoryStream = new MemoryStream(MapHack._5Cz5YWD3I6SiWmFcoGxjlf4e4Wi(array)))
					{
						BinaryReader binaryReader = new BinaryReader(memoryStream);
						List<_hVYZnKlD1p4NKgHvEIulwTgi91f> list = new List<_hVYZnKlD1p4NKgHvEIulwTgi91f>();
						while (binaryReader.BaseStream.Position != binaryReader.BaseStream.Length)
						{
							ushort type = binaryReader.ReadUInt16();
							int num = binaryReader.ReadInt32();
							for (int i = 0; i < num; i++)
							{
								byte[] array2 = binaryReader.ReadBytes(3);
								if (array2.Length == 3)
								{
									MapHack._BfQQILmNRBsu6MzWX96zDe5mAui bfQQILmNRBsu6MzWX96zDe5mAui = MapHack._BfQQILmNRBsu6MzWX96zDe5mAui._5Cz5YWD3I6SiWmFcoGxjlf4e4Wi(array2);
									list.Add(new _hVYZnKlD1p4NKgHvEIulwTgi91f(bfQQILmNRBsu6MzWX96zDe5mAui._MFEyfKFQqtcdaBxZbAOPzXMB8iP, bfQQILmNRBsu6MzWX96zDe5mAui._vwAmCOilfBfnOBAh94J77UFd0FV, type));
								}
							}
						}
						dictionary.Add(text, list.ToArray());
					}
				}
			}
		}
		MapHack._0XLBaQ99meaD7tjmEnrMOvdVgqFA = new Dictionary<string, _hVYZnKlD1p4NKgHvEIulwTgi91f[]>(dictionary.Count);
		MapHack._Y1etBfnzGhbZh3aEFGWK9mPDNwG = new Dictionary<byte, Dictionary<MapHack._BfQQILmNRBsu6MzWX96zDe5mAui, ushort>>();
		foreach (KeyValuePair<string, _hVYZnKlD1p4NKgHvEIulwTgi91f[]> keyValuePair in dictionary)
		{
			if (keyValuePair.Key.StartsWith("Realm of the Mad God World ") && keyValuePair.Key.EndsWith(" sand"))
			{
				string text2 = keyValuePair.Key.Substring(27);
				byte key = byte.Parse(text2.Substring(0, (text2[1] != ' ') ? 2 : 1));
				Dictionary<MapHack._BfQQILmNRBsu6MzWX96zDe5mAui, ushort> value = keyValuePair.Value.ToDictionary(new Func<_hVYZnKlD1p4NKgHvEIulwTgi91f, MapHack._BfQQILmNRBsu6MzWX96zDe5mAui>(MapHack._WEZhi8KRNQtER3xcz2RhdlI2jce.<>9._8RBFdEMGYBXi1tKh0OG11HV4pTH), new Func<_hVYZnKlD1p4NKgHvEIulwTgi91f, ushort>(MapHack._WEZhi8KRNQtER3xcz2RhdlI2jce.<>9._KArchRWH5DtgRfJdG7qdZscL88p));
				MapHack._Y1etBfnzGhbZh3aEFGWK9mPDNwG.Add(key, value);
			}
			else
			{
				_hVYZnKlD1p4NKgHvEIulwTgi91f[] value2 = keyValuePair.Value.ToArray<_hVYZnKlD1p4NKgHvEIulwTgi91f>();
				string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(keyValuePair.Key);
				MapHack._0XLBaQ99meaD7tjmEnrMOvdVgqFA.Add(fileNameWithoutExtension, value2);
			}
		}
	}

	// Token: 0x060004F3 RID: 1267 RVA: 0x0001CE34 File Offset: 0x0001B034
	public void MapInfo(MapInfoPacket mapInfo)
	{
		this._bilDDlbc6t9u88bs3O9XEoAkn2M = 0;
		if (MapHack._0XLBaQ99meaD7tjmEnrMOvdVgqFA != null)
		{
			this._Kfpr3IZWaJndDX4SDehARoKa1BaA = (this._xD3y9U8NpgZdRQZdTGOtPvAEipB = (mapInfo._Jp3DtIV4aAYZY26sVsXpPQjBRGO == "Realm of the Mad God"));
			foreach (KeyValuePair<string, _hVYZnKlD1p4NKgHvEIulwTgi91f[]> keyValuePair in MapHack._0XLBaQ99meaD7tjmEnrMOvdVgqFA)
			{
				if (keyValuePair.Key == mapInfo._Jp3DtIV4aAYZY26sVsXpPQjBRGO)
				{
					this._ImroCPH59GVukuvbi57fJRLAhRu = keyValuePair.Value;
					this._Kfpr3IZWaJndDX4SDehARoKa1BaA = true;
					this._xD3y9U8NpgZdRQZdTGOtPvAEipB = false;
					break;
				}
			}
			this._G4k84BYIzUgV6BaPK8DbPTP7t7P = mapInfo._8BqcoKCa24PgCbJ6omzKCS4ddwe.ToString();
			if (mapInfo._Jp3DtIV4aAYZY26sVsXpPQjBRGO == "Realm of the Mad God")
			{
				if (MapHack._8CS9GdbC7BaOZVn4rNlEYw5FycbA.ContainsKey(this._G4k84BYIzUgV6BaPK8DbPTP7t7P))
				{
					Console.WriteLine(string.Format("Using map {0} {1}", this._G4k84BYIzUgV6BaPK8DbPTP7t7P, MapHack._8CS9GdbC7BaOZVn4rNlEYw5FycbA[this._G4k84BYIzUgV6BaPK8DbPTP7t7P]));
					this._ImroCPH59GVukuvbi57fJRLAhRu = MapHack._0XLBaQ99meaD7tjmEnrMOvdVgqFA[string.Format("Realm of the Mad God World {0}", MapHack._8CS9GdbC7BaOZVn4rNlEYw5FycbA[this._G4k84BYIzUgV6BaPK8DbPTP7t7P])];
					this._Kfpr3IZWaJndDX4SDehARoKa1BaA = true;
					this._xD3y9U8NpgZdRQZdTGOtPvAEipB = false;
					return;
				}
				this._equJOlToYXlIzcUCOw4aCU25KNB = new List<_hVYZnKlD1p4NKgHvEIulwTgi91f>();
				this._SBzC5hVRwgzMaKUr0pjXalmSYJg = new Dictionary<int, int>();
				foreach (KeyValuePair<byte, Dictionary<MapHack._BfQQILmNRBsu6MzWX96zDe5mAui, ushort>> keyValuePair2 in MapHack._Y1etBfnzGhbZh3aEFGWK9mPDNwG)
				{
					this._SBzC5hVRwgzMaKUr0pjXalmSYJg.Add((int)keyValuePair2.Key, 0);
				}
			}
			return;
		}
		Console.WriteLine("Maps list is null, unable to replace maps, trying to parse again");
		MapHack._ho8Vd9FnbI87aiTjOKiAlOGOezU();
	}

	// Token: 0x060004F4 RID: 1268 RVA: 0x0001CFF8 File Offset: 0x0001B1F8
	public void Update(UpdatePacket update)
	{
		if (!Settings.Default.EnableMapHack)
		{
			return;
		}
		if (this._Kfpr3IZWaJndDX4SDehARoKa1BaA && MapHack._0XLBaQ99meaD7tjmEnrMOvdVgqFA != null)
		{
			if (this._xD3y9U8NpgZdRQZdTGOtPvAEipB && this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.MapName == "Realm of the Mad God")
			{
				this._equJOlToYXlIzcUCOw4aCU25KNB.AddRange(update._ggcOirasY7xrclnb5yxgWCbeJam);
				foreach (KeyValuePair<byte, Dictionary<MapHack._BfQQILmNRBsu6MzWX96zDe5mAui, ushort>> keyValuePair in MapHack._Y1etBfnzGhbZh3aEFGWK9mPDNwG)
				{
					int num = this._SBzC5hVRwgzMaKUr0pjXalmSYJg[(int)keyValuePair.Key];
					foreach (_hVYZnKlD1p4NKgHvEIulwTgi91f hVYZnKlD1p4NKgHvEIulwTgi91f in this._equJOlToYXlIzcUCOw4aCU25KNB)
					{
						MapHack._BfQQILmNRBsu6MzWX96zDe5mAui key = new MapHack._BfQQILmNRBsu6MzWX96zDe5mAui(hVYZnKlD1p4NKgHvEIulwTgi91f._MFEyfKFQqtcdaBxZbAOPzXMB8iP, hVYZnKlD1p4NKgHvEIulwTgi91f._vwAmCOilfBfnOBAh94J77UFd0FV);
						if (keyValuePair.Value.ContainsKey(key) && keyValuePair.Value[key] == hVYZnKlD1p4NKgHvEIulwTgi91f._k9uWQCZd8WqDr6yiKRmrLtst3KX)
						{
							num++;
						}
					}
					this._SBzC5hVRwgzMaKUr0pjXalmSYJg[(int)keyValuePair.Key] = num;
					if (num > 250)
					{
						this._equJOlToYXlIzcUCOw4aCU25KNB.Clear();
						if (!MapHack._8CS9GdbC7BaOZVn4rNlEYw5FycbA.ContainsKey(this._G4k84BYIzUgV6BaPK8DbPTP7t7P))
						{
							MapHack._8CS9GdbC7BaOZVn4rNlEYw5FycbA.Add(this._G4k84BYIzUgV6BaPK8DbPTP7t7P, (int)keyValuePair.Key);
						}
						else
						{
							MapHack._8CS9GdbC7BaOZVn4rNlEYw5FycbA[this._G4k84BYIzUgV6BaPK8DbPTP7t7P] = (int)keyValuePair.Key;
						}
						this._xD3y9U8NpgZdRQZdTGOtPvAEipB = false;
						this._ImroCPH59GVukuvbi57fJRLAhRu = MapHack._0XLBaQ99meaD7tjmEnrMOvdVgqFA[string.Format("Realm of the Mad God World {0}", keyValuePair.Key)];
						break;
					}
				}
			}
			if (this._ImroCPH59GVukuvbi57fJRLAhRu == null)
			{
				return;
			}
			List<_hVYZnKlD1p4NKgHvEIulwTgi91f> list = new List<_hVYZnKlD1p4NKgHvEIulwTgi91f>(Math.Min(this._ImroCPH59GVukuvbi57fJRLAhRu.Length + update._ggcOirasY7xrclnb5yxgWCbeJam.Length, 2048));
			list.AddRange(update._ggcOirasY7xrclnb5yxgWCbeJam);
			int i;
			for (i = this._bilDDlbc6t9u88bs3O9XEoAkn2M; i < this._ImroCPH59GVukuvbi57fJRLAhRu.Length; i++)
			{
				list.Add(this._ImroCPH59GVukuvbi57fJRLAhRu[i]);
				if (list.Count == 2048)
				{
					break;
				}
			}
			this._bilDDlbc6t9u88bs3O9XEoAkn2M = i;
			update._ggcOirasY7xrclnb5yxgWCbeJam = list.ToArray();
			if (i == this._ImroCPH59GVukuvbi57fJRLAhRu.Length)
			{
				Console.WriteLine(string.Format("Finished replacing whole map! {0} total tiles replaced", this._bilDDlbc6t9u88bs3O9XEoAkn2M));
				this._Kfpr3IZWaJndDX4SDehARoKa1BaA = false;
			}
		}
	}

	// Token: 0x060004F5 RID: 1269 RVA: 0x0001D298 File Offset: 0x0001B498
	public static void _UJg70tjjRNELbmmK4PeXnpW5W7g()
	{
		MapHack._PhbckAazFiSXqewRxSBHg5v2QDB(MapHack._5Cz5YWD3I6SiWmFcoGxjlf4e4Wi(MapHack._PhbckAazFiSXqewRxSBHg5v2QDB(MapHack._5Cz5YWD3I6SiWmFcoGxjlf4e4Wi(MapHack._PhbckAazFiSXqewRxSBHg5v2QDB(MapHack._5Cz5YWD3I6SiWmFcoGxjlf4e4Wi(_VIgCTVMa1A4g21SK8I7wH9AJhr8A._45zFuF1CYo896xeQFS5eN6devb8))))));
	}

	// Token: 0x060004F6 RID: 1270 RVA: 0x0001D2CC File Offset: 0x0001B4CC
	public void text(PlayerTextPacket playerText)
	{
		if (Settings.Default.EnableMapHack && playerText.Text == "/world" && this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.MapName == "Realm of the Mad God")
		{
			playerText.Send = false;
			this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._RUDdpffUqrc18m4ldj2l3yrb1t9(MapHack._8CS9GdbC7BaOZVn4rNlEYw5FycbA.ContainsKey(this._G4k84BYIzUgV6BaPK8DbPTP7t7P) ? ("World: " + MapHack._8CS9GdbC7BaOZVn4rNlEYw5FycbA[this._G4k84BYIzUgV6BaPK8DbPTP7t7P].ToString()) : "Unknown world");
			return;
		}
		if (playerText.Text == "/savemap")
		{
			playerText.Send = false;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
				Dictionary<ushort, List<byte[]>> dictionary = new Dictionary<ushort, List<byte[]>>();
				foreach (Square q3lhvRoGxDHbe4DHt5QEvG37i6dA in this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Tiles)
				{
					if (q3lhvRoGxDHbe4DHt5QEvG37i6dA != null)
					{
						if (!dictionary.ContainsKey(q3lhvRoGxDHbe4DHt5QEvG37i6dA._k9uWQCZd8WqDr6yiKRmrLtst3KX))
						{
							dictionary.Add(q3lhvRoGxDHbe4DHt5QEvG37i6dA._k9uWQCZd8WqDr6yiKRmrLtst3KX, new List<byte[]>());
						}
						dictionary[q3lhvRoGxDHbe4DHt5QEvG37i6dA._k9uWQCZd8WqDr6yiKRmrLtst3KX].Add(MapHack._BfQQILmNRBsu6MzWX96zDe5mAui._PhbckAazFiSXqewRxSBHg5v2QDB(q3lhvRoGxDHbe4DHt5QEvG37i6dA._MFEyfKFQqtcdaBxZbAOPzXMB8iP, q3lhvRoGxDHbe4DHt5QEvG37i6dA._vwAmCOilfBfnOBAh94J77UFd0FV));
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
				byte[] bytes = MapHack._PhbckAazFiSXqewRxSBHg5v2QDB(memoryStream.ToArray());
				File.WriteAllBytes(string.Concat(new string[]
				{
					"map_",
					this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.MapName,
					" ",
					Environment.TickCount.ToString(),
					".gz"
				}), bytes);
			}
		}
	}

	// Token: 0x060004F7 RID: 1271 RVA: 0x0001D52C File Offset: 0x0001B72C
	public static byte[] _PhbckAazFiSXqewRxSBHg5v2QDB(byte[] bytes)
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
	public static byte[] _5Cz5YWD3I6SiWmFcoGxjlf4e4Wi(byte[] bytes)
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
	private const int _wBYCsncegfb6oqJIifsosVoPD2cA = 14953;

	// Token: 0x040005F1 RID: 1521
	private const int _Vv3aEIyGfi9ZJ4s9i2Ekb9Rvftn = 26;

	// Token: 0x040005F2 RID: 1522
	private const int _SjgAD62ao05IqE2pz1o1d1rG8v6 = 14607;

	// Token: 0x040005F3 RID: 1523
	private const int _5wtSsFgOWKoRYRuAaIATJyBreIn = 14773;

	// Token: 0x040005F4 RID: 1524
	private static readonly int _NiW4dFJrbOxV0EgOv8s4ohmj3gc = 4;

	// Token: 0x040005F5 RID: 1525
	private const string _CMdaS90zkUpa5FFaVBdLC1A4hrDb = "Realm of the Mad God World ";

	// Token: 0x040005F6 RID: 1526
	private static Dictionary<string, _hVYZnKlD1p4NKgHvEIulwTgi91f[]> _0XLBaQ99meaD7tjmEnrMOvdVgqFA = null;

	// Token: 0x040005F7 RID: 1527
	private static Dictionary<byte, Dictionary<MapHack._BfQQILmNRBsu6MzWX96zDe5mAui, ushort>> _Y1etBfnzGhbZh3aEFGWK9mPDNwG = null;

	// Token: 0x040005F8 RID: 1528
	private static Dictionary<string, int> _8CS9GdbC7BaOZVn4rNlEYw5FycbA = new Dictionary<string, int>();

	// Token: 0x040005F9 RID: 1529
	private Client _W6Ov6AArxzTTDnCyBtZPqkqNaKf;

	// Token: 0x040005FA RID: 1530
	private bool _Kfpr3IZWaJndDX4SDehARoKa1BaA;

	// Token: 0x040005FB RID: 1531
	private bool _xD3y9U8NpgZdRQZdTGOtPvAEipB;

	// Token: 0x040005FC RID: 1532
	private _hVYZnKlD1p4NKgHvEIulwTgi91f[] _ImroCPH59GVukuvbi57fJRLAhRu;

	// Token: 0x040005FD RID: 1533
	private int _bilDDlbc6t9u88bs3O9XEoAkn2M;

	// Token: 0x040005FE RID: 1534
	private List<_hVYZnKlD1p4NKgHvEIulwTgi91f> _equJOlToYXlIzcUCOw4aCU25KNB;

	// Token: 0x040005FF RID: 1535
	private Dictionary<int, int> _SBzC5hVRwgzMaKUr0pjXalmSYJg;

	// Token: 0x04000600 RID: 1536
	private string _G4k84BYIzUgV6BaPK8DbPTP7t7P = "";

	// Token: 0x020000B7 RID: 183
	private struct _BfQQILmNRBsu6MzWX96zDe5mAui
	{
		// Token: 0x060004F9 RID: 1273 RVA: 0x0001D624 File Offset: 0x0001B824
		public _BfQQILmNRBsu6MzWX96zDe5mAui(short x, short y)
		{
			this._MFEyfKFQqtcdaBxZbAOPzXMB8iP = x;
			this._vwAmCOilfBfnOBAh94J77UFd0FV = y;
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x0001D640 File Offset: 0x0001B840
		public static byte[] _PhbckAazFiSXqewRxSBHg5v2QDB(short X, short Y)
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
		public static MapHack._BfQQILmNRBsu6MzWX96zDe5mAui _5Cz5YWD3I6SiWmFcoGxjlf4e4Wi(byte[] bytes)
		{
			uint num = (uint)((int)bytes[0] | (int)bytes[1] << 8 | (int)bytes[2] << 16);
			return new MapHack._BfQQILmNRBsu6MzWX96zDe5mAui((short)(num >> 12), (short)(num & 4095u));
		}

		// Token: 0x04000601 RID: 1537
		public readonly short _MFEyfKFQqtcdaBxZbAOPzXMB8iP;

		// Token: 0x04000602 RID: 1538
		public readonly short _vwAmCOilfBfnOBAh94J77UFd0FV;
	}

	// Token: 0x020000B8 RID: 184
	[CompilerGenerated]
	[Serializable]
	private sealed class _WEZhi8KRNQtER3xcz2RhdlI2jce
	{
		// Token: 0x060004FE RID: 1278 RVA: 0x0001D6EC File Offset: 0x0001B8EC
		internal MapHack._BfQQILmNRBsu6MzWX96zDe5mAui _8RBFdEMGYBXi1tKh0OG11HV4pTH(_hVYZnKlD1p4NKgHvEIulwTgi91f tile)
		{
			return new MapHack._BfQQILmNRBsu6MzWX96zDe5mAui(tile._MFEyfKFQqtcdaBxZbAOPzXMB8iP, tile._vwAmCOilfBfnOBAh94J77UFd0FV);
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x0001D70C File Offset: 0x0001B90C
		internal ushort _KArchRWH5DtgRfJdG7qdZscL88p(_hVYZnKlD1p4NKgHvEIulwTgi91f tile)
		{
			return tile._k9uWQCZd8WqDr6yiKRmrLtst3KX;
		}

		// Token: 0x04000603 RID: 1539
		public static readonly MapHack._WEZhi8KRNQtER3xcz2RhdlI2jce <>9 = new MapHack._WEZhi8KRNQtER3xcz2RhdlI2jce();

		// Token: 0x04000604 RID: 1540
		public static Func<_hVYZnKlD1p4NKgHvEIulwTgi91f, MapHack._BfQQILmNRBsu6MzWX96zDe5mAui> <>9__21_0;

		// Token: 0x04000605 RID: 1541
		public static Func<_hVYZnKlD1p4NKgHvEIulwTgi91f, ushort> <>9__21_1;
	}
}
