using System;

// Token: 0x02000030 RID: 48
internal class _cw4BmSKJnnKhbzkGsIEJTEJcKKS : IDataObject, ICloneable
{
	// Token: 0x0600026A RID: 618 RVA: 0x00011140 File Offset: 0x0000F340
	public _cw4BmSKJnnKhbzkGsIEJTEJcKKS()
	{
	}

	// Token: 0x0600026B RID: 619 RVA: 0x00011154 File Offset: 0x0000F354
	public _cw4BmSKJnnKhbzkGsIEJTEJcKKS(PacketReader r)
	{
		this._sbrtig45lkNbhXIjOScuimkbxyW = r.ReadInt32();
		this._nUppUQcAEeCO15B53eSIwjaZ8yK = r.ReadInt32();
		this._MqAsmS1QP4XsDIHDMlbb0JJi7i4 = r.ReadBoolean();
		this._C0DOrNxAEK989ot8WBgCFmURUpY = r.ReadBoolean();
	}

	// Token: 0x0600026C RID: 620 RVA: 0x00011198 File Offset: 0x0000F398
	public IDataObject Read(PacketReader r)
	{
		this._sbrtig45lkNbhXIjOScuimkbxyW = r.ReadInt32();
		this._nUppUQcAEeCO15B53eSIwjaZ8yK = r.ReadInt32();
		this._MqAsmS1QP4XsDIHDMlbb0JJi7i4 = r.ReadBoolean();
		this._C0DOrNxAEK989ot8WBgCFmURUpY = r.ReadBoolean();
		return this;
	}

	// Token: 0x0600026D RID: 621 RVA: 0x000111D8 File Offset: 0x0000F3D8
	public void Write(PacketWriter w)
	{
		w.Write(this._sbrtig45lkNbhXIjOScuimkbxyW);
		w.Write(this._nUppUQcAEeCO15B53eSIwjaZ8yK);
		w.Write(this._MqAsmS1QP4XsDIHDMlbb0JJi7i4);
		w.Write(this._C0DOrNxAEK989ot8WBgCFmURUpY);
	}

	// Token: 0x0600026E RID: 622 RVA: 0x00011218 File Offset: 0x0000F418
	public object Clone()
	{
		return new _cw4BmSKJnnKhbzkGsIEJTEJcKKS
		{
			_sbrtig45lkNbhXIjOScuimkbxyW = this._sbrtig45lkNbhXIjOScuimkbxyW,
			_nUppUQcAEeCO15B53eSIwjaZ8yK = this._nUppUQcAEeCO15B53eSIwjaZ8yK,
			_MqAsmS1QP4XsDIHDMlbb0JJi7i4 = this._MqAsmS1QP4XsDIHDMlbb0JJi7i4,
			_C0DOrNxAEK989ot8WBgCFmURUpY = this._C0DOrNxAEK989ot8WBgCFmURUpY
		};
	}

	// Token: 0x0600026F RID: 623 RVA: 0x0001125C File Offset: 0x0000F45C
	public virtual string _Ye7Bzeo9ipi3HJQJeW2fYB88LbJ()
	{
		return string.Concat(new string[]
		{
			"{ ItemItem=",
			this._sbrtig45lkNbhXIjOScuimkbxyW.ToString(),
			", SlotType=",
			this._nUppUQcAEeCO15B53eSIwjaZ8yK.ToString(),
			", Tradable=",
			this._MqAsmS1QP4XsDIHDMlbb0JJi7i4.ToString(),
			", Included=",
			this._C0DOrNxAEK989ot8WBgCFmURUpY.ToString(),
			" }"
		});
	}

	// Token: 0x0400031F RID: 799
	public int _sbrtig45lkNbhXIjOScuimkbxyW;

	// Token: 0x04000320 RID: 800
	public int _nUppUQcAEeCO15B53eSIwjaZ8yK;

	// Token: 0x04000321 RID: 801
	public bool _MqAsmS1QP4XsDIHDMlbb0JJi7i4;

	// Token: 0x04000322 RID: 802
	public bool _C0DOrNxAEK989ot8WBgCFmURUpY;
}
