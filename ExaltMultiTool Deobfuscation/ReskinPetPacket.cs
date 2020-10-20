using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000067 RID: 103
internal class ReskinPetPacket : Packet
{
	// Token: 0x17000100 RID: 256
	// (get) Token: 0x06000370 RID: 880 RVA: 0x000148BC File Offset: 0x00012ABC
	public override PacketType Type
	{
		get
		{
			return PacketType.PETCHANGEFORMMSG;
		}
	}

	// Token: 0x06000371 RID: 881 RVA: 0x000148CC File Offset: 0x00012ACC
	public override void Read(PacketReader r)
	{
		this.PetId = r.ReadInt32();
		this.NewPetType = r.ReadInt32();
		this.Item = new SlotObject(r);
	}

	// Token: 0x06000372 RID: 882 RVA: 0x00014900 File Offset: 0x00012B00
	public override void Write(PacketWriter w)
	{
		w.Write(this.PetId);
		w.Write(this.NewPetType);
		this.Item.Write(w);
	}

	// Token: 0x040004C2 RID: 1218
	public int PetId;

	// Token: 0x040004C3 RID: 1219
	public int NewPetType;

	// Token: 0x040004C4 RID: 1220
	public SlotObject Item;
}
