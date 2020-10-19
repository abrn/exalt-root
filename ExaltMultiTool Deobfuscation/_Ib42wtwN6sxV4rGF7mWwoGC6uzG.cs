using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x0200007A RID: 122
internal class FailurePacket : Packet
{
	// Token: 0x17000113 RID: 275
	// (get) Token: 0x060003BC RID: 956 RVA: 0x00015474 File Offset: 0x00013674
	public override PacketType Type
	{
		get
		{
			return PacketType.FAILURE;
		}
	}

	// Token: 0x060003BD RID: 957 RVA: 0x00015484 File Offset: 0x00013684
	public override void Read(PacketReader r)
	{
		this.ErrorId = r.ReadInt32();
		this.ErrorMessage = r.ReadString();
		this.ErrorPlace = r.ReadString();
		this._EDEJVnWjfttOBgpE8YLwKiMxdBn = r.ReadString();
	}

	// Token: 0x060003BE RID: 958 RVA: 0x000154C4 File Offset: 0x000136C4
	public override void Write(PacketWriter w)
	{
		w.Write(this.ErrorId);
		w.Write(this.ErrorMessage);
		w.Write(this.ErrorPlace);
		w.Write(this._EDEJVnWjfttOBgpE8YLwKiMxdBn);
	}

	// Token: 0x04000502 RID: 1282
	public int ErrorId;

	// Token: 0x04000503 RID: 1283
	public string ErrorMessage;

	// Token: 0x04000504 RID: 1284
	public string ErrorPlace;

	// Token: 0x04000505 RID: 1285
	public string _EDEJVnWjfttOBgpE8YLwKiMxdBn;
}
