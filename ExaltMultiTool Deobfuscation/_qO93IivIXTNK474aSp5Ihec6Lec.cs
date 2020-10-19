using System;
using System.Text;
using ExaltMultiTool.Properties;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x020000B5 RID: 181
internal class IpJoin
{
	// Token: 0x060004EA RID: 1258 RVA: 0x0001C7FC File Offset: 0x0001A9FC
	public IpJoin(Client client)
	{
		this._W6Ov6AArxzTTDnCyBtZPqkqNaKf = client;
	}

	// Token: 0x060004EB RID: 1259 RVA: 0x0001C818 File Offset: 0x0001AA18
	public void _mO6fHYBlzV19omdsENCIzVm4M4e(string ip)
	{
		this._ZcTrI4rKikyIzcHz4twt8IkJdyc = ip;
	}

	// Token: 0x060004EC RID: 1260 RVA: 0x0001C82C File Offset: 0x0001AA2C
	public void text(PlayerTextPacket text)
	{
		if (!Settings.Default.EnableGotoCommand)
		{
			return;
		}
		if (!text.Text.StartsWith("/"))
		{
			return;
		}
		string[] array = text.Text.Split(new char[]
		{
			' '
		});
		string a = array[0].ToLower();
		if (a == "/ip")
		{
			text.Send = false;
			this._KXmOjWhuRyFWt1WKcOyfLJbmImf("Server IP: " + this._ZcTrI4rKikyIzcHz4twt8IkJdyc);
			return;
		}
		if (a == "/iunderstandthiswarning")
		{
			text.Send = false;
			this._KXmOjWhuRyFWt1WKcOyfLJbmImf("Warning acknowledged and disabled, you are free to use /goto now.");
			Settings.Default.EnableGotoCommandWarningAcknowledged = true;
			Settings.Default.Save();
			return;
		}
		if (!(a == "/goto"))
		{
			return;
		}
		text.Send = false;
		if (!Settings.Default.EnableGotoCommandWarningAcknowledged)
		{
			this._KXmOjWhuRyFWt1WKcOyfLJbmImf("WARNING! People can effectively steal your login credentials with /goto and gain access to your account. If someone told you to paste this in, you probably don't want to do it. They can host a malicious server that saves your encrypted email and password when you connect, which lets them login to your account in game. YOU HAVE BEEN WARNED! Type /iUnderstandThisWarning to disable this warning.");
			return;
		}
		if (array.Length >= 2 && !string.IsNullOrEmpty(array[1]))
		{
			this._gGuRSlFatN7EhdIHBBnokR8ZAWBA(array[1]);
		}
	}

	// Token: 0x060004ED RID: 1261 RVA: 0x0001C920 File Offset: 0x0001AB20
	private string _pDA5GhmYeGD81g0boX28FeYSERD(string s)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (char c in s)
		{
			if (char.IsLetterOrDigit(c) || c == '.' || c == '-')
			{
				stringBuilder.Append(c);
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x060004EE RID: 1262 RVA: 0x0001C970 File Offset: 0x0001AB70
	private void _KXmOjWhuRyFWt1WKcOyfLJbmImf(string text)
	{
		_CBwOjnzusZzuPkHfx7wuwePHqrf cbwOjnzusZzuPkHfx7wuwePHqrf = (_CBwOjnzusZzuPkHfx7wuwePHqrf)Packet.Create(PacketType.TEXT);
		cbwOjnzusZzuPkHfx7wuwePHqrf._TYWwSeph7gPoT0Ukf1ixUStS9bD = text;
		cbwOjnzusZzuPkHfx7wuwePHqrf._IDtpCgDjmC1AQOcZCJSFNAYjlbH = cbwOjnzusZzuPkHfx7wuwePHqrf._TYWwSeph7gPoT0Ukf1ixUStS9bD;
		cbwOjnzusZzuPkHfx7wuwePHqrf._VOCc8CZlF3S0HMq8xxgy2zaOkBn = -1;
		cbwOjnzusZzuPkHfx7wuwePHqrf._605Ligxeaj9k9kBV8zQhhFhgTGl = -1;
		cbwOjnzusZzuPkHfx7wuwePHqrf._Jp3DtIV4aAYZY26sVsXpPQjBRGO = "";
		cbwOjnzusZzuPkHfx7wuwePHqrf._TL2Ac3BFZHvDuoDwJImuUlObseO = "";
		this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.SendToClient(cbwOjnzusZzuPkHfx7wuwePHqrf);
	}

	// Token: 0x060004EF RID: 1263 RVA: 0x0001C9CC File Offset: 0x0001ABCC
	private void _gGuRSlFatN7EhdIHBBnokR8ZAWBA(string ip)
	{
		string s = Guid.NewGuid().ToString();
		byte[] bytes = Encoding.ASCII.GetBytes(s);
		string key = Client.ByteArrayToString(bytes);
		ReconnectPacket u9Kj4tAStSlt3Dcm6rdEl60w8MG = (ReconnectPacket)Packet.Create(PacketType.RECONNECT);
		u9Kj4tAStSlt3Dcm6rdEl60w8MG.GameId = -2;
		u9Kj4tAStSlt3Dcm6rdEl60w8MG.Host = ip;
		u9Kj4tAStSlt3Dcm6rdEl60w8MG.Port = 2050;
		u9Kj4tAStSlt3Dcm6rdEl60w8MG.isFromArena = false;
		u9Kj4tAStSlt3Dcm6rdEl60w8MG.Key = new byte[0];
		u9Kj4tAStSlt3Dcm6rdEl60w8MG.KeyTime = -1;
		u9Kj4tAStSlt3Dcm6rdEl60w8MG.Name = "Recon";
		u9Kj4tAStSlt3Dcm6rdEl60w8MG.State = string.Empty;
		ReconnectPacket u9Kj4tAStSlt3Dcm6rdEl60w8MG2 = (ReconnectPacket)Packet.Create(PacketType.RECONNECT);
		u9Kj4tAStSlt3Dcm6rdEl60w8MG2.GameId = -2;
		u9Kj4tAStSlt3Dcm6rdEl60w8MG2.Host = "127.0.0.1";
		u9Kj4tAStSlt3Dcm6rdEl60w8MG2.Port = 2050;
		u9Kj4tAStSlt3Dcm6rdEl60w8MG2.isFromArena = false;
		u9Kj4tAStSlt3Dcm6rdEl60w8MG2.Key = bytes;
		u9Kj4tAStSlt3Dcm6rdEl60w8MG2.KeyTime = -1;
		u9Kj4tAStSlt3Dcm6rdEl60w8MG2.Name = "Realm";
		u9Kj4tAStSlt3Dcm6rdEl60w8MG2.State = string.Empty;
		this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.Proxy._15LfsipxJm1I78mh9UGesTHpsVC.TryAdd(key, u9Kj4tAStSlt3Dcm6rdEl60w8MG);
		this._W6Ov6AArxzTTDnCyBtZPqkqNaKf._RUDdpffUqrc18m4ldj2l3yrb1t9("Connecting to: " + ip);
		this._W6Ov6AArxzTTDnCyBtZPqkqNaKf.SendToClient(u9Kj4tAStSlt3Dcm6rdEl60w8MG2);
	}

	// Token: 0x040005ED RID: 1517
	private Client _W6Ov6AArxzTTDnCyBtZPqkqNaKf;

	// Token: 0x040005EE RID: 1518
	private string _ZcTrI4rKikyIzcHz4twt8IkJdyc;
}
