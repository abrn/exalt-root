using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000089 RID: 137
internal class PetEvolveResultPacket : Packet
{
	// Token: 0x17000122 RID: 290
	// (get) Token: 0x060003FA RID: 1018 RVA: 0x00015E80 File Offset: 0x00014080
	public override PacketType Type
	{
		get
		{
			return PacketType.EVOLVEPET;
		}
	}

	// Token: 0x060003FB RID: 1019 RVA: 0x00015E90 File Offset: 0x00014090
	public override void Read(PacketReader r)
	{
		this.PetId = r.ReadInt32();
		this.SkinId1 = r.ReadInt32();
		this.SkinId2 = r.ReadInt32();
	}

	// Token: 0x060003FC RID: 1020 RVA: 0x00015EC4 File Offset: 0x000140C4
	public override void Write(PacketWriter w)
	{
		w.Write(this.PetId);
		w.Write(this.SkinId1);
		w.Write(this.SkinId2);
	}

	// Token: 0x04000534 RID: 1332
	public int PetId;

	// Token: 0x04000535 RID: 1333
	public int SkinId1;

	// Token: 0x04000536 RID: 1334
	public int SkinId2;
}
