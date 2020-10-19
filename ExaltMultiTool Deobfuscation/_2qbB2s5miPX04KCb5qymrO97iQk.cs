using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000098 RID: 152
internal class _2qbB2s5miPX04KCb5qymrO97iQk : Packet
{
	// Token: 0x17000131 RID: 305
	// (get) Token: 0x06000439 RID: 1081 RVA: 0x00016AC8 File Offset: 0x00014CC8
	public override PacketType Type
	{
		get
		{
			return PacketType.TRADEACCEPTED;
		}
	}

	// Token: 0x0600043A RID: 1082 RVA: 0x00016AD8 File Offset: 0x00014CD8
	public override void Read(PacketReader r)
	{
		this._YcLL7C7DJJJ5EKgDCN8IcqA6Cu2A = new bool[(int)r.ReadInt16()];
		for (int i = 0; i < this._YcLL7C7DJJJ5EKgDCN8IcqA6Cu2A.Length; i++)
		{
			this._YcLL7C7DJJJ5EKgDCN8IcqA6Cu2A[i] = r.ReadBoolean();
		}
		this._MIWv9DTlDcBNFC1HJ3JvSRmZZOA = new bool[(int)r.ReadInt16()];
		for (int j = 0; j < this._MIWv9DTlDcBNFC1HJ3JvSRmZZOA.Length; j++)
		{
			this._MIWv9DTlDcBNFC1HJ3JvSRmZZOA[j] = r.ReadBoolean();
		}
	}

	// Token: 0x0600043B RID: 1083 RVA: 0x00016B4C File Offset: 0x00014D4C
	public override void Write(PacketWriter w)
	{
		w.Write((ushort)this._YcLL7C7DJJJ5EKgDCN8IcqA6Cu2A.Length);
		foreach (bool value in this._YcLL7C7DJJJ5EKgDCN8IcqA6Cu2A)
		{
			w.Write(value);
		}
		w.Write((ushort)this._MIWv9DTlDcBNFC1HJ3JvSRmZZOA.Length);
		foreach (bool value2 in this._MIWv9DTlDcBNFC1HJ3JvSRmZZOA)
		{
			w.Write(value2);
		}
	}

	// Token: 0x04000570 RID: 1392
	public bool[] _YcLL7C7DJJJ5EKgDCN8IcqA6Cu2A;

	// Token: 0x04000571 RID: 1393
	public bool[] _MIWv9DTlDcBNFC1HJ3JvSRmZZOA;
}
