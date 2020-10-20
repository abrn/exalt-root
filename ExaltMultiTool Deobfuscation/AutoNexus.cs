using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExaltMultiTool.Properties;
using ExaltMultiTool.Proxy.DataStructures;
using ExaltMultiTool.Proxy.Mods;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x020000AE RID: 174
internal class AutoNexus
{
	// Token: 0x060004AD RID: 1197 RVA: 0x0001A78C File Offset: 0x0001898C
	public AutoNexus(Client client)
	{
	}

	// Token: 0x060004AE RID: 1198 RVA: 0x0001A8C8 File Offset: 0x00018AC8
	private void _Pf0ENnaHZFebNxSceKLAdKBflRcA(int damage, string source = "Unknown")
	{
		this._Hw75pbsTTalpiL9BLfm1eA0YOFK = true;
		if (Settings.Default.AutoNexusShowInformation)
		{
			int num = this._wIV6RuTHp6K14hjsabfqulJm6RB * 100 / this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._50Ms1zsqax9Ua48PaWMPQfIENYb._hI9BnQSXNqD191WGfzaqXuLrtAm;
			this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._mwjcQHLef7XHbndcINL6ltoY3vmb("AutoNexus", string.Concat(new string[]
			{
				"AutoNexused at ",
				num.ToString(),
				"% HP\nSource: ",
				damage.ToString(),
				" ",
				source
			}));
		}
		Console.WriteLine("Autonexusing from " + source + ", " + damage.ToString());
		this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._kvmVQCSv0IPpfwbLqfubIJw3s3C(this._awssO9iABhEDJrqUB4tmDrMK9kh());
		this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._7uxLEqPg6T4dttVtkm2zilX7Qji((EscapePacket)Packet.Create(PacketType.ESCAPE));
	}

	// Token: 0x060004AF RID: 1199 RVA: 0x0001A994 File Offset: 0x00018B94
	private ReconnectPacket _awssO9iABhEDJrqUB4tmDrMK9kh()
	{
		ReconnectPacket u9Kj4tAStSlt3Dcm6rdEl60w8MG = (ReconnectPacket)Packet.Create(PacketType.RECONNECT);
		u9Kj4tAStSlt3Dcm6rdEl60w8MG.Host = "";
		u9Kj4tAStSlt3Dcm6rdEl60w8MG.Port = 2050;
		u9Kj4tAStSlt3Dcm6rdEl60w8MG.Name = "Nexus";
		u9Kj4tAStSlt3Dcm6rdEl60w8MG.Key = new byte[0];
		u9Kj4tAStSlt3Dcm6rdEl60w8MG.KeyTime = 0;
		u9Kj4tAStSlt3Dcm6rdEl60w8MG.State = "";
		u9Kj4tAStSlt3Dcm6rdEl60w8MG.GameId = -2;
		u9Kj4tAStSlt3Dcm6rdEl60w8MG.isFromArena = false;
		return u9Kj4tAStSlt3Dcm6rdEl60w8MG;
	}

	// Token: 0x060004B0 RID: 1200 RVA: 0x0001AA00 File Offset: 0x00018C00
	public void MapInfo(MapInfoPacket mapInfo)
	{
		this._2quYVWYoLc77QY6uJhajp7qBEFF = this._D0ydY92aMnivKXLmhWYnzjIuo7b.Contains(mapInfo.Name);
		this._L4etETbJCIQekDr3Sm4dM67NyC = (mapInfo.Name == "Ocean Trench");
		this._KgvAv7C8BPHRhNGaBUY9WAoRFFU = null;
		this._wIV6RuTHp6K14hjsabfqulJm6RB = 100;
		this._dTFvDKmJDtcJzyy5wFAsDubOP2x = 100;
		this._OheNBC1f5drFNP8lJ3bZoDVuSKv = 0;
		this._UorlUPPYrMfEq3JgqJC3zM4wIwf = false;
		this._GKvDpEvGICPwzQQpBmeSSrSA0Ut = int.MaxValue;
		this._6HhWgr0VLGFSNUy8ZkAyxO8zznB.Clear();
		this._AMQrd56F3iBO7prif4hznTC4y5A.Clear();
	}

	// Token: 0x060004B1 RID: 1201 RVA: 0x0001AA80 File Offset: 0x00018C80
	public void _qQsqaOxgCR9yg9ky7erATaKrgCC(DeathPacket death)
	{
		Console.WriteLine(string.Format("We died at {0} health, when nexusing at {1}% ({2} hp)! {3}", new object[]
		{
			this._wIV6RuTHp6K14hjsabfqulJm6RB.ToString(),
			Settings.Default.AutoNexusPercentageThreshold.ToString(),
			this._jWMYX8VJLB8QB7nBQBQJn0c1btJ.ToString(),
			death
		}));
	}

	// Token: 0x060004B2 RID: 1202 RVA: 0x0001AAD8 File Offset: 0x00018CD8
	public void Update(UpdatePacket update)
	{
		foreach (Entity eTOyUHUGABMgTlUf3FUyHRn1uVv in update.NewObjs)
		{
			if (eTOyUHUGABMgTlUf3FUyHRn1uVv.Status.ObjectId == this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._7w6u8taiwfZruB2OdFEa2AmzJaA)
			{
				this._BwUEkSS32j3v8tc5v3r4RiE6eiD(eTOyUHUGABMgTlUf3FUyHRn1uVv.Status, true);
			}
			if (!this._6HhWgr0VLGFSNUy8ZkAyxO8zznB.ContainsKey(eTOyUHUGABMgTlUf3FUyHRn1uVv.Status.ObjectId))
			{
				this._6HhWgr0VLGFSNUy8ZkAyxO8zznB.Add(eTOyUHUGABMgTlUf3FUyHRn1uVv.Status.ObjectId, eTOyUHUGABMgTlUf3FUyHRn1uVv.ObjectType);
			}
		}
	}

	// Token: 0x060004B3 RID: 1203 RVA: 0x0001AB5C File Offset: 0x00018D5C
	public void NewTick(NewTickPacket newTick)
	{
		foreach (Status seOURj9wT08Ssc6bZOctUjk0KXi in newTick.Statuses)
		{
			if (seOURj9wT08Ssc6bZOctUjk0KXi.ObjectId == this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._7w6u8taiwfZruB2OdFEa2AmzJaA)
			{
				this._BwUEkSS32j3v8tc5v3r4RiE6eiD(seOURj9wT08Ssc6bZOctUjk0KXi, false);
				break;
			}
		}
		this._L9Sq7ilWPAc2XkNbriRGfXQBoeh();
	}

