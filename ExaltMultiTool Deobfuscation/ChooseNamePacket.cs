using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000049 RID: 73
internal class ChooseNamePacket : Packet
{
	// Token: 0x170000E2 RID: 226
	// (get) Token: 0x060002F8 RID: 760 RVA: 0x00013950 File Offset: 0x00011B50
	public override PacketType Type
	{
		get
		{
			return PacketType.CHOOSENAME;
		}
	}

	// Token: 0x060002F9 RID: 761 RVA: 0x00013960 File Offset: 0x00011B60
	public override void Read(PacketReader r)
	{
		this.Name = r.ReadString();
	}

	// Token: 0x060002FA RID: 762 RVA: 0x0001397C File Offset: 0x00011B7C
	public override void Write(PacketWriter w)
	{
		w.Write(this.Name);
	}

	// Token: 0x04000471 RID: 1137
	public string Name;
}
