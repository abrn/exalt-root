using System;
using System.Linq;
using ExaltMultiTool.Properties;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x020000AD RID: 173
internal class AutoLoot
{
	// Token: 0x060004A2 RID: 1186 RVA: 0x00019E14 File Offset: 0x00018014
	public AutoLoot(Client client)
	{
		this._W6Ov6AArxzTTDnCyBtZPqkqNaKf = client;
	}

	// Token: 0x060004A3 RID: 1187 RVA: 0x00019E54 File Offset: 0x00018054
	public void MapInfo(MapInfoPacket mapInfo)
	{
		this._x8UCF6oGIzro7GNArSjf2KekKElA = mapInfo._Jp3DtIV4aAYZY26sVsXpPQjBRGO.ToLower().Contains("vault");
	}

	// Token: 0x060004A4 RID: 1188 RVA: 0x00019E7C File Offset: 0x0001807C
	public void _FMTVFcTfzNRteqoB3XiUkaNps7l(_6lHFncsY9352Wg3pNnnFZ49g5xA questObjId)
	{
		this._Gf5dMMvKN7GRcuWlZy0DgsGYZNl = questObjId._605Ligxeaj9k9kBV8zQhhFhgTGl;
	}

	// Token: 0x060004A5 RID: 1189 RVA: 0x00019E98 File Offset: 0x00018098
	public void Update(UpdatePacket update)
	{
		if (this._MJpN7Atb8LHnN3a2rImtRe9TMXG != -1 && update.Drops.Contains(this._MJpN7Atb8LHnN3a2rImtRe9TMXG))
		{
			this._MJpN7Atb8LHnN3a2rImtRe9TMXG = -1;
			if (this._Gf5dMMvKN7GRcuWlZy0DgsGYZNl != -1)
			{
				_6lHFncsY9352Wg3pNnnFZ49g5xA 6lHFncsY9352Wg3pNnnFZ49g5xA = (_6lHFncsY9352Wg3pNnnFZ49g5xA)Packet.Create(PacketType.QUESTOBJID);
				6lHFncsY9352Wg3pNnnFZ49g5xA._605Ligxeaj9k9kBV8zQhhFhgTGl = this._Gf5dMMvKN7GRcuWlZy0DgsGYZNl;
				6lHFncsY9352Wg3pNnnFZ49g5xA._4jOLjW4f3NFdoiR8aTchgxYgk8f = new int[0];
				this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._kvmVQCSv0IPpfwbLqfubIJw3s3C(6lHFncsY9352Wg3pNnnFZ49g5xA);
			}
		}
		if (Settings.Default.AutoLootBigBags)
		{
			foreach (Entity eTOyUHUGABMgTlUf3FUyHRn1uVv in update.NewObjs)
			{
				if (Enum.IsDefined(typeof(Bags), eTOyUHUGABMgTlUf3FUyHRn1uVv._koPitlGqCPegcnIS2B6efWzp4zO))
				{
					foreach (StatData eawaZQvtvbptP3yFgHw8DNBicDZ in eTOyUHUGABMgTlUf3FUyHRn1uVv.Status.Data)
					{
						if (StatsType.Id(eawaZQvtvbptP3yFgHw8DNBicDZ.Id, StatsType._l5HAIp8OEZRguJkIVcZQDtTd8ME))
						{
							eawaZQvtvbptP3yFgHw8DNBicDZ.IntValue = 175;
						}
					}
				}
			}
		}
	}

