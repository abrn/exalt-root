using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x0200003E RID: 62
internal class _1BWZdtXNcbT5jJNvaXgjhVvbn0r : Packet
{
	// Token: 0x170000D7 RID: 215
	// (get) Token: 0x060002CC RID: 716 RVA: 0x00013388 File Offset: 0x00011588
	public override PacketType Type
	{
		get
		{
			return PacketType.OTHERHIT;
		}
	}

	// Token: 0x060002CD RID: 717 RVA: 0x00013398 File Offset: 0x00011598
	public override void Read(PacketReader r)
	{
		this._Nx46RcGIU0H1BCGWaJXjN1ieopt = r.ReadInt32();
		this._0v4mmgyFOmt9eSc23UclkqyBncC = r.ReadByte();
		this._605Ligxeaj9k9kBV8zQhhFhgTGl = r.ReadInt32();
		this._GNsbx2sQjKyCD4qK29hWl8cxeSqA = r.ReadInt32();
	}

	// Token: 0x060002CE RID: 718 RVA: 0x000133D8 File Offset: 0x000115D8
	public override void Write(PacketWriter w)
	{
		w.Write(this._Nx46RcGIU0H1BCGWaJXjN1ieopt);
		w.Write(this._0v4mmgyFOmt9eSc23UclkqyBncC);
		w.Write(this._605Ligxeaj9k9kBV8zQhhFhgTGl);
		w.Write(this._GNsbx2sQjKyCD4qK29hWl8cxeSqA);
	}

	// Token: 0x0400045E RID: 1118
	public int _Nx46RcGIU0H1BCGWaJXjN1ieopt;

	// Token: 0x0400045F RID: 1119
	public byte _0v4mmgyFOmt9eSc23UclkqyBncC;

	// Token: 0x04000460 RID: 1120
	public int _605Ligxeaj9k9kBV8zQhhFhgTGl;

	// Token: 0x04000461 RID: 1121
	public int _GNsbx2sQjKyCD4qK29hWl8cxeSqA;
}
