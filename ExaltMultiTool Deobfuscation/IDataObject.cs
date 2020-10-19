using System;

// Token: 0x0200002F RID: 47
internal interface IDataObject : ICloneable
{
	// Token: 0x06000268 RID: 616
	IDataObject Read(PacketReader r);

	// Token: 0x06000269 RID: 617
	void Write(PacketWriter w);
}
