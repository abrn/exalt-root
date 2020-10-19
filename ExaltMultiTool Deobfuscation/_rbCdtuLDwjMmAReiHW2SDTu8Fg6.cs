using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x0200004A RID: 74
internal class _rbCdtuLDwjMmAReiHW2SDTu8Fg6 : Packet
{
	// Token: 0x170000E3 RID: 227
	// (get) Token: 0x060002FC RID: 764 RVA: 0x000139AC File Offset: 0x00011BAC
	public override PacketType Type
	{
		get
		{
			return PacketType.CLAIMLOGINREWARDMSG;
		}
	}

	// Token: 0x060002FD RID: 765 RVA: 0x000139BC File Offset: 0x00011BBC
	public override void Read(PacketReader r)
	{
		this._UkhTDUmE7xogsdaiziuIGSuOSje = r.ReadString();
		this._1W4la1neKBYBs439ZSEhiJnSgJT = r.ReadString();
	}

	// Token: 0x060002FE RID: 766 RVA: 0x000139E4 File Offset: 0x00011BE4
	public override void Write(PacketWriter w)
	{
		w.Write(this._UkhTDUmE7xogsdaiziuIGSuOSje);
		w.Write(this._1W4la1neKBYBs439ZSEhiJnSgJT);
	}

	// Token: 0x04000472 RID: 1138
	public string _UkhTDUmE7xogsdaiziuIGSuOSje;

	// Token: 0x04000473 RID: 1139
	public string _1W4la1neKBYBs439ZSEhiJnSgJT;
}
