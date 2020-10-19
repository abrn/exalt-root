using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace ExaltMultiTool.Proxy.DataStructures
{
	// Token: 0x020000C7 RID: 199
	public class ObjectStructure : IDataStructure<ushort>
	{
		// Token: 0x06000532 RID: 1330 RVA: 0x0001F24C File Offset: 0x0001D44C
		internal static Dictionary<ushort, ObjectStructure> _gKKd0PApBLw4Hl4Oj4Z6UarwYVc(XDocument doc)
		{
			ObjectStructure._omx8cRYQYaXGFHkoVtyfym3r9ne omx8cRYQYaXGFHkoVtyfym3r9ne = new ObjectStructure._omx8cRYQYaXGFHkoVtyfym3r9ne();
			omx8cRYQYaXGFHkoVtyfym3r9ne._Kndj0w1wpl2a6oPYP8TaQVSkPtR = new Dictionary<ushort, ObjectStructure>();
			doc.Element("Objects").Elements("Object")._mDNyNFYbqpk6ULly4BYiq6ShWsn(new Action<XElement>(omx8cRYQYaXGFHkoVtyfym3r9ne._LEx7op2Ah50gJTPEFU3rxLS5TKB));
			return omx8cRYQYaXGFHkoVtyfym3r9ne._Kndj0w1wpl2a6oPYP8TaQVSkPtR;
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000533 RID: 1331 RVA: 0x0001F2A4 File Offset: 0x0001D4A4
		// (set) Token: 0x06000534 RID: 1332 RVA: 0x0001F2B8 File Offset: 0x0001D4B8
		public ushort ID { get; private set; }

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000535 RID: 1333 RVA: 0x0001F2CC File Offset: 0x0001D4CC
		// (set) Token: 0x06000536 RID: 1334 RVA: 0x0001F2E0 File Offset: 0x0001D4E0
		public string Name { get; private set; }

		// Token: 0x06000537 RID: 1335 RVA: 0x0001F2F4 File Offset: 0x0001D4F4
		public ObjectStructure(XElement obj)
		{
			ObjectStructure._k9mva0pTfAnhOH68LvRulNGaNGH k9mva0pTfAnhOH68LvRulNGaNGH = new ObjectStructure._k9mva0pTfAnhOH68LvRulNGaNGH();
			this;
			obj._ikFKebqGeYDppnRN94BtlHzztCC<System.UInt16>.ID = (ushort)Convert.ToInt32("type", "0x0".Value);
			this;
			obj;
			"Class".ObjectClass = "GameObject".Value;
			this;
			obj.MaxHP = (ushort)Convert.ToInt32("MaxHitPoints", "0".Value);
			this;
			obj.XPMult = float.Parse("XpMult", "0".Value);
			this.Static = obj._v94aD6xnI4gMG97iMJhl8NatmPCb("Static");
			this.OccupySquare = obj._v94aD6xnI4gMG97iMJhl8NatmPCb("OccupySquare");
			this.EnemyOccupySquare = obj._v94aD6xnI4gMG97iMJhl8NatmPCb("EnemyOccupySquare");
			this.FullOccupy = obj._v94aD6xnI4gMG97iMJhl8NatmPCb("FullOccupy");
			this.BlocksSight = obj._v94aD6xnI4gMG97iMJhl8NatmPCb("BlocksSight");
			this.ProtectFromGroundDamage = obj._v94aD6xnI4gMG97iMJhl8NatmPCb("ProtectFromGroundDamage");
			this.ProtectFromSink = obj._v94aD6xnI4gMG97iMJhl8NatmPCb("ProtectFromSink");
			this.Enemy = obj._v94aD6xnI4gMG97iMJhl8NatmPCb("Enemy");
			this.Player = obj._v94aD6xnI4gMG97iMJhl8NatmPCb("Player");
			this.Pet = obj._v94aD6xnI4gMG97iMJhl8NatmPCb("Pet");
			this.DrawOnGround = obj._v94aD6xnI4gMG97iMJhl8NatmPCb("DrawOnGround");
			this;
			obj.Size = (ushort)int.Parse("Size", "0".Value);
			this;
			obj.ShadowSize = (ushort)int.Parse("ShadowSize", "0".Value);
			this;
			obj.Defense = (ushort)int.Parse("Defense", "0".Value);
			this.Flying = obj._v94aD6xnI4gMG97iMJhl8NatmPCb("Flying");
			this.God = obj._v94aD6xnI4gMG97iMJhl8NatmPCb("God");
			this.Cube = obj._v94aD6xnI4gMG97iMJhl8NatmPCb("Cube");
			this.Quest = obj._v94aD6xnI4gMG97iMJhl8NatmPCb("Quest");
			this.Item = obj._v94aD6xnI4gMG97iMJhl8NatmPCb("Item");
			this.Usable = obj._v94aD6xnI4gMG97iMJhl8NatmPCb("Usable");
			this.Soulbound = obj._v94aD6xnI4gMG97iMJhl8NatmPCb("Soulbound");
			this;
			obj.MpCost = (ushort)int.Parse("MpCost", "0".Value);
			k9mva0pTfAnhOH68LvRulNGaNGH._QNMYPbLKtCDOLp2sRcvztmtD2Ff = new List<ProjectileStructure>();
			obj.Elements("Projectile")._mDNyNFYbqpk6ULly4BYiq6ShWsn(new Action<XElement>(k9mva0pTfAnhOH68LvRulNGaNGH._7qT03toc6JWCJ7vt3WXcUBYQn7k));
			this.Projectiles = k9mva0pTfAnhOH68LvRulNGaNGH._QNMYPbLKtCDOLp2sRcvztmtD2Ff.ToArray();
			this;
			obj;
			"id"._ikFKebqGeYDppnRN94BtlHzztCC<System.UInt16>._Jp3DtIV4aAYZY26sVsXpPQjBRGO = "".Value;
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x0001F5F4 File Offset: 0x0001D7F4
		public override string ToString()
		{
			return string.Format("Object: {0} (0x{1:X})", this._ikFKebqGeYDppnRN94BtlHzztCC<System.UInt16>._Jp3DtIV4aAYZY26sVsXpPQjBRGO, this._ikFKebqGeYDppnRN94BtlHzztCC<System.UInt16>.ID);
		}

		// Token: 0x0400068E RID: 1678
		[CompilerGenerated]
		private ushort _wLyKBFmJlsIH8DtqnZeUZOuEITZ;

		// Token: 0x0400068F RID: 1679
		public string ObjectClass;

		// Token: 0x04000690 RID: 1680
		public ushort MaxHP;

		// Token: 0x04000691 RID: 1681
		public float XPMult;

		// Token: 0x04000692 RID: 1682
		public bool Static;

		// Token: 0x04000693 RID: 1683
		public bool OccupySquare;

		// Token: 0x04000694 RID: 1684
		public bool EnemyOccupySquare;

		// Token: 0x04000695 RID: 1685
		public bool FullOccupy;

		// Token: 0x04000696 RID: 1686
		public bool BlocksSight;

		// Token: 0x04000697 RID: 1687
		public bool ProtectFromGroundDamage;

		// Token: 0x04000698 RID: 1688
		public bool ProtectFromSink;

		// Token: 0x04000699 RID: 1689
		public bool Enemy;

		// Token: 0x0400069A RID: 1690
		public bool Player;

		// Token: 0x0400069B RID: 1691
		public bool Pet;

		// Token: 0x0400069C RID: 1692
		public bool DrawOnGround;

		// Token: 0x0400069D RID: 1693
		public ushort Size;

		// Token: 0x0400069E RID: 1694
		public ushort ShadowSize;

		// Token: 0x0400069F RID: 1695
		public ushort Defense;

		// Token: 0x040006A0 RID: 1696
		public bool Flying;

		// Token: 0x040006A1 RID: 1697
		public bool God;

		// Token: 0x040006A2 RID: 1698
		public bool Cube;

		// Token: 0x040006A3 RID: 1699
		public bool Quest;

		// Token: 0x040006A4 RID: 1700
		public bool Item;

		// Token: 0x040006A5 RID: 1701
		public bool Usable;

		// Token: 0x040006A6 RID: 1702
		public bool Soulbound;

		// Token: 0x040006A7 RID: 1703
		public ushort MpCost;

		// Token: 0x040006A8 RID: 1704
		public ProjectileStructure[] Projectiles;

		// Token: 0x040006A9 RID: 1705
		[CompilerGenerated]
		private string _1haiPDr5g8HadcnTI4yRJZK2hEn;

		// Token: 0x020000C8 RID: 200
		[CompilerGenerated]
		private sealed class _omx8cRYQYaXGFHkoVtyfym3r9ne
		{
			// Token: 0x0600053A RID: 1338 RVA: 0x0001F630 File Offset: 0x0001D830
			internal void _LEx7op2Ah50gJTPEFU3rxLS5TKB(XElement obj)
			{
				ObjectStructure objectStructure = new ObjectStructure(obj);
				this._Kndj0w1wpl2a6oPYP8TaQVSkPtR[objectStructure._ikFKebqGeYDppnRN94BtlHzztCC<System.UInt16>.ID] = objectStructure;
			}

			// Token: 0x040006AA RID: 1706
			public Dictionary<ushort, ObjectStructure> _Kndj0w1wpl2a6oPYP8TaQVSkPtR;
		}

		// Token: 0x020000C9 RID: 201
		[CompilerGenerated]
		private sealed class _k9mva0pTfAnhOH68LvRulNGaNGH
		{
			// Token: 0x0600053C RID: 1340 RVA: 0x0001F66C File Offset: 0x0001D86C
			internal void _7qT03toc6JWCJ7vt3WXcUBYQn7k(XElement projectile)
			{
				this._QNMYPbLKtCDOLp2sRcvztmtD2Ff.Add(new ProjectileStructure(projectile));
			}

			// Token: 0x040006AB RID: 1707
			public List<ProjectileStructure> _QNMYPbLKtCDOLp2sRcvztmtD2Ff;
		}
	}
}
