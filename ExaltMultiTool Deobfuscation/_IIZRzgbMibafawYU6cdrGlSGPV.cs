using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x0200008F RID: 143
internal class _IIZRzgbMibafawYU6cdrGlSGPV : Packet
{
	// Token: 0x17000128 RID: 296
	// (get) Token: 0x06000412 RID: 1042 RVA: 0x000161AC File Offset: 0x000143AC
	public override PacketType Type
	{
		get
		{
			return PacketType.QUESTREDEEMRESPONSE;
		}
	}

	// Token: 0x06000413 RID: 1043 RVA: 0x000161BC File Offset: 0x000143BC
	public override void Read(PacketReader r)
	{
		this._NQrlM9j7XqyqxuC189AHRlub5Mp = r.ReadBoolean();
		this._V9wbtwgSRDH0SCM4qu3SlALEWXF = r.ReadString();
	}

	// Token: 0x06000414 RID: 1044 RVA: 0x000161E4 File Offset: 0x000143E4
	public override void Write(PacketWriter w)
	{
		w.Write(this._NQrlM9j7XqyqxuC189AHRlub5Mp);
		w.Write(this._V9wbtwgSRDH0SCM4qu3SlALEWXF);
	}

	// Token: 0x0400053F RID: 1343
	public bool _NQrlM9j7XqyqxuC189AHRlub5Mp;

	// Token: 0x04000540 RID: 1344
	public string _V9wbtwgSRDH0SCM4qu3SlALEWXF;
}
