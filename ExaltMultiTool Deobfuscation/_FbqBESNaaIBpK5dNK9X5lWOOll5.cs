using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000061 RID: 97
internal class _FbqBESNaaIBpK5dNK9X5lWOOll5 : Packet
{
	// Token: 0x170000FA RID: 250
	// (get) Token: 0x06000358 RID: 856 RVA: 0x000145EC File Offset: 0x000127EC
	public override PacketType Type
	{
		get
		{
			return PacketType.PLAYERSHOOT;
		}
	}

	// Token: 0x06000359 RID: 857 RVA: 0x000145FC File Offset: 0x000127FC
	public override void Read(PacketReader r)
	{
		this._Nx46RcGIU0H1BCGWaJXjN1ieopt = r.ReadInt32();
		this._0v4mmgyFOmt9eSc23UclkqyBncC = r.ReadByte();
		this._1hqbXYh2SXWKV5rkAtGwzNqFsAb = r.ReadInt16();
		this._MkT06oCYgDubgW2NbEOzvLh8RLe = new Location(r);
		this._49dbaYgeVV0XCrIkHrqAGgDf2mFA = r.ReadSingle();
		this._M9pGV6VZGlTQ2NBOL4QU2edSL4e = r.ReadInt16();
		this._fYMO8qfurR42pgtSBHrubYGZS6d = r.ReadInt16();
		this._9n3wHFG0mCtQRdS4oFePzIHyjXg = r.ReadByte();
	}

	// Token: 0x0600035A RID: 858 RVA: 0x0001466C File Offset: 0x0001286C
	public override void Write(PacketWriter w)
	{
		w.Write(this._Nx46RcGIU0H1BCGWaJXjN1ieopt);
		w.Write(this._0v4mmgyFOmt9eSc23UclkqyBncC);
		w.Write(this._1hqbXYh2SXWKV5rkAtGwzNqFsAb);
		this._MkT06oCYgDubgW2NbEOzvLh8RLe.Write(w);
		w.Write(this._49dbaYgeVV0XCrIkHrqAGgDf2mFA);
		w.Write(this._M9pGV6VZGlTQ2NBOL4QU2edSL4e);
		w.Write(this._fYMO8qfurR42pgtSBHrubYGZS6d);
		w.Write(this._9n3wHFG0mCtQRdS4oFePzIHyjXg);
	}

	// Token: 0x040004B5 RID: 1205
	public int _Nx46RcGIU0H1BCGWaJXjN1ieopt;

	// Token: 0x040004B6 RID: 1206
	public byte _0v4mmgyFOmt9eSc23UclkqyBncC;

	// Token: 0x040004B7 RID: 1207
	public short _1hqbXYh2SXWKV5rkAtGwzNqFsAb;

	// Token: 0x040004B8 RID: 1208
	public Location _MkT06oCYgDubgW2NbEOzvLh8RLe;

	// Token: 0x040004B9 RID: 1209
	public float _49dbaYgeVV0XCrIkHrqAGgDf2mFA;

	// Token: 0x040004BA RID: 1210
	public short _M9pGV6VZGlTQ2NBOL4QU2edSL4e;

	// Token: 0x040004BB RID: 1211
	public short _fYMO8qfurR42pgtSBHrubYGZS6d;

	// Token: 0x040004BC RID: 1212
	public byte _9n3wHFG0mCtQRdS4oFePzIHyjXg;
}
