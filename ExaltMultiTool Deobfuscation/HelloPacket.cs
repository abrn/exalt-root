using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000056 RID: 86
internal class HelloPacket : Packet
{
	// Token: 0x170000EF RID: 239
	// (get) Token: 0x0600032C RID: 812 RVA: 0x00013EA4 File Offset: 0x000120A4
	public override PacketType Type
	{
		get
		{
			return PacketType.HELLO;
		}
	}

	// Token: 0x0600032D RID: 813 RVA: 0x00013EB4 File Offset: 0x000120B4
	public override void Read(PacketReader r)
	{
		this.BuildVersion = r.ReadString();
		this.GameId = r.ReadInt32();
		this.GUID = r.ReadString();
		this.Random1 = r.ReadInt32();
		this.Password = r.ReadString();
		this.Random2 = r.ReadInt32();
		this.Secret = r.ReadString();
		this.KeyTime = r.ReadInt32();
		this.Key = (byte[])r.ReadBytes((int)r.ReadInt16());
		this.MapJSON = r.ReadUTF32();
		this.EntryTag = r.ReadString();
		this.GameNet = r.ReadString();
		this.GameNetUserId = r.ReadString();
		this.PlayPlatform = r.ReadString();
		this.PlatformToken = r.ReadString();
		this.UserToken = r.ReadString();
		this.ClientToken = r.ReadString();
		this.PreviousConnectionGuid = r.ReadString();
	}

	// Token: 0x0600032E RID: 814 RVA: 0x00013FA4 File Offset: 0x000121A4
	public override void Write(PacketWriter w)
	{
		w.Write(this.BuildVersion);
		w.Write(this.GameId);
		w.Write(this.GUID);
		w.Write(this.Random1);
		w.Write(this.Password);
		w.Write(this.Random2);
		w.Write(this.Secret);
		w.Write(this.KeyTime);
		w.Write((short)this.Key.Length);
		w.Write((byte[])this.Key);
		w.WriteUTF32(this.MapJSON);
		w.Write(this.EntryTag);
		w.Write(this.GameNet);
		w.Write(this.GameNetUserId);
		w.Write(this.PlayPlatform);
		w.Write(this.PlatformToken);
		w.Write(this.UserToken);
		w.Write(this.ClientToken);
		w.Write(this.PreviousConnectionGuid);
	}

	// Token: 0x04000485 RID: 1157
	public string BuildVersion;

	// Token: 0x04000486 RID: 1158
	public int GameId;

	// Token: 0x04000487 RID: 1159
	public string GUID;

	// Token: 0x04000488 RID: 1160
	public int Random1;

	// Token: 0x04000489 RID: 1161
	public string Password;

	// Token: 0x0400048A RID: 1162
	public int Random2;

	// Token: 0x0400048B RID: 1163
	public string Secret;

	// Token: 0x0400048C RID: 1164
	public int KeyTime;

	// Token: 0x0400048D RID: 1165
	public byte[] Key;

	// Token: 0x0400048E RID: 1166
	public string MapJSON;

	// Token: 0x0400048F RID: 1167
	public string EntryTag;

	// Token: 0x04000490 RID: 1168
	public string GameNet;

	// Token: 0x04000491 RID: 1169
	public string GameNetUserId;

	// Token: 0x04000492 RID: 1170
	public string PlayPlatform;

	// Token: 0x04000493 RID: 1171
	public string PlatformToken;

	// Token: 0x04000494 RID: 1172
	public string UserToken;

	// Token: 0x04000495 RID: 1173
	public string ClientToken;

	// Token: 0x04000496 RID: 1174
	public string PreviousConnectionGuid;
}
