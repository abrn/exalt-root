using System;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x02000034 RID: 52
internal class _GPSzBI8JwQY3Ng9uzVmGvhhOW2j : IDataObject, ICloneable
{
	// Token: 0x06000293 RID: 659 RVA: 0x00012144 File Offset: 0x00010344
	public _GPSzBI8JwQY3Ng9uzVmGvhhOW2j()
	{
	}

	// Token: 0x06000294 RID: 660 RVA: 0x00012158 File Offset: 0x00010358
	public _GPSzBI8JwQY3Ng9uzVmGvhhOW2j(PacketReader r)
	{
		this._TlKWMW7v5HyfrICdamZfgb6HT48 = r.ReadString();
		this._Jp3DtIV4aAYZY26sVsXpPQjBRGO = r.ReadString();
		this._Om9UdHOBv4SCUDLfCMrntrOyTgV = r.ReadString();
		this._XcNbGF8KFT6OWFAhEJMG4X0BqNnb = r.ReadString();
		this._AcdjZgtcMgDvz2xBBNTNTMQefwBA = r.ReadInt32();
		this._Tg8iTYIY1lServzQbxJV0sBo37e = r.ReadInt32();
		this._9ovdsaR1FjGguxpBSB5I5X6FsG4 = new int[(int)r.ReadInt16()];
		for (int i = 0; i < this._9ovdsaR1FjGguxpBSB5I5X6FsG4.Length; i++)
		{
			this._9ovdsaR1FjGguxpBSB5I5X6FsG4[i] = r.ReadInt32();
		}
		this._y7YwWqs3PwwxzyrHm6LOCDBFDcr = new int[(int)r.ReadInt16()];
		for (int j = 0; j < this._y7YwWqs3PwwxzyrHm6LOCDBFDcr.Length; j++)
		{
			this._y7YwWqs3PwwxzyrHm6LOCDBFDcr[j] = r.ReadInt32();
		}
		this._Ar1aU2QFCAJ61bfpGWrVBxAFYQz = r.ReadBoolean();
		this._zUGc2omXc7QaYHHgFWUhrou0ZSP = r.ReadBoolean();
		this._OpeSsSNzQgGW8OWBP82tGD0LcqN = r.ReadBoolean();
	}

	// Token: 0x06000295 RID: 661 RVA: 0x0001223C File Offset: 0x0001043C
	public IDataObject Read(PacketReader r)
	{
		this._TlKWMW7v5HyfrICdamZfgb6HT48 = r.ReadString();
		this._Jp3DtIV4aAYZY26sVsXpPQjBRGO = r.ReadString();
		this._Om9UdHOBv4SCUDLfCMrntrOyTgV = r.ReadString();
		this._XcNbGF8KFT6OWFAhEJMG4X0BqNnb = r.ReadString();
		this._AcdjZgtcMgDvz2xBBNTNTMQefwBA = r.ReadInt32();
		this._Tg8iTYIY1lServzQbxJV0sBo37e = r.ReadInt32();
		this._9ovdsaR1FjGguxpBSB5I5X6FsG4 = new int[(int)r.ReadInt16()];
		for (int i = 0; i < this._9ovdsaR1FjGguxpBSB5I5X6FsG4.Length; i++)
		{
			this._9ovdsaR1FjGguxpBSB5I5X6FsG4[i] = r.ReadInt32();
		}
		this._y7YwWqs3PwwxzyrHm6LOCDBFDcr = new int[(int)r.ReadInt16()];
		for (int j = 0; j < this._y7YwWqs3PwwxzyrHm6LOCDBFDcr.Length; j++)
		{
			this._y7YwWqs3PwwxzyrHm6LOCDBFDcr[j] = r.ReadInt32();
		}
		this._Ar1aU2QFCAJ61bfpGWrVBxAFYQz = r.ReadBoolean();
		this._zUGc2omXc7QaYHHgFWUhrou0ZSP = r.ReadBoolean();
		this._OpeSsSNzQgGW8OWBP82tGD0LcqN = r.ReadBoolean();
		return this;
	}

	// Token: 0x06000296 RID: 662 RVA: 0x0001231C File Offset: 0x0001051C
	public void Write(PacketWriter w)
	{
		w.Write(this._TlKWMW7v5HyfrICdamZfgb6HT48);
		w.Write(this._Jp3DtIV4aAYZY26sVsXpPQjBRGO);
		w.Write(this._Om9UdHOBv4SCUDLfCMrntrOyTgV);
		w.Write(this._XcNbGF8KFT6OWFAhEJMG4X0BqNnb);
		w.Write(this._AcdjZgtcMgDvz2xBBNTNTMQefwBA);
		w.Write(this._Tg8iTYIY1lServzQbxJV0sBo37e);
		w.Write((short)this._9ovdsaR1FjGguxpBSB5I5X6FsG4.Length);
		foreach (int value in this._9ovdsaR1FjGguxpBSB5I5X6FsG4)
		{
			w.Write(value);
		}
		w.Write((short)this._y7YwWqs3PwwxzyrHm6LOCDBFDcr.Length);
		foreach (int value2 in this._y7YwWqs3PwwxzyrHm6LOCDBFDcr)
		{
			w.Write(value2);
		}
		w.Write(this._Ar1aU2QFCAJ61bfpGWrVBxAFYQz);
		w.Write(this._zUGc2omXc7QaYHHgFWUhrou0ZSP);
		w.Write(this._OpeSsSNzQgGW8OWBP82tGD0LcqN);
	}