	// Token: 0x060004A6 RID: 1190 RVA: 0x00019FB0 File Offset: 0x000181B0
	public void _ZHfjECn2B9JJHnVF67eBaO57JUp(_maJp2qic3r54gk5Eg1eeMowxvXh invSwap)
	{
		if (!Settings.Default.EnableAutoLoot)
		{
			return;
		}
		if (invSwap._Nx46RcGIU0H1BCGWaJXjN1ieopt - this._ioa1BEz5kduahxZE00RIeXhGz3r >= 500)
		{
			if (invSwap._ecyyaYf6RV1NPdHtzXFXLG5mpFA.objectId == this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.ObjectId && invSwap._ecyyaYf6RV1NPdHtzXFXLG5mpFA._uKGrcCaKPH5uzoPQhtn5OnB2jAL < this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player._myJxXFJcH1zIBkZMmXfDOvAh0vcA.Length)
			{
				this._PButw10oxkMNEfnc1xIwSTJXjvM = invSwap._ecyyaYf6RV1NPdHtzXFXLG5mpFA._uKGrcCaKPH5uzoPQhtn5OnB2jAL;
				this._VuC6GZtKUdzDpJMMx6SRUUCPBbM = this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player._myJxXFJcH1zIBkZMmXfDOvAh0vcA[invSwap._ecyyaYf6RV1NPdHtzXFXLG5mpFA._uKGrcCaKPH5uzoPQhtn5OnB2jAL];
				this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player._myJxXFJcH1zIBkZMmXfDOvAh0vcA[invSwap._ecyyaYf6RV1NPdHtzXFXLG5mpFA._uKGrcCaKPH5uzoPQhtn5OnB2jAL] = invSwap._ecyyaYf6RV1NPdHtzXFXLG5mpFA.ObjectType;
			}
			else if (invSwap._R1rVnNom2O6z6ToODjdI248Gp3O.objectId == this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.ObjectId)
			{
				if (invSwap._R1rVnNom2O6z6ToODjdI248Gp3O._uKGrcCaKPH5uzoPQhtn5OnB2jAL < this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player._myJxXFJcH1zIBkZMmXfDOvAh0vcA.Length)
				{
					this._PButw10oxkMNEfnc1xIwSTJXjvM = invSwap._R1rVnNom2O6z6ToODjdI248Gp3O._uKGrcCaKPH5uzoPQhtn5OnB2jAL;
					this._VuC6GZtKUdzDpJMMx6SRUUCPBbM = this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player._myJxXFJcH1zIBkZMmXfDOvAh0vcA[invSwap._R1rVnNom2O6z6ToODjdI248Gp3O._uKGrcCaKPH5uzoPQhtn5OnB2jAL];
					this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player._myJxXFJcH1zIBkZMmXfDOvAh0vcA[invSwap._R1rVnNom2O6z6ToODjdI248Gp3O._uKGrcCaKPH5uzoPQhtn5OnB2jAL] = invSwap._R1rVnNom2O6z6ToODjdI248Gp3O.ObjectType;
				}
			}
		}
		else
		{
			invSwap.Send = false;
			Console.WriteLine("Canceled invswap!");
		}
		this._ioa1BEz5kduahxZE00RIeXhGz3r = invSwap._Nx46RcGIU0H1BCGWaJXjN1ieopt;
	}

	// Token: 0x060004A7 RID: 1191 RVA: 0x0001A12C File Offset: 0x0001832C
	public void _yOjSn1WKSXsXVziJpL1eH5gSoWg(_6UIiGxMChbVinHsvx5uqg8WrMRc invResult)
	{
		if (Settings.Default.EnableAutoLoot && !invResult._9WVS8mgAGMXsp1FYvKoly56WY1E && this._PButw10oxkMNEfnc1xIwSTJXjvM > -1)
		{
			this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player._myJxXFJcH1zIBkZMmXfDOvAh0vcA[this._PButw10oxkMNEfnc1xIwSTJXjvM] = this._VuC6GZtKUdzDpJMMx6SRUUCPBbM;
			Console.WriteLine("Client: Swap failed");
		}
	}

