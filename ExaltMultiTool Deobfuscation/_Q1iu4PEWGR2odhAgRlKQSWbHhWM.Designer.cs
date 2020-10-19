using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ExaltMultiTool.Properties;

// Token: 0x02000002 RID: 2
internal class _Q1iu4PEWGR2odhAgRlKQSWbHhWM : UserControl
{
	// Token: 0x06000002 RID: 2 RVA: 0x00002060 File Offset: 0x00000260
	public _Q1iu4PEWGR2odhAgRlKQSWbHhWM()
	{
		this._FIaDtqWJBkvPLGAHiTMH85gkm0f();
		this._lWjWhmJoXyiE8WhbXSrYAge1vjC.Checked = Settings.Default.EnableAutoNexus;
		this._62VSbpDeRcayFyvfIb9IE4vREup.Value = Settings.Default.AutoNexusPercentageThreshold;
		this._892HB1ye673FqC2JE66HvKLszQz.Checked = Settings.Default.AutoNexusShowInformation;
		this._qjPTNygvB4B3vDNLDEu8h56XDJh.Value = Settings.Default.AutoNexusDrinkThreshold;
		this._GrG3a2HOSzWBO9DtGXrGPYzuprB.Checked = Settings.Default.AutoNexusDrinkFromInventory;
		this._PurNnAIDE44j6AvnAPVuLPTqjSk.Checked = Settings.Default.EnableAutoAbility;
		this._9QHYF9EAZe2ak9U6KEkgpsJl1u6.Value = Settings.Default.AutoAbilityMinimumManaLeftThreshold;
		this._c5laqQAVlFJapJyeOL4JaLeJfbf.Value = Settings.Default.AutoAbilityMinimumEnemyHealthThreshold;
		this._6k83485jw6zIY1JyvUVJehSZU1e.Value = Settings.Default.AutoAbilityHealHpPercent;
		this._eK6G41SpwvAkaNcHSQtBN8YOH3g.Checked = Settings.Default.AutoAbilityWeakestEnemy;
		this._GvDTOnQNOsGJ89PGbQmKVm4TY4f.Checked = Settings.Default.AutoAbilityStrongestEnemy;
		this._sN2qtf5IZN2fEvMaqDslGiFFgAV.Checked = Settings.Default.AutoAbilityClosestEnemy;
		this._CNPY7lJQfipiMP54YgOStijjuD.Checked = Settings.Default.AutoAbilityNotifications;
		this._Hjc8Zs1G4lABixPBnJgdEybxLNL.Checked = Settings.Default.AutoAbilityAutoMP;
		this._OuRzT08buKm1QrtE8IGaLOiW9qM.Checked = Settings.Default.EnableAutoAim;
		this._dmOAJYyrtKFKK3xUW1NDcvh5QVv.Checked = Settings.Default.AutoAimAtStrongestEnemy;
		this._UNMKg8qPomqO5a5Jew7ukXPzENf.Checked = Settings.Default.AutoAimAtClosestEnemy;
		this._l6raCVgixQmMN8kPAfYkFYnrqky.Checked = Settings.Default.AutoAimAlwaysFire;
		this._YjbICycDEC61T7pIUVy0eaY9v1m.Checked = Settings.Default.EnableAutoLoot;
		this._nOqnw75a3yyZAudzbKHSIUYMy4n.Value = Settings.Default.AutoLootWeaponTierThreshold;
		this._D7P47Rl73LeCnoWEZ4ymh4fBqgy.Value = Settings.Default.AutoLootAbilityTierThreshold;
		this._Bqrrvj9sLTV9fVEWILcdRkkmjKo.Value = Settings.Default.AutoLootArmorTierThreshold;
		this._ZmvCnBYucGfhRyLkfY8Vn57QKl.Value = Settings.Default.AutoLootRingTierThreshold;
		this._5IRdHPBh5V6bUQuEKkyGn9RUi1T.Checked = Settings.Default.AutoLootStatPotions;
		this._GrjrySFEic6T6Z7wWeAIYZ0GJrA.Checked = Settings.Default.AutoLootHealingPotions;
		this._Dl9iE93suz1bDyhKZboK2jTfawDA.Checked = Settings.Default.AutoLootUTs;
		this._69arQcmFpxyq8YsKbiEEVFHjqKn.Checked = Settings.Default.AutoLootMarks;
		this._x1fiq46peAdaxB8CJb2R1gvC3Ze.Checked = Settings.Default.AutoLootQuests;
		this._fy5pJKD6hrd5Rd3BYJDMYnkrYMG.Checked = Settings.Default.AutoLootOverfillHP;
		this._0doBNQg7RJwqoJMchbOLNlaqlvYA.Checked = Settings.Default.AutoLootOverfillMP;
		this._kWKdv7Ej4YZpJmrueD5AxpqBF7bA.Checked = Settings.Default.AutoLootBigBags;
		this._ZCZoTOBxN9mFZI5rBXrOOKt2TKH.Checked = Settings.Default.EnableAntiDebuffs;
		this._MVC6SsDfZUqbssBBmfaPMbSmFhe.Checked = Settings.Default.IgnoreBlind;
		this._u2jEC6VyecGYGD5C3qrbPjbfjr4.Checked = Settings.Default.IgnoreHallucinating;
		this._sTTKlNSF2pywEUoDNyMYazoDwXg.Checked = Settings.Default.IgnoreDrunk;
		this._1m7JRxDQQGenByZhp4lj51ra1uo.Checked = Settings.Default.IgnoreConfused;
		this._7ibUrZ0FPa1apl1pB7R5GgqooLG.Checked = Settings.Default.IgnoreUnstable;
		this._NKlRvThUQVierr8jt1xNV3Myl9H.Checked = Settings.Default.IgnoreDarkness;
		this._Ua0d9OnwHQ5BI5RoQEANYQVT8sU.Checked = Settings.Default.IgnoreQuiet;
		this._wVihnzsx3LI5e7WBoMmPqHjQP6d.Checked = Settings.Default.IgnoreWeak;
		this._aDFRoRC7aHH4bfveH505QN32GIF.Checked = Settings.Default.IgnoreSlowed;
		this._63BFRX3Ta4mS00FBS7S5oA6RIei.Checked = Settings.Default.IgnoreSick;
		this._Bbkzoe8PdmMImob9HioxthuG6fd.Checked = Settings.Default.IgnoreDazed;
		this._Qa5criCk6Y0AEV8dPqDlCkHFhZxA.Checked = Settings.Default.IgnoreStunned;
		this._HZRDDd8clmod73yUocCQzV7CR5qA.Checked = Settings.Default.IgnoreParalyzed;
		this._Cph2vLfFeaFKEcHaPocxtLNCvNT.Checked = Settings.Default.IgnoreBleeding;
		this._wOm0pYjtWIbGhTbcbCuMM85vzSR.Checked = Settings.Default.IgnoreArmorBreak;
		this._s4L4ts7GhmGGiDPTViFKcS0GkMO.Checked = Settings.Default.IgnorePetStasis;
		this._8E4AkIWycDhHLRPt1JlObxknaaeA.Checked = Settings.Default.IgnorePetrified;
		this._V34eau5Dg1cv3Zd7vEZY0mTColq.Checked = Settings.Default.IgnoreSilence;
		this._qWCfatZcN3T4yKLil0EWhMMwfUH.Checked = Settings.Default.EnableSafeWalk;
		this._16kZtHLtwDycSkuE6DfiCtUWvJO.Checked = Settings.Default.SafeWalkInShatters;
		this._eTdfMqaoeCvX9U8m9jfRYiV8pKE.Checked = Settings.Default.EnableConnectCommand;
		this._6hGbopNqB96fOCghBWmy3wUmFAZ.Checked = Settings.Default.EnableGotoCommand;
		this._PPWcPcwCxmYtcKjpD0iNDmzeRte.Checked = Settings.Default.AntiLagIgnoreEffects;
		this._x4uzXXueruGEcFglXIrb5e0FwrV.Checked = Settings.Default.AntiLagHideAllyPets;
		this._Pg63SBxDORY9ETmq3s7wajvik8k.Value = Settings.Default.AntiLagAllyPlayerSize;
		this._oxisaD5nAqwjrlXSR18geRg80LE.Checked = Settings.Default.AntiLagApplyToGuildMates;
		this._GtX43dQHZjQu2bV6Eare3Kpzdlc.Checked = Settings.Default.AntiLagApplyToLockList;
		this._n70yPk1wetBL7AbT2mFaJ6qaljq.Checked = Settings.Default.EnableCustomNexus;
		this._TqfCzyDDmzNUzXRCgRJHukfSl3V.Checked = Settings.Default.EnableGlow;
		this._t2acvbrlRCoBW0SQLsLf1bW6ViBA.Checked = Settings.Default.EnableTeleportToPlayerCommand;
		this._4PoQKDUdcjCbhRHv9jUBuFRjGCf.Checked = Settings.Default.EnableTeleportToPlayerClosestToQuestCommand;
		this._LSwBbAV9udSnDiLV8q5BGJbAlScA.Checked = Settings.Default.EnableTeleportToSelf;
		this._6hGbopNqB96fOCghBWmy3wUmFAZ.Checked = Settings.Default.EnableGotoCommand;
		this._RpgFCNKcg7DHEuUuRqmklU498z3.Checked = Settings.Default.DisableSystemMessages;
		this._MWkLE2pOYN6KLMnyPX43PNMmv2d.Checked = Settings.Default.EnableBazaarTimer;
		this._MHsbaQngmyctML526ywXin8JPuAA.Checked = Settings.Default.EnableAntiAFK;
		this._2G6OUmnDQnKZwcr35APccCOreeK.Checked = Settings.Default.ShowRealLHPot;
		this._9tsk3hiE5XmV8RZQ9f4Nf6XO8gd.Checked = Settings.Default.EnableFameTools;
		this._ZkdDuSvdPQwDoDAG5n9bgFAVmvpb.Checked = Settings.Default.FameDontHitCubes;
		this._VnTsmnYXLRGDwkJ8FC3nU4bIP9B.Checked = Settings.Default.FameOnlyHitGods;
		this._WhJddPSH9Ds2gCiSO7YBHdUQ8r5.Checked = Settings.Default.FameBlockTeleports;
		this._Wm4Y3d9Dbxyb3dFlDZ67hnzKobdA.Checked = Settings.Default.FameBlockAbilities;
		this._IaPeVUijdNZdd89OGoTZBAC54mX.Checked = Settings.Default.FameBlockDrinking;
		this._ArSzgygWkzBHHPBRzNRWIRx7ieg.Checked = Settings.Default.FameDontHitIgnores;
		this._Peynkzk3GJMrKqqla5AmSBsGPNd.Checked = Settings.Default.FameAccuracyFarm;
		this._VsAdTcay5ThIW4bJ6BrnGbDl1JM.Checked = Settings.Default.EnableMapHack;
		this._jWNiGS8yodvyuY2B9kSuTIvR3IG.Checked = Settings.Default.EnableO3Helper;
		this._Uh9LpC6i6KDUh3BvNPUBraYgQeY.Checked = Settings.Default.O3IgnoreShield;
		this._VbEAAQfG52Y5rE7mSLefOWnb0sIA.Checked = Settings.Default.O3IgnoreCoins;
		this._TsdwF2AqCEqU4ZIAGSvBxKuzOQD.Checked = Settings.Default.O3IgnoreDammah;
		this._t948p4wyqUtSuMCP4Wf6JExXA3b(this);
	}

	// Token: 0x06000003 RID: 3 RVA: 0x0000276C File Offset: 0x0000096C
	private void _t948p4wyqUtSuMCP4Wf6JExXA3b(Control control)
	{
		NumericUpDown numericUpDown = control as NumericUpDown;
		if (numericUpDown == null)
		{
			TextBox textBox = control as TextBox;
			if (textBox == null)
			{
				CheckBox checkBox = control as CheckBox;
				if (checkBox == null)
				{
					RadioButton radioButton = control as RadioButton;
					if (radioButton != null)
					{
						radioButton.CheckedChanged += this._sXqy5UcO0uEBOHi36B6rhGRRxmn;
					}
				}
				else
				{
					checkBox.CheckedChanged += this._sXqy5UcO0uEBOHi36B6rhGRRxmn;
				}
			}
			else
			{
				textBox.TextChanged += this._sXqy5UcO0uEBOHi36B6rhGRRxmn;
			}
		}
		else
		{
			numericUpDown.ValueChanged += this._sXqy5UcO0uEBOHi36B6rhGRRxmn;
			numericUpDown.MouseWheel += _Q1iu4PEWGR2odhAgRlKQSWbHhWM._5RA1o36SSB1Cj4MaXzNHqI21TTR.<>9._nVNds7wLpVta7Yq9XQAg1FOBaTU;
		}
		foreach (object obj in control.Controls)
		{
			Control control2 = (Control)obj;
			this._t948p4wyqUtSuMCP4Wf6JExXA3b(control2);
		}
	}