	// Token: 0x06000297 RID: 663 RVA: 0x000123F4 File Offset: 0x000105F4
	public object Clone()
	{
		return new _GPSzBI8JwQY3Ng9uzVmGvhhOW2j
		{
			_TlKWMW7v5HyfrICdamZfgb6HT48 = this._TlKWMW7v5HyfrICdamZfgb6HT48,
			_Jp3DtIV4aAYZY26sVsXpPQjBRGO = this._Jp3DtIV4aAYZY26sVsXpPQjBRGO,
			_Om9UdHOBv4SCUDLfCMrntrOyTgV = this._Om9UdHOBv4SCUDLfCMrntrOyTgV,
			_9ovdsaR1FjGguxpBSB5I5X6FsG4 = this._9ovdsaR1FjGguxpBSB5I5X6FsG4,
			_y7YwWqs3PwwxzyrHm6LOCDBFDcr = this._y7YwWqs3PwwxzyrHm6LOCDBFDcr,
			_Ar1aU2QFCAJ61bfpGWrVBxAFYQz = this._Ar1aU2QFCAJ61bfpGWrVBxAFYQz,
			_zUGc2omXc7QaYHHgFWUhrou0ZSP = this._zUGc2omXc7QaYHHgFWUhrou0ZSP,
			_Tg8iTYIY1lServzQbxJV0sBo37e = this._Tg8iTYIY1lServzQbxJV0sBo37e,
			_OpeSsSNzQgGW8OWBP82tGD0LcqN = this._OpeSsSNzQgGW8OWBP82tGD0LcqN
		};
	}

	// Token: 0x06000298 RID: 664 RVA: 0x00012474 File Offset: 0x00010674
	public virtual string _Ye7Bzeo9ipi3HJQJeW2fYB88LbJ()
	{
		string format = "{{ Id={0}, Name={1}, Description={2}, Requirements={3}, Rewards={4}, Completed={5}, ItemOfChoice={6}, Category={7}, Repeatable={8} }}";
		object[] array = new object[9];
		array[0] = this._TlKWMW7v5HyfrICdamZfgb6HT48;
		array[1] = this._Jp3DtIV4aAYZY26sVsXpPQjBRGO;
		array[2] = this._Om9UdHOBv4SCUDLfCMrntrOyTgV;
		array[3] = this._9ovdsaR1FjGguxpBSB5I5X6FsG4.Select(new Func<int, string>(_GPSzBI8JwQY3Ng9uzVmGvhhOW2j._GYJmU8hQEJPmGYp7SJwgf5eQ4OC.<>9._PCrywubQXywmcFZI4dlfrpiB8uD));
		array[4] = this._y7YwWqs3PwwxzyrHm6LOCDBFDcr.Select(new Func<int, string>(_GPSzBI8JwQY3Ng9uzVmGvhhOW2j._GYJmU8hQEJPmGYp7SJwgf5eQ4OC.<>9._I7o9HUY29KJTSe8PrAjuKpHo1UD));
		array[5] = this._Ar1aU2QFCAJ61bfpGWrVBxAFYQz;
		array[6] = this._zUGc2omXc7QaYHHgFWUhrou0ZSP;
		array[7] = this._Tg8iTYIY1lServzQbxJV0sBo37e;
		array[8] = this._OpeSsSNzQgGW8OWBP82tGD0LcqN;
		return string.Format(format, array);
	}

	// Token: 0x04000358 RID: 856
	public string _TlKWMW7v5HyfrICdamZfgb6HT48;

	// Token: 0x04000359 RID: 857
	public string _Jp3DtIV4aAYZY26sVsXpPQjBRGO;

	// Token: 0x0400035A RID: 858
	public string _Om9UdHOBv4SCUDLfCMrntrOyTgV;

	// Token: 0x0400035B RID: 859
	public string _XcNbGF8KFT6OWFAhEJMG4X0BqNnb;

	// Token: 0x0400035C RID: 860
	public int[] _9ovdsaR1FjGguxpBSB5I5X6FsG4;

	// Token: 0x0400035D RID: 861
	public int[] _y7YwWqs3PwwxzyrHm6LOCDBFDcr;

	// Token: 0x0400035E RID: 862
	public bool _Ar1aU2QFCAJ61bfpGWrVBxAFYQz;

	// Token: 0x0400035F RID: 863
	public bool _zUGc2omXc7QaYHHgFWUhrou0ZSP;

	// Token: 0x04000360 RID: 864
	public bool _OpeSsSNzQgGW8OWBP82tGD0LcqN;

	// Token: 0x04000361 RID: 865
	public int _Tg8iTYIY1lServzQbxJV0sBo37e;

	// Token: 0x04000362 RID: 866
	public int _AcdjZgtcMgDvz2xBBNTNTMQefwBA;

	// Token: 0x02000035 RID: 53
	[CompilerGenerated]
	[Serializable]
	private sealed class _GYJmU8hQEJPmGYp7SJwgf5eQ4OC
	{
		// Token: 0x0600029B RID: 667 RVA: 0x0001256C File Offset: 0x0001076C
		internal string _PCrywubQXywmcFZI4dlfrpiB8uD(int x)
		{
			return x.ToString() + " ";
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0001258C File Offset: 0x0001078C
		internal string _I7o9HUY29KJTSe8PrAjuKpHo1UD(int x)
		{
			return x.ToString() + " ";
		}

		// Token: 0x04000363 RID: 867
		public static readonly _GPSzBI8JwQY3Ng9uzVmGvhhOW2j._GYJmU8hQEJPmGYp7SJwgf5eQ4OC <>9 = new _GPSzBI8JwQY3Ng9uzVmGvhhOW2j._GYJmU8hQEJPmGYp7SJwgf5eQ4OC();

		// Token: 0x04000364 RID: 868
		public static Func<int, string> <>9__16_0;

		// Token: 0x04000365 RID: 869
		public static Func<int, string> <>9__16_1;
	}
}
