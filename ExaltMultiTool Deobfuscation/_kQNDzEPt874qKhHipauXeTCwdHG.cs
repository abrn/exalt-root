using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000062 RID: 98
internal class PlayerTextPacket : Packet
{
	// Token: 0x170000FB RID: 251
	// (get) Token: 0x0600035C RID: 860 RVA: 0x000146F0 File Offset: 0x000128F0
	public override PacketType Type
	{
		get
		{
			return PacketType.PLAYERTEXT;
		}
	}

	// Token: 0x0600035D RID: 861 RVA: 0x00014700 File Offset: 0x00012900
	public override void Read(PacketReader r)
	{
		this.Text = r.ReadString();
	}

	// Token: 0x0600035E RID: 862 RVA: 0x0001471C File Offset: 0x0001291C
	public override void Write(PacketWriter w)
	{
		w.Write(this.Text);
	}

	// Token: 0x040004BD RID: 1213
	public string Text;
}
