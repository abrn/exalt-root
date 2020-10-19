using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x02000019 RID: 25
internal class GameDataMap<T, U> where U : class, IDataStructure<T>
{
	// Token: 0x17000091 RID: 145
	// (get) Token: 0x06000145 RID: 325 RVA: 0x0000CCB8 File Offset: 0x0000AEB8
	// (set) Token: 0x06000146 RID: 326 RVA: 0x0000CCCC File Offset: 0x0000AECC
	public Dictionary<T, U> Map { get; private set; }

	// Token: 0x06000147 RID: 327 RVA: 0x0000CCE0 File Offset: 0x0000AEE0
	private GameDataMap()
	{
	}

	// Token: 0x06000148 RID: 328 RVA: 0x0000CCF4 File Offset: 0x0000AEF4
	public GameDataMap(Dictionary<T, U> map)
	{
		this.Map = map;
	}

	// Token: 0x06000149 RID: 329 RVA: 0x0000CD10 File Offset: 0x0000AF10
	public U ByID(T id)
	{
		U result;
		if (this.Map.TryGetValue(id, out result))
		{
			return result;
		}
		return default(U);
	}

	// Token: 0x0600014A RID: 330 RVA: 0x0000CD38 File Offset: 0x0000AF38
	public U ByName(string name)
	{
		IEnumerable<KeyValuePair<T, U>> source = from e in this.Map
															 where e.Value.Name == name
															 select e;
		if (source.Any<KeyValuePair<T, U>>())
		{
			return source.First<KeyValuePair<T, U>>().Value;
		}
		return default(U);
	}

	// Token: 0x0600014B RID: 331 RVA: 0x0000CD8C File Offset: 0x0000AF8C
	public U Match(Func<U, bool> f)
	{
		return this.Map.First((KeyValuePair<T, U> e) => f(e.Value)).Value;
	}


}
