using System;
using System.Collections.Generic;
using ExaltMultiTool.Properties;
using ExaltMultiTool.Proxy.Mods;

// Token: 0x020000A6 RID: 166
internal class AntiDebuffs
{
	// Token: 0x06000470 RID: 1136 RVA: 0x000177F8 File Offset: 0x000159F8
	public AntiDebuffs(Client client)
	{
		this._W6Ov6AArxzTTDnCyBtZPqkqNaKf = client;
	}

	// Token: 0x06000471 RID: 1137 RVA: 0x00017820 File Offset: 0x00015A20
	public void NewTick(NewTickPacket newTick)
	{
		if (!Settings.Default.EnableAntiDebuffs)
		{
			return;
		}
		Status seOURj9wT08Ssc6bZOctUjk0KXi = null;
		foreach (Status seOURj9wT08Ssc6bZOctUjk0KXi2 in newTick.Statuses)
		{
			if (seOURj9wT08Ssc6bZOctUjk0KXi2.ObjectId == this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player.ObjectId)
			{
				seOURj9wT08Ssc6bZOctUjk0KXi = seOURj9wT08Ssc6bZOctUjk0KXi2;
				break;
			}
		}
		if (seOURj9wT08Ssc6bZOctUjk0KXi == null)
		{
			seOURj9wT08Ssc6bZOctUjk0KXi = new Status
			{
				Data = new List<StatData>(),
				ObjectId = this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.PlayerId,
				Position = this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player.ServerPosition
			};
			seOURj9wT08Ssc6bZOctUjk0KXi.Data.Add(this._KEQIdUAoYNBIHfaEKlzmaWZQkEC());
			seOURj9wT08Ssc6bZOctUjk0KXi.Data.Add(this._R4vmt8ecPBQme5f0uUVLIH2bKDG());
			newTick.Statuses.Add(seOURj9wT08Ssc6bZOctUjk0KXi);
		}
		this._AKCOFhegR11yfoKc9xutW4J2KQD(seOURj9wT08Ssc6bZOctUjk0KXi.Data);
	}

	// Token: 0x06000472 RID: 1138 RVA: 0x00017910 File Offset: 0x00015B10
	private StatData _KEQIdUAoYNBIHfaEKlzmaWZQkEC()
	{
		return new StatData
		{
			Id = StatsType.Effects,
			IntValue = this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player._9WuxzHMDBJLJDLP6NlgGdo38O6r,
			StringValue = string.Empty
		};
	}

	// Token: 0x06000473 RID: 1139 RVA: 0x00017950 File Offset: 0x00015B50
	private StatData _R4vmt8ecPBQme5f0uUVLIH2bKDG()
	{
		return new StatData
		{
			Id = StatsType._Vn1UXDYsa7sb8qGDESMjPifFRtx,
			IntValue = this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player._Vn1UXDYsa7sb8qGDESMjPifFRtx,
			StringValue = string.Empty
		};
	}

	// Token: 0x06000474 RID: 1140 RVA: 0x00017990 File Offset: 0x00015B90
	public void move(MovePacket move)
	{
		this._y197qHnAdnQHPqX30R0Bq0tjIOcA = Environment.TickCount;
	}

	// Token: 0x06000475 RID: 1141 RVA: 0x000179A8 File Offset: 0x00015BA8
	public void _M1PxW31jx87SGG4gvOYAwe86vjg(_PQHQze9k9pObME2LmlIcbfEeSYS aoe)
	{
		if (this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player._G6mmnFaa6rCvH24Jwj69ERi78ww.DistanceSquaredTo(aoe._v9pyCwpTOdm9mtxft8q4OoLOE3B) <= (double)(aoe._Vzv7oRwBjKStnFVmjJ1K02kmfeb * aoe._Vzv7oRwBjKStnFVmjJ1K02kmfeb))
		{
			this._lCHpBLOJucYfs9PNmew5HRojkKY = true;
		}
	}

