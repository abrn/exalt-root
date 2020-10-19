using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ExaltMultiTool.Properties;
using ExaltMultiTool.Proxy.DataStructures;

// Token: 0x020000A7 RID: 167
internal class AntiLag
{
	// Token: 0x06000478 RID: 1144 RVA: 0x00017E5C File Offset: 0x0001605C
	static AntiLag()
	{
		foreach (KeyValuePair<ushort, ObjectStructure> keyValuePair in _JzyrOApzC09RC3fmb10FDURmyCl.Objects.Map)
		{
			if (keyValuePair.Value.Pet && !AntiLag._x77VwCLgs408j0fh3W5TxPbX5ji.ContainsKey(keyValuePair.Key))
			{
				AntiLag._x77VwCLgs408j0fh3W5TxPbX5ji.Add(keyValuePair.Key, 0);
			}
		}
	}

	// Token: 0x06000479 RID: 1145 RVA: 0x00017EEC File Offset: 0x000160EC
	public AntiLag(Client client)
	{
		this._W6Ov6AArxzTTDnCyBtZPqkqNaKf = client;
	}

	// Token: 0x0600047A RID: 1146 RVA: 0x00017F54 File Offset: 0x00016154
	public void MapInfo(MapInfoPacket mapInfo)
	{
		if (mapInfo._Jp3DtIV4aAYZY26sVsXpPQjBRGO.Contains("Pet Yard"))
		{
			this._8gJUelF0jq8QQIQ0DaEZomG214e = true;
		}
	}

	// Token: 0x0600047B RID: 1147 RVA: 0x00017F7C File Offset: 0x0001617C
	public void _Q1PiJQ99KBCJeLcZ0HOk3AUAjIP(_4wU9AwmH67XtmNygsXuDz9DUXYm damage)
	{
		if (!Settings.Default.BlockDamageNumbers)
		{
			return;
		}
		if (damage._605Ligxeaj9k9kBV8zQhhFhgTGl == this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.ObjectId || damage._GNsbx2sQjKyCD4qK29hWl8cxeSqA == this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.ObjectId)
		{
			damage.Send = false;
		}
	}

	// Token: 0x0600047C RID: 1148 RVA: 0x00017FC4 File Offset: 0x000161C4
	public void _1nwhQXngJ6rNjd7Ufx1bWeF0vhM(ShowEffectPacket showEffect)
	{
		if (!Settings.Default.AntiLagIgnoreEffects)
		{
			return;
		}
		string name = Enum.GetName(typeof(EffectType), showEffect.EffectType);
		showEffect.Send = !Settings.Default.AntiLagIgnoredEffects.Contains(name);
	}

	// Token: 0x0600047D RID: 1149 RVA: 0x00018014 File Offset: 0x00016214
	public void _sQE0wot2EaQSiJuOdoBQMHZLdjC(_CO7ACSeK1WWaCGAPAqLaov37Wqdb editAccountList)
	{
		if (editAccountList._OwuaUDh0iAfRHavUKndlQVgxohF == 0 && this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Objects.ContainsKey(editAccountList._605Ligxeaj9k9kBV8zQhhFhgTGl))
		{
			this._I58DJGepFQsHHGJKkuGm7aarDEoA(editAccountList._605Ligxeaj9k9kBV8zQhhFhgTGl, editAccountList._HS378dgTEo8KIggp757BtXzX60G);
		}
	}

	// Token: 0x0600047E RID: 1150 RVA: 0x00018054 File Offset: 0x00016254
	public void _3MuNCSmlbmV0iTAc8Xn9gqokJ3N(_K4pBHmoGRyaE6dWf1FIvL0dcuzKA accountList)
	{
		if (accountList._OwuaUDh0iAfRHavUKndlQVgxohF == 0)
		{
			this._8i5Xno2CWAiGhNjM0I4pUOT42rf = accountList._W6ULZ8o75Cc8MbI64rdutLQMCgh.ToList<string>();
		}
	}

