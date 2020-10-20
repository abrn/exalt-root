using System;

internal static class ConditionEffect
{
	public const int NEW_CON_THRESHOLD = 32;

	public const int DEAD = 1;

	public const int QUIET = 2;

	public const int WEAK = 3;

	public const int SLOWED = 4;

	public const int SICK = 5;

	public const int DAZED = 6;

	public const int STUNNED = 7;

	public const int BLIND = 8;

	public const int HALLUCINATING = 9;

	public const int DRUNK = 10;

	public const int CONFUSED = 11;

	public const int STUN_IMMUNE = 12;

	public const int INVISIBLE = 13;

	public const int PARALYZED = 14;

	public const int SPEEDY = 15;

	public const int BLEEDING = 16;

	public const int ARMORBROKENIMMUNE = 17;

	public const int HEALING = 18;

	public const int DAMAGING = 19;

	public const int BERSERK = 20;

	public const int PAUSED = 21;

	public const int STASIS = 22;

	public const int STASIS_IMMUNE = 23;

	public const int INVINCIBLE = 24;

	public const int INVULNERABLE = 25;

	public const int ARMORED = 26;

	public const int ARMORBROKEN = 27;

	public const int HEXED = 28;

	public const int NINJA_SPEEDY = 29;

	public const int UNSTABLE = 30;

	public const int DARKNESS = 31;

	public const int SLOWED_IMMUNE = 32;

	public const int DAZED_IMMUNE = 33;

	public const int PARALYZED_IMMUNE = 34;

	public const int PETRIFIED = 35;

	public const int PETRIFIED_IMMUNE = 36;

	public const int PET_EFFECT_ICON = 37;

	public const int CURSE = 38;

	public const int CURSE_IMMUNE = 39;

	public const int HP_BOOST = 40;

	public const int MP_BOOST = 41;

	public const int ATT_BOOST = 42;

	public const int DEF_BOOST = 43;

	public const int SPD_BOOST = 44;

	public const int VIT_BOOST = 45;

	public const int WIS_BOOST = 46;

	public const int DEX_BOOST = 47;

	public const int SILENCED = 48;

	public const int EXPOSED = 49;

	public const int ENERGIZED = 50;

	public const int HP_DEBUFF = 51;

	public const int MP_DEBUFF = 52;

	public const int ATT_DEBUFF = 53;

	public const int DEF_DEBUFF = 54;

	public const int SPD_DEBUFF = 55;

	public const int VIT_DEBUFF = 56;

	public const int WIS_DEBUFF = 57;

	public const int DEX_DEBUFF = 58;

	public const int GROUND_DAMAGE = 99;

	public const int DEAD_BIT = 1;

	public const int QUIET_BIT = 2;

	public const int WEAK_BIT = 4;

	public const int SLOWED_BIT = 8;

	public const int SICK_BIT = 16;

	public const int DAZED_BIT = 32;

	public const int STUNNED_BIT = 64;

	public const int BLIND_BIT = 128;

	public const int HALLUCINATING_BIT = 256;

	public const int DRUNK_BIT = 512;

	public const int CONFUSED_BIT = 1024;

	public const int STUN_IMMUNE_BIT = 2048;

	public const int INVISIBLE_BIT = 4096;

	public const int PARALYZED_BIT = 8192;

	public const int SPEEDY_BIT = 16384;

	public const int BLEEDING_BIT = 32768;

	public const int ARMORBROKEN_IMMUNE_BIT = 65536;

	public const int HEALING_BIT = 131072;

	public const int DAMAGING_BIT = 262144;

	public const int BERSERK_BIT = 524288;

	public const int PAUSED_BIT = 1048576;

	public const int STASIS_BIT = 2097152;

	public const int STASIS_IMMUNE_BIT = 4194304;

	public const int INVINCIBLE_BIT = 8388608;

	public const int INVULNERABLE_BIT = 16777216;

	public const int ARMORED_BIT = 33554432;

	public const int ARMORBROKEN_BIT = 67108864;

	public const int HEXED_BIT = 134217728;

	public const int NINJA_SPEEDY_BIT = 268435456;

	public const int UNSTABLE_BIT = 536870912;

	public const long DARKNESS_BIT = 1073741824L;

	public const int SLOWED_IMMUNE_BIT = 1;

	public const int DAZED_IMMUNE_BIT = 2;

	public const int PARALYZED_IMMUNE_BIT = 4;

	public const int PETRIFIED_BIT = 8;

	public const int PETRIFIED_IMMUNE_BIT = 16;

	public const int PET_EFFECT_ICON_BIT = 32;

	public const int CURSE_BIT = 64;

	public const int CURSE_IMMUNE_BIT = 128;

	public const int HP_BOOST_BIT = 256;

	public const int MP_BOOST_BIT = 512;

	public const int ATT_BOOST_BIT = 1024;

	public const int DEF_BOOST_BIT = 2048;

	public const int SPD_BOOST_BIT = 4096;

	public const int VIT_BOOST_BIT = 8192;

	public const int WIS_BOOST_BIT = 16384;

	public const int DEX_BOOST_BIT = 32768;

	public const int SILENCED_BIT = 65536;

	public const int EXPOSED_BIT = 131072;

	public const int ENERGIZED_BIT = 262144;

	public const int HP_DEBUFF_BIT = 524288;

	public const int MP_DEBUFF_BIT = 1048576;

	public const int ATT_DEBUFF_BIT = 2097152;

	public const int DEF_DEBUFF_BIT = 4194304;

	public const int SPD_DEBUFF_BIT = 8388608;

	public const int VIT_DEBUFF_BIT = 16777216;

	public const int WIS_DEBUFF_BIT = 33554432;

	public const int DEX_DEBUFF_BIT = 67108864;
}
