using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ExaltMultiTool.Properties;
using ExaltMultiTool.Proxy.DataStructures;
using ExaltMultiTool.Proxy.Mods;

// Token: 0x020000BA RID: 186
internal class ObjectTracker
{
	// Token: 0x06000508 RID: 1288 RVA: 0x0001DC28 File Offset: 0x0001BE28
	public ObjectTracker(Client client)
	{
		this._W6Ov6AArxzTTDnCyBtZPqkqNaKf = client;
		Projectile.Initialize();
	}

	// Token: 0x06000509 RID: 1289 RVA: 0x0001DC50 File Offset: 0x0001BE50
	public void MapInfo(MapInfoPacket mapInfo)
	{
		this._6cnIerYhzZda8dwMKe0N21tnsKG = mapInfo._pCEEx7DVSfoKsVtOFqw3jIq365d;
		this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.MapWidth = mapInfo._pCEEx7DVSfoKsVtOFqw3jIq365d;
		this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.MapHeight = mapInfo._92R8iOIVdqdeKvPcqUJAUojZv04;
		this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.MapName = mapInfo._Jp3DtIV4aAYZY26sVsXpPQjBRGO;
		this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Tiles = new Square[mapInfo._pCEEx7DVSfoKsVtOFqw3jIq365d * mapInfo._92R8iOIVdqdeKvPcqUJAUojZv04];
		this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Players.Clear();
		this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Enemies.Clear();
		this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Objects.Clear();
		foreach (KeyValuePair<int, Dictionary<int, Projectile>> keyValuePair in this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.projectiles)
		{
			keyValuePair.Value.Clear();
		}
		this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.projectiles.Clear();
	}

	// Token: 0x0600050A RID: 1290 RVA: 0x0001DD4C File Offset: 0x0001BF4C
	public void _1lYB9SyYVs1zUAIHgLGbUs7pmeb()
	{
		if (!Settings.Default.DisableSystemMessages)
		{
			Task.Run(new Action(this._4yDmq1wQzdpqsMz61vSBKKxThyO));
		}
	}

	// Token: 0x0600050B RID: 1291 RVA: 0x0001DD78 File Offset: 0x0001BF78
	private void _4yDmq1wQzdpqsMz61vSBKKxThyO()
	{
		Thread.Sleep(500);
		this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.SendToClient("RealmStock", "Connected to MultiTool Proxy!");
	}

