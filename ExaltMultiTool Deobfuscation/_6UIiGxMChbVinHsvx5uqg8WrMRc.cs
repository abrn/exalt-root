using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000080 RID: 128
internal class InvResultPacket : Packet
{
	// Token: 0x17000119 RID: 281
	// (get) Token: 0x060003D4 RID: 980 RVA: 0x00015780 File Offset: 0x00013980
	public override PacketType Type
	{
		get
		{
			return PacketType.INVRESULT;
		}
	}

	// Token: 0x060003D5 RID: 981 RVA: 0x00015790 File Offset: 0x00013990
	public override void Read(PacketReader r)
	{
		this._9WVS8mgAGMXsp1FYvKoly56WY1E = r.ReadBoolean();
		this._ecyyaYf6RV1NPdHtzXFXLG5mpFA = new SlotObject(r);
		this._R1rVnNom2O6z6ToODjdI248Gp3O = new SlotObject(r);
	}

	// Token: 0x060003D6 RID: 982 RVA: 0x000157C4 File Offset: 0x000139C4
	public override void Write(PacketWriter w)
	{
		w.Write(this._9WVS8mgAGMXsp1FYvKoly56WY1E);
		this._ecyyaYf6RV1NPdHtzXFXLG5mpFA.Write(w);
		this._R1rVnNom2O6z6ToODjdI248Gp3O.Write(w);
	}

	// Token: 0x04000510 RID: 1296
	public bool _9WVS8mgAGMXsp1FYvKoly56WY1E;

	// Token: 0x04000511 RID: 1297
	public SlotObject _ecyyaYf6RV1NPdHtzXFXLG5mpFA;

	// Token: 0x04000512 RID: 1298
	public SlotObject _R1rVnNom2O6z6ToODjdI248Gp3O;
}
