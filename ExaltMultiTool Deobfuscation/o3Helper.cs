using System;
using System.Collections.Generic;
using ExaltMultiTool.Properties;

// Token: 0x020000B9 RID: 185
internal class o3Helper
{
	// Token: 0x06000500 RID: 1280 RVA: 0x0001D720 File Offset: 0x0001B920
	public o3Helper(Client client)
	{
		this._W6Ov6AArxzTTDnCyBtZPqkqNaKf = client;
	}

	// Token: 0x06000501 RID: 1281 RVA: 0x0001D7E8 File Offset: 0x0001B9E8
	public void MapInfo(MapInfoPacket mapInfo)
	{
		this._vb0DX76k2oGNsxzar6rSoSPQjNG = (mapInfo.Name == "Oryx's Sanctuary");
	}

	// Token: 0x06000502 RID: 1282 RVA: 0x0001D80C File Offset: 0x0001BA0C
	public void _9BgsXisaUbFFlj5HLRd76sERUUX(EnemyHitPacket enemyHit)
	{
		if (!this._vb0DX76k2oGNsxzar6rSoSPQjNG)
		{
			return;
		}
		if (!Settings.Default.EnableO3Helper)
		{
			return;
		}
		if (Settings.Default.O3IgnoreShield && this._ZNtO3Z5ZBTYgV6mEURWJLnX7IAE == enemyHit._GNsbx2sQjKyCD4qK29hWl8cxeSqA && this._DvFI4lAdBcrOLNGKR4DD0txYDzE)
		{
			enemyHit.Send = false;
		}
		if (Settings.Default.O3IgnoreCoins && this._QuPiu2GPCzjpjvfRX0glTiLvd4h != -1)
		{
			if (enemyHit._GNsbx2sQjKyCD4qK29hWl8cxeSqA != this._QuPiu2GPCzjpjvfRX0glTiLvd4h)
			{
				if (enemyHit._GNsbx2sQjKyCD4qK29hWl8cxeSqA != this._qkuz687iYpmhOg92JsOC5zdeX2d)
				{
					if (enemyHit._GNsbx2sQjKyCD4qK29hWl8cxeSqA != this._8niSHNdstFUpUXKm5glDNGpsIDb)
					{
						if (enemyHit._GNsbx2sQjKyCD4qK29hWl8cxeSqA != this._wQrWHcEyV10BvnGcxZ341AFxRfc)
						{
							goto IL_99;
						}
					}
				}
				enemyHit.Send = false;
			}
		}
		IL_99:
		if (Settings.Default.O3IgnoreDammah && this._jD069csRPo3TtZu4eUegBA1njRh)
		{
			if (enemyHit._GNsbx2sQjKyCD4qK29hWl8cxeSqA == this._P7AOh27Wmx0yKxIn1YD76DTQnDh)
			{
				enemyHit.Send = false;
			}
		}
	}

	// Token: 0x06000503 RID: 1283 RVA: 0x0001D8E0 File Offset: 0x0001BAE0
	public void _1nwhQXngJ6rNjd7Ufx1bWeF0vhM(ShowEffectPacket showEffect)
	{
		if (!this._vb0DX76k2oGNsxzar6rSoSPQjNG)
		{
			return;
		}
		if (!Settings.Default.EnableO3Helper)
		{
			return;
		}
		if (showEffect.EffectType != EffectType.Flash)
		{
			return;
		}
		if (!this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Objects.ContainsKey(showEffect.TargetId))
		{
			return;
		}
		GameObject dbvvb43n9c5uNQ7JklPD1fnCEnv = this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Objects[showEffect.TargetId];
		if (dbvvb43n9c5uNQ7JklPD1fnCEnv == null)
		{
			return;
		}
		if (dbvvb43n9c5uNQ7JklPD1fnCEnv.ObjectType != 8701)
		{
			if (dbvvb43n9c5uNQ7JklPD1fnCEnv.ObjectType != 8702)
			{
				if (dbvvb43n9c5uNQ7JklPD1fnCEnv.ObjectType != 8703)
				{
					return;
				}
			}
		}
		if (showEffect.PosA._vwAmCOilfBfnOBAh94J77UFd0FV == 5.0 && showEffect.Color.A == 0 && showEffect.Color.A == 0 && showEffect.Color.A == 0 && showEffect.Color.A == 0)
		{
			this._QuPiu2GPCzjpjvfRX0glTiLvd4h = showEffect.TargetId;
			return;
		}
	}