	// Token: 0x060004B4 RID: 1204 RVA: 0x0001ABD0 File Offset: 0x00018DD0
	private void _BwUEkSS32j3v8tc5v3r4RiE6eiD(Status status, bool fromUpdate = false)
	{
		bool flag = false;
		foreach (StatData eawaZQvtvbptP3yFgHw8DNBicDZ in status.Data)
		{
			if (StatsType.Id(eawaZQvtvbptP3yFgHw8DNBicDZ.Id, StatsType.HP))
			{
				if (fromUpdate)
				{
					this._wIV6RuTHp6K14hjsabfqulJm6RB = eawaZQvtvbptP3yFgHw8DNBicDZ.IntValue;
					this._MrinDQL27mmJE4svfljIZVv3O7b(eawaZQvtvbptP3yFgHw8DNBicDZ.IntValue);
				}
				this._dTFvDKmJDtcJzyy5wFAsDubOP2x = eawaZQvtvbptP3yFgHw8DNBicDZ.IntValue;
			}
			else if (!StatsType.Id(eawaZQvtvbptP3yFgHw8DNBicDZ.Id, StatsType._DVNBi2eQHLdmlmNyYH05WDcfCzq))
			{
				if (!StatsType.Id(eawaZQvtvbptP3yFgHw8DNBicDZ.Id, StatsType.Inventory1))
				{
					if (StatsType.Id(eawaZQvtvbptP3yFgHw8DNBicDZ.Id, StatsType.HealthBonus))
					{
						flag = true;
					}
					else if (!StatsType.Id(eawaZQvtvbptP3yFgHw8DNBicDZ.Id, StatsType.Effects))
					{
						if (StatsType.Id(eawaZQvtvbptP3yFgHw8DNBicDZ.Id, StatsType.Effects2))
						{
							this._ebyfk31Ab9aj569ppNj1fwNxyUG = ((eawaZQvtvbptP3yFgHw8DNBicDZ.IntValue & 536870912) == 536870912);
						}
					}
					else if ((eawaZQvtvbptP3yFgHw8DNBicDZ.IntValue & 67108864) != 0)
					{
						this._UorlUPPYrMfEq3JgqJC3zM4wIwf = false;
					}
				}
				else if (this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._50Ms1zsqax9Ua48PaWMPQfIENYb._koPitlGqCPegcnIS2B6efWzp4zO == 799)
				{
					this._T1pUOttbRRz7ku5YCPysaK7ODuE(eawaZQvtvbptP3yFgHw8DNBicDZ.IntValue);
				}
			}
			else
			{
				this._MrinDQL27mmJE4svfljIZVv3O7b(eawaZQvtvbptP3yFgHw8DNBicDZ.IntValue);
			}
		}
		if (flag)
		{
			this._PAhfVkixgGie7An1LzLMAKuPLECA();
		}
		if (this._y197qHnAdnQHPqX30R0Bq0tjIOcA - this._GKvDpEvGICPwzQQpBmeSSrSA0Ut > 700)
		{
			this._UorlUPPYrMfEq3JgqJC3zM4wIwf = false;
		}
	}

	// Token: 0x060004B5 RID: 1205 RVA: 0x0001AD5C File Offset: 0x00018F5C
	public void move(MovePacket move)
	{
		if (move.TickId == 0)
		{
			this._y197qHnAdnQHPqX30R0Bq0tjIOcA = move._Nx46RcGIU0H1BCGWaJXjN1ieopt;
			this._9uQC3m47mudh1sCSmEtgs0EPXSo(move._Nx46RcGIU0H1BCGWaJXjN1ieopt, 0, move.NewPosition);
		}
		else
		{
			this._9uQC3m47mudh1sCSmEtgs0EPXSo(move._Nx46RcGIU0H1BCGWaJXjN1ieopt, move._Nx46RcGIU0H1BCGWaJXjN1ieopt - this._y197qHnAdnQHPqX30R0Bq0tjIOcA, move.NewPosition);
			this._y197qHnAdnQHPqX30R0Bq0tjIOcA = move._Nx46RcGIU0H1BCGWaJXjN1ieopt;
		}
		this._0qPs3ICAiKqEpockvHdkXyWtLLK = move.NewPosition;
	}

	// Token: 0x060004B6 RID: 1206 RVA: 0x0001ADCC File Offset: 0x00018FCC
	public void _4GSfC8bADOwIwOXLYze8EOUBQxJ(NotificationPacket notification)
	{
		if (notification._605Ligxeaj9k9kBV8zQhhFhgTGl != this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._7w6u8taiwfZruB2OdFEa2AmzJaA)
		{
			return;
		}
		if (notification._V9wbtwgSRDH0SCM4qu3SlALEWXF.Contains("server.plus_symbol"))
		{
			if (notification._DFCaX26LcGoemsDXfEoR4O7im9r == 65280)
			{
				string[] array = notification._V9wbtwgSRDH0SCM4qu3SlALEWXF.Split(new string[]
				{
					"\"amount\":\""
				}, StringSplitOptions.RemoveEmptyEntries);
				if (array.Length != 2)
				{
					Console.WriteLine("Malformed notification message: " + notification._V9wbtwgSRDH0SCM4qu3SlALEWXF);
					return;
				}
				string[] array2 = array[1].Split(new string[]
				{
					"\"}}"
				}, StringSplitOptions.RemoveEmptyEntries);
				if (array2.Length != 1)
				{
					Console.WriteLine("Malformed notification message: " + notification._V9wbtwgSRDH0SCM4qu3SlALEWXF);
					return;
				}
				int amount;
				if (!int.TryParse(array2[0], out amount))
				{
					Console.WriteLine("Malformed notification message: " + notification._V9wbtwgSRDH0SCM4qu3SlALEWXF);
					return;
				}
				this._Ac6nTGaucsLc0qgHVNdx4vdDNGY(amount, "Notif Heal");
			}
		}
	}

