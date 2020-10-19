using System;

// Token: 0x020000C2 RID: 194
internal interface IDataStructure<T>
{
	// Token: 0x1700013B RID: 315
	// (get) Token: 0x06000523 RID: 1315
	string Name { get; }

	// Token: 0x1700013C RID: 316
	// (get) Token: 0x06000524 RID: 1316
	T ID { get; }
}
