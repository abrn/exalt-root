using System;
using System.Reflection;
using System.Text;

// Token: 0x02000033 RID: 51
internal class _EqQZEaZX9DWa2qWU9yl21hXa9eN
{
	// Token: 0x0600028B RID: 651 RVA: 0x00011740 File Offset: 0x0000F940
	public _EqQZEaZX9DWa2qWU9yl21hXa9eN(int ownerObjectId)
	{
		this._0fGEyhVNT3zNHE6jzPplPx6jM6g = ownerObjectId;
		this._Jp3DtIV4aAYZY26sVsXpPQjBRGO = "";
	}

	// Token: 0x0600028C RID: 652 RVA: 0x000117A8 File Offset: 0x0000F9A8
	public _EqQZEaZX9DWa2qWU9yl21hXa9eN(int ownerObjectId, MapInfoPacket mapInfo)
	{
		this._0fGEyhVNT3zNHE6jzPplPx6jM6g = ownerObjectId;
		this._Jp3DtIV4aAYZY26sVsXpPQjBRGO = "";
		this._J7VwVS5qpzlByqu8B6AKwj7oO3x = mapInfo._Jp3DtIV4aAYZY26sVsXpPQjBRGO;
		this._CO0bfAMJAEfni7qUeHiAhciX55oA = mapInfo._x71SpSMNAviwa63BTEZfGszpp14;
		this._qbK2v2iN98g4OMBqAvi2oMcDXsm = mapInfo._pCEEx7DVSfoKsVtOFqw3jIq365d;
		this._6UWiEBuADteDCWXzyg9k8j5h4qZ = mapInfo._92R8iOIVdqdeKvPcqUJAUojZv04;
	}

	// Token: 0x0600028D RID: 653 RVA: 0x00011840 File Offset: 0x0000FA40
	public void _P121IKZIlX2mwLlqYE56erHJuhg(UpdatePacket update)
	{
		foreach (Entity eTOyUHUGABMgTlUf3FUyHRn1uVv in update.NewObjs)
		{
			if (eTOyUHUGABMgTlUf3FUyHRn1uVv.Status.ObjectId == this._0fGEyhVNT3zNHE6jzPplPx6jM6g)
			{
				this._mvJnAw6BUql91ryBD7pgazCL7Yd = eTOyUHUGABMgTlUf3FUyHRn1uVv.Status.Position;
				foreach (StatData eawaZQvtvbptP3yFgHw8DNBicDZ in eTOyUHUGABMgTlUf3FUyHRn1uVv.Status.Data)
				{
					this._P121IKZIlX2mwLlqYE56erHJuhg(StatsType._aB83fkaWIFXdehxJ8Dj9IX8iZ3m(eawaZQvtvbptP3yFgHw8DNBicDZ.Id), eawaZQvtvbptP3yFgHw8DNBicDZ.IntValue, eawaZQvtvbptP3yFgHw8DNBicDZ.StringValue);
				}
			}
		}
	}

	// Token: 0x0600028E RID: 654 RVA: 0x000118F8 File Offset: 0x0000FAF8
	public void _P121IKZIlX2mwLlqYE56erHJuhg(NewTickPacket newTick)
	{
		foreach (Status seOURj9wT08Ssc6bZOctUjk0KXi in newTick.Statuses)
		{
			if (seOURj9wT08Ssc6bZOctUjk0KXi.ObjectId == this._0fGEyhVNT3zNHE6jzPplPx6jM6g)
			{
				foreach (StatData eawaZQvtvbptP3yFgHw8DNBicDZ in seOURj9wT08Ssc6bZOctUjk0KXi.Data)
				{
					this._mvJnAw6BUql91ryBD7pgazCL7Yd = seOURj9wT08Ssc6bZOctUjk0KXi.Position;
					this._P121IKZIlX2mwLlqYE56erHJuhg(StatsType._aB83fkaWIFXdehxJ8Dj9IX8iZ3m(eawaZQvtvbptP3yFgHw8DNBicDZ.Id), eawaZQvtvbptP3yFgHw8DNBicDZ.IntValue, eawaZQvtvbptP3yFgHw8DNBicDZ.StringValue);
				}
			}
		}
	}

