using System;

// Token: 0x020000A5 RID: 165
internal class AntiDdos
{
	// Token: 0x0600046E RID: 1134 RVA: 0x000177BC File Offset: 0x000159BC
	public void NewTick()
	{
		this._invitesThisTick = 0;
	}

	// Token: 0x0600046F RID: 1135 RVA: 0x000177D0 File Offset: 0x000159D0
	public void Invite(InvitedToGuildPacket invitedToGuild)
	{
		int invitesThisTick = this._invitesThisTick;
		this._invitesThisTick = invitesThisTick + 1;
		if (invitesThisTick > 5)
		{
			invitedToGuild.Send = false;
		}
	}

	// Token: 0x04000593 RID: 1427
	private int _invitesThisTick;
}