	// Token: 0x060004B7 RID: 1207 RVA: 0x0001AEB0 File Offset: 0x000190B0
	public void _ZHfjECn2B9JJHnVF67eBaO57JUp(InvSwapPacket invSwap)
	{
		if (invSwap.SlotObject1.objectId == this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._7w6u8taiwfZruB2OdFEa2AmzJaA)
		{
			if (invSwap.SlotObject1.SlotId == 1)
			{
				this._T1pUOttbRRz7ku5YCPysaK7ODuE(invSwap.SlotObject2.ObjectType);
			}
		}
		if (invSwap.SlotObject2.objectId == this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._7w6u8taiwfZruB2OdFEa2AmzJaA)
		{
			if (invSwap.SlotObject2.SlotId == 1)
			{
				this._T1pUOttbRRz7ku5YCPysaK7ODuE(invSwap.SlotObject1.ObjectType);
			}
		}
	}

	// Token: 0x060004B8 RID: 1208 RVA: 0x0001AF30 File Offset: 0x00019130
	public void _1nwhQXngJ6rNjd7Ufx1bWeF0vhM(ShowEffectPacket showEffect)
	{
		if (!this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._aJjNVtwA8oe4lWrzJfpazHqj9A2.ContainsKey(showEffect.TargetId))
		{
			return;
		}
		GameObject dbvvb43n9c5uNQ7JklPD1fnCEnv = this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._aJjNVtwA8oe4lWrzJfpazHqj9A2[showEffect.TargetId];
		if (dbvvb43n9c5uNQ7JklPD1fnCEnv.ObjectType == 799 || dbvvb43n9c5uNQ7JklPD1fnCEnv.ObjectType == 797)
		{
			if (dbvvb43n9c5uNQ7JklPD1fnCEnv.ObjectType == 799 && !AutoNexus._4HVpBFqtCWjgYDd06ijku36wpTl(showEffect.Color, 16711680))
			{
				return;
			}
			int num = this._wmYfEcnzJZHUMf6TmaRnx4oPoiG(showEffect.TargetId);
			if (num != 0 && !this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._50Ms1zsqax9Ua48PaWMPQfIENYb._PaME7E91qS83Dt2dp6ptMCHxaAu())
			{
				this._aHKs49K4OBGbC8YIpcXr4eOw2ei(num);
			}
		}
	}

	// Token: 0x060004B9 RID: 1209 RVA: 0x0001AFD0 File Offset: 0x000191D0
	public void _M1PxW31jx87SGG4gvOYAwe86vjg(AoEPacket aoe)
	{
		this._AMQrd56F3iBO7prif4hznTC4y5A.Add(new _7kZ0X7cJVyJ4MZi00zDEPWadmiH(aoe));
	}

	// Token: 0x060004BA RID: 1210 RVA: 0x0001AFF0 File Offset: 0x000191F0
	public void _iKqf12lpU2ifSlxUxUegqEC5CVe(AoEAckPacket aoeAck)
	{
		if (this._Hw75pbsTTalpiL9BLfm1eA0YOFK)
		{
			aoeAck.Send = false;
		}
		this._0qPs3ICAiKqEpockvHdkXyWtLLK = aoeAck.Pos;
		foreach (_7kZ0X7cJVyJ4MZi00zDEPWadmiH 7kZ0X7cJVyJ4MZi00zDEPWadmiH in this._AMQrd56F3iBO7prif4hznTC4y5A)
		{
			if (this._0qPs3ICAiKqEpockvHdkXyWtLLK._lEH5A8k6GZhNzOJciwld9Bb4RqP(7kZ0X7cJVyJ4MZi00zDEPWadmiH._v9pyCwpTOdm9mtxft8q4OoLOE3B) < (double)7kZ0X7cJVyJ4MZi00zDEPWadmiH._Vzv7oRwBjKStnFVmjJ1K02kmfeb)
			{
				string str = string.Format("(Type: {0})", 7kZ0X7cJVyJ4MZi00zDEPWadmiH._KAKiJQlm5UYoc2K2Kaz3qKefgXA);
				ObjectStructure objectStructure = _JzyrOApzC09RC3fmb10FDURmyCl.Objects._VoD2o9blcwqcx7hMw7WQQNbE28(7kZ0X7cJVyJ4MZi00zDEPWadmiH._KAKiJQlm5UYoc2K2Kaz3qKefgXA);
				if (objectStructure != null)
				{
					str = objectStructure._ikFKebqGeYDppnRN94BtlHzztCC<System.UInt16>._Jp3DtIV4aAYZY26sVsXpPQjBRGO;
				}
				this._Qkocwb8McbBzbTY7woKcuOjrC0(this._J8MwnexgOmgIB8O2UFl3jAf56PH(7kZ0X7cJVyJ4MZi00zDEPWadmiH._Q1PiJQ99KBCJeLcZ0HOk3AUAjIP, this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._50Ms1zsqax9Ua48PaWMPQfIENYb._I8uQpaQw1Wx940p3k48AjKZWpuM, 7kZ0X7cJVyJ4MZi00zDEPWadmiH._cOOwLggepjcumTMmHiNjo8G61wH), "AoE damage (" + str + ")");
			}
		}
		this._AMQrd56F3iBO7prif4hznTC4y5A.Clear();
	}

	// Token: 0x060004BB RID: 1211 RVA: 0x0001B0EC File Offset: 0x000192EC
	public void _524YRDmz9HCOj575eu5oeD5ruJb(GroundDamagePacket groundDamage)
	{
		if (this._Hw75pbsTTalpiL9BLfm1eA0YOFK)
		{
			groundDamage.Send = false;
		}
		Square q3lhvRoGxDHbe4DHt5QEvG37i6dA = this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._fuF7NYMFFzBrq5FBvTs4MvKbrW(groundDamage.Position);
		if (q3lhvRoGxDHbe4DHt5QEvG37i6dA != null)
		{
			this._Qkocwb8McbBzbTY7woKcuOjrC0((int)q3lhvRoGxDHbe4DHt5QEvG37i6dA.Tile.MaxDamage, "Ground damage (" + q3lhvRoGxDHbe4DHt5QEvG37i6dA.Tile._ikFKebqGeYDppnRN94BtlHzztCC<System.UInt16>._Jp3DtIV4aAYZY26sVsXpPQjBRGO + ")");
			return;
		}
		Console.WriteLine(string.Format("Null tile at {0} when taking GroundDamage", groundDamage.Position));
		this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._mwjcQHLef7XHbndcINL6ltoY3vmb("AutoNexus", "Took ground damage from an unknown source, autonexus may not be fully functional!");
	}

