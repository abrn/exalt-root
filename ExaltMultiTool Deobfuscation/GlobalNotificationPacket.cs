using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x0200007C RID: 124
internal class GlobalNotificationPacket : Packet
{
	// Token: 0x17000115 RID: 277
	// (get) Token: 0x060003C4 RID: 964 RVA: 0x000155B0 File Offset: 0x000137B0
	public override PacketType Type
	{
		get
		{
			return PacketType.GLOBALNOTIFICATION;
		}
	}

	// Token: 0x060003C5 RID: 965 RVA: 0x000155C0 File Offset: 0x000137C0
	public override void Read(PacketReader r)
	{
		this.TypeId = r.ReadInt32();
		this.Text = r.ReadString();
	}

	// Token: 0x060003C6 RID: 966 RVA: 0x000155E8 File Offset: 0x000137E8
	public override void Write(PacketWriter w)
	{
		w.Write(this.TypeId);
		w.Write(this.Text);
	}

	// Token: 0x04000508 RID: 1288
	public int TypeId;

	// Token: 0x04000509 RID: 1289
	public string Text;
}
