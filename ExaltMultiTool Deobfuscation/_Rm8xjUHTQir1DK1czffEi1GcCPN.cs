using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000081 RID: 129
internal class _Rm8xjUHTQir1DK1czffEi1GcCPN : Packet
{
	// Token: 0x1700011A RID: 282
	// (get) Token: 0x060003D8 RID: 984 RVA: 0x0001580C File Offset: 0x00013A0C
	public override PacketType Type
	{
		get
		{
			return PacketType.KEYINFORESPONSE;
		}
	}

	// Token: 0x060003D9 RID: 985 RVA: 0x0001581C File Offset: 0x00013A1C
	public override void Read(PacketReader r)
	{
		this._utdbxIA4aeCAiqz5jjzV5XopSjM = r.ReadBytes((int)r.BaseStream.Length - 5);
	}

	// Token: 0x060003DA RID: 986 RVA: 0x00015844 File Offset: 0x00013A44
	public override void Write(PacketWriter w)
	{
		w.Write(this._utdbxIA4aeCAiqz5jjzV5XopSjM);
	}

	// Token: 0x04000513 RID: 1299
	public byte[] _utdbxIA4aeCAiqz5jjzV5XopSjM;
}
