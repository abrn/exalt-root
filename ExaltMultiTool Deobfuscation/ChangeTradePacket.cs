using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000047 RID: 71
internal class ChangeTradePacket : Packet
{
	// Token: 0x170000E0 RID: 224
	// (get) Token: 0x060002F0 RID: 752 RVA: 0x0001386C File Offset: 0x00011A6C
	public override PacketType Type
	{
		get
		{
			return PacketType.CHANGETRADE;
		}
	}

	// Token: 0x060002F1 RID: 753 RVA: 0x0001387C File Offset: 0x00011A7C
	public override void Read(PacketReader r)
	{
		this.Offers = new bool[(int)r.ReadInt16()];
		for (int i = 0; i < this.Offers.Length; i++)
		{
			this.Offers[i] = r.ReadBoolean();
		}
	}

	// Token: 0x060002F2 RID: 754 RVA: 0x000138BC File Offset: 0x00011ABC
	public override void Write(PacketWriter w)
	{
		w.Write((ushort)this.Offers.Length);
		foreach (bool value in this.Offers)
		{
			w.Write(value);
		}
	}

	// Token: 0x04000470 RID: 1136
	public bool[] Offers;
}
