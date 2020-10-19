using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000075 RID: 117
internal class CreateGuildResultPacket : Packet
{
	// Token: 0x1700010E RID: 270
	// (get) Token: 0x060003A8 RID: 936 RVA: 0x00014FE8 File Offset: 0x000131E8
	public override PacketType Type
	{
		get
		{
			return PacketType.GUILDRESULT;
		}
	}

	// Token: 0x060003A9 RID: 937 RVA: 0x00014FF8 File Offset: 0x000131F8
	public override void Read(PacketReader r)
	{
		this.Success = r.ReadBoolean();
		this.ErrorText = r.ReadString();
	}

	// Token: 0x060003AA RID: 938 RVA: 0x00015020 File Offset: 0x00013220
	public override void Write(PacketWriter w)
	{
		w.Write(this.Success);
		w.Write(this.ErrorText);
	}

	// Token: 0x040004E4 RID: 1252
	public bool Success;

	// Token: 0x040004E5 RID: 1253
	public string ErrorText;
}
