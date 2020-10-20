using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000083 RID: 131
internal class NameResultPacket : Packet
{
	// Token: 0x1700011C RID: 284
	// (get) Token: 0x060003E0 RID: 992 RVA: 0x00015AE0 File Offset: 0x00013CE0
	public override PacketType Type
	{
		get
		{
			return PacketType.NAMERESULT;
		}
	}

	// Token: 0x060003E1 RID: 993 RVA: 0x00015AF0 File Offset: 0x00013CF0
	public override void Read(PacketReader r)
	{
		this.Success = r.ReadBoolean();
		this.ErrorText = r.ReadString();
	}

	// Token: 0x060003E2 RID: 994 RVA: 0x00015B18 File Offset: 0x00013D18
	public override void Write(PacketWriter w)
	{
		w.Write(this.Success);
		w.Write(this.ErrorText);
	}

	// Token: 0x04000524 RID: 1316
	public bool Success;

	// Token: 0x04000525 RID: 1317
	public string ErrorText;
}
