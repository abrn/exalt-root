using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000091 RID: 145
internal class RealmHeroLeftMsgPacket : Packet
{
	// Token: 0x1700012A RID: 298
	// (get) Token: 0x0600041A RID: 1050 RVA: 0x00016294 File Offset: 0x00014494
	public override PacketType Type
	{
		get
		{
			return PacketType.REALMHEROLEFTMSG;
		}
	}

	// Token: 0x0600041B RID: 1051 RVA: 0x000162A4 File Offset: 0x000144A4
	public override void Read(PacketReader r)
	{
		this.Heros = r.ReadInt32();
	}

	// Token: 0x0600041C RID: 1052 RVA: 0x000162C0 File Offset: 0x000144C0
	public override void Write(PacketWriter w)
	{
		w.Write(this.Heros);
	}

	// Token: 0x04000543 RID: 1347
	private int Heros;
}
