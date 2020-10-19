using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000057 RID: 87
internal class _fF056LUPJ2QRGuNEDdwfat8Nfg0 : Packet
{
	// Token: 0x170000F0 RID: 240
	// (get) Token: 0x06000330 RID: 816 RVA: 0x000140B4 File Offset: 0x000122B4
	public override PacketType Type
	{
		get
		{
			return PacketType.INVDROP;
		}
	}

	// Token: 0x06000331 RID: 817 RVA: 0x000140C4 File Offset: 0x000122C4
	public override void Read(PacketReader r)
	{
		this._LgxK5GR2YdT31chQJOKuf3C3zSA = new _A3HGGdSvVENqKj3O1HGYDO3Qh8C(r);
	}

	// Token: 0x06000332 RID: 818 RVA: 0x000140E0 File Offset: 0x000122E0
	public override void Write(PacketWriter w)
	{
		this._LgxK5GR2YdT31chQJOKuf3C3zSA.Write(w);
	}

	// Token: 0x04000497 RID: 1175
	public _A3HGGdSvVENqKj3O1HGYDO3Qh8C _LgxK5GR2YdT31chQJOKuf3C3zSA;
}
