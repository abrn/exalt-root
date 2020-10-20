using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;

// Token: 0x02000023 RID: 35
internal class ServerParser
{
	// Token: 0x170000CC RID: 204
	// (get) Token: 0x06000214 RID: 532 RVA: 0x0000F170 File Offset: 0x0000D370
	// (set) Token: 0x06000215 RID: 533 RVA: 0x0000F184 File Offset: 0x0000D384
	public static Dictionary<string, string> _IOpSuG4guyYLeez9LywVYmMYQtG { get; private set; } = new Dictionary<string, string>();

	// Token: 0x170000CD RID: 205
	// (get) Token: 0x06000216 RID: 534 RVA: 0x0000F198 File Offset: 0x0000D398
	// (set) Token: 0x06000217 RID: 535 RVA: 0x0000F1AC File Offset: 0x0000D3AC
	public static Dictionary<string, string> ServerAbbreviations { get; private set; } = new Dictionary<string, string>();

	// Token: 0x06000218 RID: 536 RVA: 0x0000F1C0 File Offset: 0x0000D3C0
	public static void Parse()
	{
		Console.WriteLine("System: Parsing servers...");
		XmlDocument xmlDocument = new XmlDocument();
		using (WebClient webClient = new WebClient())
		{
			string xml = webClient.DownloadString(string.Format("http://realmofthemadgodhrd.appspot.com/char/list?guid={0}", Environment.TickCount));
			xmlDocument.LoadXml(xml);
		}
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("Chars/Servers/Server");
		if (xmlNodeList == null)
		{
			throw new Exception("Failed to grab server list! Possibly rate limited by DECA, wait 10 minutes and try again.");
		}
		foreach (object obj in xmlNodeList)
		{
			XmlNode xmlNode = (XmlNode)obj;
			XmlNode xmlNode2 = xmlNode.SelectSingleNode("Name");
			XmlNode xmlNode3 = xmlNode.SelectSingleNode("DNS");
			if (xmlNode2 != null && xmlNode3 != null)
			{
				if (!xmlNode2.InnerText.StartsWith("CU"))
				{
					ServerParser._IOpSuG4guyYLeez9LywVYmMYQtG.Add(xmlNode2.InnerText, xmlNode3.InnerText);
				}
				StringBuilder stringBuilder = new StringBuilder();
				foreach (char c in xmlNode2.InnerText)
				{
					if (char.IsUpper(c) || char.IsDigit(c))
					{
						stringBuilder.Append(c);
					}
				}
				ServerParser.ServerAbbreviations.Add(stringBuilder.ToString().ToLower(), xmlNode2.InnerText);
				ServerParser.ServerAbbreviations.Add(xmlNode2.InnerText.ToLower(), xmlNode2.InnerText);
			}
			else
			{
				Console.WriteLine("System: Failed parsing server " + xmlNode.OuterXml);
			}
		}
		if (ServerParser._IOpSuG4guyYLeez9LywVYmMYQtG.Count == 0)
		{
			throw new Exception("Was not able to parse any RotMG servers!");
		}
	}

	// Token: 0x0400026F RID: 623
	[CompilerGenerated]
	private static Dictionary<string, string> _wlwmSk98qchDUP3G6Bi1yt7hmBP;

	// Token: 0x04000270 RID: 624
	[CompilerGenerated]
	private static Dictionary<string, string> _TUzwC8akty221MCyZmikoCOZJ7G;
}
