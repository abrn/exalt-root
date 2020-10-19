using System;
using System.CodeDom.Compiler;
using System.Collections.Specialized;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ExaltMultiTool.Properties
{
	// Token: 0x02000010 RID: 16
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.7.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000078 RID: 120 RVA: 0x0000B28C File Offset: 0x0000948C
		public static Settings Default
		{
			get
			{
				return Settings._9gQQs5d1bS4tMxTYaUvZ3j6UZwe;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000079 RID: 121 RVA: 0x0000B2A0 File Offset: 0x000094A0
		// (set) Token: 0x0600007A RID: 122 RVA: 0x0000B2C0 File Offset: 0x000094C0
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string ExaltGamePath
		{
			get
			{
				return (string)this["ExaltGamePath"];
			}
			set
			{
				this["ExaltGamePath"] = value;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600007B RID: 123 RVA: 0x0000B2DC File Offset: 0x000094DC
		// (set) Token: 0x0600007C RID: 124 RVA: 0x0000B2FC File Offset: 0x000094FC
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string ExaltLauncherPath
		{
			get
			{
				return (string)this["ExaltLauncherPath"];
			}
			set
			{
				this["ExaltLauncherPath"] = value;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600007D RID: 125 RVA: 0x0000B318 File Offset: 0x00009518
		// (set) Token: 0x0600007E RID: 126 RVA: 0x0000B338 File Offset: 0x00009538
		[DefaultSettingValue("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" />")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public StringCollection SavedAccounts
		{
			get
			{
				return (StringCollection)this["SavedAccounts"];
			}
			set
			{
				this["SavedAccounts"] = value;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600007F RID: 127 RVA: 0x0000B354 File Offset: 0x00009554
		// (set) Token: 0x06000080 RID: 128 RVA: 0x0000B374 File Offset: 0x00009574
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool EnableAutoNexus
		{
			get
			{
				return (bool)this["EnableAutoNexus"];
			}
			set
			{
				this["EnableAutoNexus"] = value;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000081 RID: 129 RVA: 0x0000B394 File Offset: 0x00009594
		// (set) Token: 0x06000082 RID: 130 RVA: 0x0000B3B4 File Offset: 0x000095B4
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("25")]
		public int AutoNexusPercentageThreshold
		{
			get
			{
				return (int)this["AutoNexusPercentageThreshold"];
			}
			set
			{
				this["AutoNexusPercentageThreshold"] = value;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000083 RID: 131 RVA: 0x0000B3D4 File Offset: 0x000095D4
		// (set) Token: 0x06000084 RID: 132 RVA: 0x0000B3F4 File Offset: 0x000095F4
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("USWest")]
		public string CurrentServer
		{
			get
			{
				return (string)this["CurrentServer"];
			}
			set
			{
				this["CurrentServer"] = value;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000085 RID: 133 RVA: 0x0000B410 File Offset: 0x00009610
		// (set) Token: 0x06000086 RID: 134 RVA: 0x0000B430 File Offset: 0x00009630
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("8")]
		public float AimRangeTilesThreshold
		{
			get
			{
				return (float)this["AimRangeTilesThreshold"];
			}
			set
			{
				this["AimRangeTilesThreshold"] = value;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000087 RID: 135 RVA: 0x0000B450 File Offset: 0x00009650
		// (set) Token: 0x06000088 RID: 136 RVA: 0x0000B470 File Offset: 0x00009670
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool AutoAimAlwaysFire
		{
			get
			{
				return (bool)this["AutoAimAlwaysFire"];
			}
			set
			{
				this["AutoAimAlwaysFire"] = value;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000089 RID: 137 RVA: 0x0000B490 File Offset: 0x00009690
		// (set) Token: 0x0600008A RID: 138 RVA: 0x0000B4B0 File Offset: 0x000096B0
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool EnableAutoAbility
		{
			get
			{
				return (bool)this["EnableAutoAbility"];
			}
			set
			{
				this["EnableAutoAbility"] = value;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600008B RID: 139 RVA: 0x0000B4D0 File Offset: 0x000096D0
		// (set) Token: 0x0600008C RID: 140 RVA: 0x0000B4F0 File Offset: 0x000096F0
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool EnableAutoAim
		{
			get
			{
				return (bool)this["EnableAutoAim"];
			}
			set
			{
				this["EnableAutoAim"] = value;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600008D RID: 141 RVA: 0x0000B510 File Offset: 0x00009710
		// (set) Token: 0x0600008E RID: 142 RVA: 0x0000B530 File Offset: 0x00009730
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool EnableAutoLoot
		{
			get
			{
				return (bool)this["EnableAutoLoot"];
			}
			set
			{
				this["EnableAutoLoot"] = value;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600008F RID: 143 RVA: 0x0000B550 File Offset: 0x00009750
		// (set) Token: 0x06000090 RID: 144 RVA: 0x0000B570 File Offset: 0x00009770
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		public bool AutoAimAtClosestEnemy
		{
			get
			{
				return (bool)this["AutoAimAtClosestEnemy"];
			}
			set
			{
				this["AutoAimAtClosestEnemy"] = value;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000091 RID: 145 RVA: 0x0000B590 File Offset: 0x00009790
		// (set) Token: 0x06000092 RID: 146 RVA: 0x0000B5B0 File Offset: 0x000097B0
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool AutoAimAtStrongestEnemy
		{
			get
			{
				return (bool)this["AutoAimAtStrongestEnemy"];
			}
			set
			{
				this["AutoAimAtStrongestEnemy"] = value;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000093 RID: 147 RVA: 0x0000B5D0 File Offset: 0x000097D0
		// (set) Token: 0x06000094 RID: 148 RVA: 0x0000B5F0 File Offset: 0x000097F0
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("11")]
		public int AutoLootWeaponTierThreshold
		{
			get
			{
				return (int)this["AutoLootWeaponTierThreshold"];
			}
			set
			{
				this["AutoLootWeaponTierThreshold"] = value;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000095 RID: 149 RVA: 0x0000B610 File Offset: 0x00009810
		// (set) Token: 0x06000096 RID: 150 RVA: 0x0000B630 File Offset: 0x00009830
		[DefaultSettingValue("11")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public int AutoLootArmorTierThreshold
		{
			get
			{
				return (int)this["AutoLootArmorTierThreshold"];
			}
			set
			{
				this["AutoLootArmorTierThreshold"] = value;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000097 RID: 151 RVA: 0x0000B650 File Offset: 0x00009850
		// (set) Token: 0x06000098 RID: 152 RVA: 0x0000B670 File Offset: 0x00009870
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("5")]
		public int AutoLootRingTierThreshold
		{
			get
			{
				return (int)this["AutoLootRingTierThreshold"];
			}
			set
			{
				this["AutoLootRingTierThreshold"] = value;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000099 RID: 153 RVA: 0x0000B690 File Offset: 0x00009890
		// (set) Token: 0x0600009A RID: 154 RVA: 0x0000B6B0 File Offset: 0x000098B0
		[DefaultSettingValue("6")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public int AutoLootAbilityTierThreshold
		{
			get
			{
				return (int)this["AutoLootAbilityTierThreshold"];
			}
			set
			{
				this["AutoLootAbilityTierThreshold"] = value;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600009B RID: 155 RVA: 0x0000B6D0 File Offset: 0x000098D0
		// (set) Token: 0x0600009C RID: 156 RVA: 0x0000B6F0 File Offset: 0x000098F0
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool AutoLootStatPotions
		{
			get
			{
				return (bool)this["AutoLootStatPotions"];
			}
			set
			{
				this["AutoLootStatPotions"] = value;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600009D RID: 157 RVA: 0x0000B710 File Offset: 0x00009910
		// (set) Token: 0x0600009E RID: 158 RVA: 0x0000B730 File Offset: 0x00009930
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool AutoLootUTs
		{
			get
			{
				return (bool)this["AutoLootUTs"];
			}
			set
			{
				this["AutoLootUTs"] = value;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600009F RID: 159 RVA: 0x0000B750 File Offset: 0x00009950
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x0000B770 File Offset: 0x00009970
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool AutoLootHealingPotions
		{
			get
			{
				return (bool)this["AutoLootHealingPotions"];
			}
			set
			{
				this["AutoLootHealingPotions"] = value;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x0000B790 File Offset: 0x00009990
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x0000B7B0 File Offset: 0x000099B0
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool IgnoreBlind
		{
			get
			{
				return (bool)this["IgnoreBlind"];
			}
			set
			{
				this["IgnoreBlind"] = value;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x0000B7D0 File Offset: 0x000099D0
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x0000B7F0 File Offset: 0x000099F0
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		public bool IgnoreHallucinating
		{
			get
			{
				return (bool)this["IgnoreHallucinating"];
			}
			set
			{
				this["IgnoreHallucinating"] = value;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x0000B810 File Offset: 0x00009A10
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x0000B830 File Offset: 0x00009A30
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool IgnoreDrunk
		{
			get
			{
				return (bool)this["IgnoreDrunk"];
			}
			set
			{
				this["IgnoreDrunk"] = value;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x0000B850 File Offset: 0x00009A50
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x0000B870 File Offset: 0x00009A70
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		public bool IgnoreConfused
		{
			get
			{
				return (bool)this["IgnoreConfused"];
			}
			set
			{
				this["IgnoreConfused"] = value;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x0000B890 File Offset: 0x00009A90
		// (set) Token: 0x060000AA RID: 170 RVA: 0x0000B8B0 File Offset: 0x00009AB0
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool IgnoreUnstable
		{
			get
			{
				return (bool)this["IgnoreUnstable"];
			}
			set
			{
				this["IgnoreUnstable"] = value;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000AB RID: 171 RVA: 0x0000B8D0 File Offset: 0x00009AD0
		// (set) Token: 0x060000AC RID: 172 RVA: 0x0000B8F0 File Offset: 0x00009AF0
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool IgnoreDarkness
		{
			get
			{
				return (bool)this["IgnoreDarkness"];
			}
			set
			{
				this["IgnoreDarkness"] = value;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000AD RID: 173 RVA: 0x0000B910 File Offset: 0x00009B10
		// (set) Token: 0x060000AE RID: 174 RVA: 0x0000B930 File Offset: 0x00009B30
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool IgnoreQuiet
		{
			get
			{
				return (bool)this["IgnoreQuiet"];
			}
			set
			{
				this["IgnoreQuiet"] = value;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000AF RID: 175 RVA: 0x0000B950 File Offset: 0x00009B50
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x0000B970 File Offset: 0x00009B70
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool IgnoreWeak
		{
			get
			{
				return (bool)this["IgnoreWeak"];
			}
			set
			{
				this["IgnoreWeak"] = value;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x0000B990 File Offset: 0x00009B90
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x0000B9B0 File Offset: 0x00009BB0
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool IgnoreSlowed
		{
			get
			{
				return (bool)this["IgnoreSlowed"];
			}
			set
			{
				this["IgnoreSlowed"] = value;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x0000B9D0 File Offset: 0x00009BD0
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x0000B9F0 File Offset: 0x00009BF0
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool IgnoreSick
		{
			get
			{
				return (bool)this["IgnoreSick"];
			}
			set
			{
				this["IgnoreSick"] = value;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x0000BA10 File Offset: 0x00009C10
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x0000BA30 File Offset: 0x00009C30
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool IgnoreDazed
		{
			get
			{
				return (bool)this["IgnoreDazed"];
			}
			set
			{
				this["IgnoreDazed"] = value;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x0000BA50 File Offset: 0x00009C50
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x0000BA70 File Offset: 0x00009C70
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool IgnoreStunned
		{
			get
			{
				return (bool)this["IgnoreStunned"];
			}
			set
			{
				this["IgnoreStunned"] = value;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x0000BA90 File Offset: 0x00009C90
		// (set) Token: 0x060000BA RID: 186 RVA: 0x0000BAB0 File Offset: 0x00009CB0
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool IgnoreParalyzed
		{
			get
			{
				return (bool)this["IgnoreParalyzed"];
			}
			set
			{
				this["IgnoreParalyzed"] = value;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000BB RID: 187 RVA: 0x0000BAD0 File Offset: 0x00009CD0
		// (set) Token: 0x060000BC RID: 188 RVA: 0x0000BAF0 File Offset: 0x00009CF0
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		public bool IgnoreBleeding
		{
			get
			{
				return (bool)this["IgnoreBleeding"];
			}
			set
			{
				this["IgnoreBleeding"] = value;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000BD RID: 189 RVA: 0x0000BB10 File Offset: 0x00009D10
		// (set) Token: 0x060000BE RID: 190 RVA: 0x0000BB30 File Offset: 0x00009D30
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool IgnoreArmorBreak
		{
			get
			{
				return (bool)this["IgnoreArmorBreak"];
			}
			set
			{
				this["IgnoreArmorBreak"] = value;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000BF RID: 191 RVA: 0x0000BB50 File Offset: 0x00009D50
		// (set) Token: 0x060000C0 RID: 192 RVA: 0x0000BB70 File Offset: 0x00009D70
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool IgnorePetStasis
		{
			get
			{
				return (bool)this["IgnorePetStasis"];
			}
			set
			{
				this["IgnorePetStasis"] = value;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x0000BB90 File Offset: 0x00009D90
		// (set) Token: 0x060000C2 RID: 194 RVA: 0x0000BBB0 File Offset: 0x00009DB0
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool IgnorePetrified
		{
			get
			{
				return (bool)this["IgnorePetrified"];
			}
			set
			{
				this["IgnorePetrified"] = value;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x0000BBD0 File Offset: 0x00009DD0
		// (set) Token: 0x060000C4 RID: 196 RVA: 0x0000BBF0 File Offset: 0x00009DF0
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool IgnoreSilence
		{
			get
			{
				return (bool)this["IgnoreSilence"];
			}
			set
			{
				this["IgnoreSilence"] = value;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x0000BC10 File Offset: 0x00009E10
		// (set) Token: 0x060000C6 RID: 198 RVA: 0x0000BC30 File Offset: 0x00009E30
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool EnableSafeWalk
		{
			get
			{
				return (bool)this["EnableSafeWalk"];
			}
			set
			{
				this["EnableSafeWalk"] = value;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x0000BC50 File Offset: 0x00009E50
		// (set) Token: 0x060000C8 RID: 200 RVA: 0x0000BC70 File Offset: 0x00009E70
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool SafeWalkInShatters
		{
			get
			{
				return (bool)this["SafeWalkInShatters"];
			}
			set
			{
				this["SafeWalkInShatters"] = value;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x0000BC90 File Offset: 0x00009E90
		// (set) Token: 0x060000CA RID: 202 RVA: 0x0000BCB0 File Offset: 0x00009EB0
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool AntiLagIgnoreEffects
		{
			get
			{
				return (bool)this["AntiLagIgnoreEffects"];
			}
			set
			{
				this["AntiLagIgnoreEffects"] = value;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000CB RID: 203 RVA: 0x0000BCD0 File Offset: 0x00009ED0
		// (set) Token: 0x060000CC RID: 204 RVA: 0x0000BCF0 File Offset: 0x00009EF0
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool AutoAbilityClosestEnemy
		{
			get
			{
				return (bool)this["AutoAbilityClosestEnemy"];
			}
			set
			{
				this["AutoAbilityClosestEnemy"] = value;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000CD RID: 205 RVA: 0x0000BD10 File Offset: 0x00009F10
		// (set) Token: 0x060000CE RID: 206 RVA: 0x0000BD30 File Offset: 0x00009F30
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool AutoAbilityWeakestEnemy
		{
			get
			{
				return (bool)this["AutoAbilityWeakestEnemy"];
			}
			set
			{
				this["AutoAbilityWeakestEnemy"] = value;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000CF RID: 207 RVA: 0x0000BD50 File Offset: 0x00009F50
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x0000BD70 File Offset: 0x00009F70
		[DebuggerNonUserCode]
		[DefaultSettingValue("100")]
		[UserScopedSetting]
		public int AutoAbilityMinimumEnemyHealthThreshold
		{
			get
			{
				return (int)this["AutoAbilityMinimumEnemyHealthThreshold"];
			}
			set
			{
				this["AutoAbilityMinimumEnemyHealthThreshold"] = value;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x0000BD90 File Offset: 0x00009F90
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x0000BDB0 File Offset: 0x00009FB0
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("100")]
		public int AutoAbilityMinimumManaLeftThreshold
		{
			get
			{
				return (int)this["AutoAbilityMinimumManaLeftThreshold"];
			}
			set
			{
				this["AutoAbilityMinimumManaLeftThreshold"] = value;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x0000BDD0 File Offset: 0x00009FD0
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x0000BDF0 File Offset: 0x00009FF0
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("3")]
		public int AbilityMinimumEnemyGroupSize
		{
			get
			{
				return (int)this["AbilityMinimumEnemyGroupSize"];
			}
			set
			{
				this["AbilityMinimumEnemyGroupSize"] = value;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x0000BE10 File Offset: 0x0000A010
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x0000BE30 File Offset: 0x0000A030
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		public bool AutoAbilityStrongestEnemy
		{
			get
			{
				return (bool)this["AutoAbilityStrongestEnemy"];
			}
			set
			{
				this["AutoAbilityStrongestEnemy"] = value;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x0000BE50 File Offset: 0x0000A050
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x0000BE70 File Offset: 0x0000A070
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		public bool EnableOther
		{
			get
			{
				return (bool)this["EnableOther"];
			}
			set
			{
				this["EnableOther"] = value;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x0000BE90 File Offset: 0x0000A090
		// (set) Token: 0x060000DA RID: 218 RVA: 0x0000BEB0 File Offset: 0x0000A0B0
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool EnableTeleportToPlayerCommand
		{
			get
			{
				return (bool)this["EnableTeleportToPlayerCommand"];
			}
			set
			{
				this["EnableTeleportToPlayerCommand"] = value;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060000DB RID: 219 RVA: 0x0000BED0 File Offset: 0x0000A0D0
		// (set) Token: 0x060000DC RID: 220 RVA: 0x0000BEF0 File Offset: 0x0000A0F0
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool EnableTeleportToPlayerClosestToQuestCommand
		{
			get
			{
				return (bool)this["EnableTeleportToPlayerClosestToQuestCommand"];
			}
			set
			{
				this["EnableTeleportToPlayerClosestToQuestCommand"] = value;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060000DD RID: 221 RVA: 0x0000BF10 File Offset: 0x0000A110
		// (set) Token: 0x060000DE RID: 222 RVA: 0x0000BF30 File Offset: 0x0000A130
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool EnableAntiDebuffs
		{
			get
			{
				return (bool)this["EnableAntiDebuffs"];
			}
			set
			{
				this["EnableAntiDebuffs"] = value;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060000DF RID: 223 RVA: 0x0000BF50 File Offset: 0x0000A150
		// (set) Token: 0x060000E0 RID: 224 RVA: 0x0000BF70 File Offset: 0x0000A170
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool IgnoreShowEffects
		{
			get
			{
				return (bool)this["IgnoreShowEffects"];
			}
			set
			{
				this["IgnoreShowEffects"] = value;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x0000BF90 File Offset: 0x0000A190
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x0000BFB0 File Offset: 0x0000A1B0
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool BlockDamageNumbers
		{
			get
			{
				return (bool)this["BlockDamageNumbers"];
			}
			set
			{
				this["BlockDamageNumbers"] = value;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x0000BFD0 File Offset: 0x0000A1D0
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x0000BFF0 File Offset: 0x0000A1F0
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("45")]
		public int AutoAbilityHealHpPercent
		{
			get
			{
				return (int)this["AutoAbilityHealHpPercent"];
			}
			set
			{
				this["AutoAbilityHealHpPercent"] = value;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x0000C010 File Offset: 0x0000A210
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x0000C030 File Offset: 0x0000A230
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool EnemyIgnore
		{
			get
			{
				return (bool)this["EnemyIgnore"];
			}
			set
			{
				this["EnemyIgnore"] = value;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x0000C050 File Offset: 0x0000A250
		// (set) Token: 0x060000E8 RID: 232 RVA: 0x0000C070 File Offset: 0x0000A270
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool EnableGlow
		{
			get
			{
				return (bool)this["EnableGlow"];
			}
			set
			{
				this["EnableGlow"] = value;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x0000C090 File Offset: 0x0000A290
		// (set) Token: 0x060000EA RID: 234 RVA: 0x0000C0B0 File Offset: 0x0000A2B0
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool AutoNexusShowInformation
		{
			get
			{
				return (bool)this["AutoNexusShowInformation"];
			}
			set
			{
				this["AutoNexusShowInformation"] = value;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060000EB RID: 235 RVA: 0x0000C0D0 File Offset: 0x0000A2D0
		// (set) Token: 0x060000EC RID: 236 RVA: 0x0000C0F0 File Offset: 0x0000A2F0
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool EnableCustomNexus
		{
			get
			{
				return (bool)this["EnableCustomNexus"];
			}
			set
			{
				this["EnableCustomNexus"] = value;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060000ED RID: 237 RVA: 0x0000C110 File Offset: 0x0000A310
		// (set) Token: 0x060000EE RID: 238 RVA: 0x0000C130 File Offset: 0x0000A330
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		public bool EnableConnectCommand
		{
			get
			{
				return (bool)this["EnableConnectCommand"];
			}
			set
			{
				this["EnableConnectCommand"] = value;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060000EF RID: 239 RVA: 0x0000C150 File Offset: 0x0000A350
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x0000C170 File Offset: 0x0000A370
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool EnableGotoCommand
		{
			get
			{
				return (bool)this["EnableGotoCommand"];
			}
			set
			{
				this["EnableGotoCommand"] = value;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x0000C190 File Offset: 0x0000A390
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x0000C1B0 File Offset: 0x0000A3B0
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool DisableSystemMessages
		{
			get
			{
				return (bool)this["DisableSystemMessages"];
			}
			set
			{
				this["DisableSystemMessages"] = value;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x0000C1D0 File Offset: 0x0000A3D0
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x0000C1F0 File Offset: 0x0000A3F0
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool EnableFameTools
		{
			get
			{
				return (bool)this["EnableFameTools"];
			}
			set
			{
				this["EnableFameTools"] = value;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x0000C210 File Offset: 0x0000A410
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x0000C230 File Offset: 0x0000A430
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool FameDontHitCubes
		{
			get
			{
				return (bool)this["FameDontHitCubes"];
			}
			set
			{
				this["FameDontHitCubes"] = value;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x0000C250 File Offset: 0x0000A450
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x0000C270 File Offset: 0x0000A470
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool FameOnlyHitGods
		{
			get
			{
				return (bool)this["FameOnlyHitGods"];
			}
			set
			{
				this["FameOnlyHitGods"] = value;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x0000C290 File Offset: 0x0000A490
		// (set) Token: 0x060000FA RID: 250 RVA: 0x0000C2B0 File Offset: 0x0000A4B0
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool FameBlockTeleports
		{
			get
			{
				return (bool)this["FameBlockTeleports"];
			}
			set
			{
				this["FameBlockTeleports"] = value;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060000FB RID: 251 RVA: 0x0000C2D0 File Offset: 0x0000A4D0
		// (set) Token: 0x060000FC RID: 252 RVA: 0x0000C2F0 File Offset: 0x0000A4F0
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool FameBlockAbilities
		{
			get
			{
				return (bool)this["FameBlockAbilities"];
			}
			set
			{
				this["FameBlockAbilities"] = value;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060000FD RID: 253 RVA: 0x0000C310 File Offset: 0x0000A510
		// (set) Token: 0x060000FE RID: 254 RVA: 0x0000C330 File Offset: 0x0000A530
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool FameBlockDrinking
		{
			get
			{
				return (bool)this["FameBlockDrinking"];
			}
			set
			{
				this["FameBlockDrinking"] = value;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060000FF RID: 255 RVA: 0x0000C350 File Offset: 0x0000A550
		// (set) Token: 0x06000100 RID: 256 RVA: 0x0000C370 File Offset: 0x0000A570
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool EnableGotoCommandWarningAcknowledged
		{
			get
			{
				return (bool)this["EnableGotoCommandWarningAcknowledged"];
			}
			set
			{
				this["EnableGotoCommandWarningAcknowledged"] = value;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000101 RID: 257 RVA: 0x0000C390 File Offset: 0x0000A590
		// (set) Token: 0x06000102 RID: 258 RVA: 0x0000C3B0 File Offset: 0x0000A5B0
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool FameDontHitIgnores
		{
			get
			{
				return (bool)this["FameDontHitIgnores"];
			}
			set
			{
				this["FameDontHitIgnores"] = value;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000103 RID: 259 RVA: 0x0000C3D0 File Offset: 0x0000A5D0
		// (set) Token: 0x06000104 RID: 260 RVA: 0x0000C3F0 File Offset: 0x0000A5F0
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		public bool EnableBazaarTimer
		{
			get
			{
				return (bool)this["EnableBazaarTimer"];
			}
			set
			{
				this["EnableBazaarTimer"] = value;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000105 RID: 261 RVA: 0x0000C410 File Offset: 0x0000A610
		// (set) Token: 0x06000106 RID: 262 RVA: 0x0000C430 File Offset: 0x0000A630
		[DebuggerNonUserCode]
		[DefaultSettingValue("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfInt xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" />")]
		[UserScopedSetting]
		public int[] FameIngoredEnemies
		{
			get
			{
				return (int[])this["FameIngoredEnemies"];
			}
			set
			{
				this["FameIngoredEnemies"] = value;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000107 RID: 263 RVA: 0x0000C44C File Offset: 0x0000A64C
		// (set) Token: 0x06000108 RID: 264 RVA: 0x0000C46C File Offset: 0x0000A66C
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool AutoAbilityNotifications
		{
			get
			{
				return (bool)this["AutoAbilityNotifications"];
			}
			set
			{
				this["AutoAbilityNotifications"] = value;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000109 RID: 265 RVA: 0x0000C48C File Offset: 0x0000A68C
		// (set) Token: 0x0600010A RID: 266 RVA: 0x0000C4AC File Offset: 0x0000A6AC
		[DebuggerNonUserCode]
		[DefaultSettingValue("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <string>Stream</string>\r\n  <string>Line</string>\r\n  <string>Burst</string>\r\n  <string>Flow</string>\r\n  <string>Ring</string>\r\n  <string>Coneblast</string>\r\n</ArrayOfString>")]
		[UserScopedSetting]
		public string[] AntiLagIgnoredEffects
		{
			get
			{
				return (string[])this["AntiLagIgnoredEffects"];
			}
			set
			{
				this["AntiLagIgnoredEffects"] = value;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600010B RID: 267 RVA: 0x0000C4C8 File Offset: 0x0000A6C8
		// (set) Token: 0x0600010C RID: 268 RVA: 0x0000C4E8 File Offset: 0x0000A6E8
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool EnableAntiAFK
		{
			get
			{
				return (bool)this["EnableAntiAFK"];
			}
			set
			{
				this["EnableAntiAFK"] = value;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600010D RID: 269 RVA: 0x0000C508 File Offset: 0x0000A708
		// (set) Token: 0x0600010E RID: 270 RVA: 0x0000C528 File Offset: 0x0000A728
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool FameAccuracyFarm
		{
			get
			{
				return (bool)this["FameAccuracyFarm"];
			}
			set
			{
				this["FameAccuracyFarm"] = value;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600010F RID: 271 RVA: 0x0000C548 File Offset: 0x0000A748
		// (set) Token: 0x06000110 RID: 272 RVA: 0x0000C568 File Offset: 0x0000A768
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("100")]
		public int AntiLagAllyPlayerSize
		{
			get
			{
				return (int)this["AntiLagAllyPlayerSize"];
			}
			set
			{
				this["AntiLagAllyPlayerSize"] = value;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000111 RID: 273 RVA: 0x0000C588 File Offset: 0x0000A788
		// (set) Token: 0x06000112 RID: 274 RVA: 0x0000C5A8 File Offset: 0x0000A7A8
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool AntiLagHideAllyPets
		{
			get
			{
				return (bool)this["AntiLagHideAllyPets"];
			}
			set
			{
				this["AntiLagHideAllyPets"] = value;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000113 RID: 275 RVA: 0x0000C5C8 File Offset: 0x0000A7C8
		// (set) Token: 0x06000114 RID: 276 RVA: 0x0000C5E8 File Offset: 0x0000A7E8
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool AntiLagApplyToGuildMates
		{
			get
			{
				return (bool)this["AntiLagApplyToGuildMates"];
			}
			set
			{
				this["AntiLagApplyToGuildMates"] = value;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000115 RID: 277 RVA: 0x0000C608 File Offset: 0x0000A808
		// (set) Token: 0x06000116 RID: 278 RVA: 0x0000C628 File Offset: 0x0000A828
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool AntiLagApplyToLockList
		{
			get
			{
				return (bool)this["AntiLagApplyToLockList"];
			}
			set
			{
				this["AntiLagApplyToLockList"] = value;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000117 RID: 279 RVA: 0x0000C648 File Offset: 0x0000A848
		// (set) Token: 0x06000118 RID: 280 RVA: 0x0000C668 File Offset: 0x0000A868
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool EnableErrorReporting
		{
			get
			{
				return (bool)this["EnableErrorReporting"];
			}
			set
			{
				this["EnableErrorReporting"] = value;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000119 RID: 281 RVA: 0x0000C688 File Offset: 0x0000A888
		// (set) Token: 0x0600011A RID: 282 RVA: 0x0000C6A8 File Offset: 0x0000A8A8
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool AutoLootQuests
		{
			get
			{
				return (bool)this["AutoLootQuests"];
			}
			set
			{
				this["AutoLootQuests"] = value;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600011B RID: 283 RVA: 0x0000C6C8 File Offset: 0x0000A8C8
		// (set) Token: 0x0600011C RID: 284 RVA: 0x0000C6E8 File Offset: 0x0000A8E8
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool EnableMapHack
		{
			get
			{
				return (bool)this["EnableMapHack"];
			}
			set
			{
				this["EnableMapHack"] = value;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600011D RID: 285 RVA: 0x0000C708 File Offset: 0x0000A908
		// (set) Token: 0x0600011E RID: 286 RVA: 0x0000C728 File Offset: 0x0000A928
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		public bool AutoLootMarks
		{
			get
			{
				return (bool)this["AutoLootMarks"];
			}
			set
			{
				this["AutoLootMarks"] = value;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600011F RID: 287 RVA: 0x0000C748 File Offset: 0x0000A948
		// (set) Token: 0x06000120 RID: 288 RVA: 0x0000C768 File Offset: 0x0000A968
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("40")]
		public int AutoNexusDrinkThreshold
		{
			get
			{
				return (int)this["AutoNexusDrinkThreshold"];
			}
			set
			{
				this["AutoNexusDrinkThreshold"] = value;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000121 RID: 289 RVA: 0x0000C788 File Offset: 0x0000A988
		// (set) Token: 0x06000122 RID: 290 RVA: 0x0000C7A8 File Offset: 0x0000A9A8
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string ExaltSteamPath
		{
			get
			{
				return (string)this["ExaltSteamPath"];
			}
			set
			{
				this["ExaltSteamPath"] = value;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000123 RID: 291 RVA: 0x0000C7C4 File Offset: 0x0000A9C4
		// (set) Token: 0x06000124 RID: 292 RVA: 0x0000C7E4 File Offset: 0x0000A9E4
		[DefaultSettingValue("00000000-0000-0000-0000-000000000000")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public Guid ID
		{
			get
			{
				return (Guid)this["ID"];
			}
			set
			{
				this["ID"] = value;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000125 RID: 293 RVA: 0x0000C804 File Offset: 0x0000AA04
		// (set) Token: 0x06000126 RID: 294 RVA: 0x0000C824 File Offset: 0x0000AA24
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool AutoLootOverfillMP
		{
			get
			{
				return (bool)this["AutoLootOverfillMP"];
			}
			set
			{
				this["AutoLootOverfillMP"] = value;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000127 RID: 295 RVA: 0x0000C844 File Offset: 0x0000AA44
		// (set) Token: 0x06000128 RID: 296 RVA: 0x0000C864 File Offset: 0x0000AA64
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool AutoLootOverfillHP
		{
			get
			{
				return (bool)this["AutoLootOverfillHP"];
			}
			set
			{
				this["AutoLootOverfillHP"] = value;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000129 RID: 297 RVA: 0x0000C884 File Offset: 0x0000AA84
		// (set) Token: 0x0600012A RID: 298 RVA: 0x0000C8A4 File Offset: 0x0000AAA4
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool AutoLootBigBags
		{
			get
			{
				return (bool)this["AutoLootBigBags"];
			}
			set
			{
				this["AutoLootBigBags"] = value;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600012B RID: 299 RVA: 0x0000C8C4 File Offset: 0x0000AAC4
		// (set) Token: 0x0600012C RID: 300 RVA: 0x0000C8E4 File Offset: 0x0000AAE4
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool EnableO3Helper
		{
			get
			{
				return (bool)this["EnableO3Helper"];
			}
			set
			{
				this["EnableO3Helper"] = value;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600012D RID: 301 RVA: 0x0000C904 File Offset: 0x0000AB04
		// (set) Token: 0x0600012E RID: 302 RVA: 0x0000C924 File Offset: 0x0000AB24
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool O3IgnoreShield
		{
			get
			{
				return (bool)this["O3IgnoreShield"];
			}
			set
			{
				this["O3IgnoreShield"] = value;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600012F RID: 303 RVA: 0x0000C944 File Offset: 0x0000AB44
		// (set) Token: 0x06000130 RID: 304 RVA: 0x0000C964 File Offset: 0x0000AB64
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool O3IgnoreCoins
		{
			get
			{
				return (bool)this["O3IgnoreCoins"];
			}
			set
			{
				this["O3IgnoreCoins"] = value;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000131 RID: 305 RVA: 0x0000C984 File Offset: 0x0000AB84
		// (set) Token: 0x06000132 RID: 306 RVA: 0x0000C9A4 File Offset: 0x0000ABA4
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool O3IgnoreDammah
		{
			get
			{
				return (bool)this["O3IgnoreDammah"];
			}
			set
			{
				this["O3IgnoreDammah"] = value;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000133 RID: 307 RVA: 0x0000C9C4 File Offset: 0x0000ABC4
		// (set) Token: 0x06000134 RID: 308 RVA: 0x0000C9E4 File Offset: 0x0000ABE4
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool AutoAbilityAutoMP
		{
			get
			{
				return (bool)this["AutoAbilityAutoMP"];
			}
			set
			{
				this["AutoAbilityAutoMP"] = value;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000135 RID: 309 RVA: 0x0000CA04 File Offset: 0x0000AC04
		// (set) Token: 0x06000136 RID: 310 RVA: 0x0000CA24 File Offset: 0x0000AC24
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool AutoNexusDrinkFromInventory
		{
			get
			{
				return (bool)this["AutoNexusDrinkFromInventory"];
			}
			set
			{
				this["AutoNexusDrinkFromInventory"] = value;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000137 RID: 311 RVA: 0x0000CA44 File Offset: 0x0000AC44
		// (set) Token: 0x06000138 RID: 312 RVA: 0x0000CA64 File Offset: 0x0000AC64
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool ShowRealLHPot
		{
			get
			{
				return (bool)this["ShowRealLHPot"];
			}
			set
			{
				this["ShowRealLHPot"] = value;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000139 RID: 313 RVA: 0x0000CA84 File Offset: 0x0000AC84
		// (set) Token: 0x0600013A RID: 314 RVA: 0x0000CAA4 File Offset: 0x0000ACA4
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		public bool SafeWalkToggle
		{
			get
			{
				return (bool)this["SafeWalkToggle"];
			}
			set
			{
				this["SafeWalkToggle"] = value;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600013B RID: 315 RVA: 0x0000CAC4 File Offset: 0x0000ACC4
		// (set) Token: 0x0600013C RID: 316 RVA: 0x0000CAE4 File Offset: 0x0000ACE4
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool EnableTeleportToSelf
		{
			get
			{
				return (bool)this["EnableTeleportToSelf"];
			}
			set
			{
				this["EnableTeleportToSelf"] = value;
			}
		}

		// Token: 0x040000EC RID: 236
		private static Settings _9gQQs5d1bS4tMxTYaUvZ3j6UZwe = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
