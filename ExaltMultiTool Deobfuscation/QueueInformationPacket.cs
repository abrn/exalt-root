using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000090 RID: 144
internal class QueueInformationPacket : Packet
{
	// Token: 0x17000129 RID: 297
	// (get) Token: 0x06000416 RID: 1046 RVA: 0x00016220 File Offset: 0x00014420
	public override PacketType Type
	{
		get
		{
			return PacketType.QUEUEINFORMATION;
		}
	}

	// Token: 0x06000417 RID: 1047 RVA: 0x00016230 File Offset: 0x00014430
	public override void Read(PacketReader r)
	{
		this.CurrentPosition = r.ReadUInt16();
		this.MaxPosition = r.ReadUInt16();
	}

	// Token: 0x06000418 RID: 1048 RVA: 0x00016258 File Offset: 0x00014458
	public override void Write(PacketWriter w)
	{
		w.Write(this.CurrentPosition);
		w.Write(this.MaxPosition);
	}

	// Token: 0x04000541 RID: 1345
	public ushort CurrentPosition;

	// Token: 0x04000542 RID: 1346
	public ushort MaxPosition;
}
