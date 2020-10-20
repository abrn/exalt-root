using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x0200008D RID: 141
internal class QuestFetchResponsePacket : Packet
{
	// Token: 0x17000126 RID: 294
	// (get) Token: 0x0600040A RID: 1034 RVA: 0x00016040 File Offset: 0x00014240
	public override PacketType Type
	{
		get
		{
			return PacketType.QUESTFETCHRESPONSE;
		}
	}

	// Token: 0x0600040B RID: 1035 RVA: 0x00016050 File Offset: 0x00014250
	public override void Read(PacketReader r)
	{
		this.Quests = new QuestData[(int)r.ReadInt16()];
		for (int i = 0; i < this.Quests.Length; i++)
		{
			this.Quests[i] = new QuestData(r);
		}
		this.NextRefreshPrice = r.ReadInt16();
	}

	// Token: 0x0600040C RID: 1036 RVA: 0x0001609C File Offset: 0x0001429C
	public override void Write(PacketWriter w)
	{
		w.Write((short)this.Quests.Length);
		QuestData[] quests = Quests;
		for (int i = 0; i < quests.Length; i++)
		{
			quests[i].Write(w);
		}
		w.Write(this.NextRefreshPrice);
	}

	// Token: 0x0400053B RID: 1339
	public QuestData[] Quests;

	// Token: 0x0400053C RID: 1340
	public short NextRefreshPrice;
}
