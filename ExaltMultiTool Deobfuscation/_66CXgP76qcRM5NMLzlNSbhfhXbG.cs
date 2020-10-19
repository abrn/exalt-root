using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using ExaltMultiTool.Proxy.DataStructures;

// Token: 0x020000C4 RID: 196
internal class _66CXgP76qcRM5NMLzlNSbhfhXbG : IDataStructure<ushort>
{
	// Token: 0x06000525 RID: 1317 RVA: 0x0001EDBC File Offset: 0x0001CFBC
	internal static Dictionary<ushort, _66CXgP76qcRM5NMLzlNSbhfhXbG> _gKKd0PApBLw4Hl4Oj4Z6UarwYVc(XDocument doc)
	{
		_66CXgP76qcRM5NMLzlNSbhfhXbG._scX3EzcsG7EnfglOEZnrcQOXMvg scX3EzcsG7EnfglOEZnrcQOXMvg = new _66CXgP76qcRM5NMLzlNSbhfhXbG._scX3EzcsG7EnfglOEZnrcQOXMvg();
		scX3EzcsG7EnfglOEZnrcQOXMvg._Kndj0w1wpl2a6oPYP8TaQVSkPtR = new Dictionary<ushort, _66CXgP76qcRM5NMLzlNSbhfhXbG>();
		doc.Element("Objects").Elements("Object").Where(new Func<XElement, bool>(_66CXgP76qcRM5NMLzlNSbhfhXbG._pEFaz9qb0BYKJUd5mVB8ZFXUwMg.<>9._GCBlMH3OTN6TV6oACvglvvrOmTR))._mDNyNFYbqpk6ULly4BYiq6ShWsn(new Action<XElement>(scX3EzcsG7EnfglOEZnrcQOXMvg._fFWNtW4btW9NFPrxjFKOW6uqCMp));
		return scX3EzcsG7EnfglOEZnrcQOXMvg._Kndj0w1wpl2a6oPYP8TaQVSkPtR;
	}

	// Token: 0x1700013D RID: 317
	// (get) Token: 0x06000526 RID: 1318 RVA: 0x0001EE38 File Offset: 0x0001D038
	// (set) Token: 0x06000527 RID: 1319 RVA: 0x0001EE4C File Offset: 0x0001D04C
	public ushort ID { get; private set; }

	// Token: 0x1700013E RID: 318
	// (get) Token: 0x06000528 RID: 1320 RVA: 0x0001EE60 File Offset: 0x0001D060
	// (set) Token: 0x06000529 RID: 1321 RVA: 0x0001EE74 File Offset: 0x0001D074
	public string Name { get; private set; }

	// Token: 0x0600052A RID: 1322 RVA: 0x0001EE88 File Offset: 0x0001D088
	public _66CXgP76qcRM5NMLzlNSbhfhXbG(XElement item)
	{
		/*
An exception occurred when decompiling this method (0600052A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void _66CXgP76qcRM5NMLzlNSbhfhXbG::.ctor(System.Xml.Linq.XElement)
 ---> System.Exception: Inconsistent stack size at IL_1ED
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 279
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 269
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in C:\projects\dnspy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1545
*/;
	}

	// Token: 0x0600052B RID: 1323 RVA: 0x0001F148 File Offset: 0x0001D348
	private void _7pEdStpqTzVAkmRmG6QdEDbT3PrA(IEnumerable<XElement> activateXMLs)
	{
		foreach (XElement activate in activateXMLs)
		{
			this._dHPNoGlmrfb0cl4aaEGpRxXcgRw.Add(new _kEekgEziy3MAWF43C6Y4bLsMB7E(activate));
		}
	}

	// Token: 0x0600052C RID: 1324 RVA: 0x0001F19C File Offset: 0x0001D39C
	public virtual string _Ye7Bzeo9ipi3HJQJeW2fYB88LbJ()
	{
		return string.Format("Item: {0} (0x{1:X})", this.Name, this.ID);
	}

	// Token: 0x04000679 RID: 1657
	[CompilerGenerated]
	private ushort _wLyKBFmJlsIH8DtqnZeUZOuEITZ;

	// Token: 0x0400067A RID: 1658
	public ProjectileStructure _hEKV2n49EDOyZ8ibopOnEaZqWkk;

