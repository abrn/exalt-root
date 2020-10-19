using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x0200003C RID: 60
internal class _5REHLZQHHjlnOJeEg4aahwb3mAp : Packet
{
	// Token: 0x170000D5 RID: 213
	// (get) Token: 0x060002C4 RID: 708 RVA: 0x000131FC File Offset: 0x000113FC
	public override PacketType Type
	{
		get
		{
			return PacketType.PETCHANGESKINMSG;
		}
	}

	// Token: 0x060002C5 RID: 709 RVA: 0x0001320C File Offset: 0x0001140C
	public override void Read(PacketReader r)
	{
		this._gMQB8nUc90NEebz9oVexr6Ppdmb = r.ReadInt32();
		this._lzeJbLqKTrOjSpCh6A6kpUftgap = r.ReadInt32();
		this._GbtHysMRPoKlTOMs7qbMI8m9BjB = r.ReadInt32();
	}

	// Token: 0x060002C6 RID: 710 RVA: 0x00013240 File Offset: 0x00011440
	public override void Write(PacketWriter w)
	{
		w.Write(this._gMQB8nUc90NEebz9oVexr6Ppdmb);
		w.Write(this._lzeJbLqKTrOjSpCh6A6kpUftgap);
		w.Write(this._GbtHysMRPoKlTOMs7qbMI8m9BjB);
	}

	// Token: 0x04000456 RID: 1110
	public int _gMQB8nUc90NEebz9oVexr6Ppdmb;

	// Token: 0x04000457 RID: 1111
	public int _lzeJbLqKTrOjSpCh6A6kpUftgap;

	// Token: 0x04000458 RID: 1112
	public int _GbtHysMRPoKlTOMs7qbMI8m9BjB;
}
