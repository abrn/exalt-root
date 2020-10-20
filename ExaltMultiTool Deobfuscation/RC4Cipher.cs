using System;
using System.Text;

// Token: 0x02000024 RID: 36
internal class RC4Cipher
{
	// Token: 0x0600021B RID: 539 RVA: 0x0000F3DC File Offset: 0x0000D5DC
	public RC4Cipher(byte[] key)
	{
		this.workingKey = key;
		this.SetKey(this.workingKey);
	}

	// Token: 0x0600021C RID: 540 RVA: 0x0000F404 File Offset: 0x0000D604
	public RC4Cipher(string hexString)
	{
		this.workingKey = RC4Cipher.HexStringToBytes(hexString);
		this.SetKey(this.workingKey);
	}

	// Token: 0x0600021D RID: 541 RVA: 0x0000F430 File Offset: 0x0000D630
	public void Cipher(byte[] packet)
	{
		this.ProcessBytes(packet, 5, packet.Length - 5, packet, 5);
	}

	// Token: 0x0600021E RID: 542 RVA: 0x0000F44C File Offset: 0x0000D64C
	public void _smnmslTWWiECC2NFEBMTr1MiokW()
	{
		this.SetKey(this.workingKey);
	}

	// Token: 0x0600021F RID: 543 RVA: 0x0000F468 File Offset: 0x0000D668
	private void ProcessBytes(byte[] input, int inOff, int length, byte[] output, int outOff)
	{
		for (int i = 0; i < length; i++)
		{
			this.x = (this.x + 1 & 255);
			this.y = ((int)this.engineState[this.x] + this.y & 255);
			byte b = this.engineState[this.x];
			this.engineState[this.x] = this.engineState[this.y];
			this.engineState[this.y] = b;
			output[i + outOff] = ((byte)(input[i + inOff] ^ this.engineState[(int)(this.engineState[this.x] + this.engineState[this.y] & byte.MaxValue)]));
		}
	}

	// Token: 0x06000220 RID: 544 RVA: 0x0000F528 File Offset: 0x0000D728
	private void SetKey(byte[] keyBytes)
	{
		this.workingKey = keyBytes;
		this.y = 0;
		this.x = 0;
		if (this.engineState == null)
		{
			this.engineState = new byte[RC4Cipher.STATE_LENGTH];
		}
		for (int i = 0; i < RC4Cipher.STATE_LENGTH; i++)
		{
			this.engineState[i] = (byte)i;
		}
		int num = 0;
		int num2 = 0;
		for (int j = 0; j < RC4Cipher.STATE_LENGTH; j++)
		{
			num2 = ((int)((keyBytes[num] & byte.MaxValue) + this.engineState[j]) + num2 & 255);
			byte b = this.engineState[j];
			this.engineState[j] = this.engineState[num2];
			this.engineState[num2] = b;
			num = (num + 1) % keyBytes.Length;
		}
	}

	// Token: 0x06000221 RID: 545 RVA: 0x0000F5E0 File Offset: 0x0000D7E0
	public static byte[] HexStringToBytes(string key)
	{
		if (key.Length % 2 != 0)
		{
			throw new ArgumentException("Invalid hex string!");
		}
		byte[] array = new byte[key.Length / 2];
		char[] array2 = key.ToCharArray();
		for (int i = 0; i < array2.Length; i += 2)
		{
			int num = Convert.ToInt32(new StringBuilder(2).Append(array2[i]).Append(array2[i + 1]).ToString(), 16);
			array[i / 2] = (byte)num;
		}
		return array;
	}

	// Token: 0x04000271 RID: 625
	private static readonly int STATE_LENGTH = 256;

	// Token: 0x04000272 RID: 626
	private byte[] engineState;

	// Token: 0x04000273 RID: 627
	private int x;

	// Token: 0x04000274 RID: 628
	private int y;

	// Token: 0x04000275 RID: 629
	private byte[] workingKey;
}
