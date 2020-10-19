using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x0200005C RID: 92
internal class _RIycmCn337rdwHKgAP2S8werk44 : Packet
{
	// Token: 0x170000F5 RID: 245
	// (get) Token: 0x06000344 RID: 836 RVA: 0x000142D4 File Offset: 0x000124D4
	public override PacketType Type
	{
		get
		{
			return PacketType.LOAD;
		}
	}

	// Token: 0x06000345 RID: 837 RVA: 0x000142E4 File Offset: 0x000124E4
	public override void Read(PacketReader r)
	{
		this._z51McfCX7r3QwZZ2Nh78rfp6IAh = r.ReadInt32();
		this._38qIHXlB7yTzHdLpQfiJxOul2iM = r.ReadBoolean();
		this._aapegx4D6nAePdcldcfu6WqpLFg = r.ReadBoolean();
	}

	// Token: 0x06000346 RID: 838 RVA: 0x00014318 File Offset: 0x00012518
	public override void Write(PacketWriter w)
	{
		w.Write(this._z51McfCX7r3QwZZ2Nh78rfp6IAh);
		w.Write(this._38qIHXlB7yTzHdLpQfiJxOul2iM);
		w.Write(this._aapegx4D6nAePdcldcfu6WqpLFg);
	}

	// Token: 0x0400049F RID: 1183
	public int _z51McfCX7r3QwZZ2Nh78rfp6IAh;

	// Token: 0x040004A0 RID: 1184
	public bool _38qIHXlB7yTzHdLpQfiJxOul2iM;

	// Token: 0x040004A1 RID: 1185
	public bool _aapegx4D6nAePdcldcfu6WqpLFg;
}
