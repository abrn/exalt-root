using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x0200006E RID: 110
internal class AccountListPacket : Packet
{
	// Token: 0x17000107 RID: 263
	// (get) Token: 0x0600038C RID: 908 RVA: 0x00014BB8 File Offset: 0x00012DB8
	public override PacketType Type
	{
		get
		{
			return PacketType.ACCOUNTLIST;
		}
	}

	// Token: 0x0600038D RID: 909 RVA: 0x00014BC8 File Offset: 0x00012DC8
	public override void Read(PacketReader r)
	{
		this.AccountListId = r.ReadInt32();
		this.AccountIds = new string[(int)r.ReadInt16()];
		for (int i = 0; i < this.AccountIds.Length; i++)
		{
			this.AccountIds[i] = r.ReadString();
		}
		this.LockAction = r.ReadInt32();
	}

	// Token: 0x0600038E RID: 910 RVA: 0x00014C20 File Offset: 0x00012E20
	public override void Write(PacketWriter w)
	{
		w.Write(this.AccountListId);
		w.Write((short)this.AccountIds.Length);
		foreach (string value in this.AccountIds)
		{
			w.Write(value);
		}
		w.Write(this.LockAction);
	}

	// Token: 0x040004CE RID: 1230
	public int AccountListId;

	// Token: 0x040004CF RID: 1231
	public string[] AccountIds;

	// Token: 0x040004D0 RID: 1232
	public int LockAction;
}
