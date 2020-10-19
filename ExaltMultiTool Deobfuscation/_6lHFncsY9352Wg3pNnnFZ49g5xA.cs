using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x0200008E RID: 142
internal class _6lHFncsY9352Wg3pNnnFZ49g5xA : Packet
{
	// Token: 0x17000127 RID: 295
	// (get) Token: 0x0600040E RID: 1038 RVA: 0x000160F8 File Offset: 0x000142F8
	public override PacketType Type
	{
		get
		{
			return PacketType.QUESTOBJID;
		}
	}

	// Token: 0x0600040F RID: 1039 RVA: 0x00016108 File Offset: 0x00014308
	public override void Read(PacketReader r)
	{
		this._605Ligxeaj9k9kBV8zQhhFhgTGl = r.ReadInt32();
		int num = _di3Iyuw9XRVUyJrW7NCBFduCW4H._eHIpo1lHmEGnQwbA8tDvcpJtdfl(r);
		this._4jOLjW4f3NFdoiR8aTchgxYgk8f = new int[num];
		for (int i = 0; i < num; i++)
		{
			this._4jOLjW4f3NFdoiR8aTchgxYgk8f[i] = _di3Iyuw9XRVUyJrW7NCBFduCW4H._eHIpo1lHmEGnQwbA8tDvcpJtdfl(r);
		}
	}

	// Token: 0x06000410 RID: 1040 RVA: 0x00016150 File Offset: 0x00014350
	public override void Write(PacketWriter w)
	{
		w.Write(this._605Ligxeaj9k9kBV8zQhhFhgTGl);
		_di3Iyuw9XRVUyJrW7NCBFduCW4H._7A7oILp80mGDmH4Uco8L8vPbaS4(w, this._4jOLjW4f3NFdoiR8aTchgxYgk8f.Length);
		foreach (int value in this._4jOLjW4f3NFdoiR8aTchgxYgk8f)
		{
			_di3Iyuw9XRVUyJrW7NCBFduCW4H._7A7oILp80mGDmH4Uco8L8vPbaS4(w, value);
		}
	}

	// Token: 0x0400053D RID: 1341
	public int _605Ligxeaj9k9kBV8zQhhFhgTGl;

	// Token: 0x0400053E RID: 1342
	public int[] _4jOLjW4f3NFdoiR8aTchgxYgk8f;
}
