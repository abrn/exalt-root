using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000084 RID: 132
internal class NewAbilityPacket : Packet
{
	// Token: 0x1700011D RID: 285
	// (get) Token: 0x060003E4 RID: 996 RVA: 0x00015B54 File Offset: 0x00013D54
	public override PacketType Type
	{
		get
		{
			return PacketType.NEWABILITY;
		}
	}

	// Token: 0x060003E5 RID: 997 RVA: 0x00015B64 File Offset: 0x00013D64
	public override void Read(PacketReader r)
	{
		this.PetAbilityType = (PetAbility)r.ReadInt32();
	}

	// Token: 0x060003E6 RID: 998 RVA: 0x00015B80 File Offset: 0x00013D80
	public override void Write(PacketWriter w)
	{
		w.Write((int)this.Type);
	}

	// Token: 0x04000526 RID: 1318
	public PetAbility PetAbilityType;
}
