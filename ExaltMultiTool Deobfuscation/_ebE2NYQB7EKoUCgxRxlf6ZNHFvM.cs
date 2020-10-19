using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x0200009C RID: 156
internal class _ebE2NYQB7EKoUCgxRxlf6ZNHFvM : Packet
{
	// Token: 0x17000135 RID: 309
	// (get) Token: 0x06000449 RID: 1097 RVA: 0x00016D3C File Offset: 0x00014F3C
	public override PacketType Type
	{
		get
		{
			return PacketType.TRADESTART;
		}
	}

	// Token: 0x0600044A RID: 1098 RVA: 0x00016D4C File Offset: 0x00014F4C
	public override void Read(PacketReader r)
	{
		this._8gnXXNFcmalqfCKbnCKV0nfs2mH = new _cw4BmSKJnnKhbzkGsIEJTEJcKKS[(int)r.ReadInt16()];
		for (int i = 0; i < this._8gnXXNFcmalqfCKbnCKV0nfs2mH.Length; i++)
		{
			this._8gnXXNFcmalqfCKbnCKV0nfs2mH[i] = new _cw4BmSKJnnKhbzkGsIEJTEJcKKS(r);
		}
		this._1l9b2vYrvHLlSwzM9YmhVuCOPFP = r.ReadString();
		this._bU7DO24Qe6U9yWrQibZIoZ0cSbC = new _cw4BmSKJnnKhbzkGsIEJTEJcKKS[(int)r.ReadInt16()];
		for (int j = 0; j < this._bU7DO24Qe6U9yWrQibZIoZ0cSbC.Length; j++)
		{
			this._bU7DO24Qe6U9yWrQibZIoZ0cSbC[j] = new _cw4BmSKJnnKhbzkGsIEJTEJcKKS(r);
		}
		this._7lEDJBHqNQSeLC6x5LcHbTq6WkF = r.ReadInt32();
	}

	// Token: 0x0600044B RID: 1099 RVA: 0x00016DD8 File Offset: 0x00014FD8
	public override void Write(PacketWriter w)
	{
		w.Write((ushort)this._8gnXXNFcmalqfCKbnCKV0nfs2mH.Length);
		_cw4BmSKJnnKhbzkGsIEJTEJcKKS[] array = this._8gnXXNFcmalqfCKbnCKV0nfs2mH;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].Write(w);
		}
		w.Write(this._1l9b2vYrvHLlSwzM9YmhVuCOPFP);
		w.Write((ushort)this._bU7DO24Qe6U9yWrQibZIoZ0cSbC.Length);
		array = this._bU7DO24Qe6U9yWrQibZIoZ0cSbC;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].Write(w);
		}
		w.Write(this._7lEDJBHqNQSeLC6x5LcHbTq6WkF);
	}

	// Token: 0x04000576 RID: 1398
	public _cw4BmSKJnnKhbzkGsIEJTEJcKKS[] _8gnXXNFcmalqfCKbnCKV0nfs2mH;

	// Token: 0x04000577 RID: 1399
	public string _1l9b2vYrvHLlSwzM9YmhVuCOPFP;

	// Token: 0x04000578 RID: 1400
	public _cw4BmSKJnnKhbzkGsIEJTEJcKKS[] _bU7DO24Qe6U9yWrQibZIoZ0cSbC;

	// Token: 0x04000579 RID: 1401
	public int _7lEDJBHqNQSeLC6x5LcHbTq6WkF;
}
