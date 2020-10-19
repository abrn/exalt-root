using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x0200009F RID: 159
internal class UpdatePacket : Packet
{
	// Token: 0x17000137 RID: 311
	// (get) Token: 0x06000454 RID: 1108 RVA: 0x000170CC File Offset: 0x000152CC
	public override PacketType Type
	{
		get
		{
			return PacketType.UPDATE;
		}
	}

	// Token: 0x06000455 RID: 1109 RVA: 0x000170DC File Offset: 0x000152DC
	public override void Read(PacketReader r)
	{
		this._ggcOirasY7xrclnb5yxgWCbeJam = new _hVYZnKlD1p4NKgHvEIulwTgi91f[_di3Iyuw9XRVUyJrW7NCBFduCW4H._eHIpo1lHmEGnQwbA8tDvcpJtdfl(r)];
		for (int i = 0; i < this._ggcOirasY7xrclnb5yxgWCbeJam.Length; i++)
		{
			this._ggcOirasY7xrclnb5yxgWCbeJam[i] = (_hVYZnKlD1p4NKgHvEIulwTgi91f)new _hVYZnKlD1p4NKgHvEIulwTgi91f().Read(r);
		}
		this.NewObjs = new Entity[_di3Iyuw9XRVUyJrW7NCBFduCW4H._eHIpo1lHmEGnQwbA8tDvcpJtdfl(r)];
		for (int j = 0; j < this.NewObjs.Length; j++)
		{
			this.NewObjs[j] = (Entity)new Entity().Read(r);
		}
		this.Drops = new int[_di3Iyuw9XRVUyJrW7NCBFduCW4H._eHIpo1lHmEGnQwbA8tDvcpJtdfl(r)];
		for (int k = 0; k < this.Drops.Length; k++)
		{
			this.Drops[k] = _di3Iyuw9XRVUyJrW7NCBFduCW4H._eHIpo1lHmEGnQwbA8tDvcpJtdfl(r);
		}
	}

	// Token: 0x06000456 RID: 1110 RVA: 0x00017194 File Offset: 0x00015394
	public override void Write(PacketWriter w)
	{
		_di3Iyuw9XRVUyJrW7NCBFduCW4H._7A7oILp80mGDmH4Uco8L8vPbaS4(w, this._ggcOirasY7xrclnb5yxgWCbeJam.Length);
		_hVYZnKlD1p4NKgHvEIulwTgi91f[] ggcOirasY7xrclnb5yxgWCbeJam = this._ggcOirasY7xrclnb5yxgWCbeJam;
		for (int i = 0; i < ggcOirasY7xrclnb5yxgWCbeJam.Length; i++)
		{
			ggcOirasY7xrclnb5yxgWCbeJam[i].Write(w);
		}
		_di3Iyuw9XRVUyJrW7NCBFduCW4H._7A7oILp80mGDmH4Uco8L8vPbaS4(w, this.NewObjs.Length);
		Entity[] jyJGMVpAZL4M3WPGiyvdnxz1cTH = this.NewObjs;
		for (int i = 0; i < jyJGMVpAZL4M3WPGiyvdnxz1cTH.Length; i++)
		{
			jyJGMVpAZL4M3WPGiyvdnxz1cTH[i].Write(w);
		}
		_di3Iyuw9XRVUyJrW7NCBFduCW4H._7A7oILp80mGDmH4Uco8L8vPbaS4(w, this.Drops.Length);
		foreach (int value in this.Drops)
		{
			_di3Iyuw9XRVUyJrW7NCBFduCW4H._7A7oILp80mGDmH4Uco8L8vPbaS4(w, value);
		}
	}

	// Token: 0x04000586 RID: 1414
	public _hVYZnKlD1p4NKgHvEIulwTgi91f[] _ggcOirasY7xrclnb5yxgWCbeJam;

	// Token: 0x04000587 RID: 1415
	public Entity[] NewObjs;

	// Token: 0x04000588 RID: 1416
	public int[] Drops;
}
