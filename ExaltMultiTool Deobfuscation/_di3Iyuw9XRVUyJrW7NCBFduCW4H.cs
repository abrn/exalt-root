using System;

// Token: 0x0200002D RID: 45
internal class _di3Iyuw9XRVUyJrW7NCBFduCW4H
{
	// Token: 0x06000261 RID: 609 RVA: 0x00010FCC File Offset: 0x0000F1CC
	public static int _eHIpo1lHmEGnQwbA8tDvcpJtdfl(PacketReader r)
	{
		byte b = r.ReadByte();
		bool flag = (b & 64) > 0;
		byte b2 = 6;
		int num = (int)(b & 63);
		while ((b & 128) != 0)
		{
			b = r.ReadByte();
			num |= (int)(b & 127) << (int)b2;
			b2 += 7;
		}
		if (flag)
		{
			num = -num;
		}
		return num;
	}

	// Token: 0x06000262 RID: 610 RVA: 0x0001101C File Offset: 0x0000F21C
	public static void _7A7oILp80mGDmH4Uco8L8vPbaS4(PacketWriter w, int value)
	{
		bool flag = value < 0;
		uint num = (uint)(flag ? (-(uint)value) : value);
		byte b = (byte)(num & 63u);
		if (flag)
		{
			b |= 64;
		}
		num >>= 6;
		bool flag2;
		if (flag2 = (num > 0u))
		{
			b |= 128;
		}
		w.Write(b);
		while (flag2)
		{
			b = (byte)(num & 127u);
			num >>= 7;
			if (flag2 = (num > 0u))
			{
				b |= 128;
			}
			w.Write(b);
		}
	}
}
