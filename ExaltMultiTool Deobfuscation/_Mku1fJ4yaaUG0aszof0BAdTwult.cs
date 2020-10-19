using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x0200005D RID: 93
internal class _Mku1fJ4yaaUG0aszof0BAdTwult : Packet
{
	// Token: 0x170000F6 RID: 246
	// (get) Token: 0x06000348 RID: 840 RVA: 0x00014360 File Offset: 0x00012560
	public override PacketType Type
	{
		get
		{
			return PacketType.LOGINREWARDMSG;
		}
	}

	// Token: 0x06000349 RID: 841 RVA: 0x00014370 File Offset: 0x00012570
	public override void Read(PacketReader r)
	{
		this._lkWd8YaMc9BjtwzBA3PZoNRpPir = r.ReadInt32();
		this._LmEskIXC9vKfGu6Nf0U5VFE1BEu = r.ReadInt32();
		this._B8vzrB2PfiAuMZNy8IbbkkSLMND = r.ReadInt32();
	}

	// Token: 0x0600034A RID: 842 RVA: 0x000143A4 File Offset: 0x000125A4
	public override void Write(PacketWriter w)
	{
		w.Write(this._lkWd8YaMc9BjtwzBA3PZoNRpPir);
		w.Write(this._LmEskIXC9vKfGu6Nf0U5VFE1BEu);
		w.Write(this._B8vzrB2PfiAuMZNy8IbbkkSLMND);
	}

	// Token: 0x040004A2 RID: 1186
	public int _lkWd8YaMc9BjtwzBA3PZoNRpPir;

	// Token: 0x040004A3 RID: 1187
	public int _LmEskIXC9vKfGu6Nf0U5VFE1BEu;

	// Token: 0x040004A4 RID: 1188
	public int _B8vzrB2PfiAuMZNy8IbbkkSLMND;
}