	// Token: 0x0600047F RID: 1151 RVA: 0x0001807C File Offset: 0x0001627C
	public void _IDtpCgDjmC1AQOcZCJSFNAYjlbH(_CBwOjnzusZzuPkHfx7wuwePHqrf text)
	{
		if (!this._mP2INHckp4rxUZYBXKirz6uS4ll)
		{
			return;
		}
		if (text._VOCc8CZlF3S0HMq8xxgy2zaOkBn == -1)
		{
			if (text._TL2Ac3BFZHvDuoDwJImuUlObseO == "*Guild*" && text._IDtpCgDjmC1AQOcZCJSFNAYjlbH.Contains(this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player._DLxrEjFA9uIUMlXFyCHIdWI4V11))
			{
				if (!text._IDtpCgDjmC1AQOcZCJSFNAYjlbH.StartsWith("{\"key\":\"server.guild_join\",\"tokens\":{\"name\":\""))
				{
					if (text._IDtpCgDjmC1AQOcZCJSFNAYjlbH.Contains(" has left "))
					{
						string[] array = text._IDtpCgDjmC1AQOcZCJSFNAYjlbH.Split(new string[]
						{
							" has left "
						}, StringSplitOptions.RemoveEmptyEntries);
						if (array.Length != 2)
						{
							return;
						}
						string name = array[0].ToLower();
						string guild = array[1];
						this._FGFdx3AUQj8HjTcrwR2FJ5tSVIL(name, guild);
					}
				}
				else
				{
					string[] array = text._IDtpCgDjmC1AQOcZCJSFNAYjlbH.Split(new string[]
					{
						"{\"key\":\"server.guild_join\",\"tokens\":{\"name\":\""
					}, StringSplitOptions.RemoveEmptyEntries);
					if (array.Length != 1)
					{
						return;
					}
					array = array[0].Split(new string[]
					{
						"\",\"guild\":\""
					}, StringSplitOptions.RemoveEmptyEntries);
					if (array.Length != 2)
					{
						return;
					}
					string name2 = array[0].ToLower();
					string guild2 = array[1].Substring(0, array[1].Length - 3);
					this._FGFdx3AUQj8HjTcrwR2FJ5tSVIL(name2, guild2);
					return;
				}
			}
		}
	}

	// Token: 0x06000480 RID: 1152 RVA: 0x000181A0 File Offset: 0x000163A0
	public void text(PlayerTextPacket playerText)
	{
		if (string.IsNullOrEmpty(playerText.Text))
		{
			return;
		}
		if (playerText.Text.StartsWith("/lock ") || playerText.Text.StartsWith("/unlock "))
		{
			string[] array = playerText.Text.Split(new string[]
			{
				"/lock ",
				"/unlock "
			}, StringSplitOptions.RemoveEmptyEntries);
			if (array.Length < 2)
			{
				return;
			}
			string b = array[1].ToLower();
			foreach (GameObject dbvvb43n9c5uNQ7JklPD1fnCEnv in this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Players.Values)
			{
				if (dbvvb43n9c5uNQ7JklPD1fnCEnv._Jp3DtIV4aAYZY26sVsXpPQjBRGO.ToLower() == b)
				{
					bool add = playerText.Text.StartsWith("/lock ");
					this._I58DJGepFQsHHGJKkuGm7aarDEoA(dbvvb43n9c5uNQ7JklPD1fnCEnv.ObjectId, add);
					break;
				}
			}
		}
	}

	// Token: 0x06000481 RID: 1153 RVA: 0x00018298 File Offset: 0x00016498
	private void _I58DJGepFQsHHGJKkuGm7aarDEoA(int objectId, bool add)
	{
		if (!this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Players.ContainsKey(objectId))
		{
			return;
		}
		GameObject dbvvb43n9c5uNQ7JklPD1fnCEnv = this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Players[objectId];
		if (string.IsNullOrEmpty(dbvvb43n9c5uNQ7JklPD1fnCEnv._hX8BFqWLS62laclaj1NZp3sAf1lA))
		{
			return;
		}
		if (add)
		{
			if (!this._8i5Xno2CWAiGhNjM0I4pUOT42rf.Contains(dbvvb43n9c5uNQ7JklPD1fnCEnv._hX8BFqWLS62laclaj1NZp3sAf1lA))
			{
				this._8i5Xno2CWAiGhNjM0I4pUOT42rf.Add(dbvvb43n9c5uNQ7JklPD1fnCEnv._hX8BFqWLS62laclaj1NZp3sAf1lA);
			}
		}
		else if (this._8i5Xno2CWAiGhNjM0I4pUOT42rf.Contains(dbvvb43n9c5uNQ7JklPD1fnCEnv._hX8BFqWLS62laclaj1NZp3sAf1lA))
		{
			this._8i5Xno2CWAiGhNjM0I4pUOT42rf.Remove(dbvvb43n9c5uNQ7JklPD1fnCEnv._hX8BFqWLS62laclaj1NZp3sAf1lA);
		}
		this._QMiMllo0YlhVg64NxhXAlvDccJW = true;
	}

