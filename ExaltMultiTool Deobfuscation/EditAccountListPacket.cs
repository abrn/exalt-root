using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x0200004D RID: 77
internal class EditAccountListPacket : Packet
{
	// Token: 0x170000E6 RID: 230
	// (get) Token: 0x06000308 RID: 776 RVA: 0x00013B08 File Offset: 0x00011D08
	public override PacketType Type
	{
		get
		{
			return PacketType.EDITACCOUNTLIST;
		}
	}

	// Token: 0x06000309 RID: 777 RVA: 0x00013B18 File Offset: 0x00011D18
	public override void Read(PacketReader r)
	{
		this.AccountListId = r.ReadInt32();
		this.Add = r.ReadBoolean();
		this.ObjectId = r.ReadInt32();
	}

	// Token: 0x0600030A RID: 778 RVA: 0x00013B4C File Offset: 0x00011D4C
	public override void Write(PacketWriter w)
	{
		w.Write(this.AccountListId);
		w.Write(this.Add);
		w.Write(this.ObjectId);
	}

	// Token: 0x04000478 RID: 1144
	public int AccountListId;

	// Token: 0x04000479 RID: 1145
	public bool Add;

	// Token: 0x0400047A RID: 1146
	public int ObjectId;
}
