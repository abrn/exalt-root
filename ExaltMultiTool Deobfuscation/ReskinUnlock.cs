using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000094 RID: 148
internal class ReskinUnlock : Packet
{
	// Token: 0x1700012D RID: 301
	// (get) Token: 0x06000426 RID: 1062 RVA: 0x00016460 File Offset: 0x00014660
	public override PacketType Type
	{
		get
		{
			return PacketType.RESKINUNLOCK;
		}
	}

	// Token: 0x06000427 RID: 1063 RVA: 0x00016470 File Offset: 0x00014670
	public override void Read(PacketReader r)
	{
		this.SkinId = r.ReadInt32();
		this.IsPetSkin = r.ReadInt32();
	}

	// Token: 0x06000428 RID: 1064 RVA: 0x00016498 File Offset: 0x00014698
	public override void Write(PacketWriter w)
	{
		w.Write(this.SkinId);
		w.Write(this.IsPetSkin);
	}

	// Token: 0x0400054D RID: 1357
	public int SkinId;

	// Token: 0x0400054E RID: 1358
	public int IsPetSkin;
}
