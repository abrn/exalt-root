using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x0200007F RID: 127
internal class _tJHGMoVf7DhHyQm8a6SCuL1cSWl : Packet
{
	// Token: 0x17000118 RID: 280
	// (get) Token: 0x060003D0 RID: 976 RVA: 0x0001570C File Offset: 0x0001390C
	public override PacketType Type
	{
		get
		{
			return PacketType.INVITEDTOGUILD;
		}
	}

	// Token: 0x060003D1 RID: 977 RVA: 0x0001571C File Offset: 0x0001391C
	public override void Read(PacketReader r)
	{
		this._Jp3DtIV4aAYZY26sVsXpPQjBRGO = r.ReadString();
		this._nnw4mIJ2qnTBfbumuZegfJw1qcX = r.ReadString();
	}

	// Token: 0x060003D2 RID: 978 RVA: 0x00015744 File Offset: 0x00013944
	public override void Write(PacketWriter w)
	{
		w.Write(this._Jp3DtIV4aAYZY26sVsXpPQjBRGO);
		w.Write(this._nnw4mIJ2qnTBfbumuZegfJw1qcX);
	}

	// Token: 0x0400050E RID: 1294
	public string _Jp3DtIV4aAYZY26sVsXpPQjBRGO;

	// Token: 0x0400050F RID: 1295
	public string _nnw4mIJ2qnTBfbumuZegfJw1qcX;
}
