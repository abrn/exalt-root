using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ExaltMultiTool.Proxy.DataStructures;

// Token: 0x0200001D RID: 29
internal class GameObject
{
	// Token: 0x17000092 RID: 146
	// (get) Token: 0x06000151 RID: 337 RVA: 0x0000CF28 File Offset: 0x0000B128
	// (set) Token: 0x06000152 RID: 338 RVA: 0x0000CF3C File Offset: 0x0000B13C
	public int MaxHealth { get; set; }

	// Token: 0x17000093 RID: 147
	// (get) Token: 0x06000153 RID: 339 RVA: 0x0000CF50 File Offset: 0x0000B150
	// (set) Token: 0x06000154 RID: 340 RVA: 0x0000CF64 File Offset: 0x0000B164
	public int Health { get; set; }

	// Token: 0x17000094 RID: 148
	// (get) Token: 0x06000155 RID: 341 RVA: 0x0000CF78 File Offset: 0x0000B178
	// (set) Token: 0x06000156 RID: 342 RVA: 0x0000CF8C File Offset: 0x0000B18C
	public int Size { get; set; }

	// Token: 0x17000095 RID: 149
	// (get) Token: 0x06000157 RID: 343 RVA: 0x0000CFA0 File Offset: 0x0000B1A0
	// (set) Token: 0x06000158 RID: 344 RVA: 0x0000CFB4 File Offset: 0x0000B1B4
	public int MaxMana { get; set; }

	// Token: 0x17000096 RID: 150
	// (get) Token: 0x06000159 RID: 345 RVA: 0x0000CFC8 File Offset: 0x0000B1C8
	// (set) Token: 0x0600015A RID: 346 RVA: 0x0000CFDC File Offset: 0x0000B1DC
	public int Mana { get; set; }

	// Token: 0x17000097 RID: 151
	// (get) Token: 0x0600015B RID: 347 RVA: 0x0000CFF0 File Offset: 0x0000B1F0
	// (set) Token: 0x0600015C RID: 348 RVA: 0x0000D004 File Offset: 0x0000B204
	public int Attack { get; set; }

	// Token: 0x17000098 RID: 152
	// (get) Token: 0x0600015D RID: 349 RVA: 0x0000D018 File Offset: 0x0000B218
	// (set) Token: 0x0600015E RID: 350 RVA: 0x0000D02C File Offset: 0x0000B22C
	public int Defense { get; set; }

	// Token: 0x17000099 RID: 153
	// (get) Token: 0x0600015F RID: 351 RVA: 0x0000D040 File Offset: 0x0000B240
	// (set) Token: 0x06000160 RID: 352 RVA: 0x0000D054 File Offset: 0x0000B254
	public int Speed { get; set; }

	// Token: 0x1700009A RID: 154
	// (get) Token: 0x06000161 RID: 353 RVA: 0x0000D068 File Offset: 0x0000B268
	// (set) Token: 0x06000162 RID: 354 RVA: 0x0000D07C File Offset: 0x0000B27C
	public int Vitality { get; set; }

	// Token: 0x1700009B RID: 155
	// (get) Token: 0x06000163 RID: 355 RVA: 0x0000D090 File Offset: 0x0000B290
	// (set) Token: 0x06000164 RID: 356 RVA: 0x0000D0A4 File Offset: 0x0000B2A4
	public int Wisdom { get; set; }

	// Token: 0x1700009C RID: 156
	// (get) Token: 0x06000165 RID: 357 RVA: 0x0000D0B8 File Offset: 0x0000B2B8
	// (set) Token: 0x06000166 RID: 358 RVA: 0x0000D0CC File Offset: 0x0000B2CC
	public int Dexterity { get; set; }

	// Token: 0x1700009D RID: 157
	// (get) Token: 0x06000167 RID: 359 RVA: 0x0000D0E0 File Offset: 0x0000B2E0
	// (set) Token: 0x06000168 RID: 360 RVA: 0x0000D0F4 File Offset: 0x0000B2F4
	public int HealthBoost { get; set; }

	// Token: 0x1700009E RID: 158
	// (get) Token: 0x06000169 RID: 361 RVA: 0x0000D108 File Offset: 0x0000B308
	// (set) Token: 0x0600016A RID: 362 RVA: 0x0000D11C File Offset: 0x0000B31C
	public int ManaBoost { get; set; }

	// Token: 0x1700009F RID: 159
	// (get) Token: 0x0600016B RID: 363 RVA: 0x0000D130 File Offset: 0x0000B330
	// (set) Token: 0x0600016C RID: 364 RVA: 0x0000D144 File Offset: 0x0000B344
	public int AttackBoost { get; set; }

	// Token: 0x170000A0 RID: 160
	// (get) Token: 0x0600016D RID: 365 RVA: 0x0000D158 File Offset: 0x0000B358
	// (set) Token: 0x0600016E RID: 366 RVA: 0x0000D16C File Offset: 0x0000B36C
	public int DefenseBoost { get; set; }

