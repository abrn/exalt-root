using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using ExaltMultiTool.Properties;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x020000AB RID: 171
internal class AutoAbility
{
	// Token: 0x06000492 RID: 1170 RVA: 0x00018C0C File Offset: 0x00016E0C
	public AutoAbility(Client client)
	{
		this.client = client;
		/*
An exception occurred when decompiling this method (06000492)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void _STe2bPkqPGrT82rYFTNvXVBAs1c::.ctor(_U5AaPl8DapnIJVdc80Ay29WdWR4)
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
		;
	}

	// Token: 0x06000493 RID: 1171 RVA: 0x00018D04 File Offset: 0x00016F04
	public void MapInfo(MapInfoPacket mapInfo)
	{
		this._isSafeMap = this._safeMapNames.Contains(mapInfo.Name);
		this._lastUseItem = 0;
		this._nextAltAttack = 0;
		this._lastAutoAbilityAttempt = 0;
	}


	// Token: 0x06000496 RID: 1174 RVA: 0x00018DA4 File Offset: 0x00016FA4
	public void PlayerShoot(PlayerShootPacket playerShoot)
	{
		this._fakeMousePosition = this.client.Player.ClientPosition.PositionInDirection((double)playerShoot.Angle, 6.0);
	}

	// Token: 0x06000497 RID: 1175 RVA: 0x00018DDC File Offset: 0x00016FDC
	public void UseItem(UseItemPacket useItem)
	{
		if (useItem.SlotObject.SlotId == 1 && Settings.Default.EnableAutoAbility && useItem.Time - this._lastUseItem < 500)
		{
			useItem.Send = false;
			this.client.SendToClient("AutoAbility", "Ability is on cooldown!");
			return;
		}
		this._lastUseItem = useItem.Time;
	}

	// Token: 0x06000499 RID: 1177 RVA: 0x00018F5C File Offset: 0x0001715C
	public void move(MovePacket move)
	{
		if (this._WYanjAEAeovcd96Ghpur7VAJRUlA)
		{
			this._WYanjAEAeovcd96Ghpur7VAJRUlA = false;
			this._sOwc8Hz5GYPFJ7BLvgRX72MvmaK(move._Nx46RcGIU0H1BCGWaJXjN1ieopt, 2595, byte.MaxValue, move.NewPosition);
		}
	}

	// Token: 0x0600049A RID: 1178 RVA: 0x00018F94 File Offset: 0x00017194
	private void _sOwc8Hz5GYPFJ7BLvgRX72MvmaK(int time, int itemType, byte slotId, Location location)
	{
		UseItemPacket lylWoxWrca2h31SiYiDb8gyQP0o = (UseItemPacket)Packet.Create(PacketType.USEITEM);
		lylWoxWrca2h31SiYiDb8gyQP0o.SlotObject = new SlotObject
		{
			objectId = this.client.PlayerId,
			ObjectType = itemType,
			SlotId = (int)slotId
		};
		lylWoxWrca2h31SiYiDb8gyQP0o.Time = time;
		lylWoxWrca2h31SiYiDb8gyQP0o.ItemUsePos = location;
		lylWoxWrca2h31SiYiDb8gyQP0o.UseType = ((slotId >= 254) ? 0 : 1);
		this.client.SendToServer(lylWoxWrca2h31SiYiDb8gyQP0o);
	}

	// Token: 0x0600049B RID: 1179 RVA: 0x00019008 File Offset: 0x00017208
	public void Move(MovePacket move)
	{
		if (!Settings.Default.EnableAutoAbility || Settings.Default.FameBlockAbilities)
		{
			return;
		}
		if (this._isSafeMap)
		{
			return;
		}
		if (this.client.Player == null)
		{
			return;
		}
		if (time - this._lastAutoAbilityAttempt < 1000)
		{
			return;
		}
		int num = this.client.Player.Inventory[1];
		if (num == -1)
		{
			return;
		}
		ItemStructure itemStructure = GameData.Items.ByID((ushort)num);
		if (itemStructure == null)
		{
			return;
		}
		int time = move.Time;
		if (time - this._lastUseItem < 500)
		{
			return;
		}
		if (time < this._nextAltAttack)
		{
			return;
		}
		ushort objectType = this.client.Player.ObjectType;
		if (objectType != 768)
		{
			switch (objectType)
			{
			case 782:
				if (!this.client.Player.isUnstable())
				{
					this.ShootAimAngle(itemStructure, time, double.NaN, 12.0, this.client.Player.ClientPosition);
					this._lastAutoAbilityAttempt = time;
				}
				return;
			case 783:
				return;
			case 784:
				if (num == 1976 || this.client.Player.Health * 100 / this.client.Player.MaxHealth <= Settings.Default.AutoAbilityHealHpPercent)
				{
					this.UseAltWeapon(itemStructure, time, this.client.Player.ClientPosition, 1);
					this._lastAutoAbilityAttempt = time;
				}
				return;
			case 785:
				if (!this.client.Player.isUnstable())
				{
					float num2;
					if (num != 8994)
					{
						if (num != 9152)
						{
							num2 = 4.4f;
						}
						else
						{
							num2 = 6.4f;
						}
					}
					else
					{
						num2 = 4.6f;
					}
					float num3 = num2;
					this.ShootAimAngle(itemStructure, time, double.NaN, (double)num3, this.client.Player.ClientPosition);
					return;
				}
				return;
			default:
				switch (objectType)
				{
				case 796:
					this.UseAltWeapon(itemStructure, time, this.client.Player.ClientPosition, 1);
					this._lastAutoAbilityAttempt = time;
					return;
				case 797:
				case 799:
					goto IL_39A;
				case 798:
				case 804:
					return;
				case 800:
					if (this.client.Player.isUnstable())
					{
						return;
					}
					break;
				case 801:
					if (this.client.Player.isUnstable())
					{
						return;
					}
					break;
				case 802:
					if (this.client.Player.isUnstable())
					{
						this._lastAutoAbilityAttempt = time;
						return;
					}
					break;
				case 803:
					if (!this.client.Player.isUnstable())
					{
						this.UseAltWeapon(itemStructure, time, this.client.Player.ClientPosition, 1);
						this._lastAutoAbilityAttempt = time;
						return;
					}
					return;
				case 805:
					if (!this.client.Player.isUnstable())
					{
						this.ShootAimAngle(itemStructure, time, double.NaN, 7.0, this.client.Player.ClientPosition);
						this._lastAutoAbilityAttempt = time;
						return;
					}
					return;
				case 806:
					if (this.client.Player.isNinjaSpeedy())
					{
						this.UseAltWeapon(itemStructure, time, this.client.Player.ClientPosition, 1);
						this._lastAutoAbilityAttempt = time;
						return;
					}
					return;
				default:
					return;
				}
				this.UseAltWeapon(itemStructure, time, false);
				return;
			}
		}
		else if (num == 2650)
		{
			return;
		}
		IL_39A:
		this.UseAltWeapon(itemStructure, time, this.client.Player.ClientPosition, 1);
		this._lastAutoAbilityAttempt = time;
	}

	// Token: 0x0600049C RID: 1180 RVA: 0x000193D0 File Offset: 0x000175D0
	private void UseAltWeapon(ItemStructure item, int time, Location position = null, byte useType = 1)
	{
		if (position == null)
		{
			position = this.client.Player.ClientPosition;
		}
		int num = (int)item._tYSs4Ly8XTHvXe9jwJ9dhQMMttd;
		num = ((num == 0) ? 500 : (num * 1000));
		this._nextAltAttack = time + num;
		this._lastUseItem = time;
		UseItemPacket useItemPacket = (UseItemPacket)Packet.Create(PacketType.USEITEM);
		useItemPacket.SlotObject = new SlotObject
		{
			objectId = this.client.Player.ObjectId,
			SlotId = 1,
			ObjectType = this.client.Player.Inventory[1]
		};
		useItemPacket.Time = time;
		useItemPacket.UseType = useType;
		useItemPacket.ItemUsePos = position;
		this.client.SendToServer(useItemPacket);
		if (Settings.Default.AutoAbilityNotifications)
		{
			this.client.SendToClient("AutoAbility activated!");
		}
	}

	// Token: 0x0600049E RID: 1182 RVA: 0x000195BC File Offset: 0x000177BC
	private void Shoot(int Time)
	{
		if (this._isSafeMap)
		{
			return;
		}
		if (this.client.Player == null)
		{
			return;
		}
		int num = this.client.Player.Inventory[1];
		if (num == -1)
		{
			return;
		}
		if (this.client.Player.isStunned())
		{
			return;
		}
		if (this.client.Player.isPaused())
		{
			return;
		}
		ItemStructure itemStructure = GameData.Items.ByID((ushort)num);
		if (itemStructure == null)
		{
			return;
		}
		if (itemStructure.NumProjectiles != 0)
		{
			return;
		}
		for (int i = 0; i < itemStructure.NumProjectiles; i++)
		{
			PlayerShootPacket projectile = (PlayerShootPacket)Packet.Create(PacketType.PLAYERSHOOT);
			projectile.Angle = 0f;
			projectile.Position = new Location(this.client.Player.ClientPosition.X + Math.Cos((double)projectile.Angle) * 0.3, this.client.Player.ClientPosition.Y + Math.Sin((double)projectile.Angle) * 0.3);
			projectile.Time = Time;
			projectile.BulletId = this.client.GetBulletId();
			projectile.ContainerType = (short)itemStructure.ID;
			AllyShootPacket allyShootPacket = (AllyShootPacket)Packet.Create(PacketType.ALLYSHOOT);
			allyShootPacket.Angle = projectile.Angle;
			allyShootPacket.BulletId = projectile.BulletId;
			allyShootPacket.ContainerType = projectile.ContainerType;
			allyShootPacket.OwnerId = this.client.Player.ObjectId;
			this.client.SendToServer(projectile);
			this.client.SendToClient(allyShootPacket);
		}
	}

	// Token: 0x0600049F RID: 1183 RVA: 0x00019764 File Offset: 0x00017964
	private void ShootAimAngle(ItemStructure item, int time, double projSpeed, double maxDist, Location playerPos)
	{
		maxDist *= maxDist;
		Location location = new Location(this._fakeMousePosition.X, this._fakeMousePosition.Y);
		Location location2 = Location.Empty;
		Location location3 = Location.Empty;
		double num = double.MaxValue;
		int num2 = int.MinValue;
		int num3 = int.MinValue;
		int num4 = 2;
		if (Settings.Default.AutoAbilityClosestEnemy)
		{
			num4 = 2;
		}
		if (Settings.Default.AutoAbilityStrongestEnemy)
		{
			num4 = 1;
		}
		int num5 = 5;
		num5 *= num5;
		bool enemyIgnore = Settings.Default.EnemyIgnore;
		int autoAbilityMinimumEnemyHealthThreshold = Settings.Default.AutoAbilityMinimumEnemyHealthThreshold;
		bool flag = true;
		bool flag2 = true;
		for (; ; )
		{
			if (num4 == 0)
			{
				using (Dictionary<int, GameObject>.ValueCollection.Enumerator enumerator = this.client.Enemies.Values.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						GameObject gameObject = enumerator.Current;
						bool boss = gameObject.Boss;
						if (gameObject.Character && (!flag || boss) && !gameObject.isInvulnerable() && gameObject.Health >= 0 && (enemyIgnore || !Settings.Default.FameIngoredEnemies.Contains((int)gameObject.ObjectType)) && gameObject.MaxHealth >= autoAbilityMinimumEnemyHealthThreshold)
						{
							if (double.IsNaN(projSpeed))
							{
								location2 = new Location(gameObject.ServerPosition.X, gameObject.ServerPosition.Y);
							}
							else
							{
								location2 = new Location(gameObject.ClientPosition.X, gameObject.ClientPosition.Y);
							}
							if (location2 != Location.Empty)
							{
								double num6 = playerPos.DistanceSquaredTo(gameObject.ClientPosition);
								if (num6 <= maxDist)
								{
									num6 = playerPos.DistanceSquaredTo(location);
									if (num6 <= (double)num5)
									{
										if (flag && boss)
										{
											flag2 = false;
											location3 = (Location)location2.Clone();
											break;
										}
										if (num6 <= num)
										{
											num = num6;
											location3 = (Location)location2.Clone();
										}
									}
								}
							}
						}
					}
					goto IL_4E3;
				}
				goto IL_1EF;
			}
			goto IL_1EF;
		IL_4E3:
			if (flag)
			{
				if (flag2)
				{
					flag = false;
				}
			}
			else
			{
				flag2 = false;
			}
			if (!flag2)
			{
				break;
			}
			continue;
		IL_1EF:
			if (num4 == 1)
			{
				using (Dictionary<int, GameObject>.ValueCollection.Enumerator enumerator = this.client.Enemies.Values.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						GameObject gameObject2 = enumerator.Current;
						bool boss = gameObject2.Boss;
						if (gameObject2.Character && (!flag || boss) && !gameObject2.isInvulnerable() && gameObject2.Health >= 0 && (enemyIgnore || !Settings.Default.FameIngoredEnemies.Contains((int)gameObject2.ObjectType)) && gameObject2.MaxHealth >= autoAbilityMinimumEnemyHealthThreshold)
						{
							if (double.IsNaN(projSpeed))
							{
								location2 = new Location(gameObject2.ServerPosition.X, gameObject2.ServerPosition.Y);
							}
							else
							{
								location2 = new Location(gameObject2.ClientPosition.X, gameObject2.ClientPosition.Y);
							}
							if (location2 != Location.Empty && gameObject2.MaxHealth >= num3)
							{
								if (gameObject2.MaxHealth == num3)
								{
									if (gameObject2.Health <= num2)
									{
										double num6 = playerPos.DistanceSquaredTo(gameObject2.ClientPosition);
										if ((gameObject2.Health != num2 || num6 <= num) && num6 < maxDist)
										{
											num3 = gameObject2.MaxHealth;
											num2 = gameObject2.Health;
											location3 = (Location)location2.Clone();
											num = num6;
										}
									}
								}
								else
								{
									double num6 = playerPos.DistanceSquaredTo(gameObject2.ClientPosition);
									if (num6 < maxDist)
									{
										if (flag && boss)
										{
											flag2 = false;
											location3 = location2;
											break;
										}
										num3 = gameObject2.MaxHealth;
										num2 = gameObject2.Health;
										num = num6;
										location3 = (Location)location2.Clone();
									}
								}
							}
						}
					}
					goto IL_4E3;
				}
			}
			if (num4 == 2)
			{
				foreach (GameObject gameObject3 in this.client.Enemies.Values)
				{
					bool boss = gameObject3.Boss;
					if (gameObject3.Character && (!flag || boss) && !gameObject3.isInvulnerable() && gameObject3.Health >= 0 && (enemyIgnore || !Settings.Default.FameIngoredEnemies.Contains((int)gameObject3.ObjectType)) && gameObject3.MaxHealth >= autoAbilityMinimumEnemyHealthThreshold)
					{
						if (double.IsNaN(projSpeed))
						{
							location2 = new Location(gameObject3.ServerPosition.X, gameObject3.ServerPosition.Y);
						}
						else
						{
							location2 = new Location(gameObject3.ClientPosition.X, gameObject3.ClientPosition.Y);
						}
						if (location2 != Location.Empty)
						{
							double num6 = playerPos.DistanceSquaredTo(gameObject3.ClientPosition);
							if (num6 < maxDist)
							{
								if (flag && boss)
								{
									flag2 = false;
									location3 = (Location)location2.Clone();
									break;
								}
								if (num6 < num)
								{
									num = num6;
									location3 = (Location)location2.Clone();
								}
							}
						}
					}
				}
				goto IL_4E3;
			}
			goto IL_4E3;
		}
		if (!location3.Equals(Location.Empty))
		{
			this.UseAltWeapon(item, time, location3, 1);
			this._lastAutoAbilityAttempt = time;
		}
/*
An exception occurred when decompiling this method (0600049F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void _STe2bPkqPGrT82rYFTNvXVBAs1c::_XTBDQHoktC19mrPA2ZZFbUSRLV3(_66CXgP76qcRM5NMLzlNSbhfhXbG,System.Int32,System.Double,System.Double,Location)
---> System.OverflowException: Array dimensions exceeded supported range.
at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackSlot.ModifyStack(StackSlot[] stack, Int32 popCount, Int32 pushCount, ByteCode pushDefinition) in C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 47
at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 387
at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 269
at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
--- End of inner exception stack trace ---
at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1545
*/;
	}

