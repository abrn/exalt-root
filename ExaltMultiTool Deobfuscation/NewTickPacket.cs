using System;
using System.Collections.Generic;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000086 RID: 134
internal class NewTickPacket : Packet
{
	// Token: 0x1700011F RID: 287
	// (get) Token: 0x060003EC RID: 1004 RVA: 0x00015C0C File Offset: 0x00013E0C
	public override PacketType Type
	{
		get
		{
			return PacketType.NEWTICK;
		}
	}

	// Token: 0x060003ED RID: 1005 RVA: 0x00015C1C File Offset: 0x00013E1C
	public override void Read(PacketReader r)
	{
		this.TickId = r.ReadInt32();
		this.TickTime = r.ReadInt32();
		this.ServerRealTimeMs = r.ReadUInt32();
		this.ServerLastRTTMS = r.ReadUInt16();
		int num = (int)r.ReadInt16();
		this.Statuses = new List<Status>();
		for (int i = 0; i < num; i++)
		{
			this.Statuses.Add((Status)new Status().Read(r));
		}
	}

	// Token: 0x060003EE RID: 1006 RVA: 0x00015C94 File Offset: 0x00013E94
	public override void Write(PacketWriter w)
	{
		w.Write(this.TickId);
		w.Write(this.TickTime);
		w.Write(this.ServerRealTimeMs);
		w.Write(this.ServerLastRTTMS);
		w.Write((short)this.Statuses.Count);
		foreach (Status status in Statuses)
		{
			status.Write(w);
		}
	}

	// Token: 0x04000528 RID: 1320
	public int TickId;

	// Token: 0x04000529 RID: 1321
	public int TickTime;

	// Token: 0x0400052A RID: 1322
	public uint ServerRealTimeMs;

	// Token: 0x0400052B RID: 1323
	public ushort ServerLastRTTMS;

	// Token: 0x0400052C RID: 1324
	public List<Status> Statuses;
}