	// Token: 0x170000A1 RID: 161
	// (get) Token: 0x0600016F RID: 367 RVA: 0x0000D180 File Offset: 0x0000B380
	// (set) Token: 0x06000170 RID: 368 RVA: 0x0000D194 File Offset: 0x0000B394
	public int SpeedBoost { get; set; }

	// Token: 0x170000A2 RID: 162
	// (get) Token: 0x06000171 RID: 369 RVA: 0x0000D1A8 File Offset: 0x0000B3A8
	// (set) Token: 0x06000172 RID: 370 RVA: 0x0000D1BC File Offset: 0x0000B3BC
	public int VitalityBoost { get; set; }

	// Token: 0x170000A3 RID: 163
	// (get) Token: 0x06000173 RID: 371 RVA: 0x0000D1D0 File Offset: 0x0000B3D0
	// (set) Token: 0x06000174 RID: 372 RVA: 0x0000D1E4 File Offset: 0x0000B3E4
	public int WisdomBoost { get; set; }

	// Token: 0x170000A4 RID: 164
	// (get) Token: 0x06000175 RID: 373 RVA: 0x0000D1F8 File Offset: 0x0000B3F8
	// (set) Token: 0x06000176 RID: 374 RVA: 0x0000D20C File Offset: 0x0000B40C
	public int DexterityBoost { get; set; }

	// Token: 0x170000A5 RID: 165
	// (get) Token: 0x06000177 RID: 375 RVA: 0x0000D220 File Offset: 0x0000B420
	// (set) Token: 0x06000178 RID: 376 RVA: 0x0000D234 File Offset: 0x0000B434
	public int XpGoal { get; set; }

	// Token: 0x170000A6 RID: 166
	// (get) Token: 0x06000179 RID: 377 RVA: 0x0000D248 File Offset: 0x0000B448
	// (set) Token: 0x0600017A RID: 378 RVA: 0x0000D25C File Offset: 0x0000B45C
	public int Xp { get; set; }

	// Token: 0x170000A7 RID: 167
	// (get) Token: 0x0600017B RID: 379 RVA: 0x0000D270 File Offset: 0x0000B470
	// (set) Token: 0x0600017C RID: 380 RVA: 0x0000D284 File Offset: 0x0000B484
	public int Level { get; set; }

	// Token: 0x170000A8 RID: 168
	// (get) Token: 0x0600017D RID: 381 RVA: 0x0000D298 File Offset: 0x0000B498
	// (set) Token: 0x0600017E RID: 382 RVA: 0x0000D2AC File Offset: 0x0000B4AC
	public int RealmGold { get; set; }

	// Token: 0x170000A9 RID: 169
	// (get) Token: 0x0600017F RID: 383 RVA: 0x0000D2C0 File Offset: 0x0000B4C0
	// (set) Token: 0x06000180 RID: 384 RVA: 0x0000D2D4 File Offset: 0x0000B4D4
	public string Name { get; set; }

	// Token: 0x170000AA RID: 170
	// (get) Token: 0x06000181 RID: 385 RVA: 0x0000D2E8 File Offset: 0x0000B4E8
	// (set) Token: 0x06000182 RID: 386 RVA: 0x0000D2FC File Offset: 0x0000B4FC
	public int Effects1 { get; set; }

	// Token: 0x170000AB RID: 171
	// (get) Token: 0x06000183 RID: 387 RVA: 0x0000D310 File Offset: 0x0000B510
	// (set) Token: 0x06000184 RID: 388 RVA: 0x0000D324 File Offset: 0x0000B524
	public int Effects2 { get; set; }

	// Token: 0x170000AC RID: 172
	// (get) Token: 0x06000185 RID: 389 RVA: 0x0000D338 File Offset: 0x0000B538
	// (set) Token: 0x06000186 RID: 390 RVA: 0x0000D34C File Offset: 0x0000B54C
	public int Stars { get; set; }

	// Token: 0x170000AD RID: 173
	// (get) Token: 0x06000187 RID: 391 RVA: 0x0000D360 File Offset: 0x0000B560
	// (set) Token: 0x06000188 RID: 392 RVA: 0x0000D374 File Offset: 0x0000B574
	public int CharacterFame { get; set; }

	// Token: 0x170000AE RID: 174
	// (get) Token: 0x06000189 RID: 393 RVA: 0x0000D388 File Offset: 0x0000B588
	// (set) Token: 0x0600018A RID: 394 RVA: 0x0000D39C File Offset: 0x0000B59C
	public int CharacterFameGoal { get; set; }

	// Token: 0x170000AF RID: 175
	// (get) Token: 0x0600018B RID: 395 RVA: 0x0000D3B0 File Offset: 0x0000B5B0
	// (set) Token: 0x0600018C RID: 396 RVA: 0x0000D3C4 File Offset: 0x0000B5C4
	public string Guild { get; set; }

