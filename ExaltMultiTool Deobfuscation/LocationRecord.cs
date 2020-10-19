using System;

// Token: 0x02000032 RID: 50
internal class LocationRecord : Location
{
	// Token: 0x06000285 RID: 645 RVA: 0x00011624 File Offset: 0x0000F824
	public LocationRecord(int time, double x, double y)
	{
		this.Time = time;
		this.X = x;
		this.Y = y;
	}

	// Token: 0x06000286 RID: 646 RVA: 0x0001164C File Offset: 0x0000F84C
	public LocationRecord(PacketReader r)
	{
		this.Time = r.ReadInt32();
		base.Read(r);
	}

	// Token: 0x06000287 RID: 647 RVA: 0x00011674 File Offset: 0x0000F874
	public override IDataObject Read(PacketReader r)
	{
		this.Time = r.ReadInt32();
		base.Read(r);
		return this;
	}

	// Token: 0x06000288 RID: 648 RVA: 0x00011698 File Offset: 0x0000F898
	public override void Write(PacketWriter w)
	{
		w.Write(this.Time);
		this.Write(w);
	}

	// Token: 0x06000289 RID: 649 RVA: 0x000116B8 File Offset: 0x0000F8B8
	public virtual object _tQIo1pbwhuhzBajMDd83FA5FY8c()
	{
		return new LocationRecord(this.Time, this.X, this.Y);
	}

	// Token: 0x0600028A RID: 650 RVA: 0x000116DC File Offset: 0x0000F8DC
	public override string _Ye7Bzeo9ipi3HJQJeW2fYB88LbJ()
	{
		return string.Concat(new string[]
		{
			"{ Time=",
			this.Time.ToString(),
			", X=",
			this.X.ToString(),
			", Y=",
			this.Y.ToString(),
			" }"
		});
	}

	// Token: 0x04000325 RID: 805
	public int Time;

    public double X { get; }
    public double Y { get; }
}
