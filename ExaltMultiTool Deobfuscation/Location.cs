using System;

// Token: 0x02000031 RID: 49
internal class Location : IDataObject /*idataobject*/, ICloneable
{
	// Token: 0x06000270 RID: 624 RVA: 0x000112D8 File Offset: 0x0000F4D8
	public Location()
	{
	}

	// Token: 0x06000271 RID: 625 RVA: 0x000112EC File Offset: 0x0000F4EC
	public Location(PacketReader r)
	{
		this.x = (double)r.ReadSingle();
		this.y = (double)r.ReadSingle();
	}

	// Token: 0x06000272 RID: 626 RVA: 0x0001131C File Offset: 0x0000F51C
	public Location(float x, float y)
	{
		this.x = (double)x;
		this.y = (double)y;
	}

	// Token: 0x06000273 RID: 627 RVA: 0x00011340 File Offset: 0x0000F540
	public Location(double x, double y)
	{
		this.x = x;
		this.y = y;
	}

	// Token: 0x170000D4 RID: 212
	// (get) Token: 0x06000274 RID: 628 RVA: 0x00011364 File Offset: 0x0000F564
	public static Location Empty
	{
		get
		{
			return new Location(0f, 0f);
		}
	}

	// Token: 0x06000275 RID: 629 RVA: 0x00011380 File Offset: 0x0000F580
	public virtual IDataObject Read(PacketReader r)
	{
		this.x = (double)r.ReadSingle();
		this.y = (double)r.ReadSingle();
		return this;
	}

	// Token: 0x06000276 RID: 630 RVA: 0x000113A8 File Offset: 0x0000F5A8
	public virtual void Write(PacketWriter w)
	{
		w.Write((float)this.x);
		w.Write((float)this.y);
	}

	// Token: 0x06000277 RID: 631 RVA: 0x000113D0 File Offset: 0x0000F5D0
	public double DistanceSquaredTo(Location location)
	{
		double num = location.x - this.x;
		double num2 = location.y - this.y;
		return num * num + num2 * num2;
	}

	// Token: 0x06000278 RID: 632 RVA: 0x00011400 File Offset: 0x0000F600
	public double DistanceTo(Location location)
	{
		return Math.Sqrt(this.DistanceSquaredTo(location));
	}

	// Token: 0x06000279 RID: 633 RVA: 0x0001141C File Offset: 0x0000F61C
	public double GetAngle(Location l1, Location l2)
	{
		double x = l2.x - l1.x;
		return Math.Atan2(l2.y - l1.y, x);
	}

	// Token: 0x0600027A RID: 634 RVA: 0x0001144C File Offset: 0x0000F64C
	public double GetAngle(double x1, double y1, double x2, double y2)
	{
		double x3 = x2 - x1;
		return Math.Atan2(y2 - y1, x3);
	}

	// Token: 0x0600027B RID: 635 RVA: 0x00011468 File Offset: 0x0000F668
	public Location PositionInDirection(double targetAngle, double targetDistance)
	{
		double x = this.x + Math.Cos(targetAngle) * targetDistance;
		double y = this.y + Math.Sin(targetAngle) * targetDistance;
		return new Location(x, y);
	}

	// Token: 0x0600027C RID: 636 RVA: 0x0001149C File Offset: 0x0000F69C
	public static Location PositionInDirection(double sourceX, double sourceY, double targetAngle, double targetDistance)
	{
		double x = sourceX + Math.Cos(targetAngle) * targetDistance;
		double y = sourceY + Math.Sin(targetAngle) * targetDistance;
		return new Location(x, y);
	}

	// Token: 0x0600027D RID: 637 RVA: 0x000114C4 File Offset: 0x0000F6C4
	public Location Add(Location loc)
	{
		return new Location(this.x + loc.x, this.y + loc.y);
	}

	// Token: 0x0600027E RID: 638 RVA: 0x000114F0 File Offset: 0x0000F6F0
	public Location Subtract(Location loc)
	{
		return new Location(this.x - loc.x, this.y - loc.y);
	}

	// Token: 0x0600027F RID: 639 RVA: 0x0001151C File Offset: 0x0000F71C
	public virtual bool Equals(object obj)
	{
		Location location = (Location)obj;
		return location != null && this.x == location.x && this.y == location.y;
	}

	// Token: 0x06000280 RID: 640 RVA: 0x00011554 File Offset: 0x0000F754
	public void ScaleBy(double value)
	{
		this.x *= value;
		this.y *= value;
	}

	// Token: 0x06000281 RID: 641 RVA: 0x00011580 File Offset: 0x0000F780
	public double DotProduct(Location loc)
	{
		return double.NaN;
	}

	// Token: 0x06000282 RID: 642 RVA: 0x00011598 File Offset: 0x0000F798
	public virtual object Clone()
	{
		return new Location
		{
			x = this.x,
			y = this.y
		};
	}

	// Token: 0x06000283 RID: 643 RVA: 0x000115C4 File Offset: 0x0000F7C4
	public virtual string _Ye7Bzeo9ipi3HJQJeW2fYB88LbJ()
	{
		return string.Format("{{ X={0}, Y={1} }}", this.x, this.y);
	}

	// Token: 0x06000284 RID: 644 RVA: 0x000115F4 File Offset: 0x0000F7F4
	public string _LKh1lNSjvGBblHImeftEdtJOiaBA()
	{
		return string.Format("{{ X={0:F2}, Y={1:F2} }}", this.x, this.y);
	}

	// Token: 0x04000323 RID: 803
	public double x;

	// Token: 0x04000324 RID: 804
	public double y;
    internal double _MFEyfKFQqtcdaBxZbAOPzXMB8iP;
}
