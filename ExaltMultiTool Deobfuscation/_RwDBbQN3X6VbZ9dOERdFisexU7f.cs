using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000040 RID: 64
internal class _RwDBbQN3X6VbZ9dOERdFisexU7f : Packet
{
	// Token: 0x170000D9 RID: 217
	// (get) Token: 0x060002D4 RID: 724 RVA: 0x00013470 File Offset: 0x00011670
	public override PacketType Type
	{
		get
		{
			return PacketType.QUESTREDEEM;
		}
	}

	// Token: 0x060002D5 RID: 725 RVA: 0x00013480 File Offset: 0x00011680
	public override void Read(PacketReader r)
	{
		this._6lYbMdNFzU6bREgKhF2Qf5I50Rf = r.ReadString();
		this._jG3RdlWG8QOSbqMejdbEmnotPXB = r.ReadInt32();
		int num = (int)r.ReadInt16();
		this._IFsdg3fz4hmZaJ5f4muhQ8w5t4s = new _A3HGGdSvVENqKj3O1HGYDO3Qh8C[num];
		for (int i = 0; i < num; i++)
		{
			this._IFsdg3fz4hmZaJ5f4muhQ8w5t4s[i] = new _A3HGGdSvVENqKj3O1HGYDO3Qh8C(r);
		}
	}

	// Token: 0x060002D6 RID: 726 RVA: 0x000134D4 File Offset: 0x000116D4
	public override void Write(PacketWriter w)
	{
		w.Write(this._6lYbMdNFzU6bREgKhF2Qf5I50Rf);
		w.Write(this._jG3RdlWG8QOSbqMejdbEmnotPXB);
		w.Write((short)this._IFsdg3fz4hmZaJ5f4muhQ8w5t4s.Length);
		_A3HGGdSvVENqKj3O1HGYDO3Qh8C[] ifsdg3fz4hmZaJ5f4muhQ8w5t4s = this._IFsdg3fz4hmZaJ5f4muhQ8w5t4s;
		for (int i = 0; i < ifsdg3fz4hmZaJ5f4muhQ8w5t4s.Length; i++)
		{
			ifsdg3fz4hmZaJ5f4muhQ8w5t4s[i].Write(w);
		}
	}

	// Token: 0x04000462 RID: 1122
	public string _6lYbMdNFzU6bREgKhF2Qf5I50Rf;

	// Token: 0x04000463 RID: 1123
	public _A3HGGdSvVENqKj3O1HGYDO3Qh8C[] _IFsdg3fz4hmZaJ5f4muhQ8w5t4s;

	// Token: 0x04000464 RID: 1124
	public int _jG3RdlWG8QOSbqMejdbEmnotPXB;
}
