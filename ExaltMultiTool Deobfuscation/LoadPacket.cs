using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x0200005C RID: 92
internal class LoadPacket : Packet
{
	// Token: 0x170000F5 RID: 245
	// (get) Token: 0x06000344 RID: 836 RVA: 0x000142D4 File Offset: 0x000124D4
	public override PacketType Type
	{
		get
		{
			return PacketType.LOAD;
		}
	}

	// Token: 0x06000345 RID: 837 RVA: 0x000142E4 File Offset: 0x000124E4
	public override void Read(PacketReader r)
	{
		this.CharacterId = r.ReadInt32();
		this.IsFromArena = r.ReadBoolean();
		this.IsChallenger = r.ReadBoolean();
	}

	// Token: 0x06000346 RID: 838 RVA: 0x00014318 File Offset: 0x00012518
	public override void Write(PacketWriter w)
	{
		w.Write(this.CharacterId);
		w.Write(this.IsFromArena);
		w.Write(this.IsChallenger);
	}

	// Token: 0x0400049F RID: 1183
	public int CharacterId;

	// Token: 0x040004A0 RID: 1184
	public bool IsFromArena;

	// Token: 0x040004A1 RID: 1185
	public bool IsChallenger;
}
