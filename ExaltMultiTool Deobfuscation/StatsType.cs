using System;

// Token: 0x02000039 RID: 57
internal class StatsType
{
	// Token: 0x060002AB RID: 683 RVA: 0x0001288C File Offset: 0x00010A8C
	private StatsType(byte type)
	{
		this.m_type = type;
	}

	// Token: 0x060002AC RID: 684 RVA: 0x000128A8 File Offset: 0x00010AA8
	public bool IsUTF()
	{
		return global::StatsType.Id(this, global::StatsType.AccountId) || global::StatsType.Id(this, global::StatsType.AccountId) || global::StatsType.Id(this, global::StatsType.OwnerAccountId) || global::StatsType.Id(this, global::StatsType.GuildName) || global::StatsType.Id(this, global::StatsType.PetName) || global::StatsType.Id(this, global::StatsType._C70xyl0DG8J6CHk50QAawecBNb1);
	}

	// Token: 0x060002AD RID: 685 RVA: 0x00012904 File Offset: 0x00010B04
	public static implicit operator StatsType(int type)
	{
		if (type > 255)
		{
			throw new Exception("Not a valid StatData number.");
		}
		return new StatsType((byte)type);
	}


	// Token: 0x060002AF RID: 687 RVA: 0x00012958 File Offset: 0x00010B58
	public static implicit operator StatsType(byte type)
	{
		return new StatsType(type);
	}

	// Token: 0x060002B0 RID: 688 RVA: 0x00012970 File Offset: 0x00010B70
	public static bool _cdabW7ae4EGEYdLXJ4tAOcCD3GUA(StatsType type, int id)
	{
		if (id > 255)
		{
			throw new Exception("Not a valid StatData number.");
		}
		return type.m_type != (byte)id;
	}

	// Token: 0x060002B1 RID: 689 RVA: 0x000129A0 File Offset: 0x00010BA0
	public static bool _cdabW7ae4EGEYdLXJ4tAOcCD3GUA(StatsType type, byte id)
	{
		return type.m_type != id;
	}

    internal static UpdatePacket Id(StatsType id)
    {
        throw new NotImplementedException();
    }

    // Token: 0x060002B2 RID: 690 RVA: 0x000129BC File Offset: 0x00010BBC
    public static bool Id(StatsType type, StatsType id)
	{
		return type.m_type == id.m_type;
	}

	// Token: 0x060002B3 RID: 691 RVA: 0x000129D8 File Offset: 0x00010BD8
	public static bool Id(StatsType type, StatsType id)
	{
		return type.m_type != id.m_type;
	}

	// Token: 0x060002B4 RID: 692 RVA: 0x000129F8 File Offset: 0x00010BF8
	public static int _aB83fkaWIFXdehxJ8Dj9IX8iZ3m(StatsType type)
	{
		return (int)type.m_type;
	}

	// Token: 0x060002B5 RID: 693 RVA: 0x00012A0C File Offset: 0x00010C0C
	public static byte _aB83fkaWIFXdehxJ8Dj9IX8iZ3m(StatsType type)
	{
		return type.m_type;
	}

	// Token: 0x060002B6 RID: 694 RVA: 0x00012A20 File Offset: 0x00010C20
	public override int GetHashCode()
	{
		return base.GetHashCode();
	}

	// Token: 0x060002B7 RID: 695 RVA: 0x00012A34 File Offset: 0x00010C34
	public override bool Equals(object obj)
	{
		return obj is StatsType && global::StatsType.Id(this, (StatsType)obj);
	}

	// Token: 0x060002B8 RID: 696 RVA: 0x00012A58 File Offset: 0x00010C58
	public override string ToString()
	{
		return this.m_type.ToString();
	}

	// Token: 0x040003DE RID: 990
	public static readonly StatsType _DVNBi2eQHLdmlmNyYH05WDcfCzq = new StatsType(0);

	// Token: 0x040003DF RID: 991
	public static readonly StatsType HP = new StatsType(1);

	// Token: 0x040003E0 RID: 992
	public static readonly StatsType Size = new StatsType(2);

	// Token: 0x040003E1 RID: 993
	public static readonly StatsType MaximumMP = new StatsType(3);

	// Token: 0x040003E2 RID: 994
	public static readonly StatsType MP = new StatsType(4);

	// Token: 0x040003E3 RID: 995
	public static readonly StatsType NextLevelExperience = new StatsType(5);

	// Token: 0x040003E4 RID: 996
	public static readonly StatsType Experience = new StatsType(6);

	// Token: 0x040003E5 RID: 997
	public static readonly StatsType Level = new StatsType(7);

	// Token: 0x040003E6 RID: 998
	public static readonly StatsType Inventory0 = new StatsType(8);

	// Token: 0x040003E7 RID: 999
	public static readonly StatsType Inventory1 = new StatsType(9);

	// Token: 0x040003E8 RID: 1000
	public static readonly StatsType Inventory2 = new StatsType(10);

	// Token: 0x040003E9 RID: 1001
	public static readonly StatsType Inventory3 = new StatsType(11);