	// Token: 0x060004A0 RID: 1184 RVA: 0x00019CCC File Offset: 0x00017ECC
	private Location DeflectedPosition(Location playerCoords, Location targetCoords, Location targetVec, double projSpeed)
	{
		Location location = targetCoords.Subtract(playerCoords);
		double num = 2.0 * (targetVec.DotProduct(targetVec) - projSpeed * projSpeed);
		double num2 = 2.0 * location.DotProduct(targetVec);
		double num3 = location.DotProduct(location);
		double num4 = Math.Sqrt(num2 * num2 - 2.0 * num * num3);
		double num5 = (-num2 + num4) / num;
		double num6 = (-num2 - num4) / num;
		if (num5 < num6 && num5 >= 0.0)
		{
			targetVec.ScaleBy(num5);
		}
		else if (num6 >= 0.0)
		{
			targetVec.ScaleBy(num6);
		}
		return targetCoords.Add(targetVec);
	}


	// Token: 0x040005AA RID: 1450
	private int _lastAutoAbilityAttempt;
	private Client client;

	// Token: 0x040005AB RID: 1451
	private bool _isSafeMap;

	// Token: 0x040005AC RID: 1452
	private int _nextAltAttack;

	// Token: 0x040005AD RID: 1453
	private int _lastUseItem;

	// Token: 0x040005AE RID: 1454
	private Location _fakeMousePosition;

	// Token: 0x040005AF RID: 1455
	private Thread _KRrYunYpkRXhMLhAReiDT9amppr;

	// Token: 0x040005B0 RID: 1456
	private bool _4nYbaXoKnK4AO4BrJU0ZJDqW1Q6;

	// Token: 0x040005B1 RID: 1457
	private bool _WYanjAEAeovcd96Ghpur7VAJRUlA;

	// Token: 0x040005B2 RID: 1458
	private readonly List<string> _safeMapNames;

}
