using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000084 RID: 132
internal class _jy35B46wABp35GSACnK9cRTDZkC : Packet
{
	// Token: 0x1700011D RID: 285
	// (get) Token: 0x060003E4 RID: 996 RVA: 0x00015B54 File Offset: 0x00013D54
	public override PacketType Type
	{
		get
		{
			return PacketType.NEWABILITY;
		}
	}

	// Token: 0x060003E5 RID: 997 RVA: 0x00015B64 File Offset: 0x00013D64
	public override void Read(PacketReader r)
	{
		this._uAmdMJZAwHNAEyZgWlEw4VVu9Hx = (_oirHApJgzJXA6ZQb29bRR9s8CojA)r.ReadInt32();
	}

	// Token: 0x060003E6 RID: 998 RVA: 0x00015B80 File Offset: 0x00013D80
	public override void Write(PacketWriter w)
	{
		w.Write((int)this._AtkZAUcYsZElf0JhQKwQOGgCygn._k9uWQCZd8WqDr6yiKRmrLtst3KX);
	}

	// Token: 0x04000526 RID: 1318
	public _oirHApJgzJXA6ZQb29bRR9s8CojA _uAmdMJZAwHNAEyZgWlEw4VVu9Hx;
}
