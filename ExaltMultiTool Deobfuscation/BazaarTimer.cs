using System;
using ExaltMultiTool.Properties;

// Token: 0x020000B2 RID: 178
internal class BazaarTimer
{
	// Token: 0x060004D6 RID: 1238 RVA: 0x0001BED4 File Offset: 0x0001A0D4
	public BazaarTimer(Client client)
	{
		this.client = client;
	}

	// Token: 0x060004D7 RID: 1239 RVA: 0x0001BEF8 File Offset: 0x0001A0F8
	public void CreateSuccess()
	{
		this.TimeLeft = 30;
	}

	// Token: 0x060004D8 RID: 1240 RVA: 0x0001BF10 File Offset: 0x0001A110
	public void Ping()
	{
		if (!Settings.Default.EnableBazaarTimer)
		{
			return;
		}
		if (!this.client.MapName.Contains("Bazaar"))
		{
			return;
		}
		if (this.TimeLeft > 0)
		{
			int timeLeft = this.TimeLeft;
			this.TimeLeft = timeLeft - 1;
			if (timeLeft % 5 == 0)
			{
				this.client.SendToClient("Bazaar Timer", this.TimeLeft.ToString() + " seconds until you can enter portals");
			}
		}
	}

	// Token: 0x060004D9 RID: 1241 RVA: 0x0001BF88 File Offset: 0x0001A188
	private int GetGreenRedColor(int percent)
	{
		if (percent > 50)
		{
			return 65280 + 327680 * (100 - percent);
		}
		return 16776960 - 1280 * (50 - percent);
	}

	// Token: 0x040005E2 RID: 1506
	private Client client;

	// Token: 0x040005E3 RID: 1507
	private int TimeLeft = 30;
}
