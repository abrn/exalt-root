using System;
using System.Xml.Linq;

// Token: 0x020000C1 RID: 193
internal class Activate
{
	// Token: 0x06000522 RID: 1314 RVA: 0x0001ECE4 File Offset: 0x0001CEE4
	public Activate(XElement activate)
	{
		if (!Enum.TryParse<Activate.ActivateType>(activate.Value, out this.Name))
		{
			Console.WriteLine(string.Format("Failed to parse {0} as an ActivateType", activate));
		}
		this.Amount = activate.AttrDefault("amount", "0").ParseInt();
		this.Duration = activate.AttrDefault("duration", "0").ParseFloat();
		this.Range = activate.AttrDefault("range", "0").ParseFloat();
		string text = activate.AttrDefault("stat", "");
		if (!string.IsNullOrWhiteSpace(text) && !Enum.TryParse<StatsType.StatsTypeEnum>(text, out this.Stat))
		{
			Console.WriteLine("Failed to parse " + text + " as a StatsType");
		}
	}

	// Token: 0x04000662 RID: 1634
	public ActivateType Name;

	// Token: 0x04000663 RID: 1635
	public int Amount;

	// Token: 0x04000664 RID: 1636
	public float Duration;

	// Token: 0x04000665 RID: 1637
	public float Range;

	// Token: 0x04000666 RID: 1638
	public StatsTypeEnum Stat;

	public enum ActivateType
	{
		// Token: 0x04000652 RID: 1618
		BoostRange,
		// Token: 0x04000653 RID: 1619
		BulletCreate,
		// Token: 0x04000654 RID: 1620
		BulletNova,
		// Token: 0x04000655 RID: 1621
		ChangeObject,
		// Token: 0x04000656 RID: 1622
		ClearConditionEffectAura,
		// Token: 0x04000657 RID: 1623
		ClearConditionEffectSelf,
		// Token: 0x04000658 RID: 1624
		ConditionEffectAura,
		// Token: 0x04000659 RID: 1625
		ConditionEffectSelf,
		// Token: 0x0400065A RID: 1626
		Create,
		// Token: 0x0400065B RID: 1627
		CreateBag,
		// Token: 0x0400065C RID: 1628
		CreatePet,
		// Token: 0x0400065D RID: 1629
		CreatePortal,
		// Token: 0x0400065E RID: 1630
		DazeBlast,
		// Token: 0x0400065F RID: 1631
		Decoy,
		// Token: 0x04000660 RID: 1632
		Dye,
		// Token: 0x04000661 RID: 1633
		Exchange,
		// Token: 0x04000662 RID: 1634
		GenericActivate,
		// Token: 0x04000663 RID: 1635
		GroupTransform,
		// Token: 0x04000664 RID: 1636
		Heal,
		// Token: 0x04000665 RID: 1637
		HealNova,
		// Token: 0x04000666 RID: 1638
		IncrementStat,
		// Token: 0x04000667 RID: 1639
		KillRealmHeroes,
		// Token: 0x04000668 RID: 1640
		LevelTwenty,
		// Token: 0x04000669 RID: 1641
		Lightning,
		// Token: 0x0400066A RID: 1642
		Magic,
		// Token: 0x0400066B RID: 1643
		MagicNova,
		// Token: 0x0400066C RID: 1644
		MarkAndTeleport,
		// Token: 0x0400066D RID: 1645
		MysteryDyes,
		// Token: 0x0400066E RID: 1646
		MysteryPortal,
		// Token: 0x0400066F RID: 1647
		ObjectToss,
		// Token: 0x04000670 RID: 1648
		PermaPet,
		// Token: 0x04000671 RID: 1649
		Pet,
		// Token: 0x04000672 RID: 1650
		PoisonGrenade,
		// Token: 0x04000673 RID: 1651
		RemoveNegativeConditions,
		// Token: 0x04000674 RID: 1652
		RemoveNegativeConditionsSelf,
		// Token: 0x04000675 RID: 1653
		SelfTransform,
		// Token: 0x04000676 RID: 1654
		Shoot,
		// Token: 0x04000677 RID: 1655
		ShurikenAbility,
		// Token: 0x04000678 RID: 1656
		StasisBlast,
		// Token: 0x04000679 RID: 1657
		StatBoostAura,
		// Token: 0x0400067A RID: 1658
		StatBoostSelf,
		// Token: 0x0400067B RID: 1659
		Teleport,
		// Token: 0x0400067C RID: 1660
		TeleportToObject,
		// Token: 0x0400067D RID: 1661
		Trap,
		// Token: 0x0400067E RID: 1662
		Unlock,
		// Token: 0x0400067F RID: 1663
		UnlockPetSkin,
		// Token: 0x04000680 RID: 1664
		UnlockPortal,
		// Token: 0x04000681 RID: 1665
		UnlockSkin,
		// Token: 0x04000682 RID: 1666
		VampireBlast
	}
}
