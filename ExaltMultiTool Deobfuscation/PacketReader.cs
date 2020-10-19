using System;
using System.IO;
using System.Net;
using System.Text;

// Token: 0x0200002A RID: 42
internal class PacketReader : BinaryReader
{
	// Token: 0x0600024D RID: 589 RVA: 0x00010C94 File Offset: 0x0000EE94
	public PacketReader(MemoryStream input) : base(input, Encoding.UTF8)
	{
	}

	// Token: 0x0600024E RID: 590 RVA: 0x00010CB0 File Offset: 0x0000EEB0
	public override short ReadInt16()
	{
		return IPAddress.NetworkToHostOrder(base.ReadInt16());
	}

	// Token: 0x0600024F RID: 591 RVA: 0x00010CC8 File Offset: 0x0000EEC8
	public override ushort ReadUInt16()
	{
		return (ushort)IPAddress.NetworkToHostOrder((short)base.ReadUInt16());
	}

	// Token: 0x06000250 RID: 592 RVA: 0x00010CE4 File Offset: 0x0000EEE4
	public override int ReadInt32()
	{
		return IPAddress.NetworkToHostOrder(base.ReadInt32());
	}

	// Token: 0x06000251 RID: 593 RVA: 0x00010CFC File Offset: 0x0000EEFC
	public override float ReadSingle()
	{
		byte[] array = base.ReadBytes(4);
		Array.Reverse(array);
		return BitConverter.ToSingle(array, 0);
	}

	// Token: 0x06000252 RID: 594 RVA: 0x00010D1C File Offset: 0x0000EF1C
	public override string ReadString()
	{
		return Encoding.UTF8.GetString(this.ReadBytes((int)this.ReadInt16()));
	}

	// Token: 0x06000253 RID: 595 RVA: 0x00010D40 File Offset: 0x0000EF40
	public string ReadUTF32()
	{
		return Encoding.UTF8.GetString(this.ReadBytes(this.ReadInt32()));
	}
}
