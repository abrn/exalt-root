using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x0200008C RID: 140
internal class _Iq6EzDJfMB4Iq5WP7HuL7ZnnHqE : Packet
{
	// Token: 0x17000125 RID: 293
	// (get) Token: 0x06000406 RID: 1030 RVA: 0x00015FCC File Offset: 0x000141CC
	public override PacketType Type
	{
		get
		{
			return PacketType.PLAYSOUND;
		}
	}

	// Token: 0x06000407 RID: 1031 RVA: 0x00015FDC File Offset: 0x000141DC
	public override void Read(PacketReader r)
	{
		this._o1vIAcFEkLsw697hhlSgXnC4w9g = r.ReadInt32();
		this._KbS55PkIQ4BRaIkDdrrXRrzNkTp = (int)r.ReadByte();
	}

	// Token: 0x06000408 RID: 1032 RVA: 0x00016004 File Offset: 0x00014204
	public override void Write(PacketWriter w)
	{
		w.Write(this._o1vIAcFEkLsw697hhlSgXnC4w9g);
		w.Write((byte)this._KbS55PkIQ4BRaIkDdrrXRrzNkTp);
	}

	// Token: 0x04000539 RID: 1337
	public int _o1vIAcFEkLsw697hhlSgXnC4w9g;

	// Token: 0x0400053A RID: 1338
	public int _KbS55PkIQ4BRaIkDdrrXRrzNkTp;
}
