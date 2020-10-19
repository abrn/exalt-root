using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000088 RID: 136
internal class PasswordPromptPacket : Packet
{
	// Token: 0x17000121 RID: 289
	// (get) Token: 0x060003F6 RID: 1014 RVA: 0x00015E24 File Offset: 0x00014024
	public override PacketType Type
	{
		get
		{
			return PacketType.PASSWORDPROMPT;
		}
	}

	// Token: 0x060003F7 RID: 1015 RVA: 0x00015E34 File Offset: 0x00014034
	public override void Read(PacketReader r)
	{
		this.CleanPasswordStatus = r.ReadInt32();
	}

	// Token: 0x060003F8 RID: 1016 RVA: 0x00015E50 File Offset: 0x00014050
	public override void Write(PacketWriter w)
	{
		w.Write(this.CleanPasswordStatus);
	}

	// Token: 0x04000530 RID: 1328
	public const int SIGN_IN = 2;

	// Token: 0x04000531 RID: 1329
	public const int SEND_EMAIL_AND_SIGN_IN = 3;

	// Token: 0x04000532 RID: 1330
	public const int REGISTER = 4;

	// Token: 0x04000533 RID: 1331
	public int CleanPasswordStatus;
}
