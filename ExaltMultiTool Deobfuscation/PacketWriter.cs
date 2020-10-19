using System;
using System.IO;
using System.Net;
using System.Text;

// Token: 0x0200002B RID: 43
internal class PacketWriter : BinaryWriter
{
	// Token: 0x06000254 RID: 596 RVA: 0x00010D64 File Offset: 0x0000EF64
	public PacketWriter(MemoryStream input) : base(input)
	{
	}

	// Token: 0x06000255 RID: 597 RVA: 0x00010D78 File Offset: 0x0000EF78
	public override void Write(short value)
	{
		base.Write(IPAddress.NetworkToHostOrder(value));
	}

	// Token: 0x06000256 RID: 598 RVA: 0x00010D94 File Offset: 0x0000EF94
	public override void Write(ushort value)
	{
		base.Write((ushort)IPAddress.HostToNetworkOrder((short)value));
	}

	// Token: 0x06000257 RID: 599 RVA: 0x00010DB0 File Offset: 0x0000EFB0
	public override void Write(int value)
	{
		base.Write(IPAddress.NetworkToHostOrder(value));
	}

	// Token: 0x06000258 RID: 600 RVA: 0x00010DCC File Offset: 0x0000EFCC
	public override void Write(float value)
	{
		byte[] bytes = BitConverter.GetBytes(value);
		Array.Reverse(bytes);
		base.Write(bytes);
	}

	// Token: 0x06000259 RID: 601 RVA: 0x00010DF0 File Offset: 0x0000EFF0
	public override void Write(string value)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(value);
		this.Write((short)bytes.Length);
		base.Write(bytes);
	}

	// Token: 0x0600025A RID: 602 RVA: 0x00010E1C File Offset: 0x0000F01C
	public void WriteUTF32(string value)
	{
		this.Write(value.Length);
		this.Write(Encoding.UTF8.GetBytes(value));
	}

	// Token: 0x0600025B RID: 603 RVA: 0x00010E48 File Offset: 0x0000F048
	public static void BlockCopyInt32(byte[] data, int int32)
	{
		byte[] bytes = BitConverter.GetBytes(IPAddress.NetworkToHostOrder(int32));
		data[0] = bytes[0];
		data[1] = bytes[1];
		data[2] = bytes[2];
		data[3] = bytes[3];
	}
}