	// Token: 0x170000B0 RID: 176
	// (get) Token: 0x0600018D RID: 397 RVA: 0x0000D3D8 File Offset: 0x0000B5D8
	// (set) Token: 0x0600018E RID: 398 RVA: 0x0000D3EC File Offset: 0x0000B5EC
	public int HealthpotCount { get; set; }

	// Token: 0x170000B1 RID: 177
	// (get) Token: 0x0600018F RID: 399 RVA: 0x0000D400 File Offset: 0x0000B600
	// (set) Token: 0x06000190 RID: 400 RVA: 0x0000D414 File Offset: 0x0000B614
	public int MagicpotCount { get; set; }

	// Token: 0x170000B2 RID: 178
	// (get) Token: 0x06000191 RID: 401 RVA: 0x0000D428 File Offset: 0x0000B628
	// (set) Token: 0x06000192 RID: 402 RVA: 0x0000D43C File Offset: 0x0000B63C
	public bool HasBackpack { get; set; }

	// Token: 0x170000B3 RID: 179
	// (get) Token: 0x06000193 RID: 403 RVA: 0x0000D450 File Offset: 0x0000B650
	// (set) Token: 0x06000194 RID: 404 RVA: 0x0000D464 File Offset: 0x0000B664
	public string OwnerAccountId { get; set; }

	// Token: 0x170000B4 RID: 180
	// (get) Token: 0x06000195 RID: 405 RVA: 0x0000D478 File Offset: 0x0000B678
	// (set) Token: 0x06000196 RID: 406 RVA: 0x0000D48C File Offset: 0x0000B68C
	public bool NameChosen { get; set; }

	// Token: 0x170000B5 RID: 181
	// (get) Token: 0x06000197 RID: 407 RVA: 0x0000D4A0 File Offset: 0x0000B6A0
	// (set) Token: 0x06000198 RID: 408 RVA: 0x0000D4B4 File Offset: 0x0000B6B4
	public string TypeName { get; set; }

	// Token: 0x170000B6 RID: 182
	// (get) Token: 0x06000199 RID: 409 RVA: 0x0000D4C8 File Offset: 0x0000B6C8
	// (set) Token: 0x0600019A RID: 410 RVA: 0x0000D4DC File Offset: 0x0000B6DC
	public int MerchandiseType { get; set; }

	// Token: 0x170000B7 RID: 183
	// (get) Token: 0x0600019B RID: 411 RVA: 0x0000D4F0 File Offset: 0x0000B6F0
	// (set) Token: 0x0600019C RID: 412 RVA: 0x0000D504 File Offset: 0x0000B704
	public int PetInstanceId { get; set; }

	// Token: 0x170000B8 RID: 184
	// (get) Token: 0x0600019D RID: 413 RVA: 0x0000D518 File Offset: 0x0000B718
	// (set) Token: 0x0600019E RID: 414 RVA: 0x0000D52C File Offset: 0x0000B72C
	public string PetName { get; set; }

	// Token: 0x170000B9 RID: 185
	// (get) Token: 0x0600019F RID: 415 RVA: 0x0000D540 File Offset: 0x0000B740
	// (set) Token: 0x060001A0 RID: 416 RVA: 0x0000D554 File Offset: 0x0000B754
	public int Skin { get; set; }

	// Token: 0x170000BA RID: 186
	// (get) Token: 0x060001A1 RID: 417 RVA: 0x0000D568 File Offset: 0x0000B768
	// (set) Token: 0x060001A2 RID: 418 RVA: 0x0000D57C File Offset: 0x0000B77C
	public int PetType { get; set; }

	// Token: 0x170000BB RID: 187
	// (get) Token: 0x060001A3 RID: 419 RVA: 0x0000D590 File Offset: 0x0000B790
	// (set) Token: 0x060001A4 RID: 420 RVA: 0x0000D5A4 File Offset: 0x0000B7A4
	public int PetRarity { get; set; }

	// Token: 0x170000BC RID: 188
	// (get) Token: 0x060001A5 RID: 421 RVA: 0x0000D5B8 File Offset: 0x0000B7B8
	// (set) Token: 0x060001A6 RID: 422 RVA: 0x0000D5CC File Offset: 0x0000B7CC
	public int PetMaxAbilityPower { get; set; }

	// Token: 0x170000BD RID: 189
	// (get) Token: 0x060001A7 RID: 423 RVA: 0x0000D5E0 File Offset: 0x0000B7E0
	// (set) Token: 0x060001A8 RID: 424 RVA: 0x0000D5F4 File Offset: 0x0000B7F4
	public int PetFamily { get; set; }

	// Token: 0x170000BE RID: 190
	// (get) Token: 0x060001A9 RID: 425 RVA: 0x0000D608 File Offset: 0x0000B808
	// (set) Token: 0x060001AA RID: 426 RVA: 0x0000D61C File Offset: 0x0000B81C
	public int PetFirstAbilityPoint { get; set; }

