using System;
using System.Reflection;
using System.Text;

// Token: 0x02000033 RID: 51
internal class PlayerData
{
	// Token: 0x0600028B RID: 651 RVA: 0x00011740 File Offset: 0x0000F940
	public PlayerData(int ownerObjectId)
	{
		this.OwnerObjectId = ownerObjectId;
		this.Name = "";
	}

	// Token: 0x0600028C RID: 652 RVA: 0x000117A8 File Offset: 0x0000F9A8
	public PlayerData(int ownerObjectId, MapInfoPacket mapInfo)
	{
		this.OwnerObjectId = ownerObjectId;
		this.Name = "";
		this.MapName = mapInfo.Name;
		this.TeleportAllowed = mapInfo.AllowPlayerTeleport;
		this.MapWidth = mapInfo.Width;
		this.MapHeight = mapInfo.Height;
	}

	// Token: 0x0600028D RID: 653 RVA: 0x00011840 File Offset: 0x0000FA40
	public void Parse(UpdatePacket update)
	{
		foreach (Entity entity in update.NewObjs)
		{
			if (entity.Status.ObjectId == this.OwnerObjectId)
			{
				this.Class = (Classes)entity.ObjectType;
				this.Pos = entity.Status.Position;
				foreach (StatData statData in entity.Status.Data)
				{
					this.Parse(statData.Id, statData.IntValue, statData.StringValue);
				}
			}
		}
	}

	// Token: 0x0600028E RID: 654 RVA: 0x000118F8 File Offset: 0x0000FAF8
	public void Parse(NewTickPacket newTick)
	{
		foreach (Status status in newTick.Statuses)
		{
			if (status.ObjectId == this.OwnerObjectId)
			{
				foreach (StatData statData in status.Data)
				{
					this.Pos = status.Position;
					this.Parse(StatsType.Id, statData.IntValue, statData.StringValue);
				}
			}
		}
	}