	// Token: 0x040003EA RID: 1002
	public static readonly StatsType Inventory4 = new StatsType(12);

	// Token: 0x040003EB RID: 1003
	public static readonly StatsType Inventory5 = new StatsType(13);

	// Token: 0x040003EC RID: 1004
	public static readonly StatsType Inventory6 = new StatsType(14);

	// Token: 0x040003ED RID: 1005
	public static readonly StatsType Inventory7 = new StatsType(15);

	// Token: 0x040003EE RID: 1006
	public static readonly StatsType Inventory8 = new StatsType(16);

	// Token: 0x040003EF RID: 1007
	public static readonly StatsType Inventory9 = new StatsType(17);

	// Token: 0x040003F0 RID: 1008
	public static readonly StatsType Inventory10 = new StatsType(18);

	// Token: 0x040003F1 RID: 1009
	public static readonly StatsType Inventory11 = new StatsType(19);

	// Token: 0x040003F2 RID: 1010
	public static readonly StatsType Attack = new StatsType(20);

	// Token: 0x040003F3 RID: 1011
	public static readonly StatsType Defense = new StatsType(21);

	// Token: 0x040003F4 RID: 1012
	public static readonly StatsType Speed = new StatsType(22);

	// Token: 0x040003F5 RID: 1013
	public static readonly StatsType Vitality = new StatsType(26);

	// Token: 0x040003F6 RID: 1014
	public static readonly StatsType Wisdom = new StatsType(27);

	// Token: 0x040003F7 RID: 1015
	public static readonly StatsType Dexterity = new StatsType(28);

	// Token: 0x040003F8 RID: 1016
	public static readonly StatsType Effects = new StatsType(29);

	// Token: 0x040003F9 RID: 1017
	public static readonly StatsType Stars = new StatsType(30);

	// Token: 0x040003FA RID: 1018
	public static readonly StatsType Name = new StatsType(31);

	// Token: 0x040003FB RID: 1019
	public static readonly StatsType Texture1 = new StatsType(32);

	// Token: 0x040003FC RID: 1020
	public static readonly StatsType Texture2 = new StatsType(33);

	// Token: 0x040003FD RID: 1021
	public static readonly StatsType MerchandiseType = new StatsType(34);

	// Token: 0x040003FE RID: 1022
	public static readonly StatsType Credits = new StatsType(35);

	// Token: 0x040003FF RID: 1023
	public static readonly StatsType MerchandisePrice = new StatsType(36);

	// Token: 0x04000400 RID: 1024
	public static readonly StatsType PortalUsable = new StatsType(37);

	// Token: 0x04000401 RID: 1025
	public static readonly StatsType AccountId = new StatsType(38);

	// Token: 0x04000402 RID: 1026
	public static readonly StatsType AccountFame = new StatsType(39);

	// Token: 0x04000403 RID: 1027
	public static readonly StatsType MerchandiseCurrency = new StatsType(40);

	// Token: 0x04000404 RID: 1028
	public static readonly StatsType ObjectConnection = new StatsType(41);

	// Token: 0x04000405 RID: 1029
	public static readonly StatsType MerchandiseRemainingCount = new StatsType(42);

	// Token: 0x04000406 RID: 1030
	public static readonly StatsType MerchandiseRemainingMinutes = new StatsType(43);

	// Token: 0x04000407 RID: 1031
	public static readonly StatsType MerchandiseDiscount = new StatsType(44);

	// Token: 0x04000408 RID: 1032
	public static readonly StatsType MerchandiseRankRequirement = new StatsType(45);

	// Token: 0x04000409 RID: 1033
	public static readonly StatsType HealthBonus = new StatsType(46);

	// Token: 0x0400040A RID: 1034
	public static readonly StatsType ManaBonus = new StatsType(47);

	// Token: 0x0400040B RID: 1035
	public static readonly StatsType AttackBonus = new StatsType(48);

	// Token: 0x0400040C RID: 1036
	public static readonly StatsType DefenseBonus = new StatsType(49);

	// Token: 0x0400040D RID: 1037
	public static readonly StatsType SpeedBonus = new StatsType(50);

	// Token: 0x0400040E RID: 1038
	public static readonly StatsType VitalityBonus = new StatsType(51);

	// Token: 0x0400040F RID: 1039
	public static readonly StatsType WisdomBonus = new StatsType(52);

	// Token: 0x04000410 RID: 1040
	public static readonly StatsType DexterityBonus = new StatsType(53);

	// Token: 0x04000411 RID: 1041
	public static readonly StatsType OwnerAccountId = new StatsType(54);

	// Token: 0x04000412 RID: 1042
	public static readonly StatsType RankRequired = new StatsType(55);

	// Token: 0x04000413 RID: 1043
	public static readonly StatsType NameChosen = new StatsType(56);

	// Token: 0x04000414 RID: 1044
	public static readonly StatsType CharacterFame = new StatsType(57);

	// Token: 0x04000415 RID: 1045
	public static readonly StatsType CharacterFameGoal = new StatsType(58);

	// Token: 0x04000416 RID: 1046
	public static readonly StatsType Glowing = new StatsType(59);

