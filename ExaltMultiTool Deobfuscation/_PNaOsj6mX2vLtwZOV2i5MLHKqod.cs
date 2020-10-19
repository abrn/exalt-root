using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x0200007B RID: 123
internal class _PNaOsj6mX2vLtwZOV2i5MLHKqod : Packet
{
	// Token: 0x17000114 RID: 276
	// (get) Token: 0x060003C0 RID: 960 RVA: 0x00015518 File Offset: 0x00013718
	public override PacketType Type
	{
		get
		{
			return PacketType.FILE;
		}
	}

	// Token: 0x060003C1 RID: 961 RVA: 0x00015528 File Offset: 0x00013728
	public override void Read(PacketReader r)
	{
		this._Jp3DtIV4aAYZY26sVsXpPQjBRGO = r.ReadString();
		this._qPglBWUh800LD2zOUBKLzdmDNXl = new byte[r.ReadInt32()];
		this._qPglBWUh800LD2zOUBKLzdmDNXl = r.ReadBytes(this._qPglBWUh800LD2zOUBKLzdmDNXl.Length);
	}

	// Token: 0x060003C2 RID: 962 RVA: 0x00015568 File Offset: 0x00013768
	public override void Write(PacketWriter w)
	{
		w.Write(this._Jp3DtIV4aAYZY26sVsXpPQjBRGO);
		w.Write(this._qPglBWUh800LD2zOUBKLzdmDNXl.Length);
		w.Write(this._qPglBWUh800LD2zOUBKLzdmDNXl);
	}

	// Token: 0x04000506 RID: 1286
	public string _Jp3DtIV4aAYZY26sVsXpPQjBRGO;

	// Token: 0x04000507 RID: 1287
	public byte[] _qPglBWUh800LD2zOUBKLzdmDNXl;
}