	// Token: 0x06000504 RID: 1284 RVA: 0x0001D9D0 File Offset: 0x0001BBD0
	public void Update(UpdatePacket update)
	{
		if (!this._vb0DX76k2oGNsxzar6rSoSPQjNG)
		{
			return;
		}
		foreach (Entity eTOyUHUGABMgTlUf3FUyHRn1uVv in update.NewObjs)
		{
			if (eTOyUHUGABMgTlUf3FUyHRn1uVv.ObjectType == 45363)
			{
				this._ZNtO3Z5ZBTYgV6mEURWJLnX7IAE = eTOyUHUGABMgTlUf3FUyHRn1uVv.Status.ObjectId;
				this._gwQbCyGjOqugc22uFkNNeJgLuvV(eTOyUHUGABMgTlUf3FUyHRn1uVv.Status);
				return;
			}
			if (this._ZNtO3Z5ZBTYgV6mEURWJLnX7IAE == -1)
			{
				if (eTOyUHUGABMgTlUf3FUyHRn1uVv.ObjectType != 8701)
				{
					if (eTOyUHUGABMgTlUf3FUyHRn1uVv.ObjectType == 8702)
					{
						this._8niSHNdstFUpUXKm5glDNGpsIDb = eTOyUHUGABMgTlUf3FUyHRn1uVv.Status.ObjectId;
					}
					else if (eTOyUHUGABMgTlUf3FUyHRn1uVv.ObjectType != 8703)
					{
						if (eTOyUHUGABMgTlUf3FUyHRn1uVv.ObjectType == 9635)
						{
							this._P7AOh27Wmx0yKxIn1YD76DTQnDh = eTOyUHUGABMgTlUf3FUyHRn1uVv.Status.ObjectId;
						}
					}
					else
					{
						this._wQrWHcEyV10BvnGcxZ341AFxRfc = eTOyUHUGABMgTlUf3FUyHRn1uVv.Status.ObjectId;
					}
				}
				else
				{
					this._qkuz687iYpmhOg92JsOC5zdeX2d = eTOyUHUGABMgTlUf3FUyHRn1uVv.Status.ObjectId;
				}
			}
		}
	}

	// Token: 0x06000505 RID: 1285 RVA: 0x0001DAC4 File Offset: 0x0001BCC4
	public void NewTick(NewTickPacket newTick)
	{
		if (!this._vb0DX76k2oGNsxzar6rSoSPQjNG)
		{
			return;
		}
		foreach (Status seOURj9wT08Ssc6bZOctUjk0KXi in newTick.Statuses)
		{
			if (seOURj9wT08Ssc6bZOctUjk0KXi.ObjectId == this._ZNtO3Z5ZBTYgV6mEURWJLnX7IAE)
			{
				this._gwQbCyGjOqugc22uFkNNeJgLuvV(seOURj9wT08Ssc6bZOctUjk0KXi);
			}
		}
	}

	// Token: 0x06000506 RID: 1286 RVA: 0x0001DB30 File Offset: 0x0001BD30
	private void _gwQbCyGjOqugc22uFkNNeJgLuvV(Status status)
	{
		foreach (StatData eawaZQvtvbptP3yFgHw8DNBicDZ in status.Data)
		{
			if (!StatsType.Id(eawaZQvtvbptP3yFgHw8DNBicDZ.Id, StatsType._IETqTFGc9287W3IAM0SiEryfzal))
			{
				this._DvFI4lAdBcrOLNGKR4DD0txYDzE = this._TAIsGGDN1hlbWv5A5WT7T4CvbcB.Contains(eawaZQvtvbptP3yFgHw8DNBicDZ.IntValue);
				Console.WriteLine(string.Format("Oryx shielding: {0} (alt texture id {1})", this._DvFI4lAdBcrOLNGKR4DD0txYDzE, eawaZQvtvbptP3yFgHw8DNBicDZ.IntValue));
				break;
			}
		}
	}

