using System;
using ExaltMultiTool.Properties;

// Token: 0x020000B2 RID: 178
internal class BazaarTimer
{
	// Token: 0x060004D6 RID: 1238 RVA: 0x0001BED4 File Offset: 0x0001A0D4
	public BazaarTimer(Client client)
	{
		this._W6Ov6AArxzTTDnCyBtZPqkqNaKf = client;
	}

	// Token: 0x060004D7 RID: 1239 RVA: 0x0001BEF8 File Offset: 0x0001A0F8
	public void _1lYB9SyYVs1zUAIHgLGbUs7pmeb()
	{
		this._1p1Q2QHKnY9NolQalElyji0cG6e = 30;
	}

	// Token: 0x060004D8 RID: 1240 RVA: 0x0001BF10 File Offset: 0x0001A110
	public void _N7XjQOcdGXuT04YvvIcaSYPRc4K()
	{
		if (!Settings.Default.EnableBazaarTimer)
		{
			return;
		}
		if (!this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.MapName.Contains("Bazaar"))
		{
			return;
		}
		if (this._1p1Q2QHKnY9NolQalElyji0cG6e > 0)
		{
			int 1p1Q2QHKnY9NolQalElyji0cG6e = this._1p1Q2QHKnY9NolQalElyji0cG6e;
			this._1p1Q2QHKnY9NolQalElyji0cG6e = 1p1Q2QHKnY9NolQalElyji0cG6e - 1;
			if (1p1Q2QHKnY9NolQalElyji0cG6e % 5 == 0)
			{
				this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.SendToClient("Bazaar Timer", this._1p1Q2QHKnY9NolQalElyji0cG6e.ToString() + " seconds until you can enter portals");
			}
		}
	}

	// Token: 0x060004D9 RID: 1241 RVA: 0x0001BF88 File Offset: 0x0001A188
	private int _U8eOaysP7P2CTM0p09BSTRF4ogK(int percent)
	{
		if (percent > 50)
		{
			return 65280 + 327680 * (100 - percent);
		}
		return 16776960 - 1280 * (50 - percent);
	}

	// Token: 0x040005E2 RID: 1506
	private Client _W6Ov6AArxzTTDnCyBtZPqkqNaKf;

	// Token: 0x040005E3 RID: 1507
	private int _1p1Q2QHKnY9NolQalElyji0cG6e = 30;
}
