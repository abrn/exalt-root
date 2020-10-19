using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x0200005F RID: 95
internal class _CuAD5qOVhedsxfPCkSon6261zEK : Packet
{
	// Token: 0x170000F8 RID: 248
	// (get) Token: 0x06000350 RID: 848 RVA: 0x00014460 File Offset: 0x00012660
	public override PacketType Type
	{
		get
		{
			return PacketType.PETUPGRADEREQUEST;
		}
	}

	// Token: 0x06000351 RID: 849 RVA: 0x00014470 File Offset: 0x00012670
	public override void Read(PacketReader r)
	{
		this._PTijZobtOKKA2E4S2Vr2w9afHxg = r.ReadByte();
		this._Ia61Vapodi9BBA0MzV0cnBoOM89 = r.ReadInt32();
		this._c4R0LoUbfFhG40BLrsey7k3iafD = r.ReadInt32();
		this._605Ligxeaj9k9kBV8zQhhFhgTGl = r.ReadInt32();
		this._GbtHysMRPoKlTOMs7qbMI8m9BjB = r.ReadByte();
		this._U2kEAqSUtjhVX3xjQLvVslmigEE = new _A3HGGdSvVENqKj3O1HGYDO3Qh8C[(int)r.ReadInt16()];
		for (int i = 0; i < this._U2kEAqSUtjhVX3xjQLvVslmigEE.Length; i++)
		{
			this._U2kEAqSUtjhVX3xjQLvVslmigEE[i] = new _A3HGGdSvVENqKj3O1HGYDO3Qh8C(r);
		}
	}

	// Token: 0x06000352 RID: 850 RVA: 0x000144EC File Offset: 0x000126EC
	public override void Write(PacketWriter w)
	{
		w.Write(this._PTijZobtOKKA2E4S2Vr2w9afHxg);
		w.Write(this._Ia61Vapodi9BBA0MzV0cnBoOM89);
		w.Write(this._c4R0LoUbfFhG40BLrsey7k3iafD);
		w.Write(this._605Ligxeaj9k9kBV8zQhhFhgTGl);
		w.Write(this._GbtHysMRPoKlTOMs7qbMI8m9BjB);
		w.Write((short)this._U2kEAqSUtjhVX3xjQLvVslmigEE.Length);
		_A3HGGdSvVENqKj3O1HGYDO3Qh8C[] u2kEAqSUtjhVX3xjQLvVslmigEE = this._U2kEAqSUtjhVX3xjQLvVslmigEE;
		for (int i = 0; i < u2kEAqSUtjhVX3xjQLvVslmigEE.Length; i++)
		{
			u2kEAqSUtjhVX3xjQLvVslmigEE[i].Write(w);
		}
	}

	// Token: 0x040004AA RID: 1194
	public const int _eSs0tJLcWk3d4WWDQrnYlivW0kN = 1;

	// Token: 0x040004AB RID: 1195
	public const int _dj6CmVC8cSbl0Ttvfs8KcA7vMcT = 2;

	// Token: 0x040004AC RID: 1196
	public const int _46nAo3RAVohCruDUcqN7qMuKqcn = 3;

	// Token: 0x040004AD RID: 1197
	public byte _PTijZobtOKKA2E4S2Vr2w9afHxg;

	// Token: 0x040004AE RID: 1198
	public int _Ia61Vapodi9BBA0MzV0cnBoOM89;

	// Token: 0x040004AF RID: 1199
	public int _c4R0LoUbfFhG40BLrsey7k3iafD;

	// Token: 0x040004B0 RID: 1200
	public int _605Ligxeaj9k9kBV8zQhhFhgTGl;

	// Token: 0x040004B1 RID: 1201
	public byte _GbtHysMRPoKlTOMs7qbMI8m9BjB;

	// Token: 0x040004B2 RID: 1202
	public _A3HGGdSvVENqKj3O1HGYDO3Qh8C[] _U2kEAqSUtjhVX3xjQLvVslmigEE;
}
