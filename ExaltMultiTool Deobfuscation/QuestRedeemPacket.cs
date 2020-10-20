using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000040 RID: 64
internal class QuestRedeemPacket : Packet
{
	// Token: 0x170000D9 RID: 217
	// (get) Token: 0x060002D4 RID: 724 RVA: 0x00013470 File Offset: 0x00011670
	public override PacketType Type
	{
		get
		{
			return PacketType.QUESTREDEEM;
		}
	}

	// Token: 0x060002D5 RID: 725 RVA: 0x00013480 File Offset: 0x00011680
	public override void Read(PacketReader r)
	{
		this.QuestId = r.ReadString();
		this.Item = r.ReadInt32();
		int num = (int)r.ReadInt16();
		this.Slots = new SlotObject[num];
		for (int i = 0; i < num; i++)
		{
			this.Slots[i] = new SlotObject(r);
		}
	}

	// Token: 0x060002D6 RID: 726 RVA: 0x000134D4 File Offset: 0x000116D4
	public override void Write(PacketWriter w)
	{
		w.Write(this.QuestId);
		w.Write(this.Item);
		w.Write((short)this.Slots.Length);
		SlotObject[] slots = Slots;
		for (int i = 0; i < ifsdg3fz4hmZaJ5f4muhQ8w5t4s.Length; i++)
		{
			ifsdg3fz4hmZaJ5f4muhQ8w5t4s[i].Write(w);
		}
	}

	// Token: 0x04000462 RID: 1122
	public string QuestId;

	// Token: 0x04000463 RID: 1123
	public SlotObject[] Slots;

	// Token: 0x04000464 RID: 1124
	public int Item;
}