	// Token: 0x060004A8 RID: 1192 RVA: 0x0001A180 File Offset: 0x00018380
	public void move(MovePacket move)
	{
		if (Settings.Default.EnableAutoLoot && !this._x8UCF6oGIzro7GNArSjf2KekKElA)
		{
			foreach (GameObject dbvvb43n9c5uNQ7JklPD1fnCEnv in this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Objects.Values.ToList<GameObject>())
			{
				if (Enum.IsDefined(typeof(Bags), dbvvb43n9c5uNQ7JklPD1fnCEnv.ObjectType))
				{
					byte b = 0;
					while ((int)b < dbvvb43n9c5uNQ7JklPD1fnCEnv._myJxXFJcH1zIBkZMmXfDOvAh0vcA.Length)
					{
						int num = dbvvb43n9c5uNQ7JklPD1fnCEnv._myJxXFJcH1zIBkZMmXfDOvAh0vcA[(int)b];
						if (num != -1)
						{
							if (this._JgBnDNlAeZCF5w89wZQAiaFkkpr((ushort)num))
							{
								if (Settings.Default.AutoLootQuests)
								{
									_6lHFncsY9352Wg3pNnnFZ49g5xA 6lHFncsY9352Wg3pNnnFZ49g5xA = (_6lHFncsY9352Wg3pNnnFZ49g5xA)Packet.Create(PacketType.QUESTOBJID);
									6lHFncsY9352Wg3pNnnFZ49g5xA._605Ligxeaj9k9kBV8zQhhFhgTGl = dbvvb43n9c5uNQ7JklPD1fnCEnv.ObjectId;
									6lHFncsY9352Wg3pNnnFZ49g5xA._4jOLjW4f3NFdoiR8aTchgxYgk8f = new int[0];
									this._MJpN7Atb8LHnN3a2rImtRe9TMXG = dbvvb43n9c5uNQ7JklPD1fnCEnv.ObjectId;
									this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._kvmVQCSv0IPpfwbLqfubIJw3s3C(6lHFncsY9352Wg3pNnnFZ49g5xA);
								}
								if (dbvvb43n9c5uNQ7JklPD1fnCEnv.ServerPosition.DistanceSquaredTo(move._l6SobSknmpzcoMgQdVhaWNqcv8D) <= 1.0)
								{
									if (move._Nx46RcGIU0H1BCGWaJXjN1ieopt - this._ioa1BEz5kduahxZE00RIeXhGz3r > 600)
									{
										this._3ZPa2PpogMBGSlmtovhlwZFJ9NC(move._l6SobSknmpzcoMgQdVhaWNqcv8D, move._Nx46RcGIU0H1BCGWaJXjN1ieopt, dbvvb43n9c5uNQ7JklPD1fnCEnv.ObjectId, num, b);
									}
									return;
								}
							}
						}
						b += 1;
					}
				}
			}
			return;
		}
	}

	// Token: 0x060004A9 RID: 1193 RVA: 0x0001A2F8 File Offset: 0x000184F8
	private void _3ZPa2PpogMBGSlmtovhlwZFJ9NC(Location pos, int time, int bagObjectId, int targetType, byte slotId)
	{
		if (targetType == 2594 && this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player._r4Xq85xV6nMTyHoC0hk90XNlu5q < 6)
		{
			this._ZHfjECn2B9JJHnVF67eBaO57JUp(time, pos, bagObjectId, targetType, slotId, this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player.ObjectId, -1, 254, _JzyrOApzC09RC3fmb10FDURmyCl.Items.ByID((ushort)targetType).Name);
			return;
		}
		if (targetType == 2595 && this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player._TVtbKb9IDpIOm44EVAA4vhHuEBL < 6)
		{
			this._ZHfjECn2B9JJHnVF67eBaO57JUp(time, pos, bagObjectId, targetType, slotId, this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player.ObjectId, -1, byte.MaxValue, _JzyrOApzC09RC3fmb10FDURmyCl.Items.ByID((ushort)targetType).Name);
			return;
		}
		int num = this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player._i1wpxbN1B15L7vPjaWvObujwWOB ? 20 : 12;
		byte b = 4;
		while ((int)b < num)
		{
			if (this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player._myJxXFJcH1zIBkZMmXfDOvAh0vcA[(int)b] == -1)
			{
				this._ZHfjECn2B9JJHnVF67eBaO57JUp(time, pos, this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player.ObjectId, -1, b, bagObjectId, targetType, slotId, _JzyrOApzC09RC3fmb10FDURmyCl.Items.ByID((ushort)targetType).Name);
				return;
			}
			b += 1;
		}
	}