	// Token: 0x170000BF RID: 191
	// (get) Token: 0x060001AB RID: 427 RVA: 0x0000D630 File Offset: 0x0000B830
	// (set) Token: 0x060001AC RID: 428 RVA: 0x0000D644 File Offset: 0x0000B844
	public int PetSecondAbilityPoint { get; set; }

	// Token: 0x170000C0 RID: 192
	// (get) Token: 0x060001AD RID: 429 RVA: 0x0000D658 File Offset: 0x0000B858
	// (set) Token: 0x060001AE RID: 430 RVA: 0x0000D66C File Offset: 0x0000B86C
	public int PetThirdAbilityPoint { get; set; }

	// Token: 0x170000C1 RID: 193
	// (get) Token: 0x060001AF RID: 431 RVA: 0x0000D680 File Offset: 0x0000B880
	// (set) Token: 0x060001B0 RID: 432 RVA: 0x0000D694 File Offset: 0x0000B894
	public int PetFirstAbilityPower { get; set; }

	// Token: 0x170000C2 RID: 194
	// (get) Token: 0x060001B1 RID: 433 RVA: 0x0000D6A8 File Offset: 0x0000B8A8
	// (set) Token: 0x060001B2 RID: 434 RVA: 0x0000D6BC File Offset: 0x0000B8BC
	public int PetSecondAbilityPower { get; set; }

	// Token: 0x170000C3 RID: 195
	// (get) Token: 0x060001B3 RID: 435 RVA: 0x0000D6D0 File Offset: 0x0000B8D0
	// (set) Token: 0x060001B4 RID: 436 RVA: 0x0000D6E4 File Offset: 0x0000B8E4
	public int PetThirdAbilityPower { get; set; }

	// Token: 0x170000C4 RID: 196
	// (get) Token: 0x060001B5 RID: 437 RVA: 0x0000D6F8 File Offset: 0x0000B8F8
	// (set) Token: 0x060001B6 RID: 438 RVA: 0x0000D70C File Offset: 0x0000B90C
	public int PetFirstAbilityType { get; set; }

	// Token: 0x170000C5 RID: 197
	// (get) Token: 0x060001B7 RID: 439 RVA: 0x0000D720 File Offset: 0x0000B920
	// (set) Token: 0x060001B8 RID: 440 RVA: 0x0000D734 File Offset: 0x0000B934
	public int PetSecondAbilityType { get; set; }

	// Token: 0x170000C6 RID: 198
	// (get) Token: 0x060001B9 RID: 441 RVA: 0x0000D748 File Offset: 0x0000B948
	// (set) Token: 0x060001BA RID: 442 RVA: 0x0000D75C File Offset: 0x0000B95C
	public int PetThirdAbilityType { get; set; }

	// Token: 0x170000C7 RID: 199
	// (get) Token: 0x060001BB RID: 443 RVA: 0x0000D770 File Offset: 0x0000B970
	// (set) Token: 0x060001BC RID: 444 RVA: 0x0000D784 File Offset: 0x0000B984
	public int Breath { get; private set; }

	// Token: 0x170000C8 RID: 200
	// (get) Token: 0x060001BD RID: 445 RVA: 0x0000D798 File Offset: 0x0000B998
	// (set) Token: 0x060001BE RID: 446 RVA: 0x0000D7AC File Offset: 0x0000B9AC
	public bool Boss { get; private set; }

	// Token: 0x170000C9 RID: 201
	// (get) Token: 0x060001BF RID: 447 RVA: 0x0000D7C0 File Offset: 0x0000B9C0
	// (set) Token: 0x060001C0 RID: 448 RVA: 0x0000D7D4 File Offset: 0x0000B9D4
	public bool God { get; private set; }

	// Token: 0x170000CA RID: 202
	// (get) Token: 0x060001C1 RID: 449 RVA: 0x0000D7E8 File Offset: 0x0000B9E8
	// (set) Token: 0x060001C2 RID: 450 RVA: 0x0000D7FC File Offset: 0x0000B9FC
	public bool Cube { get; private set; }

	// Token: 0x170000CB RID: 203
	// (get) Token: 0x060001C3 RID: 451 RVA: 0x0000D810 File Offset: 0x0000BA10
	public double TilesPerSecond
	{
		get
		{
			return 4.0 + 5.6 * ((double)this.Speed / 75.0);
		}
	}