	// Token: 0x060004BC RID: 1212 RVA: 0x0001B174 File Offset: 0x00019374
	public void PlayerHit(PlayerHitPacket playerHit)
	{
		if (this._Hw75pbsTTalpiL9BLfm1eA0YOFK)
		{
			playerHit.Send = false;
		}
		string str = playerHit.ObjectId.ToString();
		if (this._6HhWgr0VLGFSNUy8ZkAyxO8zznB.ContainsKey(playerHit.ObjectId))
		{
			str = _JzyrOApzC09RC3fmb10FDURmyCl.Objects._VoD2o9blcwqcx7hMw7WQQNbE28(this._6HhWgr0VLGFSNUy8ZkAyxO8zznB[playerHit.ObjectId])._ikFKebqGeYDppnRN94BtlHzztCC<System.UInt16>._Jp3DtIV4aAYZY26sVsXpPQjBRGO;
		}
		if (!this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._Ani0JV9AEtv593Gb1nTnVgkYqML.ContainsKey(playerHit.ObjectId))
		{
			Console.WriteLine("We got hit by a shot that is not logged, owner: " + str + ", bid: " + playerHit.BulletId.ToString());
			this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._mwjcQHLef7XHbndcINL6ltoY3vmb("AutoNexus", "Took projectile damage from an unknown source, autonexus may not be fully functional!");
			return;
		}
		Dictionary<int, Projectile> dictionary = this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._Ani0JV9AEtv593Gb1nTnVgkYqML[playerHit.ObjectId];
		if (dictionary.ContainsKey((int)playerHit.BulletId))
		{
			Projectile projectile = dictionary[(int)playerHit.BulletId];
			bool armorPierce = Projectile.IsPiercing((int)this._6HhWgr0VLGFSNUy8ZkAyxO8zznB[projectile.OwnerId], projectile.ProjectileType);
			int amount = this._J8MwnexgOmgIB8O2UFl3jAf56PH((ushort)projectile.Damage, this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._50Ms1zsqax9Ua48PaWMPQfIENYb._I8uQpaQw1Wx940p3k48AjKZWpuM, armorPierce);
			if (Projectile.IsArmorBreaking((int)this._6HhWgr0VLGFSNUy8ZkAyxO8zznB[projectile.OwnerId], projectile.ProjectileType))
			{
				this._UorlUPPYrMfEq3JgqJC3zM4wIwf = true;
				this._GKvDpEvGICPwzQQpBmeSSrSA0Ut = this._y197qHnAdnQHPqX30R0Bq0tjIOcA;
			}
			this._Qkocwb8McbBzbTY7woKcuOjrC0(amount, "Projectile damage (" + str + ")");
		}
	}

	// Token: 0x060004BD RID: 1213 RVA: 0x0001B2DC File Offset: 0x000194DC
	private int _J8MwnexgOmgIB8O2UFl3jAf56PH(ushort originalDamage, int playerDefense, bool armorPierce)
	{
		int num = playerDefense;
		if (!armorPierce && !this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._50Ms1zsqax9Ua48PaWMPQfIENYb._oXsCK7yO7qJB1FLXQSIQngK4drY() && !this._UorlUPPYrMfEq3JgqJC3zM4wIwf)
		{
			if (this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._50Ms1zsqax9Ua48PaWMPQfIENYb._cPWvaf8DndobPySrTOml9uL6DAY())
			{
				num *= 2;
			}
		}
		else
		{
			num = 0;
		}
		if (this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._50Ms1zsqax9Ua48PaWMPQfIENYb._cINym90PMnmRaoXIKD1nK8pqHYR())
		{
			num -= 20;
		}
		double val = (double)originalDamage * 0.15;
		double val2 = (double)((int)originalDamage - num);
		double num2 = (double)((int)Math.Max(val, val2));
		if (this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._50Ms1zsqax9Ua48PaWMPQfIENYb._V9sexWGjUomNGkbTZsOsc8ZyOSC())
		{
			num2 = 0.0;
		}
		if (this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._50Ms1zsqax9Ua48PaWMPQfIENYb._dEiUEywXA9bOApweAxlbLqIezsn())
		{
			num2 = (double)((int)(num2 * 0.9));
		}
		if (this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._50Ms1zsqax9Ua48PaWMPQfIENYb._P9AZZcEdIaX8LaN2BI9jH6JT5Uh())
		{
			num2 = (double)((int)(num2 * 1.2));
		}
		return (int)num2;
	}

	// Token: 0x060004BE RID: 1214 RVA: 0x0001B3B4 File Offset: 0x000195B4
	private void _9uQC3m47mudh1sCSmEtgs0EPXSo(int time, int diff, Location whereabouts)
	{
		int wIV6RuTHp6K14hjsabfqulJm6RB = this._wIV6RuTHp6K14hjsabfqulJm6RB;
		this._O5dcmdDsuBeRCoXBBIOM2vrjFDK(diff);
		if (this._qx2AoradoYEUzNcySNa3ijGQPHe())
		{
			this._Pf0ENnaHZFebNxSceKLAdKBflRcA(wIV6RuTHp6K14hjsabfqulJm6RB - this._wIV6RuTHp6K14hjsabfqulJm6RB, "(Health drain)");
			return;
		}
		this._CtfGdpKEPpxmj5zCPGEiGGvDz0i(time, whereabouts);
	}

	// Token: 0x060004BF RID: 1215 RVA: 0x0001B3F4 File Offset: 0x000195F4
	private void _CtfGdpKEPpxmj5zCPGEiGGvDz0i(int time, Location whereabouts)
	{
		if (this._2quYVWYoLc77QY6uJhajp7qBEFF)
		{
			return;
		}
		if (!Settings.Default.EnableAutoNexus)
		{
			return;
		}
		if (this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._50Ms1zsqax9Ua48PaWMPQfIENYb._PaME7E91qS83Dt2dp6ptMCHxaAu())
		{
			return;
		}
		if (this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._50Ms1zsqax9Ua48PaWMPQfIENYb._sNZat68b2TvW6o582Hg9CFuEJCV <= this._nIuIwM7BarTHQX1xmpazfcFvdit && this._wIV6RuTHp6K14hjsabfqulJm6RB <= this._nIuIwM7BarTHQX1xmpazfcFvdit && this._dTFvDKmJDtcJzyy5wFAsDubOP2x <= this._nIuIwM7BarTHQX1xmpazfcFvdit)
		{
			if (time - this._r67gu1of1w1RIgPZODUlQX7QMJD > 500 && this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._50Ms1zsqax9Ua48PaWMPQfIENYb._sNZat68b2TvW6o582Hg9CFuEJCV < this._nIuIwM7BarTHQX1xmpazfcFvdit)
			{
				this._osMLuk1s0aJxtKxL3WlQPyfw9Vf(time, whereabouts);
			}
			return;
		}
	}