	// Token: 0x04000417 RID: 1047
	public static readonly StatsType SinkLevel = new StatsType(60);

	// Token: 0x04000418 RID: 1048
	public static readonly StatsType AltTextureIndex = new StatsType(61);

	// Token: 0x04000419 RID: 1049
	public static readonly StatsType GuildName = new StatsType(62);

	// Token: 0x0400041A RID: 1050
	public static readonly StatsType GuildRank = new StatsType(63);

	// Token: 0x0400041B RID: 1051
	public static readonly StatsType OxygenBar = new StatsType(64);

	// Token: 0x0400041C RID: 1052
	public static readonly StatsType XpBoosterActive = new StatsType(65);

	// Token: 0x0400041D RID: 1053
	public static readonly StatsType XpBoostTime = new StatsType(66);

	// Token: 0x0400041E RID: 1054
	public static readonly StatsType LootDropBoostTime = new StatsType(67);

	// Token: 0x0400041F RID: 1055
	public static readonly StatsType LootTierBoostTime = new StatsType(68);

	// Token: 0x04000420 RID: 1056
	public static readonly StatsType HealthPotionCount = new StatsType(69);

	// Token: 0x04000421 RID: 1057
	public static readonly StatsType MagicPotionCount = new StatsType(70);

	// Token: 0x04000422 RID: 1058
	public static readonly StatsType Backpack0 = new StatsType(71);

	// Token: 0x04000423 RID: 1059
	public static readonly StatsType Backpack1 = new StatsType(72);

	// Token: 0x04000424 RID: 1060
	public static readonly StatsType Backpack2 = new StatsType(73);

	// Token: 0x04000425 RID: 1061
	public static readonly StatsType Backpack3 = new StatsType(74);

	// Token: 0x04000426 RID: 1062
	public static readonly StatsType Backpack4 = new StatsType(75);

	// Token: 0x04000427 RID: 1063
	public static readonly StatsType Backpack5 = new StatsType(76);

	// Token: 0x04000428 RID: 1064
	public static readonly StatsType Backpack6 = new StatsType(77);

	// Token: 0x04000429 RID: 1065
	public static readonly StatsType Backpack7 = new StatsType(78);

	// Token: 0x0400042A RID: 1066
	public static readonly StatsType HasBackpack = new StatsType(79);

	// Token: 0x0400042B RID: 1067
	public static readonly StatsType Skin = new StatsType(80);

	// Token: 0x0400042C RID: 1068
	public static readonly StatsType PetInstanceId = new StatsType(81);

	// Token: 0x0400042D RID: 1069
	public static readonly StatsType PetName = new StatsType(82);

	// Token: 0x0400042E RID: 1070
	public static readonly StatsType PetType = new StatsType(83);

	// Token: 0x0400042F RID: 1071
	public static readonly StatsType PetRarity = new StatsType(84);

	// Token: 0x04000430 RID: 1072
	public static readonly StatsType PetMaximumLevel = new StatsType(85);

	// Token: 0x04000431 RID: 1073
	public static readonly StatsType PetFamily = new StatsType(86);

	// Token: 0x04000432 RID: 1074
	public static readonly StatsType PetPoints0 = new StatsType(87);

	// Token: 0x04000433 RID: 1075
	public static readonly StatsType PetPoints1 = new StatsType(88);

	// Token: 0x04000434 RID: 1076
	public static readonly StatsType PetPoints2 = new StatsType(89);

	// Token: 0x04000435 RID: 1077
	public static readonly StatsType PetLevel0 = new StatsType(90);

	// Token: 0x04000436 RID: 1078
	public static readonly StatsType PetLevel1 = new StatsType(91);

	// Token: 0x04000437 RID: 1079
	public static readonly StatsType PetLevel2 = new StatsType(92);

	// Token: 0x04000438 RID: 1080
	public static readonly StatsType PetAbilityType0 = new StatsType(93);

	// Token: 0x04000439 RID: 1081
	public static readonly StatsType PetAbilityType1 = new StatsType(94);

	// Token: 0x0400043A RID: 1082
	public static readonly StatsType PetAbilityType2 = new StatsType(95);

	// Token: 0x0400043B RID: 1083
	public static readonly StatsType Effects2 = new StatsType(96);

	// Token: 0x0400043C RID: 1084
	public static readonly StatsType FortuneTokens = new StatsType(97);

	// Token: 0x0400043D RID: 1085
	public static readonly StatsType SupporterPoints = new StatsType(98);

	// Token: 0x0400043E RID: 1086
	public static readonly StatsType SupporterStat = new StatsType(99);

	// Token: 0x0400043F RID: 1087
	public static readonly StatsType ChallengerStarBgStat = new StatsType(100);

	// Token: 0x04000441 RID: 1089
	public static readonly StatsType ProjectileSpeedMult = new StatsType(102);

	// Token: 0x04000442 RID: 1090
	public static readonly StatsType ProjectileLifeMult = new StatsType(103);

	// Token: 0x0400044F RID: 1103
	private byte m_type;

    internal static int statData(StatsType id)
    {
        throw new NotImplementedException();
    }
}
