using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using ExaltMultiTool.Properties;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x020000AB RID: 171
internal class AutoNexus2
{
	// Token: 0x06000492 RID: 1170 RVA: 0x00018C0C File Offset: 0x00016E0C
	public AutoNexus2(Client client)
	{
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
*/;
	}

	// Token: 0x06000493 RID: 1171 RVA: 0x00018D04 File Offset: 0x00016F04
	public void MapInfo(MapInfoPacket mapInfo)
	{
		this._2quYVWYoLc77QY6uJhajp7qBEFF = this._D0ydY92aMnivKXLmhWYnzjIuo7b.Contains(mapInfo._Jp3DtIV4aAYZY26sVsXpPQjBRGO);
		this._LcADAK1yIEbTQq1vfRipPNFwKLC = 0;
		this._icFiCxIg3nuFxO6qEhyXAJ1fqVM = 0;
	}

	// Token: 0x06000494 RID: 1172 RVA: 0x00018D38 File Offset: 0x00016F38
	public void _1lYB9SyYVs1zUAIHgLGbUs7pmeb()
	{
	}

	// Token: 0x06000495 RID: 1173 RVA: 0x00018D48 File Offset: 0x00016F48
	private void _K74DY77Mq8T8DRNXctlEP68HLhDA()
	{
		Thread.Sleep(1000);
		PingPacket ykOkPpwVP47hYsRllP7CSUIW8im = (PingPacket)Packet.Create(PacketType.PING);
		ykOkPpwVP47hYsRllP7CSUIW8im.Serial = -1;
		while (this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Connected)
		{
			if (Settings.Default.EnableAutoAbility)
			{
				this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.SendToClient(ykOkPpwVP47hYsRllP7CSUIW8im);
			}
			Thread.Sleep(70);
		}
	}

	// Token: 0x06000496 RID: 1174 RVA: 0x00018DA4 File Offset: 0x00016FA4
	public void _Khyl0TTBfDtVskFpnw4HUKIFLHj(_FbqBESNaaIBpK5dNK9X5lWOOll5 playerShoot)
	{
		this._IsYQ6CL3u3MPkFFNleTLf7tNE5A = this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player._G6mmnFaa6rCvH24Jwj69ERi78ww.PositionInDirection((double)playerShoot._49dbaYgeVV0XCrIkHrqAGgDf2mFA, 6.0);
	}

	// Token: 0x06000497 RID: 1175 RVA: 0x00018DDC File Offset: 0x00016FDC
	public void _byANTPGcPV95u6KbP2GDQqgUZ1f(UseItemPacket useItem)
	{
		if (useItem.SlotObject._uKGrcCaKPH5uzoPQhtn5OnB2jAL == 1 && Settings.Default.EnableAutoAbility && useItem._Nx46RcGIU0H1BCGWaJXjN1ieopt - this._LcADAK1yIEbTQq1vfRipPNFwKLC < 500)
		{
			useItem.Send = false;
			this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.SendToClient("AutoAbility", "Ability is on cooldown!");
			return;
		}
		this._LcADAK1yIEbTQq1vfRipPNFwKLC = useItem._Nx46RcGIU0H1BCGWaJXjN1ieopt;
	}

	// Token: 0x06000498 RID: 1176 RVA: 0x00018E40 File Offset: 0x00017040
	public void NewTick(NewTickPacket newTick)
	{
		foreach (Status seOURj9wT08Ssc6bZOctUjk0KXi in newTick.Statuses)
		{
			if (seOURj9wT08Ssc6bZOctUjk0KXi.ObjectId == this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player.ObjectId)
			{
				bool flag = true;
				foreach (StatData eawaZQvtvbptP3yFgHw8DNBicDZ in seOURj9wT08Ssc6bZOctUjk0KXi.Data)
				{
					if (StatsType.Id(eawaZQvtvbptP3yFgHw8DNBicDZ.Id, StatsType.Effects))
					{
						flag = ((eawaZQvtvbptP3yFgHw8DNBicDZ.IntValue & 2) != 0);
						break;
					}
				}
				if (Settings.Default.AutoAbilityAutoMP && this._4nYbaXoKnK4AO4BrJU0ZJDqW1Q6 && !flag && this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player._TVtbKb9IDpIOm44EVAA4vhHuEBL > 0)
				{
					this._WYanjAEAeovcd96Ghpur7VAJRUlA = true;
				}
				this._4nYbaXoKnK4AO4BrJU0ZJDqW1Q6 = ((this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player._9WuxzHMDBJLJDLP6NlgGdo38O6r & 2) != 0);
				break;
			}
		}
	}

