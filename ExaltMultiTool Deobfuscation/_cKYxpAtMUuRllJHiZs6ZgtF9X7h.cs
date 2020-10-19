using System;
using System.Text;

// Token: 0x02000024 RID: 36
internal class RC4Cipher
{
	// Token: 0x0600021B RID: 539 RVA: 0x0000F3DC File Offset: 0x0000D5DC
	public RC4Cipher(byte[] key)
	{
		this._8UNCV66azHilTrhcYMDL7JNtlZA = key;
		this._4oJ0K5rvGnuL0HzdQbridv7Wd0o(this._8UNCV66azHilTrhcYMDL7JNtlZA);
	}

	// Token: 0x0600021C RID: 540 RVA: 0x0000F404 File Offset: 0x0000D604
	public RC4Cipher(string hexString)
	{
		this._8UNCV66azHilTrhcYMDL7JNtlZA = RC4Cipher._kRu14g6KBH76jITAyQyaYnqckKG(hexString);
		this._4oJ0K5rvGnuL0HzdQbridv7Wd0o(this._8UNCV66azHilTrhcYMDL7JNtlZA);
	}

	// Token: 0x0600021D RID: 541 RVA: 0x0000F430 File Offset: 0x0000D630
	public void Cipher(byte[] packet)
	{
		this._haSsoozblfsY8Znc59CzuBL9V6t(packet, 5, packet.Length - 5, packet, 5);
	}

	// Token: 0x0600021E RID: 542 RVA: 0x0000F44C File Offset: 0x0000D64C
	public void _smnmslTWWiECC2NFEBMTr1MiokW()
	{
		this._4oJ0K5rvGnuL0HzdQbridv7Wd0o(this._8UNCV66azHilTrhcYMDL7JNtlZA);
	}

	// Token: 0x0600021F RID: 543 RVA: 0x0000F468 File Offset: 0x0000D668
	private void _haSsoozblfsY8Znc59CzuBL9V6t(byte[] input, int inOff, int length, byte[] output, int outOff)
	{
		for (int i = 0; i < length; i++)
		{
			this._G5Ra9WHarLJVuCRS9jeiAHiryFy = (this._G5Ra9WHarLJVuCRS9jeiAHiryFy + 1 & 255);
			this._pe9mbYpp0zEChw9jkGSHmUKGlXh = ((int)this._m6bO6p7ecPFnroWoAoUj3dPm4tq[this._G5Ra9WHarLJVuCRS9jeiAHiryFy] + this._pe9mbYpp0zEChw9jkGSHmUKGlXh & 255);
			byte b = this._m6bO6p7ecPFnroWoAoUj3dPm4tq[this._G5Ra9WHarLJVuCRS9jeiAHiryFy];
			this._m6bO6p7ecPFnroWoAoUj3dPm4tq[this._G5Ra9WHarLJVuCRS9jeiAHiryFy] = this._m6bO6p7ecPFnroWoAoUj3dPm4tq[this._pe9mbYpp0zEChw9jkGSHmUKGlXh];
			this._m6bO6p7ecPFnroWoAoUj3dPm4tq[this._pe9mbYpp0zEChw9jkGSHmUKGlXh] = b;
			output[i + outOff] = (input[i + inOff] ^ this._m6bO6p7ecPFnroWoAoUj3dPm4tq[(int)(this._m6bO6p7ecPFnroWoAoUj3dPm4tq[this._G5Ra9WHarLJVuCRS9jeiAHiryFy] + this._m6bO6p7ecPFnroWoAoUj3dPm4tq[this._pe9mbYpp0zEChw9jkGSHmUKGlXh] & byte.MaxValue)]);
		}
	}

	// Token: 0x06000220 RID: 544 RVA: 0x0000F528 File Offset: 0x0000D728
	private void _4oJ0K5rvGnuL0HzdQbridv7Wd0o(byte[] keyBytes)
	{
		this._8UNCV66azHilTrhcYMDL7JNtlZA = keyBytes;
		this._pe9mbYpp0zEChw9jkGSHmUKGlXh = 0;
		this._G5Ra9WHarLJVuCRS9jeiAHiryFy = 0;
		if (this._m6bO6p7ecPFnroWoAoUj3dPm4tq == null)
		{
			this._m6bO6p7ecPFnroWoAoUj3dPm4tq = new byte[RC4Cipher._wmtB5WOwU3bDlzAJN0Becx6RWChA];
		}
		for (int i = 0; i < RC4Cipher._wmtB5WOwU3bDlzAJN0Becx6RWChA; i++)
		{
			this._m6bO6p7ecPFnroWoAoUj3dPm4tq[i] = (byte)i;
		}
		int num = 0;
		int num2 = 0;
		for (int j = 0; j < RC4Cipher._wmtB5WOwU3bDlzAJN0Becx6RWChA; j++)
		{
			num2 = ((int)((keyBytes[num] & byte.MaxValue) + this._m6bO6p7ecPFnroWoAoUj3dPm4tq[j]) + num2 & 255);
			byte b = this._m6bO6p7ecPFnroWoAoUj3dPm4tq[j];
			this._m6bO6p7ecPFnroWoAoUj3dPm4tq[j] = this._m6bO6p7ecPFnroWoAoUj3dPm4tq[num2];
			this._m6bO6p7ecPFnroWoAoUj3dPm4tq[num2] = b;
			num = (num + 1) % keyBytes.Length;
		}
	}

	// Token: 0x06000221 RID: 545 RVA: 0x0000F5E0 File Offset: 0x0000D7E0
	public static byte[] _kRu14g6KBH76jITAyQyaYnqckKG(string key)
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
	private static readonly int _wmtB5WOwU3bDlzAJN0Becx6RWChA = 256;

	// Token: 0x04000272 RID: 626
	private byte[] _m6bO6p7ecPFnroWoAoUj3dPm4tq;

	// Token: 0x04000273 RID: 627
	private int _G5Ra9WHarLJVuCRS9jeiAHiryFy;

	// Token: 0x04000274 RID: 628
	private int _pe9mbYpp0zEChw9jkGSHmUKGlXh;

	// Token: 0x04000275 RID: 629
	private byte[] _8UNCV66azHilTrhcYMDL7JNtlZA;
}
