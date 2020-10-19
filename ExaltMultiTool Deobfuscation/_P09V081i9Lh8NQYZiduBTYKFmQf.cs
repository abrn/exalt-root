using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000082 RID: 130
internal class MapInfoPacket : Packet
{
	// Token: 0x1700011B RID: 283
	// (get) Token: 0x060003DC RID: 988 RVA: 0x00015874 File Offset: 0x00013A74
	public override PacketType Type
	{
		get
		{
			return PacketType.MAPINFO;
		}
	}

	// Token: 0x060003DD RID: 989 RVA: 0x00015884 File Offset: 0x00013A84
	public override void Read(PacketReader r)
	{
		this._pCEEx7DVSfoKsVtOFqw3jIq365d = r.ReadInt32();
		this._92R8iOIVdqdeKvPcqUJAUojZv04 = r.ReadInt32();
		this._Jp3DtIV4aAYZY26sVsXpPQjBRGO = r.ReadString();
		this._qj8dhntiHGuupB7WCO6MqhVu9Gk = r.ReadString();
		this._40uBmtUgIhA00uHUvBaukNTl5IJ = r.ReadString();
		this._8BqcoKCa24PgCbJ6omzKCS4ddwe = r.ReadUInt32();
		this._0icLbg1a0R7DmLUCTSXbjohkq0qA = r.ReadInt32();
		this._cbSTRKVWT0vZxa6dMndfCize5qI = r.ReadInt32();
		this._x71SpSMNAviwa63BTEZfGszpp14 = r.ReadBoolean();
		this._9jduv1Du0GQYO0LLS55FZDdHuBe = r.ReadBoolean();
		this._t1wFaqP1jWwllWK3z9AoUWs5UgE = r.ReadInt16();
		this._gJoC6vMNCgLy8gERjMJFefbQQik = r.ReadString();
		this._Whwc3CMIHuZj4jHkpfLVzxo3oue = r.ReadUInt32();
		this._NKlJ9vpQwR31qi2KWDlaR5u2Qqi = new string[(int)r.ReadInt16()];
		for (int i = 0; i < this._NKlJ9vpQwR31qi2KWDlaR5u2Qqi.Length; i++)
		{
			this._NKlJ9vpQwR31qi2KWDlaR5u2Qqi[i] = r.ReadUTF32();
		}
		this._cPRBw4BtFbeLK0I633Djdb7DlWM = new string[(int)r.ReadInt16()];
		for (int j = 0; j < this._cPRBw4BtFbeLK0I633Djdb7DlWM.Length; j++)
		{
			this._cPRBw4BtFbeLK0I633Djdb7DlWM[j] = r.ReadUTF32();
		}
		this._NRtkt4Ru8i9Ls0Mbru0TAC9Vddg = r.ReadString();
	}

	// Token: 0x060003DE RID: 990 RVA: 0x000159A0 File Offset: 0x00013BA0
	public override void Write(PacketWriter w)
	{
		w.Write(this._pCEEx7DVSfoKsVtOFqw3jIq365d);
		w.Write(this._92R8iOIVdqdeKvPcqUJAUojZv04);
		w.Write(this._Jp3DtIV4aAYZY26sVsXpPQjBRGO);
		w.Write(this._qj8dhntiHGuupB7WCO6MqhVu9Gk);
		w.Write(this._40uBmtUgIhA00uHUvBaukNTl5IJ);
		w.Write(this._8BqcoKCa24PgCbJ6omzKCS4ddwe);
		w.Write(this._0icLbg1a0R7DmLUCTSXbjohkq0qA);
		w.Write(this._cbSTRKVWT0vZxa6dMndfCize5qI);
		w.Write(this._x71SpSMNAviwa63BTEZfGszpp14);
		w.Write(this._9jduv1Du0GQYO0LLS55FZDdHuBe);
		w.Write(this._t1wFaqP1jWwllWK3z9AoUWs5UgE);
		w.Write(this._gJoC6vMNCgLy8gERjMJFefbQQik);
		w.Write(this._Whwc3CMIHuZj4jHkpfLVzxo3oue);
		w.Write((short)this._NKlJ9vpQwR31qi2KWDlaR5u2Qqi.Length);
		foreach (string value in this._NKlJ9vpQwR31qi2KWDlaR5u2Qqi)
		{
			w.WriteUTF32(value);
		}
		w.Write((short)this._cPRBw4BtFbeLK0I633Djdb7DlWM.Length);
		foreach (string value2 in this._cPRBw4BtFbeLK0I633Djdb7DlWM)
		{
			w.WriteUTF32(value2);
		}
		w.Write(this._NRtkt4Ru8i9Ls0Mbru0TAC9Vddg);
	}

	// Token: 0x04000514 RID: 1300
	public int _pCEEx7DVSfoKsVtOFqw3jIq365d;

	// Token: 0x04000515 RID: 1301
	public int _92R8iOIVdqdeKvPcqUJAUojZv04;

	// Token: 0x04000516 RID: 1302
	public string _Jp3DtIV4aAYZY26sVsXpPQjBRGO;

	// Token: 0x04000517 RID: 1303
	public string _qj8dhntiHGuupB7WCO6MqhVu9Gk;

	// Token: 0x04000518 RID: 1304
	public string _40uBmtUgIhA00uHUvBaukNTl5IJ;

	// Token: 0x04000519 RID: 1305
	public int _cbSTRKVWT0vZxa6dMndfCize5qI;

	// Token: 0x0400051A RID: 1306
	public uint _8BqcoKCa24PgCbJ6omzKCS4ddwe;

	// Token: 0x0400051B RID: 1307
	public int _0icLbg1a0R7DmLUCTSXbjohkq0qA;

	// Token: 0x0400051C RID: 1308
	public bool _x71SpSMNAviwa63BTEZfGszpp14;

	// Token: 0x0400051D RID: 1309
	public bool _9jduv1Du0GQYO0LLS55FZDdHuBe;

	// Token: 0x0400051E RID: 1310
	public short _t1wFaqP1jWwllWK3z9AoUWs5UgE;

	// Token: 0x0400051F RID: 1311
	public string _gJoC6vMNCgLy8gERjMJFefbQQik;

	// Token: 0x04000520 RID: 1312
	public uint _Whwc3CMIHuZj4jHkpfLVzxo3oue;

	// Token: 0x04000521 RID: 1313
	public string _NRtkt4Ru8i9Ls0Mbru0TAC9Vddg;

	// Token: 0x04000522 RID: 1314
	public string[] _NKlJ9vpQwR31qi2KWDlaR5u2Qqi = new string[0];

	// Token: 0x04000523 RID: 1315
	public string[] _cPRBw4BtFbeLK0I633Djdb7DlWM = new string[0];
}
