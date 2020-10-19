using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000099 RID: 153
internal class TradeChangedPacket : Packet
{
	// Token: 0x17000132 RID: 306
	// (get) Token: 0x0600043D RID: 1085 RVA: 0x00016BCC File Offset: 0x00014DCC
	public override PacketType Type
	{
		get
		{
			return PacketType.TRADECHANGED;
		}
	}

	// Token: 0x0600043E RID: 1086 RVA: 0x00016BDC File Offset: 0x00014DDC
	public override void Read(PacketReader r)
	{
		this.Offers = new bool[(int)r.ReadInt16()];
		for (int i = 0; i < this.Offers.Length; i++)
		{
			this.Offers[i] = r.ReadBoolean();
		}
	}

	// Token: 0x0600043F RID: 1087 RVA: 0x00016C1C File Offset: 0x00014E1C
	public override void Write(PacketWriter w)
	{
		w.Write((ushort)this.Offers.Length);
		foreach (bool value in this.Offers)
		{
			w.Write(value);
		}
	}

	// Token: 0x04000572 RID: 1394
	public bool[] Offers;
}
