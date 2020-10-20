using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000082 RID: 130
internal class MapInfoPacket : Packet
{
	// Token: 0x1700011B RID: 283
	// (get) Token: 0x060003DC RID: 988 RVA: 0x00015874 File Offset: 0x00013A74
	public override PacketType Type
	{
		get
		{
			return PacketType.MAPINFO;
		}
	}

	// Token: 0x060003DD RID: 989 RVA: 0x00015884 File Offset: 0x00013A84
	public override void Read(PacketReader r)
	{
		this.Width = r.ReadInt32();
		this.Height = r.ReadInt32();
		this.Name = r.ReadString();
		this.DisplayName = r.ReadString();
		this.RealmName = r.ReadString();
		this.Fp = r.ReadUInt32();
		this.Background = r.ReadInt32();
		this.Difficulty = r.ReadInt32();
		this.AllowPlayerTeleport = r.ReadBoolean();
		this.ShowDisplays = r.ReadBoolean();
		this.MaxPlayers = r.ReadInt16();
		this.ConnectionGuid = r.ReadString();
		this.GameOpenedTime = r.ReadUInt32();
		this.ClientXML = new string[(int)r.ReadInt16()];
		for (int i = 0; i < this.ClientXML.Length; i++)
		{
			this.ClientXML[i] = r.ReadUTF32();
		}
		this.ExtraXML = new string[(int)r.ReadInt16()];
		for (int j = 0; j < this.ExtraXML.Length; j++)
		{
			this.ExtraXML[j] = r.ReadUTF32();
		}
		this.ServerVersion = r.ReadString();
	}

	// Token: 0x060003DE RID: 990 RVA: 0x000159A0 File Offset: 0x00013BA0
	public override void Write(PacketWriter w)
	{
		w.Write(this.Width);
		w.Write(this.Height);
		w.Write(this.Name);
		w.Write(this.DisplayName);
		w.Write(this.RealmName);
		w.Write(this.Fp);
		w.Write(this.Background);
		w.Write(this.Difficulty);
		w.Write(this.AllowPlayerTeleport);
		w.Write(this.ShowDisplays);
		w.Write(this.MaxPlayers);
		w.Write(this.ConnectionGuid);
		w.Write(this.GameOpenedTime);
		w.Write((short)this.ClientXML.Length);
		foreach (string value in this.ClientXML)
		{
			w.WriteUTF32(value);
		}
		w.Write((short)this.ExtraXML.Length);
		foreach (string value2 in this.ExtraXML)
		{
			w.WriteUTF32(value2);
		}
		w.Write(this.ServerVersion);
	}

	// Token: 0x04000514 RID: 1300
	public int Width;

	// Token: 0x04000515 RID: 1301
	public int Height;

	// Token: 0x04000516 RID: 1302
	public string Name;

	// Token: 0x04000517 RID: 1303
	public string DisplayName;

	// Token: 0x04000518 RID: 1304
	public string RealmName;

	// Token: 0x04000519 RID: 1305
	public int Difficulty;

	// Token: 0x0400051A RID: 1306
	public uint Fp;

	// Token: 0x0400051B RID: 1307
	public int Background;

	// Token: 0x0400051C RID: 1308
	public bool AllowPlayerTeleport;

	// Token: 0x0400051D RID: 1309
	public bool ShowDisplays;

	// Token: 0x0400051E RID: 1310
	public short MaxPlayers;

	// Token: 0x0400051F RID: 1311
	public string ConnectionGuid;

	// Token: 0x04000520 RID: 1312
	public uint GameOpenedTime;

	// Token: 0x04000521 RID: 1313
	public string ServerVersion;

	// Token: 0x04000522 RID: 1314
	public string[] ClientXML = new string[0];

	// Token: 0x04000523 RID: 1315
	public string[] ExtraXML = new string[0];
}
