using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x0200009E RID: 158
internal class _42MDFAqFgN3kq2mDoOoSv80eEmr : Packet
{
	// Token: 0x17000136 RID: 310
	// (get) Token: 0x06000450 RID: 1104 RVA: 0x00017070 File Offset: 0x00015270
	public override PacketType Type
	{
		get
		{
			return PacketType.UNLOCKINFORMATION;
		}
	}

	// Token: 0x06000451 RID: 1105 RVA: 0x00017080 File Offset: 0x00015280
	public override void Read(PacketReader r)
	{
		this._DHydYFnqMaxh1ohNxPOHqbxoOcA = r.ReadInt32();
	}

	// Token: 0x06000452 RID: 1106 RVA: 0x0001709C File Offset: 0x0001529C
	public override void Write(PacketWriter w)
	{
		w.Write(this._DHydYFnqMaxh1ohNxPOHqbxoOcA);
	}

	// Token: 0x04000585 RID: 1413
	public int _DHydYFnqMaxh1ohNxPOHqbxoOcA;
}