	// Token: 0x060001C4 RID: 452 RVA: 0x0000D844 File Offset: 0x0000BA44
	public GameObject(int objectId)
	{
		this.ObjectId = objectId;
		/*
An exception occurred when decompiling this method (060001C4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void _DBVVB43n9c5uNQ7JklPD1fnCEnv::.ctor(System.Int32)
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

	// Token: 0x060001C5 RID: 453 RVA: 0x0000D8A4 File Offset: 0x0000BAA4
	public GameObject(Entity source)
	{
		this.ObjectType = source.ObjectType;
		this.ObjectId = source.Status.ObjectId;
		this.ParseEntity(source);
		/*
An exception occurred when decompiling this method (060001C5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void _DBVVB43n9c5uNQ7JklPD1fnCEnv::.ctor(_eTOyUHUGABMgTlUf3FUyHRn1uVv)
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

	// Token: 0x060001C6 RID: 454 RVA: 0x0000D920 File Offset: 0x0000BB20
	public void ParseEntity(Entity entity)
	{
		this.ObjectType = entity.ObjectType;
		this.ObjectId = entity.Status.ObjectId;
		ObjectStructure objectStructure = GameData.Objects.ByID(this.ObjectType);
		if (objectStructure != null)
		{
			this.MaxHealth = 100;
			this.Health = 100;
			this.Player = objectStructure.Player;
			this.Enemy = objectStructure.Enemy;
			this.Character = (objectStructure.ObjectClass == "Character");
			this.OccupySquare = objectStructure.OccupySquare;
			this.FullOccupy = objectStructure.FullOccupy;
			this.EnemyOccupySquare = objectStructure.EnemyOccupySquare;
			this.Static = objectStructure.Static;
			this.Defense = (int)objectStructure.Defense;
			this.MaxHealth = (int)objectStructure.MaxHP;
			this.Size = (int)objectStructure.Size;
			this.TypeName = objectStructure.Name;
			this.Boss = (objectStructure.Quest || GameObject._d3bQGhO5AtJlVgiWWm5etPWFoQA.Contains((int)this.ObjectType));
			this.God = objectStructure.God;
			this.Cube = objectStructure.Cube;
		}
		this.ParseStatus(entity.Status, 0, -1, -1, -1L, false);
	}

	// Token: 0x060001C7 RID: 455 RVA: 0x0000DA54 File Offset: 0x0000BC54
	public void ParseStatus(Status status, int tickTime, int tickId, int lastTickId, long lastUpdate, bool selfAndNewTick = false)
	{
		this.ServerPosition = (Location)status.Position.Clone();
		if (tickTime != 0)
		{
			this.OnTickPos(status.Position.x, status.Position.y, tickTime, tickId, lastTickId, lastUpdate);
		}
		else if (this.ClientPosition == null || this.ClientPosition.x == 0.0)
		{
			this.ClientPosition = (Location)status.Position.Clone();
		}
		foreach (StatData statData in status.Data)
		{
			switch (statData.Id)
			{
			case 0:
				this.MaxHealth = statData.IntValue;
				break;
			case 1:
				this.Health = statData.IntValue;
				break;
			case 2:
				this.Size = statData.IntValue;
				break;
			case 3:
				this.MaxMana = statData.IntValue;
				break;
			case 4:
				this.Mana = statData.IntValue;
				break;
			case 5:
				this.XpGoal = statData.IntValue;
				break;
			case 6:
				this.Xp = statData.IntValue;
				break;
			case 7:
				this.Level = statData.IntValue;
				break;
			case 8:
				this.Inventory[0] = statData.IntValue;
				break;
			case 9:
				this.Inventory[1] = statData.IntValue;
				break;
			case 10:
				this.Inventory[2] = statData.IntValue;
				break;
			case 11:
				this.Inventory[3] = statData.IntValue;
				break;
			case 12:
				this.Inventory[4] = statData.IntValue;
				break;
			case 13:
				this.Inventory[5] = statData.IntValue;
				break;
			case 14:
				this.Inventory[6] = statData.IntValue;
				break;
			case 15:
				this.Inventory[7] = statData.IntValue;
				break;
			case 16:
				this.Inventory[8] = statData.IntValue;
				break;
			case 17:
				this.Inventory[9] = statData.IntValue;
				break;
			case 18:
				this.Inventory[10] = statData.IntValue;
				break;
			case 19:
				this.Inventory[11] = statData.IntValue;
				break;
			case 20:
				this.Attack = statData.IntValue;
				break;
			case 21:
				this.Defense = statData.IntValue;
				break;
			case 22:
				this.Speed = statData.IntValue;
				break;
			case 26:
				this.Vitality = statData.IntValue;
				break;
			case 27:
				this.Wisdom = statData.IntValue;
				break;
			case 28:
				this.Dexterity = statData.IntValue;
				break;
			case 29:
				this.Effects1 = statData.IntValue;
				break;
			case 30:
				this.Stars = statData.IntValue;
				break;
			case 31:
				this.Name = statData.StringValue;
				break;
			case 34:
				this.MerchandiseType = statData.IntValue;
				break;
			case 35:
				this.RealmGold = statData.IntValue;
				break;
			case 37:
				this._YqxSFlGcVQn30hPhozXRrYQ6QU = (statData.IntValue == 1);
				break;
			case 38:
				this.AccountId = statData.StringValue;
				break;
			case 39:
				this._56pdYv1LPTIA6NGeLxVI6h8jOT8 = statData.IntValue;
				break;
			case 46:
				this.HealthBoost = statData.IntValue;
				break;
			case 47:
				this.ManaBoost = statData.IntValue;
				break;
			case 48:
				this.AttackBoost = statData.IntValue;
				break;
			case 49:
				this.DefenseBoost = statData.IntValue;
				break;
			case 50:
				this.SpeedBoost = statData.IntValue;
				break;
			case 51:
				this.VitalityBoost = statData.IntValue;
				break;
			case 52:
				this.WisdomBoost = statData.IntValue;
				break;
			case 53:
				this.DexterityBoost = statData.IntValue;
				break;
			case 54:
				this.OwnerAccountId = statData.StringValue;
				break;
			case 56:
				this.NameChosen = (statData.IntValue == 1);
				break;
			case 57:
				this.CharacterFame = statData.IntValue;
				break;
			case 58:
				this.CharacterFameGoal = statData.IntValue;
				break;
			case 62:
				this.Guild = statData.StringValue;
				break;
			case 63:
				this._LgHauWr40j3A6clN8gZvftMEHKs = statData.IntValue;
				break;
			case 64:
				this.Breath = statData.IntValue;
				break;
			case 69:
				this.HealthpotCount = statData.IntValue;
				break;
			case 70:
				this.MagicpotCount = statData.IntValue;
				break;
			case 71:
				this.Inventory[12] = statData.IntValue;
				break;
			case 72:
				this.Inventory[13] = statData.IntValue;
				break;
			case 73:
				this.Inventory[14] = statData.IntValue;
				break;
			case 74:
				this.Inventory[15] = statData.IntValue;
				break;
			case 75:
				this.Inventory[16] = statData.IntValue;
				break;
			case 76:
				this.Inventory[17] = statData.IntValue;
				break;
			case 77:
				this.Inventory[18] = statData.IntValue;
				break;
			case 78:
				this.Inventory[19] = statData.IntValue;
				break;
			case 79:
				this.HasBackpack = (statData.IntValue == 1);
				break;
			case 80:
				this.Skin = statData.IntValue;
				break;
			case 81:
				this.PetInstanceId = statData.IntValue;
				break;
			case 82:
				this.PetName = statData.StringValue;
				break;
			case 83:
				this.PetType = statData.IntValue;
				break;
			case 84:
				this.PetRarity = statData.IntValue;
				break;
			case 85:
				this.PetMaxAbilityPower = statData.IntValue;
				break;
			case 86:
				this.PetFamily = statData.IntValue;
				break;
			case 87:
				this.PetFirstAbilityPoint = statData.IntValue;
				break;
			case 88:
				this.PetSecondAbilityPoint = statData.IntValue;
				break;
			case 89:
				this.PetThirdAbilityPoint = statData.IntValue;
				break;
			case 90:
				this.PetFirstAbilityPower = statData.IntValue;
				break;
			case 91:
				this.PetSecondAbilityPower = statData.IntValue;
				break;
			case 92:
				this.PetThirdAbilityPower = statData.IntValue;
				break;
			case 93:
				this.PetFirstAbilityType = statData.IntValue;
				break;
			case 94:
				this.PetSecondAbilityType = statData.IntValue;
				break;
			case 95:
				this.PetThirdAbilityType = statData.IntValue;
				break;
			case 96:
				this.Effects2 = statData.IntValue;
				break;
			}
		}
	}


    // Token: 0x060001C8 RID: 456 RVA: 0x0000E1F8 File Offset: 0x0000C3F8
    public void MoveTo(float x, float y)
	{
		this.ClientPosition.x = (double)x;
		this.ClientPosition.y = (double)y;
	}

	// Token: 0x060001C9 RID: 457 RVA: 0x0000E220 File Offset: 0x0000C420
	public void MoveTo(double x, double y)
	{
		this.ClientPosition.x = (double)((float)x);
		this.ClientPosition.y = (double)((float)y);
	}

	// Token: 0x060001CA RID: 458 RVA: 0x0000E24C File Offset: 0x0000C44C
	public void MoveTo(Location loc)
	{
		this.ClientPosition = loc;
	}

	// Token: 0x060001CB RID: 459 RVA: 0x0000E260 File Offset: 0x0000C460
	public void OnTickPos(double x, double y, int tickTime, int tickId, int lastTickId, long lastUpdate)
	{
		if (this.MyLastTickId < lastTickId)
		{
			this.MoveTo(this.ServerPosition.x, this.ServerPosition.y);
		}
		this.LastTickUpdateTime = lastUpdate;
		this.ServerPosition.x = (double)((float)x);
		this.ServerPosition.y = (double)((float)y);
		this.MoveVec.x = (this.ServerPosition.x - this.ClientPosition.x) / (double)tickTime;
		this.MoveVec.y = (this.ServerPosition.y - this.ClientPosition.y) / (double)tickTime;
		this.MyLastTickId = tickId;
	}

	// Token: 0x060001CC RID: 460 RVA: 0x0000E30C File Offset: 0x0000C50C
	public void Goto(Location loc)
	{
		this.ServerPosition = loc;
	}

	// Token: 0x060001CD RID: 461 RVA: 0x0000E320 File Offset: 0x0000C520
	public bool ValidTarget()
	{
		return this.Enemy && this.Character && this.Vulnerable();
	}

	// Token: 0x060001CE RID: 462 RVA: 0x0000E348 File Offset: 0x0000C548
	public bool Vulnerable()
	{
		return !this.isStasis() && !this.isInvincible() && !this.isInvulnerable();
	}

	// Token: 0x060001CF RID: 463 RVA: 0x0000E370 File Offset: 0x0000C570
	public bool isQuiet()
	{
		return (this.Effects1 & 2) != 0;
	}

	// Token: 0x060001D0 RID: 464 RVA: 0x0000E388 File Offset: 0x0000C588
	public bool isWeak()
	{
		return (this.Effects1 & 4) != 0;
	}

	// Token: 0x060001D1 RID: 465 RVA: 0x0000E3A0 File Offset: 0x0000C5A0
	public bool isSlowed()
	{
		return (this.Effects1 & 8) != 0;
	}

	// Token: 0x060001D2 RID: 466 RVA: 0x0000E3B8 File Offset: 0x0000C5B8
	public bool isSick()
	{
		return (this.Effects1 & 16) != 0;
	}

	// Token: 0x060001D3 RID: 467 RVA: 0x0000E3D4 File Offset: 0x0000C5D4
	public bool _VYY292R0wjHJDKGbid8DHBw6uWU()
	{
		return (this.Effects1 & 32) != 0;
	}

	// Token: 0x060001D4 RID: 468 RVA: 0x0000E3F0 File Offset: 0x0000C5F0
	public bool isStunned()
	{
		return (this.Effects1 & 64) != 0;
	}

	// Token: 0x060001D5 RID: 469 RVA: 0x0000E40C File Offset: 0x0000C60C
	public bool _mmzbylldFLOLW76nYjYuCJLMg9CA()
	{
		return (this.Effects1 & 128) != 0;
	}

	// Token: 0x060001D6 RID: 470 RVA: 0x0000E428 File Offset: 0x0000C628
	public bool _7oD5SyK9C0vDGBfxFCsaWb8CDXr()
	{
		return (this.Effects1 & 512) != 0;
	}

	// Token: 0x060001D7 RID: 471 RVA: 0x0000E444 File Offset: 0x0000C644
	public bool _WJxV24iCcufp3XHJCHeDoUJ9r7o()
	{
		return (this.Effects1 & 1024) != 0;
	}

	// Token: 0x060001D8 RID: 472 RVA: 0x0000E460 File Offset: 0x0000C660
	public bool _NLH3KJ5cY1pLQ2EBfjvbAqhbGhq()
	{
		return (this.Effects1 & 32768) != 0;
	}

	// Token: 0x060001D9 RID: 473 RVA: 0x0000E47C File Offset: 0x0000C67C
	public bool _QrQq907a11ErRdJm6BkF2zQtiBB()
	{
		return (this.Effects1 & 2048) != 0;
	}

	// Token: 0x060001DA RID: 474 RVA: 0x0000E498 File Offset: 0x0000C698
	public bool isInvisible()
	{
		return (this.Effects1 & 4096) != 0;
	}

	// Token: 0x060001DB RID: 475 RVA: 0x0000E4B4 File Offset: 0x0000C6B4
	public bool _4umwJVUjDISqEuPZf48aehDFcvm()
	{
		return (this.Effects1 & 8192) != 0;
	}

	// Token: 0x060001DC RID: 476 RVA: 0x0000E4D0 File Offset: 0x0000C6D0
	public bool _JqJhAeEWwY5WcJ0GNAsQaGdn7vC()
	{
		return (this.Effects1 & 16384) != 0;
	}

	// Token: 0x060001DD RID: 477 RVA: 0x0000E4EC File Offset: 0x0000C6EC
	public bool isNinjaSpeedy()
	{
		return (this.Effects1 & 268435456) != 0;
	}

	// Token: 0x060001DE RID: 478 RVA: 0x0000E508 File Offset: 0x0000C708
	public bool _zYbhDLqAS3OKAU5Gzce11AVNomi()
	{
		return (this.Effects1 & 256) != 0;
	}

	// Token: 0x060001DF RID: 479 RVA: 0x0000E524 File Offset: 0x0000C724
	public bool _QjCbV9Fd4t6nKLKemADmO4bM4hBA()
	{
		return (this.Effects1 & 131072) != 0;
	}

	// Token: 0x060001E0 RID: 480 RVA: 0x0000E540 File Offset: 0x0000C740
	public bool _kA7EpbLbFY8401niZOTcaddulEcb()
	{
		return (this.Effects1 & 262144) != 0;
	}

	// Token: 0x060001E1 RID: 481 RVA: 0x0000E55C File Offset: 0x0000C75C
	public bool _Jif7LLeDiipmHEpATbMgegRDNZx()
	{
		return (this.Effects1 & 524288) != 0;
	}

	// Token: 0x060001E2 RID: 482 RVA: 0x0000E578 File Offset: 0x0000C778
	public bool isPaused()
	{
		return (this.Effects1 & 1048576) != 0;
	}

	// Token: 0x060001E3 RID: 483 RVA: 0x0000E594 File Offset: 0x0000C794
	public bool isStasis()
	{
		return (this.Effects1 & 2097152) != 0;
	}

	// Token: 0x060001E4 RID: 484 RVA: 0x0000E5B0 File Offset: 0x0000C7B0
	public bool isInvincible()
	{
		return (this.Effects1 & 8388608) != 0;
	}

	// Token: 0x060001E5 RID: 485 RVA: 0x0000E5CC File Offset: 0x0000C7CC
	public bool isInvulnerable()
	{
		return (this.Effects1 & 16777216) != 0;
	}

	// Token: 0x060001E6 RID: 486 RVA: 0x0000E5E8 File Offset: 0x0000C7E8
	public bool _cPWvaf8DndobPySrTOml9uL6DAY()
	{
		return (this.Effects1 & 33554432) != 0;
	}

	// Token: 0x060001E7 RID: 487 RVA: 0x0000E604 File Offset: 0x0000C804
	public bool _oXsCK7yO7qJB1FLXQSIQngK4drY()
	{
		return (this.Effects1 & 67108864) != 0;
	}

	// Token: 0x060001E8 RID: 488 RVA: 0x0000E620 File Offset: 0x0000C820
	public bool _Mn7u212iJGR2MPhwrp35S0C0CRI()
	{
		return (this.Effects2 & 65536) != 0;
	}

	// Token: 0x060001E9 RID: 489 RVA: 0x0000E63C File Offset: 0x0000C83C
	public bool isUnstable()
	{
		return (this.Effects1 & 536870912) != 0;
	}

	// Token: 0x060001EA RID: 490 RVA: 0x0000E658 File Offset: 0x0000C858
	public bool _cINym90PMnmRaoXIKD1nK8pqHYR()
	{
		return (this.Effects2 & 131072) != 0;
	}

	// Token: 0x060001EB RID: 491 RVA: 0x0000E674 File Offset: 0x0000C874
	public bool _dEiUEywXA9bOApweAxlbLqIezsn()
	{
		return (this.Effects2 & 8) != 0;
	}

	// Token: 0x060001EC RID: 492 RVA: 0x0000E68C File Offset: 0x0000C88C
	public bool _P9AZZcEdIaX8LaN2BI9jH6JT5Uh()
	{
		return (this.Effects2 & 64) != 0;
	}

	public ushort ObjectType;

	// Token: 0x040001C5 RID: 453
	public int ObjectId;

	// Token: 0x040001C6 RID: 454
	public Location ClientPosition = Location.Empty;

	// Token: 0x040001C7 RID: 455
	public Location ServerPosition = Location.Empty;

	// Token: 0x040001C8 RID: 456
	public int MyLastTickId;

	// Token: 0x040001C9 RID: 457
	public long LastTickUpdateTime;

	// Token: 0x040001CA RID: 458
	public Location MoveVec = new Location(0f, 0f);

	// Token: 0x040001CB RID: 459
	public bool Player;

	// Token: 0x040001CC RID: 460
	public bool Enemy;

	// Token: 0x040001CD RID: 461
	public bool Character;

	// Token: 0x040001CE RID: 462
	public bool OccupySquare;

	// Token: 0x040001CF RID: 463
	public bool FullOccupy;

	// Token: 0x040001D0 RID: 464
	public bool EnemyOccupySquare;

	// Token: 0x040001D1 RID: 465
	public bool Static;

	// Token: 0x040001F3 RID: 499
	public int[] Inventory = new int[]
	{
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1
	};

	// Token: 0x040001F4 RID: 500
	public bool CanEnterPortal;

	// Token: 0x040001F5 RID: 501
	public string AccountId;

	// Token: 0x040001F8 RID: 504
	public int AccountFame;

	// Token: 0x040001F9 RID: 505
	public int GuildRank;

	// Token: 0x04000210 RID: 528
	private static readonly List<int> UnlistedBosses = new List<int>
		{
			1337,
			2048,
			2340,
			2349,
			3448,
			3449,
			3452,
			3613,
			3622,
			4312,
			4324,
			4325,
			4326,
			5943,
			8200,
			24092,
			24327,
			24351,
			24363,
			24587,
			29003,
			29021,
			29039,
			29341,
			29342,
			29723,
			29764,
			30026,
			45104,
			45371,
			45076,
			28618,
			28619,
			32751,
			29793
		};
}
