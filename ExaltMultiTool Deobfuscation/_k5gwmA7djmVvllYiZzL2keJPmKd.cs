using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x0200004C RID: 76
internal class _k5gwmA7djmVvllYiZzL2keJPmKd : Packet
{
	// Token: 0x170000E5 RID: 229
	// (get) Token: 0x06000304 RID: 772 RVA: 0x00013A7C File Offset: 0x00011C7C
	public override PacketType Type
	{
		get
		{
			return PacketType.CREATE;
		}
	}

	// Token: 0x06000305 RID: 773 RVA: 0x00013A8C File Offset: 0x00011C8C
	public override void Read(PacketReader r)
	{
		this._ewSyr7TbjGBUYwKoKIIQHtXTgZp = r.ReadInt16();
		this._lzeJbLqKTrOjSpCh6A6kpUftgap = r.ReadInt16();
		this._aapegx4D6nAePdcldcfu6WqpLFg = r.ReadBoolean();
	}

	// Token: 0x06000306 RID: 774 RVA: 0x00013AC0 File Offset: 0x00011CC0
	public override void Write(PacketWriter w)
	{
		w.Write(this._ewSyr7TbjGBUYwKoKIIQHtXTgZp);
		w.Write(this._lzeJbLqKTrOjSpCh6A6kpUftgap);
		w.Write(this._aapegx4D6nAePdcldcfu6WqpLFg);
	}

	// Token: 0x04000475 RID: 1141
	public short _ewSyr7TbjGBUYwKoKIIQHtXTgZp;

	// Token: 0x04000476 RID: 1142
	public short _lzeJbLqKTrOjSpCh6A6kpUftgap;

	// Token: 0x04000477 RID: 1143
	public bool _aapegx4D6nAePdcldcfu6WqpLFg;
}
