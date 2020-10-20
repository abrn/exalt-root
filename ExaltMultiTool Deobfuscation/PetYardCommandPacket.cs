using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x0200005F RID: 95
internal class PetYardCommandPacket : Packet
{
	// Token: 0x170000F8 RID: 248
	// (get) Token: 0x06000350 RID: 848 RVA: 0x00014460 File Offset: 0x00012660
	public override PacketType Type
	{
		get
		{
			return PacketType.PETUPGRADEREQUEST;
		}
	}

	// Token: 0x06000351 RID: 849 RVA: 0x00014470 File Offset: 0x00012670
	public override void Read(PacketReader r)
	{
		this.CommandId = r.ReadByte();
		this.PetId1 = r.ReadInt32();
		this.PetId2 = r.ReadInt32();
		this.ObjectId = r.ReadInt32();
		this.ObjectSlot = r.ReadByte();
		this.Currency = new SlotObject[(int)r.ReadInt16()];
		for (int i = 0; i < this.Currency.Length; i++)
		{
			this.Currency[i] = new SlotObject(r);
		}
	}

	// Token: 0x06000352 RID: 850 RVA: 0x000144EC File Offset: 0x000126EC
	public override void Write(PacketWriter w)
	{
		w.Write(this.CommandId);
		w.Write(this.PetId1);
		w.Write(this.PetId2);
		w.Write(this.ObjectId);
		w.Write(this.ObjectSlot);
		w.Write((short)this.Currency.Length);
		SlotObject[] Currency = this.Currency;
		for (int i = 0; i < Currency.Length; i++)
		{
			Currency[i].Write(w);
		}
	}

	// Token: 0x040004AA RID: 1194
	public const int UPGRADE_PET_YARD = 1;

	// Token: 0x040004AB RID: 1195
	public const int FEED_PET = 2;

	// Token: 0x040004AC RID: 1196
	public const int FUSE_PET = 3;

	// Token: 0x040004AD RID: 1197
	public byte CommandId;

	// Token: 0x040004AE RID: 1198
	public int PetId1;

	// Token: 0x040004AF RID: 1199
	public int PetId2;

	// Token: 0x040004B0 RID: 1200
	public int ObjectId;

	// Token: 0x040004B1 RID: 1201
	public byte ObjectSlot;

	// Token: 0x040004B2 RID: 1202
	public SlotObject[] Currency;
}