	// Token: 0x06000507 RID: 1287 RVA: 0x0001DBD0 File Offset: 0x0001BDD0
	internal void _IDtpCgDjmC1AQOcZCJSFNAYjlbH(TextPacket text)
	{
		if (!this._vb0DX76k2oGNsxzar6rSoSPQjNG)
		{
			return;
		}
		if (text.ObjectId > -1)
		{
			return;
		}
		Console.WriteLine("O3 text: <" + text.Name + "> " + text.Text);
		this._jD069csRPo3TtZu4eUegBA1njRh = this._KbHw3Ra3u250PHwUB4Qi44L9irF.Contains(text.Text);
	}

	// Token: 0x04000606 RID: 1542
	private const int _OpjPxCXItadGgntHv7RNLToaLEP = 45363;

	// Token: 0x04000607 RID: 1543
	private const int _FVjnjTGBDwoE9at1V53bhNsKUOp = 8701;

	// Token: 0x04000608 RID: 1544
	private const int _31pBhqgn2zYHYVvXFzNz5MJTh5q = 8702;

	// Token: 0x04000609 RID: 1545
	private const int _3m4b03Cmg413oH4FXzplNZlWTPe = 8703;

	// Token: 0x0400060A RID: 1546
	private const int _ipGLr5560Fq4fhjNLnZ6tNzME5f = 9635;

	// Token: 0x0400060B RID: 1547
	private readonly List<string> _KbHw3Ra3u250PHwUB4Qi44L9irF = new List<string>
	{
		"No more! A steep price is to be paid for this brazen insolence in the face of my own grandeur!",
		"Greetings, dogged peons! I am Dammah, and I shall be your unmaker!",
		"Your uprising ends here. Lay down your feeble weapons and accept death.",
		"Do NOT interrupt me, impatient ones!",
		"I SAID DO NOT INTERRUPT ME! For this I shall hasten your end!"
	};

	// Token: 0x0400060C RID: 1548
	private readonly List<int> _TAIsGGDN1hlbWv5A5WT7T4CvbcB = new List<int>
	{
		8,
		9,
		24,
		53,
		55,
		92,
		94
	};

	// Token: 0x0400060D RID: 1549
	private Client _W6Ov6AArxzTTDnCyBtZPqkqNaKf;

	// Token: 0x0400060E RID: 1550
	private bool _vb0DX76k2oGNsxzar6rSoSPQjNG;

	// Token: 0x0400060F RID: 1551
	private int _ZNtO3Z5ZBTYgV6mEURWJLnX7IAE = -1;

	// Token: 0x04000610 RID: 1552
	private int _qkuz687iYpmhOg92JsOC5zdeX2d = -1;

	// Token: 0x04000611 RID: 1553
	private int _8niSHNdstFUpUXKm5glDNGpsIDb = -1;

	// Token: 0x04000612 RID: 1554
	private int _wQrWHcEyV10BvnGcxZ341AFxRfc = -1;

	// Token: 0x04000613 RID: 1555
	private bool _DvFI4lAdBcrOLNGKR4DD0txYDzE;

	// Token: 0x04000614 RID: 1556
	private int _QuPiu2GPCzjpjvfRX0glTiLvd4h = -1;

	// Token: 0x04000615 RID: 1557
	private bool _jD069csRPo3TtZu4eUegBA1njRh;

	// Token: 0x04000616 RID: 1558
	private int _P7AOh27Wmx0yKxIn1YD76DTQnDh = -1;
}
