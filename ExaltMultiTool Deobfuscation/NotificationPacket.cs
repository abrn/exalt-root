using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000087 RID: 135
internal class NotificationPacket : Packet
{
	// Token: 0x17000120 RID: 288
	// (get) Token: 0x060003F0 RID: 1008 RVA: 0x00015D3C File Offset: 0x00013F3C
	public override PacketType Type
	{
		get
		{
			return PacketType.NOTIFICATION;
		}
	}

	// Token: 0x060003F1 RID: 1009 RVA: 0x00015D4C File Offset: 0x00013F4C
	public override void Read(PacketReader r)
	{
		this.ObjectId = r.ReadInt32();
		this.Message = r.ReadString();
		this.Color = r.ReadInt32();
	}

	// Token: 0x060003F2 RID: 1010 RVA: 0x00015D80 File Offset: 0x00013F80
	public override void Write(PacketWriter w)
	{
		w.Write(this.ObjectId);
		w.Write(this.Message);
		w.Write(this.Color);
	}

	// Token: 0x060003F3 RID: 1011 RVA: 0x00015DB4 File Offset: 0x00013FB4
	public static NotificationPacket CreateNotification(int objectId, string message)
	{
		return NotificationPacket.CreateNotification(objectId, 65535, message);
	}

	// Token: 0x060003F4 RID: 1012 RVA: 0x00015DD0 File Offset: 0x00013FD0
	public static NotificationPacket CreateNotification(int objectId, int color, string message)
	{
		//notificationpacket
		NotificationPacket notificationPacket = (NotificationPacket)Packet.Create(PacketType.NOTIFICATION);
		notificationPacket.ObjectId = objectId;
		notificationPacket.Message = "{\"key\":\"server.plus_symbol\",\"tokens\":{\"amount\":\"" + message + "\"}}";
		notificationPacket.Color = color;
		return notificationPacket;
	}

	// Token: 0x0400052D RID: 1325
	public int ObjectId;

	// Token: 0x0400052E RID: 1326
	public string Message;

	// Token: 0x0400052F RID: 1327
	public int Color;
}
