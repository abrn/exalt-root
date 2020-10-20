using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace ExaltMultiTool.Proxy.DataStructures
{
	// Token: 0x020000CF RID: 207
	public class TileStructure : IDataStructure<ushort>
	{
		// Token: 0x06000551 RID: 1361 RVA: 0x0001FBC4 File Offset: 0x0001DDC4
		internal static Dictionary<ushort, TileStructure> _gKKd0PApBLw4Hl4Oj4Z6UarwYVc(XDocument doc)
		{
			TileStructure._97xdJ2DJKuu1P6jRrMAx0j03WkH 97xdJ2DJKuu1P6jRrMAx0j03WkH = new TileStructure._97xdJ2DJKuu1P6jRrMAx0j03WkH();
			97xdJ2DJKuu1P6jRrMAx0j03WkH._Kndj0w1wpl2a6oPYP8TaQVSkPtR = new Dictionary<ushort, TileStructure>();
			doc.Element("GroundTypes").Elements("Ground").ForEach(new Action<XElement>(97xdJ2DJKuu1P6jRrMAx0j03WkH._LEx7op2Ah50gJTPEFU3rxLS5TKB));
			return 97xdJ2DJKuu1P6jRrMAx0j03WkH._Kndj0w1wpl2a6oPYP8TaQVSkPtR;
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000552 RID: 1362 RVA: 0x0001FC1C File Offset: 0x0001DE1C
		// (set) Token: 0x06000553 RID: 1363 RVA: 0x0001FC30 File Offset: 0x0001DE30
		public ushort ID { get; private set; }

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000554 RID: 1364 RVA: 0x0001FC44 File Offset: 0x0001DE44
		// (set) Token: 0x06000555 RID: 1365 RVA: 0x0001FC58 File Offset: 0x0001DE58
		public string Name { get; private set; }

		// Token: 0x06000556 RID: 1366 RVA: 0x0001FC6C File Offset: 0x0001DE6C
		public TileStructure(XElement tile)
		{
			this;
			tile._ikFKebqGeYDppnRN94BtlHzztCC<System.UInt16>.ID = (ushort)Convert.ToInt32("type", "0x0".Value);
			this.NoWalk = tile.HasElement("NoWalk");
			this;
			tile.Speed = float.Parse("Speed", "1".Value);
			this.Sink = tile.HasElement("Sink");
			this;
			tile.MinDamage = (ushort)int.Parse("MinDamage", "0".Value);
			this;
			tile.MaxDamage = (ushort)int.Parse("MaxDamage", "0".Value);
			this;
			tile;
			"id"._ikFKebqGeYDppnRN94BtlHzztCC<System.UInt16>._Jp3DtIV4aAYZY26sVsXpPQjBRGO = "".Value;
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x0001FD4C File Offset: 0x0001DF4C
		public override string ToString()
		{
			return string.Format("Tile: {0} (0x{1:X})", this._ikFKebqGeYDppnRN94BtlHzztCC<System.UInt16>._Jp3DtIV4aAYZY26sVsXpPQjBRGO, this._ikFKebqGeYDppnRN94BtlHzztCC<System.UInt16>.ID);
		}

		// Token: 0x040006C6 RID: 1734
		[CompilerGenerated]
		private ushort _wLyKBFmJlsIH8DtqnZeUZOuEITZ;

		// Token: 0x040006C7 RID: 1735
		public bool NoWalk;

		// Token: 0x040006C8 RID: 1736
		public float Speed;

		// Token: 0x040006C9 RID: 1737
		public bool Sink;

		// Token: 0x040006CA RID: 1738
		public ushort MinDamage;

		// Token: 0x040006CB RID: 1739
		public ushort MaxDamage;

		// Token: 0x040006CC RID: 1740
		[CompilerGenerated]
		private string _1haiPDr5g8HadcnTI4yRJZK2hEn;

		// Token: 0x020000D0 RID: 208
		[CompilerGenerated]
		private sealed class _97xdJ2DJKuu1P6jRrMAx0j03WkH
		{
			// Token: 0x06000559 RID: 1369 RVA: 0x0001FD88 File Offset: 0x0001DF88
			internal void _LEx7op2Ah50gJTPEFU3rxLS5TKB(XElement tile)
			{
				TileStructure tileStructure = new TileStructure(tile);
				this._Kndj0w1wpl2a6oPYP8TaQVSkPtR[tileStructure._ikFKebqGeYDppnRN94BtlHzztCC<System.UInt16>.ID] = tileStructure;
			}

			// Token: 0x040006CD RID: 1741
			public Dictionary<ushort, TileStructure> _Kndj0w1wpl2a6oPYP8TaQVSkPtR;
		}
	}
}
