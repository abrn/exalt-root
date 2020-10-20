using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x0200004A RID: 74
internal class ClaimLoginRewardPacket : Packet
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
		this.ClaimKey = r.ReadString();
		this.ClaimType = r.ReadString();
	}

	// Token: 0x060002FE RID: 766 RVA: 0x000139E4 File Offset: 0x00011BE4
	public override void Write(PacketWriter w)
	{
		w.Write(this.ClaimKey);
		w.Write(this.ClaimType);
	}

	// Token: 0x04000472 RID: 1138
	public string ClaimKey;

	// Token: 0x04000473 RID: 1139
	public string ClaimType;
}