	// Token: 0x060004AA RID: 1194 RVA: 0x0001A418 File Offset: 0x00018618
	private void _ZHfjECn2B9JJHnVF67eBaO57JUp(int time, Location position, int objectId1, int itemType1, byte slotId1, int objectId2, int itemType2, byte slotId2, string itemName)
	{
		_maJp2qic3r54gk5Eg1eeMowxvXh maJp2qic3r54gk5Eg1eeMowxvXh = (_maJp2qic3r54gk5Eg1eeMowxvXh)Packet.Create(PacketType.INVSWAP);
		maJp2qic3r54gk5Eg1eeMowxvXh._Nx46RcGIU0H1BCGWaJXjN1ieopt = time;
		maJp2qic3r54gk5Eg1eeMowxvXh._MkT06oCYgDubgW2NbEOzvLh8RLe = position;
		maJp2qic3r54gk5Eg1eeMowxvXh._ecyyaYf6RV1NPdHtzXFXLG5mpFA = new _A3HGGdSvVENqKj3O1HGYDO3Qh8C
		{
			objectId = objectId1,
			ObjectType = itemType1,
			_uKGrcCaKPH5uzoPQhtn5OnB2jAL = (int)slotId1
		};
		maJp2qic3r54gk5Eg1eeMowxvXh._R1rVnNom2O6z6ToODjdI248Gp3O = new _A3HGGdSvVENqKj3O1HGYDO3Qh8C
		{
			objectId = objectId2,
			ObjectType = itemType2,
			_uKGrcCaKPH5uzoPQhtn5OnB2jAL = (int)slotId2
		};
		this._ioa1BEz5kduahxZE00RIeXhGz3r = time;
		this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.SendToServer(maJp2qic3r54gk5Eg1eeMowxvXh);
		this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.SendToClient("AutoLoot", "Looting " + itemName);
	}

