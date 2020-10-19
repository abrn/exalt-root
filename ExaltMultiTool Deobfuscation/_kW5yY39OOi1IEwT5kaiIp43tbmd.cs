using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x020000A0 RID: 160
internal class _kW5yY39OOi1IEwT5kaiIp43tbmd : Packet
{
	// Token: 0x17000138 RID: 312
	// (get) Token: 0x06000458 RID: 1112 RVA: 0x00017240 File Offset: 0x00015440
	public override PacketType Type
	{
		get
		{
			return PacketType.ACTIVEPETUPDATE;
		}
	}

	// Token: 0x06000459 RID: 1113 RVA: 0x00017250 File Offset: 0x00015450
	public override void Read(PacketReader r)
	{
		this._gMQB8nUc90NEebz9oVexr6Ppdmb = r.ReadInt32();
	}

	// Token: 0x0600045A RID: 1114 RVA: 0x0001726C File Offset: 0x0001546C
	public override void Write(PacketWriter w)
	{
		w.Write(this._gMQB8nUc90NEebz9oVexr6Ppdmb);
	}

	// Token: 0x04000589 RID: 1417
	public int _gMQB8nUc90NEebz9oVexr6Ppdmb;
}
