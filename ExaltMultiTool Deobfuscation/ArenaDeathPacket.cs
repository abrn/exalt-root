using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x0200005B RID: 91
internal class ArenaDeathPacket : Packet
{
	// Token: 0x170000F4 RID: 244
	// (get) Token: 0x06000340 RID: 832 RVA: 0x00014278 File Offset: 0x00012478
	public override PacketType Type
	{
		get
		{
			return PacketType.ACCEPTARENADEATH;
		}
	}

	// Token: 0x06000341 RID: 833 RVA: 0x00014288 File Offset: 0x00012488
	public override void Read(PacketReader r)
	{
		this.RestartPrice = r.ReadInt32();
	}

	// Token: 0x06000342 RID: 834 RVA: 0x000142A4 File Offset: 0x000124A4
	public override void Write(PacketWriter w)
	{
		w.Write(this.RestartPrice);
	}

	// Token: 0x0400049E RID: 1182
	public int RestartPrice;
}
