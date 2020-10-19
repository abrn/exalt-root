using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000073 RID: 115
internal class BuyResultPacket : Packet
{
	// Token: 0x1700010C RID: 268
	// (get) Token: 0x060003A0 RID: 928 RVA: 0x00014F00 File Offset: 0x00013100
	public override PacketType Type
	{
		get
		{
			return PacketType.BUYRESULT;
		}
	}

	// Token: 0x060003A1 RID: 929 RVA: 0x00014F10 File Offset: 0x00013110
	public override void Read(PacketReader r)
	{
		this.Result = r.ReadInt32();
		this.Message = r.ReadString();
	}

	// Token: 0x060003A2 RID: 930 RVA: 0x00014F38 File Offset: 0x00013138
	public override void Write(PacketWriter w)
	{
		w.Write(this.Result);
		w.Write(this.Message);
	}

	// Token: 0x040004E0 RID: 1248
	public int Result;

	// Token: 0x040004E1 RID: 1249
	public string Message;
}