	// Token: 0x0600028F RID: 655 RVA: 0x000119B8 File Offset: 0x0000FBB8
	public void _P121IKZIlX2mwLlqYE56erHJuhg(int id, int intValue, string stringValue)
	{
		if (StatsType.Id(new StatsType((byte)id), StatsType._DVNBi2eQHLdmlmNyYH05WDcfCzq))
		{
			this._hI9BnQSXNqD191WGfzaqXuLrtAm = intValue;
			return;
		}
		if (StatsType.Id(new StatsType((byte)id), StatsType.HP))
		{
			this._sNZat68b2TvW6o582Hg9CFuEJCV = intValue;
			return;
		}
		if (StatsType.Id(new StatsType((byte)id), StatsType._QkkjT08Jq1EAHiSlsxNcrD5paX9))
		{
			this._hEsbmlbXONy7ZBQJ7WWzpDvfvgr = intValue;
			return;
		}
		if (StatsType.Id(new StatsType((byte)id), StatsType.MP))
		{
			this._d6odaPuEJmqJn749YMNMKeI9xTi = intValue;
			return;
		}
		if (StatsType.Id(new StatsType((byte)id), StatsType._TuTejl6BJwjzMlO6dSSYgBTEB8l))
		{
			this._TzlI3eSRr63TXqEBVw9SJLUpX3A = intValue;
			return;
		}
		if (StatsType.Id(new StatsType((byte)id), StatsType._JbADdSEurT8Fk6JbwEscBOG6VPt))
		{
			this._cHa7IwOLz7Zljlt6nYPH1d3XYsD = intValue;
			return;
		}
		if (StatsType.Id(new StatsType((byte)id), StatsType._kVPIn7lal6qAksGnCpfbCxqF9pv))
		{
			this._kVPIn7lal6qAksGnCpfbCxqF9pv = intValue;
			return;
		}
		if (StatsType.Id(new StatsType((byte)id), StatsType._kO6uiVaRgPa6zvwV2YgkaFawFeA))
		{
			this._LgxK5GR2YdT31chQJOKuf3C3zSA[0] = intValue;
			return;
		}
		if (StatsType.Id(new StatsType((byte)id), StatsType._idaesRih3T62YKfF1b0nKNMOdlo))
		{
			this._LgxK5GR2YdT31chQJOKuf3C3zSA[1] = intValue;
			return;
		}
		if (StatsType.Id(new StatsType((byte)id), StatsType._Elnq8QyL4vGRCwYAWNqB3poZk3g))
		{
			this._LgxK5GR2YdT31chQJOKuf3C3zSA[2] = intValue;
			return;
		}
		if (StatsType.Id(new StatsType((byte)id), StatsType._GIjfmXQzE3E0aenxsDaAxVhd1TS))
		{
			this._LgxK5GR2YdT31chQJOKuf3C3zSA[3] = intValue;
			return;
		}
		if (StatsType.Id(new StatsType((byte)id), StatsType._nf7bk3w6XqIyW0GRVPptSPegV0c))
		{
			this._LgxK5GR2YdT31chQJOKuf3C3zSA[4] = intValue;
			return;
		}
		if (StatsType.Id(new StatsType((byte)id), StatsType._wBDcV7WqlqU0RiUzd0JaYulVLop))
		{
			this._LgxK5GR2YdT31chQJOKuf3C3zSA[5] = intValue;
			return;
		}
		if (StatsType.Id(new StatsType((byte)id), StatsType._nyqBkmlRFF5A6f9gM44lyrdSwFI))
		{
			this._LgxK5GR2YdT31chQJOKuf3C3zSA[6] = intValue;
			return;
		}
		if (StatsType.Id(new StatsType((byte)id), StatsType._KbfKlNWj4mBtJIGPRsKYtTEOu9B))
		{
			this._LgxK5GR2YdT31chQJOKuf3C3zSA[7] = intValue;
			return;
		}
		if (StatsType.Id(new StatsType((byte)id), StatsType._SuGywcWU0SU5yC6EudAzgam1i0))
		{
			this._LgxK5GR2YdT31chQJOKuf3C3zSA[8] = intValue;
			return;
		}
		if (StatsType.Id(new StatsType((byte)id), StatsType._WnxPmr6ftaysCv1lzG9xOGSBT1g))
		{
			this._LgxK5GR2YdT31chQJOKuf3C3zSA[9] = intValue;
			return;
		}
		if (StatsType.Id(new StatsType((byte)id), StatsType._x6kfS9rjAQzo94A4reHQXK3nkaH))
		{
			this._LgxK5GR2YdT31chQJOKuf3C3zSA[10] = intValue;
			return;
		}
		if (StatsType.Id(new StatsType((byte)id), StatsType._Ra9EqaM4zauDBI123vX3hnJcNZi))
		{
			this._LgxK5GR2YdT31chQJOKuf3C3zSA[11] = intValue;
			return;
		}
		if (StatsType.Id(new StatsType((byte)id), StatsType._dI2A4xkFMBKB33bDL8Z5iBFtdKyA))
		{
			this._dI2A4xkFMBKB33bDL8Z5iBFtdKyA = intValue;
			return;
		}
		if (StatsType.Id(new StatsType((byte)id), StatsType._I8uQpaQw1Wx940p3k48AjKZWpuM))
		{
			this._I8uQpaQw1Wx940p3k48AjKZWpuM = intValue;
			return;
		}
		if (StatsType.Id(new StatsType((byte)id), StatsType._QdxR2qr1IpaCFjLkbiV08vZVgcY))
		{
			this._QdxR2qr1IpaCFjLkbiV08vZVgcY = intValue;
			return;
		}
		if (StatsType.Id(new StatsType((byte)id), StatsType._UJS9Gfx8k7FD8Uw5U6mVqjWLghC))
		{
			this._UJS9Gfx8k7FD8Uw5U6mVqjWLghC = intValue;
			return;
		}
		if (StatsType.Id(new StatsType((byte)id), StatsType._WHCAkdeYqXMbNsGZ6LrBhVGy9y4))
		{
			this._WHCAkdeYqXMbNsGZ6LrBhVGy9y4 = intValue;
			return;
		}
		if (StatsType.Id(new StatsType((byte)id), StatsType._pdtKFzngyBbdiv5VHFvMh7Hovb3))
		{
			this._pdtKFzngyBbdiv5VHFvMh7Hovb3 = intValue;
			return;
		}
		if (StatsType.Id(new StatsType((byte)id), StatsType.Effects))
		{
			this._xRou6pLb1OAINZAI0Yki8s1brKc = intValue;
			return;
		}
		if (StatsType.Id(new StatsType((byte)id), StatsType._ArqZre4dIDTIIPy3xTszHel9Wqf))
		{
			this._ArqZre4dIDTIIPy3xTszHel9Wqf = intValue;
			return;
		}
		if (StatsType.Id(new StatsType((byte)id), StatsType._Jp3DtIV4aAYZY26sVsXpPQjBRGO))
		{
			this._Jp3DtIV4aAYZY26sVsXpPQjBRGO = stringValue;
			return;
		}
		if (StatsType.Id(new StatsType((byte)id), StatsType._TKbQLd6bI116m2Ua1V2GkjCjohg))
		{
			this._4FDwTdljo8ctqjmJc03fgnIaeZg = intValue;
			return;
		}
		if (StatsType.Id(new StatsType((byte)id), StatsType._AIx8b5TcnS5VDiVLZjYLnwCifsd))
		{
			this._Lzvzp2oXdYnE0lwswnTvC9XMF20 = intValue;
			return;
		}
		if (StatsType.Id(new StatsType((byte)id), StatsType._hX8BFqWLS62laclaj1NZp3sAf1lA))
		{
			this._hX8BFqWLS62laclaj1NZp3sAf1lA = stringValue;
			return;
		}
		if (StatsType.Id(new StatsType((byte)id), StatsType._56pdYv1LPTIA6NGeLxVI6h8jOT8))
		{
			this._56pdYv1LPTIA6NGeLxVI6h8jOT8 = intValue;
			return;
		}
		if (StatsType.Id(new StatsType((byte)id), StatsType._a19Kww8XtLvH56Cl4ErqzYwACOr))
		{
			this._a19Kww8XtLvH56Cl4ErqzYwACOr = intValue;
			return;
		}
		if (StatsType.Id(new StatsType((byte)id), StatsType._7PsO1ZY2PoG3jMvyBfd2G7j6ygc))
		{
			this._7PsO1ZY2PoG3jMvyBfd2G7j6ygc = intValue;
			return;
		}
		if (StatsType.Id(new StatsType((byte)id), StatsType._4rfvEfTefqPghGJsKrqd7EtsEre))
		{
			this._4rfvEfTefqPghGJsKrqd7EtsEre = intValue;
			return;
		}
		if (StatsType.Id(new StatsType((byte)id), StatsType._bJyEvHBLdYV7m9rFbt33Pzb2sxA))
		{
			this._bJyEvHBLdYV7m9rFbt33Pzb2sxA = intValue;
			return;
		}
		if (StatsType.Id(new StatsType((byte)id), StatsType._v8e0yLlSvUcBhpWcWa9eZykXXQD))
		{
			this._v8e0yLlSvUcBhpWcWa9eZykXXQD = intValue;
			return;
		}
		if (StatsType.Id(new StatsType((byte)id), StatsType._D3LajoXm4jGGTmV2Y1LI3FGsJjn))
		{
			this._D3LajoXm4jGGTmV2Y1LI3FGsJjn = intValue;
			return;
		}
		if (StatsType.Id(new StatsType((byte)id), StatsType._4akWucPyC5kfaQPCwo1ZymNANi2))
		{
			this._4akWucPyC5kfaQPCwo1ZymNANi2 = intValue;
			return;
		}
		if (StatsType.Id(new StatsType((byte)id), StatsType._YEq14ZJh64oSIGyaFj5kn82EMRDA))
		{
			this._YEq14ZJh64oSIGyaFj5kn82EMRDA = intValue;
			return;
		}
		if (StatsType.Id(new StatsType((byte)id), StatsType._GwQlWzhgVAQa52xKJBrIYHUwuSg))
		{
			this._72MClqxUQNaMFXiM1F3S15fnmVs = intValue;
			return;
		}
		if (StatsType.Id(new StatsType((byte)id), StatsType._elsgOPOhrazwFqRBlSiBgics9eZ))
		{
			this._elsgOPOhrazwFqRBlSiBgics9eZ = (intValue > 0);
			return;
		}
		if (StatsType.Id(new StatsType((byte)id), StatsType._wtUCeGWgiFihItvjiXcbqM4OcaG))
		{
			this._wtUCeGWgiFihItvjiXcbqM4OcaG = intValue;
			return;
		}
		if (StatsType.Id(new StatsType((byte)id), StatsType._o7pfCVIFMYowiMMXy0NnZe6rdAK))
		{
			this._o7pfCVIFMYowiMMXy0NnZe6rdAK = intValue;
			return;
		}
		if (StatsType.Id(new StatsType((byte)id), StatsType._jQToCmezajoMkD7AWz3F9w0fiQJ))
		{
			this._4Q2zMMuGhulFGkA7jhmbJO28xjb = (intValue > -1);
			return;
		}
		if (StatsType.Id(new StatsType((byte)id), StatsType._nnw4mIJ2qnTBfbumuZegfJw1qcX))
		{
			this._nnw4mIJ2qnTBfbumuZegfJw1qcX = stringValue;
			return;
		}
		if (StatsType.Id(new StatsType((byte)id), StatsType._LgHauWr40j3A6clN8gZvftMEHKs))
		{
			this._LgHauWr40j3A6clN8gZvftMEHKs = intValue;
			return;
		}
		if (StatsType.Id(new StatsType((byte)id), StatsType._bwlhTiDZyjHndQbZAcaCfdCkLYc))
		{
			this._NS3P3L4cIOPeb4lcI1vHxLBjUsG = intValue;
			return;
		}
		if (StatsType.Id(new StatsType((byte)id), StatsType._QKbxIHZBPI9Dq3OhZ51dNkkdQY7A))
		{
			this._QKbxIHZBPI9Dq3OhZ51dNkkdQY7A = intValue;
			return;
		}
		if (StatsType.Id(new StatsType((byte)id), StatsType._V45DgbkdekLVCMtEzfZpb7LDuz3))
		{
			this._V45DgbkdekLVCMtEzfZpb7LDuz3 = intValue;
			return;
		}
		if (StatsType.Id(new StatsType((byte)id), StatsType._5gFvVxLffbEYV6UfbYXgWt9k7uM))
		{
			this._ZfO1ANJ75ZswBzkm1MtjqXYma3I[0] = intValue;
			return;
		}
		if (StatsType.Id(new StatsType((byte)id), StatsType._vopOQhtijAp9Bk35wA0Sh1LiePA))
		{
			this._ZfO1ANJ75ZswBzkm1MtjqXYma3I[1] = intValue;
			return;
		}
		if (StatsType.Id(new StatsType((byte)id), StatsType._byTrm6qjjyHReLKfncrk5X6B2NC))
		{
			this._ZfO1ANJ75ZswBzkm1MtjqXYma3I[2] = intValue;
			return;
		}
		if (StatsType.Id(new StatsType((byte)id), StatsType._uLrbmPp2nSEJJD8G3aRNk2ZiYSC))
		{
			this._ZfO1ANJ75ZswBzkm1MtjqXYma3I[3] = intValue;
			return;
		}
		if (StatsType.Id(new StatsType((byte)id), StatsType._a2MDiylwgtMXzdWOqOvOl0hqJ9J))
		{
			this._ZfO1ANJ75ZswBzkm1MtjqXYma3I[4] = intValue;
			return;
		}
		if (StatsType.Id(new StatsType((byte)id), StatsType._L77q6EJufoAZNPrD4G9br8W6sBk))
		{
			this._ZfO1ANJ75ZswBzkm1MtjqXYma3I[5] = intValue;
			return;
		}
		if (StatsType.Id(new StatsType((byte)id), StatsType._3KKCmYZQVnHZQ4nggRv26Ot6Ct))
		{
			this._ZfO1ANJ75ZswBzkm1MtjqXYma3I[6] = intValue;
			return;
		}
		if (StatsType.Id(new StatsType((byte)id), StatsType._bfw0GuMqiQGEPHyCpXmy8P83nnB))
		{
			this._ZfO1ANJ75ZswBzkm1MtjqXYma3I[7] = intValue;
			return;
		}
		if (StatsType.Id(new StatsType((byte)id), StatsType._i1wpxbN1B15L7vPjaWvObujwWOB))
		{
			this._i1wpxbN1B15L7vPjaWvObujwWOB = (intValue > 0);
			return;
		}
		if (StatsType.Id(new StatsType((byte)id), StatsType._qRYx5j3OvH1oNGlfjLNr6zIbDjF))
		{
			this._qRYx5j3OvH1oNGlfjLNr6zIbDjF = intValue;
		}
	}

