using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000058 RID: 88
internal class _maJp2qic3r54gk5Eg1eeMowxvXh : Packet
{
	// Token: 0x170000F1 RID: 241
	// (get) Token: 0x06000334 RID: 820 RVA: 0x00014110 File Offset: 0x00012310
	public override PacketType Type
	{
		get
		{
			return PacketType.INVSWAP;
		}
	}

	// Token: 0x06000335 RID: 821 RVA: 0x00014120 File Offset: 0x00012320
	public override void Read(PacketReader r)
	{
		this._Nx46RcGIU0H1BCGWaJXjN1ieopt = r.ReadInt32();
		this._MkT06oCYgDubgW2NbEOzvLh8RLe = new Location(r);
		this._ecyyaYf6RV1NPdHtzXFXLG5mpFA = new _A3HGGdSvVENqKj3O1HGYDO3Qh8C(r);
		this._R1rVnNom2O6z6ToODjdI248Gp3O = new _A3HGGdSvVENqKj3O1HGYDO3Qh8C(r);
	}

	// Token: 0x06000336 RID: 822 RVA: 0x00014160 File Offset: 0x00012360
	public override void Write(PacketWriter w)
	{
		w.Write(this._Nx46RcGIU0H1BCGWaJXjN1ieopt);
		this._MkT06oCYgDubgW2NbEOzvLh8RLe.Write(w);
		this._ecyyaYf6RV1NPdHtzXFXLG5mpFA.Write(w);
		this._R1rVnNom2O6z6ToODjdI248Gp3O.Write(w);
	}

	// Token: 0x04000498 RID: 1176
	public int _Nx46RcGIU0H1BCGWaJXjN1ieopt;

	// Token: 0x04000499 RID: 1177
	public Location _MkT06oCYgDubgW2NbEOzvLh8RLe;

	// Token: 0x0400049A RID: 1178
	public _A3HGGdSvVENqKj3O1HGYDO3Qh8C _ecyyaYf6RV1NPdHtzXFXLG5mpFA;

	// Token: 0x0400049B RID: 1179
	public _A3HGGdSvVENqKj3O1HGYDO3Qh8C _R1rVnNom2O6z6ToODjdI248Gp3O;
}
