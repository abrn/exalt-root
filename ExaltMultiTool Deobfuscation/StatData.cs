using System;

// Token: 0x02000038 RID: 56
internal class StatData : IDataObject, ICloneable
{
	// Token: 0x060002A4 RID: 676 RVA: 0x000126F8 File Offset: 0x000108F8
	public bool IsStringData()
	{
		return this.Id.IsUTF();
	}

	// Token: 0x060002A5 RID: 677 RVA: 0x00012710 File Offset: 0x00010910
	public StatData()
	{
	}

	// Token: 0x060002A6 RID: 678 RVA: 0x00012724 File Offset: 0x00010924
	public StatData(PacketReader r)
	{
		this.Id = r.ReadByte();
		if (this.IsStringData())
		{
			this.StringValue = r.ReadString();
			return;
		}
		this.IntValue = CompressedInt.Read(r);
	}

	// Token: 0x060002A7 RID: 679 RVA: 0x0001276C File Offset: 0x0001096C
	public IDataObject Read(PacketReader r)
	{
		this.Id = r.ReadByte();
		if (this.IsStringData())
		{
			this.StringValue = r.ReadString();
		}
		else
		{
			this.IntValue = CompressedInt.Read(r);
		}
		return this;
	}

	// Token: 0x060002A8 RID: 680 RVA: 0x000127B0 File Offset: 0x000109B0
	public void Write(PacketWriter w)
	{
		w.Write(Id);
		if (this.IsStringData())
		{
			w.Write(this.StringValue);
			return;
		}
		CompressedInt.Write(w, this.IntValue);
	}

	// Token: 0x060002A9 RID: 681 RVA: 0x000127F0 File Offset: 0x000109F0
	public object Clone()
	{
		return new StatData
		{
			Id = this.Id,
			IntValue = this.IntValue,
			StringValue = this.StringValue
		};
	}

	// Token: 0x060002AA RID: 682 RVA: 0x00012828 File Offset: 0x00010A28
	public override string ToString()
	{
		string[] array = new string[5];
		array[0] = "{ Id=";
		int num = 1;
		StatsType id = this.Id;
		array[num] = ((id != null) ? id.ToString() : null);
		array[2] = "Value=";
		array[3] = (this.IsStringData() ? this.StringValue : this.IntValue.ToString());
		array[4] = " }";
		return string.Concat(array);
	}

	// Token: 0x040003DB RID: 987
	public StatsType Id;

	// Token: 0x040003DC RID: 988
	public int IntValue;

	// Token: 0x040003DD RID: 989
	public string StringValue;
}
