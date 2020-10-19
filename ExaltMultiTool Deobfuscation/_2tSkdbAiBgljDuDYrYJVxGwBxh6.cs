using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000065 RID: 101
internal class _2tSkdbAiBgljDuDYrYJVxGwBxh6 : Packet
{
	// Token: 0x170000FE RID: 254
	// (get) Token: 0x06000368 RID: 872 RVA: 0x0001481C File Offset: 0x00012A1C
	public override PacketType Type
	{
		get
		{
			return PacketType.RESETDAILYQUESTS;
		}
	}

	// Token: 0x06000369 RID: 873 RVA: 0x0001482C File Offset: 0x00012A2C
	public override void Read(PacketReader r)
	{
	}

	// Token: 0x0600036A RID: 874 RVA: 0x0001483C File Offset: 0x00012A3C
	public override void Write(PacketWriter w)
	{
	}
}
