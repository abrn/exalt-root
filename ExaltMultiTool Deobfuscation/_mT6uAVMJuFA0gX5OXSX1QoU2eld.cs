using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x0200005E RID: 94
internal class _mT6uAVMJuFA0gX5OXSX1QoU2eld : Packet
{
	// Token: 0x170000F7 RID: 247
	// (get) Token: 0x0600034C RID: 844 RVA: 0x000143EC File Offset: 0x000125EC
	public override PacketType Type
	{
		get
		{
			return PacketType.ACTIVEPETUPDATEREQUEST;
		}
	}

	// Token: 0x0600034D RID: 845 RVA: 0x000143FC File Offset: 0x000125FC
	public override void Read(PacketReader r)
	{
		this._PTijZobtOKKA2E4S2Vr2w9afHxg = (int)r.ReadByte();
		this._gMQB8nUc90NEebz9oVexr6Ppdmb = (uint)r.ReadInt32();
	}

	// Token: 0x0600034E RID: 846 RVA: 0x00014424 File Offset: 0x00012624
	public override void Write(PacketWriter w)
	{
		w.Write((byte)this._PTijZobtOKKA2E4S2Vr2w9afHxg);
		w.Write((int)this._gMQB8nUc90NEebz9oVexr6Ppdmb);
	}

	// Token: 0x040004A5 RID: 1189
	public const int _LQeSZsnE23gnfJcvGKG3fZG9Lfh = 1;

	// Token: 0x040004A6 RID: 1190
	public const int _U3nfBQLa9WjlucSuMeDPriY5VxG = 2;

	// Token: 0x040004A7 RID: 1191
	public const int _eSGbmSWMCqS08zDHpivVBD8OAWf = 3;

	// Token: 0x040004A8 RID: 1192
	public int _PTijZobtOKKA2E4S2Vr2w9afHxg;

	// Token: 0x040004A9 RID: 1193
	public uint _gMQB8nUc90NEebz9oVexr6Ppdmb;
}