	// Token: 0x0600050C RID: 1292 RVA: 0x0001DDA4 File Offset: 0x0001BFA4
	public void Update(UpdatePacket update)
	{
		foreach (_hVYZnKlD1p4NKgHvEIulwTgi91f hVYZnKlD1p4NKgHvEIulwTgi91f in update._ggcOirasY7xrclnb5yxgWCbeJam)
		{
			this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Tiles[(int)hVYZnKlD1p4NKgHvEIulwTgi91f._MFEyfKFQqtcdaBxZbAOPzXMB8iP * this._6cnIerYhzZda8dwMKe0N21tnsKG + (int)hVYZnKlD1p4NKgHvEIulwTgi91f._vwAmCOilfBfnOBAh94J77UFd0FV] = new Square(_JzyrOApzC09RC3fmb10FDURmyCl.Tiles.ByID(hVYZnKlD1p4NKgHvEIulwTgi91f._k9uWQCZd8WqDr6yiKRmrLtst3KX), hVYZnKlD1p4NKgHvEIulwTgi91f._MFEyfKFQqtcdaBxZbAOPzXMB8iP, hVYZnKlD1p4NKgHvEIulwTgi91f._vwAmCOilfBfnOBAh94J77UFd0FV, hVYZnKlD1p4NKgHvEIulwTgi91f._k9uWQCZd8WqDr6yiKRmrLtst3KX);
		}
		Entity[] jyJGMVpAZL4M3WPGiyvdnxz1cTH = update.NewObjs;
		int i = 0;
		while (i < jyJGMVpAZL4M3WPGiyvdnxz1cTH.Length)
		{
			Entity eTOyUHUGABMgTlUf3FUyHRn1uVv = jyJGMVpAZL4M3WPGiyvdnxz1cTH[i];
			GameObject dbvvb43n9c5uNQ7JklPD1fnCEnv = new GameObject(eTOyUHUGABMgTlUf3FUyHRn1uVv);
			if (dbvvb43n9c5uNQ7JklPD1fnCEnv._Zfx7ZfyZsrOtjl3lIHaVkBDWPNH)
			{
				goto IL_175;
			}
			if (dbvvb43n9c5uNQ7JklPD1fnCEnv._50Ms1zsqax9Ua48PaWMPQfIENYb)
			{
				if (this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Players.ContainsKey(eTOyUHUGABMgTlUf3FUyHRn1uVv.Status.ObjectId))
				{
					this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Players.Remove(eTOyUHUGABMgTlUf3FUyHRn1uVv.Status.ObjectId);
				}
				this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Players.Add(eTOyUHUGABMgTlUf3FUyHRn1uVv.Status.ObjectId, dbvvb43n9c5uNQ7JklPD1fnCEnv);
				if (dbvvb43n9c5uNQ7JklPD1fnCEnv.ObjectId == this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.PlayerId && Settings.Default.EnableGlow)
				{
					using (List<StatData>.Enumerator enumerator = eTOyUHUGABMgTlUf3FUyHRn1uVv.Status.Data.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							StatData eawaZQvtvbptP3yFgHw8DNBicDZ = enumerator.Current;
							if (StatsType.Id(eawaZQvtvbptP3yFgHw8DNBicDZ.Id, StatsType._jQToCmezajoMkD7AWz3F9w0fiQJ))
							{
								eawaZQvtvbptP3yFgHw8DNBicDZ.IntValue = 100;
								break;
							}
						}
						goto IL_23F;
					}
					goto IL_175;
				}
			}
			IL_23F:
			if (eTOyUHUGABMgTlUf3FUyHRn1uVv.Status.ObjectId == this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.PlayerId)
			{
				this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player = dbvvb43n9c5uNQ7JklPD1fnCEnv;
			}
			if (this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Objects.ContainsKey(eTOyUHUGABMgTlUf3FUyHRn1uVv.Status.ObjectId))
			{
				this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Objects.Remove(eTOyUHUGABMgTlUf3FUyHRn1uVv.Status.ObjectId);
			}
			this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Objects.Add(eTOyUHUGABMgTlUf3FUyHRn1uVv.Status.ObjectId, dbvvb43n9c5uNQ7JklPD1fnCEnv);
			i++;
			continue;
			IL_175:
			if (this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Enemies.ContainsKey(eTOyUHUGABMgTlUf3FUyHRn1uVv.Status.ObjectId))
			{
				this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Enemies.Remove(eTOyUHUGABMgTlUf3FUyHRn1uVv.Status.ObjectId);
			}
			this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Enemies.Add(eTOyUHUGABMgTlUf3FUyHRn1uVv.Status.ObjectId, dbvvb43n9c5uNQ7JklPD1fnCEnv);
			goto IL_23F;
		}
		foreach (int key in update.Drops)
		{
			if (this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Enemies.ContainsKey(key))
			{
				this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Enemies.Remove(key);
			}
			if (this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Players.ContainsKey(key))
			{
				this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Players.Remove(key);
			}
			if (this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Objects.ContainsKey(key))
			{
				this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Objects.Remove(key);
			}
		}
	}

	// Token: 0x0600050D RID: 1293 RVA: 0x0001E0B4 File Offset: 0x0001C2B4
	public void NewTick(NewTickPacket newTick)
	{
		foreach (Status seOURj9wT08Ssc6bZOctUjk0KXi in newTick.Statuses)
		{
			if (this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Objects.ContainsKey(seOURj9wT08Ssc6bZOctUjk0KXi.ObjectId))
			{
				this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Objects[seOURj9wT08Ssc6bZOctUjk0KXi.ObjectId]._Se7aqnZW3CHDIceb2hAge7QmcPY(seOURj9wT08Ssc6bZOctUjk0KXi, newTick._O8ZPS6Ibh455w0oY1jBdktfRWIA, newTick._AKwrGdNlyCcdoE29BXWWchVg2fJ, newTick._AKwrGdNlyCcdoE29BXWWchVg2fJ, (long)this._y197qHnAdnQHPqX30R0Bq0tjIOcA, false);
			}
		}
	}

	// Token: 0x0600050E RID: 1294 RVA: 0x0001E150 File Offset: 0x0001C350
	public void move(MovePacket move)
	{
		this._y197qHnAdnQHPqX30R0Bq0tjIOcA = Environment.TickCount;
		if (this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player != null)
		{
			this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Player._G6mmnFaa6rCvH24Jwj69ERi78ww = move._l6SobSknmpzcoMgQdVhaWNqcv8D;
		}
	}

	// Token: 0x0600050F RID: 1295 RVA: 0x0001E18C File Offset: 0x0001C38C
	public void _Qz49aY7UXgmnBNNMA6Q6IEQtadk(_CBWrHXLbrCktla3qkqXNmNymbvH enemyShoot)
	{
		if (!this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Objects.ContainsKey(enemyShoot._o1vIAcFEkLsw697hhlSgXnC4w9g))
		{
			return;
		}
		GameObject dbvvb43n9c5uNQ7JklPD1fnCEnv = this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Objects[enemyShoot._o1vIAcFEkLsw697hhlSgXnC4w9g];
		if (!Projectile.ObjectTypeToProjectileIdStructureMap.ContainsKey((int)dbvvb43n9c5uNQ7JklPD1fnCEnv.ObjectType))
		{
			Console.WriteLine(string.Concat(new string[]
			{
				"Unable to find enemy type in map, enemytype: ",
				dbvvb43n9c5uNQ7JklPD1fnCEnv.ObjectType.ToString(),
				" (",
				dbvvb43n9c5uNQ7JklPD1fnCEnv._aN5iXUMyRRH5dqciRi77IpySUoh,
				")"
			}));
			return;
		}
		Dictionary<byte, ProjectileStructure> dictionary = Projectile.ObjectTypeToProjectileIdStructureMap[(int)dbvvb43n9c5uNQ7JklPD1fnCEnv.ObjectType];
		if (dictionary.ContainsKey(enemyShoot._U7AZyGcFQm4AJLAEAuhbwgnobvG))
		{
			Dictionary<int, Projectile> dictionary2;
			if (!this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.projectiles.ContainsKey(enemyShoot._o1vIAcFEkLsw697hhlSgXnC4w9g))
			{
				dictionary2 = new Dictionary<int, Projectile>();
				this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.projectiles.Add(enemyShoot._o1vIAcFEkLsw697hhlSgXnC4w9g, dictionary2);
			}
			else
			{
				dictionary2 = this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.projectiles[enemyShoot._o1vIAcFEkLsw697hhlSgXnC4w9g];
			}
			ProjectileStructure structure = dictionary[enemyShoot._U7AZyGcFQm4AJLAEAuhbwgnobvG];
			for (int i = 0; i < (int)enemyShoot._iJYXKz0RNaSBkr15qJpRokSEGeT; i++)
			{
				byte b = (byte)(((int)enemyShoot._0v4mmgyFOmt9eSc23UclkqyBncC + i) % 256);
				Projectile value = default(Projectile);
				value.Id = b;
				value.OwnerId = enemyShoot._o1vIAcFEkLsw697hhlSgXnC4w9g;
				value.Damage = (int)enemyShoot._Q1PiJQ99KBCJeLcZ0HOk3AUAjIP;
				value.ProjectileType = enemyShoot._U7AZyGcFQm4AJLAEAuhbwgnobvG;
				value.Structure = structure;
				if (dictionary2.ContainsKey((int)b))
				{
					dictionary2[(int)b] = value;
				}
				else
				{
					dictionary2.Add((int)b, value);
				}
			}
			return;
		}
		Console.WriteLine(string.Concat(new string[]
		{
			"Unable to find enemy projectile type in map, enemytype: ",
			dbvvb43n9c5uNQ7JklPD1fnCEnv.ObjectType.ToString(),
			" (",
			dbvvb43n9c5uNQ7JklPD1fnCEnv._aN5iXUMyRRH5dqciRi77IpySUoh,
			")"
		}));
	}

	// Token: 0x04000617 RID: 1559
	private Client _W6Ov6AArxzTTDnCyBtZPqkqNaKf;

	// Token: 0x04000618 RID: 1560
	private int _y197qHnAdnQHPqX30R0Bq0tjIOcA = -1;

	// Token: 0x04000619 RID: 1561
	private int _6cnIerYhzZda8dwMKe0N21tnsKG;
}
