using System;
using System.Collections.Generic;
using System.Linq;
using ExaltMultiTool.Properties;

// Token: 0x020000B3 RID: 179
internal class FameHelper
{
	// Token: 0x060004DA RID: 1242 RVA: 0x0001BFBC File Offset: 0x0001A1BC
	public FameHelper(Client client)
	{
		this.client = client;
	}

	// Token: 0x060004DB RID: 1243 RVA: 0x0001BFE4 File Offset: 0x0001A1E4
	public void MapInfo()
	{
		Dictionary<int, int> originalConditions = this._originalConditions;
		if (originalConditions != null)
		{
			originalConditions.Clear();
		}
		this._originalConditions = new Dictionary<int, int>();
		Dictionary<int, bool> conditionModified = this._conditionModified;
		if (conditionModified != null)
		{
			conditionModified.Clear();
		}
		this._conditionModified = new Dictionary<int, bool>();
	}

	// Token: 0x060004DC RID: 1244 RVA: 0x0001C02C File Offset: 0x0001A22C
	public void Update(UpdatePacket update)
	{
		foreach (Entity entity in update.NewObjs)
		{
			this.AddCond(entity.Status);
			this.HandleStatus(entity.Status);
		}
	}

	// Token: 0x060004DD RID: 1245 RVA: 0x0001C06C File Offset: 0x0001A26C
	public void NewTick(NewTickPacket newTick)
	{
		List<int> list = new List<int>();
		foreach (Status status in newTick.Statuses)
		{
			this.AddCond(status);
			this.HandleStatus(status);
			list.Add(status.ObjectId);
		}
		foreach (KeyValuePair<int, GameObject> keyValuePair in this.client.Enemies)
		{
			if (!list.Contains(keyValuePair.Key))
			{
				Status status2 = this.CreateStatus(keyValuePair.Key, keyValuePair.Value.Effects1);
				this.HandleStatus(status2);
				newTick.Statuses.Add(status2);
			}
		}
		if (Settings.Default.EnableFameTools && Settings.Default.FameBlockAbilities)
		{
			this._zeroedLastTick = true;
			newTick.Statuses.Add(new Status
			{
				ObjectId = this.client.ObjectId,
				Position = Location.Empty,
				Data = new List<StatData>
					{
						new StatData
						{
							Id = StatsType.MP,
							IntValue = 0,
							StringValue = string.Empty
						}
					}
			});
			return;
		}
		if (this._zeroedLastTick)
		{
			this._zeroedLastTick = false;
			newTick.Statuses.Add(new Status
			{
				ObjectId = this.client.ObjectId,
				Position = Location.Empty,
				Data = new List<StatData>
					{
						new StatData
						{
							Id = StatsType.MP,
							IntValue = this._realMpValue,
							StringValue = string.Empty
						}
					}
			});
		}
		/*
An exception occurred when decompiling this method (060004DD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void _OAt1v1fa3mV9nVCKyiOkBnC7BvM::_hVmuXIrMhcPYMqFwACPjjq5nVnC(_m0LaYtYXCYLft6qTol5zHQxjnf3)
 ---> System.ArgumentOutOfRangeException: Non-negative number required.
Parameter name: length
   at System.Array.Copy(Array sourceArray, Int32 sourceIndex, Array destinationArray, Int32 destinationIndex, Int32 length, Boolean reliable)
   at System.Array.Copy(Array sourceArray, Array destinationArray, Int32 length)
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackSlot.ModifyStack(StackSlot[] stack, Int32 popCount, Int32 pushCount, ByteCode pushDefinition) in C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 49
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 387
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 269
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1545
*/
	}

	// Token: 0x060004DE RID: 1246 RVA: 0x0001C24C File Offset: 0x0001A44C
	private Status CreateStatus(int enemyId, int condition)
	{
		this._conditionModified[enemyId] = true;
		return new Status
		{
			ObjectId = enemyId,
			Position = this.client.Enemies[enemyId].ServerPosition,
			Data = new List<StatData>
			{
				new StatData
				{
					Id = StatsType.Effects,
					IntValue = condition,
					StringValue = string.Empty
				}
			}
		};
	}

	// Token: 0x060004DF RID: 1247 RVA: 0x0001C2C4 File Offset: 0x0001A4C4
	private void AddCond(Status status)
	{
		foreach (StatData eawaZQvtvbptP3yFgHw8DNBicDZ in status.Data)
		{
			if (StatsType.Id(eawaZQvtvbptP3yFgHw8DNBicDZ.Id, StatsType.Effects))
			{
				if (this._originalConditions.ContainsKey(status.ObjectId))
				{
					this._originalConditions[status.ObjectId] = eawaZQvtvbptP3yFgHw8DNBicDZ.IntValue;
					break;
				}
				this._originalConditions.Add(status.ObjectId, eawaZQvtvbptP3yFgHw8DNBicDZ.IntValue);
				this._conditionModified.Add(status.ObjectId, false);
				break;
			}
		}
	}

