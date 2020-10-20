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
		this.client = client;
	}

	// Token: 0x06000471 RID: 1137 RVA: 0x00017820 File Offset: 0x00015A20
	public void NewTick(NewTickPacket newTick)
	{
		if (!Settings.Default.EnableAntiDebuffs)
		{
			return;
		}
		Status status = null;
		foreach (Status status2 in newTick.Statuses)
		{
			if (status2.ObjectId == this.client.Player.ObjectId)
			{
				status = status2;
				break;
			}
		}
		if (status == null)
		{
			status = new Status
			{
				Data = new List<StatData>(),
				ObjectId = this.client.PlayerId,
				Position = this.client.Player.ServerPosition
			};
			status.Data.Add(this.PlayerCondition1Stat());
			status.Data.Add(this.PlayerCondition2Stat());
			newTick.Statuses.Add(status);
		}
		this.FixPlayerDebuffs(status.Data);
	}

	// Token: 0x06000472 RID: 1138 RVA: 0x00017910 File Offset: 0x00015B10
	private StatData PlayerCondition1Stat()
	{
		return new StatData
		{
			Id = StatsType.Effects,
			IntValue = this.client.Player.Effects1,
			StringValue = string.Empty
		};
	}

	// Token: 0x06000473 RID: 1139 RVA: 0x00017950 File Offset: 0x00015B50
	private StatData PlayerCondition2Stat()
	{
		return new StatData
		{
			Id = StatsType.Effects2,
			IntValue = this.client.Player.Effects2,
			StringValue = string.Empty
		};
	}

	// Token: 0x06000474 RID: 1140 RVA: 0x00017990 File Offset: 0x00015B90
	public void Move(MovePacket move)
	{
		this._lastUpdate = Environment.TickCount;
	}

	// Token: 0x06000475 RID: 1141 RVA: 0x000179A8 File Offset: 0x00015BA8
	public void AoE(AoEPacket aoe)
	{
		if (this.client.Player.ClientPosition.DistanceSquaredTo(aoe.Location) <= (double)(aoe.Radius * aoe.Radius))
		{
			this._aoeDebuff = true;
		}
	}

	// Token: 0x06000476 RID: 1142 RVA: 0x000179E8 File Offset: 0x00015BE8
	public void PlayerHit(PlayerHitPacket playerHit)
	{
		this._needsServerDebuffsFixed = true;
		if (!Settings.Default.EnableAntiDebuffs)
		{
			return;
		}
		if (!this.client.projectiles.ContainsKey(playerHit.ObjectId))
		{
			return;
		}
		Dictionary<int, Projectile> dictionary = this.client.projectiles[playerHit.ObjectId];
		if (!dictionary.ContainsKey((int)playerHit.BulletId))
		{
			return;
		}
		Dictionary<string, float> statusEffects = dictionary[(int)playerHit.BulletId].Structure.StatusEffects;
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
	private void FixPlayerDebuffs(List<StatData> statData)
	{
		StatData statData2 = null;
		StatData statData3 = null;
		foreach (StatData statData4 in statData)
		{
			if (StatsType.Id(statData4.Id, StatsType.Effects))
			{
				statData2 = statData4;
			}
			else if (StatsType.Id(statData4.Id, StatsType.Effects2))
			{
				statData3 = statData4;
			}
			if (statData2 != null && statData3 != null)
			{
				break;
			}
		}
		if (statData2 == null)
		{
			statData2 = this.PlayerCondition1Stat();
			statData.Add(statData2);
		}
		if (statData3 == null)
		{
			statData3 = this.PlayerCondition2Stat();
			statData.Add(statData3);
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
		statData2.IntValue &= ~num3;
		if (this._aoeDebuff)
		{
			this._aoeDebuff = false;
		}
		else if (this._needsServerDebuffsFixed)
		{
			statData2.IntValue &= ~num;
		}
		if (this._aoeDebuff)
		{
			this._aoeDebuff = false;
			return;
		}
		if (this._needsServerDebuffsFixed)
		{
			statData3.IntValue &= ~num2;
		}
	}

	// Token: 0x04000594 RID: 1428
	private Client client;

	// Token: 0x04000595 RID: 1429
	private bool _aoeDebuff;

	// Token: 0x04000596 RID: 1430
	private bool _needsServerDebuffsFixed;

	// Token: 0x04000597 RID: 1431
	private int _lastUpdate;

	// Token: 0x04000598 RID: 1432
	private object _ackLock = new object();

	// Token: 0x04000599 RID: 1433
	private int _skipAcks;
}
