using System;
using System.Collections.Generic;

// Token: 0x0200003A RID: 58
internal class Status : IDataObject, ICloneable
{
	// Token: 0x060002BA RID: 698 RVA: 0x00012FC0 File Offset: 0x000111C0
	public IDataObject Read(PacketReader r)
	{
		this.ObjectId = _di3Iyuw9XRVUyJrW7NCBFduCW4H._eHIpo1lHmEGnQwbA8tDvcpJtdfl(r);
		this.Position.Read(r);
		int num = _di3Iyuw9XRVUyJrW7NCBFduCW4H._eHIpo1lHmEGnQwbA8tDvcpJtdfl(r);
		this.Data = new List<StatData>(num);
		for (int i = 0; i < num; i++)
		{
			this.Data.Add(new StatData(r));
		}
		return this;
	}

	// Token: 0x060002BB RID: 699 RVA: 0x00013018 File Offset: 0x00011218
	public void Write(PacketWriter w)
	{
		_di3Iyuw9XRVUyJrW7NCBFduCW4H._7A7oILp80mGDmH4Uco8L8vPbaS4(w, this.ObjectId);
		this.Position.Write(w);
		_di3Iyuw9XRVUyJrW7NCBFduCW4H._7A7oILp80mGDmH4Uco8L8vPbaS4(w, this.Data.Count);
		foreach (StatData eawaZQvtvbptP3yFgHw8DNBicDZ in this.Data)
		{
			eawaZQvtvbptP3yFgHw8DNBicDZ.Write(w);
		}
	}

	// Token: 0x060002BC RID: 700 RVA: 0x00013094 File Offset: 0x00011294
	public object Clone()
	{
		return new Status
		{
			Data = new List<StatData>(this.Data),
			ObjectId = this.ObjectId,
			Position = (Location)this.Position.Clone()
		};
	}

	// Token: 0x04000450 RID: 1104
	public int ObjectId;

	// Token: 0x04000451 RID: 1105
	public Location Position = new Location();

	// Token: 0x04000452 RID: 1106
	public List<StatData> Data;
}
