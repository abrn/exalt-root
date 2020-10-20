using System;
using System.Linq;
using System.Runtime.CompilerServices;
using ExaltMultiTool.Properties;
using ExaltMultiTool.Proxy.DataStructures;

// Token: 0x020000BD RID: 189
internal class SafeWalk
{
	// Token: 0x06000517 RID: 1303 RVA: 0x0001E538 File Offset: 0x0001C738
	public SafeWalk(Client client)
	{
		this._W6Ov6AArxzTTDnCyBtZPqkqNaKf = client;
	}

	// Token: 0x06000518 RID: 1304 RVA: 0x0001E5E8 File Offset: 0x0001C7E8
	private bool _tNVnGb7wT30wYHlyz5P26VK4N9A(int x, int y)
	{
		int num = x * this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.MapWidth + y;
		return this._YDJPnvGydjRtHbTYPWxd7UiJCec[num];
	}

	// Token: 0x06000519 RID: 1305 RVA: 0x0001E610 File Offset: 0x0001C810
	private void _7SgGAwTfaktiXrT3QCykHV9mnw7(int x, int y, bool value)
	{
		int num = x * this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.MapWidth + y;
		this._YDJPnvGydjRtHbTYPWxd7UiJCec[num] = value;
	}

	// Token: 0x0600051A RID: 1306 RVA: 0x0001E638 File Offset: 0x0001C838
	public void MapInfo(MapInfoPacket mapInfo)
	{
		this._x042beur4ZH17DjAMLokZ55nUnB = mapInfo.DisplayName.ToLower().Contains("shatters");
		this._YDJPnvGydjRtHbTYPWxd7UiJCec = new bool[mapInfo.Width * mapInfo.Height];
	}

	// Token: 0x0600051B RID: 1307 RVA: 0x0001E678 File Offset: 0x0001C878
	public void Update(UpdatePacket update)
	{
		foreach (Entity entity in update.NewObjs)
		{
			ObjectStructure objectStructure = _JzyrOApzC09RC3fmb10FDURmyCl.Objects.ByID(entity.ObjectType);
			if (objectStructure != null && objectStructure.ProtectFromGroundDamage)
			{
				this._7SgGAwTfaktiXrT3QCykHV9mnw7((int)entity.Status.Position._MFEyfKFQqtcdaBxZbAOPzXMB8iP, (int)entity.Status.Position._vwAmCOilfBfnOBAh94J77UFd0FV, true);
			}
		}
		Tile[] ggcOirasY7xrclnb5yxgWCbeJam = update.Tiles;
		for (int i = 0; i < ggcOirasY7xrclnb5yxgWCbeJam.Length; i++)
		{
			SafeWalk._g1WDWSAbzyUpKozUw6l3xkhhISDA g1WDWSAbzyUpKozUw6l3xkhhISDA = new SafeWalk._g1WDWSAbzyUpKozUw6l3xkhhISDA();
			g1WDWSAbzyUpKozUw6l3xkhhISDA._mWe1fQ384BLZe9PnvAln1y7kKo = ggcOirasY7xrclnb5yxgWCbeJam[i];
			Square q3lhvRoGxDHbe4DHt5QEvG37i6dA = this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.TileAt((int)g1WDWSAbzyUpKozUw6l3xkhhISDA._mWe1fQ384BLZe9PnvAln1y7kKo.X, (int)g1WDWSAbzyUpKozUw6l3xkhhISDA._mWe1fQ384BLZe9PnvAln1y7kKo.Y);
			if (Settings.Default.EnableSafeWalk && (!this._x042beur4ZH17DjAMLokZ55nUnB || Settings.Default.SafeWalkInShatters) && q3lhvRoGxDHbe4DHt5QEvG37i6dA.Tile.MinDamage > 0 && !this._tNVnGb7wT30wYHlyz5P26VK4N9A((int)g1WDWSAbzyUpKozUw6l3xkhhISDA._mWe1fQ384BLZe9PnvAln1y7kKo.X, (int)g1WDWSAbzyUpKozUw6l3xkhhISDA._mWe1fQ384BLZe9PnvAln1y7kKo.Y))
			{
				g1WDWSAbzyUpKozUw6l3xkhhISDA._mWe1fQ384BLZe9PnvAln1y7kKo.Type = this._ZxBRntkKcr5OaFN9gyfy49Kgo2C;
			}
			else if (Settings.Default.EnableCustomNexus && this._dTuaCU4AfnCs9pYZeRjpD63NJTo.Any(new Func<TileStructure, bool>(g1WDWSAbzyUpKozUw6l3xkhhISDA._cK3tqcFri6sqAZcZMXo2Hx0C43c)))
			{
				g1WDWSAbzyUpKozUw6l3xkhhISDA._mWe1fQ384BLZe9PnvAln1y7kKo.Type = this._z9AeFwUcnW6WFZFN9LXLmHkxRUn._ikFKebqGeYDppnRN94BtlHzztCC<System.UInt16>.ID;
			}
		}
	}

	// Token: 0x04000625 RID: 1573
	private Client _W6Ov6AArxzTTDnCyBtZPqkqNaKf;

	// Token: 0x04000626 RID: 1574
	private bool[] _YDJPnvGydjRtHbTYPWxd7UiJCec;

	// Token: 0x04000627 RID: 1575
	private bool _x042beur4ZH17DjAMLokZ55nUnB;

	// Token: 0x04000628 RID: 1576
	private readonly ushort _ZxBRntkKcr5OaFN9gyfy49Kgo2C = _JzyrOApzC09RC3fmb10FDURmyCl.Tiles.ByName("EH Secret Floor")._ikFKebqGeYDppnRN94BtlHzztCC<System.UInt16>.ID;

	// Token: 0x04000629 RID: 1577
	private TileStructure _z9AeFwUcnW6WFZFN9LXLmHkxRUn = _JzyrOApzC09RC3fmb10FDURmyCl.Tiles.ByName("Crystal Cave Shallow Water");

	// Token: 0x0400062A RID: 1578
	private TileStructure[] _dTuaCU4AfnCs9pYZeRjpD63NJTo = new TileStructure[]
	{
		_JzyrOApzC09RC3fmb10FDURmyCl.Tiles.ByName("Pool"),
		_JzyrOApzC09RC3fmb10FDURmyCl.Tiles.ByID(14605),
		_JzyrOApzC09RC3fmb10FDURmyCl.Tiles.ByID(14788),
		_JzyrOApzC09RC3fmb10FDURmyCl.Tiles.ByID(14812),
		_JzyrOApzC09RC3fmb10FDURmyCl.Tiles.ByID(14771)
	};

	// Token: 0x020000BE RID: 190
	[CompilerGenerated]
	private sealed class _g1WDWSAbzyUpKozUw6l3xkhhISDA
	{
		// Token: 0x0600051D RID: 1309 RVA: 0x0001E7EC File Offset: 0x0001C9EC
		internal bool _cK3tqcFri6sqAZcZMXo2Hx0C43c(TileStructure type)
		{
			return type._ikFKebqGeYDppnRN94BtlHzztCC<System.UInt16>.ID == this._mWe1fQ384BLZe9PnvAln1y7kKo.Type;
		}

		// Token: 0x0400062B RID: 1579
		public Tile _mWe1fQ384BLZe9PnvAln1y7kKo;
	}
}
