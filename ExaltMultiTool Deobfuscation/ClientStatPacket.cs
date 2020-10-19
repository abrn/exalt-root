using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000074 RID: 116
internal class ClientStatPacket : Packet
{
	// Token: 0x1700010D RID: 269
	// (get) Token: 0x060003A4 RID: 932 RVA: 0x00014F74 File Offset: 0x00013174
	public override PacketType Type
	{
		get
		{
			return PacketType.CLIENTSTAT;
		}
	}

	// Token: 0x060003A5 RID: 933 RVA: 0x00014F84 File Offset: 0x00013184
	public override void Read(PacketReader r)
	{
		this.Name = r.ReadString();
		this.Value = r.ReadInt32();
	}

	// Token: 0x060003A6 RID: 934 RVA: 0x00014FAC File Offset: 0x000131AC
	public override void Write(PacketWriter w)
	{
		w.Write(this.Name);
		w.Write(this.Value);
	}

	// Token: 0x040004E2 RID: 1250
	public string Name;

	// Token: 0x040004E3 RID: 1251
	public int Value;
}
