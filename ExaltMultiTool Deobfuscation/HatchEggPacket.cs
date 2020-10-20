using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x0200007E RID: 126
internal class HatchEggPacket : Packet
{
	// Token: 0x17000117 RID: 279
	// (get) Token: 0x060003CC RID: 972 RVA: 0x00015698 File Offset: 0x00013898
	public override PacketType Type
	{
		get
		{
			return PacketType.HATCHPET;
		}
	}

	// Token: 0x060003CD RID: 973 RVA: 0x000156A8 File Offset: 0x000138A8
	public override void Read(PacketReader r)
	{
		this.PetName = r.ReadString();
		this.PetSkinId = r.ReadInt32();
	}

	// Token: 0x060003CE RID: 974 RVA: 0x000156D0 File Offset: 0x000138D0
	public override void Write(PacketWriter w)
	{
		w.Write(this.PetName);
		w.Write(this.PetSkinId);
	}

	// Token: 0x0400050C RID: 1292
	public string PetName;

	// Token: 0x0400050D RID: 1293
	public int PetSkinId;
}
