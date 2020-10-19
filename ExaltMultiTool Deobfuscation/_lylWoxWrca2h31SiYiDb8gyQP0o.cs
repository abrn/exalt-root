using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x0200006C RID: 108
internal class UseItemPacket : Packet
{
	// Token: 0x17000105 RID: 261
	// (get) Token: 0x06000384 RID: 900 RVA: 0x00014AB8 File Offset: 0x00012CB8
	public override PacketType Type
	{
		get
		{
			return PacketType.USEITEM;
		}
	}

	// Token: 0x06000385 RID: 901 RVA: 0x00014AC8 File Offset: 0x00012CC8
	public override void Read(PacketReader r)
	{
		this._Nx46RcGIU0H1BCGWaJXjN1ieopt = r.ReadInt32();
		this.SlotObject = new _A3HGGdSvVENqKj3O1HGYDO3Qh8C(r);
		this._fbMEQqPOnQITCQFqK3LVLkEtWye = new Location(r);
		this._zDKahCudqipTR5FObLj9ijwgWo8 = r.ReadByte();
	}

	// Token: 0x06000386 RID: 902 RVA: 0x00014B08 File Offset: 0x00012D08
	public override void Write(PacketWriter w)
	{
		w.Write(this._Nx46RcGIU0H1BCGWaJXjN1ieopt);
		this.SlotObject.Write(w);
		this._fbMEQqPOnQITCQFqK3LVLkEtWye.Write(w);
		w.Write(this._zDKahCudqipTR5FObLj9ijwgWo8);
	}

	// Token: 0x040004C9 RID: 1225
	public int _Nx46RcGIU0H1BCGWaJXjN1ieopt;

	// Token: 0x040004CA RID: 1226
	public _A3HGGdSvVENqKj3O1HGYDO3Qh8C SlotObject;

	// Token: 0x040004CB RID: 1227
	public Location _fbMEQqPOnQITCQFqK3LVLkEtWye;

	// Token: 0x040004CC RID: 1228
	public byte _zDKahCudqipTR5FObLj9ijwgWo8;
}
