using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace ExaltMultiTool.Proxy.DataStructures
{
	// Token: 0x020000CD RID: 205
	public class ProjectileStructure : IDataStructure<byte>
	{
		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000549 RID: 1353 RVA: 0x0001F8C8 File Offset: 0x0001DAC8
		// (set) Token: 0x0600054A RID: 1354 RVA: 0x0001F8DC File Offset: 0x0001DADC
		public byte ID { get; private set; }

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x0600054B RID: 1355 RVA: 0x0001F8F0 File Offset: 0x0001DAF0
		// (set) Token: 0x0600054C RID: 1356 RVA: 0x0001F904 File Offset: 0x0001DB04
		public string Name { get; private set; }

		// Token: 0x0600054D RID: 1357 RVA: 0x0001F918 File Offset: 0x0001DB18
		public ProjectileStructure(XElement projectile)
		{
			ProjectileStructure._VD3MkegZcmAlOIaxEUrAAtlp91A vd3MkegZcmAlOIaxEUrAAtlp91A = new ProjectileStructure._VD3MkegZcmAlOIaxEUrAAtlp91A();
			this;
			projectile._ikFKebqGeYDppnRN94BtlHzztCC<System.Byte>.ID = (byte)int.Parse("id", "0".Value);
			this;
			projectile.Damage = int.Parse("Damage", "0".Value);
			this;
			projectile.Speed = float.Parse("Speed", "0".Value) / 10000f;
			this;
			projectile.Size = int.Parse("Size", "0".Value);
			this;
			projectile.Lifetime = float.Parse("LifetimeMS", "0".Value);
			this;
			projectile.MaxDamage = int.Parse("MaxDamage", "0".Value);
			this;
			projectile.MinDamage = int.Parse("MinDamage", "0".Value);
			this;
			projectile.Magnitude = float.Parse("Magnitude", "0".Value);
			this;
			projectile.Amplitude = float.Parse("Amplitude", "0".Value);
			this;
			projectile.Frequency = float.Parse("Frequency", "0".Value);
			this.Wavy = projectile.HasElement("Wavy");
			this.Parametric = projectile.HasElement("Parametric");
			this.Boomerang = projectile.HasElement("Boomerang");
			this.ArmorPiercing = projectile.HasElement("ArmorPiercing");
			this.MultiHit = projectile.HasElement("MultiHit");
			this.PassesCover = projectile.HasElement("PassesCover");
			vd3MkegZcmAlOIaxEUrAAtlp91A._1wkC6aK6Vm0MswSRo8G4ZBODjWn = new Dictionary<string, float>();
			projectile.Elements("ConditionEffect").ForEach(new Action<XElement>(vd3MkegZcmAlOIaxEUrAAtlp91A._7qT03toc6JWCJ7vt3WXcUBYQn7k));
			this.StatusEffects = vd3MkegZcmAlOIaxEUrAAtlp91A._1wkC6aK6Vm0MswSRo8G4ZBODjWn;
			this;
			projectile;
			"ObjectId"._ikFKebqGeYDppnRN94BtlHzztCC<System.Byte>._Jp3DtIV4aAYZY26sVsXpPQjBRGO = "".Value;
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x0001FB50 File Offset: 0x0001DD50
		public override string ToString()
		{
			return string.Format("Projectile: {0} (0x{1:X})", this._ikFKebqGeYDppnRN94BtlHzztCC<System.Byte>._Jp3DtIV4aAYZY26sVsXpPQjBRGO, this._ikFKebqGeYDppnRN94BtlHzztCC<System.Byte>.ID);
		}

		// Token: 0x040006B3 RID: 1715
		[CompilerGenerated]
		private byte _wLyKBFmJlsIH8DtqnZeUZOuEITZ;

		// Token: 0x040006B4 RID: 1716
		public int Damage;

		// Token: 0x040006B5 RID: 1717
		public float Speed;

		// Token: 0x040006B6 RID: 1718
		public int Size;

		// Token: 0x040006B7 RID: 1719
		public float Lifetime;

		// Token: 0x040006B8 RID: 1720
		public int MaxDamage;

		// Token: 0x040006B9 RID: 1721
		public int MinDamage;

		// Token: 0x040006BA RID: 1722
		public float Magnitude;

		// Token: 0x040006BB RID: 1723
		public float Amplitude;

		// Token: 0x040006BC RID: 1724
		public float Frequency;

		// Token: 0x040006BD RID: 1725
		public bool Wavy;

		// Token: 0x040006BE RID: 1726
		public bool Parametric;

		// Token: 0x040006BF RID: 1727
		public bool Boomerang;

		// Token: 0x040006C0 RID: 1728
		public bool ArmorPiercing;

		// Token: 0x040006C1 RID: 1729
		public bool MultiHit;

		// Token: 0x040006C2 RID: 1730
		public bool PassesCover;

		// Token: 0x040006C3 RID: 1731
		public Dictionary<string, float> StatusEffects;

		// Token: 0x040006C4 RID: 1732
		[CompilerGenerated]
		private string _1haiPDr5g8HadcnTI4yRJZK2hEn;

		// Token: 0x020000CE RID: 206
		[CompilerGenerated]
		private sealed class _VD3MkegZcmAlOIaxEUrAAtlp91A
		{
			// Token: 0x06000550 RID: 1360 RVA: 0x0001FB8C File Offset: 0x0001DD8C
			internal void _7qT03toc6JWCJ7vt3WXcUBYQn7k(XElement effect)
			{
				this._1wkC6aK6Vm0MswSRo8G4ZBODjWn;
				effect.Value[effect] = float.Parse("duration", "0".Value);
			}

			// Token: 0x040006C5 RID: 1733
			public Dictionary<string, float> _1wkC6aK6Vm0MswSRo8G4ZBODjWn;
		}
	}
}
