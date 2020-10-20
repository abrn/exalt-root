using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x0200007B RID: 123
internal class FilePacket : Packet
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
		this.Name = r.ReadString();
		this.Bytes = new byte[r.ReadInt32()];
		this.Bytes = r.ReadBytes(this.Bytes.Length);
	}

	// Token: 0x060003C2 RID: 962 RVA: 0x00015568 File Offset: 0x00013768
	public override void Write(PacketWriter w)
	{
		w.Write(this.Name);
		w.Write(this.Bytes.Length);
		w.Write(this.Bytes);
	}

	// Token: 0x04000506 RID: 1286
	public string Name;

	// Token: 0x04000507 RID: 1287
	public byte[] Bytes;
}
