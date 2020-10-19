using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000059 RID: 89
internal class _FcecAoLgSn3EW3xLxrLFCvci1zaA : Packet
{
	// Token: 0x170000F2 RID: 242
	// (get) Token: 0x06000338 RID: 824 RVA: 0x000141B4 File Offset: 0x000123B4
	public override PacketType Type
	{
		get
		{
			return PacketType.JOINGUILD;
		}
	}

	// Token: 0x06000339 RID: 825 RVA: 0x000141C4 File Offset: 0x000123C4
	public override void Read(PacketReader r)
	{
		this._nnw4mIJ2qnTBfbumuZegfJw1qcX = r.ReadString();
	}

	// Token: 0x0600033A RID: 826 RVA: 0x000141E0 File Offset: 0x000123E0
	public override void Write(PacketWriter w)
	{
		w.Write(this._nnw4mIJ2qnTBfbumuZegfJw1qcX);
	}

	// Token: 0x0400049C RID: 1180
	public string _nnw4mIJ2qnTBfbumuZegfJw1qcX;
}
