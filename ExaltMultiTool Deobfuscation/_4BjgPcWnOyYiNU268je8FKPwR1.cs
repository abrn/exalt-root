using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000068 RID: 104
internal class _4BjgPcWnOyYiNU268je8FKPwR1 : Packet
{
	// Token: 0x17000101 RID: 257
	// (get) Token: 0x06000374 RID: 884 RVA: 0x00014948 File Offset: 0x00012B48
	public override PacketType Type
	{
		get
		{
			return PacketType.SETCONDITION;
		}
	}

	// Token: 0x06000375 RID: 885 RVA: 0x00014958 File Offset: 0x00012B58
	public override void Read(PacketReader r)
	{
		this._7ukuDCBZA2xXaNEsu2sBTbiJAOr = r.ReadByte();
		this._1bvKMoTHoblcZDmfK6Y9MpPQo7r = r.ReadSingle();
	}

	// Token: 0x06000376 RID: 886 RVA: 0x00014980 File Offset: 0x00012B80
	public override void Write(PacketWriter w)
	{
		w.Write(this._7ukuDCBZA2xXaNEsu2sBTbiJAOr);
		w.Write(this._1bvKMoTHoblcZDmfK6Y9MpPQo7r);
	}

	// Token: 0x040004C5 RID: 1221
	public byte _7ukuDCBZA2xXaNEsu2sBTbiJAOr;

	// Token: 0x040004C6 RID: 1222
	public float _1bvKMoTHoblcZDmfK6Y9MpPQo7r;
}
