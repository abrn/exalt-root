using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x0200008E RID: 142
internal class QuestObjIdPacket : Packet
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
		this.ObjectId = r.ReadInt32();
		int num = CompressedInt.Read(r);
		this._4jOLjW4f3NFdoiR8aTchgxYgk8f = new int[num];
		for (int i = 0; i < num; i++)
		{
			this._4jOLjW4f3NFdoiR8aTchgxYgk8f[i] = CompressedInt.Read(r);
		}
	}

	// Token: 0x06000410 RID: 1040 RVA: 0x00016150 File Offset: 0x00014350
	public override void Write(PacketWriter w)
	{
		w.Write(this.ObjectId);
		CompressedInt.Write(w, this._4jOLjW4f3NFdoiR8aTchgxYgk8f.Length);
		foreach (int value in this._4jOLjW4f3NFdoiR8aTchgxYgk8f)
		{
			CompressedInt.Write(w, value);
		}
	}

	// Token: 0x0400053D RID: 1341
	public int ObjectId;

	// Token: 0x0400053E RID: 1342
	public int[] _4jOLjW4f3NFdoiR8aTchgxYgk8f;
}
