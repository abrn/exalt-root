using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000070 RID: 112
internal class _PQHQze9k9pObME2LmlIcbfEeSYS : Packet
{
	// Token: 0x17000109 RID: 265
	// (get) Token: 0x06000394 RID: 916 RVA: 0x00014D44 File Offset: 0x00012F44
	public override PacketType Type
	{
		get
		{
			return PacketType.AOE;
		}
	}

	// Token: 0x06000395 RID: 917 RVA: 0x00014D54 File Offset: 0x00012F54
	public override void Read(PacketReader r)
	{
		this._v9pyCwpTOdm9mtxft8q4OoLOE3B = new Location(r);
		this._Vzv7oRwBjKStnFVmjJ1K02kmfeb = r.ReadSingle();
		this._Q1PiJQ99KBCJeLcZ0HOk3AUAjIP = r.ReadUInt16();
		this._xRou6pLb1OAINZAI0Yki8s1brKc = (_MfAkBOGBLRiw9NYYbzHg9B0r0ip)r.ReadByte();
		this._6HSWlrLBerFgfLyTHogEOZHUTTw = r.ReadSingle();
		this._KAKiJQlm5UYoc2K2Kaz3qKefgXA = r.ReadUInt16();
		this._DFCaX26LcGoemsDXfEoR4O7im9r = r.ReadInt32();
		this._cOOwLggepjcumTMmHiNjo8G61wH = r.ReadBoolean();
	}

	// Token: 0x06000396 RID: 918 RVA: 0x00014DC4 File Offset: 0x00012FC4
	public override void Write(PacketWriter w)
	{
		this._v9pyCwpTOdm9mtxft8q4OoLOE3B.Write(w);
		w.Write(this._Vzv7oRwBjKStnFVmjJ1K02kmfeb);
		w.Write(this._Q1PiJQ99KBCJeLcZ0HOk3AUAjIP);
		w.Write((byte)this._xRou6pLb1OAINZAI0Yki8s1brKc);
		w.Write(this._6HSWlrLBerFgfLyTHogEOZHUTTw);
		w.Write(this._KAKiJQlm5UYoc2K2Kaz3qKefgXA);
		w.Write(this._DFCaX26LcGoemsDXfEoR4O7im9r);
		w.Write(this._cOOwLggepjcumTMmHiNjo8G61wH);
	}

	// Token: 0x040004D6 RID: 1238
	public Location _v9pyCwpTOdm9mtxft8q4OoLOE3B;

	// Token: 0x040004D7 RID: 1239
	public float _Vzv7oRwBjKStnFVmjJ1K02kmfeb;

	// Token: 0x040004D8 RID: 1240
	public ushort _Q1PiJQ99KBCJeLcZ0HOk3AUAjIP;

	// Token: 0x040004D9 RID: 1241
	public _MfAkBOGBLRiw9NYYbzHg9B0r0ip _xRou6pLb1OAINZAI0Yki8s1brKc;

	// Token: 0x040004DA RID: 1242
	public float _6HSWlrLBerFgfLyTHogEOZHUTTw;

	// Token: 0x040004DB RID: 1243
	public ushort _KAKiJQlm5UYoc2K2Kaz3qKefgXA;

	// Token: 0x040004DC RID: 1244
	public int _DFCaX26LcGoemsDXfEoR4O7im9r;

	// Token: 0x040004DD RID: 1245
	public bool _cOOwLggepjcumTMmHiNjo8G61wH;
}
