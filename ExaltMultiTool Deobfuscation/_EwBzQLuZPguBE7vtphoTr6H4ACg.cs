using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000063 RID: 99
internal class _EwBzQLuZPguBE7vtphoTr6H4ACg : Packet
{
	// Token: 0x170000FC RID: 252
	// (get) Token: 0x06000360 RID: 864 RVA: 0x0001474C File Offset: 0x0001294C
	public override PacketType Type
	{
		get
		{
			return PacketType.PONG;
		}
	}

	// Token: 0x06000361 RID: 865 RVA: 0x0001475C File Offset: 0x0001295C
	public override void Read(PacketReader r)
	{
		this._QkGLjNjXWUxjTZhmXs1sKEYLp0F = r.ReadInt32();
		this._Nx46RcGIU0H1BCGWaJXjN1ieopt = r.ReadInt32();
	}

	// Token: 0x06000362 RID: 866 RVA: 0x00014784 File Offset: 0x00012984
	public override void Write(PacketWriter w)
	{
		w.Write(this._QkGLjNjXWUxjTZhmXs1sKEYLp0F);
		w.Write(this._Nx46RcGIU0H1BCGWaJXjN1ieopt);
	}

	// Token: 0x040004BE RID: 1214
	public int _QkGLjNjXWUxjTZhmXs1sKEYLp0F;

	// Token: 0x040004BF RID: 1215
	public int _Nx46RcGIU0H1BCGWaJXjN1ieopt;
}