	// Token: 0x06000290 RID: 656 RVA: 0x00012070 File Offset: 0x00010270
	public bool _PMk1LghtJtx8x2q5bfCEnzYXuzi(_FxW3cpBIUZT3nuKFOJfwHOThAq7 effect)
	{
		return (this._xRou6pLb1OAINZAI0Yki8s1brKc & (int)effect) != 0;
	}

	// Token: 0x06000291 RID: 657 RVA: 0x00012088 File Offset: 0x00010288
	public float _yChu4Yf7dFtxHK6YltXFAjpMs2()
	{
		return (4f + 5.6f * ((float)this._QdxR2qr1IpaCFjLkbiV08vZVgcY / 75f)) / 5f;
	}

	// Token: 0x06000292 RID: 658 RVA: 0x000120B4 File Offset: 0x000102B4
	public virtual string _Ye7Bzeo9ipi3HJQJeW2fYB88LbJ()
	{
		FieldInfo[] fields = base.GetType().GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(this._0fGEyhVNT3zNHE6jzPplPx6jM6g.ToString() + "'s PlayerData Instance");
		foreach (FieldInfo fieldInfo in fields)
		{
			if (fieldInfo.GetValue(this) != null)
			{
				StringBuilder stringBuilder2 = stringBuilder;
				string str = "\n\t";
				string name = fieldInfo.Name;
				string str2 = " => ";
				object value = fieldInfo.GetValue(this);
				stringBuilder2.Append(str + name + str2 + ((value != null) ? value.ToString() : null));
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x04000326 RID: 806
	public int _0fGEyhVNT3zNHE6jzPplPx6jM6g;

	// Token: 0x04000327 RID: 807
	public string _J7VwVS5qpzlByqu8B6AKwj7oO3x;

	// Token: 0x04000328 RID: 808
	public bool _CO0bfAMJAEfni7qUeHiAhciX55oA;

	// Token: 0x04000329 RID: 809
	public int _qbK2v2iN98g4OMBqAvi2oMcDXsm;

	// Token: 0x0400032A RID: 810
	public int _6UWiEBuADteDCWXzyg9k8j5h4qZ;

	// Token: 0x0400032B RID: 811
	public int _hI9BnQSXNqD191WGfzaqXuLrtAm;

	// Token: 0x0400032C RID: 812
	public int _sNZat68b2TvW6o582Hg9CFuEJCV;

	// Token: 0x0400032D RID: 813
	public int _hEsbmlbXONy7ZBQJ7WWzpDvfvgr;

	// Token: 0x0400032E RID: 814
	public int _d6odaPuEJmqJn749YMNMKeI9xTi;

	// Token: 0x0400032F RID: 815
	public int _TzlI3eSRr63TXqEBVw9SJLUpX3A;

	// Token: 0x04000330 RID: 816
	public int _cHa7IwOLz7Zljlt6nYPH1d3XYsD;

	// Token: 0x04000331 RID: 817
	public int _kVPIn7lal6qAksGnCpfbCxqF9pv = 1;

	// Token: 0x04000332 RID: 818
	public int[] _LgxK5GR2YdT31chQJOKuf3C3zSA = new int[]
	{
		-1,
		-1,
		-1,
		-1,
		-1,
		-1,
		-1,
		-1,
		-1,
		-1,
		-1,
		-1
	};

	// Token: 0x04000333 RID: 819
	public int[] _ZfO1ANJ75ZswBzkm1MtjqXYma3I = new int[]
	{
		-1,
		-1,
		-1,
		-1,
		-1,
		-1,
		-1,
		-1
	};

	// Token: 0x04000334 RID: 820
	public int _dI2A4xkFMBKB33bDL8Z5iBFtdKyA;

	// Token: 0x04000335 RID: 821
	public int _I8uQpaQw1Wx940p3k48AjKZWpuM;

	// Token: 0x04000336 RID: 822
	public int _QdxR2qr1IpaCFjLkbiV08vZVgcY;

	// Token: 0x04000337 RID: 823
	public int _UJS9Gfx8k7FD8Uw5U6mVqjWLghC;

	// Token: 0x04000338 RID: 824
	public int _WHCAkdeYqXMbNsGZ6LrBhVGy9y4;

	// Token: 0x04000339 RID: 825
	public int _pdtKFzngyBbdiv5VHFvMh7Hovb3;

	// Token: 0x0400033A RID: 826
	public int _xRou6pLb1OAINZAI0Yki8s1brKc;

	// Token: 0x0400033B RID: 827
	public int _ArqZre4dIDTIIPy3xTszHel9Wqf;

	// Token: 0x0400033C RID: 828
	public string _Jp3DtIV4aAYZY26sVsXpPQjBRGO;

	// Token: 0x0400033D RID: 829
	public int _4FDwTdljo8ctqjmJc03fgnIaeZg;

	// Token: 0x0400033E RID: 830
	public int _Lzvzp2oXdYnE0lwswnTvC9XMF20;

	// Token: 0x0400033F RID: 831
	public bool _YqxSFlGcVQn30hPhozXRrYQ6QU;

	// Token: 0x04000340 RID: 832
	public string _hX8BFqWLS62laclaj1NZp3sAf1lA;

	// Token: 0x04000341 RID: 833
	public int _56pdYv1LPTIA6NGeLxVI6h8jOT8;

	// Token: 0x04000342 RID: 834
	public int _a19Kww8XtLvH56Cl4ErqzYwACOr;

	// Token: 0x04000343 RID: 835
	public int _7PsO1ZY2PoG3jMvyBfd2G7j6ygc;

	// Token: 0x04000344 RID: 836
	public int _4rfvEfTefqPghGJsKrqd7EtsEre;

	// Token: 0x04000345 RID: 837
	public int _bJyEvHBLdYV7m9rFbt33Pzb2sxA;

	// Token: 0x04000346 RID: 838
	public int _v8e0yLlSvUcBhpWcWa9eZykXXQD;

	// Token: 0x04000347 RID: 839
	public int _D3LajoXm4jGGTmV2Y1LI3FGsJjn;

	// Token: 0x04000348 RID: 840
	public int _4akWucPyC5kfaQPCwo1ZymNANi2;

	// Token: 0x04000349 RID: 841
	public int _YEq14ZJh64oSIGyaFj5kn82EMRDA;

	// Token: 0x0400034A RID: 842
	public int _72MClqxUQNaMFXiM1F3S15fnmVs;

	// Token: 0x0400034B RID: 843
	public bool _elsgOPOhrazwFqRBlSiBgics9eZ;

	// Token: 0x0400034C RID: 844
	public int _wtUCeGWgiFihItvjiXcbqM4OcaG;

	// Token: 0x0400034D RID: 845
	public int _o7pfCVIFMYowiMMXy0NnZe6rdAK;

	// Token: 0x0400034E RID: 846
	public bool _4Q2zMMuGhulFGkA7jhmbJO28xjb;

	// Token: 0x0400034F RID: 847
	public string _nnw4mIJ2qnTBfbumuZegfJw1qcX;

	// Token: 0x04000350 RID: 848
	public int _LgHauWr40j3A6clN8gZvftMEHKs;

	// Token: 0x04000351 RID: 849
	public int _NS3P3L4cIOPeb4lcI1vHxLBjUsG;

	// Token: 0x04000352 RID: 850
	public int _QKbxIHZBPI9Dq3OhZ51dNkkdQY7A;

	// Token: 0x04000353 RID: 851
	public int _V45DgbkdekLVCMtEzfZpb7LDuz3;

	// Token: 0x04000354 RID: 852
	public bool _i1wpxbN1B15L7vPjaWvObujwWOB;

	// Token: 0x04000355 RID: 853
	public int _qRYx5j3OvH1oNGlfjLNr6zIbDjF;

	// Token: 0x04000356 RID: 854
	public Location _mvJnAw6BUql91ryBD7pgazCL7Yd = new Location();

	// Token: 0x04000357 RID: 855
	public _3ybR0NIqCoLauI7agWn04Q92Mgr _eWTmO7bk3xilC4EIWJVRVBGVZvq;
}
