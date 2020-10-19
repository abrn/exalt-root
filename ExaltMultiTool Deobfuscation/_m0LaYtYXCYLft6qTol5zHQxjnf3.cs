using System;
using System.Collections.Generic;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000086 RID: 134
internal class NewTickPacket : Packet
{
	// Token: 0x1700011F RID: 287
	// (get) Token: 0x060003EC RID: 1004 RVA: 0x00015C0C File Offset: 0x00013E0C
	public override PacketType Type
	{
		get
		{
			return PacketType.NEWTICK;
		}
	}

	// Token: 0x060003ED RID: 1005 RVA: 0x00015C1C File Offset: 0x00013E1C
	public override void Read(PacketReader r)
	{
		this._AKwrGdNlyCcdoE29BXWWchVg2fJ = r.ReadInt32();
		this._O8ZPS6Ibh455w0oY1jBdktfRWIA = r.ReadInt32();
		this._3w7FsPNx8HxtVzAwav0Ej4FiR1A = r.ReadUInt32();
		this._eXMXaNv4TpTBa3URSBoQO7ZIpCe = r.ReadUInt16();
		int num = (int)r.ReadInt16();
		this.Statuses = new List<Status>();
		for (int i = 0; i < num; i++)
		{
			this.Statuses.Add((Status)new Status().Read(r));
		}
	}

	// Token: 0x060003EE RID: 1006 RVA: 0x00015C94 File Offset: 0x00013E94
	public override void Write(PacketWriter w)
	{
		w.Write(this._AKwrGdNlyCcdoE29BXWWchVg2fJ);
		w.Write(this._O8ZPS6Ibh455w0oY1jBdktfRWIA);
		w.Write(this._3w7FsPNx8HxtVzAwav0Ej4FiR1A);
		w.Write(this._eXMXaNv4TpTBa3URSBoQO7ZIpCe);
		w.Write((short)this.Statuses.Count);
		foreach (Status seOURj9wT08Ssc6bZOctUjk0KXi in this.Statuses)
		{
			seOURj9wT08Ssc6bZOctUjk0KXi.Write(w);
		}
	}

	// Token: 0x04000528 RID: 1320
	public int _AKwrGdNlyCcdoE29BXWWchVg2fJ;

	// Token: 0x04000529 RID: 1321
	public int _O8ZPS6Ibh455w0oY1jBdktfRWIA;

	// Token: 0x0400052A RID: 1322
	public uint _3w7FsPNx8HxtVzAwav0Ej4FiR1A;

	// Token: 0x0400052B RID: 1323
	public ushort _eXMXaNv4TpTBa3URSBoQO7ZIpCe;

	// Token: 0x0400052C RID: 1324
	public List<Status> Statuses;
}
