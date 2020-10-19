using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000078 RID: 120
internal class DeathPacket : Packet
{
	// Token: 0x17000111 RID: 273
	// (get) Token: 0x060003B4 RID: 948 RVA: 0x0001526C File Offset: 0x0001346C
	public override PacketType Type
	{
		get
		{
			return PacketType.DEATH;
		}
	}

	// Token: 0x060003B5 RID: 949 RVA: 0x0001527C File Offset: 0x0001347C
	public override void Read(PacketReader r)
	{
		this.AccountId = r.ReadString();
		this.CharId = r.ReadInt32();
		this.KilledBy = r.ReadString();
		this.ZombieType = r.ReadInt32();
		this.ZombieId = r.ReadInt32();
		this.Unknown_0 = r.ReadInt32();
	}

	// Token: 0x060003B6 RID: 950 RVA: 0x000152D4 File Offset: 0x000134D4
	public override void Write(PacketWriter w)
	{
		w.Write(this.AccountId);
		w.Write(this.CharId);
		w.Write(this.KilledBy);
		w.Write(this.ZombieType);
		w.Write(this.ZombieId);
		w.Write(this.Unknown_0);
	}

	// Token: 0x040004F4 RID: 1268
	public string AccountId;

	// Token: 0x040004F5 RID: 1269
	public int CharId;

	// Token: 0x040004F6 RID: 1270
	public string KilledBy;

	// Token: 0x040004F7 RID: 1271
	public int ZombieType;

	// Token: 0x040004F8 RID: 1272
	public int ZombieId;

	// Token: 0x040004F9 RID: 1273
	public int Unknown_0;
}
