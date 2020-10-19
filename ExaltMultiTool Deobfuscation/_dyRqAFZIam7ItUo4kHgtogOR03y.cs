using System;

// Token: 0x0200009D RID: 157
internal class _dyRqAFZIam7ItUo4kHgtogOR03y : Packet
{
	// Token: 0x0600044D RID: 1101 RVA: 0x00016E6C File Offset: 0x0001506C
	public override void Read(PacketReader r)
	{
		this._aEt2m1KmAUMmB6GB1VH6xO7nfTo = r.ReadBoolean();
		this._vHwvFTdtybw0wbMUYb9dAbmmlwo = _di3Iyuw9XRVUyJrW7NCBFduCW4H._eHIpo1lHmEGnQwbA8tDvcpJtdfl(r);
		this._dTandZssr5wqR01xSFUDFq5dcMG = _di3Iyuw9XRVUyJrW7NCBFduCW4H._eHIpo1lHmEGnQwbA8tDvcpJtdfl(r);
		this._ojemGvaGxKtDMP5HMiAE7112GWE = _di3Iyuw9XRVUyJrW7NCBFduCW4H._eHIpo1lHmEGnQwbA8tDvcpJtdfl(r);
		int num = _di3Iyuw9XRVUyJrW7NCBFduCW4H._eHIpo1lHmEGnQwbA8tDvcpJtdfl(r);
		this._lDZ2Fa0xsQLf7DftRC2peVut2Wh = new int[num];
		for (int i = 0; i < num; i++)
		{
			this._lDZ2Fa0xsQLf7DftRC2peVut2Wh[i] = _di3Iyuw9XRVUyJrW7NCBFduCW4H._eHIpo1lHmEGnQwbA8tDvcpJtdfl(r);
		}
		num = _di3Iyuw9XRVUyJrW7NCBFduCW4H._eHIpo1lHmEGnQwbA8tDvcpJtdfl(r);
		this._5C5D2XeNHhtkTpVa000vhfE0GpcA = new int[num];
		for (int i = 0; i < num; i++)
		{
			this._5C5D2XeNHhtkTpVa000vhfE0GpcA[i] = _di3Iyuw9XRVUyJrW7NCBFduCW4H._eHIpo1lHmEGnQwbA8tDvcpJtdfl(r);
		}
		num = _di3Iyuw9XRVUyJrW7NCBFduCW4H._eHIpo1lHmEGnQwbA8tDvcpJtdfl(r);
		this._tTjbnC1WCSEVy0Xbj9YV3MXie4n = new int[num];
		for (int i = 0; i < num; i++)
		{
			this._tTjbnC1WCSEVy0Xbj9YV3MXie4n[i] = _di3Iyuw9XRVUyJrW7NCBFduCW4H._eHIpo1lHmEGnQwbA8tDvcpJtdfl(r);
		}
		this._z4gKavtyvb3dxFmEc8EzDvPwPDw = (int)r.ReadInt16();
		this._VYjsOGPwGgg72VFk07reSzsChTf = (int)r.ReadInt16();
		this._5zhyyxAz2TXSmgDcDfn7a3zN7Ii = (int)r.ReadInt16();
		this._EWTLEoXjLqMr6Byb33lrerAdckT = (int)r.ReadInt16();
	}

	// Token: 0x0600044E RID: 1102 RVA: 0x00016F60 File Offset: 0x00015160
	public override void Write(PacketWriter w)
	{
		w.Write(this._aEt2m1KmAUMmB6GB1VH6xO7nfTo);
		w.Write(this._vHwvFTdtybw0wbMUYb9dAbmmlwo);
		w.Write(this._dTandZssr5wqR01xSFUDFq5dcMG);
		w.Write(this._ojemGvaGxKtDMP5HMiAE7112GWE);
		w.Write((short)this._lDZ2Fa0xsQLf7DftRC2peVut2Wh.Length);
		foreach (int value in this._lDZ2Fa0xsQLf7DftRC2peVut2Wh)
		{
			w.Write(value);
		}
		w.Write((short)this._5C5D2XeNHhtkTpVa000vhfE0GpcA.Length);
		foreach (int value2 in this._5C5D2XeNHhtkTpVa000vhfE0GpcA)
		{
			w.Write(value2);
		}
		w.Write((short)this._tTjbnC1WCSEVy0Xbj9YV3MXie4n.Length);
		foreach (int value3 in this._tTjbnC1WCSEVy0Xbj9YV3MXie4n)
		{
			w.Write(value3);
		}
		w.Write(this._z4gKavtyvb3dxFmEc8EzDvPwPDw);
		w.Write(this._VYjsOGPwGgg72VFk07reSzsChTf);
		w.Write(this._5zhyyxAz2TXSmgDcDfn7a3zN7Ii);
		w.Write(this._EWTLEoXjLqMr6Byb33lrerAdckT);
	}

	// Token: 0x0400057A RID: 1402
	public bool _aEt2m1KmAUMmB6GB1VH6xO7nfTo;

	// Token: 0x0400057B RID: 1403
	public int _vHwvFTdtybw0wbMUYb9dAbmmlwo;

	// Token: 0x0400057C RID: 1404
	public int _dTandZssr5wqR01xSFUDFq5dcMG;

	// Token: 0x0400057D RID: 1405
	public int _ojemGvaGxKtDMP5HMiAE7112GWE;

	// Token: 0x0400057E RID: 1406
	public int[] _lDZ2Fa0xsQLf7DftRC2peVut2Wh;

	// Token: 0x0400057F RID: 1407
	public int[] _5C5D2XeNHhtkTpVa000vhfE0GpcA;

	// Token: 0x04000580 RID: 1408
	public int[] _tTjbnC1WCSEVy0Xbj9YV3MXie4n;

	// Token: 0x04000581 RID: 1409
	public int _z4gKavtyvb3dxFmEc8EzDvPwPDw;

	// Token: 0x04000582 RID: 1410
	public int _VYjsOGPwGgg72VFk07reSzsChTf;

	// Token: 0x04000583 RID: 1411
	public int _5zhyyxAz2TXSmgDcDfn7a3zN7Ii;

	// Token: 0x04000584 RID: 1412
	public int _EWTLEoXjLqMr6Byb33lrerAdckT;
}