	// Token: 0x060004C0 RID: 1216 RVA: 0x0001B490 File Offset: 0x00019690
	private void _osMLuk1s0aJxtKxL3WlQPyfw9Vf(int time, Location whereabouts)
	{
		bool flag = false;
		int[] array = new int[0];
		if (!flag && this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._50Ms1zsqax9Ua48PaWMPQfIENYb._r4Xq85xV6nMTyHoC0hk90XNlu5q > 0)
		{
			array = new int[]
			{
				2594,
				254
			};
			flag = true;
		}
		if (flag)
		{
			this._sOwc8Hz5GYPFJ7BLvgRX72MvmaK(time, array[0], (byte)array[1], whereabouts);
			this._r67gu1of1w1RIgPZODUlQX7QMJD = time;
		}
	}

	// Token: 0x060004C2 RID: 1218 RVA: 0x0001B668 File Offset: 0x00019868
	private void _sOwc8Hz5GYPFJ7BLvgRX72MvmaK(int time, int itemType, byte slotId, Location location)
	{
		UseItemPacket lylWoxWrca2h31SiYiDb8gyQP0o = (UseItemPacket)Packet.Create(PacketType.USEITEM);
		lylWoxWrca2h31SiYiDb8gyQP0o.SlotObject = new SlotObject
		{
			objectId = this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._7w6u8taiwfZruB2OdFEa2AmzJaA,
			ObjectType = itemType,
			SlotId = (int)slotId
		};
		lylWoxWrca2h31SiYiDb8gyQP0o.Time = time;
		lylWoxWrca2h31SiYiDb8gyQP0o.ItemUsePos = location;
		lylWoxWrca2h31SiYiDb8gyQP0o.UseType = ((slotId >= 254) ? 0 : 1);
		this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._7uxLEqPg6T4dttVtkm2zilX7Qji(lylWoxWrca2h31SiYiDb8gyQP0o);
	}

	// Token: 0x060004C3 RID: 1219 RVA: 0x0001B6DC File Offset: 0x000198DC
	private void _O5dcmdDsuBeRCoXBBIOM2vrjFDK(int diff)
	{
		double num = (double)diff * 0.001;
		double num2 = 1.0 + 0.12 * (double)this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._50Ms1zsqax9Ua48PaWMPQfIENYb._UJS9Gfx8k7FD8Uw5U6mVqjWLghC;
		if (this._ebyfk31Ab9aj569ppNj1fwNxyUG)
		{
			num2 /= 2.0;
		}
		int num3;
		bool flag = ((!this._L4etETbJCIQekDr3Sm4dM67NyC) ? (num3 = 0) : (num3 = ((this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._50Ms1zsqax9Ua48PaWMPQfIENYb._NS3P3L4cIOPeb4lcI1vHxLBjUsG == 0) ? 1 : 0))) != 0;
		if (!this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._50Ms1zsqax9Ua48PaWMPQfIENYb._PaME7E91qS83Dt2dp6ptMCHxaAu() && !this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._50Ms1zsqax9Ua48PaWMPQfIENYb._NLH3KJ5cY1pLQ2EBfjvbAqhbGhq())
		{
			this._hj8yk7x1HcgngLMmaVYqpB3jODh += num2 * num;
			if (this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._50Ms1zsqax9Ua48PaWMPQfIENYb._QjCbV9Fd4t6nKLKemADmO4bM4hBA())
			{
				this._hj8yk7x1HcgngLMmaVYqpB3jODh += 20.0 * num;
				if (num3 != 0)
				{
					goto IL_F3;
				}
				goto IL_10B;
			}
		}
		else if (this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._50Ms1zsqax9Ua48PaWMPQfIENYb._NLH3KJ5cY1pLQ2EBfjvbAqhbGhq())
		{
			this._hj8yk7x1HcgngLMmaVYqpB3jODh -= 20.0 * num;
		}
		if (!flag)
		{
			goto IL_10B;
		}
		IL_F3:
		this._hj8yk7x1HcgngLMmaVYqpB3jODh -= 94.0 * num;
		IL_10B:
		int num4 = (int)this._hj8yk7x1HcgngLMmaVYqpB3jODh;
		double hj8yk7x1HcgngLMmaVYqpB3jODh = this._hj8yk7x1HcgngLMmaVYqpB3jODh - (double)num4;
		this._hj8yk7x1HcgngLMmaVYqpB3jODh = hj8yk7x1HcgngLMmaVYqpB3jODh;
		this._wIV6RuTHp6K14hjsabfqulJm6RB += num4;
		if (this._wIV6RuTHp6K14hjsabfqulJm6RB > this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._50Ms1zsqax9Ua48PaWMPQfIENYb._hI9BnQSXNqD191WGfzaqXuLrtAm)
		{
			this._wIV6RuTHp6K14hjsabfqulJm6RB = this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._50Ms1zsqax9Ua48PaWMPQfIENYb._hI9BnQSXNqD191WGfzaqXuLrtAm;
		}
	}

	// Token: 0x060004C4 RID: 1220 RVA: 0x0001B84C File Offset: 0x00019A4C
	private void _L9Sq7ilWPAc2XkNbriRGfXQBoeh()
	{
		this._jWMYX8VJLB8QB7nBQBQJn0c1btJ = (int)((double)Settings.Default.AutoNexusPercentageThreshold * 0.01 * (double)this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._50Ms1zsqax9Ua48PaWMPQfIENYb._hI9BnQSXNqD191WGfzaqXuLrtAm);
		this._nIuIwM7BarTHQX1xmpazfcFvdit = (int)((double)Settings.Default.AutoNexusDrinkThreshold * 0.01 * (double)this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._50Ms1zsqax9Ua48PaWMPQfIENYb._hI9BnQSXNqD191WGfzaqXuLrtAm);
	}

