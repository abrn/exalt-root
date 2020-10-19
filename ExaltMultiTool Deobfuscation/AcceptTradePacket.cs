using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000042 RID: 66
internal class AcceptTradePacket : Packet
{
	// Token: 0x170000DB RID: 219
	// (get) Token: 0x060002DC RID: 732 RVA: 0x000135C8 File Offset: 0x000117C8
	public override PacketType Type
	{
		get
		{
			return PacketType.ACCEPTTRADE;
		}
	}

	// Token: 0x060002DD RID: 733 RVA: 0x000135D8 File Offset: 0x000117D8
	public override void Read(PacketReader r)
	{
		this.MyOffers = new bool[(int)r.ReadInt16()];
		for (int i = 0; i < this.MyOffers.Length; i++)
		{
			this.MyOffers[i] = r.ReadBoolean();
		}
		this.YourOffers = new bool[(int)r.ReadInt16()];
		for (int j = 0; j < this.YourOffers.Length; j++)
		{
			this.YourOffers[j] = r.ReadBoolean();
		}
	}

	// Token: 0x060002DE RID: 734 RVA: 0x0001364C File Offset: 0x0001184C
	public override void Write(PacketWriter w)
	{
		w.Write((ushort)this.MyOffers.Length);
		foreach (bool value in this.MyOffers)
		{
			w.Write(value);
		}
		w.Write((ushort)this.YourOffers.Length);
		foreach (bool value2 in this.YourOffers)
		{
			w.Write(value2);
		}
	}

	// Token: 0x04000468 RID: 1128
	public bool[] MyOffers;

	// Token: 0x04000469 RID: 1129
	public bool[] YourOffers;
}
