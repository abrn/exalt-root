using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000085 RID: 133
internal class _LKXCtqN8hIH8qOlVlbcgUvWwe6w : Packet
{
	// Token: 0x1700011E RID: 286
	// (get) Token: 0x060003E8 RID: 1000 RVA: 0x00015BB0 File Offset: 0x00013DB0
	public override PacketType Type
	{
		get
		{
			return PacketType.NEWCHARACTERINFORMATION;
		}
	}

	// Token: 0x060003E9 RID: 1001 RVA: 0x00015BC0 File Offset: 0x00013DC0
	public override void Read(PacketReader r)
	{
		this._znyT9Fcsxg5Pk1Wu6NfeadzdfYr = r.ReadString();
	}

	// Token: 0x060003EA RID: 1002 RVA: 0x00015BDC File Offset: 0x00013DDC
	public override void Write(PacketWriter w)
	{
		w.Write(this._znyT9Fcsxg5Pk1Wu6NfeadzdfYr);
	}

	// Token: 0x04000527 RID: 1319
	public string _znyT9Fcsxg5Pk1Wu6NfeadzdfYr;
}
