using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x0200006D RID: 109
internal class _JrdXxRFAhPHjNMwiVoCr24bVuORA : Packet
{
	// Token: 0x17000106 RID: 262
	// (get) Token: 0x06000388 RID: 904 RVA: 0x00014B5C File Offset: 0x00012D5C
	public override PacketType Type
	{
		get
		{
			return PacketType.USEPORTAL;
		}
	}

	// Token: 0x06000389 RID: 905 RVA: 0x00014B6C File Offset: 0x00012D6C
	public override void Read(PacketReader r)
	{
		this._605Ligxeaj9k9kBV8zQhhFhgTGl = r.ReadInt32();
	}

	// Token: 0x0600038A RID: 906 RVA: 0x00014B88 File Offset: 0x00012D88
	public override void Write(PacketWriter w)
	{
		w.Write(this._605Ligxeaj9k9kBV8zQhhFhgTGl);
	}

	// Token: 0x040004CD RID: 1229
	public int _605Ligxeaj9k9kBV8zQhhFhgTGl;
}