	// Token: 0x06000499 RID: 1177 RVA: 0x00018F5C File Offset: 0x0001715C
	public void move(MovePacket move)
	{
		if (this._WYanjAEAeovcd96Ghpur7VAJRUlA)
		{
			this._WYanjAEAeovcd96Ghpur7VAJRUlA = false;
			this._sOwc8Hz5GYPFJ7BLvgRX72MvmaK(move._Nx46RcGIU0H1BCGWaJXjN1ieopt, 2595, byte.MaxValue, move._l6SobSknmpzcoMgQdVhaWNqcv8D);
		}
	}

	// Token: 0x0600049A RID: 1178 RVA: 0x00018F94 File Offset: 0x00017194
	private void _sOwc8Hz5GYPFJ7BLvgRX72MvmaK(int time, int itemType, byte slotId, Location location)
	{
		UseItemPacket lylWoxWrca2h31SiYiDb8gyQP0o = (UseItemPacket)Packet.Create(PacketType.USEITEM);
		lylWoxWrca2h31SiYiDb8gyQP0o.SlotObject = new _A3HGGdSvVENqKj3O1HGYDO3Qh8C
		{
			objectId = this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.PlayerId,
			ObjectType = itemType,
			_uKGrcCaKPH5uzoPQhtn5OnB2jAL = (int)slotId
		};
		lylWoxWrca2h31SiYiDb8gyQP0o._Nx46RcGIU0H1BCGWaJXjN1ieopt = time;
		lylWoxWrca2h31SiYiDb8gyQP0o._fbMEQqPOnQITCQFqK3LVLkEtWye = location;
		lylWoxWrca2h31SiYiDb8gyQP0o._zDKahCudqipTR5FObLj9ijwgWo8 = ((slotId >= 254) ? 0 : 1);
		this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.SendToServer(lylWoxWrca2h31SiYiDb8gyQP0o);
	}

