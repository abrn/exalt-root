using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x0200004E RID: 78
internal class _7k8aOfI7MhNrVnHioUXbsPAxkbm : Packet
{
	// Token: 0x170000E7 RID: 231
	// (get) Token: 0x0600030C RID: 780 RVA: 0x00013B94 File Offset: 0x00011D94
	public override PacketType Type
	{
		get
		{
			return PacketType.ENEMYHIT;
		}
	}

	// Token: 0x0600030D RID: 781 RVA: 0x00013BA4 File Offset: 0x00011DA4
	public override void Read(PacketReader r)
	{
		this._Nx46RcGIU0H1BCGWaJXjN1ieopt = r.ReadInt32();
		this._0v4mmgyFOmt9eSc23UclkqyBncC = r.ReadByte();
		this._GNsbx2sQjKyCD4qK29hWl8cxeSqA = r.ReadInt32();
		this._2ngiu12rPzXamKVx8VRv7bDEspS = r.ReadBoolean();
	}

	// Token: 0x0600030E RID: 782 RVA: 0x00013BE4 File Offset: 0x00011DE4
	public override void Write(PacketWriter w)
	{
		w.Write(this._Nx46RcGIU0H1BCGWaJXjN1ieopt);
		w.Write(this._0v4mmgyFOmt9eSc23UclkqyBncC);
		w.Write(this._GNsbx2sQjKyCD4qK29hWl8cxeSqA);
		w.Write(this._2ngiu12rPzXamKVx8VRv7bDEspS);
	}

	// Token: 0x0400047B RID: 1147
	public int _Nx46RcGIU0H1BCGWaJXjN1ieopt;

	// Token: 0x0400047C RID: 1148
	public byte _0v4mmgyFOmt9eSc23UclkqyBncC;

	// Token: 0x0400047D RID: 1149
	public int _GNsbx2sQjKyCD4qK29hWl8cxeSqA;

	// Token: 0x0400047E RID: 1150
	public bool _2ngiu12rPzXamKVx8VRv7bDEspS;
}
