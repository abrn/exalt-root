using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x020000A8 RID: 168
internal class AntiSpam
{
	// Token: 0x0600048A RID: 1162 RVA: 0x000188D8 File Offset: 0x00016AD8
	public AntiSpam(Client client)
	{
		this._W6Ov6AArxzTTDnCyBtZPqkqNaKf = client;
	}

	// Token: 0x0600048B RID: 1163 RVA: 0x000188F4 File Offset: 0x00016AF4
	public void _IDtpCgDjmC1AQOcZCJSFNAYjlbH(TextPacket text)
	{
		AntiSpam._NALkTCRxB8Bckmseeqnv7i0kCyI nalkTCRxB8Bckmseeqnv7i0kCyI = new AntiSpam._NALkTCRxB8Bckmseeqnv7i0kCyI();
		if (text.NumStars < 0)
		{
			return;
		}
		string text2 = new string(text.Text.Where(new Func<char, bool>(AntiSpam._vivpEx53PFCsVvObdFSPnLCt1jI.<>9._2dxsRhxa41ZKWVboSAEZpelfEdH)).ToArray<char>()).ToLower();
		nalkTCRxB8Bckmseeqnv7i0kCyI._sZl5VVGwUNhpSevGpchDKxixKmq = string.Concat(new string[]
		{
			text2,
			"|",
			text2.Normalize(NormalizationForm.FormC),
			"|",
			text2.Normalize(NormalizationForm.FormD),
			"|",
			text2.Normalize(NormalizationForm.FormKC),
			"|",
			text2.Normalize(NormalizationForm.FormKD)
		});
		IEnumerable<string> source = AntiSpam._bEmgoLZoxB0Dj38HfcyPeu2va8F.Where(new Func<string, bool>(nalkTCRxB8Bckmseeqnv7i0kCyI._q4iwLAZzsaapIsfQm7wlxlSVPoG));
		text.Send = !source.Any<string>();
	}

	// Token: 0x040005A5 RID: 1445
	private Client _W6Ov6AArxzTTDnCyBtZPqkqNaKf;

	// Token: 0x040005A6 RID: 1446
	private static readonly string[] _bEmgoLZoxB0Dj38HfcyPeu2va8F = new string[]
	{
		"oryxsh0p",
		"whtebagnet",
		"realmshopinfo",
		"realmshoplnfo",
		"rotmgmarketc",
		"rpgstashcom",
		"realmitems",
		"reaimitems",
		"reaimltems",
		"realmltems",
		"realmpowernet",
		"reaimpowernet",
		"rea!mkingsxyz",
		"buyrotmgc",
		"lifepotorg",
		"rotmgmaxme",
		"oryxln",
		"rwtmg",
		"rotmgio",
		"realmpower",
		"reaimpower",
		"rwtstore",
		"rwtshop",
		"rotmgrwt",
		"realmgood",
		"reaimgood",
		"rpgrip",
		"rpgrlp",
		"realmshop",
		"reaimshop",
		"realmsh0p",
		"reaimsh0p",
		"realmp0wer",
		"reaimp0wer",
		"relmgood",
		"reimgood",
		"hyuk3d",
		"realmservices",
		"rotmgstore",
		"discordgg",
		"discordcom",
		"discordrwt",
		"rwt",
		"discorddupe",
		"dlscord",
		"dlsc0rd",
		"0rdgg",
		"ordgg"
	};

	// Token: 0x020000A9 RID: 169
	[CompilerGenerated]
	private sealed class _NALkTCRxB8Bckmseeqnv7i0kCyI
	{
		// Token: 0x0600048E RID: 1166 RVA: 0x00018BA4 File Offset: 0x00016DA4
		internal bool _q4iwLAZzsaapIsfQm7wlxlSVPoG(string entry)
		{
			return this._sZl5VVGwUNhpSevGpchDKxixKmq.Contains(entry);
		}

		// Token: 0x040005A7 RID: 1447
		public string _sZl5VVGwUNhpSevGpchDKxixKmq;
	}

	// Token: 0x020000AA RID: 170
	[CompilerGenerated]
	[Serializable]
	private sealed class _vivpEx53PFCsVvObdFSPnLCt1jI
	{
		// Token: 0x06000491 RID: 1169 RVA: 0x00018BEC File Offset: 0x00016DEC
		internal bool _2dxsRhxa41ZKWVboSAEZpelfEdH(char c)
		{
			return char.IsLetter(c) || char.IsNumber(c);
		}

		// Token: 0x040005A8 RID: 1448
		public static readonly AntiSpam._vivpEx53PFCsVvObdFSPnLCt1jI <>9 = new AntiSpam._vivpEx53PFCsVvObdFSPnLCt1jI();

		// Token: 0x040005A9 RID: 1449
		public static Func<char, bool> <>9__2_0;
	}
}