	// Token: 0x06000482 RID: 1154 RVA: 0x00018330 File Offset: 0x00016530
	public void Update(UpdatePacket update)
	{
		foreach (Entity eTOyUHUGABMgTlUf3FUyHRn1uVv in update.NewObjs)
		{
			if (!this._l0pQWie3EdIbqnUAhHouBM6negQ(eTOyUHUGABMgTlUf3FUyHRn1uVv) && eTOyUHUGABMgTlUf3FUyHRn1uVv.Status.ObjectId != this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.PlayerId && this._MqRICahBouQPM8OB0ywZnrHDd2B(eTOyUHUGABMgTlUf3FUyHRn1uVv))
			{
				if (!this._qPxjEBFpJZ17X1yCPDgrEKyOr3c.ContainsKey(eTOyUHUGABMgTlUf3FUyHRn1uVv.Status.ObjectId))
				{
					this._qPxjEBFpJZ17X1yCPDgrEKyOr3c.Add(eTOyUHUGABMgTlUf3FUyHRn1uVv.Status.ObjectId, 100);
				}
				this._BwUEkSS32j3v8tc5v3r4RiE6eiD(eTOyUHUGABMgTlUf3FUyHRn1uVv.Status);
				this._QMiMllo0YlhVg64NxhXAlvDccJW = true;
			}
		}
		foreach (int key in update.Drops)
		{
			if (this._qPxjEBFpJZ17X1yCPDgrEKyOr3c.ContainsKey(key))
			{
				this._qPxjEBFpJZ17X1yCPDgrEKyOr3c.Remove(key);
			}
		}
	}

	// Token: 0x06000483 RID: 1155 RVA: 0x000183FC File Offset: 0x000165FC
	private bool _urdfHWzeuZZsgc3tVNYjh4aVfbE(Entity entity)
	{
		return AntiLag._x77VwCLgs408j0fh3W5TxPbX5ji.ContainsKey(entity._koPitlGqCPegcnIS2B6efWzp4zO);
	}

	// Token: 0x06000484 RID: 1156 RVA: 0x0001841C File Offset: 0x0001661C
	private bool _l0pQWie3EdIbqnUAhHouBM6negQ(Entity entity)
	{
		return entity.Status.ObjectId - 1 == this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.PlayerId && this.ContainsKey(entity);
	}

	// Token: 0x06000485 RID: 1157 RVA: 0x0001844C File Offset: 0x0001664C
	private bool _MqRICahBouQPM8OB0ywZnrHDd2B(Entity entity)
	{
		return this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Players.ContainsKey(entity.Status.ObjectId) || this.ContainsKey(entity);
	}

