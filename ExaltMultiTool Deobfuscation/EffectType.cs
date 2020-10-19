using System;
using System.ComponentModel;

// Token: 0x02000014 RID: 20
internal enum EffectType
{
	// Token: 0x040001B8 RID: 440
	[Description("Particles around player when they are healed")]
	Heal = 1,
	// Token: 0x040001B9 RID: 441
	[Description("Blue particles around players after they teleport")]
	Teleport,
	// Token: 0x040001BA RID: 442
	[Description("Unused Necromancer particle stream")]
	Stream,
	// Token: 0x040001BB RID: 443
	[Description("Bombs, Traps, Poisons")]
	Throw,
	// Token: 0x040001BC RID: 444
	[Description("AoE Buff particles")]
	Nova,
	// Token: 0x040001BD RID: 445
	[Description("Particles on a poisoned enemy")]
	Poison,
	// Token: 0x040001BE RID: 446
	[Description("Line effects like spellbomb to player and pet heals")]
	Line,
	// Token: 0x040001BF RID: 447
	[Description("AoE effects")]
	Burst,
	// Token: 0x040001C0 RID: 448
	[Description("Unused Necromancer particle stream")]
	Flow,
	// Token: 0x040001C1 RID: 449
	[Description("AoE effects")]
	Ring,
	// Token: 0x040001C2 RID: 450
	[Description("Scepter lightning")]
	Lightning,
	// Token: 0x040001C3 RID: 451
	[Description("Mystic Orb effect")]
	Collapse,
	// Token: 0x040001C4 RID: 452
	[Description("Unused 2D conical effect")]
	Coneblast,
	// Token: 0x040001C5 RID: 453
	[Description("Realm Earthquake")]
	Jitter,
	// Token: 0x040001C6 RID: 454
	[Description("Loot Bag despawn effect")]
	Flash,
	// Token: 0x040001C7 RID: 455
	[Description("Enemy projectile toss")]
	ThrowProjectile,
	// Token: 0x040001C8 RID: 456
	[Description("Pet Electric particles")]
	Shocker,
	// Token: 0x040001C9 RID: 457
	[Description("Electrified Enemy effect")]
	Shockee,
	// Token: 0x040001CA RID: 458
	[Description("Pet Rising Fury effect")]
	RisingFury,
	// Token: 0x040001CB RID: 459
	[Description("AoE Buff effects")]
	NovaNoAoe,
	// Token: 0x040001CC RID: 460
	[Description("Unknown")]
	InspiredEffect,
	// Token: 0x040001CD RID: 461
	[Description("Unknown")]
	HolyBeamEffect,
	// Token: 0x040001CE RID: 462
	[Description("Unknown")]
	CircleTelegraphEffect,
	// Token: 0x040001CF RID: 463
	[Description("Unknown")]
	ChaosBeamEffect,
	// Token: 0x040001D0 RID: 464
	[Description("Unknown")]
	TeleportMonsterEffect,
	// Token: 0x040001D1 RID: 465
	[Description("Unknown")]
	MeteorEffect,
	// Token: 0x040001D2 RID: 466
	[Description("Transformed Item Effects")]
	GildedBuff,
	// Token: 0x040001D3 RID: 467
	[Description("Transformed Item Effects")]
	JadeBuff,
	// Token: 0x040001D4 RID: 468
	[Description("Transformed Item Effects")]
	ChaosBuff,
	// Token: 0x040001D5 RID: 469
	[Description("Transformed Item Effects")]
	ThunderBuff,
	// Token: 0x040001D6 RID: 470
	[Description("Unknown")]
	StatusFlash,
	// Token: 0x040001D7 RID: 471
	[Description("Transformed Item Effects")]
	FireOrbBuff
}
