using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000066 RID: 102
internal class _5V9yWe0NZ1FUZAVqEFttU08qdUi : Packet
{
	// Token: 0x170000FF RID: 255
	// (get) Token: 0x0600036C RID: 876 RVA: 0x00014860 File Offset: 0x00012A60
	public override PacketType Type
	{
		get
		{
			return PacketType.RESKIN;
		}
	}

	// Token: 0x0600036D RID: 877 RVA: 0x00014870 File Offset: 0x00012A70
	public override void Read(PacketReader r)
	{
		this._Beq6qiCbInqKACICa00lAyBBTsM = r.ReadInt32();
	}

	// Token: 0x0600036E RID: 878 RVA: 0x0001488C File Offset: 0x00012A8C
	public override void Write(PacketWriter w)
	{
		w.Write(this._Beq6qiCbInqKACICa00lAyBBTsM);
	}

	// Token: 0x040004C1 RID: 1217
	public int _Beq6qiCbInqKACICa00lAyBBTsM;
}