	// Token: 0x060004AB RID: 1195 RVA: 0x0001A4B4 File Offset: 0x000186B4
	private bool _JgBnDNlAeZCF5w89wZQAiaFkkpr(ushort itemId)
	{
		_66CXgP76qcRM5NMLzlNSbhfhXbG 66CXgP76qcRM5NMLzlNSbhfhXbG = _JzyrOApzC09RC3fmb10FDURmyCl.Items.ByID(itemId);
		if (66CXgP76qcRM5NMLzlNSbhfhXbG == null)
		{
			return false;
		}
		if (Settings.Default.AutoLootHealingPotions && 66CXgP76qcRM5NMLzlNSbhfhXbG._Jp3DtIV4aAYZY26sVsXpPQjBRGO == "Health Potion" && (Settings.Default.AutoLootOverfillHP || this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player._r4Xq85xV6nMTyHoC0hk90XNlu5q < 6))
		{
			return true;
		}
		if (Settings.Default.AutoLootHealingPotions && 66CXgP76qcRM5NMLzlNSbhfhXbG._Jp3DtIV4aAYZY26sVsXpPQjBRGO == "Magic Potion" && (Settings.Default.AutoLootOverfillMP || this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player._TVtbKb9IDpIOm44EVAA4vhHuEBL < 6))
		{
			return true;
		}
		if (Settings.Default.AutoLootStatPotions && AutoLoot._P39Ewd5t5oRhDMGPTfQqUmm9y7c.Contains(66CXgP76qcRM5NMLzlNSbhfhXbG._Jp3DtIV4aAYZY26sVsXpPQjBRGO))
		{
			return true;
		}
		if (Settings.Default.AutoLootUTs && 66CXgP76qcRM5NMLzlNSbhfhXbG._EasYH1zBgDZtaXhuG2mVF2bKxKu == _FvA2grK5CUVSLJHb7V5mXAgE1SA.UT)
		{
			if (66CXgP76qcRM5NMLzlNSbhfhXbG._nUppUQcAEeCO15B53eSIwjaZ8yK != 10)
			{
				if (66CXgP76qcRM5NMLzlNSbhfhXbG._nUppUQcAEeCO15B53eSIwjaZ8yK != 26)
				{
					return true;
				}
			}
		}
		if (Settings.Default.AutoLootMarks && 66CXgP76qcRM5NMLzlNSbhfhXbG._Jp3DtIV4aAYZY26sVsXpPQjBRGO.Contains("Mark of "))
		{
			return true;
		}
		switch (66CXgP76qcRM5NMLzlNSbhfhXbG._nUppUQcAEeCO15B53eSIwjaZ8yK)
		{
		case 1:
		case 2:
		case 3:
		case 8:
		case 17:
		case 24:
			return (int)66CXgP76qcRM5NMLzlNSbhfhXbG._EasYH1zBgDZtaXhuG2mVF2bKxKu >= Settings.Default.AutoLootWeaponTierThreshold;
		case 4:
		case 5:
		case 11:
		case 12:
		case 13:
		case 15:
		case 16:
		case 18:
		case 19:
		case 20:
		case 21:
		case 22:
		case 23:
		case 25:
		case 27:
			return (int)66CXgP76qcRM5NMLzlNSbhfhXbG._EasYH1zBgDZtaXhuG2mVF2bKxKu >= Settings.Default.AutoLootAbilityTierThreshold;
		case 6:
		case 7:
		case 14:
			return (int)66CXgP76qcRM5NMLzlNSbhfhXbG._EasYH1zBgDZtaXhuG2mVF2bKxKu >= Settings.Default.AutoLootArmorTierThreshold;
		case 9:
			return (int)66CXgP76qcRM5NMLzlNSbhfhXbG._EasYH1zBgDZtaXhuG2mVF2bKxKu >= Settings.Default.AutoLootRingTierThreshold;
		}
		return false;
	}

	// Token: 0x040005B7 RID: 1463
	private Client _W6Ov6AArxzTTDnCyBtZPqkqNaKf;

	// Token: 0x040005B8 RID: 1464
	private int _ioa1BEz5kduahxZE00RIeXhGz3r = -1;

	// Token: 0x040005B9 RID: 1465
	private bool _x8UCF6oGIzro7GNArSjf2KekKElA;

	// Token: 0x040005BA RID: 1466
	private int _PButw10oxkMNEfnc1xIwSTJXjvM = -1;

	// Token: 0x040005BB RID: 1467
	private int _VuC6GZtKUdzDpJMMx6SRUUCPBbM = -1;

	// Token: 0x040005BC RID: 1468
	private int _Gf5dMMvKN7GRcuWlZy0DgsGYZNl = -1;

	// Token: 0x040005BD RID: 1469
	private int _MJpN7Atb8LHnN3a2rImtRe9TMXG = -1;

	// Token: 0x040005BE RID: 1470
	private static readonly string[] _P39Ewd5t5oRhDMGPTfQqUmm9y7c = new string[]
	{
		"Mystery Stat Pot",
		"Potion of Life",
		"Potion of Mana",
		"Potion of Defense",
		"Potion of Speed",
		"Potion of Attack",
		"Potion of Dexterity",
		"Potion of Wisdom",
		"Potion of Vitality",
		"Potion of Life (SB)",
		"Potion of Mana (SB)",
		"Potion of Defense (SB)",
		"Potion of Speed (SB)",
		"Potion of Attack (SB)",
		"Potion of Dexterity (SB)",
		"Potion of Wisdom (SB)",
		"Potion of Vitality (SB)",
		"Greater Potion of Life",
		"Greater Potion of Mana",
		"Greater Potion of Defense",
		"Greater Potion of Speed",
		"Greater Potion of Attack",
		"Greater Potion of Dexterity",
		"Greater Potion of Wisdom",
		"Greater Potion of Vitality"
	};
}
