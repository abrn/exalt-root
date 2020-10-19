using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000067 RID: 103
internal class _dTB7tEoatdtq5iT8bsKKFbL4EvR : Packet
{
	// Token: 0x17000100 RID: 256
	// (get) Token: 0x06000370 RID: 880 RVA: 0x000148BC File Offset: 0x00012ABC
	public override PacketType Type
	{
		get
		{
			return PacketType.PETCHANGEFORMMSG;
		}
	}

	// Token: 0x06000371 RID: 881 RVA: 0x000148CC File Offset: 0x00012ACC
	public override void Read(PacketReader r)
	{
		this._gMQB8nUc90NEebz9oVexr6Ppdmb = r.ReadInt32();
		this._X6bQjlFCFiWchC4u3ofuLZDJetu = r.ReadInt32();
		this._jG3RdlWG8QOSbqMejdbEmnotPXB = new _A3HGGdSvVENqKj3O1HGYDO3Qh8C(r);
	}

	// Token: 0x06000372 RID: 882 RVA: 0x00014900 File Offset: 0x00012B00
	public override void Write(PacketWriter w)
	{
		w.Write(this._gMQB8nUc90NEebz9oVexr6Ppdmb);
		w.Write(this._X6bQjlFCFiWchC4u3ofuLZDJetu);
		this._jG3RdlWG8QOSbqMejdbEmnotPXB.Write(w);
	}

	// Token: 0x040004C2 RID: 1218
	public int _gMQB8nUc90NEebz9oVexr6Ppdmb;

	// Token: 0x040004C3 RID: 1219
	public int _X6bQjlFCFiWchC4u3ofuLZDJetu;

	// Token: 0x040004C4 RID: 1220
	public _A3HGGdSvVENqKj3O1HGYDO3Qh8C _jG3RdlWG8QOSbqMejdbEmnotPXB;
}
