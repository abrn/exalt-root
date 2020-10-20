using System;
using System.Collections.Generic;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000077 RID: 119
internal class _4wU9AwmH67XtmNygsXuDz9DUXYm : Packet
{
	// Token: 0x17000110 RID: 272
	// (get) Token: 0x060003B0 RID: 944 RVA: 0x000150D0 File Offset: 0x000132D0
	public override PacketType Type
	{
		get
		{
			return PacketType.DAMAGE;
		}
	}

	// Token: 0x060003B1 RID: 945 RVA: 0x000150E0 File Offset: 0x000132E0
	public override void Read(PacketReader r)
	{
		this.TargetId = r.ReadInt32();
		byte b = r.ReadByte();
		this._xRou6pLb1OAINZAI0Yki8s1brKc = (ConditionEffects)0;
		for (int i = 0; i < (int)b; i++)
		{
			this._xRou6pLb1OAINZAI0Yki8s1brKc |= (ConditionEffects)(1 << (int)r.ReadByte());
		}
		this._Q1PiJQ99KBCJeLcZ0HOk3AUAjIP = r.ReadUInt16();
		this._M3PGxU4nNuXDsBnmxkUUzv2UADh = r.ReadByte();
		this._2ngiu12rPzXamKVx8VRv7bDEspS = ((this._M3PGxU4nNuXDsBnmxkUUzv2UADh & 1) > 0);
		this._cOOwLggepjcumTMmHiNjo8G61wH = ((this._M3PGxU4nNuXDsBnmxkUUzv2UADh & 2) > 0);
		this._cvRdSzlVcAcxDFt0A1VEPQuZ9r = ((this._M3PGxU4nNuXDsBnmxkUUzv2UADh & 4) > 0);
		this._0v4mmgyFOmt9eSc23UclkqyBncC = r.ReadByte();
		this.ObjectId = r.ReadInt32();
	}

	// Token: 0x060003B2 RID: 946 RVA: 0x00015190 File Offset: 0x00013390
	public override void Write(PacketWriter w)
	{
		w.Write(this.TargetId);
		List<byte> list = new List<byte>();
		for (byte b = 1; b < 255; b += 1)
		{
			if ((this._xRou6pLb1OAINZAI0Yki8s1brKc & (ConditionEffects)(1 << (int)b)) != (ConditionEffects)0)
			{
				list.Add(b);
			}
		}
		w.Write((byte)list.Count);
		foreach (byte value in list)
		{
			w.Write(value);
		}
		w.Write(this._Q1PiJQ99KBCJeLcZ0HOk3AUAjIP);
		w.Write(this._M3PGxU4nNuXDsBnmxkUUzv2UADh);
		w.Write(this._0v4mmgyFOmt9eSc23UclkqyBncC);
		w.Write(this.ObjectId);
	}

	// Token: 0x040004E8 RID: 1256
	private const int _eIf3o1zz3FOay2jGBrIm9Sj1KSG = 1;

	// Token: 0x040004E9 RID: 1257
	private const int _oNOP8EBTKvHnWFC8pFJg0ANhvW = 2;

	// Token: 0x040004EA RID: 1258
	private const int _YfrhiknsMbdgnAQqv8oIvyoqPaB = 4;

	// Token: 0x040004EB RID: 1259
	public int TargetId;

	// Token: 0x040004EC RID: 1260
	public ConditionEffects _xRou6pLb1OAINZAI0Yki8s1brKc;

	// Token: 0x040004ED RID: 1261
	public ushort _Q1PiJQ99KBCJeLcZ0HOk3AUAjIP;

	// Token: 0x040004EE RID: 1262
	public byte _M3PGxU4nNuXDsBnmxkUUzv2UADh;

	// Token: 0x040004EF RID: 1263
	public bool _2ngiu12rPzXamKVx8VRv7bDEspS;

	// Token: 0x040004F0 RID: 1264
	public bool _cOOwLggepjcumTMmHiNjo8G61wH;

	// Token: 0x040004F1 RID: 1265
	public bool _cvRdSzlVcAcxDFt0A1VEPQuZ9r;

	// Token: 0x040004F2 RID: 1266
	public byte _0v4mmgyFOmt9eSc23UclkqyBncC;

	// Token: 0x040004F3 RID: 1267
	public int ObjectId;
}
