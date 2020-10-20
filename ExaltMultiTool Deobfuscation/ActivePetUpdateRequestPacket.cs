using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x0200005E RID: 94
internal class ActivePetUpdateRequestPacket : Packet
{
	// Token: 0x170000F7 RID: 247
	// (get) Token: 0x0600034C RID: 844 RVA: 0x000143EC File Offset: 0x000125EC
	public override PacketType Type
	{
		get
		{
			return PacketType.ACTIVEPETUPDATEREQUEST;
		}
	}

	// Token: 0x0600034D RID: 845 RVA: 0x000143FC File Offset: 0x000125FC
	public override void Read(PacketReader r)
	{
		this.CommandId = (int)r.ReadByte();
		this.PetId = (uint)r.ReadInt32();
	}

	// Token: 0x0600034E RID: 846 RVA: 0x00014424 File Offset: 0x00012624
	public override void Write(PacketWriter w)
	{
		w.Write((byte)this.CommandId);
		w.Write((int)this.PetId);
	}

	// Token: 0x040004A5 RID: 1189
	public const int _LQeSZsnE23gnfJcvGKG3fZG9Lfh = 1;

	// Token: 0x040004A6 RID: 1190
	public const int _U3nfBQLa9WjlucSuMeDPriY5VxG = 2;

	// Token: 0x040004A7 RID: 1191
	public const int _eSGbmSWMCqS08zDHpivVBD8OAWf = 3;

	// Token: 0x040004A8 RID: 1192
	public int CommandId;

	// Token: 0x040004A9 RID: 1193
	public uint PetId;
}
