using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000054 RID: 84
internal class GuildInvitePacket : Packet
{
	// Token: 0x170000ED RID: 237
	// (get) Token: 0x06000324 RID: 804 RVA: 0x00013DEC File Offset: 0x00011FEC
	public override PacketType Type
	{
		get
		{
			return PacketType.GUILDINVITE;
		}
	}

	// Token: 0x06000325 RID: 805 RVA: 0x00013DFC File Offset: 0x00011FFC
	public override void Read(PacketReader r)
	{
		this.Name = r.ReadString();
	}

	// Token: 0x06000326 RID: 806 RVA: 0x00013E18 File Offset: 0x00012018
	public override void Write(PacketWriter w)
	{
		w.Write(this.Name);
	}

	// Token: 0x04000483 RID: 1155
	public string Name;
}
