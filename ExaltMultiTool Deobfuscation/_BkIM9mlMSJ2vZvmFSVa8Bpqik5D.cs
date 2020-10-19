using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000089 RID: 137
internal class _BkIM9mlMSJ2vZvmFSVa8Bpqik5D : Packet
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
		this._gMQB8nUc90NEebz9oVexr6Ppdmb = r.ReadInt32();
		this._alMr6MXdHe9dZ1WKz0pJT6XNGRy = r.ReadInt32();
		this._xyG67pgxKdCMHbiNSUm60M7DhxK = r.ReadInt32();
	}

	// Token: 0x060003FC RID: 1020 RVA: 0x00015EC4 File Offset: 0x000140C4
	public override void Write(PacketWriter w)
	{
		w.Write(this._gMQB8nUc90NEebz9oVexr6Ppdmb);
		w.Write(this._alMr6MXdHe9dZ1WKz0pJT6XNGRy);
		w.Write(this._xyG67pgxKdCMHbiNSUm60M7DhxK);
	}

	// Token: 0x04000534 RID: 1332
	public int _gMQB8nUc90NEebz9oVexr6Ppdmb;

	// Token: 0x04000535 RID: 1333
	public int _alMr6MXdHe9dZ1WKz0pJT6XNGRy;

	// Token: 0x04000536 RID: 1334
	public int _xyG67pgxKdCMHbiNSUm60M7DhxK;
}
