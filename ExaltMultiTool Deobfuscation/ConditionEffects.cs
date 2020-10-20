using System;

// Token: 0x02000012 RID: 18
[Flags]
internal enum ConditionEffects
{
	// Token: 0x04000164 RID: 356
	Dead = 1,
	// Token: 0x04000165 RID: 357
	Quiet = 2,
	// Token: 0x04000166 RID: 358
	Weak = 4,
	// Token: 0x04000167 RID: 359
	Slowed = 8,
	// Token: 0x04000168 RID: 360
	Sick = 16,
	// Token: 0x04000169 RID: 361
	Dazed = 32,
	// Token: 0x0400016A RID: 362
	Stunned = 64,
	// Token: 0x0400016B RID: 363
	Blind = 128,
	// Token: 0x0400016C RID: 364
	Hallucinating = 256,
	// Token: 0x0400016D RID: 365
	Drunk = 512,
	// Token: 0x0400016E RID: 366
	Confused = 1024,
	// Token: 0x0400016F RID: 367
	StunImmume = 2048,
	// Token: 0x04000170 RID: 368
	Invisible = 4096,
	// Token: 0x04000171 RID: 369
	Paralyzed = 8192,
	// Token: 0x04000172 RID: 370
	Speedy = 16384,
	// Token: 0x04000173 RID: 371
	Bleeding = 32768,
	// Token: 0x04000174 RID: 372
	ArmorBrokenImmune = 65536,
	// Token: 0x04000175 RID: 373
	Healing = 131072,
	// Token: 0x04000176 RID: 374
	Damaging = 262144,
	// Token: 0x04000177 RID: 375
	Berserk = 524288,
	// Token: 0x04000178 RID: 376
	Paused = 1048576,
	// Token: 0x04000179 RID: 377
	Stasis = 2097152,
	// Token: 0x0400017A RID: 378
	StasisImmune = 4194304,
	// Token: 0x0400017B RID: 379
	Invincible = 8388608,
	// Token: 0x0400017C RID: 380
	Invulnerable = 16777216,
	// Token: 0x0400017D RID: 381
	Armored = 33554432,
	// Token: 0x0400017E RID: 382
	ArmorBroken = 67108864,
	// Token: 0x0400017F RID: 383
	Hexed = 134217728,
	// Token: 0x04000180 RID: 384
	AnotherSpeedy = 268435456,
	// Token: 0x04000181 RID: 385
	Unstable = 536870912,
	// Token: 0x04000182 RID: 386
	Darkness = 1073741824,
	// Token: 0x04000183 RID: 387
	HpBoost = 1048576
}
