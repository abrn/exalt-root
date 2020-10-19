using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x0200007D RID: 125
internal class _6bFcDAcspnOQmt4APGeJjRcd3kA : Packet
{
	// Token: 0x17000116 RID: 278
	// (get) Token: 0x060003C8 RID: 968 RVA: 0x00015624 File Offset: 0x00013824
	public override PacketType Type
	{
		get
		{
			return PacketType.GOTO;
		}
	}

	// Token: 0x060003C9 RID: 969 RVA: 0x00015634 File Offset: 0x00013834
	public override void Read(PacketReader r)
	{
		this._605Ligxeaj9k9kBV8zQhhFhgTGl = r.ReadInt32();
		this._v9pyCwpTOdm9mtxft8q4OoLOE3B = new Location(r);
	}

	// Token: 0x060003CA RID: 970 RVA: 0x0001565C File Offset: 0x0001385C
	public override void Write(PacketWriter w)
	{
		w.Write(this._605Ligxeaj9k9kBV8zQhhFhgTGl);
		this._v9pyCwpTOdm9mtxft8q4OoLOE3B.Write(w);
	}

	// Token: 0x0400050A RID: 1290
	public int _605Ligxeaj9k9kBV8zQhhFhgTGl;

	// Token: 0x0400050B RID: 1291
	public Location _v9pyCwpTOdm9mtxft8q4OoLOE3B;
}
