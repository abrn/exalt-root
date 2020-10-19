using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x0200003D RID: 61
internal class MovePacket : Packet
{
	// Token: 0x170000D6 RID: 214
	// (get) Token: 0x060002C8 RID: 712 RVA: 0x00013288 File Offset: 0x00011488
	public override PacketType Type
	{
		get
		{
			return PacketType.MOVE;
		}
	}

	// Token: 0x060002C9 RID: 713 RVA: 0x00013298 File Offset: 0x00011498
	public override void Read(PacketReader r)
	{
		this.TickId = r.ReadInt32();
		this.Time = r.ReadInt32();
		this._jibXvbYxtn4vGAp7d5JjGTJzRQB = r.ReadUInt32();
		this._l6SobSknmpzcoMgQdVhaWNqcv8D = new Location(r);
		this._R1WaWBvLcECAzd7zfoHrisdxkyD = new LocationRecord[(int)r.ReadInt16()];
		for (int i = 0; i < this._R1WaWBvLcECAzd7zfoHrisdxkyD.Length; i++)
		{
			this._R1WaWBvLcECAzd7zfoHrisdxkyD[i] = new LocationRecord(r);
		}
	}

	// Token: 0x060002CA RID: 714 RVA: 0x00013308 File Offset: 0x00011508
	public override void Write(PacketWriter w)
	{
		w.Write(this.TickId);
		w.Write(this._Nx46RcGIU0H1BCGWaJXjN1ieopt);
		w.Write(this._jibXvbYxtn4vGAp7d5JjGTJzRQB);
		this._l6SobSknmpzcoMgQdVhaWNqcv8D.Write(w);
		w.Write((short)this._R1WaWBvLcECAzd7zfoHrisdxkyD.Length);
		LocationRecord[] r1WaWBvLcECAzd7zfoHrisdxkyD = this._R1WaWBvLcECAzd7zfoHrisdxkyD;
		for (int i = 0; i < r1WaWBvLcECAzd7zfoHrisdxkyD.Length; i++)
		{
			r1WaWBvLcECAzd7zfoHrisdxkyD[i].Write(w);
		}
	}

	// Token: 0x04000459 RID: 1113
	public int TickId;

	// Token: 0x0400045A RID: 1114
	public int _Nx46RcGIU0H1BCGWaJXjN1ieopt;

	// Token: 0x0400045B RID: 1115
	public uint _jibXvbYxtn4vGAp7d5JjGTJzRQB;

	// Token: 0x0400045C RID: 1116
	public Location _l6SobSknmpzcoMgQdVhaWNqcv8D;

	// Token: 0x0400045D RID: 1117
	public LocationRecord[] _R1WaWBvLcECAzd7zfoHrisdxkyD;
}
