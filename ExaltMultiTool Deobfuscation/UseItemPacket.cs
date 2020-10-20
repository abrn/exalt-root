using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x0200006C RID: 108
internal class UseItemPacket : Packet
{
	// Token: 0x17000105 RID: 261
	// (get) Token: 0x06000384 RID: 900 RVA: 0x00014AB8 File Offset: 0x00012CB8
	public override PacketType Type
	{
		get
		{
			return PacketType.USEITEM;
		}
	}

	// Token: 0x06000385 RID: 901 RVA: 0x00014AC8 File Offset: 0x00012CC8
	public override void Read(PacketReader r)
	{
		this.Time = r.ReadInt32();
		this.SlotObject = new SlotObject(r);
		this.ItemUsePos = new Location(r);
		this.UseType = r.ReadByte();
	}

	// Token: 0x06000386 RID: 902 RVA: 0x00014B08 File Offset: 0x00012D08
	public override void Write(PacketWriter w)
	{
		w.Write(this.Time);
		this.SlotObject.Write(w);
		this.ItemUsePos.Write(w);
		w.Write(this.UseType);
	}

	// Token: 0x040004C9 RID: 1225
	public int Time;

	// Token: 0x040004CA RID: 1226
	public SlotObject SlotObject;

	// Token: 0x040004CB RID: 1227
	public Location ItemUsePos;

	// Token: 0x040004CC RID: 1228
	public byte UseType;
}