	// Token: 0x060004C5 RID: 1221 RVA: 0x0001B8B8 File Offset: 0x00019AB8
	private bool _qx2AoradoYEUzNcySNa3ijGQPHe()
	{
		return !this._2quYVWYoLc77QY6uJhajp7qBEFF && Settings.Default.EnableAutoNexus && (this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._50Ms1zsqax9Ua48PaWMPQfIENYb._sNZat68b2TvW6o582Hg9CFuEJCV < this._jWMYX8VJLB8QB7nBQBQJn0c1btJ || this._wIV6RuTHp6K14hjsabfqulJm6RB < this._jWMYX8VJLB8QB7nBQBQJn0c1btJ || this._dTFvDKmJDtcJzyy5wFAsDubOP2x < this._jWMYX8VJLB8QB7nBQBQJn0c1btJ);
	}

	// Token: 0x060004C6 RID: 1222 RVA: 0x0001B914 File Offset: 0x00019B14
	private void _MrinDQL27mmJE4svfljIZVv3O7b(int newMax)
	{
		if (newMax < this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._50Ms1zsqax9Ua48PaWMPQfIENYb._hI9BnQSXNqD191WGfzaqXuLrtAm && this._wIV6RuTHp6K14hjsabfqulJm6RB > this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._50Ms1zsqax9Ua48PaWMPQfIENYb._hI9BnQSXNqD191WGfzaqXuLrtAm)
		{
			this._wIV6RuTHp6K14hjsabfqulJm6RB = this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._50Ms1zsqax9Ua48PaWMPQfIENYb._hI9BnQSXNqD191WGfzaqXuLrtAm;
		}
		this._L9Sq7ilWPAc2XkNbriRGfXQBoeh();
	}

	// Token: 0x060004C7 RID: 1223 RVA: 0x0001B968 File Offset: 0x00019B68
	private void _Ac6nTGaucsLc0qgHVNdx4vdDNGY(int amount, string source)
	{
		this._wIV6RuTHp6K14hjsabfqulJm6RB += amount;
		if (this._wIV6RuTHp6K14hjsabfqulJm6RB > this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._50Ms1zsqax9Ua48PaWMPQfIENYb._hI9BnQSXNqD191WGfzaqXuLrtAm)
		{
			this._wIV6RuTHp6K14hjsabfqulJm6RB = this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._50Ms1zsqax9Ua48PaWMPQfIENYb._hI9BnQSXNqD191WGfzaqXuLrtAm;
		}
	}

	// Token: 0x060004C8 RID: 1224 RVA: 0x0001B9B4 File Offset: 0x00019BB4
	private void _Qkocwb8McbBzbTY7woKcuOjrC0(int amount, string source)
	{
		this._wIV6RuTHp6K14hjsabfqulJm6RB -= amount;
		this._dTFvDKmJDtcJzyy5wFAsDubOP2x -= amount;
		if (this._qx2AoradoYEUzNcySNa3ijGQPHe())
		{
			this._Pf0ENnaHZFebNxSceKLAdKBflRcA(amount, source);
		}
	}

	// Token: 0x060004C9 RID: 1225 RVA: 0x0001B9F0 File Offset: 0x00019BF0
	private void _T1pUOttbRRz7ku5YCPysaK7ODuE(int sealId)
	{
		if (sealId == -1)
		{
			this._KgvAv7C8BPHRhNGaBUY9WAoRFFU = null;
			return;
		}
		if (this._KgvAv7C8BPHRhNGaBUY9WAoRFFU != null)
		{
			if ((int)this._KgvAv7C8BPHRhNGaBUY9WAoRFFU._X5iK7DxZXqEuFaG5vPlQc32oVuG == sealId)
			{
				return;
			}
		}
		_66CXgP76qcRM5NMLzlNSbhfhXbG 66CXgP76qcRM5NMLzlNSbhfhXbG = _JzyrOApzC09RC3fmb10FDURmyCl.Items.ByID((ushort)sealId);
		if (66CXgP76qcRM5NMLzlNSbhfhXbG == null)
		{
			this._KgvAv7C8BPHRhNGaBUY9WAoRFFU = null;
			return;
		}
		this._KgvAv7C8BPHRhNGaBUY9WAoRFFU = 66CXgP76qcRM5NMLzlNSbhfhXbG;
	}