	// Token: 0x06000486 RID: 1158 RVA: 0x00018480 File Offset: 0x00016680
	public void NewTick(NewTickPacket newTick)
	{
		foreach (Status status in newTick.Statuses)
		{
			this._BwUEkSS32j3v8tc5v3r4RiE6eiD(status);
		}
		this._mP2INHckp4rxUZYBXKirz6uS4ll = !string.IsNullOrEmpty(this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player._DLxrEjFA9uIUMlXFyCHIdWI4V11);
		if (this._QMiMllo0YlhVg64NxhXAlvDccJW || this._cm5hn3COGw89v12qgogbgY38ZUL != Settings.Default.AntiLagApplyToGuildMates || this._mT3h9cwD5qMmZ6iYl5xSCP706fe != Settings.Default.AntiLagApplyToLockList || this._GYhdmALmkcDWSQUyNxwYq1kCaMI != Settings.Default.AntiLagHideAllyPets || (Settings.Default.AntiLagAllyPlayerSize != 100 && Settings.Default.AntiLagAllyPlayerSize != this._8tudMYjkF0MLCz8PxczdDNhxggbA))
		{
			foreach (KeyValuePair<int, int> keyValuePair in this._qPxjEBFpJZ17X1yCPDgrEKyOr3c)
			{
				if (this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Objects.ContainsKey(keyValuePair.Key))
				{
					GameObject dbvvb43n9c5uNQ7JklPD1fnCEnv = this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Objects[keyValuePair.Key];
					int oa4cpVBuVli8iMfEr9qRAJovcHe = this._KUZbM21i3sBdHGSPdQFqgE2X2bZ(keyValuePair.Key);
					newTick.Statuses.Add(new Status
					{
						Position = dbvvb43n9c5uNQ7JklPD1fnCEnv.ServerPosition,
						ObjectId = keyValuePair.Key,
						Data = new List<StatData>
						{
							new StatData
							{
								Id = StatsType._l5HAIp8OEZRguJkIVcZQDtTd8ME,
								IntValue = oa4cpVBuVli8iMfEr9qRAJovcHe,
								StringValue = string.Empty
							}
						}
					});
				}
			}
		}
		this._8tudMYjkF0MLCz8PxczdDNhxggbA = Settings.Default.AntiLagAllyPlayerSize;
		this._cm5hn3COGw89v12qgogbgY38ZUL = Settings.Default.AntiLagApplyToGuildMates;
		this._mT3h9cwD5qMmZ6iYl5xSCP706fe = Settings.Default.AntiLagApplyToLockList;
		this._GYhdmALmkcDWSQUyNxwYq1kCaMI = Settings.Default.AntiLagHideAllyPets;
		this._QMiMllo0YlhVg64NxhXAlvDccJW = false;
	}

	// Token: 0x06000487 RID: 1159 RVA: 0x00018688 File Offset: 0x00016888
	private int _KUZbM21i3sBdHGSPdQFqgE2X2bZ(int objectId)
	{
		GameObject dbvvb43n9c5uNQ7JklPD1fnCEnv = this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Objects[objectId];
		if (dbvvb43n9c5uNQ7JklPD1fnCEnv._50Ms1zsqax9Ua48PaWMPQfIENYb)
		{
			bool flag = !string.IsNullOrEmpty(dbvvb43n9c5uNQ7JklPD1fnCEnv._hX8BFqWLS62laclaj1NZp3sAf1lA) && this._8i5Xno2CWAiGhNjM0I4pUOT42rf.Contains(dbvvb43n9c5uNQ7JklPD1fnCEnv._hX8BFqWLS62laclaj1NZp3sAf1lA);
			bool flag2 = !string.IsNullOrEmpty(dbvvb43n9c5uNQ7JklPD1fnCEnv._DLxrEjFA9uIUMlXFyCHIdWI4V11) && dbvvb43n9c5uNQ7JklPD1fnCEnv._DLxrEjFA9uIUMlXFyCHIdWI4V11 == this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player._DLxrEjFA9uIUMlXFyCHIdWI4V11;
			bool antiLagApplyToLockList = Settings.Default.AntiLagApplyToLockList;
			bool antiLagApplyToGuildMates = Settings.Default.AntiLagApplyToGuildMates;
			int antiLagAllyPlayerSize = Settings.Default.AntiLagAllyPlayerSize;
			int num = this._qPxjEBFpJZ17X1yCPDgrEKyOr3c[objectId];
			if (flag && !antiLagApplyToLockList)
			{
				return num;
			}
			if (flag2 && !antiLagApplyToGuildMates)
			{
				return num;
			}
			return (int)((double)antiLagAllyPlayerSize / 100.0 * (double)num);
		}
		else if (AntiLag._x77VwCLgs408j0fh3W5TxPbX5ji.ContainsKey(dbvvb43n9c5uNQ7JklPD1fnCEnv.ObjectType))
		{
			if (Settings.Default.AntiLagHideAllyPets && !this._8gJUelF0jq8QQIQ0DaEZomG214e)
			{
				return 0;
			}
			return this._qPxjEBFpJZ17X1yCPDgrEKyOr3c[objectId];
		}
		else
		{
			if (Settings.Default.AntiLagAllyPlayerSize != 100)
			{
				return Settings.Default.AntiLagAllyPlayerSize;
			}
			return this._qPxjEBFpJZ17X1yCPDgrEKyOr3c[objectId];
		}
	}

