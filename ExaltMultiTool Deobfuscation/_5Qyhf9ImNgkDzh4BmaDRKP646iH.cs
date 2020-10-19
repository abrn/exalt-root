using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000076 RID: 118
internal class _5Qyhf9ImNgkDzh4BmaDRKP646iH : Packet
{
	// Token: 0x1700010F RID: 271
	// (get) Token: 0x060003AC RID: 940 RVA: 0x0001505C File Offset: 0x0001325C
	public override PacketType Type
	{
		get
		{
			return PacketType.CREATESUCCESS;
		}
	}

	// Token: 0x060003AD RID: 941 RVA: 0x0001506C File Offset: 0x0001326C
	public override void Read(PacketReader r)
	{
		this.ObjectId = r.ReadInt32();
		this._TwMfbUoOVU2fkWnDRSrq8xiGB6f = r.ReadInt32();
	}

	// Token: 0x060003AE RID: 942 RVA: 0x00015094 File Offset: 0x00013294
	public override void Write(PacketWriter w)
	{
		w.Write(this.ObjectId);
		w.Write(this._TwMfbUoOVU2fkWnDRSrq8xiGB6f);
	}

	// Token: 0x040004E6 RID: 1254
	public int ObjectId;

	// Token: 0x040004E7 RID: 1255
	public int _TwMfbUoOVU2fkWnDRSrq8xiGB6f;
}
