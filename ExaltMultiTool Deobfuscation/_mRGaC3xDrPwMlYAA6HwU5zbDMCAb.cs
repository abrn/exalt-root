using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x0200008D RID: 141
internal class _mRGaC3xDrPwMlYAA6HwU5zbDMCAb : Packet
{
	// Token: 0x17000126 RID: 294
	// (get) Token: 0x0600040A RID: 1034 RVA: 0x00016040 File Offset: 0x00014240
	public override PacketType Type
	{
		get
		{
			return PacketType.QUESTFETCHRESPONSE;
		}
	}

	// Token: 0x0600040B RID: 1035 RVA: 0x00016050 File Offset: 0x00014250
	public override void Read(PacketReader r)
	{
		this._oGLg92ZtoDnU4GgOGVeGb3xIQ3B = new _GPSzBI8JwQY3Ng9uzVmGvhhOW2j[(int)r.ReadInt16()];
		for (int i = 0; i < this._oGLg92ZtoDnU4GgOGVeGb3xIQ3B.Length; i++)
		{
			this._oGLg92ZtoDnU4GgOGVeGb3xIQ3B[i] = new _GPSzBI8JwQY3Ng9uzVmGvhhOW2j(r);
		}
		this._nMJBcNIGuh3bdg135pLESsozDWU = r.ReadInt16();
	}

	// Token: 0x0600040C RID: 1036 RVA: 0x0001609C File Offset: 0x0001429C
	public override void Write(PacketWriter w)
	{
		w.Write((short)this._oGLg92ZtoDnU4GgOGVeGb3xIQ3B.Length);
		_GPSzBI8JwQY3Ng9uzVmGvhhOW2j[] oGLg92ZtoDnU4GgOGVeGb3xIQ3B = this._oGLg92ZtoDnU4GgOGVeGb3xIQ3B;
		for (int i = 0; i < oGLg92ZtoDnU4GgOGVeGb3xIQ3B.Length; i++)
		{
			oGLg92ZtoDnU4GgOGVeGb3xIQ3B[i].Write(w);
		}
		w.Write(this._nMJBcNIGuh3bdg135pLESsozDWU);
	}

	// Token: 0x0400053B RID: 1339
	public _GPSzBI8JwQY3Ng9uzVmGvhhOW2j[] _oGLg92ZtoDnU4GgOGVeGb3xIQ3B;

	// Token: 0x0400053C RID: 1340
	public short _nMJBcNIGuh3bdg135pLESsozDWU;
}