	// Token: 0x06000476 RID: 1142 RVA: 0x000179E8 File Offset: 0x00015BE8
	public void PlayerHit(PlayerHitPacket playerHit)
	{
		this._gIfpqrMKQDoYj3Noc8rkgoNIcFb = true;
		if (!Settings.Default.EnableAntiDebuffs)
		{
			return;
		}
		if (!this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.projectiles.ContainsKey(playerHit._605Ligxeaj9k9kBV8zQhhFhgTGl))
		{
			return;
		}
		Dictionary<int, Projectile> dictionary = this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.projectiles[playerHit._605Ligxeaj9k9kBV8zQhhFhgTGl];
		if (!dictionary.ContainsKey((int)playerHit._0v4mmgyFOmt9eSc23UclkqyBncC))
		{
			return;
		}
		Dictionary<string, float> statusEffects = dictionary[(int)playerHit._0v4mmgyFOmt9eSc23UclkqyBncC].Structure.StatusEffects;
		if (Settings.Default.IgnoreQuiet && statusEffects.ContainsKey("Quiet"))
		{
			playerHit.Send = false;
			return;
		}
		if (Settings.Default.IgnoreWeak && statusEffects.ContainsKey("Weak"))
		{
			playerHit.Send = false;
			return;
		}
		if (Settings.Default.IgnoreSlowed && statusEffects.ContainsKey("Slowed"))
		{
			playerHit.Send = false;
			return;
		}
		if (Settings.Default.IgnoreSick && statusEffects.ContainsKey("Sick"))
		{
			playerHit.Send = false;
			return;
		}
		if (Settings.Default.IgnoreDazed && statusEffects.ContainsKey("Dazed"))
		{
			playerHit.Send = false;
			return;
		}
		if (Settings.Default.IgnoreStunned && statusEffects.ContainsKey("Stunned"))
		{
			playerHit.Send = false;
			return;
		}
		if (Settings.Default.IgnoreParalyzed && statusEffects.ContainsKey("Paralyzed"))
		{
			playerHit.Send = false;
			return;
		}
		if (Settings.Default.IgnoreBleeding && statusEffects.ContainsKey("Bleeding"))
		{
			playerHit.Send = false;
			return;
		}
		if (Settings.Default.IgnoreArmorBreak && statusEffects.ContainsKey("ArmorBreak"))
		{
			playerHit.Send = false;
			return;
		}
		if (Settings.Default.IgnorePetStasis && statusEffects.ContainsKey("PetStasis"))
		{
			playerHit.Send = false;
			return;
		}
		if (Settings.Default.IgnorePetrified && statusEffects.ContainsKey("Petrified"))
		{
			playerHit.Send = false;
			return;
		}
		if (Settings.Default.IgnoreSilence && statusEffects.ContainsKey("Silence"))
		{
			playerHit.Send = false;
			return;
		}
	}

