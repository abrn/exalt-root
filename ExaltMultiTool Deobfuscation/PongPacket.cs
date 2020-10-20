using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000063 RID: 99
internal class PongPacket : Packet
{
	// Token: 0x170000FC RID: 252
	// (get) Token: 0x06000360 RID: 864 RVA: 0x0001474C File Offset: 0x0001294C
	public override PacketType Type
	{
		get
		{
			return PacketType.PONG;
		}
	}

	// Token: 0x06000361 RID: 865 RVA: 0x0001475C File Offset: 0x0001295C
	public override void Read(PacketReader r)
	{
		this.Serial = r.ReadInt32();
		this.Time = r.ReadInt32();
	}

	// Token: 0x06000362 RID: 866 RVA: 0x00014784 File Offset: 0x00012984
	public override void Write(PacketWriter w)
	{
		w.Write(this.Serial);
		w.Write(this.Time);
	}

	// Token: 0x040004BE RID: 1214
	public int Serial;

	// Token: 0x040004BF RID: 1215
	public int Time;
}
