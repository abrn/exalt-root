using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x0200004B RID: 75
internal class CreateGuildPacket : Packet
{
	// Token: 0x170000E4 RID: 228
	// (get) Token: 0x06000300 RID: 768 RVA: 0x00013A20 File Offset: 0x00011C20
	public override PacketType Type
	{
		get
		{
			return PacketType.CREATEGUILD;
		}
	}

	// Token: 0x06000301 RID: 769 RVA: 0x00013A30 File Offset: 0x00011C30
	public override void Read(PacketReader r)
	{
		this.Name = r.ReadString();
	}

	// Token: 0x06000302 RID: 770 RVA: 0x00013A4C File Offset: 0x00011C4C
	public override void Write(PacketWriter w)
	{
		w.Write(this.Name);
	}

	// Token: 0x04000474 RID: 1140
	public string Name;
}