	// Token: 0x06000477 RID: 1143 RVA: 0x00017BF4 File Offset: 0x00015DF4
	private void _AKCOFhegR11yfoKc9xutW4J2KQD(List<StatData> statData)
	{
		StatData eawaZQvtvbptP3yFgHw8DNBicDZ = null;
		StatData eawaZQvtvbptP3yFgHw8DNBicDZ2 = null;
		foreach (StatData eawaZQvtvbptP3yFgHw8DNBicDZ3 in statData)
		{
			if (StatsType.Id(eawaZQvtvbptP3yFgHw8DNBicDZ3.Id, StatsType.Effects))
			{
				eawaZQvtvbptP3yFgHw8DNBicDZ = eawaZQvtvbptP3yFgHw8DNBicDZ3;
			}
			else if (StatsType.Id(eawaZQvtvbptP3yFgHw8DNBicDZ3.Id, StatsType._Vn1UXDYsa7sb8qGDESMjPifFRtx))
			{
				eawaZQvtvbptP3yFgHw8DNBicDZ2 = eawaZQvtvbptP3yFgHw8DNBicDZ3;
			}
			if (eawaZQvtvbptP3yFgHw8DNBicDZ != null && eawaZQvtvbptP3yFgHw8DNBicDZ2 != null)
			{
				break;
			}
		}
		if (eawaZQvtvbptP3yFgHw8DNBicDZ == null)
		{
			eawaZQvtvbptP3yFgHw8DNBicDZ = this._KEQIdUAoYNBIHfaEKlzmaWZQkEC();
			statData.Add(eawaZQvtvbptP3yFgHw8DNBicDZ);
		}
		if (eawaZQvtvbptP3yFgHw8DNBicDZ2 == null)
		{
			eawaZQvtvbptP3yFgHw8DNBicDZ2 = this._R4vmt8ecPBQme5f0uUVLIH2bKDG();
			statData.Add(eawaZQvtvbptP3yFgHw8DNBicDZ2);
		}
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		if (Settings.Default.IgnoreQuiet)
		{
			num |= 2;
		}
		if (Settings.Default.IgnoreWeak)
		{
			num |= 4;
		}
		if (Settings.Default.IgnoreSlowed)
		{
			num |= 8;
		}
		if (Settings.Default.IgnoreSick)
		{
			num |= 16;
		}
		if (Settings.Default.IgnoreDazed)
		{
			num |= 32;
		}
		if (Settings.Default.IgnoreStunned)
		{
			num |= 64;
		}
		if (Settings.Default.IgnoreParalyzed)
		{
			num |= 8192;
		}
		if (Settings.Default.IgnoreBleeding)
		{
			num |= 32768;
		}
		if (Settings.Default.IgnoreArmorBreak)
		{
			num |= 67108864;
		}
		if (Settings.Default.IgnorePetStasis)
		{
			num |= 2097152;
		}
		if (Settings.Default.IgnoreBlind)
		{
			num3 |= 128;
		}
		if (Settings.Default.IgnoreHallucinating)
		{
			num3 |= 256;
		}
		if (Settings.Default.IgnoreDrunk)
		{
			num3 |= 512;
		}
		if (Settings.Default.IgnoreConfused)
		{
			num3 |= 1024;
		}
		if (Settings.Default.IgnoreUnstable)
		{
			num3 |= 536870912;
		}
		if (Settings.Default.IgnoreDarkness)
		{
			num3 |= 1073741824;
		}
		if (Settings.Default.IgnorePetrified)
		{
			num2 |= 8;
		}
		if (Settings.Default.IgnoreSilence)
		{
			num2 |= 65536;
		}
		eawaZQvtvbptP3yFgHw8DNBicDZ.IntValue &= ~num3;
		if (this._lCHpBLOJucYfs9PNmew5HRojkKY)
		{
			this._lCHpBLOJucYfs9PNmew5HRojkKY = false;
		}
		else if (this._gIfpqrMKQDoYj3Noc8rkgoNIcFb)
		{
			eawaZQvtvbptP3yFgHw8DNBicDZ.IntValue &= ~num;
		}
		if (this._lCHpBLOJucYfs9PNmew5HRojkKY)
		{
			this._lCHpBLOJucYfs9PNmew5HRojkKY = false;
			return;
		}
		if (this._gIfpqrMKQDoYj3Noc8rkgoNIcFb)
		{
			eawaZQvtvbptP3yFgHw8DNBicDZ2.IntValue &= ~num2;
		}
	}

	// Token: 0x04000594 RID: 1428
	private Client _W6Ov6AArxzTTDnCyBtZPqkqNaKf;

	// Token: 0x04000595 RID: 1429
	private bool _lCHpBLOJucYfs9PNmew5HRojkKY;

	// Token: 0x04000596 RID: 1430
	private bool _gIfpqrMKQDoYj3Noc8rkgoNIcFb;

	// Token: 0x04000597 RID: 1431
	private int _y197qHnAdnQHPqX30R0Bq0tjIOcA;

	// Token: 0x04000598 RID: 1432
	private object _GVQZwd9Q3A67KafuVB7LPIBWqKe = new object();

	// Token: 0x04000599 RID: 1433
	private int _QetDgqwKLXTfa05bFRH0dR9FaXkb;
}