	// Token: 0x06000004 RID: 4 RVA: 0x0000286C File Offset: 0x00000A6C
	private void _sXqy5UcO0uEBOHi36B6rhGRRxmn(object sender, EventArgs e)
	{
		Settings.Default.EnableAutoNexus = this._lWjWhmJoXyiE8WhbXSrYAge1vjC.Checked;
		Settings.Default.AutoNexusPercentageThreshold = (int)this._62VSbpDeRcayFyvfIb9IE4vREup.Value;
		Settings.Default.AutoNexusShowInformation = this._892HB1ye673FqC2JE66HvKLszQz.Checked;
		Settings.Default.AutoNexusDrinkThreshold = (int)this._qjPTNygvB4B3vDNLDEu8h56XDJh.Value;
		Settings.Default.AutoNexusDrinkFromInventory = this._GrG3a2HOSzWBO9DtGXrGPYzuprB.Checked;
		Settings.Default.EnableAutoAbility = this._PurNnAIDE44j6AvnAPVuLPTqjSk.Checked;
		Settings.Default.AutoAbilityMinimumManaLeftThreshold = (int)this._9QHYF9EAZe2ak9U6KEkgpsJl1u6.Value;
		Settings.Default.AutoAbilityMinimumEnemyHealthThreshold = (int)this._c5laqQAVlFJapJyeOL4JaLeJfbf.Value;
		Settings.Default.AutoAbilityHealHpPercent = (int)this._6k83485jw6zIY1JyvUVJehSZU1e.Value;
		Settings.Default.AutoAbilityWeakestEnemy = this._eK6G41SpwvAkaNcHSQtBN8YOH3g.Checked;
		Settings.Default.AutoAbilityStrongestEnemy = this._GvDTOnQNOsGJ89PGbQmKVm4TY4f.Checked;
		Settings.Default.AutoAbilityClosestEnemy = this._sN2qtf5IZN2fEvMaqDslGiFFgAV.Checked;
		Settings.Default.AutoAbilityNotifications = this._CNPY7lJQfipiMP54YgOStijjuD.Checked;
		Settings.Default.AutoAbilityAutoMP = this._Hjc8Zs1G4lABixPBnJgdEybxLNL.Checked;
		Settings.Default.EnableAutoAim = this._OuRzT08buKm1QrtE8IGaLOiW9qM.Checked;
		Settings.Default.AutoAimAtStrongestEnemy = this._dmOAJYyrtKFKK3xUW1NDcvh5QVv.Checked;
		Settings.Default.AutoAimAtClosestEnemy = this._UNMKg8qPomqO5a5Jew7ukXPzENf.Checked;
		Settings.Default.AutoAimAlwaysFire = this._l6raCVgixQmMN8kPAfYkFYnrqky.Checked;
		Settings.Default.EnableAutoLoot = this._YjbICycDEC61T7pIUVy0eaY9v1m.Checked;
		Settings.Default.AutoLootWeaponTierThreshold = (int)this._nOqnw75a3yyZAudzbKHSIUYMy4n.Value;
		Settings.Default.AutoLootAbilityTierThreshold = (int)this._D7P47Rl73LeCnoWEZ4ymh4fBqgy.Value;
		Settings.Default.AutoLootArmorTierThreshold = (int)this._Bqrrvj9sLTV9fVEWILcdRkkmjKo.Value;
		Settings.Default.AutoLootRingTierThreshold = (int)this._ZmvCnBYucGfhRyLkfY8Vn57QKl.Value;
		Settings.Default.AutoLootStatPotions = this._5IRdHPBh5V6bUQuEKkyGn9RUi1T.Checked;
		Settings.Default.AutoLootHealingPotions = this._GrjrySFEic6T6Z7wWeAIYZ0GJrA.Checked;
		Settings.Default.AutoLootUTs = this._Dl9iE93suz1bDyhKZboK2jTfawDA.Checked;
		Settings.Default.AutoLootMarks = this._69arQcmFpxyq8YsKbiEEVFHjqKn.Checked;
		Settings.Default.AutoLootQuests = this._x1fiq46peAdaxB8CJb2R1gvC3Ze.Checked;
		Settings.Default.AutoLootOverfillHP = this._fy5pJKD6hrd5Rd3BYJDMYnkrYMG.Checked;
		Settings.Default.AutoLootOverfillMP = this._0doBNQg7RJwqoJMchbOLNlaqlvYA.Checked;
		Settings.Default.AutoLootBigBags = this._kWKdv7Ej4YZpJmrueD5AxpqBF7bA.Checked;
		Settings.Default.EnableAntiDebuffs = this._ZCZoTOBxN9mFZI5rBXrOOKt2TKH.Checked;
		Settings.Default.IgnoreBlind = this._MVC6SsDfZUqbssBBmfaPMbSmFhe.Checked;
		Settings.Default.IgnoreHallucinating = this._u2jEC6VyecGYGD5C3qrbPjbfjr4.Checked;
		Settings.Default.IgnoreDrunk = this._sTTKlNSF2pywEUoDNyMYazoDwXg.Checked;
		Settings.Default.IgnoreConfused = this._1m7JRxDQQGenByZhp4lj51ra1uo.Checked;
		Settings.Default.IgnoreUnstable = this._7ibUrZ0FPa1apl1pB7R5GgqooLG.Checked;
		Settings.Default.IgnoreDarkness = this._NKlRvThUQVierr8jt1xNV3Myl9H.Checked;
		Settings.Default.IgnoreQuiet = this._Ua0d9OnwHQ5BI5RoQEANYQVT8sU.Checked;
		Settings.Default.IgnoreWeak = this._wVihnzsx3LI5e7WBoMmPqHjQP6d.Checked;
		Settings.Default.IgnoreSlowed = this._aDFRoRC7aHH4bfveH505QN32GIF.Checked;
		Settings.Default.IgnoreSick = this._63BFRX3Ta4mS00FBS7S5oA6RIei.Checked;
		Settings.Default.IgnoreDazed = this._Bbkzoe8PdmMImob9HioxthuG6fd.Checked;
		Settings.Default.IgnoreStunned = this._Qa5criCk6Y0AEV8dPqDlCkHFhZxA.Checked;
		Settings.Default.IgnoreParalyzed = this._HZRDDd8clmod73yUocCQzV7CR5qA.Checked;
		Settings.Default.IgnoreBleeding = this._Cph2vLfFeaFKEcHaPocxtLNCvNT.Checked;
		Settings.Default.IgnoreArmorBreak = this._wOm0pYjtWIbGhTbcbCuMM85vzSR.Checked;
		Settings.Default.IgnorePetStasis = this._s4L4ts7GhmGGiDPTViFKcS0GkMO.Checked;
		Settings.Default.IgnorePetrified = this._8E4AkIWycDhHLRPt1JlObxknaaeA.Checked;
		Settings.Default.IgnoreSilence = this._V34eau5Dg1cv3Zd7vEZY0mTColq.Checked;
		Settings.Default.EnableSafeWalk = this._qWCfatZcN3T4yKLil0EWhMMwfUH.Checked;
		Settings.Default.SafeWalkInShatters = this._16kZtHLtwDycSkuE6DfiCtUWvJO.Checked;
		Settings.Default.EnableConnectCommand = this._eTdfMqaoeCvX9U8m9jfRYiV8pKE.Checked;
		Settings.Default.EnableGotoCommand = this._6hGbopNqB96fOCghBWmy3wUmFAZ.Checked;
		Settings.Default.AntiLagAllyPlayerSize = (int)this._Pg63SBxDORY9ETmq3s7wajvik8k.Value;
		Settings.Default.AntiLagIgnoreEffects = this._PPWcPcwCxmYtcKjpD0iNDmzeRte.Checked;
		Settings.Default.AntiLagHideAllyPets = this._x4uzXXueruGEcFglXIrb5e0FwrV.Checked;
		Settings.Default.AntiLagApplyToGuildMates = this._oxisaD5nAqwjrlXSR18geRg80LE.Checked;
		Settings.Default.AntiLagApplyToLockList = this._GtX43dQHZjQu2bV6Eare3Kpzdlc.Checked;
		Settings.Default.EnableCustomNexus = this._n70yPk1wetBL7AbT2mFaJ6qaljq.Checked;
		Settings.Default.EnableGlow = this._TqfCzyDDmzNUzXRCgRJHukfSl3V.Checked;
		Settings.Default.EnableTeleportToPlayerCommand = this._t2acvbrlRCoBW0SQLsLf1bW6ViBA.Checked;
		Settings.Default.EnableTeleportToPlayerClosestToQuestCommand = this._4PoQKDUdcjCbhRHv9jUBuFRjGCf.Checked;
		Settings.Default.EnableTeleportToSelf = this._LSwBbAV9udSnDiLV8q5BGJbAlScA.Checked;
		Settings.Default.DisableSystemMessages = this._RpgFCNKcg7DHEuUuRqmklU498z3.Checked;
		Settings.Default.EnableBazaarTimer = this._MWkLE2pOYN6KLMnyPX43PNMmv2d.Checked;
		Settings.Default.EnableAntiAFK = this._MHsbaQngmyctML526ywXin8JPuAA.Checked;
		Settings.Default.ShowRealLHPot = this._2G6OUmnDQnKZwcr35APccCOreeK.Checked;
		Settings.Default.EnableFameTools = this._9tsk3hiE5XmV8RZQ9f4Nf6XO8gd.Checked;
		Settings.Default.FameDontHitCubes = this._ZkdDuSvdPQwDoDAG5n9bgFAVmvpb.Checked;
		Settings.Default.FameOnlyHitGods = this._VnTsmnYXLRGDwkJ8FC3nU4bIP9B.Checked;
		Settings.Default.FameBlockTeleports = this._WhJddPSH9Ds2gCiSO7YBHdUQ8r5.Checked;
		Settings.Default.FameBlockAbilities = this._Wm4Y3d9Dbxyb3dFlDZ67hnzKobdA.Checked;
		Settings.Default.FameBlockDrinking = this._IaPeVUijdNZdd89OGoTZBAC54mX.Checked;
		Settings.Default.FameDontHitIgnores = this._ArSzgygWkzBHHPBRzNRWIRx7ieg.Checked;
		Settings.Default.FameAccuracyFarm = this._Peynkzk3GJMrKqqla5AmSBsGPNd.Checked;
		Settings.Default.EnableMapHack = this._VsAdTcay5ThIW4bJ6BrnGbDl1JM.Checked;
		Settings.Default.EnableO3Helper = this._jWNiGS8yodvyuY2B9kSuTIvR3IG.Checked;
		Settings.Default.O3IgnoreShield = this._Uh9LpC6i6KDUh3BvNPUBraYgQeY.Checked;
		Settings.Default.O3IgnoreCoins = this._VbEAAQfG52Y5rE7mSLefOWnb0sIA.Checked;
		Settings.Default.O3IgnoreDammah = this._TsdwF2AqCEqU4ZIAGSvBxKuzOQD.Checked;
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00002F50 File Offset: 0x00001150
	private void _jZxPoYDfcs8ZdPNQyM3MgL8VNkh(object sender, EventArgs e)
	{
		MessageBox.Show("Auto Nexus will return your character safely to the nexus when your HP is reduced below the percentage of health that you selected.\n\nAuto Nexus is predictive and will factor incoming damage before it hits you.\n\nDue to server lag, you can still die in rare situations.\n\nYou can choose when AutoNexus will attempt to drink HP potions to save your life, and if it can drink from the inventory to do so.", "RealmStock Multi-Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
	}

	// Token: 0x06000006 RID: 6 RVA: 0x00002F70 File Offset: 0x00001170
	private void _3eFrIdlRtQNYPnnLHtJlTKFNlTE(object sender, EventArgs e)
	{
		MessageBox.Show("Auto Ability will automatically use your abilities to Heal, Buff, and DPS.\n\nAuto Ability only activates based on the conditions you set.\n\nEnable MP potion drinking to automatically restore MP if possible after Quiet.", "RealmStock Multi-Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
	}

	// Token: 0x06000007 RID: 7 RVA: 0x00002F90 File Offset: 0x00001190
	private void _5GHoc2YDqDj3YNQJeQtH9mjoEng(object sender, EventArgs e)
	{
		MessageBox.Show("Not implemented yet. Coming soon!", "RealmStock Multi-Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00002FB0 File Offset: 0x000011B0
	private void _UnSIOV3laMPRj2Lqs3IAJvQdtvi(object sender, EventArgs e)
	{
		MessageBox.Show("Auto Loot will instantly pick up any items on the ground near your character that you allow.\n\nAuto Loot is faster than any manual looting, but due to server lag, results may vary.\n\nBig Loot Bags will make your loot easier to see. It's purely cosmetic.\n\nLoot Bag Quests will show quests to your loot so you can find it easer.\n\nOverfill HP/MP Potions will loot potions to your inventory if your potion slots are full.", "RealmStock Multi-Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00002FD0 File Offset: 0x000011D0
	private void _bzIa0kYLr6689kU85IYJCBEDtdp(object sender, EventArgs e)
	{
		MessageBox.Show("Anti Debuffs will block any incoming debuffs that you choose.\n\nClient Side Debuffs: Can be disabled without worry of disconnect.\n\nServer Side Debuffs: Can cause disconnects over time when blocked.", "RealmStock Multi-Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00002FF0 File Offset: 0x000011F0
	private void _CXFTlPL1Qxhf9YZ4A336gY7rDb(object sender, EventArgs e)
	{
		MessageBox.Show("Safe walk replaces any tile that may deal damage to your character so your character will not come in contact with it.\n\nDisable this feature in Shatters to avoid rare situations where lava can be entrely blocking your path.\n\nYou can have the original tiles be walkable while shooting.", "RealmStock Multi-Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00003010 File Offset: 0x00001210
	private void _CDpAVFnUKjSxUOYPbqyGHT9FzbT(object sender, EventArgs e)
	{
		MessageBox.Show("Any commands you enable can be used at any point from the chat.\n\nCustom Nexus Appearance and Red Glow are only visible to you and are for fun only. Change maps for changes to take effect.\n\nMap Hack will pre-load some map tiles for convenience on maps like Nexus, Vault, Realms. This comes at the expense of lag spikes while the tiles are being loaded after you join a map!\n\nMap Hack will only load God Lands in the Realm.\n\nYou can choose to highligh the real Pot if you are rushing Lost Halls.", "RealmStock Multi-Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00003030 File Offset: 0x00001230
	private void _4IYnT6mUBNH2AdemxmfDvOMcU8j(object sender, EventArgs e)
	{
		MessageBox.Show("Any commands you enable can be used at any point from the chat.\n\nUse /con to quickly change servers.\n\nUse /goto to connect to a specific IP. Advanced users only.\n\nStealth Mode removes the help messages produced in-game by the tool in order to look more legit for screenshots.", "RealmStock Multi-Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00003050 File Offset: 0x00001250
	private void _laFdVRsWZTx9itTGUwb74tgE3lq(object sender, EventArgs e)
	{
		MessageBox.Show("Fame Tools will help you get fame bonuses easier.\n\nDon't Hit Cubes: Friend of the Cubes Bonus\n\nBlock Teleports: Boots on the Ground Bonus\n\nBlock Abilities: Mundane Bonus\n\nBlock Drinking: Thirsty Bonus\n\nAccuracy Farm Mode allows you to shoot at enemies but not kill them.", "RealmStock Multi-Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
	}

	// Token: 0x0600000E RID: 14 RVA: 0x00003070 File Offset: 0x00001270
	private void _afN8bOzkbCBgalxThtbh3kWUzlh(object sender, EventArgs e)
	{
		MessageBox.Show("These prevent you from damaging Oryx and others during Oryx 3\n\nwhen he raises his shield (damage during this inflicts a negative\n\ndebuff affecting the entire group), or from hitting the wrong\n\nGemsbok coin, or when hitting Dammah during his monologue.\n\n", "RealmStock Multi-Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
	}

	// Token: 0x0600000F RID: 15 RVA: 0x00003090 File Offset: 0x00001290
	private void _va7kpTLeKCdVnAKkLLUQgWAK1jH(object sender, LinkLabelLinkClickedEventArgs e)
	{
		new _3epUp89nX32qcURFompyGb29FFH().ShowDialog();
	}

	// Token: 0x06000010 RID: 16 RVA: 0x000030A8 File Offset: 0x000012A8
	private void _PDXcGhpMUbphCYaR2fxXoaVYgPqA(object sender, LinkLabelLinkClickedEventArgs e)
	{
		new _MRAqRiBsXVmIrTUhEyVasdjWGfe().ShowDialog();
	}

	// Token: 0x06000011 RID: 17 RVA: 0x000030C0 File Offset: 0x000012C0
	private void _Zr5z6XtKBUdCIiAWoWQEHLiRJBf(object sender, EventArgs e)
	{
		MessageBox.Show("Hide game effects to reduce lag.\n\nSome effects have confusing names or are unknown, we tried to provide helpful descriptions.\n\nChange Ally Size to declutter your screen from Ally players. You can hide ally pets as well.", "RealmStock Multi-Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
	}

	// Token: 0x06000012 RID: 18 RVA: 0x000030E0 File Offset: 0x000012E0
	protected virtual void _iC1WNstKLx2ElubOgleDPXpBVek(bool disposing)
	{
		if (disposing && this._UBpFiXjXmW4HUIyvG86l99grd9E != null)
		{
			this._UBpFiXjXmW4HUIyvG86l99grd9E.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x06000013 RID: 19 RVA: 0x0000310C File Offset: 0x0000130C
	private void _FIaDtqWJBkvPLGAHiTMH85gkm0f()
	{
		this._66R5JOMpaHqfjMaFdYBF8CAzrsP = new Panel();
		this._16kZtHLtwDycSkuE6DfiCtUWvJO = new CheckBox();
		this._jfBHRYSFZdRBdHioXeKUuy5vR5j = new Panel();
		this._o04URIO6P3nv08ZeHJ9CrS77uPC = new Button();
		this._qWCfatZcN3T4yKLil0EWhMMwfUH = new CheckBox();
		this._tTk6bi5hd04ILmOC4QXTGaAhjoXA = new Panel();
		this._2G6OUmnDQnKZwcr35APccCOreeK = new CheckBox();
		this._LSwBbAV9udSnDiLV8q5BGJbAlScA = new CheckBox();
		this._VsAdTcay5ThIW4bJ6BrnGbDl1JM = new CheckBox();
		this._MHsbaQngmyctML526ywXin8JPuAA = new CheckBox();
		this._MWkLE2pOYN6KLMnyPX43PNMmv2d = new CheckBox();
		this._RpgFCNKcg7DHEuUuRqmklU498z3 = new CheckBox();
		this._HKvBIWwhyYKablJJ0IwaHtn9QR8 = new Label();
		this._n70yPk1wetBL7AbT2mFaJ6qaljq = new CheckBox();
		this._TqfCzyDDmzNUzXRCgRJHukfSl3V = new CheckBox();
		this._4PoQKDUdcjCbhRHv9jUBuFRjGCf = new CheckBox();
		this._t2acvbrlRCoBW0SQLsLf1bW6ViBA = new CheckBox();
		this._wFWtZv2drhYBk4jZvD4d01sJNGO = new Panel();
		this._s63jh3TIOah0EzSLqZ9NZb0Mqre = new Button();
		this._cPRPcukexlWRRbt17KCOAXsFL4F = new Panel();
		this._SGElH7giclUeEyBHAOAHXBzc4wM = new Panel();
		this._DRFtjKGGY2VXLBCayHDByNnUzWO = new Panel();
		this._V34eau5Dg1cv3Zd7vEZY0mTColq = new CheckBox();
		this._8E4AkIWycDhHLRPt1JlObxknaaeA = new CheckBox();
		this._s4L4ts7GhmGGiDPTViFKcS0GkMO = new CheckBox();
		this._wOm0pYjtWIbGhTbcbCuMM85vzSR = new CheckBox();
		this._Cph2vLfFeaFKEcHaPocxtLNCvNT = new CheckBox();
		this._HZRDDd8clmod73yUocCQzV7CR5qA = new CheckBox();
		this._Qa5criCk6Y0AEV8dPqDlCkHFhZxA = new CheckBox();
		this._Bbkzoe8PdmMImob9HioxthuG6fd = new CheckBox();
		this._63BFRX3Ta4mS00FBS7S5oA6RIei = new CheckBox();
		this._aDFRoRC7aHH4bfveH505QN32GIF = new CheckBox();
		this._wVihnzsx3LI5e7WBoMmPqHjQP6d = new CheckBox();
		this._Ua0d9OnwHQ5BI5RoQEANYQVT8sU = new CheckBox();
		this._sPASlpgjmceRkJ10l5HMqtXYwCG = new Label();
		this._NKlRvThUQVierr8jt1xNV3Myl9H = new CheckBox();
		this._7ibUrZ0FPa1apl1pB7R5GgqooLG = new CheckBox();
		this._1m7JRxDQQGenByZhp4lj51ra1uo = new CheckBox();
		this._sTTKlNSF2pywEUoDNyMYazoDwXg = new CheckBox();
		this._u2jEC6VyecGYGD5C3qrbPjbfjr4 = new CheckBox();
		this._MVC6SsDfZUqbssBBmfaPMbSmFhe = new CheckBox();
		this._njdDYS23mYGWn2ocLeCmY0a2slbA = new Label();
		this._cRnQHjhccoQdAxvsGCdFVwDfJE1 = new Panel();
		this._9x1otcvb4GZxwhWAzUr4o7Pyt6b = new Button();
		this._ZCZoTOBxN9mFZI5rBXrOOKt2TKH = new CheckBox();
		this._xZBd1IVcAqPTBrdFglWuJbpqhVv = new Panel();
		this._kWKdv7Ej4YZpJmrueD5AxpqBF7bA = new CheckBox();
		this._0doBNQg7RJwqoJMchbOLNlaqlvYA = new CheckBox();
		this._fy5pJKD6hrd5Rd3BYJDMYnkrYMG = new CheckBox();
		this._69arQcmFpxyq8YsKbiEEVFHjqKn = new CheckBox();
		this._x1fiq46peAdaxB8CJb2R1gvC3Ze = new CheckBox();
		this._ZmvCnBYucGfhRyLkfY8Vn57QKl = new NumericUpDown();
		this._wIxsQPJFBeOnkTBETLyot7U7HQd = new Label();
		this._D7P47Rl73LeCnoWEZ4ymh4fBqgy = new NumericUpDown();
		this._jnLDC0xHVtKyjWVKOWAH40DziuUb = new Label();
		this._Dl9iE93suz1bDyhKZboK2jTfawDA = new CheckBox();
		this._GrjrySFEic6T6Z7wWeAIYZ0GJrA = new CheckBox();
		this._5IRdHPBh5V6bUQuEKkyGn9RUi1T = new CheckBox();
		this._Bqrrvj9sLTV9fVEWILcdRkkmjKo = new NumericUpDown();
		this._QizBpycMvTObFLaaBtybGm832AR = new Label();
		this._nOqnw75a3yyZAudzbKHSIUYMy4n = new NumericUpDown();
		this._cDL6L6SyYNLSfiuaaTdcpgF0E5Y = new Label();
		this._Mc1AKCDOLA5IewbvwOjyn2GdPfq = new Panel();
		this._m8Tr8k6wY8UXWx0M0vhk32xVXwb = new Button();
		this._YjbICycDEC61T7pIUVy0eaY9v1m = new CheckBox();
		this._ZE6BWnV3aucOtptJFG0jFQt19wR = new Panel();
		this._l6raCVgixQmMN8kPAfYkFYnrqky = new CheckBox();
		this._UNMKg8qPomqO5a5Jew7ukXPzENf = new RadioButton();
		this._dmOAJYyrtKFKK3xUW1NDcvh5QVv = new RadioButton();
		this._wHaSFzsf19T5k2ZBGvHJu0pcf3i = new Label();
		this._jtPLnv8PlfLBzXu7dbti6f34nDq = new NumericUpDown();
		this._U56cl9eFIl3JKbtQh9k53UWb6SY = new Label();
		this._mf7O8njBr55uJOPndWhOfZhB26k = new Panel();
		this._kevi7G85zI1rlB8dS2oLX5hhF5k = new Button();
		this._OuRzT08buKm1QrtE8IGaLOiW9qM = new CheckBox();
		this._oUyaM8rB6O9TO4tYBzBYZxK4m3w = new Panel();
		this._CNPY7lJQfipiMP54YgOStijjuD = new CheckBox();
		this._JtRnoMorwqCBXJIsNMmgOow41KL = new Label();
		this._6k83485jw6zIY1JyvUVJehSZU1e = new NumericUpDown();
		this._OtdDwtRcwgnd04tA1CeTqnWtGmdA = new Label();
		this._sN2qtf5IZN2fEvMaqDslGiFFgAV = new RadioButton();
		this._agYF6ii02oU5KICbi31ZCzXf25U = new Label();
		this._GvDTOnQNOsGJ89PGbQmKVm4TY4f = new RadioButton();
		this._JrQ0jvSnpu8tCPkHfWRan3nPstO = new NumericUpDown();
		this._eK6G41SpwvAkaNcHSQtBN8YOH3g = new RadioButton();
		this._Pqw9zi4w7GqQwYQK41QnTuuWuPB = new Label();
		this._avTCWVvfyh5Z2ZcOPgrfahJGerT = new Label();
		this._9QHYF9EAZe2ak9U6KEkgpsJl1u6 = new NumericUpDown();
		this._ysfSIj72X08AFWJAyx7j0yhALnK = new Label();
		this._FIIdC84o3TKCFUXg0FpaRpwDHmHA = new Label();
		this._c5laqQAVlFJapJyeOL4JaLeJfbf = new NumericUpDown();
		this._oG0D38K3dGqrjszXNGDhJgLg3YO = new Label();
		this._Mixf8sI0kZDJCwoFg3WpNQN0h1H = new Panel();
		this._ftgy68Qbf8ty1dzazTutC4fGxcX = new Button();
		this._PurNnAIDE44j6AvnAPVuLPTqjSk = new CheckBox();
		this._OFGERDl1EqTyy8cSjx875xroSBC = new Panel();
		this._UQXpP3YbtvnD1q2FOAN2qS2ohxW = new Label();
		this._qjPTNygvB4B3vDNLDEu8h56XDJh = new NumericUpDown();
		this._D56B164kgvuhufuOvewvaVBYdYh = new Label();
		this._892HB1ye673FqC2JE66HvKLszQz = new CheckBox();
		this._Do5CIYGgaFClsbuysngi6YRJSNq = new Label();
		this._yQ1kSD7a2a3aKSDQCfysAKHn0Ue = new Panel();
		this._IiKbopXhVBOSMxagiaQAt5bahuxA = new Button();
		this._62VSbpDeRcayFyvfIb9IE4vREup = new NumericUpDown();
		this._0HGnMal1Vd4x3tahp3yMGdeIssG = new Label();
		this._lWjWhmJoXyiE8WhbXSrYAge1vjC = new CheckBox();
		this._YnUaeaUO3v7j9nMGyrg8xLCRvbaA = new Panel();
		this._rkCOyhCrmFgszG5N6BFXtycsLJC = new Label();
		this._6hGbopNqB96fOCghBWmy3wUmFAZ = new CheckBox();
		this._eTdfMqaoeCvX9U8m9jfRYiV8pKE = new CheckBox();
		this._PNCuD1l2tNobM4F9uXZCce0XGip = new Label();
		this._CFHhsixORk1ubYPKegZSTI4aJ0k = new Panel();
		this._RUh9TbFjqdzx0jETEYjgjtUGoTg = new Button();
		this._eNEP9aTBIxptpE2leJOgLDYn7ds = new Panel();
		this._Peynkzk3GJMrKqqla5AmSBsGPNd = new CheckBox();
		this._LeBw0Xu8GHUkpehWS0c8qyHakdb = new LinkLabel();
		this._IaPeVUijdNZdd89OGoTZBAC54mX = new CheckBox();
		this._Wm4Y3d9Dbxyb3dFlDZ67hnzKobdA = new CheckBox();
		this._WhJddPSH9Ds2gCiSO7YBHdUQ8r5 = new CheckBox();
		this._VnTsmnYXLRGDwkJ8FC3nU4bIP9B = new CheckBox();
		this._ZkdDuSvdPQwDoDAG5n9bgFAVmvpb = new CheckBox();
		this._ArSzgygWkzBHHPBRzNRWIRx7ieg = new CheckBox();
		this._CcJWy1gRUni2ZZkIO4OKPTcaWGH = new Panel();
		this._2adxfsCrw3qjBhHJrJ5dDXAABnX = new Button();
		this._9tsk3hiE5XmV8RZQ9f4Nf6XO8gd = new CheckBox();
		this._6XCiVyAA72dGw5FZ1rL70tvdgKC = new Panel();
		this._GtX43dQHZjQu2bV6Eare3Kpzdlc = new CheckBox();
		this._oxisaD5nAqwjrlXSR18geRg80LE = new CheckBox();
		this._x4uzXXueruGEcFglXIrb5e0FwrV = new CheckBox();
		this._BEFwFnaRw3Ak2YGQpfohIOtEIDf = new Label();
		this._TRtDzNcp0DaJTMueoeHQxP8IcvE = new Label();
		this._Pg63SBxDORY9ETmq3s7wajvik8k = new NumericUpDown();
		this._vc4gWdSsA2eFoiytixLF73YIYLM = new LinkLabel();
		this._tKBTSAORY4UWZkVWDYEkF4vaVRn = new Label();
		this._PPWcPcwCxmYtcKjpD0iNDmzeRte = new CheckBox();
		this._lCRdTL6EkYbJqSpDojm7OcFWfI3b = new Panel();
		this._3bGCaPsCFkbs5nX39EXz6FbIqlP = new Button();
		this._s0nXuBNPmKbDc1iFqeq2pmE5M0y = new Panel();
		this._TsdwF2AqCEqU4ZIAGSvBxKuzOQD = new CheckBox();
		this._VbEAAQfG52Y5rE7mSLefOWnb0sIA = new CheckBox();
		this._Uh9LpC6i6KDUh3BvNPUBraYgQeY = new CheckBox();
		this._5hgAZ08Jk9aXcfouJfbf4Lz0SgN = new Panel();
		this._eesno6VabGLIZTjbrNpe4JCXr1f = new Button();
		this._jWNiGS8yodvyuY2B9kSuTIvR3IG = new CheckBox();
		this._GrG3a2HOSzWBO9DtGXrGPYzuprB = new CheckBox();
		this._Hjc8Zs1G4lABixPBnJgdEybxLNL = new CheckBox();
		this._66R5JOMpaHqfjMaFdYBF8CAzrsP.SuspendLayout();
		this._tTk6bi5hd04ILmOC4QXTGaAhjoXA.SuspendLayout();
		this._cPRPcukexlWRRbt17KCOAXsFL4F.SuspendLayout();
		this._xZBd1IVcAqPTBrdFglWuJbpqhVv.SuspendLayout();
		((ISupportInitialize)this._ZmvCnBYucGfhRyLkfY8Vn57QKl).BeginInit();
		((ISupportInitialize)this._D7P47Rl73LeCnoWEZ4ymh4fBqgy).BeginInit();
		((ISupportInitialize)this._Bqrrvj9sLTV9fVEWILcdRkkmjKo).BeginInit();
		((ISupportInitialize)this._nOqnw75a3yyZAudzbKHSIUYMy4n).BeginInit();
		this._ZE6BWnV3aucOtptJFG0jFQt19wR.SuspendLayout();
		((ISupportInitialize)this._jtPLnv8PlfLBzXu7dbti6f34nDq).BeginInit();
		this._oUyaM8rB6O9TO4tYBzBYZxK4m3w.SuspendLayout();
		((ISupportInitialize)this._6k83485jw6zIY1JyvUVJehSZU1e).BeginInit();
		((ISupportInitialize)this._JrQ0jvSnpu8tCPkHfWRan3nPstO).BeginInit();
		((ISupportInitialize)this._9QHYF9EAZe2ak9U6KEkgpsJl1u6).BeginInit();
		((ISupportInitialize)this._c5laqQAVlFJapJyeOL4JaLeJfbf).BeginInit();
		this._OFGERDl1EqTyy8cSjx875xroSBC.SuspendLayout();
		((ISupportInitialize)this._qjPTNygvB4B3vDNLDEu8h56XDJh).BeginInit();
		((ISupportInitialize)this._62VSbpDeRcayFyvfIb9IE4vREup).BeginInit();
		this._YnUaeaUO3v7j9nMGyrg8xLCRvbaA.SuspendLayout();
		this._eNEP9aTBIxptpE2leJOgLDYn7ds.SuspendLayout();
		this._6XCiVyAA72dGw5FZ1rL70tvdgKC.SuspendLayout();
		((ISupportInitialize)this._Pg63SBxDORY9ETmq3s7wajvik8k).BeginInit();
		this._s0nXuBNPmKbDc1iFqeq2pmE5M0y.SuspendLayout();
		base.SuspendLayout();
		this._66R5JOMpaHqfjMaFdYBF8CAzrsP.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
		this._66R5JOMpaHqfjMaFdYBF8CAzrsP.BackColor = Color.FromArgb(54, 61, 52);
		this._66R5JOMpaHqfjMaFdYBF8CAzrsP.BorderStyle = BorderStyle.FixedSingle;
		this._66R5JOMpaHqfjMaFdYBF8CAzrsP.Controls.Add(this._16kZtHLtwDycSkuE6DfiCtUWvJO);
		this._66R5JOMpaHqfjMaFdYBF8CAzrsP.Controls.Add(this._jfBHRYSFZdRBdHioXeKUuy5vR5j);
		this._66R5JOMpaHqfjMaFdYBF8CAzrsP.Controls.Add(this._o04URIO6P3nv08ZeHJ9CrS77uPC);
		this._66R5JOMpaHqfjMaFdYBF8CAzrsP.Controls.Add(this._qWCfatZcN3T4yKLil0EWhMMwfUH);
		this._66R5JOMpaHqfjMaFdYBF8CAzrsP.Location = new Point(6, 813);
		this._66R5JOMpaHqfjMaFdYBF8CAzrsP.Name = "pnlSafeWalk";
		this._66R5JOMpaHqfjMaFdYBF8CAzrsP.Size = new Size(502, 61);
		this._66R5JOMpaHqfjMaFdYBF8CAzrsP.TabIndex = 26;
		this._16kZtHLtwDycSkuE6DfiCtUWvJO.AutoSize = true;
		this._16kZtHLtwDycSkuE6DfiCtUWvJO.BackColor = Color.FromArgb(54, 61, 52);
		this._16kZtHLtwDycSkuE6DfiCtUWvJO.Location = new Point(30, 33);
		this._16kZtHLtwDycSkuE6DfiCtUWvJO.Name = "chkSafeWalkInShatters";
		this._16kZtHLtwDycSkuE6DfiCtUWvJO.Size = new Size(131, 21);
		this._16kZtHLtwDycSkuE6DfiCtUWvJO.TabIndex = 14;
		this._16kZtHLtwDycSkuE6DfiCtUWvJO.Text = "Enable in Shatters";
		this._16kZtHLtwDycSkuE6DfiCtUWvJO.UseVisualStyleBackColor = false;
		this._jfBHRYSFZdRBdHioXeKUuy5vR5j.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
		this._jfBHRYSFZdRBdHioXeKUuy5vR5j.BackColor = Color.FromArgb(54, 61, 52);
		this._jfBHRYSFZdRBdHioXeKUuy5vR5j.BorderStyle = BorderStyle.FixedSingle;
		this._jfBHRYSFZdRBdHioXeKUuy5vR5j.Location = new Point(8, 28);
		this._jfBHRYSFZdRBdHioXeKUuy5vR5j.Name = "sepSafeWalk";
		this._jfBHRYSFZdRBdHioXeKUuy5vR5j.Size = new Size(485, 1);
		this._jfBHRYSFZdRBdHioXeKUuy5vR5j.TabIndex = 6;
		this._o04URIO6P3nv08ZeHJ9CrS77uPC.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
		this._o04URIO6P3nv08ZeHJ9CrS77uPC.Font = new Font("Segoe UI", 6.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this._o04URIO6P3nv08ZeHJ9CrS77uPC.ForeColor = Color.Black;
		this._o04URIO6P3nv08ZeHJ9CrS77uPC.Location = new Point(471, 5);
		this._o04URIO6P3nv08ZeHJ9CrS77uPC.Name = "btnSafeWalkInfo";
		this._o04URIO6P3nv08ZeHJ9CrS77uPC.Size = new Size(23, 20);
		this._o04URIO6P3nv08ZeHJ9CrS77uPC.TabIndex = 5;
		this._o04URIO6P3nv08ZeHJ9CrS77uPC.Text = "?";
		this._o04URIO6P3nv08ZeHJ9CrS77uPC.UseVisualStyleBackColor = true;
		this._o04URIO6P3nv08ZeHJ9CrS77uPC.Click += this._CXFTlPL1Qxhf9YZ4A336gY7rDb;
		this._qWCfatZcN3T4yKLil0EWhMMwfUH.AutoSize = true;
		this._qWCfatZcN3T4yKLil0EWhMMwfUH.BackColor = Color.FromArgb(54, 61, 52);
		this._qWCfatZcN3T4yKLil0EWhMMwfUH.Font = new Font("Segoe UI", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this._qWCfatZcN3T4yKLil0EWhMMwfUH.ForeColor = SystemColors.ButtonFace;
		this._qWCfatZcN3T4yKLil0EWhMMwfUH.Location = new Point(8, 3);
		this._qWCfatZcN3T4yKLil0EWhMMwfUH.Name = "chkSafeWalk";
		this._qWCfatZcN3T4yKLil0EWhMMwfUH.Size = new Size(104, 25);
		this._qWCfatZcN3T4yKLil0EWhMMwfUH.TabIndex = 1;
		this._qWCfatZcN3T4yKLil0EWhMMwfUH.Text = "Safe Walk";
		this._qWCfatZcN3T4yKLil0EWhMMwfUH.UseVisualStyleBackColor = false;
		this._tTk6bi5hd04ILmOC4QXTGaAhjoXA.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
		this._tTk6bi5hd04ILmOC4QXTGaAhjoXA.BackColor = Color.FromArgb(54, 51, 52);
		this._tTk6bi5hd04ILmOC4QXTGaAhjoXA.BorderStyle = BorderStyle.FixedSingle;
		this._tTk6bi5hd04ILmOC4QXTGaAhjoXA.Controls.Add(this._2G6OUmnDQnKZwcr35APccCOreeK);
		this._tTk6bi5hd04ILmOC4QXTGaAhjoXA.Controls.Add(this._LSwBbAV9udSnDiLV8q5BGJbAlScA);
		this._tTk6bi5hd04ILmOC4QXTGaAhjoXA.Controls.Add(this._VsAdTcay5ThIW4bJ6BrnGbDl1JM);
		this._tTk6bi5hd04ILmOC4QXTGaAhjoXA.Controls.Add(this._MHsbaQngmyctML526ywXin8JPuAA);
		this._tTk6bi5hd04ILmOC4QXTGaAhjoXA.Controls.Add(this._MWkLE2pOYN6KLMnyPX43PNMmv2d);
		this._tTk6bi5hd04ILmOC4QXTGaAhjoXA.Controls.Add(this._RpgFCNKcg7DHEuUuRqmklU498z3);
		this._tTk6bi5hd04ILmOC4QXTGaAhjoXA.Controls.Add(this._HKvBIWwhyYKablJJ0IwaHtn9QR8);
		this._tTk6bi5hd04ILmOC4QXTGaAhjoXA.Controls.Add(this._n70yPk1wetBL7AbT2mFaJ6qaljq);
		this._tTk6bi5hd04ILmOC4QXTGaAhjoXA.Controls.Add(this._TqfCzyDDmzNUzXRCgRJHukfSl3V);
		this._tTk6bi5hd04ILmOC4QXTGaAhjoXA.Controls.Add(this._4PoQKDUdcjCbhRHv9jUBuFRjGCf);
		this._tTk6bi5hd04ILmOC4QXTGaAhjoXA.Controls.Add(this._t2acvbrlRCoBW0SQLsLf1bW6ViBA);
		this._tTk6bi5hd04ILmOC4QXTGaAhjoXA.Controls.Add(this._wFWtZv2drhYBk4jZvD4d01sJNGO);
		this._tTk6bi5hd04ILmOC4QXTGaAhjoXA.Controls.Add(this._s63jh3TIOah0EzSLqZ9NZb0Mqre);
		this._tTk6bi5hd04ILmOC4QXTGaAhjoXA.Location = new Point(6, 1178);
		this._tTk6bi5hd04ILmOC4QXTGaAhjoXA.Name = "pnlOther";
		this._tTk6bi5hd04ILmOC4QXTGaAhjoXA.Size = new Size(502, 306);
		this._tTk6bi5hd04ILmOC4QXTGaAhjoXA.TabIndex = 25;
		this._2G6OUmnDQnKZwcr35APccCOreeK.AutoSize = true;
		this._2G6OUmnDQnKZwcr35APccCOreeK.Location = new Point(30, 276);
		this._2G6OUmnDQnKZwcr35APccCOreeK.Name = "chkShowRealLHPot";
		this._2G6OUmnDQnKZwcr35APccCOreeK.Size = new Size(184, 21);
		this._2G6OUmnDQnKZwcr35APccCOreeK.TabIndex = 40;
		this._2G6OUmnDQnKZwcr35APccCOreeK.Text = "Show Real Pot in Lost Halls";
		this._2G6OUmnDQnKZwcr35APccCOreeK.UseVisualStyleBackColor = true;
		this._LSwBbAV9udSnDiLV8q5BGJbAlScA.AutoSize = true;
		this._LSwBbAV9udSnDiLV8q5BGJbAlScA.BackColor = Color.FromArgb(54, 51, 52);
		this._LSwBbAV9udSnDiLV8q5BGJbAlScA.Location = new Point(30, 87);
		this._LSwBbAV9udSnDiLV8q5BGJbAlScA.Name = "chkTeleportToSelf";
		this._LSwBbAV9udSnDiLV8q5BGJbAlScA.Size = new Size(169, 21);
		this._LSwBbAV9udSnDiLV8q5BGJbAlScA.TabIndex = 39;
		this._LSwBbAV9udSnDiLV8q5BGJbAlScA.Text = "/tp : Teleport to yourself";
		this._LSwBbAV9udSnDiLV8q5BGJbAlScA.UseVisualStyleBackColor = false;
		this._VsAdTcay5ThIW4bJ6BrnGbDl1JM.AutoSize = true;
		this._VsAdTcay5ThIW4bJ6BrnGbDl1JM.Location = new Point(30, 249);
		this._VsAdTcay5ThIW4bJ6BrnGbDl1JM.Name = "chkEnableMapHack";
		this._VsAdTcay5ThIW4bJ6BrnGbDl1JM.Size = new Size(392, 21);
		this._VsAdTcay5ThIW4bJ6BrnGbDl1JM.TabIndex = 38;
		this._VsAdTcay5ThIW4bJ6BrnGbDl1JM.Text = "Enable Map Hack (Pre-Loads some maps, lags while doing so)";
		this._VsAdTcay5ThIW4bJ6BrnGbDl1JM.UseVisualStyleBackColor = true;
		this._MHsbaQngmyctML526ywXin8JPuAA.AutoSize = true;
		this._MHsbaQngmyctML526ywXin8JPuAA.Location = new Point(30, 222);
		this._MHsbaQngmyctML526ywXin8JPuAA.Name = "chkEnableAntiAFK";
		this._MHsbaQngmyctML526ywXin8JPuAA.Size = new Size(126, 21);
		this._MHsbaQngmyctML526ywXin8JPuAA.TabIndex = 37;
		this._MHsbaQngmyctML526ywXin8JPuAA.Text = "Anti AFK Timeout";
		this._MHsbaQngmyctML526ywXin8JPuAA.UseVisualStyleBackColor = true;
		this._MWkLE2pOYN6KLMnyPX43PNMmv2d.AutoSize = true;
		this._MWkLE2pOYN6KLMnyPX43PNMmv2d.Location = new Point(30, 195);
		this._MWkLE2pOYN6KLMnyPX43PNMmv2d.Name = "chkEnableBazaarTimer";
		this._MWkLE2pOYN6KLMnyPX43PNMmv2d.Size = new Size(174, 21);
		this._MWkLE2pOYN6KLMnyPX43PNMmv2d.TabIndex = 27;
		this._MWkLE2pOYN6KLMnyPX43PNMmv2d.Text = "Bazaar Portal Entry Timer";
		this._MWkLE2pOYN6KLMnyPX43PNMmv2d.UseVisualStyleBackColor = true;
		this._RpgFCNKcg7DHEuUuRqmklU498z3.AutoSize = true;
		this._RpgFCNKcg7DHEuUuRqmklU498z3.BackColor = Color.FromArgb(54, 51, 52);
		this._RpgFCNKcg7DHEuUuRqmklU498z3.Location = new Point(30, 168);
		this._RpgFCNKcg7DHEuUuRqmklU498z3.Name = "chkDisableSystemMessages";
		this._RpgFCNKcg7DHEuUuRqmklU498z3.Size = new Size(148, 21);
		this._RpgFCNKcg7DHEuUuRqmklU498z3.TabIndex = 26;
		this._RpgFCNKcg7DHEuUuRqmklU498z3.Text = "Enable Stealth Mode";
		this._RpgFCNKcg7DHEuUuRqmklU498z3.UseVisualStyleBackColor = false;
		this._HKvBIWwhyYKablJJ0IwaHtn9QR8.AutoSize = true;
		this._HKvBIWwhyYKablJJ0IwaHtn9QR8.Font = new Font("Segoe UI", 12f, FontStyle.Bold);
		this._HKvBIWwhyYKablJJ0IwaHtn9QR8.Location = new Point(8, 3);
		this._HKvBIWwhyYKablJJ0IwaHtn9QR8.Name = "lblTools";
		this._HKvBIWwhyYKablJJ0IwaHtn9QR8.Size = new Size(50, 21);
		this._HKvBIWwhyYKablJJ0IwaHtn9QR8.TabIndex = 24;
		this._HKvBIWwhyYKablJJ0IwaHtn9QR8.Text = "Tools";
		this._n70yPk1wetBL7AbT2mFaJ6qaljq.AutoSize = true;
		this._n70yPk1wetBL7AbT2mFaJ6qaljq.BackColor = Color.FromArgb(54, 51, 52);
		this._n70yPk1wetBL7AbT2mFaJ6qaljq.Location = new Point(30, 114);
		this._n70yPk1wetBL7AbT2mFaJ6qaljq.Name = "chkEnableCustomNexus";
		this._n70yPk1wetBL7AbT2mFaJ6qaljq.Size = new Size(185, 21);
		this._n70yPk1wetBL7AbT2mFaJ6qaljq.TabIndex = 23;
		this._n70yPk1wetBL7AbT2mFaJ6qaljq.Text = "Custom Nexus Appearance";
		this._n70yPk1wetBL7AbT2mFaJ6qaljq.UseVisualStyleBackColor = false;
		this._TqfCzyDDmzNUzXRCgRJHukfSl3V.AutoSize = true;
		this._TqfCzyDDmzNUzXRCgRJHukfSl3V.BackColor = Color.FromArgb(54, 51, 52);
		this._TqfCzyDDmzNUzXRCgRJHukfSl3V.Location = new Point(30, 141);
		this._TqfCzyDDmzNUzXRCgRJHukfSl3V.Name = "chkEnableGlow";
		this._TqfCzyDDmzNUzXRCgRJHukfSl3V.Size = new Size(165, 21);
		this._TqfCzyDDmzNUzXRCgRJHukfSl3V.TabIndex = 22;
		this._TqfCzyDDmzNUzXRCgRJHukfSl3V.Text = "Enable Red Player Glow";
		this._TqfCzyDDmzNUzXRCgRJHukfSl3V.UseVisualStyleBackColor = false;
		this._4PoQKDUdcjCbhRHv9jUBuFRjGCf.AutoSize = true;
		this._4PoQKDUdcjCbhRHv9jUBuFRjGCf.BackColor = Color.FromArgb(54, 51, 52);
		this._4PoQKDUdcjCbhRHv9jUBuFRjGCf.Location = new Point(30, 33);
		this._4PoQKDUdcjCbhRHv9jUBuFRjGCf.Name = "chkTeleportToPlayerClosestToQuestCommand";
		this._4PoQKDUdcjCbhRHv9jUBuFRjGCf.Size = new Size(338, 21);
		this._4PoQKDUdcjCbhRHv9jUBuFRjGCf.TabIndex = 18;
		this._4PoQKDUdcjCbhRHv9jUBuFRjGCf.Text = "/tpq : Teleport to player closest to your current quest";
		this._4PoQKDUdcjCbhRHv9jUBuFRjGCf.UseVisualStyleBackColor = false;
		this._t2acvbrlRCoBW0SQLsLf1bW6ViBA.AutoSize = true;
		this._t2acvbrlRCoBW0SQLsLf1bW6ViBA.BackColor = Color.FromArgb(54, 51, 52);
		this._t2acvbrlRCoBW0SQLsLf1bW6ViBA.Location = new Point(30, 60);
		this._t2acvbrlRCoBW0SQLsLf1bW6ViBA.Name = "chkTeleportToPlayerCommand";
		this._t2acvbrlRCoBW0SQLsLf1bW6ViBA.Size = new Size(269, 21);
		this._t2acvbrlRCoBW0SQLsLf1bW6ViBA.TabIndex = 17;
		this._t2acvbrlRCoBW0SQLsLf1bW6ViBA.Text = "/tp <name> : Teleport to specified player";
		this._t2acvbrlRCoBW0SQLsLf1bW6ViBA.UseVisualStyleBackColor = false;
		this._wFWtZv2drhYBk4jZvD4d01sJNGO.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
		this._wFWtZv2drhYBk4jZvD4d01sJNGO.BackColor = Color.FromArgb(54, 51, 52);
		this._wFWtZv2drhYBk4jZvD4d01sJNGO.BorderStyle = BorderStyle.FixedSingle;
		this._wFWtZv2drhYBk4jZvD4d01sJNGO.Location = new Point(8, 28);
		this._wFWtZv2drhYBk4jZvD4d01sJNGO.Name = "sepOther";
		this._wFWtZv2drhYBk4jZvD4d01sJNGO.Size = new Size(485, 1);
		this._wFWtZv2drhYBk4jZvD4d01sJNGO.TabIndex = 6;
		this._s63jh3TIOah0EzSLqZ9NZb0Mqre.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
		this._s63jh3TIOah0EzSLqZ9NZb0Mqre.Font = new Font("Segoe UI", 6.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this._s63jh3TIOah0EzSLqZ9NZb0Mqre.ForeColor = Color.Black;
		this._s63jh3TIOah0EzSLqZ9NZb0Mqre.Location = new Point(471, 5);
		this._s63jh3TIOah0EzSLqZ9NZb0Mqre.Name = "btnOtherInfo";
		this._s63jh3TIOah0EzSLqZ9NZb0Mqre.Size = new Size(23, 20);
		this._s63jh3TIOah0EzSLqZ9NZb0Mqre.TabIndex = 5;
		this._s63jh3TIOah0EzSLqZ9NZb0Mqre.Text = "?";
		this._s63jh3TIOah0EzSLqZ9NZb0Mqre.UseVisualStyleBackColor = true;
		this._s63jh3TIOah0EzSLqZ9NZb0Mqre.Click += this._CDpAVFnUKjSxUOYPbqyGHT9FzbT;
		this._cPRPcukexlWRRbt17KCOAXsFL4F.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
		this._cPRPcukexlWRRbt17KCOAXsFL4F.BackColor = Color.FromArgb(44, 41, 72);
		this._cPRPcukexlWRRbt17KCOAXsFL4F.BorderStyle = BorderStyle.FixedSingle;
		this._cPRPcukexlWRRbt17KCOAXsFL4F.Controls.Add(this._SGElH7giclUeEyBHAOAHXBzc4wM);
		this._cPRPcukexlWRRbt17KCOAXsFL4F.Controls.Add(this._DRFtjKGGY2VXLBCayHDByNnUzWO);
		this._cPRPcukexlWRRbt17KCOAXsFL4F.Controls.Add(this._V34eau5Dg1cv3Zd7vEZY0mTColq);
		this._cPRPcukexlWRRbt17KCOAXsFL4F.Controls.Add(this._8E4AkIWycDhHLRPt1JlObxknaaeA);
		this._cPRPcukexlWRRbt17KCOAXsFL4F.Controls.Add(this._s4L4ts7GhmGGiDPTViFKcS0GkMO);
		this._cPRPcukexlWRRbt17KCOAXsFL4F.Controls.Add(this._wOm0pYjtWIbGhTbcbCuMM85vzSR);
		this._cPRPcukexlWRRbt17KCOAXsFL4F.Controls.Add(this._Cph2vLfFeaFKEcHaPocxtLNCvNT);
		this._cPRPcukexlWRRbt17KCOAXsFL4F.Controls.Add(this._HZRDDd8clmod73yUocCQzV7CR5qA);
		this._cPRPcukexlWRRbt17KCOAXsFL4F.Controls.Add(this._Qa5criCk6Y0AEV8dPqDlCkHFhZxA);
		this._cPRPcukexlWRRbt17KCOAXsFL4F.Controls.Add(this._Bbkzoe8PdmMImob9HioxthuG6fd);
		this._cPRPcukexlWRRbt17KCOAXsFL4F.Controls.Add(this._63BFRX3Ta4mS00FBS7S5oA6RIei);
		this._cPRPcukexlWRRbt17KCOAXsFL4F.Controls.Add(this._aDFRoRC7aHH4bfveH505QN32GIF);
		this._cPRPcukexlWRRbt17KCOAXsFL4F.Controls.Add(this._wVihnzsx3LI5e7WBoMmPqHjQP6d);
		this._cPRPcukexlWRRbt17KCOAXsFL4F.Controls.Add(this._Ua0d9OnwHQ5BI5RoQEANYQVT8sU);
		this._cPRPcukexlWRRbt17KCOAXsFL4F.Controls.Add(this._sPASlpgjmceRkJ10l5HMqtXYwCG);
		this._cPRPcukexlWRRbt17KCOAXsFL4F.Controls.Add(this._NKlRvThUQVierr8jt1xNV3Myl9H);
		this._cPRPcukexlWRRbt17KCOAXsFL4F.Controls.Add(this._7ibUrZ0FPa1apl1pB7R5GgqooLG);
		this._cPRPcukexlWRRbt17KCOAXsFL4F.Controls.Add(this._1m7JRxDQQGenByZhp4lj51ra1uo);
		this._cPRPcukexlWRRbt17KCOAXsFL4F.Controls.Add(this._sTTKlNSF2pywEUoDNyMYazoDwXg);
		this._cPRPcukexlWRRbt17KCOAXsFL4F.Controls.Add(this._u2jEC6VyecGYGD5C3qrbPjbfjr4);
		this._cPRPcukexlWRRbt17KCOAXsFL4F.Controls.Add(this._MVC6SsDfZUqbssBBmfaPMbSmFhe);
		this._cPRPcukexlWRRbt17KCOAXsFL4F.Controls.Add(this._njdDYS23mYGWn2ocLeCmY0a2slbA);
		this._cPRPcukexlWRRbt17KCOAXsFL4F.Controls.Add(this._cRnQHjhccoQdAxvsGCdFVwDfJE1);
		this._cPRPcukexlWRRbt17KCOAXsFL4F.Controls.Add(this._9x1otcvb4GZxwhWAzUr4o7Pyt6b);
		this._cPRPcukexlWRRbt17KCOAXsFL4F.Controls.Add(this._ZCZoTOBxN9mFZI5rBXrOOKt2TKH);
		this._cPRPcukexlWRRbt17KCOAXsFL4F.Location = new Point(6, 586);
		this._cPRPcukexlWRRbt17KCOAXsFL4F.Name = "pnlAntiDebuffs";
		this._cPRPcukexlWRRbt17KCOAXsFL4F.Size = new Size(502, 221);
		this._cPRPcukexlWRRbt17KCOAXsFL4F.TabIndex = 24;
		this._SGElH7giclUeEyBHAOAHXBzc4wM.BackColor = Color.FromArgb(44, 41, 72);
		this._SGElH7giclUeEyBHAOAHXBzc4wM.BorderStyle = BorderStyle.FixedSingle;
		this._SGElH7giclUeEyBHAOAHXBzc4wM.Location = new Point(200, 53);
		this._SGElH7giclUeEyBHAOAHXBzc4wM.Name = "sepServerSide";
		this._SGElH7giclUeEyBHAOAHXBzc4wM.Size = new Size(300, 1);
		this._SGElH7giclUeEyBHAOAHXBzc4wM.TabIndex = 36;
		this._DRFtjKGGY2VXLBCayHDByNnUzWO.BackColor = Color.FromArgb(44, 41, 72);
		this._DRFtjKGGY2VXLBCayHDByNnUzWO.BorderStyle = BorderStyle.FixedSingle;
		this._DRFtjKGGY2VXLBCayHDByNnUzWO.Location = new Point(30, 53);
		this._DRFtjKGGY2VXLBCayHDByNnUzWO.Name = "sepClientSide";
		this._DRFtjKGGY2VXLBCayHDByNnUzWO.Size = new Size(150, 1);
		this._DRFtjKGGY2VXLBCayHDByNnUzWO.TabIndex = 35;
		this._V34eau5Dg1cv3Zd7vEZY0mTColq.AutoSize = true;
		this._V34eau5Dg1cv3Zd7vEZY0mTColq.BackColor = Color.FromArgb(44, 41, 72);
		this._V34eau5Dg1cv3Zd7vEZY0mTColq.Location = new Point(351, 193);
		this._V34eau5Dg1cv3Zd7vEZY0mTColq.Name = "chkIngoreSilence";
		this._V34eau5Dg1cv3Zd7vEZY0mTColq.Size = new Size(109, 21);
		this._V34eau5Dg1cv3Zd7vEZY0mTColq.TabIndex = 34;
		this._V34eau5Dg1cv3Zd7vEZY0mTColq.Text = "Ignore Silence";
		this._V34eau5Dg1cv3Zd7vEZY0mTColq.UseVisualStyleBackColor = false;
		this._8E4AkIWycDhHLRPt1JlObxknaaeA.AutoSize = true;
		this._8E4AkIWycDhHLRPt1JlObxknaaeA.BackColor = Color.FromArgb(44, 41, 72);
		this._8E4AkIWycDhHLRPt1JlObxknaaeA.Location = new Point(351, 166);
		this._8E4AkIWycDhHLRPt1JlObxknaaeA.Name = "chkIngorePetrified";
		this._8E4AkIWycDhHLRPt1JlObxknaaeA.Size = new Size(117, 21);
		this._8E4AkIWycDhHLRPt1JlObxknaaeA.TabIndex = 33;
		this._8E4AkIWycDhHLRPt1JlObxknaaeA.Text = "Ignore Petrified";
		this._8E4AkIWycDhHLRPt1JlObxknaaeA.UseVisualStyleBackColor = false;
		this._s4L4ts7GhmGGiDPTViFKcS0GkMO.AutoSize = true;
		this._s4L4ts7GhmGGiDPTViFKcS0GkMO.BackColor = Color.FromArgb(44, 41, 72);
		this._s4L4ts7GhmGGiDPTViFKcS0GkMO.Location = new Point(351, 139);
		this._s4L4ts7GhmGGiDPTViFKcS0GkMO.Name = "chkIngorePetStasis";
		this._s4L4ts7GhmGGiDPTViFKcS0GkMO.Size = new Size(124, 21);
		this._s4L4ts7GhmGGiDPTViFKcS0GkMO.TabIndex = 32;
		this._s4L4ts7GhmGGiDPTViFKcS0GkMO.Text = "Ignore Pet Stasis";
		this._s4L4ts7GhmGGiDPTViFKcS0GkMO.UseVisualStyleBackColor = false;
		this._wOm0pYjtWIbGhTbcbCuMM85vzSR.AutoSize = true;
		this._wOm0pYjtWIbGhTbcbCuMM85vzSR.BackColor = Color.FromArgb(44, 41, 72);
		this._wOm0pYjtWIbGhTbcbCuMM85vzSR.Location = new Point(351, 112);
		this._wOm0pYjtWIbGhTbcbCuMM85vzSR.Name = "chkIngoreArmorBroken";
		this._wOm0pYjtWIbGhTbcbCuMM85vzSR.Size = new Size(150, 21);
		this._wOm0pYjtWIbGhTbcbCuMM85vzSR.TabIndex = 31;
		this._wOm0pYjtWIbGhTbcbCuMM85vzSR.Text = "Ignore Armor Broken";
		this._wOm0pYjtWIbGhTbcbCuMM85vzSR.UseVisualStyleBackColor = false;
		this._Cph2vLfFeaFKEcHaPocxtLNCvNT.AutoSize = true;
		this._Cph2vLfFeaFKEcHaPocxtLNCvNT.BackColor = Color.FromArgb(44, 41, 72);
		this._Cph2vLfFeaFKEcHaPocxtLNCvNT.Location = new Point(351, 85);
		this._Cph2vLfFeaFKEcHaPocxtLNCvNT.Name = "chkIngoreBleeding";
		this._Cph2vLfFeaFKEcHaPocxtLNCvNT.Size = new Size(119, 21);
		this._Cph2vLfFeaFKEcHaPocxtLNCvNT.TabIndex = 30;
		this._Cph2vLfFeaFKEcHaPocxtLNCvNT.Text = "Ignore Bleeding";
		this._Cph2vLfFeaFKEcHaPocxtLNCvNT.UseVisualStyleBackColor = false;
		this._HZRDDd8clmod73yUocCQzV7CR5qA.AutoSize = true;
		this._HZRDDd8clmod73yUocCQzV7CR5qA.BackColor = Color.FromArgb(44, 41, 72);
		this._HZRDDd8clmod73yUocCQzV7CR5qA.Location = new Point(351, 58);
		this._HZRDDd8clmod73yUocCQzV7CR5qA.Name = "chkIngoreParalyzed";
		this._HZRDDd8clmod73yUocCQzV7CR5qA.Size = new Size(125, 21);
		this._HZRDDd8clmod73yUocCQzV7CR5qA.TabIndex = 29;
		this._HZRDDd8clmod73yUocCQzV7CR5qA.Text = "Ignore Paralyzed";
		this._HZRDDd8clmod73yUocCQzV7CR5qA.UseVisualStyleBackColor = false;
		this._Qa5criCk6Y0AEV8dPqDlCkHFhZxA.AutoSize = true;
		this._Qa5criCk6Y0AEV8dPqDlCkHFhZxA.BackColor = Color.FromArgb(44, 41, 72);
		this._Qa5criCk6Y0AEV8dPqDlCkHFhZxA.Location = new Point(200, 193);
		this._Qa5criCk6Y0AEV8dPqDlCkHFhZxA.Name = "chkIngoreStunned";
		this._Qa5criCk6Y0AEV8dPqDlCkHFhZxA.Size = new Size(116, 21);
		this._Qa5criCk6Y0AEV8dPqDlCkHFhZxA.TabIndex = 28;
		this._Qa5criCk6Y0AEV8dPqDlCkHFhZxA.Text = "Ignore Stunned";
		this._Qa5criCk6Y0AEV8dPqDlCkHFhZxA.UseVisualStyleBackColor = false;
		this._Bbkzoe8PdmMImob9HioxthuG6fd.AutoSize = true;
		this._Bbkzoe8PdmMImob9HioxthuG6fd.BackColor = Color.FromArgb(44, 41, 72);
		this._Bbkzoe8PdmMImob9HioxthuG6fd.Location = new Point(200, 166);
		this._Bbkzoe8PdmMImob9HioxthuG6fd.Name = "chkIngoreDazed";
		this._Bbkzoe8PdmMImob9HioxthuG6fd.Size = new Size(106, 21);
		this._Bbkzoe8PdmMImob9HioxthuG6fd.TabIndex = 27;
		this._Bbkzoe8PdmMImob9HioxthuG6fd.Text = "Ignore Dazed";
		this._Bbkzoe8PdmMImob9HioxthuG6fd.UseVisualStyleBackColor = false;
		this._63BFRX3Ta4mS00FBS7S5oA6RIei.AutoSize = true;
		this._63BFRX3Ta4mS00FBS7S5oA6RIei.BackColor = Color.FromArgb(44, 41, 72);
		this._63BFRX3Ta4mS00FBS7S5oA6RIei.Location = new Point(200, 139);
		this._63BFRX3Ta4mS00FBS7S5oA6RIei.Name = "chkIngoreSick";
		this._63BFRX3Ta4mS00FBS7S5oA6RIei.Size = new Size(91, 21);
		this._63BFRX3Ta4mS00FBS7S5oA6RIei.TabIndex = 26;
		this._63BFRX3Ta4mS00FBS7S5oA6RIei.Text = "Ignore Sick";
		this._63BFRX3Ta4mS00FBS7S5oA6RIei.UseVisualStyleBackColor = false;
		this._aDFRoRC7aHH4bfveH505QN32GIF.AutoSize = true;
		this._aDFRoRC7aHH4bfveH505QN32GIF.BackColor = Color.FromArgb(44, 41, 72);
		this._aDFRoRC7aHH4bfveH505QN32GIF.Location = new Point(200, 112);
		this._aDFRoRC7aHH4bfveH505QN32GIF.Name = "chkIngoreSlowed";
		this._aDFRoRC7aHH4bfveH505QN32GIF.Size = new Size(111, 21);
		this._aDFRoRC7aHH4bfveH505QN32GIF.TabIndex = 25;
		this._aDFRoRC7aHH4bfveH505QN32GIF.Text = "Ignore Slowed";
		this._aDFRoRC7aHH4bfveH505QN32GIF.UseVisualStyleBackColor = false;
		this._wVihnzsx3LI5e7WBoMmPqHjQP6d.AutoSize = true;
		this._wVihnzsx3LI5e7WBoMmPqHjQP6d.BackColor = Color.FromArgb(44, 41, 72);
		this._wVihnzsx3LI5e7WBoMmPqHjQP6d.Location = new Point(200, 85);
		this._wVihnzsx3LI5e7WBoMmPqHjQP6d.Name = "chkIngoreWeak";
		this._wVihnzsx3LI5e7WBoMmPqHjQP6d.Size = new Size(100, 21);
		this._wVihnzsx3LI5e7WBoMmPqHjQP6d.TabIndex = 24;
		this._wVihnzsx3LI5e7WBoMmPqHjQP6d.Text = "Ignore Weak";
		this._wVihnzsx3LI5e7WBoMmPqHjQP6d.UseVisualStyleBackColor = false;
		this._Ua0d9OnwHQ5BI5RoQEANYQVT8sU.AutoSize = true;
		this._Ua0d9OnwHQ5BI5RoQEANYQVT8sU.BackColor = Color.FromArgb(44, 41, 72);
		this._Ua0d9OnwHQ5BI5RoQEANYQVT8sU.Location = new Point(200, 58);
		this._Ua0d9OnwHQ5BI5RoQEANYQVT8sU.Name = "chkIngoreQuiet";
		this._Ua0d9OnwHQ5BI5RoQEANYQVT8sU.Size = new Size(100, 21);
		this._Ua0d9OnwHQ5BI5RoQEANYQVT8sU.TabIndex = 23;
		this._Ua0d9OnwHQ5BI5RoQEANYQVT8sU.Text = "Ignore Quiet";
		this._Ua0d9OnwHQ5BI5RoQEANYQVT8sU.UseVisualStyleBackColor = false;
		this._sPASlpgjmceRkJ10l5HMqtXYwCG.AutoSize = true;
		this._sPASlpgjmceRkJ10l5HMqtXYwCG.BackColor = Color.FromArgb(44, 41, 72);
		this._sPASlpgjmceRkJ10l5HMqtXYwCG.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this._sPASlpgjmceRkJ10l5HMqtXYwCG.ForeColor = SystemColors.ControlLight;
		this._sPASlpgjmceRkJ10l5HMqtXYwCG.Location = new Point(197, 32);
		this._sPASlpgjmceRkJ10l5HMqtXYwCG.Name = "lblServerSideDebuffs";
		this._sPASlpgjmceRkJ10l5HMqtXYwCG.Size = new Size(164, 17);
		this._sPASlpgjmceRkJ10l5HMqtXYwCG.TabIndex = 22;
		this._sPASlpgjmceRkJ10l5HMqtXYwCG.Text = "Server Side (DC possible)";
		this._NKlRvThUQVierr8jt1xNV3Myl9H.AutoSize = true;
		this._NKlRvThUQVierr8jt1xNV3Myl9H.BackColor = Color.FromArgb(44, 41, 72);
		this._NKlRvThUQVierr8jt1xNV3Myl9H.Location = new Point(30, 193);
		this._NKlRvThUQVierr8jt1xNV3Myl9H.Name = "chkIngoreDarkness";
		this._NKlRvThUQVierr8jt1xNV3Myl9H.Size = new Size(122, 21);
		this._NKlRvThUQVierr8jt1xNV3Myl9H.TabIndex = 21;
		this._NKlRvThUQVierr8jt1xNV3Myl9H.Text = "Ignore Darkness";
		this._NKlRvThUQVierr8jt1xNV3Myl9H.UseVisualStyleBackColor = false;
		this._7ibUrZ0FPa1apl1pB7R5GgqooLG.AutoSize = true;
		this._7ibUrZ0FPa1apl1pB7R5GgqooLG.BackColor = Color.FromArgb(44, 41, 72);
		this._7ibUrZ0FPa1apl1pB7R5GgqooLG.Location = new Point(30, 166);
		this._7ibUrZ0FPa1apl1pB7R5GgqooLG.Name = "chkIngoreUnstable";
		this._7ibUrZ0FPa1apl1pB7R5GgqooLG.Size = new Size(120, 21);
		this._7ibUrZ0FPa1apl1pB7R5GgqooLG.TabIndex = 20;
		this._7ibUrZ0FPa1apl1pB7R5GgqooLG.Text = "Ignore Unstable";
		this._7ibUrZ0FPa1apl1pB7R5GgqooLG.UseVisualStyleBackColor = false;
		this._1m7JRxDQQGenByZhp4lj51ra1uo.AutoSize = true;
		this._1m7JRxDQQGenByZhp4lj51ra1uo.BackColor = Color.FromArgb(44, 41, 72);
		this._1m7JRxDQQGenByZhp4lj51ra1uo.Location = new Point(30, 139);
		this._1m7JRxDQQGenByZhp4lj51ra1uo.Name = "chkIngoreConfused";
		this._1m7JRxDQQGenByZhp4lj51ra1uo.Size = new Size(124, 21);
		this._1m7JRxDQQGenByZhp4lj51ra1uo.TabIndex = 19;
		this._1m7JRxDQQGenByZhp4lj51ra1uo.Text = "Ignore Confused";
		this._1m7JRxDQQGenByZhp4lj51ra1uo.UseVisualStyleBackColor = false;
		this._sTTKlNSF2pywEUoDNyMYazoDwXg.AutoSize = true;
		this._sTTKlNSF2pywEUoDNyMYazoDwXg.BackColor = Color.FromArgb(44, 41, 72);
		this._sTTKlNSF2pywEUoDNyMYazoDwXg.Location = new Point(30, 112);
		this._sTTKlNSF2pywEUoDNyMYazoDwXg.Name = "chkIngoreDrunk";
		this._sTTKlNSF2pywEUoDNyMYazoDwXg.Size = new Size(103, 21);
		this._sTTKlNSF2pywEUoDNyMYazoDwXg.TabIndex = 18;
		this._sTTKlNSF2pywEUoDNyMYazoDwXg.Text = "Ignore Drunk";
		this._sTTKlNSF2pywEUoDNyMYazoDwXg.UseVisualStyleBackColor = false;
		this._u2jEC6VyecGYGD5C3qrbPjbfjr4.AutoSize = true;
		this._u2jEC6VyecGYGD5C3qrbPjbfjr4.BackColor = Color.FromArgb(44, 41, 72);
		this._u2jEC6VyecGYGD5C3qrbPjbfjr4.Location = new Point(30, 85);
		this._u2jEC6VyecGYGD5C3qrbPjbfjr4.Name = "chkIngoreHallucination";
		this._u2jEC6VyecGYGD5C3qrbPjbfjr4.Size = new Size(143, 21);
		this._u2jEC6VyecGYGD5C3qrbPjbfjr4.TabIndex = 17;
		this._u2jEC6VyecGYGD5C3qrbPjbfjr4.Text = "Ignore Hallucination";
		this._u2jEC6VyecGYGD5C3qrbPjbfjr4.UseVisualStyleBackColor = false;
		this._MVC6SsDfZUqbssBBmfaPMbSmFhe.AutoSize = true;
		this._MVC6SsDfZUqbssBBmfaPMbSmFhe.BackColor = Color.FromArgb(44, 41, 72);
		this._MVC6SsDfZUqbssBBmfaPMbSmFhe.Location = new Point(30, 58);
		this._MVC6SsDfZUqbssBBmfaPMbSmFhe.Name = "chkIngoreBlindess";
		this._MVC6SsDfZUqbssBBmfaPMbSmFhe.Size = new Size(123, 21);
		this._MVC6SsDfZUqbssBBmfaPMbSmFhe.TabIndex = 16;
		this._MVC6SsDfZUqbssBBmfaPMbSmFhe.Text = "Ignore Blindness";
		this._MVC6SsDfZUqbssBBmfaPMbSmFhe.UseVisualStyleBackColor = false;
		this._njdDYS23mYGWn2ocLeCmY0a2slbA.AutoSize = true;
		this._njdDYS23mYGWn2ocLeCmY0a2slbA.BackColor = Color.FromArgb(44, 41, 72);
		this._njdDYS23mYGWn2ocLeCmY0a2slbA.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this._njdDYS23mYGWn2ocLeCmY0a2slbA.ForeColor = SystemColors.ControlLight;
		this._njdDYS23mYGWn2ocLeCmY0a2slbA.Location = new Point(27, 32);
		this._njdDYS23mYGWn2ocLeCmY0a2slbA.Name = "lblClientSideDebuffs";
		this._njdDYS23mYGWn2ocLeCmY0a2slbA.Size = new Size(128, 17);
		this._njdDYS23mYGWn2ocLeCmY0a2slbA.TabIndex = 15;
		this._njdDYS23mYGWn2ocLeCmY0a2slbA.Text = "Client Side (No DC)";
		this._cRnQHjhccoQdAxvsGCdFVwDfJE1.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
		this._cRnQHjhccoQdAxvsGCdFVwDfJE1.BackColor = Color.FromArgb(44, 41, 72);
		this._cRnQHjhccoQdAxvsGCdFVwDfJE1.BorderStyle = BorderStyle.FixedSingle;
		this._cRnQHjhccoQdAxvsGCdFVwDfJE1.Location = new Point(8, 28);
		this._cRnQHjhccoQdAxvsGCdFVwDfJE1.Name = "sepAntiDebuffs";
		this._cRnQHjhccoQdAxvsGCdFVwDfJE1.Size = new Size(485, 1);
		this._cRnQHjhccoQdAxvsGCdFVwDfJE1.TabIndex = 6;
		this._9x1otcvb4GZxwhWAzUr4o7Pyt6b.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
		this._9x1otcvb4GZxwhWAzUr4o7Pyt6b.Font = new Font("Segoe UI", 6.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this._9x1otcvb4GZxwhWAzUr4o7Pyt6b.ForeColor = Color.Black;
		this._9x1otcvb4GZxwhWAzUr4o7Pyt6b.Location = new Point(471, 5);
		this._9x1otcvb4GZxwhWAzUr4o7Pyt6b.Name = "btnAntiDebuffsInfo";
		this._9x1otcvb4GZxwhWAzUr4o7Pyt6b.Size = new Size(23, 20);
		this._9x1otcvb4GZxwhWAzUr4o7Pyt6b.TabIndex = 5;
		this._9x1otcvb4GZxwhWAzUr4o7Pyt6b.Text = "?";
		this._9x1otcvb4GZxwhWAzUr4o7Pyt6b.UseVisualStyleBackColor = true;
		this._9x1otcvb4GZxwhWAzUr4o7Pyt6b.Click += this._bzIa0kYLr6689kU85IYJCBEDtdp;
		this._ZCZoTOBxN9mFZI5rBXrOOKt2TKH.AutoSize = true;
		this._ZCZoTOBxN9mFZI5rBXrOOKt2TKH.BackColor = Color.FromArgb(44, 41, 72);
		this._ZCZoTOBxN9mFZI5rBXrOOKt2TKH.Font = new Font("Segoe UI", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this._ZCZoTOBxN9mFZI5rBXrOOKt2TKH.ForeColor = SystemColors.ButtonFace;
		this._ZCZoTOBxN9mFZI5rBXrOOKt2TKH.Location = new Point(8, 3);
		this._ZCZoTOBxN9mFZI5rBXrOOKt2TKH.Name = "chkAntiDebuffs";
		this._ZCZoTOBxN9mFZI5rBXrOOKt2TKH.Size = new Size(125, 25);
		this._ZCZoTOBxN9mFZI5rBXrOOKt2TKH.TabIndex = 1;
		this._ZCZoTOBxN9mFZI5rBXrOOKt2TKH.Text = "Anti Debuffs";
		this._ZCZoTOBxN9mFZI5rBXrOOKt2TKH.UseVisualStyleBackColor = false;
		this._xZBd1IVcAqPTBrdFglWuJbpqhVv.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
		this._xZBd1IVcAqPTBrdFglWuJbpqhVv.BackColor = Color.FromArgb(64, 21, 62);
		this._xZBd1IVcAqPTBrdFglWuJbpqhVv.BorderStyle = BorderStyle.FixedSingle;
		this._xZBd1IVcAqPTBrdFglWuJbpqhVv.Controls.Add(this._kWKdv7Ej4YZpJmrueD5AxpqBF7bA);
		this._xZBd1IVcAqPTBrdFglWuJbpqhVv.Controls.Add(this._0doBNQg7RJwqoJMchbOLNlaqlvYA);
		this._xZBd1IVcAqPTBrdFglWuJbpqhVv.Controls.Add(this._fy5pJKD6hrd5Rd3BYJDMYnkrYMG);
		this._xZBd1IVcAqPTBrdFglWuJbpqhVv.Controls.Add(this._69arQcmFpxyq8YsKbiEEVFHjqKn);
		this._xZBd1IVcAqPTBrdFglWuJbpqhVv.Controls.Add(this._x1fiq46peAdaxB8CJb2R1gvC3Ze);
		this._xZBd1IVcAqPTBrdFglWuJbpqhVv.Controls.Add(this._ZmvCnBYucGfhRyLkfY8Vn57QKl);
		this._xZBd1IVcAqPTBrdFglWuJbpqhVv.Controls.Add(this._wIxsQPJFBeOnkTBETLyot7U7HQd);
		this._xZBd1IVcAqPTBrdFglWuJbpqhVv.Controls.Add(this._D7P47Rl73LeCnoWEZ4ymh4fBqgy);
		this._xZBd1IVcAqPTBrdFglWuJbpqhVv.Controls.Add(this._jnLDC0xHVtKyjWVKOWAH40DziuUb);
		this._xZBd1IVcAqPTBrdFglWuJbpqhVv.Controls.Add(this._Dl9iE93suz1bDyhKZboK2jTfawDA);
		this._xZBd1IVcAqPTBrdFglWuJbpqhVv.Controls.Add(this._GrjrySFEic6T6Z7wWeAIYZ0GJrA);
		this._xZBd1IVcAqPTBrdFglWuJbpqhVv.Controls.Add(this._5IRdHPBh5V6bUQuEKkyGn9RUi1T);
		this._xZBd1IVcAqPTBrdFglWuJbpqhVv.Controls.Add(this._Bqrrvj9sLTV9fVEWILcdRkkmjKo);
		this._xZBd1IVcAqPTBrdFglWuJbpqhVv.Controls.Add(this._QizBpycMvTObFLaaBtybGm832AR);
		this._xZBd1IVcAqPTBrdFglWuJbpqhVv.Controls.Add(this._nOqnw75a3yyZAudzbKHSIUYMy4n);
		this._xZBd1IVcAqPTBrdFglWuJbpqhVv.Controls.Add(this._cDL6L6SyYNLSfiuaaTdcpgF0E5Y);
		this._xZBd1IVcAqPTBrdFglWuJbpqhVv.Controls.Add(this._Mc1AKCDOLA5IewbvwOjyn2GdPfq);
		this._xZBd1IVcAqPTBrdFglWuJbpqhVv.Controls.Add(this._m8Tr8k6wY8UXWx0M0vhk32xVXwb);
		this._xZBd1IVcAqPTBrdFglWuJbpqhVv.Controls.Add(this._YjbICycDEC61T7pIUVy0eaY9v1m);
		this._xZBd1IVcAqPTBrdFglWuJbpqhVv.Location = new Point(6, 407);
		this._xZBd1IVcAqPTBrdFglWuJbpqhVv.Name = "pnlAutoLoot";
		this._xZBd1IVcAqPTBrdFglWuJbpqhVv.Size = new Size(502, 174);
		this._xZBd1IVcAqPTBrdFglWuJbpqhVv.TabIndex = 23;
		this._kWKdv7Ej4YZpJmrueD5AxpqBF7bA.AutoSize = true;
		this._kWKdv7Ej4YZpJmrueD5AxpqBF7bA.BackColor = Color.FromArgb(64, 21, 62);
		this._kWKdv7Ej4YZpJmrueD5AxpqBF7bA.Location = new Point(180, 90);
		this._kWKdv7Ej4YZpJmrueD5AxpqBF7bA.Name = "chkAutoLootBigLootBags";
		this._kWKdv7Ej4YZpJmrueD5AxpqBF7bA.Size = new Size(107, 21);
		this._kWKdv7Ej4YZpJmrueD5AxpqBF7bA.TabIndex = 27;
		this._kWKdv7Ej4YZpJmrueD5AxpqBF7bA.Text = "Big Loot Bags";
		this._kWKdv7Ej4YZpJmrueD5AxpqBF7bA.UseVisualStyleBackColor = false;
		this._0doBNQg7RJwqoJMchbOLNlaqlvYA.AutoSize = true;
		this._0doBNQg7RJwqoJMchbOLNlaqlvYA.BackColor = Color.FromArgb(64, 21, 62);
		this._0doBNQg7RJwqoJMchbOLNlaqlvYA.Location = new Point(321, 117);
		this._0doBNQg7RJwqoJMchbOLNlaqlvYA.Name = "chkAutoLootOverFillMP";
		this._0doBNQg7RJwqoJMchbOLNlaqlvYA.Size = new Size(138, 21);
		this._0doBNQg7RJwqoJMchbOLNlaqlvYA.TabIndex = 26;
		this._0doBNQg7RJwqoJMchbOLNlaqlvYA.Text = "Overfill MP Potions";
		this._0doBNQg7RJwqoJMchbOLNlaqlvYA.UseVisualStyleBackColor = false;
		this._fy5pJKD6hrd5Rd3BYJDMYnkrYMG.AutoSize = true;
		this._fy5pJKD6hrd5Rd3BYJDMYnkrYMG.BackColor = Color.FromArgb(64, 21, 62);
		this._fy5pJKD6hrd5Rd3BYJDMYnkrYMG.Location = new Point(180, 117);
		this._fy5pJKD6hrd5Rd3BYJDMYnkrYMG.Name = "chkAutoLootOverFillHP";
		this._fy5pJKD6hrd5Rd3BYJDMYnkrYMG.Size = new Size(135, 21);
		this._fy5pJKD6hrd5Rd3BYJDMYnkrYMG.TabIndex = 25;
		this._fy5pJKD6hrd5Rd3BYJDMYnkrYMG.Text = "Overfill HP Potions";
		this._fy5pJKD6hrd5Rd3BYJDMYnkrYMG.UseVisualStyleBackColor = false;
		this._69arQcmFpxyq8YsKbiEEVFHjqKn.AutoSize = true;
		this._69arQcmFpxyq8YsKbiEEVFHjqKn.BackColor = Color.FromArgb(64, 21, 62);
		this._69arQcmFpxyq8YsKbiEEVFHjqKn.Location = new Point(30, 144);
		this._69arQcmFpxyq8YsKbiEEVFHjqKn.Name = "chkAutoLootMarks";
		this._69arQcmFpxyq8YsKbiEEVFHjqKn.Size = new Size(93, 21);
		this._69arQcmFpxyq8YsKbiEEVFHjqKn.TabIndex = 24;
		this._69arQcmFpxyq8YsKbiEEVFHjqKn.Text = "Loot Marks";
		this._69arQcmFpxyq8YsKbiEEVFHjqKn.UseVisualStyleBackColor = false;
		this._x1fiq46peAdaxB8CJb2R1gvC3Ze.AutoSize = true;
		this._x1fiq46peAdaxB8CJb2R1gvC3Ze.BackColor = Color.FromArgb(64, 21, 62);
		this._x1fiq46peAdaxB8CJb2R1gvC3Ze.Location = new Point(30, 90);
		this._x1fiq46peAdaxB8CJb2R1gvC3Ze.Name = "chkAutoLootQuests";
		this._x1fiq46peAdaxB8CJb2R1gvC3Ze.Size = new Size(132, 21);
		this._x1fiq46peAdaxB8CJb2R1gvC3Ze.TabIndex = 23;
		this._x1fiq46peAdaxB8CJb2R1gvC3Ze.Text = "Show Loot Quests";
		this._x1fiq46peAdaxB8CJb2R1gvC3Ze.UseVisualStyleBackColor = false;
		this._ZmvCnBYucGfhRyLkfY8Vn57QKl.BackColor = Color.FromArgb(64, 21, 62);
		this._ZmvCnBYucGfhRyLkfY8Vn57QKl.Font = new Font("Segoe UI", 8.25f);
		this._ZmvCnBYucGfhRyLkfY8Vn57QKl.ForeColor = SystemColors.ControlLight;
		this._ZmvCnBYucGfhRyLkfY8Vn57QKl.Location = new Point(353, 62);
		NumericUpDown zmvCnBYucGfhRyLkfY8Vn57QKl = this._ZmvCnBYucGfhRyLkfY8Vn57QKl;
		int[] array = new int[4];
		array[0] = 20;
		zmvCnBYucGfhRyLkfY8Vn57QKl.Maximum = new decimal(array);
		NumericUpDown zmvCnBYucGfhRyLkfY8Vn57QKl2 = this._ZmvCnBYucGfhRyLkfY8Vn57QKl;
		int[] array2 = new int[4];
		array2[0] = 1;
		zmvCnBYucGfhRyLkfY8Vn57QKl2.Minimum = new decimal(array2);
		this._ZmvCnBYucGfhRyLkfY8Vn57QKl.Name = "numAutoLootRingTierThreshold";
		this._ZmvCnBYucGfhRyLkfY8Vn57QKl.Size = new Size(40, 22);
		this._ZmvCnBYucGfhRyLkfY8Vn57QKl.TabIndex = 20;
		NumericUpDown zmvCnBYucGfhRyLkfY8Vn57QKl3 = this._ZmvCnBYucGfhRyLkfY8Vn57QKl;
		int[] array3 = new int[4];
		array3[0] = 1;
		zmvCnBYucGfhRyLkfY8Vn57QKl3.Value = new decimal(array3);
		this._wIxsQPJFBeOnkTBETLyot7U7HQd.AutoSize = true;
		this._wIxsQPJFBeOnkTBETLyot7U7HQd.BackColor = Color.FromArgb(64, 21, 62);
		this._wIxsQPJFBeOnkTBETLyot7U7HQd.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this._wIxsQPJFBeOnkTBETLyot7U7HQd.ForeColor = SystemColors.ControlLight;
		this._wIxsQPJFBeOnkTBETLyot7U7HQd.Location = new Point(222, 63);
		this._wIxsQPJFBeOnkTBETLyot7U7HQd.Name = "lblMinimumRingTier";
		this._wIxsQPJFBeOnkTBETLyot7U7HQd.Size = new Size(121, 17);
		this._wIxsQPJFBeOnkTBETLyot7U7HQd.TabIndex = 21;
		this._wIxsQPJFBeOnkTBETLyot7U7HQd.Text = "Minimum Ring Tier:";
		this._D7P47Rl73LeCnoWEZ4ymh4fBqgy.BackColor = Color.FromArgb(64, 21, 62);
		this._D7P47Rl73LeCnoWEZ4ymh4fBqgy.Font = new Font("Segoe UI", 8.25f);
		this._D7P47Rl73LeCnoWEZ4ymh4fBqgy.ForeColor = SystemColors.ControlLight;
		this._D7P47Rl73LeCnoWEZ4ymh4fBqgy.Location = new Point(353, 34);
		NumericUpDown d7P47Rl73LeCnoWEZ4ymh4fBqgy = this._D7P47Rl73LeCnoWEZ4ymh4fBqgy;
		int[] array4 = new int[4];
		array4[0] = 20;
		d7P47Rl73LeCnoWEZ4ymh4fBqgy.Maximum = new decimal(array4);
		NumericUpDown d7P47Rl73LeCnoWEZ4ymh4fBqgy2 = this._D7P47Rl73LeCnoWEZ4ymh4fBqgy;
		int[] array5 = new int[4];
		array5[0] = 1;
		d7P47Rl73LeCnoWEZ4ymh4fBqgy2.Minimum = new decimal(array5);
		this._D7P47Rl73LeCnoWEZ4ymh4fBqgy.Name = "numAutoLootAbilityTierThreshold";
		this._D7P47Rl73LeCnoWEZ4ymh4fBqgy.Size = new Size(40, 22);
		this._D7P47Rl73LeCnoWEZ4ymh4fBqgy.TabIndex = 18;
		NumericUpDown d7P47Rl73LeCnoWEZ4ymh4fBqgy3 = this._D7P47Rl73LeCnoWEZ4ymh4fBqgy;
		int[] array6 = new int[4];
		array6[0] = 1;
		d7P47Rl73LeCnoWEZ4ymh4fBqgy3.Value = new decimal(array6);
		this._jnLDC0xHVtKyjWVKOWAH40DziuUb.AutoSize = true;
		this._jnLDC0xHVtKyjWVKOWAH40DziuUb.BackColor = Color.FromArgb(64, 21, 62);
		this._jnLDC0xHVtKyjWVKOWAH40DziuUb.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this._jnLDC0xHVtKyjWVKOWAH40DziuUb.ForeColor = SystemColors.ControlLight;
		this._jnLDC0xHVtKyjWVKOWAH40DziuUb.Location = new Point(222, 35);
		this._jnLDC0xHVtKyjWVKOWAH40DziuUb.Name = "lblMinimumAbilityTier";
		this._jnLDC0xHVtKyjWVKOWAH40DziuUb.Size = new Size(130, 17);
		this._jnLDC0xHVtKyjWVKOWAH40DziuUb.TabIndex = 19;
		this._jnLDC0xHVtKyjWVKOWAH40DziuUb.Text = "Minimum Ability Tier:";
		this._Dl9iE93suz1bDyhKZboK2jTfawDA.AutoSize = true;
		this._Dl9iE93suz1bDyhKZboK2jTfawDA.BackColor = Color.FromArgb(64, 21, 62);
		this._Dl9iE93suz1bDyhKZboK2jTfawDA.Location = new Point(133, 144);
		this._Dl9iE93suz1bDyhKZboK2jTfawDA.Name = "chkAutoLootUTs";
		this._Dl9iE93suz1bDyhKZboK2jTfawDA.Size = new Size(78, 21);
		this._Dl9iE93suz1bDyhKZboK2jTfawDA.TabIndex = 17;
		this._Dl9iE93suz1bDyhKZboK2jTfawDA.Text = "Loot UTs";
		this._Dl9iE93suz1bDyhKZboK2jTfawDA.UseVisualStyleBackColor = false;
		this._GrjrySFEic6T6Z7wWeAIYZ0GJrA.AutoSize = true;
		this._GrjrySFEic6T6Z7wWeAIYZ0GJrA.BackColor = Color.FromArgb(64, 21, 62);
		this._GrjrySFEic6T6Z7wWeAIYZ0GJrA.Location = new Point(30, 117);
		this._GrjrySFEic6T6Z7wWeAIYZ0GJrA.Name = "chkAutoLootHealingPotions";
		this._GrjrySFEic6T6Z7wWeAIYZ0GJrA.Size = new Size(144, 21);
		this._GrjrySFEic6T6Z7wWeAIYZ0GJrA.TabIndex = 16;
		this._GrjrySFEic6T6Z7wWeAIYZ0GJrA.Text = "Loot HP/MP Potions";
		this._GrjrySFEic6T6Z7wWeAIYZ0GJrA.UseVisualStyleBackColor = false;
		this._5IRdHPBh5V6bUQuEKkyGn9RUi1T.AutoSize = true;
		this._5IRdHPBh5V6bUQuEKkyGn9RUi1T.BackColor = Color.FromArgb(64, 21, 62);
		this._5IRdHPBh5V6bUQuEKkyGn9RUi1T.Location = new Point(217, 144);
		this._5IRdHPBh5V6bUQuEKkyGn9RUi1T.Name = "chkAutoLootStatPotions";
		this._5IRdHPBh5V6bUQuEKkyGn9RUi1T.Size = new Size(126, 21);
		this._5IRdHPBh5V6bUQuEKkyGn9RUi1T.TabIndex = 15;
		this._5IRdHPBh5V6bUQuEKkyGn9RUi1T.Text = "Loot Stat Potions";
		this._5IRdHPBh5V6bUQuEKkyGn9RUi1T.UseVisualStyleBackColor = false;
		this._Bqrrvj9sLTV9fVEWILcdRkkmjKo.BackColor = Color.FromArgb(64, 21, 62);
		this._Bqrrvj9sLTV9fVEWILcdRkkmjKo.Font = new Font("Segoe UI", 8.25f);
		this._Bqrrvj9sLTV9fVEWILcdRkkmjKo.ForeColor = SystemColors.ControlLight;
		this._Bqrrvj9sLTV9fVEWILcdRkkmjKo.Location = new Point(171, 62);
		NumericUpDown bqrrvj9sLTV9fVEWILcdRkkmjKo = this._Bqrrvj9sLTV9fVEWILcdRkkmjKo;
		int[] array7 = new int[4];
		array7[0] = 20;
		bqrrvj9sLTV9fVEWILcdRkkmjKo.Maximum = new decimal(array7);
		NumericUpDown bqrrvj9sLTV9fVEWILcdRkkmjKo2 = this._Bqrrvj9sLTV9fVEWILcdRkkmjKo;
		int[] array8 = new int[4];
		array8[0] = 1;
		bqrrvj9sLTV9fVEWILcdRkkmjKo2.Minimum = new decimal(array8);
		this._Bqrrvj9sLTV9fVEWILcdRkkmjKo.Name = "numAutoLootArmorTierThreshold";
		this._Bqrrvj9sLTV9fVEWILcdRkkmjKo.Size = new Size(40, 22);
		this._Bqrrvj9sLTV9fVEWILcdRkkmjKo.TabIndex = 11;
		NumericUpDown bqrrvj9sLTV9fVEWILcdRkkmjKo3 = this._Bqrrvj9sLTV9fVEWILcdRkkmjKo;
		int[] array9 = new int[4];
		array9[0] = 1;
		bqrrvj9sLTV9fVEWILcdRkkmjKo3.Value = new decimal(array9);
		this._QizBpycMvTObFLaaBtybGm832AR.AutoSize = true;
		this._QizBpycMvTObFLaaBtybGm832AR.BackColor = Color.FromArgb(64, 21, 62);
		this._QizBpycMvTObFLaaBtybGm832AR.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this._QizBpycMvTObFLaaBtybGm832AR.ForeColor = SystemColors.ControlLight;
		this._QizBpycMvTObFLaaBtybGm832AR.Location = new Point(27, 63);
		this._QizBpycMvTObFLaaBtybGm832AR.Name = "lblMinimumArmorTier";
		this._QizBpycMvTObFLaaBtybGm832AR.Size = new Size(132, 17);
		this._QizBpycMvTObFLaaBtybGm832AR.TabIndex = 12;
		this._QizBpycMvTObFLaaBtybGm832AR.Text = "Minimum Armor Tier:";
		this._nOqnw75a3yyZAudzbKHSIUYMy4n.BackColor = Color.FromArgb(64, 21, 62);
		this._nOqnw75a3yyZAudzbKHSIUYMy4n.Font = new Font("Segoe UI", 8.25f);
		this._nOqnw75a3yyZAudzbKHSIUYMy4n.ForeColor = SystemColors.ControlLight;
		this._nOqnw75a3yyZAudzbKHSIUYMy4n.Location = new Point(171, 34);
		NumericUpDown nOqnw75a3yyZAudzbKHSIUYMy4n = this._nOqnw75a3yyZAudzbKHSIUYMy4n;
		int[] array10 = new int[4];
		array10[0] = 20;
		nOqnw75a3yyZAudzbKHSIUYMy4n.Maximum = new decimal(array10);
		NumericUpDown nOqnw75a3yyZAudzbKHSIUYMy4n2 = this._nOqnw75a3yyZAudzbKHSIUYMy4n;
		int[] array11 = new int[4];
		array11[0] = 1;
		nOqnw75a3yyZAudzbKHSIUYMy4n2.Minimum = new decimal(array11);
		this._nOqnw75a3yyZAudzbKHSIUYMy4n.Name = "numAutoLootWeaponTierThreshold";
		this._nOqnw75a3yyZAudzbKHSIUYMy4n.Size = new Size(40, 22);
		this._nOqnw75a3yyZAudzbKHSIUYMy4n.TabIndex = 9;
		NumericUpDown nOqnw75a3yyZAudzbKHSIUYMy4n3 = this._nOqnw75a3yyZAudzbKHSIUYMy4n;
		int[] array12 = new int[4];
		array12[0] = 1;
		nOqnw75a3yyZAudzbKHSIUYMy4n3.Value = new decimal(array12);
		this._cDL6L6SyYNLSfiuaaTdcpgF0E5Y.AutoSize = true;
		this._cDL6L6SyYNLSfiuaaTdcpgF0E5Y.BackColor = Color.FromArgb(64, 21, 62);
		this._cDL6L6SyYNLSfiuaaTdcpgF0E5Y.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this._cDL6L6SyYNLSfiuaaTdcpgF0E5Y.ForeColor = SystemColors.ControlLight;
		this._cDL6L6SyYNLSfiuaaTdcpgF0E5Y.Location = new Point(27, 35);
		this._cDL6L6SyYNLSfiuaaTdcpgF0E5Y.Name = "lblMinimumWeaponTier";
		this._cDL6L6SyYNLSfiuaaTdcpgF0E5Y.Size = new Size(143, 17);
		this._cDL6L6SyYNLSfiuaaTdcpgF0E5Y.TabIndex = 10;
		this._cDL6L6SyYNLSfiuaaTdcpgF0E5Y.Text = "Minimum Weapon Tier:";
		this._Mc1AKCDOLA5IewbvwOjyn2GdPfq.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
		this._Mc1AKCDOLA5IewbvwOjyn2GdPfq.BackColor = Color.FromArgb(64, 21, 62);
		this._Mc1AKCDOLA5IewbvwOjyn2GdPfq.BorderStyle = BorderStyle.FixedSingle;
		this._Mc1AKCDOLA5IewbvwOjyn2GdPfq.Location = new Point(8, 28);
		this._Mc1AKCDOLA5IewbvwOjyn2GdPfq.Name = "sepAutoLoot";
		this._Mc1AKCDOLA5IewbvwOjyn2GdPfq.Size = new Size(485, 1);
		this._Mc1AKCDOLA5IewbvwOjyn2GdPfq.TabIndex = 6;
		this._m8Tr8k6wY8UXWx0M0vhk32xVXwb.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
		this._m8Tr8k6wY8UXWx0M0vhk32xVXwb.Font = new Font("Segoe UI", 6.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this._m8Tr8k6wY8UXWx0M0vhk32xVXwb.ForeColor = Color.Black;
		this._m8Tr8k6wY8UXWx0M0vhk32xVXwb.Location = new Point(471, 5);
		this._m8Tr8k6wY8UXWx0M0vhk32xVXwb.Name = "btnAutoLootInfo";
		this._m8Tr8k6wY8UXWx0M0vhk32xVXwb.Size = new Size(23, 20);
		this._m8Tr8k6wY8UXWx0M0vhk32xVXwb.TabIndex = 5;
		this._m8Tr8k6wY8UXWx0M0vhk32xVXwb.Text = "?";
		this._m8Tr8k6wY8UXWx0M0vhk32xVXwb.UseVisualStyleBackColor = true;
		this._m8Tr8k6wY8UXWx0M0vhk32xVXwb.Click += this._UnSIOV3laMPRj2Lqs3IAJvQdtvi;
		this._YjbICycDEC61T7pIUVy0eaY9v1m.AutoSize = true;
		this._YjbICycDEC61T7pIUVy0eaY9v1m.BackColor = Color.FromArgb(64, 21, 62);
		this._YjbICycDEC61T7pIUVy0eaY9v1m.Font = new Font("Segoe UI", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this._YjbICycDEC61T7pIUVy0eaY9v1m.ForeColor = SystemColors.ButtonFace;
		this._YjbICycDEC61T7pIUVy0eaY9v1m.Location = new Point(8, 3);
		this._YjbICycDEC61T7pIUVy0eaY9v1m.Name = "chkAutoLoot";
		this._YjbICycDEC61T7pIUVy0eaY9v1m.Size = new Size(104, 25);
		this._YjbICycDEC61T7pIUVy0eaY9v1m.TabIndex = 1;
		this._YjbICycDEC61T7pIUVy0eaY9v1m.Text = "Auto Loot";
		this._YjbICycDEC61T7pIUVy0eaY9v1m.UseVisualStyleBackColor = false;
		this._ZE6BWnV3aucOtptJFG0jFQt19wR.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
		this._ZE6BWnV3aucOtptJFG0jFQt19wR.BackColor = Color.FromArgb(24, 51, 42);
		this._ZE6BWnV3aucOtptJFG0jFQt19wR.BorderStyle = BorderStyle.FixedSingle;
		this._ZE6BWnV3aucOtptJFG0jFQt19wR.Controls.Add(this._l6raCVgixQmMN8kPAfYkFYnrqky);
		this._ZE6BWnV3aucOtptJFG0jFQt19wR.Controls.Add(this._UNMKg8qPomqO5a5Jew7ukXPzENf);
		this._ZE6BWnV3aucOtptJFG0jFQt19wR.Controls.Add(this._dmOAJYyrtKFKK3xUW1NDcvh5QVv);
		this._ZE6BWnV3aucOtptJFG0jFQt19wR.Controls.Add(this._wHaSFzsf19T5k2ZBGvHJu0pcf3i);
		this._ZE6BWnV3aucOtptJFG0jFQt19wR.Controls.Add(this._jtPLnv8PlfLBzXu7dbti6f34nDq);
		this._ZE6BWnV3aucOtptJFG0jFQt19wR.Controls.Add(this._U56cl9eFIl3JKbtQh9k53UWb6SY);
		this._ZE6BWnV3aucOtptJFG0jFQt19wR.Controls.Add(this._mf7O8njBr55uJOPndWhOfZhB26k);
		this._ZE6BWnV3aucOtptJFG0jFQt19wR.Controls.Add(this._kevi7G85zI1rlB8dS2oLX5hhF5k);
		this._ZE6BWnV3aucOtptJFG0jFQt19wR.Controls.Add(this._OuRzT08buKm1QrtE8IGaLOiW9qM);
		this._ZE6BWnV3aucOtptJFG0jFQt19wR.Location = new Point(6, 309);
		this._ZE6BWnV3aucOtptJFG0jFQt19wR.Name = "pnlAutoAim";
		this._ZE6BWnV3aucOtptJFG0jFQt19wR.Size = new Size(502, 92);
		this._ZE6BWnV3aucOtptJFG0jFQt19wR.TabIndex = 22;
		this._l6raCVgixQmMN8kPAfYkFYnrqky.AutoSize = true;
		this._l6raCVgixQmMN8kPAfYkFYnrqky.BackColor = Color.FromArgb(24, 51, 42);
		this._l6raCVgixQmMN8kPAfYkFYnrqky.Location = new Point(358, 63);
		this._l6raCVgixQmMN8kPAfYkFYnrqky.Name = "chkAutoAimAlwaysFire";
		this._l6raCVgixQmMN8kPAfYkFYnrqky.Size = new Size(91, 21);
		this._l6raCVgixQmMN8kPAfYkFYnrqky.TabIndex = 13;
		this._l6raCVgixQmMN8kPAfYkFYnrqky.Text = "Always Fire";
		this._l6raCVgixQmMN8kPAfYkFYnrqky.UseVisualStyleBackColor = false;
		this._UNMKg8qPomqO5a5Jew7ukXPzENf.AutoSize = true;
		this._UNMKg8qPomqO5a5Jew7ukXPzENf.BackColor = Color.FromArgb(24, 51, 42);
		this._UNMKg8qPomqO5a5Jew7ukXPzENf.Location = new Point(201, 62);
		this._UNMKg8qPomqO5a5Jew7ukXPzENf.Name = "chkAutoAimAtClosestEnemy";
		this._UNMKg8qPomqO5a5Jew7ukXPzENf.Size = new Size(151, 21);
		this._UNMKg8qPomqO5a5Jew7ukXPzENf.TabIndex = 12;
		this._UNMKg8qPomqO5a5Jew7ukXPzENf.TabStop = true;
		this._UNMKg8qPomqO5a5Jew7ukXPzENf.Text = "Aim at Closest Enemy";
		this._UNMKg8qPomqO5a5Jew7ukXPzENf.UseVisualStyleBackColor = false;
		this._dmOAJYyrtKFKK3xUW1NDcvh5QVv.AutoSize = true;
		this._dmOAJYyrtKFKK3xUW1NDcvh5QVv.BackColor = Color.FromArgb(24, 51, 42);
		this._dmOAJYyrtKFKK3xUW1NDcvh5QVv.Location = new Point(30, 62);
		this._dmOAJYyrtKFKK3xUW1NDcvh5QVv.Name = "chkAutoAimAtStrongestEnemy";
		this._dmOAJYyrtKFKK3xUW1NDcvh5QVv.Size = new Size(165, 21);
		this._dmOAJYyrtKFKK3xUW1NDcvh5QVv.TabIndex = 11;
		this._dmOAJYyrtKFKK3xUW1NDcvh5QVv.TabStop = true;
		this._dmOAJYyrtKFKK3xUW1NDcvh5QVv.Text = "Aim at Strongest Enemy";
		this._dmOAJYyrtKFKK3xUW1NDcvh5QVv.UseVisualStyleBackColor = false;
		this._wHaSFzsf19T5k2ZBGvHJu0pcf3i.AutoSize = true;
		this._wHaSFzsf19T5k2ZBGvHJu0pcf3i.BackColor = Color.FromArgb(24, 51, 42);
		this._wHaSFzsf19T5k2ZBGvHJu0pcf3i.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this._wHaSFzsf19T5k2ZBGvHJu0pcf3i.ForeColor = SystemColors.ControlLight;
		this._wHaSFzsf19T5k2ZBGvHJu0pcf3i.Location = new Point(146, 35);
		this._wHaSFzsf19T5k2ZBGvHJu0pcf3i.Name = "lblAimRangeTiles";
		this._wHaSFzsf19T5k2ZBGvHJu0pcf3i.Size = new Size(31, 17);
		this._wHaSFzsf19T5k2ZBGvHJu0pcf3i.TabIndex = 9;
		this._wHaSFzsf19T5k2ZBGvHJu0pcf3i.Text = "tiles";
		this._jtPLnv8PlfLBzXu7dbti6f34nDq.BackColor = Color.FromArgb(24, 51, 42);
		this._jtPLnv8PlfLBzXu7dbti6f34nDq.Font = new Font("Segoe UI", 8.25f);
		this._jtPLnv8PlfLBzXu7dbti6f34nDq.ForeColor = SystemColors.ControlLight;
		this._jtPLnv8PlfLBzXu7dbti6f34nDq.Location = new Point(102, 34);
		NumericUpDown jtPLnv8PlfLBzXu7dbti6f34nDq = this._jtPLnv8PlfLBzXu7dbti6f34nDq;
		int[] array13 = new int[4];
		array13[0] = 20;
		jtPLnv8PlfLBzXu7dbti6f34nDq.Maximum = new decimal(array13);
		NumericUpDown jtPLnv8PlfLBzXu7dbti6f34nDq2 = this._jtPLnv8PlfLBzXu7dbti6f34nDq;
		int[] array14 = new int[4];
		array14[0] = 1;
		jtPLnv8PlfLBzXu7dbti6f34nDq2.Minimum = new decimal(array14);
		this._jtPLnv8PlfLBzXu7dbti6f34nDq.Name = "numAutoAimRangeThreshold";
		this._jtPLnv8PlfLBzXu7dbti6f34nDq.Size = new Size(40, 22);
		this._jtPLnv8PlfLBzXu7dbti6f34nDq.TabIndex = 7;
		NumericUpDown jtPLnv8PlfLBzXu7dbti6f34nDq3 = this._jtPLnv8PlfLBzXu7dbti6f34nDq;
		int[] array15 = new int[4];
		array15[0] = 1;
		jtPLnv8PlfLBzXu7dbti6f34nDq3.Value = new decimal(array15);
		this._U56cl9eFIl3JKbtQh9k53UWb6SY.AutoSize = true;
		this._U56cl9eFIl3JKbtQh9k53UWb6SY.BackColor = Color.FromArgb(24, 51, 42);
		this._U56cl9eFIl3JKbtQh9k53UWb6SY.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this._U56cl9eFIl3JKbtQh9k53UWb6SY.ForeColor = SystemColors.ControlLight;
		this._U56cl9eFIl3JKbtQh9k53UWb6SY.Location = new Point(27, 35);
		this._U56cl9eFIl3JKbtQh9k53UWb6SY.Name = "lblAimRange";
		this._U56cl9eFIl3JKbtQh9k53UWb6SY.Size = new Size(74, 17);
		this._U56cl9eFIl3JKbtQh9k53UWb6SY.TabIndex = 8;
		this._U56cl9eFIl3JKbtQh9k53UWb6SY.Text = "Aim Range:";
		this._mf7O8njBr55uJOPndWhOfZhB26k.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
		this._mf7O8njBr55uJOPndWhOfZhB26k.BackColor = Color.FromArgb(24, 51, 42);
		this._mf7O8njBr55uJOPndWhOfZhB26k.BorderStyle = BorderStyle.FixedSingle;
		this._mf7O8njBr55uJOPndWhOfZhB26k.Location = new Point(8, 28);
		this._mf7O8njBr55uJOPndWhOfZhB26k.Name = "sepAutoAim";
		this._mf7O8njBr55uJOPndWhOfZhB26k.Size = new Size(485, 1);
		this._mf7O8njBr55uJOPndWhOfZhB26k.TabIndex = 6;
		this._kevi7G85zI1rlB8dS2oLX5hhF5k.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
		this._kevi7G85zI1rlB8dS2oLX5hhF5k.Font = new Font("Segoe UI", 6.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this._kevi7G85zI1rlB8dS2oLX5hhF5k.ForeColor = Color.Black;
		this._kevi7G85zI1rlB8dS2oLX5hhF5k.Location = new Point(471, 5);
		this._kevi7G85zI1rlB8dS2oLX5hhF5k.Name = "btnAutoAimInfo";
		this._kevi7G85zI1rlB8dS2oLX5hhF5k.Size = new Size(23, 20);
		this._kevi7G85zI1rlB8dS2oLX5hhF5k.TabIndex = 5;
		this._kevi7G85zI1rlB8dS2oLX5hhF5k.Text = "?";
		this._kevi7G85zI1rlB8dS2oLX5hhF5k.UseVisualStyleBackColor = true;
		this._kevi7G85zI1rlB8dS2oLX5hhF5k.Click += this._5GHoc2YDqDj3YNQJeQtH9mjoEng;
		this._OuRzT08buKm1QrtE8IGaLOiW9qM.AutoSize = true;
		this._OuRzT08buKm1QrtE8IGaLOiW9qM.BackColor = Color.FromArgb(24, 51, 42);
		this._OuRzT08buKm1QrtE8IGaLOiW9qM.Enabled = false;
		this._OuRzT08buKm1QrtE8IGaLOiW9qM.Font = new Font("Segoe UI", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this._OuRzT08buKm1QrtE8IGaLOiW9qM.ForeColor = SystemColors.ButtonFace;
		this._OuRzT08buKm1QrtE8IGaLOiW9qM.Location = new Point(8, 3);
		this._OuRzT08buKm1QrtE8IGaLOiW9qM.Name = "chkAutoAim";
		this._OuRzT08buKm1QrtE8IGaLOiW9qM.Size = new Size(253, 25);
		this._OuRzT08buKm1QrtE8IGaLOiW9qM.TabIndex = 1;
		this._OuRzT08buKm1QrtE8IGaLOiW9qM.Text = "Auto Aim (Not Implemented)";
		this._OuRzT08buKm1QrtE8IGaLOiW9qM.UseVisualStyleBackColor = false;
		this._oUyaM8rB6O9TO4tYBzBYZxK4m3w.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
		this._oUyaM8rB6O9TO4tYBzBYZxK4m3w.BackColor = Color.FromArgb(74, 31, 32);
		this._oUyaM8rB6O9TO4tYBzBYZxK4m3w.BorderStyle = BorderStyle.FixedSingle;
		this._oUyaM8rB6O9TO4tYBzBYZxK4m3w.Controls.Add(this._Hjc8Zs1G4lABixPBnJgdEybxLNL);
		this._oUyaM8rB6O9TO4tYBzBYZxK4m3w.Controls.Add(this._CNPY7lJQfipiMP54YgOStijjuD);
		this._oUyaM8rB6O9TO4tYBzBYZxK4m3w.Controls.Add(this._JtRnoMorwqCBXJIsNMmgOow41KL);
		this._oUyaM8rB6O9TO4tYBzBYZxK4m3w.Controls.Add(this._6k83485jw6zIY1JyvUVJehSZU1e);
		this._oUyaM8rB6O9TO4tYBzBYZxK4m3w.Controls.Add(this._OtdDwtRcwgnd04tA1CeTqnWtGmdA);
		this._oUyaM8rB6O9TO4tYBzBYZxK4m3w.Controls.Add(this._sN2qtf5IZN2fEvMaqDslGiFFgAV);
		this._oUyaM8rB6O9TO4tYBzBYZxK4m3w.Controls.Add(this._agYF6ii02oU5KICbi31ZCzXf25U);
		this._oUyaM8rB6O9TO4tYBzBYZxK4m3w.Controls.Add(this._GvDTOnQNOsGJ89PGbQmKVm4TY4f);
		this._oUyaM8rB6O9TO4tYBzBYZxK4m3w.Controls.Add(this._JrQ0jvSnpu8tCPkHfWRan3nPstO);
		this._oUyaM8rB6O9TO4tYBzBYZxK4m3w.Controls.Add(this._eK6G41SpwvAkaNcHSQtBN8YOH3g);
		this._oUyaM8rB6O9TO4tYBzBYZxK4m3w.Controls.Add(this._Pqw9zi4w7GqQwYQK41QnTuuWuPB);
		this._oUyaM8rB6O9TO4tYBzBYZxK4m3w.Controls.Add(this._avTCWVvfyh5Z2ZcOPgrfahJGerT);
		this._oUyaM8rB6O9TO4tYBzBYZxK4m3w.Controls.Add(this._9QHYF9EAZe2ak9U6KEkgpsJl1u6);
		this._oUyaM8rB6O9TO4tYBzBYZxK4m3w.Controls.Add(this._ysfSIj72X08AFWJAyx7j0yhALnK);
		this._oUyaM8rB6O9TO4tYBzBYZxK4m3w.Controls.Add(this._FIIdC84o3TKCFUXg0FpaRpwDHmHA);
		this._oUyaM8rB6O9TO4tYBzBYZxK4m3w.Controls.Add(this._c5laqQAVlFJapJyeOL4JaLeJfbf);
		this._oUyaM8rB6O9TO4tYBzBYZxK4m3w.Controls.Add(this._oG0D38K3dGqrjszXNGDhJgLg3YO);
		this._oUyaM8rB6O9TO4tYBzBYZxK4m3w.Controls.Add(this._Mixf8sI0kZDJCwoFg3WpNQN0h1H);
		this._oUyaM8rB6O9TO4tYBzBYZxK4m3w.Controls.Add(this._ftgy68Qbf8ty1dzazTutC4fGxcX);
		this._oUyaM8rB6O9TO4tYBzBYZxK4m3w.Controls.Add(this._PurNnAIDE44j6AvnAPVuLPTqjSk);
		this._oUyaM8rB6O9TO4tYBzBYZxK4m3w.Location = new Point(6, 100);
		this._oUyaM8rB6O9TO4tYBzBYZxK4m3w.Name = "pnlAutoAbility";
		this._oUyaM8rB6O9TO4tYBzBYZxK4m3w.Size = new Size(502, 203);
		this._oUyaM8rB6O9TO4tYBzBYZxK4m3w.TabIndex = 21;
		this._CNPY7lJQfipiMP54YgOStijjuD.AutoSize = true;
		this._CNPY7lJQfipiMP54YgOStijjuD.BackColor = Color.FromArgb(74, 31, 32);
		this._CNPY7lJQfipiMP54YgOStijjuD.Location = new Point(30, 176);
		this._CNPY7lJQfipiMP54YgOStijjuD.Name = "chkAutoAbilityNotifications";
		this._CNPY7lJQfipiMP54YgOStijjuD.Size = new Size(226, 21);
		this._CNPY7lJQfipiMP54YgOStijjuD.TabIndex = 38;
		this._CNPY7lJQfipiMP54YgOStijjuD.Text = "Show Auto Activation Notifications";
		this._CNPY7lJQfipiMP54YgOStijjuD.UseVisualStyleBackColor = false;
		this._JtRnoMorwqCBXJIsNMmgOow41KL.AutoSize = true;
		this._JtRnoMorwqCBXJIsNMmgOow41KL.BackColor = Color.FromArgb(74, 31, 32);
		this._JtRnoMorwqCBXJIsNMmgOow41KL.Location = new Point(254, 92);
		this._JtRnoMorwqCBXJIsNMmgOow41KL.Name = "lblAutoAbilityHealHpPercentAfter";
		this._JtRnoMorwqCBXJIsNMmgOow41KL.Size = new Size(174, 17);
		this._JtRnoMorwqCBXJIsNMmgOow41KL.TabIndex = 37;
		this._JtRnoMorwqCBXJIsNMmgOow41KL.Text = "%  (for Priest healing tomes)";
		this._6k83485jw6zIY1JyvUVJehSZU1e.BackColor = Color.FromArgb(74, 31, 32);
		this._6k83485jw6zIY1JyvUVJehSZU1e.ForeColor = SystemColors.ControlLight;
		this._6k83485jw6zIY1JyvUVJehSZU1e.Location = new Point(201, 90);
		this._6k83485jw6zIY1JyvUVJehSZU1e.Name = "numAutoAbilityHealHpPercent";
		this._6k83485jw6zIY1JyvUVJehSZU1e.Size = new Size(50, 25);
		this._6k83485jw6zIY1JyvUVJehSZU1e.TabIndex = 36;
		NumericUpDown 6k83485jw6zIY1JyvUVJehSZU1e = this._6k83485jw6zIY1JyvUVJehSZU1e;
		int[] array16 = new int[4];
		array16[0] = 45;
		6k83485jw6zIY1JyvUVJehSZU1e.Value = new decimal(array16);
		this._OtdDwtRcwgnd04tA1CeTqnWtGmdA.AutoSize = true;
		this._OtdDwtRcwgnd04tA1CeTqnWtGmdA.BackColor = Color.FromArgb(74, 31, 32);
		this._OtdDwtRcwgnd04tA1CeTqnWtGmdA.Location = new Point(27, 92);
		this._OtdDwtRcwgnd04tA1CeTqnWtGmdA.Name = "lblAutoAbilityHealHpPercent";
		this._OtdDwtRcwgnd04tA1CeTqnWtGmdA.Size = new Size(140, 17);
		this._OtdDwtRcwgnd04tA1CeTqnWtGmdA.TabIndex = 35;
		this._OtdDwtRcwgnd04tA1CeTqnWtGmdA.Text = "Minimum Autoheal HP:";
		this._sN2qtf5IZN2fEvMaqDslGiFFgAV.AutoSize = true;
		this._sN2qtf5IZN2fEvMaqDslGiFFgAV.BackColor = Color.FromArgb(74, 31, 32);
		this._sN2qtf5IZN2fEvMaqDslGiFFgAV.Location = new Point(280, 149);
		this._sN2qtf5IZN2fEvMaqDslGiFFgAV.Name = "chkAutoAbilityClosestEnemy";
		this._sN2qtf5IZN2fEvMaqDslGiFFgAV.Size = new Size(109, 21);
		this._sN2qtf5IZN2fEvMaqDslGiFFgAV.TabIndex = 34;
		this._sN2qtf5IZN2fEvMaqDslGiFFgAV.TabStop = true;
		this._sN2qtf5IZN2fEvMaqDslGiFFgAV.Text = "Target Closest";
		this._sN2qtf5IZN2fEvMaqDslGiFFgAV.UseVisualStyleBackColor = false;
		this._agYF6ii02oU5KICbi31ZCzXf25U.AutoSize = true;
		this._agYF6ii02oU5KICbi31ZCzXf25U.BackColor = Color.FromArgb(74, 31, 32);
		this._agYF6ii02oU5KICbi31ZCzXf25U.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this._agYF6ii02oU5KICbi31ZCzXf25U.ForeColor = SystemColors.ControlLight;
		this._agYF6ii02oU5KICbi31ZCzXf25U.Location = new Point(26, 122);
		this._agYF6ii02oU5KICbi31ZCzXf25U.Name = "lblMinimumEnemyGroupSize";
		this._agYF6ii02oU5KICbi31ZCzXf25U.Size = new Size(175, 17);
		this._agYF6ii02oU5KICbi31ZCzXf25U.TabIndex = 27;
		this._agYF6ii02oU5KICbi31ZCzXf25U.Text = "Minimum Enemy Group Size:";
		this._GvDTOnQNOsGJ89PGbQmKVm4TY4f.AutoSize = true;
		this._GvDTOnQNOsGJ89PGbQmKVm4TY4f.BackColor = Color.FromArgb(74, 31, 32);
		this._GvDTOnQNOsGJ89PGbQmKVm4TY4f.Location = new Point(151, 149);
		this._GvDTOnQNOsGJ89PGbQmKVm4TY4f.Name = "chkAutoAbilityStrongestEnemy";
		this._GvDTOnQNOsGJ89PGbQmKVm4TY4f.Size = new Size(123, 21);
		this._GvDTOnQNOsGJ89PGbQmKVm4TY4f.TabIndex = 33;
		this._GvDTOnQNOsGJ89PGbQmKVm4TY4f.TabStop = true;
		this._GvDTOnQNOsGJ89PGbQmKVm4TY4f.Text = "Target Strongest";
		this._GvDTOnQNOsGJ89PGbQmKVm4TY4f.UseVisualStyleBackColor = false;
		this._JrQ0jvSnpu8tCPkHfWRan3nPstO.BackColor = Color.FromArgb(74, 31, 32);
		this._JrQ0jvSnpu8tCPkHfWRan3nPstO.Font = new Font("Segoe UI", 8.25f);
		this._JrQ0jvSnpu8tCPkHfWRan3nPstO.ForeColor = SystemColors.ControlLight;
		this._JrQ0jvSnpu8tCPkHfWRan3nPstO.Location = new Point(201, 121);
		NumericUpDown jrQ0jvSnpu8tCPkHfWRan3nPstO = this._JrQ0jvSnpu8tCPkHfWRan3nPstO;
		int[] array17 = new int[4];
		array17[0] = 1;
		jrQ0jvSnpu8tCPkHfWRan3nPstO.Minimum = new decimal(array17);
		this._JrQ0jvSnpu8tCPkHfWRan3nPstO.Name = "numAutoAbilityMinimumGroupSizeThreshold";
		this._JrQ0jvSnpu8tCPkHfWRan3nPstO.Size = new Size(50, 22);
		this._JrQ0jvSnpu8tCPkHfWRan3nPstO.TabIndex = 26;
		NumericUpDown jrQ0jvSnpu8tCPkHfWRan3nPstO2 = this._JrQ0jvSnpu8tCPkHfWRan3nPstO;
		int[] array18 = new int[4];
		array18[0] = 1;
		jrQ0jvSnpu8tCPkHfWRan3nPstO2.Value = new decimal(array18);
		this._eK6G41SpwvAkaNcHSQtBN8YOH3g.AutoSize = true;
		this._eK6G41SpwvAkaNcHSQtBN8YOH3g.BackColor = Color.FromArgb(74, 31, 32);
		this._eK6G41SpwvAkaNcHSQtBN8YOH3g.Location = new Point(30, 149);
		this._eK6G41SpwvAkaNcHSQtBN8YOH3g.Name = "chkAutoAbilityWeakestEnemy";
		this._eK6G41SpwvAkaNcHSQtBN8YOH3g.Size = new Size(115, 21);
		this._eK6G41SpwvAkaNcHSQtBN8YOH3g.TabIndex = 32;
		this._eK6G41SpwvAkaNcHSQtBN8YOH3g.TabStop = true;
		this._eK6G41SpwvAkaNcHSQtBN8YOH3g.Text = "Target Weakest";
		this._eK6G41SpwvAkaNcHSQtBN8YOH3g.UseVisualStyleBackColor = false;
		this._Pqw9zi4w7GqQwYQK41QnTuuWuPB.AutoSize = true;
		this._Pqw9zi4w7GqQwYQK41QnTuuWuPB.BackColor = Color.FromArgb(74, 31, 32);
		this._Pqw9zi4w7GqQwYQK41QnTuuWuPB.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this._Pqw9zi4w7GqQwYQK41QnTuuWuPB.ForeColor = SystemColors.ControlLight;
		this._Pqw9zi4w7GqQwYQK41QnTuuWuPB.Location = new Point(277, 122);
		this._Pqw9zi4w7GqQwYQK41QnTuuWuPB.Name = "lblMinimumEnemyGroupSizeAfter";
		this._Pqw9zi4w7GqQwYQK41QnTuuWuPB.Size = new Size(158, 17);
		this._Pqw9zi4w7GqQwYQK41QnTuuWuPB.TabIndex = 31;
		this._Pqw9zi4w7GqQwYQK41QnTuuWuPB.Text = "(for abilities that multi-hit)";
		this._avTCWVvfyh5Z2ZcOPgrfahJGerT.AutoSize = true;
		this._avTCWVvfyh5Z2ZcOPgrfahJGerT.BackColor = Color.FromArgb(74, 31, 32);
		this._avTCWVvfyh5Z2ZcOPgrfahJGerT.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this._avTCWVvfyh5Z2ZcOPgrfahJGerT.ForeColor = SystemColors.ControlLight;
		this._avTCWVvfyh5Z2ZcOPgrfahJGerT.Location = new Point(254, 35);
		this._avTCWVvfyh5Z2ZcOPgrfahJGerT.Name = "lblMinimumMPLeftAfter";
		this._avTCWVvfyh5Z2ZcOPgrfahJGerT.Size = new Size(117, 17);
		this._avTCWVvfyh5Z2ZcOPgrfahJGerT.TabIndex = 30;
		this._avTCWVvfyh5Z2ZcOPgrfahJGerT.Text = "%  (for all abilities)";
		this._9QHYF9EAZe2ak9U6KEkgpsJl1u6.BackColor = Color.FromArgb(74, 31, 32);
		this._9QHYF9EAZe2ak9U6KEkgpsJl1u6.Font = new Font("Segoe UI", 8.25f);
		this._9QHYF9EAZe2ak9U6KEkgpsJl1u6.ForeColor = SystemColors.ControlLight;
		NumericUpDown 9QHYF9EAZe2ak9U6KEkgpsJl1u = this._9QHYF9EAZe2ak9U6KEkgpsJl1u6;
		int[] array19 = new int[4];
		array19[0] = 5;
		9QHYF9EAZe2ak9U6KEkgpsJl1u.Increment = new decimal(array19);
		this._9QHYF9EAZe2ak9U6KEkgpsJl1u6.Location = new Point(201, 34);
		this._9QHYF9EAZe2ak9U6KEkgpsJl1u6.Name = "numAutoAbilityMinimumManaLeftThreshold";
		this._9QHYF9EAZe2ak9U6KEkgpsJl1u6.Size = new Size(50, 22);
		this._9QHYF9EAZe2ak9U6KEkgpsJl1u6.TabIndex = 28;
		this._ysfSIj72X08AFWJAyx7j0yhALnK.AutoSize = true;
		this._ysfSIj72X08AFWJAyx7j0yhALnK.BackColor = Color.FromArgb(74, 31, 32);
		this._ysfSIj72X08AFWJAyx7j0yhALnK.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this._ysfSIj72X08AFWJAyx7j0yhALnK.ForeColor = SystemColors.ControlLight;
		this._ysfSIj72X08AFWJAyx7j0yhALnK.Location = new Point(27, 35);
		this._ysfSIj72X08AFWJAyx7j0yhALnK.Name = "lblMinimumMPLeft";
		this._ysfSIj72X08AFWJAyx7j0yhALnK.Size = new Size(113, 17);
		this._ysfSIj72X08AFWJAyx7j0yhALnK.TabIndex = 29;
		this._ysfSIj72X08AFWJAyx7j0yhALnK.Text = "Minimum MP Left:";
		this._FIIdC84o3TKCFUXg0FpaRpwDHmHA.AutoSize = true;
		this._FIIdC84o3TKCFUXg0FpaRpwDHmHA.BackColor = Color.FromArgb(74, 31, 32);
		this._FIIdC84o3TKCFUXg0FpaRpwDHmHA.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this._FIIdC84o3TKCFUXg0FpaRpwDHmHA.ForeColor = SystemColors.ControlLight;
		this._FIIdC84o3TKCFUXg0FpaRpwDHmHA.Location = new Point(254, 63);
		this._FIIdC84o3TKCFUXg0FpaRpwDHmHA.Name = "lblMinimumEnemyHPAfter";
		this._FIIdC84o3TKCFUXg0FpaRpwDHmHA.Size = new Size(217, 17);
		this._FIIdC84o3TKCFUXg0FpaRpwDHmHA.TabIndex = 24;
		this._FIIdC84o3TKCFUXg0FpaRpwDHmHA.Text = "%  (for abilities that target enemies)";
		this._c5laqQAVlFJapJyeOL4JaLeJfbf.BackColor = Color.FromArgb(74, 31, 32);
		this._c5laqQAVlFJapJyeOL4JaLeJfbf.Font = new Font("Segoe UI", 8.25f);
		this._c5laqQAVlFJapJyeOL4JaLeJfbf.ForeColor = SystemColors.ControlLight;
		NumericUpDown c5laqQAVlFJapJyeOL4JaLeJfbf = this._c5laqQAVlFJapJyeOL4JaLeJfbf;
		int[] array20 = new int[4];
		array20[0] = 5;
		c5laqQAVlFJapJyeOL4JaLeJfbf.Increment = new decimal(array20);
		this._c5laqQAVlFJapJyeOL4JaLeJfbf.Location = new Point(201, 62);
		this._c5laqQAVlFJapJyeOL4JaLeJfbf.Name = "numAutoAbilityMinimumEnemyHealthThreshold";
		this._c5laqQAVlFJapJyeOL4JaLeJfbf.Size = new Size(50, 22);
		this._c5laqQAVlFJapJyeOL4JaLeJfbf.TabIndex = 20;
		this._oG0D38K3dGqrjszXNGDhJgLg3YO.AutoSize = true;
		this._oG0D38K3dGqrjszXNGDhJgLg3YO.BackColor = Color.FromArgb(74, 31, 32);
		this._oG0D38K3dGqrjszXNGDhJgLg3YO.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this._oG0D38K3dGqrjszXNGDhJgLg3YO.ForeColor = SystemColors.ControlLight;
		this._oG0D38K3dGqrjszXNGDhJgLg3YO.Location = new Point(27, 63);
		this._oG0D38K3dGqrjszXNGDhJgLg3YO.Name = "lblMinimumEnemyHP";
		this._oG0D38K3dGqrjszXNGDhJgLg3YO.Size = new Size(127, 17);
		this._oG0D38K3dGqrjszXNGDhJgLg3YO.TabIndex = 21;
		this._oG0D38K3dGqrjszXNGDhJgLg3YO.Text = "Minimum Enemy HP:";
		this._Mixf8sI0kZDJCwoFg3WpNQN0h1H.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
		this._Mixf8sI0kZDJCwoFg3WpNQN0h1H.BackColor = Color.FromArgb(74, 31, 32);
		this._Mixf8sI0kZDJCwoFg3WpNQN0h1H.BorderStyle = BorderStyle.FixedSingle;
		this._Mixf8sI0kZDJCwoFg3WpNQN0h1H.Location = new Point(8, 28);
		this._Mixf8sI0kZDJCwoFg3WpNQN0h1H.Name = "sepAutoAbility";
		this._Mixf8sI0kZDJCwoFg3WpNQN0h1H.Size = new Size(485, 1);
		this._Mixf8sI0kZDJCwoFg3WpNQN0h1H.TabIndex = 5;
		this._ftgy68Qbf8ty1dzazTutC4fGxcX.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
		this._ftgy68Qbf8ty1dzazTutC4fGxcX.Font = new Font("Segoe UI", 6.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this._ftgy68Qbf8ty1dzazTutC4fGxcX.ForeColor = Color.Black;
		this._ftgy68Qbf8ty1dzazTutC4fGxcX.Location = new Point(471, 5);
		this._ftgy68Qbf8ty1dzazTutC4fGxcX.Name = "btnAutoAbilityInfo";
		this._ftgy68Qbf8ty1dzazTutC4fGxcX.Size = new Size(23, 20);
		this._ftgy68Qbf8ty1dzazTutC4fGxcX.TabIndex = 4;
		this._ftgy68Qbf8ty1dzazTutC4fGxcX.Text = "?";
		this._ftgy68Qbf8ty1dzazTutC4fGxcX.UseVisualStyleBackColor = true;
		this._ftgy68Qbf8ty1dzazTutC4fGxcX.Click += this._3eFrIdlRtQNYPnnLHtJlTKFNlTE;
		this._PurNnAIDE44j6AvnAPVuLPTqjSk.AutoSize = true;
		this._PurNnAIDE44j6AvnAPVuLPTqjSk.BackColor = Color.FromArgb(74, 31, 32);
		this._PurNnAIDE44j6AvnAPVuLPTqjSk.Font = new Font("Segoe UI", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this._PurNnAIDE44j6AvnAPVuLPTqjSk.ForeColor = SystemColors.ButtonFace;
		this._PurNnAIDE44j6AvnAPVuLPTqjSk.Location = new Point(8, 3);
		this._PurNnAIDE44j6AvnAPVuLPTqjSk.Name = "chkAutoAbility";
		this._PurNnAIDE44j6AvnAPVuLPTqjSk.Size = new Size(121, 25);
		this._PurNnAIDE44j6AvnAPVuLPTqjSk.TabIndex = 1;
		this._PurNnAIDE44j6AvnAPVuLPTqjSk.Text = "Auto Ability";
		this._PurNnAIDE44j6AvnAPVuLPTqjSk.UseVisualStyleBackColor = false;
		this._OFGERDl1EqTyy8cSjx875xroSBC.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
		this._OFGERDl1EqTyy8cSjx875xroSBC.BackColor = Color.FromArgb(44, 41, 62);
		this._OFGERDl1EqTyy8cSjx875xroSBC.BorderStyle = BorderStyle.FixedSingle;
		this._OFGERDl1EqTyy8cSjx875xroSBC.Controls.Add(this._GrG3a2HOSzWBO9DtGXrGPYzuprB);
		this._OFGERDl1EqTyy8cSjx875xroSBC.Controls.Add(this._UQXpP3YbtvnD1q2FOAN2qS2ohxW);
		this._OFGERDl1EqTyy8cSjx875xroSBC.Controls.Add(this._qjPTNygvB4B3vDNLDEu8h56XDJh);
		this._OFGERDl1EqTyy8cSjx875xroSBC.Controls.Add(this._D56B164kgvuhufuOvewvaVBYdYh);
		this._OFGERDl1EqTyy8cSjx875xroSBC.Controls.Add(this._892HB1ye673FqC2JE66HvKLszQz);
		this._OFGERDl1EqTyy8cSjx875xroSBC.Controls.Add(this._Do5CIYGgaFClsbuysngi6YRJSNq);
		this._OFGERDl1EqTyy8cSjx875xroSBC.Controls.Add(this._yQ1kSD7a2a3aKSDQCfysAKHn0Ue);
		this._OFGERDl1EqTyy8cSjx875xroSBC.Controls.Add(this._IiKbopXhVBOSMxagiaQAt5bahuxA);
		this._OFGERDl1EqTyy8cSjx875xroSBC.Controls.Add(this._62VSbpDeRcayFyvfIb9IE4vREup);
		this._OFGERDl1EqTyy8cSjx875xroSBC.Controls.Add(this._0HGnMal1Vd4x3tahp3yMGdeIssG);
		this._OFGERDl1EqTyy8cSjx875xroSBC.Controls.Add(this._lWjWhmJoXyiE8WhbXSrYAge1vjC);
		this._OFGERDl1EqTyy8cSjx875xroSBC.Location = new Point(6, 6);
		this._OFGERDl1EqTyy8cSjx875xroSBC.Name = "pnlAutoNexus";
		this._OFGERDl1EqTyy8cSjx875xroSBC.Size = new Size(502, 88);
		this._OFGERDl1EqTyy8cSjx875xroSBC.TabIndex = 20;
		this._UQXpP3YbtvnD1q2FOAN2qS2ohxW.AutoSize = true;
		this._UQXpP3YbtvnD1q2FOAN2qS2ohxW.BackColor = Color.FromArgb(44, 41, 62);
		this._UQXpP3YbtvnD1q2FOAN2qS2ohxW.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this._UQXpP3YbtvnD1q2FOAN2qS2ohxW.ForeColor = SystemColors.ControlLight;
		this._UQXpP3YbtvnD1q2FOAN2qS2ohxW.Location = new Point(175, 62);
		this._UQXpP3YbtvnD1q2FOAN2qS2ohxW.Name = "label3";
		this._UQXpP3YbtvnD1q2FOAN2qS2ohxW.Size = new Size(60, 17);
		this._UQXpP3YbtvnD1q2FOAN2qS2ohxW.TabIndex = 18;
		this._UQXpP3YbtvnD1q2FOAN2qS2ohxW.Text = "% Health";
		this._qjPTNygvB4B3vDNLDEu8h56XDJh.BackColor = Color.FromArgb(44, 41, 62);
		this._qjPTNygvB4B3vDNLDEu8h56XDJh.Font = new Font("Segoe UI", 8.25f);
		this._qjPTNygvB4B3vDNLDEu8h56XDJh.ForeColor = SystemColors.ControlLight;
		NumericUpDown qjPTNygvB4B3vDNLDEu8h56XDJh = this._qjPTNygvB4B3vDNLDEu8h56XDJh;
		int[] array21 = new int[4];
		array21[0] = 5;
		qjPTNygvB4B3vDNLDEu8h56XDJh.Increment = new decimal(array21);
		this._qjPTNygvB4B3vDNLDEu8h56XDJh.Location = new Point(122, 61);
		NumericUpDown qjPTNygvB4B3vDNLDEu8h56XDJh2 = this._qjPTNygvB4B3vDNLDEu8h56XDJh;
		int[] array22 = new int[4];
		array22[0] = 5;
		qjPTNygvB4B3vDNLDEu8h56XDJh2.Minimum = new decimal(array22);
		this._qjPTNygvB4B3vDNLDEu8h56XDJh.Name = "numAutoNexusDrinkThreshold";
		this._qjPTNygvB4B3vDNLDEu8h56XDJh.Size = new Size(50, 22);
		this._qjPTNygvB4B3vDNLDEu8h56XDJh.TabIndex = 16;
		NumericUpDown qjPTNygvB4B3vDNLDEu8h56XDJh3 = this._qjPTNygvB4B3vDNLDEu8h56XDJh;
		int[] array23 = new int[4];
		array23[0] = 20;
		qjPTNygvB4B3vDNLDEu8h56XDJh3.Value = new decimal(array23);
		this._D56B164kgvuhufuOvewvaVBYdYh.AutoSize = true;
		this._D56B164kgvuhufuOvewvaVBYdYh.BackColor = Color.FromArgb(44, 41, 62);
		this._D56B164kgvuhufuOvewvaVBYdYh.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this._D56B164kgvuhufuOvewvaVBYdYh.ForeColor = SystemColors.ControlLight;
		this._D56B164kgvuhufuOvewvaVBYdYh.Location = new Point(33, 62);
		this._D56B164kgvuhufuOvewvaVBYdYh.Name = "lblAutoDrink";
		this._D56B164kgvuhufuOvewvaVBYdYh.Size = new Size(87, 17);
		this._D56B164kgvuhufuOvewvaVBYdYh.TabIndex = 17;
		this._D56B164kgvuhufuOvewvaVBYdYh.Text = "Auto Drink at:";
		this._892HB1ye673FqC2JE66HvKLszQz.AutoSize = true;
		this._892HB1ye673FqC2JE66HvKLszQz.BackColor = Color.FromArgb(44, 41, 62);
		this._892HB1ye673FqC2JE66HvKLszQz.Location = new Point(257, 35);
		this._892HB1ye673FqC2JE66HvKLszQz.Name = "chkAutoNexusShowInformation";
		this._892HB1ye673FqC2JE66HvKLszQz.Size = new Size(178, 21);
		this._892HB1ye673FqC2JE66HvKLszQz.TabIndex = 14;
		this._892HB1ye673FqC2JE66HvKLszQz.Text = "Show reason for nexusing";
		this._892HB1ye673FqC2JE66HvKLszQz.UseVisualStyleBackColor = false;
		this._Do5CIYGgaFClsbuysngi6YRJSNq.AutoSize = true;
		this._Do5CIYGgaFClsbuysngi6YRJSNq.BackColor = Color.FromArgb(44, 41, 62);
		this._Do5CIYGgaFClsbuysngi6YRJSNq.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this._Do5CIYGgaFClsbuysngi6YRJSNq.ForeColor = SystemColors.ControlLight;
		this._Do5CIYGgaFClsbuysngi6YRJSNq.Location = new Point(175, 35);
		this._Do5CIYGgaFClsbuysngi6YRJSNq.Name = "lblAutoNexusAfter";
		this._Do5CIYGgaFClsbuysngi6YRJSNq.Size = new Size(60, 17);
		this._Do5CIYGgaFClsbuysngi6YRJSNq.TabIndex = 5;
		this._Do5CIYGgaFClsbuysngi6YRJSNq.Text = "% Health";
		this._yQ1kSD7a2a3aKSDQCfysAKHn0Ue.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
		this._yQ1kSD7a2a3aKSDQCfysAKHn0Ue.BackColor = Color.FromArgb(44, 41, 62);
		this._yQ1kSD7a2a3aKSDQCfysAKHn0Ue.BorderStyle = BorderStyle.FixedSingle;
		this._yQ1kSD7a2a3aKSDQCfysAKHn0Ue.Location = new Point(8, 28);
		this._yQ1kSD7a2a3aKSDQCfysAKHn0Ue.Name = "sepAutoNexus";
		this._yQ1kSD7a2a3aKSDQCfysAKHn0Ue.Size = new Size(485, 1);
		this._yQ1kSD7a2a3aKSDQCfysAKHn0Ue.TabIndex = 4;
		this._IiKbopXhVBOSMxagiaQAt5bahuxA.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
		this._IiKbopXhVBOSMxagiaQAt5bahuxA.Font = new Font("Segoe UI", 6.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this._IiKbopXhVBOSMxagiaQAt5bahuxA.ForeColor = Color.Black;
		this._IiKbopXhVBOSMxagiaQAt5bahuxA.Location = new Point(471, 5);
		this._IiKbopXhVBOSMxagiaQAt5bahuxA.Name = "btnAutoNexusInfo";
		this._IiKbopXhVBOSMxagiaQAt5bahuxA.Size = new Size(23, 20);
		this._IiKbopXhVBOSMxagiaQAt5bahuxA.TabIndex = 3;
		this._IiKbopXhVBOSMxagiaQAt5bahuxA.Text = "?";
		this._IiKbopXhVBOSMxagiaQAt5bahuxA.UseVisualStyleBackColor = true;
		this._IiKbopXhVBOSMxagiaQAt5bahuxA.Click += this._jZxPoYDfcs8ZdPNQyM3MgL8VNkh;
		this._62VSbpDeRcayFyvfIb9IE4vREup.BackColor = Color.FromArgb(44, 41, 62);
		this._62VSbpDeRcayFyvfIb9IE4vREup.Font = new Font("Segoe UI", 8.25f);
		this._62VSbpDeRcayFyvfIb9IE4vREup.ForeColor = SystemColors.ControlLight;
		NumericUpDown 62VSbpDeRcayFyvfIb9IE4vREup = this._62VSbpDeRcayFyvfIb9IE4vREup;
		int[] array24 = new int[4];
		array24[0] = 5;
		62VSbpDeRcayFyvfIb9IE4vREup.Increment = new decimal(array24);
		this._62VSbpDeRcayFyvfIb9IE4vREup.Location = new Point(122, 34);
		NumericUpDown 62VSbpDeRcayFyvfIb9IE4vREup2 = this._62VSbpDeRcayFyvfIb9IE4vREup;
		int[] array25 = new int[4];
		array25[0] = 5;
		62VSbpDeRcayFyvfIb9IE4vREup2.Minimum = new decimal(array25);
		this._62VSbpDeRcayFyvfIb9IE4vREup.Name = "numAutoNexusHealthThreshold";
		this._62VSbpDeRcayFyvfIb9IE4vREup.Size = new Size(50, 22);
		this._62VSbpDeRcayFyvfIb9IE4vREup.TabIndex = 1;
		NumericUpDown 62VSbpDeRcayFyvfIb9IE4vREup3 = this._62VSbpDeRcayFyvfIb9IE4vREup;
		int[] array26 = new int[4];
		array26[0] = 5;
		62VSbpDeRcayFyvfIb9IE4vREup3.Value = new decimal(array26);
		this._0HGnMal1Vd4x3tahp3yMGdeIssG.AutoSize = true;
		this._0HGnMal1Vd4x3tahp3yMGdeIssG.BackColor = Color.FromArgb(44, 41, 62);
		this._0HGnMal1Vd4x3tahp3yMGdeIssG.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this._0HGnMal1Vd4x3tahp3yMGdeIssG.ForeColor = SystemColors.ControlLight;
		this._0HGnMal1Vd4x3tahp3yMGdeIssG.Location = new Point(27, 35);
		this._0HGnMal1Vd4x3tahp3yMGdeIssG.Name = "lblAutoNexusPercentage";
		this._0HGnMal1Vd4x3tahp3yMGdeIssG.Size = new Size(93, 17);
		this._0HGnMal1Vd4x3tahp3yMGdeIssG.TabIndex = 2;
		this._0HGnMal1Vd4x3tahp3yMGdeIssG.Text = "Auto Nexus at:";
		this._lWjWhmJoXyiE8WhbXSrYAge1vjC.AutoSize = true;
		this._lWjWhmJoXyiE8WhbXSrYAge1vjC.BackColor = Color.FromArgb(44, 41, 62);
		this._lWjWhmJoXyiE8WhbXSrYAge1vjC.Font = new Font("Segoe UI", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this._lWjWhmJoXyiE8WhbXSrYAge1vjC.ForeColor = SystemColors.ButtonFace;
		this._lWjWhmJoXyiE8WhbXSrYAge1vjC.Location = new Point(8, 3);
		this._lWjWhmJoXyiE8WhbXSrYAge1vjC.Name = "chkAutoNexus";
		this._lWjWhmJoXyiE8WhbXSrYAge1vjC.Size = new Size(149, 25);
		this._lWjWhmJoXyiE8WhbXSrYAge1vjC.TabIndex = 0;
		this._lWjWhmJoXyiE8WhbXSrYAge1vjC.Text = "059 Auto Nexus";
		this._lWjWhmJoXyiE8WhbXSrYAge1vjC.UseVisualStyleBackColor = false;
		this._YnUaeaUO3v7j9nMGyrg8xLCRvbaA.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
		this._YnUaeaUO3v7j9nMGyrg8xLCRvbaA.BackColor = Color.FromArgb(73, 35, 70);
		this._YnUaeaUO3v7j9nMGyrg8xLCRvbaA.BorderStyle = BorderStyle.FixedSingle;
		this._YnUaeaUO3v7j9nMGyrg8xLCRvbaA.Controls.Add(this._rkCOyhCrmFgszG5N6BFXtycsLJC);
		this._YnUaeaUO3v7j9nMGyrg8xLCRvbaA.Controls.Add(this._6hGbopNqB96fOCghBWmy3wUmFAZ);
		this._YnUaeaUO3v7j9nMGyrg8xLCRvbaA.Controls.Add(this._eTdfMqaoeCvX9U8m9jfRYiV8pKE);
		this._YnUaeaUO3v7j9nMGyrg8xLCRvbaA.Controls.Add(this._PNCuD1l2tNobM4F9uXZCce0XGip);
		this._YnUaeaUO3v7j9nMGyrg8xLCRvbaA.Controls.Add(this._CFHhsixORk1ubYPKegZSTI4aJ0k);
		this._YnUaeaUO3v7j9nMGyrg8xLCRvbaA.Controls.Add(this._RUh9TbFjqdzx0jETEYjgjtUGoTg);
		this._YnUaeaUO3v7j9nMGyrg8xLCRvbaA.Location = new Point(6, 880);
		this._YnUaeaUO3v7j9nMGyrg8xLCRvbaA.Name = "pnlConnection";
		this._YnUaeaUO3v7j9nMGyrg8xLCRvbaA.Size = new Size(502, 117);
		this._YnUaeaUO3v7j9nMGyrg8xLCRvbaA.TabIndex = 27;
		this._rkCOyhCrmFgszG5N6BFXtycsLJC.AutoSize = true;
		this._rkCOyhCrmFgszG5N6BFXtycsLJC.BackColor = Color.FromArgb(73, 35, 70);
		this._rkCOyhCrmFgszG5N6BFXtycsLJC.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this._rkCOyhCrmFgszG5N6BFXtycsLJC.ForeColor = SystemColors.ControlLight;
		this._rkCOyhCrmFgszG5N6BFXtycsLJC.Location = new Point(27, 87);
		this._rkCOyhCrmFgszG5N6BFXtycsLJC.Name = "lblServerWarning";
		this._rkCOyhCrmFgszG5N6BFXtycsLJC.Size = new Size(435, 17);
		this._rkCOyhCrmFgszG5N6BFXtycsLJC.TabIndex = 32;
		this._rkCOyhCrmFgszG5N6BFXtycsLJC.Text = "Make sure you are connected to Proxy Server in-game for hacks to work!";
		this._6hGbopNqB96fOCghBWmy3wUmFAZ.AutoSize = true;
		this._6hGbopNqB96fOCghBWmy3wUmFAZ.BackColor = Color.FromArgb(73, 35, 70);
		this._6hGbopNqB96fOCghBWmy3wUmFAZ.Location = new Point(30, 60);
		this._6hGbopNqB96fOCghBWmy3wUmFAZ.Name = "chkEnableGotoCommand";
		this._6hGbopNqB96fOCghBWmy3wUmFAZ.Size = new Size(290, 21);
		this._6hGbopNqB96fOCghBWmy3wUmFAZ.TabIndex = 31;
		this._6hGbopNqB96fOCghBWmy3wUmFAZ.Text = "/goto <ip> : Quick connect server IP address";
		this._6hGbopNqB96fOCghBWmy3wUmFAZ.UseVisualStyleBackColor = false;
		this._eTdfMqaoeCvX9U8m9jfRYiV8pKE.AutoSize = true;
		this._eTdfMqaoeCvX9U8m9jfRYiV8pKE.BackColor = Color.FromArgb(73, 35, 70);
		this._eTdfMqaoeCvX9U8m9jfRYiV8pKE.Location = new Point(30, 33);
		this._eTdfMqaoeCvX9U8m9jfRYiV8pKE.Name = "chkEnableConnectCommand";
		this._eTdfMqaoeCvX9U8m9jfRYiV8pKE.Size = new Size(315, 21);
		this._eTdfMqaoeCvX9U8m9jfRYiV8pKE.TabIndex = 28;
		this._eTdfMqaoeCvX9U8m9jfRYiV8pKE.Text = "/con <server> : Quick connect to specified server";
		this._eTdfMqaoeCvX9U8m9jfRYiV8pKE.UseVisualStyleBackColor = false;
		this._PNCuD1l2tNobM4F9uXZCce0XGip.AutoSize = true;
		this._PNCuD1l2tNobM4F9uXZCce0XGip.Font = new Font("Segoe UI", 12f, FontStyle.Bold);
		this._PNCuD1l2tNobM4F9uXZCce0XGip.Location = new Point(8, 3);
		this._PNCuD1l2tNobM4F9uXZCce0XGip.Name = "lblConnection";
		this._PNCuD1l2tNobM4F9uXZCce0XGip.Size = new Size(98, 21);
		this._PNCuD1l2tNobM4F9uXZCce0XGip.TabIndex = 15;
		this._PNCuD1l2tNobM4F9uXZCce0XGip.Text = "Connection";
		this._CFHhsixORk1ubYPKegZSTI4aJ0k.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
		this._CFHhsixORk1ubYPKegZSTI4aJ0k.BackColor = Color.FromArgb(44, 51, 42);
		this._CFHhsixORk1ubYPKegZSTI4aJ0k.BorderStyle = BorderStyle.FixedSingle;
		this._CFHhsixORk1ubYPKegZSTI4aJ0k.Location = new Point(8, 28);
		this._CFHhsixORk1ubYPKegZSTI4aJ0k.Name = "sepConnection";
		this._CFHhsixORk1ubYPKegZSTI4aJ0k.Size = new Size(485, 1);
		this._CFHhsixORk1ubYPKegZSTI4aJ0k.TabIndex = 6;
		this._RUh9TbFjqdzx0jETEYjgjtUGoTg.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
		this._RUh9TbFjqdzx0jETEYjgjtUGoTg.Font = new Font("Segoe UI", 6.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this._RUh9TbFjqdzx0jETEYjgjtUGoTg.ForeColor = Color.Black;
		this._RUh9TbFjqdzx0jETEYjgjtUGoTg.Location = new Point(471, 5);
		this._RUh9TbFjqdzx0jETEYjgjtUGoTg.Name = "btnConnectionInfo";
		this._RUh9TbFjqdzx0jETEYjgjtUGoTg.Size = new Size(23, 20);
		this._RUh9TbFjqdzx0jETEYjgjtUGoTg.TabIndex = 5;
		this._RUh9TbFjqdzx0jETEYjgjtUGoTg.Text = "?";
		this._RUh9TbFjqdzx0jETEYjgjtUGoTg.UseVisualStyleBackColor = true;
		this._RUh9TbFjqdzx0jETEYjgjtUGoTg.Click += this._4IYnT6mUBNH2AdemxmfDvOMcU8j;
		this._eNEP9aTBIxptpE2leJOgLDYn7ds.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
		this._eNEP9aTBIxptpE2leJOgLDYn7ds.BackColor = Color.FromArgb(100, 40, 30);
		this._eNEP9aTBIxptpE2leJOgLDYn7ds.BorderStyle = BorderStyle.FixedSingle;
		this._eNEP9aTBIxptpE2leJOgLDYn7ds.Controls.Add(this._Peynkzk3GJMrKqqla5AmSBsGPNd);
		this._eNEP9aTBIxptpE2leJOgLDYn7ds.Controls.Add(this._LeBw0Xu8GHUkpehWS0c8qyHakdb);
		this._eNEP9aTBIxptpE2leJOgLDYn7ds.Controls.Add(this._IaPeVUijdNZdd89OGoTZBAC54mX);
		this._eNEP9aTBIxptpE2leJOgLDYn7ds.Controls.Add(this._Wm4Y3d9Dbxyb3dFlDZ67hnzKobdA);
		this._eNEP9aTBIxptpE2leJOgLDYn7ds.Controls.Add(this._WhJddPSH9Ds2gCiSO7YBHdUQ8r5);
		this._eNEP9aTBIxptpE2leJOgLDYn7ds.Controls.Add(this._VnTsmnYXLRGDwkJ8FC3nU4bIP9B);
		this._eNEP9aTBIxptpE2leJOgLDYn7ds.Controls.Add(this._ZkdDuSvdPQwDoDAG5n9bgFAVmvpb);
		this._eNEP9aTBIxptpE2leJOgLDYn7ds.Controls.Add(this._ArSzgygWkzBHHPBRzNRWIRx7ieg);
		this._eNEP9aTBIxptpE2leJOgLDYn7ds.Controls.Add(this._CcJWy1gRUni2ZZkIO4OKPTcaWGH);
		this._eNEP9aTBIxptpE2leJOgLDYn7ds.Controls.Add(this._2adxfsCrw3qjBhHJrJ5dDXAABnX);
		this._eNEP9aTBIxptpE2leJOgLDYn7ds.Controls.Add(this._9tsk3hiE5XmV8RZQ9f4Nf6XO8gd);
		this._eNEP9aTBIxptpE2leJOgLDYn7ds.Location = new Point(6, 1490);
		this._eNEP9aTBIxptpE2leJOgLDYn7ds.Name = "pnlFame";
		this._eNEP9aTBIxptpE2leJOgLDYn7ds.Size = new Size(502, 224);
		this._eNEP9aTBIxptpE2leJOgLDYn7ds.TabIndex = 28;
		this._Peynkzk3GJMrKqqla5AmSBsGPNd.AutoSize = true;
		this._Peynkzk3GJMrKqqla5AmSBsGPNd.Location = new Point(30, 195);
		this._Peynkzk3GJMrKqqla5AmSBsGPNd.Name = "chkFameAccuracyFarm";
		this._Peynkzk3GJMrKqqla5AmSBsGPNd.Size = new Size(231, 21);
		this._Peynkzk3GJMrKqqla5AmSBsGPNd.TabIndex = 36;
		this._Peynkzk3GJMrKqqla5AmSBsGPNd.Text = "Accuracy Farm (Unkillable Enemies)";
		this._Peynkzk3GJMrKqqla5AmSBsGPNd.UseVisualStyleBackColor = true;
		this._LeBw0Xu8GHUkpehWS0c8qyHakdb.AutoSize = true;
		this._LeBw0Xu8GHUkpehWS0c8qyHakdb.BackColor = Color.Transparent;
		this._LeBw0Xu8GHUkpehWS0c8qyHakdb.LinkColor = Color.Gold;
		this._LeBw0Xu8GHUkpehWS0c8qyHakdb.Location = new Point(216, 34);
		this._LeBw0Xu8GHUkpehWS0c8qyHakdb.Name = "btnEditIgnoredEnemyList";
		this._LeBw0Xu8GHUkpehWS0c8qyHakdb.Size = new Size(186, 17);
		this._LeBw0Xu8GHUkpehWS0c8qyHakdb.TabIndex = 35;
		this._LeBw0Xu8GHUkpehWS0c8qyHakdb.TabStop = true;
		this._LeBw0Xu8GHUkpehWS0c8qyHakdb.Text = "Add/Remove Ignored Enemies";
		this._LeBw0Xu8GHUkpehWS0c8qyHakdb.LinkClicked += this._va7kpTLeKCdVnAKkLLUQgWAK1jH;
		this._IaPeVUijdNZdd89OGoTZBAC54mX.AutoSize = true;
		this._IaPeVUijdNZdd89OGoTZBAC54mX.BackColor = Color.FromArgb(100, 40, 30);
		this._IaPeVUijdNZdd89OGoTZBAC54mX.Location = new Point(30, 168);
		this._IaPeVUijdNZdd89OGoTZBAC54mX.Name = "chkFameBlockDrinking";
		this._IaPeVUijdNZdd89OGoTZBAC54mX.Size = new Size(109, 21);
		this._IaPeVUijdNZdd89OGoTZBAC54mX.TabIndex = 34;
		this._IaPeVUijdNZdd89OGoTZBAC54mX.Text = "Block Drinking";
		this._IaPeVUijdNZdd89OGoTZBAC54mX.UseVisualStyleBackColor = false;
		this._Wm4Y3d9Dbxyb3dFlDZ67hnzKobdA.AutoSize = true;
		this._Wm4Y3d9Dbxyb3dFlDZ67hnzKobdA.BackColor = Color.FromArgb(100, 40, 30);
		this._Wm4Y3d9Dbxyb3dFlDZ67hnzKobdA.Location = new Point(30, 141);
		this._Wm4Y3d9Dbxyb3dFlDZ67hnzKobdA.Name = "chkFameBlockAbilities";
		this._Wm4Y3d9Dbxyb3dFlDZ67hnzKobdA.Size = new Size(106, 21);
		this._Wm4Y3d9Dbxyb3dFlDZ67hnzKobdA.TabIndex = 33;
		this._Wm4Y3d9Dbxyb3dFlDZ67hnzKobdA.Text = "Block Abilities";
		this._Wm4Y3d9Dbxyb3dFlDZ67hnzKobdA.UseVisualStyleBackColor = false;
		this._WhJddPSH9Ds2gCiSO7YBHdUQ8r5.AutoSize = true;
		this._WhJddPSH9Ds2gCiSO7YBHdUQ8r5.BackColor = Color.FromArgb(100, 40, 30);
		this._WhJddPSH9Ds2gCiSO7YBHdUQ8r5.Location = new Point(30, 114);
		this._WhJddPSH9Ds2gCiSO7YBHdUQ8r5.Name = "chkFameBlockTeleports";
		this._WhJddPSH9Ds2gCiSO7YBHdUQ8r5.Size = new Size(115, 21);
		this._WhJddPSH9Ds2gCiSO7YBHdUQ8r5.TabIndex = 32;
		this._WhJddPSH9Ds2gCiSO7YBHdUQ8r5.Text = "Block Teleports";
		this._WhJddPSH9Ds2gCiSO7YBHdUQ8r5.UseVisualStyleBackColor = false;
		this._VnTsmnYXLRGDwkJ8FC3nU4bIP9B.AutoSize = true;
		this._VnTsmnYXLRGDwkJ8FC3nU4bIP9B.BackColor = Color.FromArgb(100, 40, 30);
		this._VnTsmnYXLRGDwkJ8FC3nU4bIP9B.Location = new Point(30, 87);
		this._VnTsmnYXLRGDwkJ8FC3nU4bIP9B.Name = "chkFameOnlyHitGods";
		this._VnTsmnYXLRGDwkJ8FC3nU4bIP9B.Size = new Size(108, 21);
		this._VnTsmnYXLRGDwkJ8FC3nU4bIP9B.TabIndex = 31;
		this._VnTsmnYXLRGDwkJ8FC3nU4bIP9B.Text = "Only Hit Gods";
		this._VnTsmnYXLRGDwkJ8FC3nU4bIP9B.UseVisualStyleBackColor = false;
		this._ZkdDuSvdPQwDoDAG5n9bgFAVmvpb.AutoSize = true;
		this._ZkdDuSvdPQwDoDAG5n9bgFAVmvpb.BackColor = Color.FromArgb(100, 40, 30);
		this._ZkdDuSvdPQwDoDAG5n9bgFAVmvpb.Location = new Point(30, 60);
		this._ZkdDuSvdPQwDoDAG5n9bgFAVmvpb.Name = "chkFameDontHitCubes";
		this._ZkdDuSvdPQwDoDAG5n9bgFAVmvpb.Size = new Size(118, 21);
		this._ZkdDuSvdPQwDoDAG5n9bgFAVmvpb.TabIndex = 30;
		this._ZkdDuSvdPQwDoDAG5n9bgFAVmvpb.Text = "Don't Hit Cubes";
		this._ZkdDuSvdPQwDoDAG5n9bgFAVmvpb.UseVisualStyleBackColor = false;
		this._ArSzgygWkzBHHPBRzNRWIRx7ieg.AutoSize = true;
		this._ArSzgygWkzBHHPBRzNRWIRx7ieg.BackColor = Color.FromArgb(100, 40, 30);
		this._ArSzgygWkzBHHPBRzNRWIRx7ieg.Location = new Point(30, 33);
		this._ArSzgygWkzBHHPBRzNRWIRx7ieg.Name = "chkDontHitIgnores";
		this._ArSzgygWkzBHHPBRzNRWIRx7ieg.Size = new Size(180, 21);
		this._ArSzgygWkzBHHPBRzNRWIRx7ieg.TabIndex = 14;
		this._ArSzgygWkzBHHPBRzNRWIRx7ieg.Text = "Don't Hit Ignored Enemies";
		this._ArSzgygWkzBHHPBRzNRWIRx7ieg.UseVisualStyleBackColor = false;
		this._CcJWy1gRUni2ZZkIO4OKPTcaWGH.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
		this._CcJWy1gRUni2ZZkIO4OKPTcaWGH.BackColor = Color.FromArgb(44, 51, 42);
		this._CcJWy1gRUni2ZZkIO4OKPTcaWGH.BorderStyle = BorderStyle.FixedSingle;
		this._CcJWy1gRUni2ZZkIO4OKPTcaWGH.Location = new Point(8, 28);
		this._CcJWy1gRUni2ZZkIO4OKPTcaWGH.Name = "sepFame";
		this._CcJWy1gRUni2ZZkIO4OKPTcaWGH.Size = new Size(485, 1);
		this._CcJWy1gRUni2ZZkIO4OKPTcaWGH.TabIndex = 6;
		this._2adxfsCrw3qjBhHJrJ5dDXAABnX.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
		this._2adxfsCrw3qjBhHJrJ5dDXAABnX.Font = new Font("Segoe UI", 6.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this._2adxfsCrw3qjBhHJrJ5dDXAABnX.ForeColor = Color.Black;
		this._2adxfsCrw3qjBhHJrJ5dDXAABnX.Location = new Point(471, 5);
		this._2adxfsCrw3qjBhHJrJ5dDXAABnX.Name = "btnFameToolsInfo";
		this._2adxfsCrw3qjBhHJrJ5dDXAABnX.Size = new Size(23, 20);
		this._2adxfsCrw3qjBhHJrJ5dDXAABnX.TabIndex = 5;
		this._2adxfsCrw3qjBhHJrJ5dDXAABnX.Text = "?";
		this._2adxfsCrw3qjBhHJrJ5dDXAABnX.UseVisualStyleBackColor = true;
		this._2adxfsCrw3qjBhHJrJ5dDXAABnX.Click += this._laFdVRsWZTx9itTGUwb74tgE3lq;
		this._9tsk3hiE5XmV8RZQ9f4Nf6XO8gd.AutoSize = true;
		this._9tsk3hiE5XmV8RZQ9f4Nf6XO8gd.BackColor = Color.FromArgb(100, 40, 30);
		this._9tsk3hiE5XmV8RZQ9f4Nf6XO8gd.Font = new Font("Segoe UI", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this._9tsk3hiE5XmV8RZQ9f4Nf6XO8gd.ForeColor = SystemColors.ButtonFace;
		this._9tsk3hiE5XmV8RZQ9f4Nf6XO8gd.Location = new Point(8, 3);
		this._9tsk3hiE5XmV8RZQ9f4Nf6XO8gd.Name = "chkEnableFameTools";
		this._9tsk3hiE5XmV8RZQ9f4Nf6XO8gd.Size = new Size(114, 25);
		this._9tsk3hiE5XmV8RZQ9f4Nf6XO8gd.TabIndex = 1;
		this._9tsk3hiE5XmV8RZQ9f4Nf6XO8gd.Text = "Fame Tools";
		this._9tsk3hiE5XmV8RZQ9f4Nf6XO8gd.UseVisualStyleBackColor = false;
		this._6XCiVyAA72dGw5FZ1rL70tvdgKC.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
		this._6XCiVyAA72dGw5FZ1rL70tvdgKC.BackColor = Color.FromArgb(44, 71, 42);
		this._6XCiVyAA72dGw5FZ1rL70tvdgKC.BorderStyle = BorderStyle.FixedSingle;
		this._6XCiVyAA72dGw5FZ1rL70tvdgKC.Controls.Add(this._GtX43dQHZjQu2bV6Eare3Kpzdlc);
		this._6XCiVyAA72dGw5FZ1rL70tvdgKC.Controls.Add(this._oxisaD5nAqwjrlXSR18geRg80LE);
		this._6XCiVyAA72dGw5FZ1rL70tvdgKC.Controls.Add(this._x4uzXXueruGEcFglXIrb5e0FwrV);
		this._6XCiVyAA72dGw5FZ1rL70tvdgKC.Controls.Add(this._BEFwFnaRw3Ak2YGQpfohIOtEIDf);
		this._6XCiVyAA72dGw5FZ1rL70tvdgKC.Controls.Add(this._TRtDzNcp0DaJTMueoeHQxP8IcvE);
		this._6XCiVyAA72dGw5FZ1rL70tvdgKC.Controls.Add(this._Pg63SBxDORY9ETmq3s7wajvik8k);
		this._6XCiVyAA72dGw5FZ1rL70tvdgKC.Controls.Add(this._vc4gWdSsA2eFoiytixLF73YIYLM);
		this._6XCiVyAA72dGw5FZ1rL70tvdgKC.Controls.Add(this._tKBTSAORY4UWZkVWDYEkF4vaVRn);
		this._6XCiVyAA72dGw5FZ1rL70tvdgKC.Controls.Add(this._PPWcPcwCxmYtcKjpD0iNDmzeRte);
		this._6XCiVyAA72dGw5FZ1rL70tvdgKC.Controls.Add(this._lCRdTL6EkYbJqSpDojm7OcFWfI3b);
		this._6XCiVyAA72dGw5FZ1rL70tvdgKC.Controls.Add(this._3bGCaPsCFkbs5nX39EXz6FbIqlP);
		this._6XCiVyAA72dGw5FZ1rL70tvdgKC.Location = new Point(6, 1003);
		this._6XCiVyAA72dGw5FZ1rL70tvdgKC.Name = "pnlAntiLag";
		this._6XCiVyAA72dGw5FZ1rL70tvdgKC.Size = new Size(502, 169);
		this._6XCiVyAA72dGw5FZ1rL70tvdgKC.TabIndex = 29;
		this._GtX43dQHZjQu2bV6Eare3Kpzdlc.AutoSize = true;
		this._GtX43dQHZjQu2bV6Eare3Kpzdlc.BackColor = Color.FromArgb(44, 71, 42);
		this._GtX43dQHZjQu2bV6Eare3Kpzdlc.Location = new Point(30, 89);
		this._GtX43dQHZjQu2bV6Eare3Kpzdlc.Name = "chkAntiLagApplyToLockList";
		this._GtX43dQHZjQu2bV6Eare3Kpzdlc.Size = new Size(190, 21);
		this._GtX43dQHZjQu2bV6Eare3Kpzdlc.TabIndex = 44;
		this._GtX43dQHZjQu2bV6Eare3Kpzdlc.Text = "Change Lock List Player Size";
		this._GtX43dQHZjQu2bV6Eare3Kpzdlc.UseVisualStyleBackColor = false;
		this._oxisaD5nAqwjrlXSR18geRg80LE.AutoSize = true;
		this._oxisaD5nAqwjrlXSR18geRg80LE.BackColor = Color.FromArgb(44, 71, 42);
		this._oxisaD5nAqwjrlXSR18geRg80LE.Location = new Point(30, 62);
		this._oxisaD5nAqwjrlXSR18geRg80LE.Name = "chkAntiLagApplyToGuildMates";
		this._oxisaD5nAqwjrlXSR18geRg80LE.Size = new Size(205, 21);
		this._oxisaD5nAqwjrlXSR18geRg80LE.TabIndex = 43;
		this._oxisaD5nAqwjrlXSR18geRg80LE.Text = "Change Guild Mate Player Size";
		this._oxisaD5nAqwjrlXSR18geRg80LE.UseVisualStyleBackColor = false;
		this._x4uzXXueruGEcFglXIrb5e0FwrV.AutoSize = true;
		this._x4uzXXueruGEcFglXIrb5e0FwrV.BackColor = Color.FromArgb(44, 71, 42);
		this._x4uzXXueruGEcFglXIrb5e0FwrV.Location = new Point(30, 116);
		this._x4uzXXueruGEcFglXIrb5e0FwrV.Name = "chkAntiLagHideAllyPets";
		this._x4uzXXueruGEcFglXIrb5e0FwrV.Size = new Size(145, 21);
		this._x4uzXXueruGEcFglXIrb5e0FwrV.TabIndex = 42;
		this._x4uzXXueruGEcFglXIrb5e0FwrV.Text = "Hide Ally Player Pets";
		this._x4uzXXueruGEcFglXIrb5e0FwrV.UseVisualStyleBackColor = false;
		this._BEFwFnaRw3Ak2YGQpfohIOtEIDf.AutoSize = true;
		this._BEFwFnaRw3Ak2YGQpfohIOtEIDf.BackColor = Color.FromArgb(44, 71, 42);
		this._BEFwFnaRw3Ak2YGQpfohIOtEIDf.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this._BEFwFnaRw3Ak2YGQpfohIOtEIDf.ForeColor = SystemColors.ControlLight;
		this._BEFwFnaRw3Ak2YGQpfohIOtEIDf.Location = new Point(238, 36);
		this._BEFwFnaRw3Ak2YGQpfohIOtEIDf.Name = "label2";
		this._BEFwFnaRw3Ak2YGQpfohIOtEIDf.Size = new Size(154, 17);
		this._BEFwFnaRw3Ak2YGQpfohIOtEIDf.TabIndex = 41;
		this._BEFwFnaRw3Ak2YGQpfohIOtEIDf.Text = "(0 = HIDE, 100 = normal)";
		this._TRtDzNcp0DaJTMueoeHQxP8IcvE.AutoSize = true;
		this._TRtDzNcp0DaJTMueoeHQxP8IcvE.BackColor = Color.FromArgb(44, 71, 42);
		this._TRtDzNcp0DaJTMueoeHQxP8IcvE.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this._TRtDzNcp0DaJTMueoeHQxP8IcvE.ForeColor = SystemColors.ControlLight;
		this._TRtDzNcp0DaJTMueoeHQxP8IcvE.Location = new Point(27, 36);
		this._TRtDzNcp0DaJTMueoeHQxP8IcvE.Name = "lblAntiLagAllySize";
		this._TRtDzNcp0DaJTMueoeHQxP8IcvE.Size = new Size(142, 17);
		this._TRtDzNcp0DaJTMueoeHQxP8IcvE.TabIndex = 40;
		this._TRtDzNcp0DaJTMueoeHQxP8IcvE.Text = "Change Ally Player Size";
		this._Pg63SBxDORY9ETmq3s7wajvik8k.BackColor = Color.FromArgb(44, 71, 42);
		this._Pg63SBxDORY9ETmq3s7wajvik8k.Font = new Font("Segoe UI", 8.25f);
		this._Pg63SBxDORY9ETmq3s7wajvik8k.ForeColor = SystemColors.ControlLight;
		this._Pg63SBxDORY9ETmq3s7wajvik8k.Location = new Point(176, 34);
		NumericUpDown pg63SBxDORY9ETmq3s7wajvik8k = this._Pg63SBxDORY9ETmq3s7wajvik8k;
		int[] array27 = new int[4];
		array27[0] = 1000;
		pg63SBxDORY9ETmq3s7wajvik8k.Maximum = new decimal(array27);
		this._Pg63SBxDORY9ETmq3s7wajvik8k.Name = "numAntiLagAllySize";
		this._Pg63SBxDORY9ETmq3s7wajvik8k.Size = new Size(57, 22);
		this._Pg63SBxDORY9ETmq3s7wajvik8k.TabIndex = 39;
		NumericUpDown pg63SBxDORY9ETmq3s7wajvik8k2 = this._Pg63SBxDORY9ETmq3s7wajvik8k;
		int[] array28 = new int[4];
		array28[0] = 1;
		pg63SBxDORY9ETmq3s7wajvik8k2.Value = new decimal(array28);
		this._vc4gWdSsA2eFoiytixLF73YIYLM.AutoSize = true;
		this._vc4gWdSsA2eFoiytixLF73YIYLM.BackColor = Color.Transparent;
		this._vc4gWdSsA2eFoiytixLF73YIYLM.LinkColor = Color.Gold;
		this._vc4gWdSsA2eFoiytixLF73YIYLM.Location = new Point(182, 144);
		this._vc4gWdSsA2eFoiytixLF73YIYLM.Name = "btnEditIgnoredEffectList";
		this._vc4gWdSsA2eFoiytixLF73YIYLM.Size = new Size(176, 17);
		this._vc4gWdSsA2eFoiytixLF73YIYLM.TabIndex = 38;
		this._vc4gWdSsA2eFoiytixLF73YIYLM.TabStop = true;
		this._vc4gWdSsA2eFoiytixLF73YIYLM.Text = "Add/Remove Ignored Effects";
		this._vc4gWdSsA2eFoiytixLF73YIYLM.LinkClicked += this._PDXcGhpMUbphCYaR2fxXoaVYgPqA;
		this._tKBTSAORY4UWZkVWDYEkF4vaVRn.AutoSize = true;
		this._tKBTSAORY4UWZkVWDYEkF4vaVRn.Font = new Font("Segoe UI", 12f, FontStyle.Bold);
		this._tKBTSAORY4UWZkVWDYEkF4vaVRn.Location = new Point(8, 3);
		this._tKBTSAORY4UWZkVWDYEkF4vaVRn.Name = "label1";
		this._tKBTSAORY4UWZkVWDYEkF4vaVRn.Size = new Size(73, 21);
		this._tKBTSAORY4UWZkVWDYEkF4vaVRn.TabIndex = 25;
		this._tKBTSAORY4UWZkVWDYEkF4vaVRn.Text = "Anti Lag";
		this._PPWcPcwCxmYtcKjpD0iNDmzeRte.AutoSize = true;
		this._PPWcPcwCxmYtcKjpD0iNDmzeRte.BackColor = Color.FromArgb(44, 71, 42);
		this._PPWcPcwCxmYtcKjpD0iNDmzeRte.Location = new Point(30, 143);
		this._PPWcPcwCxmYtcKjpD0iNDmzeRte.Name = "chkAntiLagIgnoreEffects";
		this._PPWcPcwCxmYtcKjpD0iNDmzeRte.Size = new Size(146, 21);
		this._PPWcPcwCxmYtcKjpD0iNDmzeRte.TabIndex = 37;
		this._PPWcPcwCxmYtcKjpD0iNDmzeRte.Text = "Hide Ignored Effects";
		this._PPWcPcwCxmYtcKjpD0iNDmzeRte.UseVisualStyleBackColor = false;
		this._lCRdTL6EkYbJqSpDojm7OcFWfI3b.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
		this._lCRdTL6EkYbJqSpDojm7OcFWfI3b.BackColor = Color.FromArgb(44, 51, 42);
		this._lCRdTL6EkYbJqSpDojm7OcFWfI3b.BorderStyle = BorderStyle.FixedSingle;
		this._lCRdTL6EkYbJqSpDojm7OcFWfI3b.Location = new Point(8, 28);
		this._lCRdTL6EkYbJqSpDojm7OcFWfI3b.Name = "panel2";
		this._lCRdTL6EkYbJqSpDojm7OcFWfI3b.Size = new Size(485, 1);
		this._lCRdTL6EkYbJqSpDojm7OcFWfI3b.TabIndex = 6;
		this._3bGCaPsCFkbs5nX39EXz6FbIqlP.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
		this._3bGCaPsCFkbs5nX39EXz6FbIqlP.Font = new Font("Segoe UI", 6.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this._3bGCaPsCFkbs5nX39EXz6FbIqlP.ForeColor = Color.Black;
		this._3bGCaPsCFkbs5nX39EXz6FbIqlP.Location = new Point(471, 5);
		this._3bGCaPsCFkbs5nX39EXz6FbIqlP.Name = "btnAntiLagInfo";
		this._3bGCaPsCFkbs5nX39EXz6FbIqlP.Size = new Size(23, 20);
		this._3bGCaPsCFkbs5nX39EXz6FbIqlP.TabIndex = 5;
		this._3bGCaPsCFkbs5nX39EXz6FbIqlP.Text = "?";
		this._3bGCaPsCFkbs5nX39EXz6FbIqlP.UseVisualStyleBackColor = true;
		this._3bGCaPsCFkbs5nX39EXz6FbIqlP.Click += this._Zr5z6XtKBUdCIiAWoWQEHLiRJBf;
		this._s0nXuBNPmKbDc1iFqeq2pmE5M0y.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
		this._s0nXuBNPmKbDc1iFqeq2pmE5M0y.BackColor = Color.FromArgb(120, 120, 120);
		this._s0nXuBNPmKbDc1iFqeq2pmE5M0y.BorderStyle = BorderStyle.FixedSingle;
		this._s0nXuBNPmKbDc1iFqeq2pmE5M0y.Controls.Add(this._TsdwF2AqCEqU4ZIAGSvBxKuzOQD);
		this._s0nXuBNPmKbDc1iFqeq2pmE5M0y.Controls.Add(this._VbEAAQfG52Y5rE7mSLefOWnb0sIA);
		this._s0nXuBNPmKbDc1iFqeq2pmE5M0y.Controls.Add(this._Uh9LpC6i6KDUh3BvNPUBraYgQeY);
		this._s0nXuBNPmKbDc1iFqeq2pmE5M0y.Controls.Add(this._5hgAZ08Jk9aXcfouJfbf4Lz0SgN);
		this._s0nXuBNPmKbDc1iFqeq2pmE5M0y.Controls.Add(this._eesno6VabGLIZTjbrNpe4JCXr1f);
		this._s0nXuBNPmKbDc1iFqeq2pmE5M0y.Controls.Add(this._jWNiGS8yodvyuY2B9kSuTIvR3IG);
		this._s0nXuBNPmKbDc1iFqeq2pmE5M0y.Location = new Point(6, 1720);
		this._s0nXuBNPmKbDc1iFqeq2pmE5M0y.Name = "pnlO3";
		this._s0nXuBNPmKbDc1iFqeq2pmE5M0y.Size = new Size(502, 115);
		this._s0nXuBNPmKbDc1iFqeq2pmE5M0y.TabIndex = 28;
		this._TsdwF2AqCEqU4ZIAGSvBxKuzOQD.AutoSize = true;
		this._TsdwF2AqCEqU4ZIAGSvBxKuzOQD.BackColor = Color.FromArgb(120, 120, 120);
		this._TsdwF2AqCEqU4ZIAGSvBxKuzOQD.Location = new Point(30, 87);
		this._TsdwF2AqCEqU4ZIAGSvBxKuzOQD.Name = "chkO3IgnoreDammahInterruption";
		this._TsdwF2AqCEqU4ZIAGSvBxKuzOQD.Size = new Size(235, 21);
		this._TsdwF2AqCEqU4ZIAGSvBxKuzOQD.TabIndex = 31;
		this._TsdwF2AqCEqU4ZIAGSvBxKuzOQD.Text = "Ignore Dammah during interruption";
		this._TsdwF2AqCEqU4ZIAGSvBxKuzOQD.UseVisualStyleBackColor = false;
		this._VbEAAQfG52Y5rE7mSLefOWnb0sIA.AutoSize = true;
		this._VbEAAQfG52Y5rE7mSLefOWnb0sIA.BackColor = Color.FromArgb(120, 120, 120);
		this._VbEAAQfG52Y5rE7mSLefOWnb0sIA.Location = new Point(30, 60);
		this._VbEAAQfG52Y5rE7mSLefOWnb0sIA.Name = "chkO3IgnoreGemsbokCoins";
		this._VbEAAQfG52Y5rE7mSLefOWnb0sIA.Size = new Size(199, 21);
		this._VbEAAQfG52Y5rE7mSLefOWnb0sIA.TabIndex = 30;
		this._VbEAAQfG52Y5rE7mSLefOWnb0sIA.Text = "Ignore wrong Gemsbok coins";
		this._VbEAAQfG52Y5rE7mSLefOWnb0sIA.UseVisualStyleBackColor = false;
		this._Uh9LpC6i6KDUh3BvNPUBraYgQeY.AutoSize = true;
		this._Uh9LpC6i6KDUh3BvNPUBraYgQeY.BackColor = Color.FromArgb(120, 120, 120);
		this._Uh9LpC6i6KDUh3BvNPUBraYgQeY.Location = new Point(30, 33);
		this._Uh9LpC6i6KDUh3BvNPUBraYgQeY.Name = "chkO3IgnoreShield";
		this._Uh9LpC6i6KDUh3BvNPUBraYgQeY.Size = new Size(198, 21);
		this._Uh9LpC6i6KDUh3BvNPUBraYgQeY.TabIndex = 14;
		this._Uh9LpC6i6KDUh3BvNPUBraYgQeY.Text = "Ignore O3 during shield raise";
		this._Uh9LpC6i6KDUh3BvNPUBraYgQeY.UseVisualStyleBackColor = false;
		this._5hgAZ08Jk9aXcfouJfbf4Lz0SgN.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
		this._5hgAZ08Jk9aXcfouJfbf4Lz0SgN.BackColor = Color.FromArgb(44, 51, 42);
		this._5hgAZ08Jk9aXcfouJfbf4Lz0SgN.BorderStyle = BorderStyle.FixedSingle;
		this._5hgAZ08Jk9aXcfouJfbf4Lz0SgN.Location = new Point(8, 28);
		this._5hgAZ08Jk9aXcfouJfbf4Lz0SgN.Name = "sepO3";
		this._5hgAZ08Jk9aXcfouJfbf4Lz0SgN.Size = new Size(485, 1);
		this._5hgAZ08Jk9aXcfouJfbf4Lz0SgN.TabIndex = 6;
		this._eesno6VabGLIZTjbrNpe4JCXr1f.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
		this._eesno6VabGLIZTjbrNpe4JCXr1f.Font = new Font("Segoe UI", 6.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this._eesno6VabGLIZTjbrNpe4JCXr1f.ForeColor = Color.Black;
		this._eesno6VabGLIZTjbrNpe4JCXr1f.Location = new Point(471, 5);
		this._eesno6VabGLIZTjbrNpe4JCXr1f.Name = "btnO3HelperInfo";
		this._eesno6VabGLIZTjbrNpe4JCXr1f.Size = new Size(23, 20);
		this._eesno6VabGLIZTjbrNpe4JCXr1f.TabIndex = 5;
		this._eesno6VabGLIZTjbrNpe4JCXr1f.Text = "?";
		this._eesno6VabGLIZTjbrNpe4JCXr1f.UseVisualStyleBackColor = true;
		this._eesno6VabGLIZTjbrNpe4JCXr1f.Click += this._afN8bOzkbCBgalxThtbh3kWUzlh;
		this._jWNiGS8yodvyuY2B9kSuTIvR3IG.AutoSize = true;
		this._jWNiGS8yodvyuY2B9kSuTIvR3IG.BackColor = Color.FromArgb(120, 120, 120);
		this._jWNiGS8yodvyuY2B9kSuTIvR3IG.Font = new Font("Segoe UI", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this._jWNiGS8yodvyuY2B9kSuTIvR3IG.ForeColor = SystemColors.ButtonFace;
		this._jWNiGS8yodvyuY2B9kSuTIvR3IG.Location = new Point(8, 3);
		this._jWNiGS8yodvyuY2B9kSuTIvR3IG.Name = "chkEnableO3Helper";
		this._jWNiGS8yodvyuY2B9kSuTIvR3IG.Size = new Size(134, 25);
		this._jWNiGS8yodvyuY2B9kSuTIvR3IG.TabIndex = 1;
		this._jWNiGS8yodvyuY2B9kSuTIvR3IG.Text = "Oryx 3 Helper";
		this._jWNiGS8yodvyuY2B9kSuTIvR3IG.UseVisualStyleBackColor = false;
		this._GrG3a2HOSzWBO9DtGXrGPYzuprB.AutoSize = true;
		this._GrG3a2HOSzWBO9DtGXrGPYzuprB.BackColor = Color.FromArgb(44, 41, 62);
		this._GrG3a2HOSzWBO9DtGXrGPYzuprB.Location = new Point(257, 61);
		this._GrG3a2HOSzWBO9DtGXrGPYzuprB.Name = "chkAutoNexusDrinkFromInventory";
		this._GrG3a2HOSzWBO9DtGXrGPYzuprB.Size = new Size(194, 21);
		this._GrG3a2HOSzWBO9DtGXrGPYzuprB.TabIndex = 19;
		this._GrG3a2HOSzWBO9DtGXrGPYzuprB.Text = "Drink potions from inventory";
		this._GrG3a2HOSzWBO9DtGXrGPYzuprB.UseVisualStyleBackColor = false;
		this._Hjc8Zs1G4lABixPBnJgdEybxLNL.AutoSize = true;
		this._Hjc8Zs1G4lABixPBnJgdEybxLNL.BackColor = Color.FromArgb(74, 31, 32);
		this._Hjc8Zs1G4lABixPBnJgdEybxLNL.Location = new Point(280, 176);
		this._Hjc8Zs1G4lABixPBnJgdEybxLNL.Name = "chkAutoAbilityAutoMP";
		this._Hjc8Zs1G4lABixPBnJgdEybxLNL.Size = new Size(176, 21);
		this._Hjc8Zs1G4lABixPBnJgdEybxLNL.TabIndex = 39;
		this._Hjc8Zs1G4lABixPBnJgdEybxLNL.Text = "Auto drink MP after Quiet";
		this._Hjc8Zs1G4lABixPBnJgdEybxLNL.UseVisualStyleBackColor = false;
		base.AutoScaleDimensions = new SizeF(96f, 96f);
		base.AutoScaleMode = AutoScaleMode.Dpi;
		this.AutoScroll = true;
		this.BackColor = Color.FromArgb(44, 31, 52);
		this.BackgroundImageLayout = ImageLayout.Stretch;
		base.Controls.Add(this._xZBd1IVcAqPTBrdFglWuJbpqhVv);
		base.Controls.Add(this._6XCiVyAA72dGw5FZ1rL70tvdgKC);
		base.Controls.Add(this._s0nXuBNPmKbDc1iFqeq2pmE5M0y);
		base.Controls.Add(this._eNEP9aTBIxptpE2leJOgLDYn7ds);
		base.Controls.Add(this._YnUaeaUO3v7j9nMGyrg8xLCRvbaA);
		base.Controls.Add(this._66R5JOMpaHqfjMaFdYBF8CAzrsP);
		base.Controls.Add(this._tTk6bi5hd04ILmOC4QXTGaAhjoXA);
		base.Controls.Add(this._cPRPcukexlWRRbt17KCOAXsFL4F);
		base.Controls.Add(this._ZE6BWnV3aucOtptJFG0jFQt19wR);
		base.Controls.Add(this._oUyaM8rB6O9TO4tYBzBYZxK4m3w);
		base.Controls.Add(this._OFGERDl1EqTyy8cSjx875xroSBC);
		this.DoubleBuffered = true;
		this.Font = new Font("Segoe UI", 9.75f);
		this.ForeColor = SystemColors.ControlLight;
		base.Name = "ProxyControl";
		base.Size = new Size(514, 1847);
		this._66R5JOMpaHqfjMaFdYBF8CAzrsP.ResumeLayout(false);
		this._66R5JOMpaHqfjMaFdYBF8CAzrsP.PerformLayout();
		this._tTk6bi5hd04ILmOC4QXTGaAhjoXA.ResumeLayout(false);
		this._tTk6bi5hd04ILmOC4QXTGaAhjoXA.PerformLayout();
		this._cPRPcukexlWRRbt17KCOAXsFL4F.ResumeLayout(false);
		this._cPRPcukexlWRRbt17KCOAXsFL4F.PerformLayout();
		this._xZBd1IVcAqPTBrdFglWuJbpqhVv.ResumeLayout(false);
		this._xZBd1IVcAqPTBrdFglWuJbpqhVv.PerformLayout();
		((ISupportInitialize)this._ZmvCnBYucGfhRyLkfY8Vn57QKl).EndInit();
		((ISupportInitialize)this._D7P47Rl73LeCnoWEZ4ymh4fBqgy).EndInit();
		((ISupportInitialize)this._Bqrrvj9sLTV9fVEWILcdRkkmjKo).EndInit();
		((ISupportInitialize)this._nOqnw75a3yyZAudzbKHSIUYMy4n).EndInit();
		this._ZE6BWnV3aucOtptJFG0jFQt19wR.ResumeLayout(false);
		this._ZE6BWnV3aucOtptJFG0jFQt19wR.PerformLayout();
		((ISupportInitialize)this._jtPLnv8PlfLBzXu7dbti6f34nDq).EndInit();
		this._oUyaM8rB6O9TO4tYBzBYZxK4m3w.ResumeLayout(false);
		this._oUyaM8rB6O9TO4tYBzBYZxK4m3w.PerformLayout();
		((ISupportInitialize)this._6k83485jw6zIY1JyvUVJehSZU1e).EndInit();
		((ISupportInitialize)this._JrQ0jvSnpu8tCPkHfWRan3nPstO).EndInit();
		((ISupportInitialize)this._9QHYF9EAZe2ak9U6KEkgpsJl1u6).EndInit();
		((ISupportInitialize)this._c5laqQAVlFJapJyeOL4JaLeJfbf).EndInit();
		this._OFGERDl1EqTyy8cSjx875xroSBC.ResumeLayout(false);
		this._OFGERDl1EqTyy8cSjx875xroSBC.PerformLayout();
		((ISupportInitialize)this._qjPTNygvB4B3vDNLDEu8h56XDJh).EndInit();
		((ISupportInitialize)this._62VSbpDeRcayFyvfIb9IE4vREup).EndInit();
		this._YnUaeaUO3v7j9nMGyrg8xLCRvbaA.ResumeLayout(false);
		this._YnUaeaUO3v7j9nMGyrg8xLCRvbaA.PerformLayout();
		this._eNEP9aTBIxptpE2leJOgLDYn7ds.ResumeLayout(false);
		this._eNEP9aTBIxptpE2leJOgLDYn7ds.PerformLayout();
		this._6XCiVyAA72dGw5FZ1rL70tvdgKC.ResumeLayout(false);
		this._6XCiVyAA72dGw5FZ1rL70tvdgKC.PerformLayout();
		((ISupportInitialize)this._Pg63SBxDORY9ETmq3s7wajvik8k).EndInit();
		this._s0nXuBNPmKbDc1iFqeq2pmE5M0y.ResumeLayout(false);
		this._s0nXuBNPmKbDc1iFqeq2pmE5M0y.PerformLayout();
		base.ResumeLayout(false);
	}

	// Token: 0x04000001 RID: 1
	private IContainer _UBpFiXjXmW4HUIyvG86l99grd9E;

	// Token: 0x04000002 RID: 2
	private Panel _66R5JOMpaHqfjMaFdYBF8CAzrsP;

	// Token: 0x04000003 RID: 3
	private CheckBox _16kZtHLtwDycSkuE6DfiCtUWvJO;

	// Token: 0x04000004 RID: 4
	private Panel _jfBHRYSFZdRBdHioXeKUuy5vR5j;

	// Token: 0x04000005 RID: 5
	private Button _o04URIO6P3nv08ZeHJ9CrS77uPC;

	// Token: 0x04000006 RID: 6
	private CheckBox _qWCfatZcN3T4yKLil0EWhMMwfUH;

	// Token: 0x04000007 RID: 7
	private Panel _tTk6bi5hd04ILmOC4QXTGaAhjoXA;

	// Token: 0x04000008 RID: 8
	private CheckBox _4PoQKDUdcjCbhRHv9jUBuFRjGCf;

	// Token: 0x04000009 RID: 9
	private CheckBox _t2acvbrlRCoBW0SQLsLf1bW6ViBA;

	// Token: 0x0400000A RID: 10
	private Panel _wFWtZv2drhYBk4jZvD4d01sJNGO;

	// Token: 0x0400000B RID: 11
	private Button _s63jh3TIOah0EzSLqZ9NZb0Mqre;

	// Token: 0x0400000C RID: 12
	private Panel _cPRPcukexlWRRbt17KCOAXsFL4F;

	// Token: 0x0400000D RID: 13
	private Panel _SGElH7giclUeEyBHAOAHXBzc4wM;

	// Token: 0x0400000E RID: 14
	private Panel _DRFtjKGGY2VXLBCayHDByNnUzWO;

	// Token: 0x0400000F RID: 15
	private CheckBox _V34eau5Dg1cv3Zd7vEZY0mTColq;

	// Token: 0x04000010 RID: 16
	private CheckBox _8E4AkIWycDhHLRPt1JlObxknaaeA;

	// Token: 0x04000011 RID: 17
	private CheckBox _s4L4ts7GhmGGiDPTViFKcS0GkMO;

	// Token: 0x04000012 RID: 18
	private CheckBox _wOm0pYjtWIbGhTbcbCuMM85vzSR;

	// Token: 0x04000013 RID: 19
	private CheckBox _Cph2vLfFeaFKEcHaPocxtLNCvNT;

	// Token: 0x04000014 RID: 20
	private CheckBox _HZRDDd8clmod73yUocCQzV7CR5qA;

	// Token: 0x04000015 RID: 21
	private CheckBox _Qa5criCk6Y0AEV8dPqDlCkHFhZxA;

	// Token: 0x04000016 RID: 22
	private CheckBox _Bbkzoe8PdmMImob9HioxthuG6fd;

	// Token: 0x04000017 RID: 23
	private CheckBox _63BFRX3Ta4mS00FBS7S5oA6RIei;

	// Token: 0x04000018 RID: 24
	private CheckBox _aDFRoRC7aHH4bfveH505QN32GIF;

	// Token: 0x04000019 RID: 25
	private CheckBox _wVihnzsx3LI5e7WBoMmPqHjQP6d;

	// Token: 0x0400001A RID: 26
	private CheckBox _Ua0d9OnwHQ5BI5RoQEANYQVT8sU;

	// Token: 0x0400001B RID: 27
	private Label _sPASlpgjmceRkJ10l5HMqtXYwCG;

	// Token: 0x0400001C RID: 28
	private CheckBox _NKlRvThUQVierr8jt1xNV3Myl9H;

	// Token: 0x0400001D RID: 29
	private CheckBox _7ibUrZ0FPa1apl1pB7R5GgqooLG;

	// Token: 0x0400001E RID: 30
	private CheckBox _1m7JRxDQQGenByZhp4lj51ra1uo;

	// Token: 0x0400001F RID: 31
	private CheckBox _sTTKlNSF2pywEUoDNyMYazoDwXg;

	// Token: 0x04000020 RID: 32
	private CheckBox _u2jEC6VyecGYGD5C3qrbPjbfjr4;

	// Token: 0x04000021 RID: 33
	private CheckBox _MVC6SsDfZUqbssBBmfaPMbSmFhe;

	// Token: 0x04000022 RID: 34
	private Label _njdDYS23mYGWn2ocLeCmY0a2slbA;

	// Token: 0x04000023 RID: 35
	private Panel _cRnQHjhccoQdAxvsGCdFVwDfJE1;

	// Token: 0x04000024 RID: 36
	private Button _9x1otcvb4GZxwhWAzUr4o7Pyt6b;

	// Token: 0x04000025 RID: 37
	private CheckBox _ZCZoTOBxN9mFZI5rBXrOOKt2TKH;

	// Token: 0x04000026 RID: 38
	private Panel _xZBd1IVcAqPTBrdFglWuJbpqhVv;

	// Token: 0x04000027 RID: 39
	private NumericUpDown _ZmvCnBYucGfhRyLkfY8Vn57QKl;

	// Token: 0x04000028 RID: 40
	private Label _wIxsQPJFBeOnkTBETLyot7U7HQd;

	// Token: 0x04000029 RID: 41
	private NumericUpDown _D7P47Rl73LeCnoWEZ4ymh4fBqgy;

	// Token: 0x0400002A RID: 42
	private Label _jnLDC0xHVtKyjWVKOWAH40DziuUb;

	// Token: 0x0400002B RID: 43
	private CheckBox _Dl9iE93suz1bDyhKZboK2jTfawDA;

	// Token: 0x0400002C RID: 44
	private CheckBox _GrjrySFEic6T6Z7wWeAIYZ0GJrA;

	// Token: 0x0400002D RID: 45
	private CheckBox _5IRdHPBh5V6bUQuEKkyGn9RUi1T;

	// Token: 0x0400002E RID: 46
	private NumericUpDown _Bqrrvj9sLTV9fVEWILcdRkkmjKo;

	// Token: 0x0400002F RID: 47
	private Label _QizBpycMvTObFLaaBtybGm832AR;

	// Token: 0x04000030 RID: 48
	private NumericUpDown _nOqnw75a3yyZAudzbKHSIUYMy4n;

	// Token: 0x04000031 RID: 49
	private Label _cDL6L6SyYNLSfiuaaTdcpgF0E5Y;

	// Token: 0x04000032 RID: 50
	private Panel _Mc1AKCDOLA5IewbvwOjyn2GdPfq;

	// Token: 0x04000033 RID: 51
	private Button _m8Tr8k6wY8UXWx0M0vhk32xVXwb;

	// Token: 0x04000034 RID: 52
	private CheckBox _YjbICycDEC61T7pIUVy0eaY9v1m;

	// Token: 0x04000035 RID: 53
	private Panel _ZE6BWnV3aucOtptJFG0jFQt19wR;

	// Token: 0x04000036 RID: 54
	private CheckBox _l6raCVgixQmMN8kPAfYkFYnrqky;

	// Token: 0x04000037 RID: 55
	private RadioButton _UNMKg8qPomqO5a5Jew7ukXPzENf;

	// Token: 0x04000038 RID: 56
	private RadioButton _dmOAJYyrtKFKK3xUW1NDcvh5QVv;

	// Token: 0x04000039 RID: 57
	private Label _wHaSFzsf19T5k2ZBGvHJu0pcf3i;

	// Token: 0x0400003A RID: 58
	private NumericUpDown _jtPLnv8PlfLBzXu7dbti6f34nDq;

	// Token: 0x0400003B RID: 59
	private Label _U56cl9eFIl3JKbtQh9k53UWb6SY;

	// Token: 0x0400003C RID: 60
	private Panel _mf7O8njBr55uJOPndWhOfZhB26k;

	// Token: 0x0400003D RID: 61
	private Button _kevi7G85zI1rlB8dS2oLX5hhF5k;

	// Token: 0x0400003E RID: 62
	private CheckBox _OuRzT08buKm1QrtE8IGaLOiW9qM;

	// Token: 0x0400003F RID: 63
	private Panel _oUyaM8rB6O9TO4tYBzBYZxK4m3w;

	// Token: 0x04000040 RID: 64
	private Panel _Mixf8sI0kZDJCwoFg3WpNQN0h1H;

	// Token: 0x04000041 RID: 65
	private Button _ftgy68Qbf8ty1dzazTutC4fGxcX;

	// Token: 0x04000042 RID: 66
	private CheckBox _PurNnAIDE44j6AvnAPVuLPTqjSk;

	// Token: 0x04000043 RID: 67
	private Panel _OFGERDl1EqTyy8cSjx875xroSBC;

	// Token: 0x04000044 RID: 68
	private Label _Do5CIYGgaFClsbuysngi6YRJSNq;

	// Token: 0x04000045 RID: 69
	private Panel _yQ1kSD7a2a3aKSDQCfysAKHn0Ue;

	// Token: 0x04000046 RID: 70
	private Button _IiKbopXhVBOSMxagiaQAt5bahuxA;

	// Token: 0x04000047 RID: 71
	private NumericUpDown _62VSbpDeRcayFyvfIb9IE4vREup;

	// Token: 0x04000048 RID: 72
	private Label _0HGnMal1Vd4x3tahp3yMGdeIssG;

	// Token: 0x04000049 RID: 73
	private CheckBox _lWjWhmJoXyiE8WhbXSrYAge1vjC;

	// Token: 0x0400004A RID: 74
	private Label _FIIdC84o3TKCFUXg0FpaRpwDHmHA;

	// Token: 0x0400004B RID: 75
	private NumericUpDown _c5laqQAVlFJapJyeOL4JaLeJfbf;

	// Token: 0x0400004C RID: 76
	private Label _oG0D38K3dGqrjszXNGDhJgLg3YO;

	// Token: 0x0400004D RID: 77
	private Label _avTCWVvfyh5Z2ZcOPgrfahJGerT;

	// Token: 0x0400004E RID: 78
	private NumericUpDown _9QHYF9EAZe2ak9U6KEkgpsJl1u6;

	// Token: 0x0400004F RID: 79
	private Label _ysfSIj72X08AFWJAyx7j0yhALnK;

	// Token: 0x04000050 RID: 80
	private NumericUpDown _JrQ0jvSnpu8tCPkHfWRan3nPstO;

	// Token: 0x04000051 RID: 81
	private Label _agYF6ii02oU5KICbi31ZCzXf25U;

	// Token: 0x04000052 RID: 82
	private Label _Pqw9zi4w7GqQwYQK41QnTuuWuPB;

	// Token: 0x04000053 RID: 83
	private RadioButton _GvDTOnQNOsGJ89PGbQmKVm4TY4f;

	// Token: 0x04000054 RID: 84
	private RadioButton _eK6G41SpwvAkaNcHSQtBN8YOH3g;

	// Token: 0x04000055 RID: 85
	private RadioButton _sN2qtf5IZN2fEvMaqDslGiFFgAV;

	// Token: 0x04000056 RID: 86
	private Label _JtRnoMorwqCBXJIsNMmgOow41KL;

	// Token: 0x04000057 RID: 87
	private NumericUpDown _6k83485jw6zIY1JyvUVJehSZU1e;

	// Token: 0x04000058 RID: 88
	private Label _OtdDwtRcwgnd04tA1CeTqnWtGmdA;

	// Token: 0x04000059 RID: 89
	private CheckBox _TqfCzyDDmzNUzXRCgRJHukfSl3V;

	// Token: 0x0400005A RID: 90
	private CheckBox _892HB1ye673FqC2JE66HvKLszQz;

	// Token: 0x0400005B RID: 91
	private CheckBox _n70yPk1wetBL7AbT2mFaJ6qaljq;

	// Token: 0x0400005C RID: 92
	private Panel _YnUaeaUO3v7j9nMGyrg8xLCRvbaA;

	// Token: 0x0400005D RID: 93
	private Panel _CFHhsixORk1ubYPKegZSTI4aJ0k;

	// Token: 0x0400005E RID: 94
	private Button _RUh9TbFjqdzx0jETEYjgjtUGoTg;

	// Token: 0x0400005F RID: 95
	private Label _PNCuD1l2tNobM4F9uXZCce0XGip;

	// Token: 0x04000060 RID: 96
	private CheckBox _eTdfMqaoeCvX9U8m9jfRYiV8pKE;

	// Token: 0x04000061 RID: 97
	private Label _HKvBIWwhyYKablJJ0IwaHtn9QR8;

	// Token: 0x04000062 RID: 98
	private CheckBox _6hGbopNqB96fOCghBWmy3wUmFAZ;

	// Token: 0x04000063 RID: 99
	private CheckBox _RpgFCNKcg7DHEuUuRqmklU498z3;

	// Token: 0x04000064 RID: 100
	private Panel _eNEP9aTBIxptpE2leJOgLDYn7ds;

	// Token: 0x04000065 RID: 101
	private CheckBox _ArSzgygWkzBHHPBRzNRWIRx7ieg;

	// Token: 0x04000066 RID: 102
	private Panel _CcJWy1gRUni2ZZkIO4OKPTcaWGH;

	// Token: 0x04000067 RID: 103
	private Button _2adxfsCrw3qjBhHJrJ5dDXAABnX;

	// Token: 0x04000068 RID: 104
	private CheckBox _9tsk3hiE5XmV8RZQ9f4Nf6XO8gd;

	// Token: 0x04000069 RID: 105
	private CheckBox _Wm4Y3d9Dbxyb3dFlDZ67hnzKobdA;

	// Token: 0x0400006A RID: 106
	private CheckBox _WhJddPSH9Ds2gCiSO7YBHdUQ8r5;

	// Token: 0x0400006B RID: 107
	private CheckBox _VnTsmnYXLRGDwkJ8FC3nU4bIP9B;

	// Token: 0x0400006C RID: 108
	private CheckBox _ZkdDuSvdPQwDoDAG5n9bgFAVmvpb;

	// Token: 0x0400006D RID: 109
	private CheckBox _IaPeVUijdNZdd89OGoTZBAC54mX;

	// Token: 0x0400006E RID: 110
	private CheckBox _MWkLE2pOYN6KLMnyPX43PNMmv2d;

	// Token: 0x0400006F RID: 111
	private LinkLabel _LeBw0Xu8GHUkpehWS0c8qyHakdb;

	// Token: 0x04000070 RID: 112
	private CheckBox _CNPY7lJQfipiMP54YgOStijjuD;

	// Token: 0x04000071 RID: 113
	private CheckBox _MHsbaQngmyctML526ywXin8JPuAA;

	// Token: 0x04000072 RID: 114
	private CheckBox _Peynkzk3GJMrKqqla5AmSBsGPNd;

	// Token: 0x04000073 RID: 115
	private Panel _6XCiVyAA72dGw5FZ1rL70tvdgKC;

	// Token: 0x04000074 RID: 116
	private Label _tKBTSAORY4UWZkVWDYEkF4vaVRn;

	// Token: 0x04000075 RID: 117
	private Panel _lCRdTL6EkYbJqSpDojm7OcFWfI3b;

	// Token: 0x04000076 RID: 118
	private Button _3bGCaPsCFkbs5nX39EXz6FbIqlP;

	// Token: 0x04000077 RID: 119
	private LinkLabel _vc4gWdSsA2eFoiytixLF73YIYLM;

	// Token: 0x04000078 RID: 120
	private CheckBox _PPWcPcwCxmYtcKjpD0iNDmzeRte;

	// Token: 0x04000079 RID: 121
	private NumericUpDown _Pg63SBxDORY9ETmq3s7wajvik8k;

	// Token: 0x0400007A RID: 122
	private Label _TRtDzNcp0DaJTMueoeHQxP8IcvE;

	// Token: 0x0400007B RID: 123
	private Label _BEFwFnaRw3Ak2YGQpfohIOtEIDf;

	// Token: 0x0400007C RID: 124
	private CheckBox _x4uzXXueruGEcFglXIrb5e0FwrV;

	// Token: 0x0400007D RID: 125
	private CheckBox _GtX43dQHZjQu2bV6Eare3Kpzdlc;

	// Token: 0x0400007E RID: 126
	private CheckBox _oxisaD5nAqwjrlXSR18geRg80LE;

	// Token: 0x0400007F RID: 127
	private CheckBox _x1fiq46peAdaxB8CJb2R1gvC3Ze;

	// Token: 0x04000080 RID: 128
	private CheckBox _VsAdTcay5ThIW4bJ6BrnGbDl1JM;

	// Token: 0x04000081 RID: 129
	private Label _rkCOyhCrmFgszG5N6BFXtycsLJC;

	// Token: 0x04000082 RID: 130
	private CheckBox _69arQcmFpxyq8YsKbiEEVFHjqKn;

	// Token: 0x04000083 RID: 131
	private Label _UQXpP3YbtvnD1q2FOAN2qS2ohxW;

	// Token: 0x04000084 RID: 132
	private NumericUpDown _qjPTNygvB4B3vDNLDEu8h56XDJh;

	// Token: 0x04000085 RID: 133
	private Label _D56B164kgvuhufuOvewvaVBYdYh;

	// Token: 0x04000086 RID: 134
	private CheckBox _fy5pJKD6hrd5Rd3BYJDMYnkrYMG;

	// Token: 0x04000087 RID: 135
	private CheckBox _0doBNQg7RJwqoJMchbOLNlaqlvYA;

	// Token: 0x04000088 RID: 136
	private CheckBox _kWKdv7Ej4YZpJmrueD5AxpqBF7bA;

	// Token: 0x04000089 RID: 137
	private Panel _s0nXuBNPmKbDc1iFqeq2pmE5M0y;

	// Token: 0x0400008A RID: 138
	private CheckBox _TsdwF2AqCEqU4ZIAGSvBxKuzOQD;

	// Token: 0x0400008B RID: 139
	private CheckBox _VbEAAQfG52Y5rE7mSLefOWnb0sIA;

	// Token: 0x0400008C RID: 140
	private CheckBox _Uh9LpC6i6KDUh3BvNPUBraYgQeY;

	// Token: 0x0400008D RID: 141
	private Panel _5hgAZ08Jk9aXcfouJfbf4Lz0SgN;

	// Token: 0x0400008E RID: 142
	private Button _eesno6VabGLIZTjbrNpe4JCXr1f;

	// Token: 0x0400008F RID: 143
	private CheckBox _jWNiGS8yodvyuY2B9kSuTIvR3IG;

	// Token: 0x04000090 RID: 144
	private CheckBox _LSwBbAV9udSnDiLV8q5BGJbAlScA;

	// Token: 0x04000091 RID: 145
	private CheckBox _2G6OUmnDQnKZwcr35APccCOreeK;

	// Token: 0x04000092 RID: 146
	private CheckBox _GrG3a2HOSzWBO9DtGXrGPYzuprB;

	// Token: 0x04000093 RID: 147
	private CheckBox _Hjc8Zs1G4lABixPBnJgdEybxLNL;

	// Token: 0x02000003 RID: 3
	[CompilerGenerated]
	[Serializable]
	private sealed class _5RA1o36SSB1Cj4MaXzNHqI21TTR
	{
		// Token: 0x06000016 RID: 22 RVA: 0x00009ABC File Offset: 0x00007CBC
		internal void _nVNds7wLpVta7Yq9XQAg1FOBaTU(object sender, MouseEventArgs e)
		{
			((HandledMouseEventArgs)e).Handled = true;
		}

		// Token: 0x04000094 RID: 148
		public static readonly _Q1iu4PEWGR2odhAgRlKQSWbHhWM._5RA1o36SSB1Cj4MaXzNHqI21TTR <>9 = new _Q1iu4PEWGR2odhAgRlKQSWbHhWM._5RA1o36SSB1Cj4MaXzNHqI21TTR();

		// Token: 0x04000095 RID: 149
		public static MouseEventHandler <>9__1_0;
	}
}
