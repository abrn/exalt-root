using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000056 RID: 86
internal class HelloPacket : Packet
{
	// Token: 0x170000EF RID: 239
	// (get) Token: 0x0600032C RID: 812 RVA: 0x00013EA4 File Offset: 0x000120A4
	public override PacketType Type
	{
		get
		{
			return PacketType.HELLO;
		}
	}

	// Token: 0x0600032D RID: 813 RVA: 0x00013EB4 File Offset: 0x000120B4
	public override void Read(PacketReader r)
	{
		this._NU9mAyxB3sWcy4yIHa9MOLKpza3 = r.ReadString();
		this._ojOP4UJkvpLb2pFVOLoW9ZfpS9b = r.ReadInt32();
		this._xre6S65mHTaJBHeJh765LnmDVSK = r.ReadString();
		this._6728bewhyj8Cp1Pnfm6F9123iRb = r.ReadInt32();
		this._eY9j6GAbifH5csftAdH2WzvcDtI = r.ReadString();
		this._ZSh1S9K8Dy8Qvf3pAOVp0UiHTFg = r.ReadInt32();
		this._m0WSA5nsCUj8jKn7KFVZ9SWjW3 = r.ReadString();
		this._KGn7ld0wsUeBW3EMI4gXwdHM01K = r.ReadInt32();
		this._xXzOsvNNNch6IVvOFHUSv8Y0L8c = (byte[])r.ReadBytes((int)r.ReadInt16());
		this._EpZ82Fz7gonrRE5kAxTAkDMozYb = r.ReadUTF32();
		this._rQld6K1Y2mghgjFCDA0bOMF088A = r.ReadString();
		this._7RunJMABznwkmxaETdeZGCNCdQ0 = r.ReadString();
		this._7OF23Jfw4Qq4z8aAoqdFJqyARFU = r.ReadString();
		this._jsrbqoDCnKIi7BFAgieKgzCJiCBB = r.ReadString();
		this._kykeqgSGzqqEEjFAA5NBspoGrRs = r.ReadString();
		this._E8sjwkuzIckQ9qxRYXNhXzmpPvF = r.ReadString();
		this._X4xddGQcGS0PNftvXg0qzVOgTIH = r.ReadString();
		this._fLlvVOhYP3h0lwekrLzZ8hUSv8g = r.ReadString();
	}

	// Token: 0x0600032E RID: 814 RVA: 0x00013FA4 File Offset: 0x000121A4
	public override void Write(PacketWriter w)
	{
		w.Write(this._NU9mAyxB3sWcy4yIHa9MOLKpza3);
		w.Write(this._ojOP4UJkvpLb2pFVOLoW9ZfpS9b);
		w.Write(this._xre6S65mHTaJBHeJh765LnmDVSK);
		w.Write(this._6728bewhyj8Cp1Pnfm6F9123iRb);
		w.Write(this._eY9j6GAbifH5csftAdH2WzvcDtI);
		w.Write(this._ZSh1S9K8Dy8Qvf3pAOVp0UiHTFg);
		w.Write(this._m0WSA5nsCUj8jKn7KFVZ9SWjW3);
		w.Write(this._KGn7ld0wsUeBW3EMI4gXwdHM01K);
		w.Write((short)this._xXzOsvNNNch6IVvOFHUSv8Y0L8c.Length);
		w.Write((byte[])this._xXzOsvNNNch6IVvOFHUSv8Y0L8c);
		w.WriteUTF32(this._EpZ82Fz7gonrRE5kAxTAkDMozYb);
		w.Write(this._rQld6K1Y2mghgjFCDA0bOMF088A);
		w.Write(this._7RunJMABznwkmxaETdeZGCNCdQ0);
		w.Write(this._7OF23Jfw4Qq4z8aAoqdFJqyARFU);
		w.Write(this._jsrbqoDCnKIi7BFAgieKgzCJiCBB);
		w.Write(this._kykeqgSGzqqEEjFAA5NBspoGrRs);
		w.Write(this._E8sjwkuzIckQ9qxRYXNhXzmpPvF);
		w.Write(this._X4xddGQcGS0PNftvXg0qzVOgTIH);
		w.Write(this._fLlvVOhYP3h0lwekrLzZ8hUSv8g);
	}

	// Token: 0x04000485 RID: 1157
	public string _NU9mAyxB3sWcy4yIHa9MOLKpza3;

	// Token: 0x04000486 RID: 1158
	public int _ojOP4UJkvpLb2pFVOLoW9ZfpS9b;

	// Token: 0x04000487 RID: 1159
	public string _xre6S65mHTaJBHeJh765LnmDVSK;

	// Token: 0x04000488 RID: 1160
	public int _6728bewhyj8Cp1Pnfm6F9123iRb;

	// Token: 0x04000489 RID: 1161
	public string _eY9j6GAbifH5csftAdH2WzvcDtI;

	// Token: 0x0400048A RID: 1162
	public int _ZSh1S9K8Dy8Qvf3pAOVp0UiHTFg;

	// Token: 0x0400048B RID: 1163
	public string _m0WSA5nsCUj8jKn7KFVZ9SWjW3;

	// Token: 0x0400048C RID: 1164
	public int _KGn7ld0wsUeBW3EMI4gXwdHM01K;

	// Token: 0x0400048D RID: 1165
	public byte[] _xXzOsvNNNch6IVvOFHUSv8Y0L8c;

	// Token: 0x0400048E RID: 1166
	public string _EpZ82Fz7gonrRE5kAxTAkDMozYb;

	// Token: 0x0400048F RID: 1167
	public string _rQld6K1Y2mghgjFCDA0bOMF088A;

	// Token: 0x04000490 RID: 1168
	public string _7RunJMABznwkmxaETdeZGCNCdQ0;

	// Token: 0x04000491 RID: 1169
	public string _7OF23Jfw4Qq4z8aAoqdFJqyARFU;

	// Token: 0x04000492 RID: 1170
	public string _jsrbqoDCnKIi7BFAgieKgzCJiCBB;

	// Token: 0x04000493 RID: 1171
	public string _kykeqgSGzqqEEjFAA5NBspoGrRs;

	// Token: 0x04000494 RID: 1172
	public string _E8sjwkuzIckQ9qxRYXNhXzmpPvF;

	// Token: 0x04000495 RID: 1173
	public string _X4xddGQcGS0PNftvXg0qzVOgTIH;

	// Token: 0x04000496 RID: 1174
	public string _fLlvVOhYP3h0lwekrLzZ8hUSv8g;
}
