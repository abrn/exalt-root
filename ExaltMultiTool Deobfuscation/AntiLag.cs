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
		foreach (KeyValuePair<ushort, ObjectStructure> keyValuePair in GameData.Objects.Map)
		{
			if (keyValuePair.Value.Pet && !AntiLag._petTypes.ContainsKey(keyValuePair.Key))
			{
				AntiLag._petTypes.Add(keyValuePair.Key, 0);
			}
		}
	}

	// Token: 0x06000479 RID: 1145 RVA: 0x00017EEC File Offset: 0x000160EC
	public AntiLag(Client client)
	{
		this.client = client;
	}

	// Token: 0x0600047A RID: 1146 RVA: 0x00017F54 File Offset: 0x00016154
	public void MapInfo(MapInfoPacket mapInfo)
	{
		if (mapInfo.Name.Contains("Pet Yard"))
		{
			this._isPetYard = true;
		}
	}

	// Token: 0x0600047B RID: 1147 RVA: 0x00017F7C File Offset: 0x0001617C
	public void Damage(_4wU9AwmH67XtmNygsXuDz9DUXYm damage)
	{
		if (!Settings.Default.BlockDamageNumbers)
		{
			return;
		}
		if (damage.ObjectId == this.client.ObjectId || damage.TargetId == this.client.ObjectId)
		{
			damage.Send = false;
		}
	}

	// Token: 0x0600047C RID: 1148 RVA: 0x00017FC4 File Offset: 0x000161C4
	public void ShowEffect(ShowEffectPacket showEffect)
	{
		if (!Settings.Default.AntiLagIgnoreEffects)
		{
			return;
		}
		string name = Enum.GetName(typeof(EffectType), showEffect.EffectType);
		showEffect.Send = !Settings.Default.AntiLagIgnoredEffects.Contains(name);
	}

	// Token: 0x0600047D RID: 1149 RVA: 0x00018014 File Offset: 0x00016214
	public void EditAccountList(EditAccountListPacket editAccountList)
	{
		if (editAccountList.AccountListId == 0 && this.client.Objects.ContainsKey(editAccountList.ObjectId))
		{
			this.ChangeLog(editAccountList.ObjectId, editAccountList.Add);
		}
	}

	// Token: 0x0600047E RID: 1150 RVA: 0x00018054 File Offset: 0x00016254
	public void AccountList(AccountListPacket accountList)
	{
		if (accountList.AccountListId == 0)
		{
				foreach (string key in accountList.AccountIds)
				{
					if (!this._lockedPlayers.ContainsKey(key))
					{
						this._lockedPlayers.Add(key, 0);
					}
				}
		}
	}

	// Token: 0x0600047F RID: 1151 RVA: 0x0001807C File Offset: 0x0001627C
	public void Text(TextPacket text)
	{
		if (!this._selfInGuild)
		{
			return;
		}
		if (text.NumStars == -1)
		{
			if (text.Recipient == "*Guild*" && text.Text.Contains(this.client.Player.Guild))
			{
				if (!text.Text.StartsWith("{\"key\":\"server.guild_join\",\"tokens\":{\"name\":\""))
				{
					if (text.Text.Contains(" has left "))
					{
						string[] array = text.Text.Split(new string[]
						{
							" has left "
						}, StringSplitOptions.RemoveEmptyEntries);
						if (array.Length != 2)
						{
							return;
						}
						string name = array[0].ToLower();
						string guild = array[1];
						this._UpdateIfPlayerFound(name, guild);
					}
				}
				else
				{
					string[] array = text.Text.Split(new string[]
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
					this._UpdateIfPlayerFound(name2, guild2);
					return;
				}
			}
		}
	}

	// Token: 0x06000480 RID: 1152 RVA: 0x000181A0 File Offset: 0x000163A0
	public void PlayerText(PlayerTextPacket playerText)
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
			foreach (GameObject gameObject in this.client.Players.Values)
			{
				if (gameObject.Name.ToLower() == b)
				{
					bool add = playerText.Text.StartsWith("/lock ");
					this.ChangeLog(gameObject.ObjectId, add);
					break;
				}
			}
		}
	}

	// Token: 0x06000481 RID: 1153 RVA: 0x00018298 File Offset: 0x00016498
	private void ChangeLog(int objectId, bool add)
	{
		if (!this.client.Players.ContainsKey(objectId))
		{
			return;
		}
		GameObject gameObject = this.client.Players[objectId];
		if (string.IsNullOrEmpty(gameObject.AccountId))
		{
			return;
		}
		if (add)
		{
			if (!this._lockedPlayers.ContainsKey(gameObject.AccountId))
			{
				this._lockedPlayers.Add(gameObject.AccountId, 0);
			}
		}
		else if (this._lockedPlayers.ContainsKey(gameObject.AccountId))
		{
			this._lockedPlayers.Remove(gameObject.AccountId);
		}
		this._newObjectToScaleThisTick = true;
	}

	// Token: 0x06000482 RID: 1154 RVA: 0x00018330 File Offset: 0x00016530
	public void Update(UpdatePacket update)
	{
		foreach (Entity entity in update.NewObjs)
		{
			if (!this.EntityIsMyPet(entity) && entity.Status.ObjectId != this.client.PlayerId && this.EntityIsPetOrPlayer(entity))
			{
				if (!this._objectsToScale.ContainsKey(entity.Status.ObjectId))
				{
					this._objectsToScale.Add(entity.Status.ObjectId, 100);
				}
				this.ProcessStatus(entity.Status);
				this._newObjectToScaleThisTick = true;
			}
		}
		foreach (int key in update.Drops)
		{
			if (this._objectsToScale.ContainsKey(key))
			{
				this._objectsToScale.Remove(key);
			}
		}
	}

	// Token: 0x06000483 RID: 1155 RVA: 0x000183FC File Offset: 0x000165FC
	private bool EntityIsAPet(Entity entity)
	{
		return AntiLag._petTypes.ContainsKey(entity.ObjectType);
	}

	// Token: 0x06000484 RID: 1156 RVA: 0x0001841C File Offset: 0x0001661C
	private bool EntityIsMyPet(Entity entity)
	{
		return entity.Status.ObjectId - 1 == this.client.PlayerId && this.EntityIsAPet(entity);
	}

	// Token: 0x06000485 RID: 1157 RVA: 0x0001844C File Offset: 0x0001664C
	private bool EntityIsPetOrPlayer(Entity entity)
	{
		return this.client.Players.ContainsKey(entity.Status.ObjectId) || this.EntityIsAPet(entity);
	}

	// Token: 0x06000486 RID: 1158 RVA: 0x00018480 File Offset: 0x00016680
	public void NewTick(NewTickPacket newTick)
	{
		foreach (Status status in newTick.Statuses)
		{
			this.ProcessStatus(status);
		}
		this._selfInGuild = !string.IsNullOrEmpty(this.client.Player.Guild);
		if (this._newObjectToScaleThisTick || this._changeGuildSizeLastTick != Settings.Default.AntiLagApplyToGuildMates || this._changeLockSizeLastTick != Settings.Default.AntiLagApplyToLockList || this._hidePetSizeLastTick != Settings.Default.AntiLagHideAllyPets || (Settings.Default.AntiLagAllyPlayerSize != 100 && Settings.Default.AntiLagAllyPlayerSize != this._sizeLastTick))
		{
			foreach (KeyValuePair<int, int> keyValuePair in this._objectsToScale)
			{
				if (this.client.Objects.ContainsKey(keyValuePair.Key))
				{
					GameObject gameObject = this.client.Objects[keyValuePair.Key];
					int scaledSize = this.GetScaledSize(keyValuePair.Key);
					newTick.Statuses.Add(new Status
					{
						Position = gameObject.ServerPosition,
						ObjectId = keyValuePair.Key,
						Data = new List<StatData>
						{
							new StatData
							{
								Id = StatsType.Size,
								IntValue = scaledSize,
								StringValue = string.Empty
							}
						}
					});
				}
			}
		}
		this._sizeLastTick = Settings.Default.AntiLagAllyPlayerSize;
		this._changeGuildSizeLastTick = Settings.Default.AntiLagApplyToGuildMates;
		this._changeLockSizeLastTick = Settings.Default.AntiLagApplyToLockList;
		this._hidePetSizeLastTick = Settings.Default.AntiLagHideAllyPets;
		this._newObjectToScaleThisTick = false;
	}

	// Token: 0x06000487 RID: 1159 RVA: 0x00018688 File Offset: 0x00016888
	private int GetScaledSize(int objectId)
	{
		GameObject gameObject = this.client.Objects[objectId];
		if (gameObject.Player)
		{
			bool flag = !string.IsNullOrEmpty(gameObject.AccountId) && this._lockedPlayers.ContainsKey(gameObject.AccountId);
			bool flag2 = !string.IsNullOrEmpty(gameObject.Guild) && gameObject.Guild == this.client.Player.Guild;
			bool antiLagApplyToLockList = Settings.Default.AntiLagApplyToLockList;
			bool antiLagApplyToGuildMates = Settings.Default.AntiLagApplyToGuildMates;
			int antiLagAllyPlayerSize = Settings.Default.AntiLagAllyPlayerSize;
			int num = this._objectsToScale[objectId];
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
		else if (AntiLag._petTypes.ContainsKey(gameObject.ObjectType))
		{
			if (Settings.Default.AntiLagHideAllyPets && !this._isPetYard)
			{
				return 0;
			}
			return this._objectsToScale[objectId];
		}
		else
		{
			if (Settings.Default.AntiLagAllyPlayerSize != 100)
			{
				return Settings.Default.AntiLagAllyPlayerSize;
			}
			return this._objectsToScale[objectId];
		}
	}

	// Token: 0x06000488 RID: 1160 RVA: 0x000187B0 File Offset: 0x000169B0
	private void ProcessStatus(Status status)
	{
		foreach (StatData statData in status.Data)
		{
			if (StatsType.Id(statData.Id, StatsType.Size))
			{
				if (this._objectsToScale.ContainsKey(status.ObjectId))
				{
					this._objectsToScale[status.ObjectId] = statData.IntValue;
					if (Settings.Default.AntiLagAllyPlayerSize != 100)
					{
						statData.IntValue = this.GetScaledSize(status.ObjectId);
					}
				}
				break;
			}
		}
	}

	// Token: 0x06000489 RID: 1161 RVA: 0x00018860 File Offset: 0x00016A60
	[CompilerGenerated]
	private void _UpdateIfPlayerFound(string name, string guild)
	{
		foreach (KeyValuePair<int, GameObject> keyValuePair in this.client.Players)
		{
			if (!(keyValuePair.Value.Name.ToLower() != name))
			{
				this._newObjectToScaleThisTick = true;
				break;
			}
		}
	}

	// Token: 0x0400059A RID: 1434
	private readonly Dictionary<string, byte> _lockedPlayers = new Dictionary<string, byte>();
	private static readonly Dictionary<ushort, byte> _petTypes = new Dictionary<ushort, byte>();


	// Token: 0x0400059C RID: 1436
	private bool _isPetYard;

	// Token: 0x0400059D RID: 1437
	private Client client;

	// Token: 0x0400059E RID: 1438
	private readonly Dictionary<int, int> _objectsToScale = new Dictionary<int, int>();

	// Token: 0x0400059F RID: 1439
	private int _sizeLastTick = 100;

	// Token: 0x040005A0 RID: 1440
	private bool _newObjectToScaleThisTick;

	// Token: 0x040005A1 RID: 1441
	private bool _changeGuildSizeLastTick = Settings.Default.AntiLagApplyToGuildMates;

	// Token: 0x040005A2 RID: 1442
	private bool _changeLockSizeLastTick = Settings.Default.AntiLagApplyToLockList;

	// Token: 0x040005A3 RID: 1443
	private bool _hidePetSizeLastTick = Settings.Default.AntiLagHideAllyPets;

	// Token: 0x040005A4 RID: 1444
	private bool _selfInGuild;
}