	// Token: 0x0400067B RID: 1659
	public int _VpFa8CFamucJQ3qD0BQ0lIFhXke;

	// Token: 0x0400067C RID: 1660
	public _FvA2grK5CUVSLJHb7V5mXAgE1SA _EasYH1zBgDZtaXhuG2mVF2bKxKu;

	// Token: 0x0400067D RID: 1661
	public byte _nUppUQcAEeCO15B53eSIwjaZ8yK;

	// Token: 0x0400067E RID: 1662
	public float _NNkCO0G1C0xjsQ8siIUf5aBAq9c;

	// Token: 0x0400067F RID: 1663
	public uint _dBAtE2atmri4ZhQRt9i5Yjx29Gd;

	// Token: 0x04000680 RID: 1664
	public byte _wIvHEuGsusB98pBCzDopnwnt2cj;

	// Token: 0x04000681 RID: 1665
	public byte _ZyGR9cgnDTSMpABHgSdj7cCMywb;

	// Token: 0x04000682 RID: 1666
	public decimal _tYSs4Ly8XTHvXe9jwJ9dhQMMttd;

	// Token: 0x04000683 RID: 1667
	public float _Vzv7oRwBjKStnFVmjJ1K02kmfeb;

	// Token: 0x04000684 RID: 1668
	public byte _jOJjaXD2cWVK1ERF4AVyMY4XdGi;

	// Token: 0x04000685 RID: 1669
	public bool _gTLskvvv9nSfruMKma3jIMeB9Di;

	// Token: 0x04000686 RID: 1670
	public bool _ENfLoz1h2VFPZlcUsLs3EgZ0P0H;

	// Token: 0x04000687 RID: 1671
	public bool _BU1iEIe59BmDxzIlReSh4lBTv5f;

	// Token: 0x04000688 RID: 1672
	[CompilerGenerated]
	private string _1haiPDr5g8HadcnTI4yRJZK2hEn;

	// Token: 0x04000689 RID: 1673
	public bool Potion;

	// Token: 0x0400068A RID: 1674
	public List<_kEekgEziy3MAWF43C6Y4bLsMB7E> _dHPNoGlmrfb0cl4aaEGpRxXcgRw;

	// Token: 0x020000C5 RID: 197
	[CompilerGenerated]
	private sealed class _scX3EzcsG7EnfglOEZnrcQOXMvg
	{
		// Token: 0x0600052E RID: 1326 RVA: 0x0001F1D8 File Offset: 0x0001D3D8
		internal void _fFWNtW4btW9NFPrxjFKOW6uqCMp(XElement item)
		{
			_66CXgP76qcRM5NMLzlNSbhfhXbG 66CXgP76qcRM5NMLzlNSbhfhXbG = new _66CXgP76qcRM5NMLzlNSbhfhXbG(item);
			this._Kndj0w1wpl2a6oPYP8TaQVSkPtR[66CXgP76qcRM5NMLzlNSbhfhXbG._X5iK7DxZXqEuFaG5vPlQc32oVuG] = 66CXgP76qcRM5NMLzlNSbhfhXbG;
		}

		// Token: 0x0400068B RID: 1675
		public Dictionary<ushort, _66CXgP76qcRM5NMLzlNSbhfhXbG> _Kndj0w1wpl2a6oPYP8TaQVSkPtR;
	}

	// Token: 0x020000C6 RID: 198
	[CompilerGenerated]
	[Serializable]
	private sealed class _pEFaz9qb0BYKJUd5mVB8ZFXUwMg
	{
		// Token: 0x06000531 RID: 1329 RVA: 0x0001F22C File Offset: 0x0001D42C
		internal bool _GCBlMH3OTN6TV6oACvglvvrOmTR(XElement elem)
		{
			return elem._v94aD6xnI4gMG97iMJhl8NatmPCb("Item");
		}

		// Token: 0x0400068C RID: 1676
		public static readonly _66CXgP76qcRM5NMLzlNSbhfhXbG._pEFaz9qb0BYKJUd5mVB8ZFXUwMg <>9 = new _66CXgP76qcRM5NMLzlNSbhfhXbG._pEFaz9qb0BYKJUd5mVB8ZFXUwMg();

		// Token: 0x0400068D RID: 1677
		public static Func<XElement, bool> <>9__0_0;
	}
}