	// Token: 0x060004CA RID: 1226 RVA: 0x0001BA44 File Offset: 0x00019C44
	public int _wmYfEcnzJZHUMf6TmaRnx4oPoiG(int objectId)
	{
		AutoNexus._NgEaTpjfBI3veqdBfggv7SjSaRU ngEaTpjfBI3veqdBfggv7SjSaRU;
		ngEaTpjfBI3veqdBfggv7SjSaRU._EfubdzaIe4z6qxSHa3TuY5MkdaZ = this;
		bool flag = objectId == this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._7w6u8taiwfZruB2OdFEa2AmzJaA;
		int num;
		_66CXgP76qcRM5NMLzlNSbhfhXbG 66CXgP76qcRM5NMLzlNSbhfhXbG;
		if (flag)
		{
			ngEaTpjfBI3veqdBfggv7SjSaRU._OWPal6UeunpGQX6SceuuADJxQ4k = this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._50Ms1zsqax9Ua48PaWMPQfIENYb;
			num = ngEaTpjfBI3veqdBfggv7SjSaRU._OWPal6UeunpGQX6SceuuADJxQ4k._myJxXFJcH1zIBkZMmXfDOvAh0vcA[1];
			66CXgP76qcRM5NMLzlNSbhfhXbG = this._KgvAv7C8BPHRhNGaBUY9WAoRFFU;
		}
		else
		{
			ngEaTpjfBI3veqdBfggv7SjSaRU._OWPal6UeunpGQX6SceuuADJxQ4k = this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._aJjNVtwA8oe4lWrzJfpazHqj9A2[objectId];
			num = ngEaTpjfBI3veqdBfggv7SjSaRU._OWPal6UeunpGQX6SceuuADJxQ4k._myJxXFJcH1zIBkZMmXfDOvAh0vcA[1];
			if (num == -1)
			{
				return 0;
			}
			66CXgP76qcRM5NMLzlNSbhfhXbG = _JzyrOApzC09RC3fmb10FDURmyCl.Items.ByID((ushort)num);
		}
		if (66CXgP76qcRM5NMLzlNSbhfhXbG == null)
		{
			string format = "Warning, player {0}'s seal is null! itemType is {1}";
			GameObject owpal6UeunpGQX6SceuuADJxQ4k = ngEaTpjfBI3veqdBfggv7SjSaRU._OWPal6UeunpGQX6SceuuADJxQ4k;
			Console.WriteLine(string.Format(format, (owpal6UeunpGQX6SceuuADJxQ4k != null) ? owpal6UeunpGQX6SceuuADJxQ4k.Name : null, num));
			return 0;
		}
		ngEaTpjfBI3veqdBfggv7SjSaRU._a8AkCF855MfIlZCpL3R4tVhzRug = ((ngEaTpjfBI3veqdBfggv7SjSaRU._OWPal6UeunpGQX6SceuuADJxQ4k._WHCAkdeYqXMbNsGZ6LrBhVGy9y4 < 30) ? 4.5 : (0.135 * (double)ngEaTpjfBI3veqdBfggv7SjSaRU._OWPal6UeunpGQX6SceuuADJxQ4k._WHCAkdeYqXMbNsGZ6LrBhVGy9y4));
		if (66CXgP76qcRM5NMLzlNSbhfhXbG._dHPNoGlmrfb0cl4aaEGpRxXcgRw.Count == 0)
		{
			return 0;
		}
		foreach (Activate kEekgEziy3MAWF43C6Y4bLsMB7E in 66CXgP76qcRM5NMLzlNSbhfhXbG._dHPNoGlmrfb0cl4aaEGpRxXcgRw)
		{
			if (kEekgEziy3MAWF43C6Y4bLsMB7E._tgk0PcUCADsdky6nxKvRJqbCugJA == StatsTypeEnum.MaximumHP)
			{
				ActivateType jp3DtIV4aAYZY26sVsXpPQjBRGO = kEekgEziy3MAWF43C6Y4bLsMB7E._Jp3DtIV4aAYZY26sVsXpPQjBRGO;
				if (jp3DtIV4aAYZY26sVsXpPQjBRGO == ActivateType.StatBoostAura)
				{
					return this._Uds8LACABRKlO8SErTdqBEBcjyA(kEekgEziy3MAWF43C6Y4bLsMB7E, ref ngEaTpjfBI3veqdBfggv7SjSaRU);
				}
				if (jp3DtIV4aAYZY26sVsXpPQjBRGO == ActivateType.StatBoostSelf && flag)
				{
					return this._Uds8LACABRKlO8SErTdqBEBcjyA(kEekgEziy3MAWF43C6Y4bLsMB7E, ref ngEaTpjfBI3veqdBfggv7SjSaRU);
				}
			}
		}
		return 0;
	}

	// Token: 0x060004CB RID: 1227 RVA: 0x0001BBCC File Offset: 0x00019DCC
	private double _oyoi7MZ00uEXn3wJhjCw1K4UBTJ(double oldAmount, int wis, double precision = 1.0)
	{
		if (wis < 30)
		{
			return oldAmount;
		}
		int num = (oldAmount < 0.0) ? -1 : 1;
		double num2 = oldAmount * (double)wis / 150.0 + oldAmount * (double)num;
		num2 = Math.Floor(num2 * Math.Pow(10.0, precision)) / Math.Pow(10.0, precision);
		if (num2 - (double)((int)num2 * num) < 1.0 / Math.Pow(10.0, precision) * (double)num)
		{
			return (double)((int)num2);
		}
		return num2;
	}

	// Token: 0x060004CC RID: 1228 RVA: 0x0001BC58 File Offset: 0x00019E58
	public void _aHKs49K4OBGbC8YIpcXr4eOw2ei(int healAmount)
	{
		this._OheNBC1f5drFNP8lJ3bZoDVuSKv += healAmount;
	}

	// Token: 0x060004CD RID: 1229 RVA: 0x0001BC74 File Offset: 0x00019E74
	public void _PAhfVkixgGie7An1LzLMAKuPLECA()
	{
		if (this._OheNBC1f5drFNP8lJ3bZoDVuSKv > 0)
		{
			this._Ac6nTGaucsLc0qgHVNdx4vdDNGY(this._OheNBC1f5drFNP8lJ3bZoDVuSKv, "Seal Heal");
			this._OheNBC1f5drFNP8lJ3bZoDVuSKv = 0;
		}
	}

	// Token: 0x060004CE RID: 1230 RVA: 0x0001BCA4 File Offset: 0x00019EA4
	public void _QrK9KtR4xguWgEYrBE9xnEwwcqd(PlayerTextPacket playerText)
	{
		if (this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._50Ms1zsqax9Ua48PaWMPQfIENYb != null && playerText.Text == "/reset")
		{
			this._wIV6RuTHp6K14hjsabfqulJm6RB = this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._50Ms1zsqax9Ua48PaWMPQfIENYb._sNZat68b2TvW6o582Hg9CFuEJCV;
			return;
		}
		if (playerText.Text.StartsWith("/an "))
		{
			string text = playerText.Text.Substring(4);
			if (string.IsNullOrEmpty(text))
			{
				return;
			}
			int num;
			if (!int.TryParse(text, out num))
			{
				return;
			}
			Settings.Default.AutoNexusPercentageThreshold = num;
			this._L9Sq7ilWPAc2XkNbriRGfXQBoeh();
			this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._RUDdpffUqrc18m4ldj2l3yrb1t9(string.Format("Set autonexus health threshold to {0}% (at {1} health)", num, this._jWMYX8VJLB8QB7nBQBQJn0c1btJ));
		}
	}

	// Token: 0x060004CF RID: 1231 RVA: 0x0001BD54 File Offset: 0x00019F54
	[CompilerGenerated]
	internal static bool _4HVpBFqtCWjgYDd06ijku36wpTl(ARGB argb, int color)
	{
		return (color & 16711680) >> 16 == (int)argb.R && (color & 65280) >> 8 == (int)argb.G && (color & 255) == (int)argb.B;
	}