	// Token: 0x0600028F RID: 655 RVA: 0x000119B8 File Offset: 0x0000FBB8
	public void Parse(int id, int intValue, string stringValue)
	{
		if (id == StatsType.MaximumHP)
		{
			this.MaxHealth = intValue;
			return;
		}
		if (id == StatsType.HP)
		{
			this.Health = intValue;
			return;
		}
		if (id == StatsType.MaximumMP)
		{
			this.MaxMana = intValue;
			return;
		}
		if (id == StatsType.MP)
		{
			this.Mana = intValue;
			return;
		}
		if (id == StatsType.NextLevelExperience)
		{
			this.XpGoal = intValue;
			return;
		}
		if (id == StatsType.Experience)
		{
			this.Xp = intValue;
			return;
		}
		if (id == StatsType.Level)
		{
			this.Level = intValue;
			return;
		}
		if (id == StatsType.Inventory0)
		{
			this.Slot[0] = intValue;
			return;
		}
		if (id == StatsType.Inventory1)
		{
			this.Slot[1] = intValue;
			return;
		}
		if (id == StatsType.Inventory2)
		{
			this.Slot[2] = intValue;
			return;
		}
		if (id == StatsType.Inventory3)
		{
			this.Slot[3] = intValue;
			return;
		}
		if (id == StatsType.Inventory4)
		{
			this.Slot[4] = intValue;
			return;
		}
		if (id == StatsType.Inventory5)
		{
			this.Slot[5] = intValue;
			return;
		}
		if (id == StatsType.Inventory6)
		{
			this.Slot[6] = intValue;
			return;
		}
		if (id == StatsType.Inventory7)
		{
			this.Slot[7] = intValue;
			return;
		}
		if (id == StatsType.Inventory8)
		{
			this.Slot[8] = intValue;
			return;
		}
		if (id == StatsType.Inventory9)
		{
			this.Slot[9] = intValue;
			return;
		}
		if (id == StatsType.Inventory10)
		{
			this.Slot[10] = intValue;
			return;
		}
		if (id == StatsType.Inventory11)
		{
			this.Slot[11] = intValue;
			return;
		}
		if (id == StatsType.Attack)
		{
			this.Attack = intValue;
			return;
		}
		if (id == StatsType.Defense)
		{
			this.Defense = intValue;
			return;
		}
		if (id == StatsType.Speed)
		{
			this.Speed = intValue;
			return;
		}
		if (id == StatsType.Vitality)
		{
			this.Vitality = intValue;
			return;
		}
		if (id == StatsType.Wisdom)
		{
			this.Wisdom = intValue;
			return;
		}
		if (id == StatsType.Dexterity)
		{
			this.Dexterity = intValue;
			return;
		}
		if (id == StatsType.Effects)
		{
			this.Effects = intValue;
			return;
		}
		if (id == StatsType.Stars)
		{
			this.Stars = intValue;
			return;
		}
		if (id == StatsType.Name)
		{
			this.Name = stringValue;
			return;
		}
		if (id == StatsType.Credits)
		{
			this.RealmGold = intValue;
			return;
		}
		if (id == StatsType.MerchandisePrice)
		{
			this.Price = intValue;
			return;
		}
		if (id == StatsType.AccountId)
		{
			this.AccountId = stringValue;
			return;
		}
		if (id == StatsType.AccountFame)
		{
			this.AccountFame = intValue;
			return;
		}
		if (id == StatsType.HealthBonus)
		{
			this.HealthBonus = intValue;
			return;
		}
		if (id == StatsType.ManaBonus)
		{
			this.ManaBonus = intValue;
			return;
		}
		if (id == StatsType.AttackBonus)
		{
			this.AttackBonus = intValue;
			return;
		}
		if (id == StatsType.DefenseBonus)
		{
			this.DefenseBonus = intValue;
			return;
		}
		if (id == StatsType.SpeedBonus)
		{
			this.SpeedBonus = intValue;
			return;
		}
		if (id == StatsType.VitalityBonus)
		{
			this.VitalityBonus = intValue;
			return;
		}
		if (id == StatsType.WisdomBonus)
		{
			this.WisdomBonus = intValue;
			return;
		}
		if (id == StatsType.DexterityBonus)
		{
			this.DexterityBonus = intValue;
			return;
		}
		if (id == StatsType.RankRequired)
		{
			this.NameChangeRankRequired = intValue;
			return;
		}
		if (id == StatsType.NameChosen)
		{
			this.NameChosen = (intValue > 0);
			return;
		}
		if (id == StatsType.CharacterFame)
		{
			this.CharacterFame = intValue;
			return;
		}
		if (id == StatsType.CharacterFameGoal)
		{
			this.CharacterFameGoal = intValue;
			return;
		}
		if (id == StatsType.Glowing)
		{
			this.GlowingEffect = (intValue > -1);
			return;
		}
		if (id == StatsType.GuildName)
		{
			this.GuildName = stringValue;
			return;
		}
		if (id == StatsType.GuildRank)
		{
			this.GuildRank = intValue;
			return;
		}
		if (id == StatsType.OxygenBar)
		{
			this.Breath = intValue;
			return;
		}
		if (id == StatsType.HealthPotionCount)
		{
			this.HealthPotionCount = intValue;
			return;
		}
		if (id == StatsType.MagicPotionCount)
		{
			this.MagicPotionCount = intValue;
			return;
		}
		if (id == StatsType.Backpack0)
		{
			this.BackPack[0] = intValue;
			return;
		}
		if (id == StatsType.Backpack1)
		{
			this.BackPack[1] = intValue;
			return;
		}
		if (id == StatsType.Backpack2)
		{
			this.BackPack[2] = intValue;
			return;
		}
		if (id == StatsType.Backpack3)
		{
			this.BackPack[3] = intValue;
			return;
		}
		if (id == StatsType.Backpack4)
		{
			this.BackPack[4] = intValue;
			return;
		}
		if (id == StatsType.Backpack5)
		{
			this.BackPack[5] = intValue;
			return;
		}
		if (id == StatsType.Backpack6)
		{
			this.BackPack[6] = intValue;
			return;
		}
		if (id == StatsType.Backpack7)
		{
			this.BackPack[7] = intValue;
			return;
		}
		if (id == StatsType.HasBackpack)
		{
			this.HasBackpack = (intValue > 0);
			return;
		}
		if (id == StatsType.Skin)
		{
			this.Skin = intValue;
		}
	}

	// Token: 0x06000290 RID: 656 RVA: 0x00012070 File Offset: 0x00010270
	public bool HasConditionEffect(ConditionEffects effect)
	{
		return (this.Effects & (int)effect) != 0;
	}

	// Token: 0x06000291 RID: 657 RVA: 0x00012088 File Offset: 0x00010288
	public float TilesPerTick()
	{
		return (4f + 5.6f * ((float)this.Speed / 75f)) / 5f;
	}

