using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000069 RID: 105
internal class ShootAckPacket : Packet
{
	// Token: 0x17000102 RID: 258
	// (get) Token: 0x06000378 RID: 888 RVA: 0x000149BC File Offset: 0x00012BBC
	public override PacketType Type
	{
		get
		{
			return PacketType.SHOOTACK;
		}
	}

	// Token: 0x06000379 RID: 889 RVA: 0x000149CC File Offset: 0x00012BCC
	public override void Read(PacketReader r)
	{
		this.Time = r.ReadInt32();
	}

	// Token: 0x0600037A RID: 890 RVA: 0x000149E8 File Offset: 0x00012BE8
	public override void Write(PacketWriter w)
	{
		w.Write(this.Time);
	}

	// Token: 0x040004C7 RID: 1223
	public int Time;
}
