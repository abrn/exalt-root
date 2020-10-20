using System;

// Token: 0x02000037 RID: 55
internal enum StatsTypeEnum
{
	// Token: 0x0400036A RID: 874
	MaximumHP,
	// Token: 0x0400036B RID: 875
	HP,
	// Token: 0x0400036C RID: 876
	Size,
	// Token: 0x0400036D RID: 877
	MaximumMP,
	// Token: 0x0400036E RID: 878
	MP,
	// Token: 0x0400036F RID: 879
	NextLevelExperience,
	// Token: 0x04000370 RID: 880
	Experience,
	// Token: 0x04000371 RID: 881
	Level,
	// Token: 0x04000372 RID: 882
	Inventory0,
	// Token: 0x04000373 RID: 883
	Inventory1,
	// Token: 0x04000374 RID: 884
	Inventory2,
	// Token: 0x04000375 RID: 885
	Inventory3,
	// Token: 0x04000376 RID: 886
	Inventory4,
	// Token: 0x04000377 RID: 887
	Inventory5,
	// Token: 0x04000378 RID: 888
	Inventory6,
	// Token: 0x04000379 RID: 889
	Inventory7,
	// Token: 0x0400037A RID: 890
	Inventory8,
	// Token: 0x0400037B RID: 891
	Inventory9,
	// Token: 0x0400037C RID: 892
	Inventory10,
	// Token: 0x0400037D RID: 893
	Inventory11,
	// Token: 0x0400037E RID: 894
	Attack,
	// Token: 0x0400037F RID: 895
	Defense,
	// Token: 0x04000380 RID: 896
	Speed,
	// Token: 0x04000381 RID: 897
	Vitality = 26,
	// Token: 0x04000382 RID: 898
	Wisdom,
	// Token: 0x04000383 RID: 899
	Dexterity,
	// Token: 0x04000384 RID: 900
	Effects,
	// Token: 0x04000385 RID: 901
	Stars,
	// Token: 0x04000386 RID: 902
	Name,
	// Token: 0x04000387 RID: 903
	Texture1,
	// Token: 0x04000388 RID: 904
	Texture2,
	// Token: 0x04000389 RID: 905
	MerchandiseType,
	// Token: 0x0400038A RID: 906
	Credits,
	// Token: 0x0400038B RID: 907
	MerchandisePrice,
	// Token: 0x0400038C RID: 908
	PortalUsable,
	// Token: 0x0400038D RID: 909
	AccountId,
	// Token: 0x0400038E RID: 910
	AccountFame,
	// Token: 0x0400038F RID: 911
	MerchandiseCurrency,
	// Token: 0x04000390 RID: 912
	ObjectConnection,
	// Token: 0x04000391 RID: 913
	MerchandiseRemainingCount,
	// Token: 0x04000392 RID: 914
	MerchandiseRemainingMinutes,
	// Token: 0x04000393 RID: 915
	MerchandiseDiscount,
	// Token: 0x04000394 RID: 916
	MerchandiseRankRequirement,
	// Token: 0x04000395 RID: 917
	HealthBonus,
	// Token: 0x04000396 RID: 918
	ManaBonus,
	// Token: 0x04000397 RID: 919
	AttackBonus,
	// Token: 0x04000398 RID: 920
	DefenseBonus,
	// Token: 0x04000399 RID: 921
	SpeedBonus,
	// Token: 0x0400039A RID: 922
	VitalityBonus,
	// Token: 0x0400039B RID: 923
	WisdomBonus,
	// Token: 0x0400039C RID: 924
	DexterityBonus,
	// Token: 0x0400039D RID: 925
	OwnerAccountId,
	// Token: 0x0400039E RID: 926
	RankRequired,
	// Token: 0x0400039F RID: 927
	NameChosen,
	// Token: 0x040003A0 RID: 928
	CharacterFame,
	// Token: 0x040003A1 RID: 929
	CharacterFameGoal,
	// Token: 0x040003A2 RID: 930
	Glowing,
	// Token: 0x040003A3 RID: 931
	SinkLevel,
	// Token: 0x040003A4 RID: 932
	AltTextureIndex,
	// Token: 0x040003A5 RID: 933
	GuildName,
	// Token: 0x040003A6 RID: 934
	GuildRank,
	// Token: 0x040003A7 RID: 935
	OxygenBar,
	// Token: 0x040003A8 RID: 936
	XpBoosterActive,
	// Token: 0x040003A9 RID: 937
	XpBoostTime,
	// Token: 0x040003AA RID: 938
	LootDropBoostTime,
	// Token: 0x040003AB RID: 939
	LootTierBoostTime,
	// Token: 0x040003AC RID: 940
	HealthPotionCount,
	// Token: 0x040003AD RID: 941
	MagicPotionCount,
	// Token: 0x040003AE RID: 942
	Backpack0,
	// Token: 0x040003AF RID: 943
	Backpack1,
	// Token: 0x040003B0 RID: 944
	Backpack2,
	// Token: 0x040003B1 RID: 945
	Backpack3,
	// Token: 0x040003B2 RID: 946
	Backpack4,
	// Token: 0x040003B3 RID: 947
	Backpack5,
	// Token: 0x040003B4 RID: 948
	Backpack6,
	// Token: 0x040003B5 RID: 949
	Backpack7,
	// Token: 0x040003B6 RID: 950
	HasBackpack,
	// Token: 0x040003B7 RID: 951
	Skin,
	// Token: 0x040003B8 RID: 952
	PetInstanceId,
	// Token: 0x040003B9 RID: 953
	PetName,
	// Token: 0x040003BA RID: 954
	PetType,
	// Token: 0x040003BB RID: 955
	PetRarity,
	// Token: 0x040003BC RID: 956
	PetMaximumLevel,
	// Token: 0x040003BD RID: 957
	PetFamily,
	// Token: 0x040003BE RID: 958
	PetPoints0,
	// Token: 0x040003BF RID: 959
	PetPoints1,
	// Token: 0x040003C0 RID: 960
	PetPoints2,
	// Token: 0x040003C1 RID: 961
	PetLevel0,
	// Token: 0x040003C2 RID: 962
	PetLevel1,
	// Token: 0x040003C3 RID: 963
	PetLevel2,
	// Token: 0x040003C4 RID: 964
	PetAbilityType0,
	// Token: 0x040003C5 RID: 965
	PetAbilityType1,
	// Token: 0x040003C6 RID: 966
	PetAbilityType2,
	// Token: 0x040003C7 RID: 967
	Effects2,
	// Token: 0x040003C8 RID: 968
	FortuneTokens,
	// Token: 0x040003C9 RID: 969
	SupporterPoints,
	// Token: 0x040003CA RID: 970
	SupporterStat,
	// Token: 0x040003CB RID: 971
	ChallengerStarBg,
	// Token: 0x040003CC RID: 972
	Unknown101,
	// Token: 0x040003CD RID: 973
	ProjectileSpeedMult,
	// Token: 0x040003CE RID: 974
	ProjectileLifeMult,
	// Token: 0x040003CF RID: 975
	CreatedTimestamp,
	// Token: 0x040003D0 RID: 976
	PowerupExtraAttack,
	// Token: 0x040003D1 RID: 977
	PowerupExtraDefense,
	// Token: 0x040003D2 RID: 978
	PowerupExtraSpeed,
	// Token: 0x040003D3 RID: 979
	PowerupExtraVitality,
	// Token: 0x040003D4 RID: 980
	PowerupExtraWisdom,
	// Token: 0x040003D5 RID: 981
	PowerupExtraDexterity,
	// Token: 0x040003D6 RID: 982
	PowerupExtraMaxHp,
	// Token: 0x040003D7 RID: 983
	PowerupExtraMaxMp,
	// Token: 0x040003D8 RID: 984
	PowerupDamageMult,
	// Token: 0x040003D9 RID: 985
	PetOwnerObjectId,
	// Token: 0x040003DA RID: 986
	GraveAccountId
}
