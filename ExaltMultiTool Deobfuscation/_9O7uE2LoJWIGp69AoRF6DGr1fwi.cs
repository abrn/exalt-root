using System;
using ExaltMultiTool.Properties;

// Token: 0x020000B4 RID: 180
internal class ShowRealLHPot
{
	// Token: 0x060004E6 RID: 1254 RVA: 0x0001C6F4 File Offset: 0x0001A8F4
	public void MapInfo(MapInfoPacket mapInfo)
	{
		this._3bR5NUnBT3Ocs8nEIqQNVvq5khI = (mapInfo.Name == "Lost Halls");
	}

	// Token: 0x060004E7 RID: 1255 RVA: 0x0001C718 File Offset: 0x0001A918
	public void Update(UpdatePacket update)
	{
		if (!this._3bR5NUnBT3Ocs8nEIqQNVvq5khI)
		{
			return;
		}
		if (!Settings.Default.ShowRealLHPot)
		{
			return;
		}
		foreach (Entity eTOyUHUGABMgTlUf3FUyHRn1uVv in update.NewObjs)
		{
			if (eTOyUHUGABMgTlUf3FUyHRn1uVv.ObjectType >= 45239 && eTOyUHUGABMgTlUf3FUyHRn1uVv.ObjectType <= 45243)
			{
				this._gwQbCyGjOqugc22uFkNNeJgLuvV(eTOyUHUGABMgTlUf3FUyHRn1uVv.Status);
			}
		}
	}

	// Token: 0x060004E8 RID: 1256 RVA: 0x0001C77C File Offset: 0x0001A97C
	private void _gwQbCyGjOqugc22uFkNNeJgLuvV(Status status)
	{
		foreach (StatData eawaZQvtvbptP3yFgHw8DNBicDZ in status.Data)
		{
			if (!StatsType.Id(eawaZQvtvbptP3yFgHw8DNBicDZ.Id, StatsType.Size))
			{
				eawaZQvtvbptP3yFgHw8DNBicDZ.IntValue = 200;
				break;
			}
		}
	}

	// Token: 0x040005EA RID: 1514
	private bool _3bR5NUnBT3Ocs8nEIqQNVvq5khI;

	// Token: 0x040005EB RID: 1515
	private const int _APXDifsY0VmuSc6QDF6ZLKM8MfB = 45239;

	// Token: 0x040005EC RID: 1516
	private const int _goIGczIEpqADE4lDbPb756I5jSkA = 45243;
}