	// Token: 0x060004E0 RID: 1248 RVA: 0x0001C37C File Offset: 0x0001A57C
	private void HandleStatus(Status status)
	{
		if (status.ObjectId == this.client.PlayerId)
		{
			foreach (StatData statData in status.Data)
			{
				if (StatsType.Id(statData.Id, StatsType.MP))
				{
					this._realMpValue = statData.IntValue;
					break;
				}
			}
		}
		if (!this.client.Enemies.ContainsKey(status.ObjectId))
		{
			return;
		}
		if (!Settings.Default.EnableFameTools)
		{
			this.ApplyOriginalConditionStatdata(status.Data, status.ObjectId);
			return;
		}
		if (!Settings.Default.FameDontHitCubes && !Settings.Default.FameOnlyHitGods && !Settings.Default.FameDontHitIgnores)
		{
			this.ApplyOriginalConditionStatdata(status.Data, status.ObjectId);
			return;
		}
		GameObject gameObject = this.client.Enemies[status.ObjectId];
		if ((Settings.Default.FameDontHitCubes && gameObject.Cube) || (Settings.Default.FameOnlyHitGods && !gameObject.God) || (Settings.Default.FameDontHitIgnores && Settings.Default.FameIngoredEnemies.Contains((int)gameObject.ObjectType)))
		{
			this._conditionModified[gameObject.ObjectId] = true;
			this.AddPauseToStatdata(status.Data);
		}
	}

	// Token: 0x060004E1 RID: 1249 RVA: 0x0001C4F0 File Offset: 0x0001A6F0
	private void ApplyOriginalConditionStatdata(List<StatData> statusData, int oid)
	{
		if (!this._conditionModified[oid])
		{
			return;
		}
		statusData.Add(new StatData
		{
			Id = StatsType.Effects,
			IntValue = this._originalConditions[oid],
			StringValue = string.Empty
		});
	}

	// Token: 0x060004E2 RID: 1250 RVA: 0x0001C540 File Offset: 0x0001A740
	private void AddPauseToStatdata(List<StatData> statusData)
	{
		bool flag = false;
		foreach (StatData statData in statusData)
		{
			if (!StatsType.Id(statData.Id, StatsType.Effects))
			{
				statData.IntValue |= 3145728;
				flag = true;
			}
		}
		if (!flag)
		{
			statusData.Add(new StatData
			{
				Id = StatsType.Effects,
				IntValue = 3145728,
				StringValue = ""
			});
		}
	}

	// Token: 0x060004E3 RID: 1251 RVA: 0x0001C5E0 File Offset: 0x0001A7E0
	public void text(PlayerTextPacket playerText)
	{
		if (!Settings.Default.EnableFameTools)
		{
			return;
		}
		if ((Settings.Default.FameBlockTeleports && playerText.Text.StartsWith("/tp ")) || playerText.Text.StartsWith("/teleport "))
		{
			playerText.Send = false;
		}
	}

	// Token: 0x060004E4 RID: 1252 RVA: 0x0001C634 File Offset: 0x0001A834
	public void Teleport(TeleportPacket teleport)
	{
		if (!Settings.Default.EnableFameTools)
		{
			return;
		}
		if (Settings.Default.FameBlockTeleports)
		{
			teleport.Send = false;
			this.client.CreateOryxNotification("Fame Block", "Teleport blocked for Boots on the Ground!");
			//TextPacket.CreateOryxNotification("Fame Block", "Teleport blocked for Boots on the Ground!");
		}
	}

	// Token: 0x060004E5 RID: 1253 RVA: 0x0001C678 File Offset: 0x0001A878
	public void UseItem(UseItemPacket useItem)
	{
		if (!Settings.Default.EnableFameTools)
		{
			return;
		}
		if (useItem.SlotObject.objectId != this.client.PlayerId)
		{
			return;
		}
		if (Settings.Default.FameBlockDrinking)
		{
			/*ItemStructure*/ItemStructure itemStructure = GameData.Items.ByID((ushort)useItem.SlotObject.ObjectType);
			if (itemStructure != null)
			{
				if (itemStructure.Potion)
				{
					useItem.Send = false;
				}
			}
		}
	}

	// Token: 0x040005E4 RID: 1508
	private Client client;

	// Token: 0x040005E5 RID: 1509
	private object _originalCondLock = new object();

	// Token: 0x040005E6 RID: 1510
	private Dictionary<int, int> _originalConditions;

	// Token: 0x040005E7 RID: 1511
	private Dictionary<int, bool> _conditionModified;

	// Token: 0x040005E8 RID: 1512
	private bool _zeroedLastTick;

	// Token: 0x040005E9 RID: 1513
	private int _realMpValue;
}
