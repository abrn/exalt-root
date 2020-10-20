using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x0200004C RID: 76
internal class CreatePacket : Packet
{
	// Token: 0x170000E5 RID: 229
	// (get) Token: 0x06000304 RID: 772 RVA: 0x00013A7C File Offset: 0x00011C7C
	public override PacketType Type
	{
		get
		{
			return PacketType.CREATE;
		}
	}

	// Token: 0x06000305 RID: 773 RVA: 0x00013A8C File Offset: 0x00011C8C
	public override void Read(PacketReader r)
	{
		this.ClassType = r.ReadInt16();
		this.SkinType = r.ReadInt16();
		this.IsChallenger = r.ReadBoolean();
	}

	// Token: 0x06000306 RID: 774 RVA: 0x00013AC0 File Offset: 0x00011CC0
	public override void Write(PacketWriter w)
	{
		w.Write(this.ClassType);
		w.Write(this.SkinType);
		w.Write(this.IsChallenger);
	}

	// Token: 0x04000475 RID: 1141
	public short ClassType;

	// Token: 0x04000476 RID: 1142
	public short SkinType;

	// Token: 0x04000477 RID: 1143
	public bool IsChallenger;
}