	// Token: 0x0600049B RID: 1179 RVA: 0x00019008 File Offset: 0x00017208
	public void _vlQbHVUmhMfK9FbdgASWRBOQ1Tfb(_EwBzQLuZPguBE7vtphoTr6H4ACg pong)
	{
		if (pong._QkGLjNjXWUxjTZhmXs1sKEYLp0F == -1)
		{
			pong.Send = false;
		}
		if (!Settings.Default.EnableAutoAbility || Settings.Default.FameBlockAbilities)
		{
			return;
		}
		if (this._2quYVWYoLc77QY6uJhajp7qBEFF)
		{
			return;
		}
		if (this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player == null)
		{
			return;
		}
		int num = this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player._myJxXFJcH1zIBkZMmXfDOvAh0vcA[1];
		if (num == -1)
		{
			return;
		}
		int nx46RcGIU0H1BCGWaJXjN1ieopt = pong._Nx46RcGIU0H1BCGWaJXjN1ieopt;
		if (nx46RcGIU0H1BCGWaJXjN1ieopt - this._LcADAK1yIEbTQq1vfRipPNFwKLC < 500)
		{
			return;
		}
		if (nx46RcGIU0H1BCGWaJXjN1ieopt < this._icFiCxIg3nuFxO6qEhyXAJ1fqVM)
		{
			return;
		}
		if (this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player._d6odaPuEJmqJn749YMNMKeI9xTi * 100 / this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player._hEsbmlbXONy7ZBQJ7WWzpDvfvgr < Settings.Default.AutoAbilityMinimumManaLeftThreshold)
		{
			return;
		}
		if (this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player._9qGDRscln7cTXJR05AW5wRQE7Go())
		{
			return;
		}
		if (this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player._Mn7u212iJGR2MPhwrp35S0C0CRI())
		{
			return;
		}
		if (this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player._PWIIloW30Zn9FHns5mdVIWN4Gxh())
		{
			return;
		}
		_66CXgP76qcRM5NMLzlNSbhfhXbG 66CXgP76qcRM5NMLzlNSbhfhXbG = _JzyrOApzC09RC3fmb10FDURmyCl.Items.ByID((ushort)num);
		if (66CXgP76qcRM5NMLzlNSbhfhXbG == null)
		{
			return;
		}
		if (66CXgP76qcRM5NMLzlNSbhfhXbG._VpFa8CFamucJQ3qD0BQ0lIFhXke != 0)
		{
			return;
		}
		if ((int)66CXgP76qcRM5NMLzlNSbhfhXbG._ZyGR9cgnDTSMpABHgSdj7cCMywb > this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player._d6odaPuEJmqJn749YMNMKeI9xTi)
		{
			return;
		}
		ushort koPitlGqCPegcnIS2B6efWzp4zO = this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player.ObjectType;
		if (koPitlGqCPegcnIS2B6efWzp4zO != 768)
		{
			switch (koPitlGqCPegcnIS2B6efWzp4zO)
			{
			case 782:
				if (!this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player._qzKy0uCTwAicBeimwrbQpxNj2SB())
				{
					this._XTBDQHoktC19mrPA2ZZFbUSRLV3(66CXgP76qcRM5NMLzlNSbhfhXbG, nx46RcGIU0H1BCGWaJXjN1ieopt, double.NaN, 12.0, this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player._G6mmnFaa6rCvH24Jwj69ERi78ww);
					return;
				}
				return;
			case 783:
				return;
			case 784:
				if (num == 1976 || this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player._sNZat68b2TvW6o582Hg9CFuEJCV * 100 / this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player._hI9BnQSXNqD191WGfzaqXuLrtAm <= Settings.Default.AutoAbilityHealHpPercent)
				{
					this._dd2JXitGcIPo3jwTACw4TCiA36f(66CXgP76qcRM5NMLzlNSbhfhXbG, nx46RcGIU0H1BCGWaJXjN1ieopt, this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player._G6mmnFaa6rCvH24Jwj69ERi78ww, 1);
					return;
				}
				return;
			case 785:
				if (!this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player._qzKy0uCTwAicBeimwrbQpxNj2SB())
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
					this._XTBDQHoktC19mrPA2ZZFbUSRLV3(66CXgP76qcRM5NMLzlNSbhfhXbG, nx46RcGIU0H1BCGWaJXjN1ieopt, double.NaN, (double)num3, this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player._G6mmnFaa6rCvH24Jwj69ERi78ww);
					return;
				}
				return;
			default:
				switch (koPitlGqCPegcnIS2B6efWzp4zO)
				{
				case 796:
					this._dd2JXitGcIPo3jwTACw4TCiA36f(66CXgP76qcRM5NMLzlNSbhfhXbG, nx46RcGIU0H1BCGWaJXjN1ieopt, this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player._G6mmnFaa6rCvH24Jwj69ERi78ww, 1);
					return;
				case 797:
				case 799:
					goto IL_39A;
				case 798:
				case 804:
					return;
				case 800:
					if (this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player._qzKy0uCTwAicBeimwrbQpxNj2SB())
					{
						return;
					}
					break;
				case 801:
					if (this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player._qzKy0uCTwAicBeimwrbQpxNj2SB())
					{
						return;
					}
					break;
				case 802:
					if (this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player._qzKy0uCTwAicBeimwrbQpxNj2SB())
					{
						return;
					}
					break;
				case 803:
					if (!this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player._qzKy0uCTwAicBeimwrbQpxNj2SB())
					{
						this._dd2JXitGcIPo3jwTACw4TCiA36f(66CXgP76qcRM5NMLzlNSbhfhXbG, nx46RcGIU0H1BCGWaJXjN1ieopt, this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player._G6mmnFaa6rCvH24Jwj69ERi78ww, 1);
						return;
					}
					return;
				case 805:
					if (!this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player._qzKy0uCTwAicBeimwrbQpxNj2SB())
					{
						this._XTBDQHoktC19mrPA2ZZFbUSRLV3(66CXgP76qcRM5NMLzlNSbhfhXbG, nx46RcGIU0H1BCGWaJXjN1ieopt, double.NaN, 7.0, this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player._G6mmnFaa6rCvH24Jwj69ERi78ww);
						return;
					}
					return;
				case 806:
					if (this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player._EFPCDm4RoGMqlmfb5q0syd1KVNR())
					{
						this._dd2JXitGcIPo3jwTACw4TCiA36f(66CXgP76qcRM5NMLzlNSbhfhXbG, nx46RcGIU0H1BCGWaJXjN1ieopt, this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player._G6mmnFaa6rCvH24Jwj69ERi78ww, 1);
						return;
					}
					return;
				default:
					return;
				}
				this._NoghcUm3rVisfTeVVN6AoEv6NRD(66CXgP76qcRM5NMLzlNSbhfhXbG, nx46RcGIU0H1BCGWaJXjN1ieopt, false);
				return;
			}
		}
		else if (num == 2650)
		{
			return;
		}
		IL_39A:
		this._dd2JXitGcIPo3jwTACw4TCiA36f(66CXgP76qcRM5NMLzlNSbhfhXbG, nx46RcGIU0H1BCGWaJXjN1ieopt, this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player._G6mmnFaa6rCvH24Jwj69ERi78ww, 1);
	}

	// Token: 0x0600049C RID: 1180 RVA: 0x000193D0 File Offset: 0x000175D0
	private void _dd2JXitGcIPo3jwTACw4TCiA36f(_66CXgP76qcRM5NMLzlNSbhfhXbG item, int time, Location position = null, byte useType = 1)
	{
		if (position == null)
		{
			position = this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player._G6mmnFaa6rCvH24Jwj69ERi78ww;
		}
		int num = (int)item._tYSs4Ly8XTHvXe9jwJ9dhQMMttd;
		num = ((num == 0) ? 500 : (num * 1000));
		this._icFiCxIg3nuFxO6qEhyXAJ1fqVM = time + num;
		this._LcADAK1yIEbTQq1vfRipPNFwKLC = time;
		UseItemPacket lylWoxWrca2h31SiYiDb8gyQP0o = (UseItemPacket)Packet.Create(PacketType.USEITEM);
		lylWoxWrca2h31SiYiDb8gyQP0o.SlotObject = new _A3HGGdSvVENqKj3O1HGYDO3Qh8C
		{
			objectId = this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player.ObjectId,
			_uKGrcCaKPH5uzoPQhtn5OnB2jAL = 1,
			ObjectType = this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player._myJxXFJcH1zIBkZMmXfDOvAh0vcA[1]
		};
		lylWoxWrca2h31SiYiDb8gyQP0o._Nx46RcGIU0H1BCGWaJXjN1ieopt = time;
		lylWoxWrca2h31SiYiDb8gyQP0o._zDKahCudqipTR5FObLj9ijwgWo8 = useType;
		lylWoxWrca2h31SiYiDb8gyQP0o._fbMEQqPOnQITCQFqK3LVLkEtWye = position;
		this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.SendToServer(lylWoxWrca2h31SiYiDb8gyQP0o);
		if (Settings.Default.AutoAbilityNotifications)
		{
			this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._RUDdpffUqrc18m4ldj2l3yrb1t9("AutoAbility activated!");
		}
	}

	// Token: 0x0600049D RID: 1181 RVA: 0x000194AC File Offset: 0x000176AC
	private void _NoghcUm3rVisfTeVVN6AoEv6NRD(_66CXgP76qcRM5NMLzlNSbhfhXbG item, int time, bool requireHeal = false)
	{
		AutoNexus2._HrW7TMzwtcS2gXEYo925wGvpM2e hrW7TMzwtcS2gXEYo925wGvpM2e;
		hrW7TMzwtcS2gXEYo925wGvpM2e._EfubdzaIe4z6qxSHa3TuY5MkdaZ = this;
		hrW7TMzwtcS2gXEYo925wGvpM2e._cGHhVv5nIeTOAHMC7ayCjTSiu5x = requireHeal;
		hrW7TMzwtcS2gXEYo925wGvpM2e._9hUNiOkdmiWFq12cL6vWa0dYbgFA = item._Vzv7oRwBjKStnFVmjJ1K02kmfeb * item._Vzv7oRwBjKStnFVmjJ1K02kmfeb;
		GameObject dbvvb43n9c5uNQ7JklPD1fnCEnv = null;
		int num = 0;
		hrW7TMzwtcS2gXEYo925wGvpM2e._GdHllKQLlXQN2FRsbnovwhoWBwD = 200;
		int num2 = 2;
		foreach (GameObject dbvvb43n9c5uNQ7JklPD1fnCEnv2 in this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Enemies.Values)
		{
			if (!dbvvb43n9c5uNQ7JklPD1fnCEnv2._V9sexWGjUomNGkbTZsOsc8ZyOSC() && !dbvvb43n9c5uNQ7JklPD1fnCEnv2._NzxbS5UeEb1cgkXHHLCWeEWNe7o() && (!hrW7TMzwtcS2gXEYo925wGvpM2e._cGHhVv5nIeTOAHMC7ayCjTSiu5x || dbvvb43n9c5uNQ7JklPD1fnCEnv2._hI9BnQSXNqD191WGfzaqXuLrtAm <= hrW7TMzwtcS2gXEYo925wGvpM2e._GdHllKQLlXQN2FRsbnovwhoWBwD) && this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player._G6mmnFaa6rCvH24Jwj69ERi78ww.DistanceSquaredTo(dbvvb43n9c5uNQ7JklPD1fnCEnv2._G6mmnFaa6rCvH24Jwj69ERi78ww) <= 225.0)
			{
				int num3 = this._cXonWAgDq0OYBv9JHbiGXWgO6U2(dbvvb43n9c5uNQ7JklPD1fnCEnv2, ref hrW7TMzwtcS2gXEYo925wGvpM2e);
				if (num3 > num2 && num3 > num)
				{
					dbvvb43n9c5uNQ7JklPD1fnCEnv = dbvvb43n9c5uNQ7JklPD1fnCEnv2;
					num = num3;
				}
			}
		}
		if (dbvvb43n9c5uNQ7JklPD1fnCEnv != null)
		{
			this._dd2JXitGcIPo3jwTACw4TCiA36f(item, time, dbvvb43n9c5uNQ7JklPD1fnCEnv.ServerPosition, 1);
		}
	}

	// Token: 0x0600049E RID: 1182 RVA: 0x000195BC File Offset: 0x000177BC
	private void _rF1nnKUUvJ1P4nc3Z9WugOd9MkC(int Time)
	{
		if (this._2quYVWYoLc77QY6uJhajp7qBEFF)
		{
			return;
		}
		if (this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player == null)
		{
			return;
		}
		int num = this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player._myJxXFJcH1zIBkZMmXfDOvAh0vcA[1];
		if (num == -1)
		{
			return;
		}
		if (this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player._DCRDpJMAyMHNiobyZ7Hbma7BvCW())
		{
			return;
		}
		if (this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player._PWIIloW30Zn9FHns5mdVIWN4Gxh())
		{
			return;
		}
		_66CXgP76qcRM5NMLzlNSbhfhXbG 66CXgP76qcRM5NMLzlNSbhfhXbG = _JzyrOApzC09RC3fmb10FDURmyCl.Items.ByID((ushort)num);
		if (66CXgP76qcRM5NMLzlNSbhfhXbG == null)
		{
			return;
		}
		if (66CXgP76qcRM5NMLzlNSbhfhXbG._VpFa8CFamucJQ3qD0BQ0lIFhXke != 0)
		{
			return;
		}
		for (int i = 0; i < 66CXgP76qcRM5NMLzlNSbhfhXbG._VpFa8CFamucJQ3qD0BQ0lIFhXke; i++)
		{
			_FbqBESNaaIBpK5dNK9X5lWOOll5 fbqBESNaaIBpK5dNK9X5lWOOll = (_FbqBESNaaIBpK5dNK9X5lWOOll5)Packet.Create(PacketType.PLAYERSHOOT);
			fbqBESNaaIBpK5dNK9X5lWOOll._49dbaYgeVV0XCrIkHrqAGgDf2mFA = 0f;
			fbqBESNaaIBpK5dNK9X5lWOOll._MkT06oCYgDubgW2NbEOzvLh8RLe = new Location(this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player._G6mmnFaa6rCvH24Jwj69ERi78ww._MFEyfKFQqtcdaBxZbAOPzXMB8iP + Math.Cos((double)fbqBESNaaIBpK5dNK9X5lWOOll._49dbaYgeVV0XCrIkHrqAGgDf2mFA) * 0.3, this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player._G6mmnFaa6rCvH24Jwj69ERi78ww._vwAmCOilfBfnOBAh94J77UFd0FV + Math.Sin((double)fbqBESNaaIBpK5dNK9X5lWOOll._49dbaYgeVV0XCrIkHrqAGgDf2mFA) * 0.3);
			fbqBESNaaIBpK5dNK9X5lWOOll._Nx46RcGIU0H1BCGWaJXjN1ieopt = Time;
			fbqBESNaaIBpK5dNK9X5lWOOll._0v4mmgyFOmt9eSc23UclkqyBncC = this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.GetBulletId();
			fbqBESNaaIBpK5dNK9X5lWOOll._1hqbXYh2SXWKV5rkAtGwzNqFsAb = (short)66CXgP76qcRM5NMLzlNSbhfhXbG._X5iK7DxZXqEuFaG5vPlQc32oVuG;
			AllyShootPacket wiOD9tHX7kWPaVKFpug1rj7G3vk = (AllyShootPacket)Packet.Create(PacketType.ALLYSHOOT);
			wiOD9tHX7kWPaVKFpug1rj7G3vk.Angle = fbqBESNaaIBpK5dNK9X5lWOOll._49dbaYgeVV0XCrIkHrqAGgDf2mFA;
			wiOD9tHX7kWPaVKFpug1rj7G3vk.BulletId = fbqBESNaaIBpK5dNK9X5lWOOll._0v4mmgyFOmt9eSc23UclkqyBncC;
			wiOD9tHX7kWPaVKFpug1rj7G3vk.ContainerType = fbqBESNaaIBpK5dNK9X5lWOOll._1hqbXYh2SXWKV5rkAtGwzNqFsAb;
			wiOD9tHX7kWPaVKFpug1rj7G3vk.OwnerId = this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player.ObjectId;
			this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.SendToServer(fbqBESNaaIBpK5dNK9X5lWOOll);
			this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.SendToClient(wiOD9tHX7kWPaVKFpug1rj7G3vk);
		}
	}

	// Token: 0x0600049F RID: 1183 RVA: 0x00019764 File Offset: 0x00017964
	private void _XTBDQHoktC19mrPA2ZZFbUSRLV3(_66CXgP76qcRM5NMLzlNSbhfhXbG item, int time, double projSpeed, double maxDist, Location playerPos)
	{
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
	private Location _fvNQrZ2zgoRVudedFCBvA6D564g(Location playerCoords, Location targetCoords, Location targetVec, double projSpeed)
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

	// Token: 0x060004A1 RID: 1185 RVA: 0x00019D74 File Offset: 0x00017F74
	[CompilerGenerated]
	private int _cXonWAgDq0OYBv9JHbiGXWgO6U2(GameObject target, ref AutoNexus2._HrW7TMzwtcS2gXEYo925wGvpM2e _HrW7TMzwtcS2gXEYo925wGvpM2e_0)
	{
		int num = 0;
		foreach (GameObject dbvvb43n9c5uNQ7JklPD1fnCEnv in this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Enemies.Values)
		{
			if (!dbvvb43n9c5uNQ7JklPD1fnCEnv._V9sexWGjUomNGkbTZsOsc8ZyOSC() && !dbvvb43n9c5uNQ7JklPD1fnCEnv._NzxbS5UeEb1cgkXHHLCWeEWNe7o() && (!_HrW7TMzwtcS2gXEYo925wGvpM2e_0._cGHhVv5nIeTOAHMC7ayCjTSiu5x || dbvvb43n9c5uNQ7JklPD1fnCEnv._hI9BnQSXNqD191WGfzaqXuLrtAm <= _HrW7TMzwtcS2gXEYo925wGvpM2e_0._GdHllKQLlXQN2FRsbnovwhoWBwD) && target._G6mmnFaa6rCvH24Jwj69ERi78ww.DistanceSquaredTo(dbvvb43n9c5uNQ7JklPD1fnCEnv._G6mmnFaa6rCvH24Jwj69ERi78ww) <= (double)_HrW7TMzwtcS2gXEYo925wGvpM2e_0._9hUNiOkdmiWFq12cL6vWa0dYbgFA)
			{
				num++;
			}
		}
		return num;
	}

	// Token: 0x040005AA RID: 1450
	private Client _W6Ov6AArxzTTDnCyBtZPqkqNaKf;

	// Token: 0x040005AB RID: 1451
	private bool _2quYVWYoLc77QY6uJhajp7qBEFF;

	// Token: 0x040005AC RID: 1452
	private int _icFiCxIg3nuFxO6qEhyXAJ1fqVM;

	// Token: 0x040005AD RID: 1453
	private int _LcADAK1yIEbTQq1vfRipPNFwKLC;

	// Token: 0x040005AE RID: 1454
	private Location _IsYQ6CL3u3MPkFFNleTLf7tNE5A;

	// Token: 0x040005AF RID: 1455
	private Thread _KRrYunYpkRXhMLhAReiDT9amppr;

	// Token: 0x040005B0 RID: 1456
	private bool _4nYbaXoKnK4AO4BrJU0ZJDqW1Q6;

	// Token: 0x040005B1 RID: 1457
	private bool _WYanjAEAeovcd96Ghpur7VAJRUlA;

	// Token: 0x040005B2 RID: 1458
	private readonly List<string> _D0ydY92aMnivKXLmhWYnzjIuo7b;

	// Token: 0x020000AC RID: 172
	[CompilerGenerated]
	[StructLayout(LayoutKind.Auto)]
	private struct _HrW7TMzwtcS2gXEYo925wGvpM2e
	{
		// Token: 0x040005B3 RID: 1459
		public AutoNexus2 _EfubdzaIe4z6qxSHa3TuY5MkdaZ;

		// Token: 0x040005B4 RID: 1460
		public bool _cGHhVv5nIeTOAHMC7ayCjTSiu5x;

		// Token: 0x040005B5 RID: 1461
		public int _GdHllKQLlXQN2FRsbnovwhoWBwD;

		// Token: 0x040005B6 RID: 1462
		public float _9hUNiOkdmiWFq12cL6vWa0dYbgFA;
	}
}
