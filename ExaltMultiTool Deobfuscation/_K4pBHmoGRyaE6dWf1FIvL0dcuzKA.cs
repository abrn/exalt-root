using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x0200006E RID: 110
internal class _K4pBHmoGRyaE6dWf1FIvL0dcuzKA : Packet
{
	// Token: 0x17000107 RID: 263
	// (get) Token: 0x0600038C RID: 908 RVA: 0x00014BB8 File Offset: 0x00012DB8
	public override PacketType Type
	{
		get
		{
			return PacketType.ACCOUNTLIST;
		}
	}

	// Token: 0x0600038D RID: 909 RVA: 0x00014BC8 File Offset: 0x00012DC8
	public override void Read(PacketReader r)
	{
		this._OwuaUDh0iAfRHavUKndlQVgxohF = r.ReadInt32();
		this._W6ULZ8o75Cc8MbI64rdutLQMCgh = new string[(int)r.ReadInt16()];
		for (int i = 0; i < this._W6ULZ8o75Cc8MbI64rdutLQMCgh.Length; i++)
		{
			this._W6ULZ8o75Cc8MbI64rdutLQMCgh[i] = r.ReadString();
		}
		this._yiFGOqP3rABlaT2CYN2FqpkJwUZ = r.ReadInt32();
	}

	// Token: 0x0600038E RID: 910 RVA: 0x00014C20 File Offset: 0x00012E20
	public override void Write(PacketWriter w)
	{
		w.Write(this._OwuaUDh0iAfRHavUKndlQVgxohF);
		w.Write((short)this._W6ULZ8o75Cc8MbI64rdutLQMCgh.Length);
		foreach (string value in this._W6ULZ8o75Cc8MbI64rdutLQMCgh)
		{
			w.Write(value);
		}
		w.Write(this._yiFGOqP3rABlaT2CYN2FqpkJwUZ);
	}

	// Token: 0x040004CE RID: 1230
	public int _OwuaUDh0iAfRHavUKndlQVgxohF;

	// Token: 0x040004CF RID: 1231
	public string[] _W6ULZ8o75Cc8MbI64rdutLQMCgh;

	// Token: 0x040004D0 RID: 1232
	public int _yiFGOqP3rABlaT2CYN2FqpkJwUZ;
}
