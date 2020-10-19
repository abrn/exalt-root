using System;

// Token: 0x0200003B RID: 59
internal class _hVYZnKlD1p4NKgHvEIulwTgi91f : IDataObject, ICloneable
{
	// Token: 0x060002BE RID: 702 RVA: 0x000130FC File Offset: 0x000112FC
	public _hVYZnKlD1p4NKgHvEIulwTgi91f()
	{
	}

	// Token: 0x060002BF RID: 703 RVA: 0x00013110 File Offset: 0x00011310
	public _hVYZnKlD1p4NKgHvEIulwTgi91f(short x, short y, ushort type)
	{
		this._MFEyfKFQqtcdaBxZbAOPzXMB8iP = x;
		this._vwAmCOilfBfnOBAh94J77UFd0FV = y;
		this._k9uWQCZd8WqDr6yiKRmrLtst3KX = type;
	}

	// Token: 0x060002C0 RID: 704 RVA: 0x00013138 File Offset: 0x00011338
	public IDataObject Read(PacketReader r)
	{
		this._MFEyfKFQqtcdaBxZbAOPzXMB8iP = r.ReadInt16();
		this._vwAmCOilfBfnOBAh94J77UFd0FV = r.ReadInt16();
		this._k9uWQCZd8WqDr6yiKRmrLtst3KX = r.ReadUInt16();
		return this;
	}

	// Token: 0x060002C1 RID: 705 RVA: 0x0001316C File Offset: 0x0001136C
	public void Write(PacketWriter w)
	{
		w.Write(this._MFEyfKFQqtcdaBxZbAOPzXMB8iP);
		w.Write(this._vwAmCOilfBfnOBAh94J77UFd0FV);
		w.Write(this._k9uWQCZd8WqDr6yiKRmrLtst3KX);
	}

	// Token: 0x060002C2 RID: 706 RVA: 0x000131A0 File Offset: 0x000113A0
	public object Clone()
	{
		return new _hVYZnKlD1p4NKgHvEIulwTgi91f(this._MFEyfKFQqtcdaBxZbAOPzXMB8iP, this._vwAmCOilfBfnOBAh94J77UFd0FV, this._k9uWQCZd8WqDr6yiKRmrLtst3KX);
	}

	// Token: 0x060002C3 RID: 707 RVA: 0x000131C4 File Offset: 0x000113C4
	public virtual string _Ye7Bzeo9ipi3HJQJeW2fYB88LbJ()
	{
		return string.Format("{{ X={0}, Y={1}, Type={2} }}", this._MFEyfKFQqtcdaBxZbAOPzXMB8iP, this._vwAmCOilfBfnOBAh94J77UFd0FV, this._k9uWQCZd8WqDr6yiKRmrLtst3KX);
	}

	// Token: 0x04000453 RID: 1107
	public short _MFEyfKFQqtcdaBxZbAOPzXMB8iP;

	// Token: 0x04000454 RID: 1108
	public short _vwAmCOilfBfnOBAh94J77UFd0FV;

	// Token: 0x04000455 RID: 1109
	public ushort _k9uWQCZd8WqDr6yiKRmrLtst3KX;
}
