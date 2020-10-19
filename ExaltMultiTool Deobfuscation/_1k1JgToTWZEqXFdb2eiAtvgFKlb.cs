using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000041 RID: 65
internal class _1k1JgToTWZEqXFdb2eiAtvgFKlb : Packet
{
	// Token: 0x170000DA RID: 218
	// (get) Token: 0x060002D8 RID: 728 RVA: 0x0001353C File Offset: 0x0001173C
	public override PacketType Type
	{
		get
		{
			return PacketType.SQUAREHIT;
		}
	}

	// Token: 0x060002D9 RID: 729 RVA: 0x0001354C File Offset: 0x0001174C
	public override void Read(PacketReader r)
	{
		this._Nx46RcGIU0H1BCGWaJXjN1ieopt = r.ReadInt32();
		this._0v4mmgyFOmt9eSc23UclkqyBncC = r.ReadByte();
		this._605Ligxeaj9k9kBV8zQhhFhgTGl = r.ReadInt32();
	}

	// Token: 0x060002DA RID: 730 RVA: 0x00013580 File Offset: 0x00011780
	public override void Write(PacketWriter w)
	{
		w.Write(this._Nx46RcGIU0H1BCGWaJXjN1ieopt);
		w.Write(this._0v4mmgyFOmt9eSc23UclkqyBncC);
		w.Write(this._605Ligxeaj9k9kBV8zQhhFhgTGl);
	}

	// Token: 0x04000465 RID: 1125
	public int _Nx46RcGIU0H1BCGWaJXjN1ieopt;

	// Token: 0x04000466 RID: 1126
	public byte _0v4mmgyFOmt9eSc23UclkqyBncC;

	// Token: 0x04000467 RID: 1127
	public int _605Ligxeaj9k9kBV8zQhhFhgTGl;
}
