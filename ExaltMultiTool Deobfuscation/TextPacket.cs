using System;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000097 RID: 151
internal class TextPacket : Packet
{
	// Token: 0x17000130 RID: 304
	// (get) Token: 0x06000433 RID: 1075 RVA: 0x000168F4 File Offset: 0x00014AF4
	public override PacketType Type
	{
		get
		{
			return PacketType.TEXT;
		}
	}

	// Token: 0x06000434 RID: 1076 RVA: 0x00016904 File Offset: 0x00014B04
	public override void Read(PacketReader r)
	{
		this.Name = r.ReadString();
		this.ObjectId = r.ReadInt32();
		this.NumStars = r.ReadInt32();
		this.BubbleTime = r.ReadByte();
		this.Recipient = r.ReadString();
		this.Text = r.ReadString();
		this.CleanText = r.ReadString();
		this.isSupporter = r.ReadBoolean();
		this.starBg = r.ReadInt32();
	}

	// Token: 0x06000435 RID: 1077 RVA: 0x00016980 File Offset: 0x00014B80
	public override void Write(PacketWriter w)
	{
		w.Write(this.Name);
		w.Write(this.ObjectId);
		w.Write(this.NumStars);
		w.Write(this.BubbleTime);
		w.Write(this.Recipient);
		w.Write(this.Text);
		w.Write(this.CleanText);
		w.Write(this.isSupporter);
		w.Write(this.starBg);
	}

	// Token: 0x06000436 RID: 1078 RVA: 0x000169FC File Offset: 0x00014BFC
	public static TextPacket _mUSCETHrZHWd7DqaW04ilsvEbiCA(string sender, string message)
	{
		TextPacket cbwOjnzusZzuPkHfx7wuwePHqrf = (TextPacket)Packet.Create(PacketType.TEXT);
		cbwOjnzusZzuPkHfx7wuwePHqrf.BubbleTime = 0;
		cbwOjnzusZzuPkHfx7wuwePHqrf.CleanText = message;
		cbwOjnzusZzuPkHfx7wuwePHqrf.Name = "";
		cbwOjnzusZzuPkHfx7wuwePHqrf.NumStars = -1;
		cbwOjnzusZzuPkHfx7wuwePHqrf.ObjectId = -1;
		cbwOjnzusZzuPkHfx7wuwePHqrf.Recipient = "";
		cbwOjnzusZzuPkHfx7wuwePHqrf.Text = (string.IsNullOrEmpty(sender) ? message : ("<" + sender + "> " + message));
		return cbwOjnzusZzuPkHfx7wuwePHqrf;
	}

	// Token: 0x06000437 RID: 1079 RVA: 0x00016A68 File Offset: 0x00014C68
	public static TextPacket _FqfB8lZabDqgXbSDkwlX4ALcdCp(string message)
	{
		TextPacket cbwOjnzusZzuPkHfx7wuwePHqrf = Packet._queixqbllHBpUVN7AOyM0TqcZNH<TextPacket>(PacketType.TEXT);
		cbwOjnzusZzuPkHfx7wuwePHqrf.BubbleTime = 0;
		cbwOjnzusZzuPkHfx7wuwePHqrf.CleanText = message;
		cbwOjnzusZzuPkHfx7wuwePHqrf.Name = string.Empty;
		cbwOjnzusZzuPkHfx7wuwePHqrf.NumStars = -1;
		cbwOjnzusZzuPkHfx7wuwePHqrf.ObjectId = -1;
		cbwOjnzusZzuPkHfx7wuwePHqrf.Recipient = string.Empty;
		cbwOjnzusZzuPkHfx7wuwePHqrf.Text = message;
		return cbwOjnzusZzuPkHfx7wuwePHqrf;
	}

	// Token: 0x04000567 RID: 1383
	public string Name;

	// Token: 0x04000568 RID: 1384
	public int ObjectId;

	// Token: 0x04000569 RID: 1385
	public int NumStars;

	// Token: 0x0400056A RID: 1386
	public byte BubbleTime;

	// Token: 0x0400056B RID: 1387
	public string Recipient;

	// Token: 0x0400056C RID: 1388
	public string Text;

	// Token: 0x0400056D RID: 1389
	public string CleanText;

	// Token: 0x0400056E RID: 1390
	public bool isSupporter;

	// Token: 0x0400056F RID: 1391
	public int starBg;
}
