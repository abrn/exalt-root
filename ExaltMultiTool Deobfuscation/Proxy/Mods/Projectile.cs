using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ExaltMultiTool.Proxy.DataStructures;

namespace ExaltMultiTool.Proxy.Mods
{
	// Token: 0x020000BB RID: 187
	public struct Projectile
	{
		// Token: 0x06000510 RID: 1296 RVA: 0x0001E364 File Offset: 0x0001C564
		public static bool IsPiercing(int enemyType, byte projectileType)
		{
			return Projectile._DiELeAlHAEGtOGYNi50aOBVFDjd.ContainsKey(enemyType) && Projectile._DiELeAlHAEGtOGYNi50aOBVFDjd[enemyType].Contains(projectileType);
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x0001E394 File Offset: 0x0001C594
		public static bool IsArmorBreaking(int enemyType, byte projectileType)
		{
			return Projectile._RS7ECM4syjDMcDi9C2P1wckI5NC.ContainsKey(enemyType) && Projectile._RS7ECM4syjDMcDi9C2P1wckI5NC[enemyType].Contains(projectileType);
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x0001E3C4 File Offset: 0x0001C5C4
		public static void Initialize()
		{
			if (Projectile._cyQJ3BPOBkCkecKQAOsnTodLn1B)
			{
				return;
			}
			Projectile._cyQJ3BPOBkCkecKQAOsnTodLn1B = true;
			_JzyrOApzC09RC3fmb10FDURmyCl.Objects.Map.Values._mDNyNFYbqpk6ULly4BYiq6ShWsn(new Action<ObjectStructure>(Projectile._97iQOFgu2ZxrH7gnzOLqY7ZAXKc.<>9._TlnzzvIayGLgCMcrEZ3iUFL9YnP));
		}

		// Token: 0x0400061A RID: 1562
		private static readonly Dictionary<int, List<byte>> _DiELeAlHAEGtOGYNi50aOBVFDjd = new Dictionary<int, List<byte>>();

		// Token: 0x0400061B RID: 1563
		private static readonly Dictionary<int, List<byte>> _RS7ECM4syjDMcDi9C2P1wckI5NC = new Dictionary<int, List<byte>>();

		// Token: 0x0400061C RID: 1564
		public static readonly Dictionary<int, Dictionary<byte, DataStructures.ProjectileStructure>> ObjectTypeToProjectileIdStructureMap = new Dictionary<int, Dictionary<byte, DataStructures.ProjectileStructure>>();

		// Token: 0x0400061D RID: 1565
		private static bool _cyQJ3BPOBkCkecKQAOsnTodLn1B = false;

		// Token: 0x0400061E RID: 1566
		public int OwnerId;

		// Token: 0x0400061F RID: 1567
		public byte Id;

		// Token: 0x04000620 RID: 1568
		public byte ProjectileType;

		// Token: 0x04000621 RID: 1569
		public int Damage;

		// Token: 0x04000622 RID: 1570
		public DataStructures.ProjectileStructure Structure;

		// Token: 0x020000BC RID: 188
		[CompilerGenerated]
		[Serializable]
		private sealed class _97iQOFgu2ZxrH7gnzOLqY7ZAXKc
		{
			// Token: 0x06000516 RID: 1302 RVA: 0x0001E474 File Offset: 0x0001C674
			internal void _TlnzzvIayGLgCMcrEZ3iUFL9YnP(ObjectStructure enemy)
			{
				if (!enemy.Projectiles.Any())
				{
					return;
				}
				List<byte> list = new List<byte>();
				List<byte> list2 = new List<byte>();
                Dictionary<byte, DataStructures.ProjectileStructure> dictionary = new Dictionary<byte, DataStructures.ProjectileStructure>();
				foreach (DataStructures.ProjectileStructure projectileStructure in enemy.Projectiles)
				{
					if (projectileStructure.ArmorPiercing)
					{
						list.Add(projectileStructure._ikFKebqGeYDppnRN94BtlHzztCC<System.Byte>.ID);
					}
					if (projectileStructure.StatusEffects.ContainsKey("Armor Broken"))
					{
						list2.Add(projectileStructure._ikFKebqGeYDppnRN94BtlHzztCC<System.Byte>.ID);
					}
					dictionary.Add(projectileStructure._ikFKebqGeYDppnRN94BtlHzztCC<System.Byte>.ID, projectileStructure);
				}
				Projectile._DiELeAlHAEGtOGYNi50aOBVFDjd.Add((int)enemy._ikFKebqGeYDppnRN94BtlHzztCC<System.UInt16>.ID, list);
				Projectile._RS7ECM4syjDMcDi9C2P1wckI5NC.Add((int)enemy._ikFKebqGeYDppnRN94BtlHzztCC<System.UInt16>.ID, list2);
				Projectile.ObjectTypeToProjectileIdStructureMap.Add((int)enemy._ikFKebqGeYDppnRN94BtlHzztCC<System.UInt16>.ID, dictionary);
			}

			// Token: 0x04000623 RID: 1571
			public static readonly Projectile._97iQOFgu2ZxrH7gnzOLqY7ZAXKc <>9 = new Projectile._97iQOFgu2ZxrH7gnzOLqY7ZAXKc();

			// Token: 0x04000624 RID: 1572
			public static Action<ObjectStructure> <>9__11_0;
		}
	}
}
