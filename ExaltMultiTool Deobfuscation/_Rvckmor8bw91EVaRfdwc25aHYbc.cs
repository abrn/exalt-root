using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x0200006A RID: 106
internal class TeleportPacket : Packet
{
	// Token: 0x17000103 RID: 259
	// (get) Token: 0x0600037C RID: 892 RVA: 0x00014A18 File Offset: 0x00012C18
	public override PacketType Type
	{
		get
		{
			return PacketType.TELEPORT;
		}
	}

	// Token: 0x0600037D RID: 893 RVA: 0x00014A28 File Offset: 0x00012C28
	public override void Read(PacketReader r)
	{
		this._605Ligxeaj9k9kBV8zQhhFhgTGl = r.ReadInt32();
	}

	// Token: 0x0600037E RID: 894 RVA: 0x00014A44 File Offset: 0x00012C44
	public override void Write(PacketWriter w)
	{
		w.Write(this._605Ligxeaj9k9kBV8zQhhFhgTGl);
	}

	// Token: 0x040004C8 RID: 1224
	public int _605Ligxeaj9k9kBV8zQhhFhgTGl;
}