	// Token: 0x060004D0 RID: 1232 RVA: 0x0001BD9C File Offset: 0x00019F9C
	[CompilerGenerated]
	private int _Uds8LACABRKlO8SErTdqBEBcjyA(Activate activate, ref AutoNexus._NgEaTpjfBI3veqdBfggv7SjSaRU _NgEaTpjfBI3veqdBfggv7SjSaRU_0)
	{
		double num = this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._50Ms1zsqax9Ua48PaWMPQfIENYb._Z5Ka0qxWyONdxRmDe3dCDBoiFMw._lEH5A8k6GZhNzOJciwld9Bb4RqP(_NgEaTpjfBI3veqdBfggv7SjSaRU_0._OWPal6UeunpGQX6SceuuADJxQ4k._Z5Ka0qxWyONdxRmDe3dCDBoiFMw);
		this._oyoi7MZ00uEXn3wJhjCw1K4UBTJ((double)activate.Range, _NgEaTpjfBI3veqdBfggv7SjSaRU_0._OWPal6UeunpGQX6SceuuADJxQ4k._WHCAkdeYqXMbNsGZ6LrBhVGy9y4, 1.0);
		int result = (int)this._oyoi7MZ00uEXn3wJhjCw1K4UBTJ((double)activate.Amount, _NgEaTpjfBI3veqdBfggv7SjSaRU_0._OWPal6UeunpGQX6SceuuADJxQ4k._WHCAkdeYqXMbNsGZ6LrBhVGy9y4, 0.0);
		if (num >= _NgEaTpjfBI3veqdBfggv7SjSaRU_0._a8AkCF855MfIlZCpL3R4tVhzRug)
		{
			return 0;
		}
		return result;
	}

	// Token: 0x040005BF RID: 1471
	private const int _xr9P6PEtrPsTW3t9nBmCIV2ju0j = 799;

	// Token: 0x040005C0 RID: 1472
	private const int _xvYjBQIL2AxMexsBZrtsg4XTgRp = 797;

	// Token: 0x040005C1 RID: 1473
	private const bool _XsiWTH1J7tD5Vlk6bJELA8jHln0 = false;

	// Token: 0x040005C2 RID: 1474
	private Client _W6Ov6AArxzTTDnCyBtZPqkqNaKf;

	// Token: 0x040005C3 RID: 1475
	public bool _Hw75pbsTTalpiL9BLfm1eA0YOFK;

	// Token: 0x040005C4 RID: 1476
	private int _jWMYX8VJLB8QB7nBQBQJn0c1btJ;

	// Token: 0x040005C5 RID: 1477
	private int _nIuIwM7BarTHQX1xmpazfcFvdit;

	// Token: 0x040005C6 RID: 1478
	private ItemStructure _KgvAv7C8BPHRhNGaBUY9WAoRFFU;

	// Token: 0x040005C7 RID: 1479
	private int _wIV6RuTHp6K14hjsabfqulJm6RB;

	// Token: 0x040005C8 RID: 1480
	private int _dTFvDKmJDtcJzyy5wFAsDubOP2x;

	// Token: 0x040005C9 RID: 1481
	private double _hj8yk7x1HcgngLMmaVYqpB3jODh;

	// Token: 0x040005CA RID: 1482
	private int _y197qHnAdnQHPqX30R0Bq0tjIOcA;

	// Token: 0x040005CB RID: 1483
	private int _OheNBC1f5drFNP8lJ3bZoDVuSKv;

	// Token: 0x040005CC RID: 1484
	private int _r67gu1of1w1RIgPZODUlQX7QMJD;

	// Token: 0x040005CD RID: 1485
	private bool _UorlUPPYrMfEq3JgqJC3zM4wIwf;

	// Token: 0x040005CE RID: 1486
	private int _GKvDpEvGICPwzQQpBmeSSrSA0Ut;

	// Token: 0x040005CF RID: 1487
	private bool _2quYVWYoLc77QY6uJhajp7qBEFF;

	// Token: 0x040005D0 RID: 1488
	private bool _L4etETbJCIQekDr3Sm4dM67NyC;

	// Token: 0x040005D1 RID: 1489
	private object _L3oPeJNpyUoZawlFy7xi5hjWzHp;

	// Token: 0x040005D2 RID: 1490
	private List<_7kZ0X7cJVyJ4MZi00zDEPWadmiH> _AMQrd56F3iBO7prif4hznTC4y5A;

	// Token: 0x040005D3 RID: 1491
	private Location _0qPs3ICAiKqEpockvHdkXyWtLLK;

	// Token: 0x040005D4 RID: 1492
	private bool _ebyfk31Ab9aj569ppNj1fwNxyUG;

	// Token: 0x040005D5 RID: 1493
	private readonly List<string> _D0ydY92aMnivKXLmhWYnzjIuo7b;

	// Token: 0x040005D6 RID: 1494
	private Dictionary<int, ushort> _6HhWgr0VLGFSNUy8ZkAyxO8zznB;

	// Token: 0x020000AF RID: 175
	[CompilerGenerated]
	[Serializable]
	private sealed class _COGac3v2Ltj2Rm61nUs1anvxYmd
	{
		// Token: 0x060004D3 RID: 1235 RVA: 0x0001BE48 File Offset: 0x0001A048
		internal bool _BtCpICxZUD14Y9ob2aTTpGXgwGM(Activate activate)
		{
			return activate.Name == ActivateType.Heal || activate.Name == ActivateType.HealNova;
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x0001BE6C File Offset: 0x0001A06C
		internal bool _PoMZS1TIek23FTr8kGDUp3DmApF(Activate activate)
		{
			return activate.Amount > 0;
		}

		// Token: 0x040005D7 RID: 1495
		public static readonly AutoNexus._COGac3v2Ltj2Rm61nUs1anvxYmd <>9 = new AutoNexus._COGac3v2Ltj2Rm61nUs1anvxYmd();

		// Token: 0x040005D8 RID: 1496
		public static Func<Activate, bool> <>9__44_0;

		// Token: 0x040005D9 RID: 1497
		public static Func<Activate, bool> <>9__44_1;
	}

	// Token: 0x020000B0 RID: 176
	[CompilerGenerated]
	[StructLayout(LayoutKind.Auto)]
	private struct _NgEaTpjfBI3veqdBfggv7SjSaRU
	{
		// Token: 0x040005DA RID: 1498
		public AutoNexus _EfubdzaIe4z6qxSHa3TuY5MkdaZ;

		// Token: 0x040005DB RID: 1499
		public GameObject _OWPal6UeunpGQX6SceuuADJxQ4k;

		// Token: 0x040005DC RID: 1500
		public double _a8AkCF855MfIlZCpL3R4tVhzRug;
	}
}
