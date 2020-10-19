using System;
using System.Collections.Generic;
using ExaltMultiTool.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

// Token: 0x020000A3 RID: 163
internal class AccuracyFarm
{
	// Token: 0x06000464 RID: 1124 RVA: 0x0001733C File Offset: 0x0001553C
	public AccuracyFarm(Client client)
	{
		this.Client = client;
	}

	// Token: 0x06000465 RID: 1125 RVA: 0x00017364 File Offset: 0x00015564
	public void MapInfo()
	{
		if (Settings.Default.EnableFameTools && Settings.Default.FameAccuracyFarm)
		{
			this.Client.SendToClient("AccuracyFarm", "Warning, AccuracyFarm is enabled, enemy killing is disabled and teleporting is blocked, disable Accuracy Farm for normal gameplay functionality!");
		}
	}

	// Token: 0x06000466 RID: 1126 RVA: 0x000173A0 File Offset: 0x000155A0
	public void Update(UpdatePacket update)
	{
		foreach (Entity entity in update.NewObjs)
		{
			if (this.Client.Enemies.ContainsKey(entity.Status.ObjectId))
			{
				if (!this._originalHealthValues.ContainsKey(entity.Status.ObjectId))
				{
					this._originalHealthValues.Add(entity.Status.ObjectId, 100);
				}
				this.ProcessStatus(entity.Status);
			}
		}
		foreach (int key in update.Drops)
		{
			if (this._originalHealthValues.ContainsKey(key))
			{
				this._originalHealthValues.Remove(key);
			}
		}
	}

	// Token: 0x06000467 RID: 1127 RVA: 0x00017458 File Offset: 0x00015658
	public void NewTick(NewTickPacket newTick)
	{
		foreach (System.Windows.Forms.VisualStyles.VisualStyleElement.Status status in newTick.Statuses)
		{
			if (this.Client.Enemies.ContainsKey(status.ObjectId))
			{
				this.ProcessStatus(status);
			}
		}
		if (Settings.Default.EnableFameTools && Settings.Default.FameAccuracyFarm)
		{
			this._maxedHpLastTick = true;
			return;
		}
		if (this._maxedHpLastTick)
		{
			foreach (GameObject gameObject in this.Client.Enemies.Values)
			{
				if (this._originalHealthValues.ContainsKey(gameObject.ObjectId))
				{
					newTick.Statuses.Add(new Status
					{
						Position = gameObject.ServerPosition,
						ObjectId = gameObject.ObjectId,
						Data = new List<StatData>
						{
							new StatData
							{
								Id = StatsType.HP,
								IntValue = this._originalHealthValues[gameObject.ObjectId],
								StringValue = string.Empty
							}
						}
					});
				}
			}
			this._maxedHpLastTick = false;
		}
	}

	// Token: 0x06000468 RID: 1128 RVA: 0x000175C0 File Offset: 0x000157C0
	private void ProcessStatus(Status status)
	{
		foreach (StatData statData in status.Data)
		{
			if (StatsType.Id(statData.Id, StatsType.HP))
			{
				this._originalHealthValues[status.ObjectId] = statData.IntValue;
				break;
			}
		}
		if (Settings.Default.EnableFameTools && Settings.Default.FameAccuracyFarm)
		{
			StatData item = new StatData
			{
				Id = StatsType.HP,
				IntValue = int.MaxValue,
				StringValue = string.Empty
			};
			status.Data.Add(item);
		}
	}

	// Token: 0x06000469 RID: 1129 RVA: 0x00017688 File Offset: 0x00015888
	public void Teleport(TeleportPacket teleport)
	{
	}

	// Token: 0x0400058B RID: 1419
	private Client Client;

	// Token: 0x0400058C RID: 1420
	private readonly Dictionary<int, int> _originalHealthValues = new Dictionary<int, int>();

	// Token: 0x0400058D RID: 1421
	private bool _maxedHpLastTick;
}
