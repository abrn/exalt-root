using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000093 RID: 147
internal class _ie7JTKAWyRmgDm1bLTkfqKGNcNO : Packet
{
	// Token: 0x1700012C RID: 300
	// (get) Token: 0x06000422 RID: 1058 RVA: 0x00016404 File Offset: 0x00014604
	public override PacketType Type
	{
		get
		{
			return PacketType.DELETEPET;
		}
	}

	// Token: 0x06000423 RID: 1059 RVA: 0x00016414 File Offset: 0x00014614
	public override void Read(PacketReader r)
	{
		this._gMQB8nUc90NEebz9oVexr6Ppdmb = r.ReadInt32();
	}

	// Token: 0x06000424 RID: 1060 RVA: 0x00016430 File Offset: 0x00014630
	public override void Write(PacketWriter w)
	{
		w.Write(this._gMQB8nUc90NEebz9oVexr6Ppdmb);
	}

	// Token: 0x0400054C RID: 1356
	public int _gMQB8nUc90NEebz9oVexr6Ppdmb;
}