	// Token: 0x06000488 RID: 1160 RVA: 0x000187B0 File Offset: 0x000169B0
	private void _BwUEkSS32j3v8tc5v3r4RiE6eiD(Status status)
	{
		foreach (StatData eawaZQvtvbptP3yFgHw8DNBicDZ in status.Data)
		{
			if (StatsType.Id(eawaZQvtvbptP3yFgHw8DNBicDZ.Id, StatsType._l5HAIp8OEZRguJkIVcZQDtTd8ME))
			{
				if (this._qPxjEBFpJZ17X1yCPDgrEKyOr3c.ContainsKey(status.ObjectId))
				{
					this._qPxjEBFpJZ17X1yCPDgrEKyOr3c[status.ObjectId] = eawaZQvtvbptP3yFgHw8DNBicDZ.IntValue;
					if (Settings.Default.AntiLagAllyPlayerSize != 100)
					{
						eawaZQvtvbptP3yFgHw8DNBicDZ.IntValue = this._KUZbM21i3sBdHGSPdQFqgE2X2bZ(status.ObjectId);
					}
				}
				break;
			}
		}
	}

	// Token: 0x06000489 RID: 1161 RVA: 0x00018860 File Offset: 0x00016A60
	[CompilerGenerated]
	private void _FGFdx3AUQj8HjTcrwR2FJ5tSVIL(string name, string guild)
	{
		foreach (KeyValuePair<int, GameObject> keyValuePair in this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Players)
		{
			if (!(keyValuePair.Value._Jp3DtIV4aAYZY26sVsXpPQjBRGO.ToLower() != name))
			{
				this._QMiMllo0YlhVg64NxhXAlvDccJW = true;
				break;
			}
		}
	}

	// Token: 0x0400059A RID: 1434
	private static readonly Dictionary<ushort, byte> _x77VwCLgs408j0fh3W5TxPbX5ji = new Dictionary<ushort, byte>();

	// Token: 0x0400059B RID: 1435
	private List<string> _8i5Xno2CWAiGhNjM0I4pUOT42rf = new List<string>();

	// Token: 0x0400059C RID: 1436
	private bool _8gJUelF0jq8QQIQ0DaEZomG214e;

	// Token: 0x0400059D RID: 1437
	private Client _W6Ov6AArxzTTDnCyBtZPqkqNaKf;

	// Token: 0x0400059E RID: 1438
	private readonly Dictionary<int, int> _qPxjEBFpJZ17X1yCPDgrEKyOr3c = new Dictionary<int, int>();

	// Token: 0x0400059F RID: 1439
	private int _8tudMYjkF0MLCz8PxczdDNhxggbA = 100;

	// Token: 0x040005A0 RID: 1440
	private bool _QMiMllo0YlhVg64NxhXAlvDccJW;

	// Token: 0x040005A1 RID: 1441
	private bool _cm5hn3COGw89v12qgogbgY38ZUL = Settings.Default.AntiLagApplyToGuildMates;

	// Token: 0x040005A2 RID: 1442
	private bool _mT3h9cwD5qMmZ6iYl5xSCP706fe = Settings.Default.AntiLagApplyToLockList;

	// Token: 0x040005A3 RID: 1443
	private bool _GYhdmALmkcDWSQUyNxwYq1kCaMI = Settings.Default.AntiLagHideAllyPets;

	// Token: 0x040005A4 RID: 1444
	private bool _mP2INHckp4rxUZYBXKirz6uS4ll;
}
