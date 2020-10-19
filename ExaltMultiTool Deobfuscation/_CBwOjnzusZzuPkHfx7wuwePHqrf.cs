using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000097 RID: 151
internal class _CBwOjnzusZzuPkHfx7wuwePHqrf : Packet
{
	// Token: 0x17000130 RID: 304
	// (get) Token: 0x06000433 RID: 1075 RVA: 0x000168F4 File Offset: 0x00014AF4
	public override PacketType Type
	{
		get
		{
			return PacketType.TEXT;
		}
	}

	// Token: 0x06000434 RID: 1076 RVA: 0x00016904 File Offset: 0x00014B04
	public override void Read(PacketReader r)
	{
		this._Jp3DtIV4aAYZY26sVsXpPQjBRGO = r.ReadString();
		this._605Ligxeaj9k9kBV8zQhhFhgTGl = r.ReadInt32();
		this._VOCc8CZlF3S0HMq8xxgy2zaOkBn = r.ReadInt32();
		this._JHXpKzQHnmOcdCEJpRB60tA2vOG = r.ReadByte();
		this._TL2Ac3BFZHvDuoDwJImuUlObseO = r.ReadString();
		this._IDtpCgDjmC1AQOcZCJSFNAYjlbH = r.ReadString();
		this._TYWwSeph7gPoT0Ukf1ixUStS9bD = r.ReadString();
		this._7aaeGo9X4ira5unF4mlb9bO6o9E = r.ReadBoolean();
		this._xsSItsJYN74QDLyhGetUE9glrgy = r.ReadInt32();
	}

	// Token: 0x06000435 RID: 1077 RVA: 0x00016980 File Offset: 0x00014B80
	public override void Write(PacketWriter w)
	{
		w.Write(this._Jp3DtIV4aAYZY26sVsXpPQjBRGO);
		w.Write(this._605Ligxeaj9k9kBV8zQhhFhgTGl);
		w.Write(this._VOCc8CZlF3S0HMq8xxgy2zaOkBn);
		w.Write(this._JHXpKzQHnmOcdCEJpRB60tA2vOG);
		w.Write(this._TL2Ac3BFZHvDuoDwJImuUlObseO);
		w.Write(this._IDtpCgDjmC1AQOcZCJSFNAYjlbH);
		w.Write(this._TYWwSeph7gPoT0Ukf1ixUStS9bD);
		w.Write(this._7aaeGo9X4ira5unF4mlb9bO6o9E);
		w.Write(this._xsSItsJYN74QDLyhGetUE9glrgy);
	}

	// Token: 0x06000436 RID: 1078 RVA: 0x000169FC File Offset: 0x00014BFC
	public static _CBwOjnzusZzuPkHfx7wuwePHqrf _mUSCETHrZHWd7DqaW04ilsvEbiCA(string sender, string message)
	{
		_CBwOjnzusZzuPkHfx7wuwePHqrf cbwOjnzusZzuPkHfx7wuwePHqrf = (_CBwOjnzusZzuPkHfx7wuwePHqrf)Packet.Create(PacketType.TEXT);
		cbwOjnzusZzuPkHfx7wuwePHqrf._JHXpKzQHnmOcdCEJpRB60tA2vOG = 0;
		cbwOjnzusZzuPkHfx7wuwePHqrf._TYWwSeph7gPoT0Ukf1ixUStS9bD = message;
		cbwOjnzusZzuPkHfx7wuwePHqrf._Jp3DtIV4aAYZY26sVsXpPQjBRGO = "";
		cbwOjnzusZzuPkHfx7wuwePHqrf._VOCc8CZlF3S0HMq8xxgy2zaOkBn = -1;
		cbwOjnzusZzuPkHfx7wuwePHqrf._605Ligxeaj9k9kBV8zQhhFhgTGl = -1;
		cbwOjnzusZzuPkHfx7wuwePHqrf._TL2Ac3BFZHvDuoDwJImuUlObseO = "";
		cbwOjnzusZzuPkHfx7wuwePHqrf._IDtpCgDjmC1AQOcZCJSFNAYjlbH = (string.IsNullOrEmpty(sender) ? message : ("<" + sender + "> " + message));
		return cbwOjnzusZzuPkHfx7wuwePHqrf;
	}

	// Token: 0x06000437 RID: 1079 RVA: 0x00016A68 File Offset: 0x00014C68
	public static _CBwOjnzusZzuPkHfx7wuwePHqrf _FqfB8lZabDqgXbSDkwlX4ALcdCp(string message)
	{
		_CBwOjnzusZzuPkHfx7wuwePHqrf cbwOjnzusZzuPkHfx7wuwePHqrf = Packet._queixqbllHBpUVN7AOyM0TqcZNH<_CBwOjnzusZzuPkHfx7wuwePHqrf>(PacketType.TEXT);
		cbwOjnzusZzuPkHfx7wuwePHqrf._JHXpKzQHnmOcdCEJpRB60tA2vOG = 0;
		cbwOjnzusZzuPkHfx7wuwePHqrf._TYWwSeph7gPoT0Ukf1ixUStS9bD = message;
		cbwOjnzusZzuPkHfx7wuwePHqrf._Jp3DtIV4aAYZY26sVsXpPQjBRGO = string.Empty;
		cbwOjnzusZzuPkHfx7wuwePHqrf._VOCc8CZlF3S0HMq8xxgy2zaOkBn = -1;
		cbwOjnzusZzuPkHfx7wuwePHqrf._605Ligxeaj9k9kBV8zQhhFhgTGl = -1;
		cbwOjnzusZzuPkHfx7wuwePHqrf._TL2Ac3BFZHvDuoDwJImuUlObseO = string.Empty;
		cbwOjnzusZzuPkHfx7wuwePHqrf._IDtpCgDjmC1AQOcZCJSFNAYjlbH = message;
		return cbwOjnzusZzuPkHfx7wuwePHqrf;
	}

	// Token: 0x04000567 RID: 1383
	public string _Jp3DtIV4aAYZY26sVsXpPQjBRGO;

	// Token: 0x04000568 RID: 1384
	public int _605Ligxeaj9k9kBV8zQhhFhgTGl;

	// Token: 0x04000569 RID: 1385
	public int _VOCc8CZlF3S0HMq8xxgy2zaOkBn;

	// Token: 0x0400056A RID: 1386
	public byte _JHXpKzQHnmOcdCEJpRB60tA2vOG;

	// Token: 0x0400056B RID: 1387
	public string _TL2Ac3BFZHvDuoDwJImuUlObseO;

	// Token: 0x0400056C RID: 1388
	public string _IDtpCgDjmC1AQOcZCJSFNAYjlbH;

	// Token: 0x0400056D RID: 1389
	public string _TYWwSeph7gPoT0Ukf1ixUStS9bD;

	// Token: 0x0400056E RID: 1390
	public bool _7aaeGo9X4ira5unF4mlb9bO6o9E;

	// Token: 0x0400056F RID: 1391
	public int _xsSItsJYN74QDLyhGetUE9glrgy;
}
