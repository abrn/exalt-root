using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000055 RID: 85
internal class GuildRemovePacket : Packet
{
	// Token: 0x170000EE RID: 238
	// (get) Token: 0x06000328 RID: 808 RVA: 0x00013E48 File Offset: 0x00012048
	public override PacketType Type
	{
		get
		{
			return PacketType.GUILDREMOVE;
		}
	}

	// Token: 0x06000329 RID: 809 RVA: 0x00013E58 File Offset: 0x00012058
	public override void Read(PacketReader r)
	{
		this.Name = r.ReadString();
	}

	// Token: 0x0600032A RID: 810 RVA: 0x00013E74 File Offset: 0x00012074
	public override void Write(PacketWriter w)
	{
		w.Write(this.Name);
	}

	// Token: 0x04000484 RID: 1156
	public string Name;
}
