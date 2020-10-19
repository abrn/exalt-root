using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000095 RID: 149
internal class ServerPlayerShootPacket : Packet
{
	// Token: 0x1700012E RID: 302
	// (get) Token: 0x0600042A RID: 1066 RVA: 0x000164D4 File Offset: 0x000146D4
	public override PacketType Type
	{
		get
		{
			return PacketType.SERVERPLAYERSHOOT;
		}
	}

	// Token: 0x0600042B RID: 1067 RVA: 0x000164E4 File Offset: 0x000146E4
	public override void Read(PacketReader r)
	{
		this._0v4mmgyFOmt9eSc23UclkqyBncC = r.ReadByte();
		this._o1vIAcFEkLsw697hhlSgXnC4w9g = r.ReadInt32();
		this._1hqbXYh2SXWKV5rkAtGwzNqFsAb = r.ReadInt32();
		this._b7xn6ues8h0HobnamuYX88jlY2N = new Location(r);
		this._49dbaYgeVV0XCrIkHrqAGgDf2mFA = r.ReadSingle();
		this._Q1PiJQ99KBCJeLcZ0HOk3AUAjIP = r.ReadInt16();
	}

	// Token: 0x0600042C RID: 1068 RVA: 0x0001653C File Offset: 0x0001473C
	public override void Write(PacketWriter w)
	{
		w.Write(this._0v4mmgyFOmt9eSc23UclkqyBncC);
		w.Write(this._o1vIAcFEkLsw697hhlSgXnC4w9g);
		w.Write(this._1hqbXYh2SXWKV5rkAtGwzNqFsAb);
		this._b7xn6ues8h0HobnamuYX88jlY2N.Write(w);
		w.Write(this._49dbaYgeVV0XCrIkHrqAGgDf2mFA);
		w.Write(this._Q1PiJQ99KBCJeLcZ0HOk3AUAjIP);
	}

	// Token: 0x0400054F RID: 1359
	public byte _0v4mmgyFOmt9eSc23UclkqyBncC;

	// Token: 0x04000550 RID: 1360
	public int _o1vIAcFEkLsw697hhlSgXnC4w9g;

	// Token: 0x04000551 RID: 1361
	public int _1hqbXYh2SXWKV5rkAtGwzNqFsAb;

	// Token: 0x04000552 RID: 1362
	public Location _b7xn6ues8h0HobnamuYX88jlY2N;

	// Token: 0x04000553 RID: 1363
	public float _49dbaYgeVV0XCrIkHrqAGgDf2mFA;

	// Token: 0x04000554 RID: 1364
	public short _Q1PiJQ99KBCJeLcZ0HOk3AUAjIP;
}
