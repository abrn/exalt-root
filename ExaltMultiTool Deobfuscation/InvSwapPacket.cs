using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000058 RID: 88
internal class InvSwapPacket : Packet
{
	// Token: 0x170000F1 RID: 241
	// (get) Token: 0x06000334 RID: 820 RVA: 0x00014110 File Offset: 0x00012310
	public override PacketType Type
	{
		get
		{
			return PacketType.INVSWAP;
		}
	}

	// Token: 0x06000335 RID: 821 RVA: 0x00014120 File Offset: 0x00012320
	public override void Read(PacketReader r)
	{
		this.Time = r.ReadInt32();
		this.Position = new Location(r);
		this.SlotObject1 = new SlotObject(r);
		this.SlotObject2 = new SlotObject(r);
	}

	// Token: 0x06000336 RID: 822 RVA: 0x00014160 File Offset: 0x00012360
	public override void Write(PacketWriter w)
	{
		w.Write(this.Time);
		this.Position.Write(w);
		this.SlotObject1.Write(w);
		this.SlotObject2.Write(w);
	}

	// Token: 0x04000498 RID: 1176
	public int Time;

	// Token: 0x04000499 RID: 1177
	public Location Position;

	// Token: 0x0400049A RID: 1178
	public SlotObject SlotObject1;

	// Token: 0x0400049B RID: 1179
	public SlotObject SlotObject2;
}
