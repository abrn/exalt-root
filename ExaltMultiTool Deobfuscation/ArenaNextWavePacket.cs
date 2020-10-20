using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000072 RID: 114
internal class ArenaNextWavePacket : Packet
{
	// Token: 0x1700010B RID: 267
	// (get) Token: 0x0600039C RID: 924 RVA: 0x00014EA4 File Offset: 0x000130A4
	public override PacketType Type
	{
		get
		{
			return PacketType.IMMINENTARENAWAVE;
		}
	}

	// Token: 0x0600039D RID: 925 RVA: 0x00014EB4 File Offset: 0x000130B4
	public override void Read(PacketReader r)
	{
		this.TypeId = r.ReadInt32();
	}

	// Token: 0x0600039E RID: 926 RVA: 0x00014ED0 File Offset: 0x000130D0
	public override void Write(PacketWriter w)
	{
		w.Write(this.TypeId);
	}

	// Token: 0x040004DF RID: 1247
	public int TypeId;
}
