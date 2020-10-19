using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x0200005A RID: 90
internal class _DRnAVctaHy43lHFmLM8RiSA8VbP : Packet
{
	// Token: 0x170000F3 RID: 243
	// (get) Token: 0x0600033C RID: 828 RVA: 0x00014210 File Offset: 0x00012410
	public override PacketType Type
	{
		get
		{
			return PacketType.KEYINFOREQUEST;
		}
	}

	// Token: 0x0600033D RID: 829 RVA: 0x00014220 File Offset: 0x00012420
	public override void Read(PacketReader r)
	{
		this._n9TZfgmLaqaeaE15gSQUGN16s5N = r.ReadBytes((int)r.BaseStream.Length - 5);
	}

	// Token: 0x0600033E RID: 830 RVA: 0x00014248 File Offset: 0x00012448
	public override void Write(PacketWriter w)
	{
		w.Write(this._n9TZfgmLaqaeaE15gSQUGN16s5N);
	}

	// Token: 0x0400049D RID: 1181
	public byte[] _n9TZfgmLaqaeaE15gSQUGN16s5N;
}
