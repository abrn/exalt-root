using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x0200008B RID: 139
internal class PingPacket : Packet
{
	// Token: 0x17000124 RID: 292
	// (get) Token: 0x06000402 RID: 1026 RVA: 0x00015F70 File Offset: 0x00014170
	public override PacketType Type
	{
		get
		{
			return PacketType.PING;
		}
	}

	// Token: 0x06000403 RID: 1027 RVA: 0x00015F80 File Offset: 0x00014180
	public override void Read(PacketReader r)
	{
		this.Serial = r.ReadInt32();
	}

	// Token: 0x06000404 RID: 1028 RVA: 0x00015F9C File Offset: 0x0001419C
	public override void Write(PacketWriter w)
	{
		w.Write(this.Serial);
	}

	// Token: 0x04000538 RID: 1336
	public int Serial;
}