	// Token: 0x06000292 RID: 658 RVA: 0x000120B4 File Offset: 0x000102B4
	public override string ToString()
	{
		FieldInfo[] fields = base.GetType().GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(this.OwnerObjectId.ToString() + "'s PlayerData Instance");
		foreach (FieldInfo fieldInfo in fields)
		{
			if (fieldInfo.GetValue(this) != null)
			{
				StringBuilder stringBuilder2 = stringBuilder;
				string str = "\n\t";
				string name = fieldInfo.Name;
				string str2 = " => ";
				object value = fieldInfo.GetValue(this);
				stringBuilder2.Append(str + name + str2 + ((value != null) ? value.ToString() : null));
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x04000326 RID: 806
	public int OwnerObjectId;

	// Token: 0x04000327 RID: 807
	public string MapName;

	// Token: 0x04000328 RID: 808
	public bool TeleportAllowed;

	// Token: 0x04000329 RID: 809
	public int MapWidth;

	// Token: 0x0400032A RID: 810
	public int MapHeight;

	// Token: 0x0400032B RID: 811
	public int MaxHealth;

	// Token: 0x0400032C RID: 812
	public int Health;

	// Token: 0x0400032D RID: 813
	public int MaxMana;

	// Token: 0x0400032E RID: 814
	public int Mana;

	// Token: 0x0400032F RID: 815
	public int XpGoal;

	// Token: 0x04000330 RID: 816
	public int Xp;

	// Token: 0x04000331 RID: 817
	public int Level = 1;

	// Token: 0x04000332 RID: 818
	public int[] Slot = new int[]
	{
		-1,
		-1,
		-1,
		-1,
		-1,
		-1,
		-1,
		-1,
		-1,
		-1,
		-1,
		-1
	};

	// Token: 0x04000333 RID: 819
	public int[] BackPack = new int[]
	{
		-1,
		-1,
		-1,
		-1,
		-1,
		-1,
		-1,
		-1
	};

	// Token: 0x04000334 RID: 820
	public int Attack;

	// Token: 0x04000335 RID: 821
	public int Defense;

	// Token: 0x04000336 RID: 822
	public int Speed;

	// Token: 0x04000337 RID: 823
	public int Vitality;

	// Token: 0x04000338 RID: 824
	public int Wisdom;

	// Token: 0x04000339 RID: 825
	public int Dexterity;

	// Token: 0x0400033A RID: 826
	public int Effects;

	// Token: 0x0400033B RID: 827
	public int Stars;

	// Token: 0x0400033C RID: 828
	public string Name;

	// Token: 0x0400033D RID: 829
	public int RealmGold;

	// Token: 0x0400033E RID: 830
	public int Price;

	// Token: 0x0400033F RID: 831
	public bool CanEnterPortal;

	// Token: 0x04000340 RID: 832
	public string AccountId;

	// Token: 0x04000341 RID: 833
	public int AccountFame;

	// Token: 0x04000342 RID: 834
	public int HealthBonus;

	// Token: 0x04000343 RID: 835
	public int ManaBonus;

	// Token: 0x04000344 RID: 836
	public int AttackBonus;

	// Token: 0x04000345 RID: 837
	public int DefenseBonus;

	// Token: 0x04000346 RID: 838
	public int SpeedBonus;

	// Token: 0x04000347 RID: 839
	public int VitalityBonus;

	// Token: 0x04000348 RID: 840
	public int WisdomBonus;

	// Token: 0x04000349 RID: 841
	public int DexterityBonus;

	// Token: 0x0400034A RID: 842
	public int NameChangeRankRequired;

	// Token: 0x0400034B RID: 843
	public bool NameChosen;

	// Token: 0x0400034C RID: 844
	public int CharacterFame;

	// Token: 0x0400034D RID: 845
	public int CharacterFameGoal;

	// Token: 0x0400034E RID: 846
	public bool GlowingEffect;

	// Token: 0x0400034F RID: 847
	public string GuildName;

	// Token: 0x04000350 RID: 848
	public int GuildRank;

	// Token: 0x04000351 RID: 849
	public int Breath;

	// Token: 0x04000352 RID: 850
	public int HealthPotionCount;

	// Token: 0x04000353 RID: 851
	public int MagicPotionCount;

	// Token: 0x04000354 RID: 852
	public bool HasBackpack;

	// Token: 0x04000355 RID: 853
	public int Skin;

	// Token: 0x04000356 RID: 854
	public Location Pos = new Location();

	// Token: 0x04000357 RID: 855
	public Classes Class;
}
