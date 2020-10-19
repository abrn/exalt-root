using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000079 RID: 121
internal class _CBWrHXLbrCktla3qkqXNmNymbvH : Packet
{
	// Token: 0x17000112 RID: 274
	// (get) Token: 0x060003B8 RID: 952 RVA: 0x00015340 File Offset: 0x00013540
	public override PacketType Type
	{
		get
		{
			return PacketType.ENEMYSHOOT;
		}
	}

	// Token: 0x060003B9 RID: 953 RVA: 0x00015350 File Offset: 0x00013550
	public override void Read(PacketReader r)
	{
		this._0v4mmgyFOmt9eSc23UclkqyBncC = r.ReadByte();
		this._o1vIAcFEkLsw697hhlSgXnC4w9g = r.ReadInt32();
		this._U7AZyGcFQm4AJLAEAuhbwgnobvG = r.ReadByte();
		this._v9pyCwpTOdm9mtxft8q4OoLOE3B = new Location(r);
		this._49dbaYgeVV0XCrIkHrqAGgDf2mFA = r.ReadSingle();
		this._Q1PiJQ99KBCJeLcZ0HOk3AUAjIP = r.ReadInt16();
		if (r.BaseStream.Position >= r.BaseStream.Length)
		{
			this._iJYXKz0RNaSBkr15qJpRokSEGeT = 1;
			this._AMPBCUrJf25cjHcTVtMhU0crO3Qb = 0f;
			return;
		}
		this._iJYXKz0RNaSBkr15qJpRokSEGeT = r.ReadByte();
		this._AMPBCUrJf25cjHcTVtMhU0crO3Qb = r.ReadSingle();
	}

	// Token: 0x060003BA RID: 954 RVA: 0x000153E8 File Offset: 0x000135E8
	public override void Write(PacketWriter w)
	{
		w.Write(this._0v4mmgyFOmt9eSc23UclkqyBncC);
		w.Write(this._o1vIAcFEkLsw697hhlSgXnC4w9g);
		w.Write(this._U7AZyGcFQm4AJLAEAuhbwgnobvG);
		this._v9pyCwpTOdm9mtxft8q4OoLOE3B.Write(w);
		w.Write(this._49dbaYgeVV0XCrIkHrqAGgDf2mFA);
		w.Write(this._Q1PiJQ99KBCJeLcZ0HOk3AUAjIP);
		if (this._iJYXKz0RNaSBkr15qJpRokSEGeT != 1)
		{
			w.Write(this._iJYXKz0RNaSBkr15qJpRokSEGeT);
			w.Write(this._AMPBCUrJf25cjHcTVtMhU0crO3Qb);
		}
	}

	// Token: 0x040004FA RID: 1274
	public byte _0v4mmgyFOmt9eSc23UclkqyBncC;

	// Token: 0x040004FB RID: 1275
	public int _o1vIAcFEkLsw697hhlSgXnC4w9g;

	// Token: 0x040004FC RID: 1276
	public byte _U7AZyGcFQm4AJLAEAuhbwgnobvG;

	// Token: 0x040004FD RID: 1277
	public Location _v9pyCwpTOdm9mtxft8q4OoLOE3B;

	// Token: 0x040004FE RID: 1278
	public float _49dbaYgeVV0XCrIkHrqAGgDf2mFA;

	// Token: 0x040004FF RID: 1279
	public short _Q1PiJQ99KBCJeLcZ0HOk3AUAjIP;

	// Token: 0x04000500 RID: 1280
	public byte _iJYXKz0RNaSBkr15qJpRokSEGeT;

	// Token: 0x04000501 RID: 1281
	public float _AMPBCUrJf25cjHcTVtMhU0crO3Qb;
}
