using System;

// Token: 0x02000027 RID: 39
internal class PacketBuffer
{
	// Token: 0x0600023D RID: 573 RVA: 0x000107DC File Offset: 0x0000E9DC
	public PacketBuffer()
	{
		this.Bytes = new byte[4];
	}

	// Token: 0x0600023E RID: 574 RVA: 0x000107FC File Offset: 0x0000E9FC
	public void Resize(int newSize)
	{
		if (newSize > 1048576)
		{
			throw new ArgumentException("New buffer size is too large");
		}
		byte[] bytes = this.Bytes;
		this.Bytes = new byte[newSize];
		this.Bytes[0] = bytes[0];
		this.Bytes[1] = bytes[1];
		this.Bytes[2] = bytes[2];
		this.Bytes[3] = bytes[3];
	}

	// Token: 0x0600023F RID: 575 RVA: 0x0001085C File Offset: 0x0000EA5C
	public void Advance(int numBytes)
	{
		this.Index += numBytes;
	}

	// Token: 0x06000240 RID: 576 RVA: 0x00010878 File Offset: 0x0000EA78
	public void Reset()
	{
		this.Bytes = new byte[4];
		this.Index = 0;
	}

	// Token: 0x06000241 RID: 577 RVA: 0x00010898 File Offset: 0x0000EA98
	public int BytesRemaining()
	{
		return this.Bytes.Length - this.Index;
	}

	// Token: 0x06000242 RID: 578 RVA: 0x000108B4 File Offset: 0x0000EAB4
	public void Dispose()
	{
		this.Bytes = null;
	}

	// Token: 0x040002AB RID: 683
	public int Index;

	// Token: 0x040002AC RID: 684
	public byte[] Bytes;
}
