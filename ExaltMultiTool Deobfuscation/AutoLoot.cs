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
		this.client = client;
	}

	// Token: 0x060004A3 RID: 1187 RVA: 0x00019E54 File Offset: 0x00018054
	public void MapInfo(MapInfoPacket mapInfo)
	{
		this._inVault = mapInfo.Name.ToLower().Contains("vault");
	}

	// Token: 0x060004A4 RID: 1188 RVA: 0x00019E7C File Offset: 0x0001807C
	public void QuestObjId(QuestObjIdPacket questObjId)
	{
		this._lastQuest = questObjId.ObjectId;
	}

	// Token: 0x060004A5 RID: 1189 RVA: 0x00019E98 File Offset: 0x00018098
	public void Update(UpdatePacket update)
	{
		if (this._lootQuest != -1 && update.Drops.Contains(this._lootQuest))
		{
			this._lootQuest = -1;
			if (this._lastQuest != -1)
			{
				QuestObjIdPacket questObjIdPacket = (QuestObjIdPacket)Packet.Create(PacketType.QUESTOBJID);
				questObjIdPacket.ObjectId = this._lastQuest;
				this._lastQuest = -1;
				this.client.SendToClient(questObjIdPacket);
			}
		}
		if (Settings.Default.AutoLootBigBags)
		{
			foreach (Entity entity in update.NewObjs)
			{
				if (Enum.IsDefined(typeof(Bags), entity.ObjectType))
				{
					foreach (StatData stat in entity.Status.Data)
					{
						if (StatsType.Id(stat.Id, StatsType.Size))
						{
							stat.IntValue = 175;
						}
					}
				}
			}
		}
	}

	// Token: 0x060004A6 RID: 1190 RVA: 0x00019FB0 File Offset: 0x000181B0
	public void InvSwap(InvSwapPacket invSwap)
	{
		if (!Settings.Default.EnableAutoLoot)
		{
			return;
		}
		if (invSwap.Time - this.Time >= 500)
		{
			if (invSwap.SlotObject1.objectId == this.client.ObjectId && invSwap.SlotObject1.SlotId < this.client.Player.Inventory.Length)
			{
				this._lastSlot = invSwap.SlotObject1.SlotId;
				this._lastItem = this.client.Player.Inventory[invSwap.SlotObject1.SlotId];
				this.client.Player.Inventory[invSwap.SlotObject1.SlotId] = invSwap.SlotObject1.ObjectType;
			}
			else if (invSwap.SlotObject2.objectId == this.client.ObjectId)
			{
				if (invSwap.SlotObject2.SlotId < this.client.Player.Inventory.Length)
				{
					this._lastSlot = invSwap.SlotObject2.SlotId;
					this._lastItem = this.client.Player.Inventory[invSwap.SlotObject2.SlotId];
					this.client.Player.Inventory[invSwap.SlotObject2.SlotId] = invSwap.SlotObject2.ObjectType;
				}
			}
		}
		else
		{
			invSwap.Send = false;
			Console.WriteLine("Canceled invswap!");
		}
		this.Time = invSwap.Time;
	}

	// Token: 0x060004A7 RID: 1191 RVA: 0x0001A12C File Offset: 0x0001832C
	public void InvResult(InvResultPacket invResult)
	{
		if (Settings.Default.EnableAutoLoot && !invResult._9WVS8mgAGMXsp1FYvKoly56WY1E && this._lastSlot > -1)
		{
			this.client.Player.Inventory[this._lastSlot] = this._lastItem;
			Console.WriteLine("Client: Swap failed");
		}
	}

	// Token: 0x060004A8 RID: 1192 RVA: 0x0001A180 File Offset: 0x00018380
	public void Move(MovePacket move)
	{
		if (Settings.Default.EnableAutoLoot && !this._inVault)
		{
			foreach (GameObject gameObject in this.client.Objects.Values.ToList<GameObject>())
			{
				if (Enum.IsDefined(typeof(Bags), gameObject.ObjectType))
				{
					byte b = 0;
					while ((int)b < gameObject.Inventory.Length)
					{
						int num = gameObject.Inventory[(int)b];
						if (num != -1)
						{
							if (this.CheckLootTier((ushort)num))
							{
								if (Settings.Default.AutoLootQuests)
								{
									QuestObjIdPacket questObjIdPacket = (QuestObjIdPacket)Packet.Create(PacketType.QUESTOBJID);
									questObjIdPacket.ObjectId = gameObject.ObjectId;
									questObjIdPacket._4jOLjW4f3NFdoiR8aTchgxYgk8f = new int[0];
									this._lootQuest = gameObject.ObjectId;
									this.client.SendToClient(questObjIdPacket);
								}
								if (gameObject.ServerPosition.DistanceSquaredTo(move.NewPosition) <= 1.0)
								{
									if (move._Nx46RcGIU0H1BCGWaJXjN1ieopt - this.Time > 600)
									{
										this.PickupItem(move.NewPosition, move._Nx46RcGIU0H1BCGWaJXjN1ieopt, gameObject.ObjectId, num, b);
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
	private void PickupItem(Location pos, int time, int bagObjectId, int targetType, byte slotId)
	{
		if (targetType == 2594 && this.client.Player.HealthpotCount < 6)
		{
			this.InvSwap(time, pos, bagObjectId, targetType, slotId, this.client.Player.ObjectId, -1, 254, GameData.Items.ByID((ushort)targetType).Name);
			return;
		}
		if (targetType == 2595 && this.client.Player.MagicpotCount < 6)
		{
			this.InvSwap(time, pos, bagObjectId, targetType, slotId, this.client.Player.ObjectId, -1, byte.MaxValue, GameData.Items.ByID((ushort)targetType).Name);
			return;
		}
		int num = this.client.Player.HasBackpack ? 20 : 12;
		byte b = 4;
		while ((int)b < num)
		{
			if (this.client.Player.Inventory[(int)b] == -1)
			{
				this.InvSwap(time, pos, this.client.Player.ObjectId, -1, b, bagObjectId, targetType, slotId, GameData.Items.ByID((ushort)targetType).Name);
				return;
			}
			b += 1;
		}
	}

	// Token: 0x060004AA RID: 1194 RVA: 0x0001A418 File Offset: 0x00018618
	private void InvSwap(int time, Location position, int objectId1, int itemType1, byte slotId1, int objectId2, int itemType2, byte slotId2, string itemName)
	{
		InvSwapPacket invSwapPacket = (InvSwapPacket)Packet.Create(PacketType.INVSWAP);
		invSwapPacket.Time = time;
		invSwapPacket.Position = position;
		invSwapPacket.SlotObject1 = new SlotObject
		{
			objectId = objectId1,
			ObjectType = itemType1,
			SlotId = (int)slotId1
		};
		invSwapPacket.SlotObject2 = new SlotObject
		{
			objectId = objectId2,
			ObjectType = itemType2,
			SlotId = (int)slotId2
		};
		this.Time = time;
		this.client.SendToServer(invSwapPacket);
		this.client.SendToClient("AutoLoot", "Looting " + itemName);
	}

	// Token: 0x060004AB RID: 1195 RVA: 0x0001A4B4 File Offset: 0x000186B4
	private bool CheckLootTier(ushort itemId)
	{
		ItemStructure itemStructure = GameData.Items.ByID(itemId);
		if (itemStructure == null)
		{
			return false;
		}
		if (Settings.Default.AutoLootHealingPotions && itemStructure.Name == "Health Potion" && (Settings.Default.AutoLootOverfillHP || client.Player.HealthpotCount < 6))
		{
			return true;
		}
		if (Settings.Default.AutoLootHealingPotions && itemStructure.Name == "Magic Potion" && (Settings.Default.AutoLootOverfillMP || this.client.Player.MagicpotCount < 6))
		{
			return true;
		}
		if (Settings.Default.AutoLootStatPotions && AutoLoot.statPotions.Contains(itemStructure.Name))
		{
			return true;
		}
		if (Settings.Default.AutoLootUTs && itemStructure.Tier == Tiers.UT)
		{
			if (itemStructure._nUppUQcAEeCO15B53eSIwjaZ8yK != 10)
			{
				if (itemStructure._nUppUQcAEeCO15B53eSIwjaZ8yK != 26)
				{
					return true;
				}
			}
		}
		if (Settings.Default.AutoLootMarks && itemStructure.Name.Contains("Mark of "))
		{
			return true;
		}
		switch (itemStructure._nUppUQcAEeCO15B53eSIwjaZ8yK)
		{
		case 1:
		case 2:
		case 3:
		case 8:
		case 17:
		case 24:
			return (int)itemStructure.Tier >= Settings.Default.AutoLootWeaponTierThreshold;
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
			return (int)itemStructure.Tier >= Settings.Default.AutoLootAbilityTierThreshold;
		case 6:
		case 7:
		case 14:
			return (int)itemStructure.Tier >= Settings.Default.AutoLootArmorTierThreshold;
		case 9:
			return (int)itemStructure.Tier >= Settings.Default.AutoLootRingTierThreshold;
		}
		return false;
	}

	// Token: 0x040005B7 RID: 1463
	private Client client;

	// Token: 0x040005B8 RID: 1464
	private int Time = -1;

	// Token: 0x040005B9 RID: 1465
	private bool _inVault;

	// Token: 0x040005BA RID: 1466
	private int _lastSlot = -1;

	// Token: 0x040005BB RID: 1467
	private int _lastItem = -1;

	// Token: 0x040005BC RID: 1468
	private int _lastQuest = -1;

	// Token: 0x040005BD RID: 1469
	private int _lootQuest = -1;

	// Token: 0x040005BE RID: 1470
	private static readonly string[] statPotions = new string[]
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
