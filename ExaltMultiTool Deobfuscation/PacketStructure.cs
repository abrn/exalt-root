using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x020000CA RID: 202
internal class PacketStructure : IDataStructure<byte>
{
	// Token: 0x0600053D RID: 1341 RVA: 0x0001F68C File Offset: 0x0001D88C
	internal static Dictionary<byte, PacketStructure> Load(XDocument doc)
	{
		Dictionary<byte, PacketStructure> map = new Dictionary<byte, PacketStructure>();
		doc.Element("Packets").Elements("Packet").ForEach(delegate (XElement packet)
		{
			PacketStructure packetStructure = new PacketStructure(packet);
			map[packetStructure.ID] = packetStructure;
		});
		return map;
    }

	// Token: 0x17000141 RID: 321
	// (get) Token: 0x0600053E RID: 1342 RVA: 0x0001F6E4 File Offset: 0x0001D8E4
	// (set) Token: 0x0600053F RID: 1343 RVA: 0x0001F6F8 File Offset: 0x0001D8F8
	public byte ID { get; private set; }

	// Token: 0x17000142 RID: 322
	// (get) Token: 0x06000540 RID: 1344 RVA: 0x0001F70C File Offset: 0x0001D90C
	public string Name
	{
		get
		{
			return this.PacketType.ToString();
		}
	}

	// Token: 0x06000541 RID: 1345 RVA: 0x0001F72C File Offset: 0x0001D92C
	public PacketStructure(XElement packet)
	{
		this.ID = (byte)packet.ElemDefault("PacketId", "").ParseInt();
		if (!Enum.TryParse<PacketType>(packet.ElemDefault("PacketName", ""), out this.PacketType))
		{
			this.PacketType = PacketType.UNKNOWN;
		}
		this.Type = null;
		foreach (Type type in PacketStructure.packetTypes)
		{
			if ((Activator.CreateInstance(type) as Packet).Type == this.PacketType)
			{
				this.Type = type;
			}
		}
	}

	// Token: 0x06000542 RID: 1346 RVA: 0x0001F7C8 File Offset: 0x0001D9C8
	public override string ToString()
	{
		return string.Format("Packet: {0} (0x{1:X})", this.PacketType, this.ID);
	}

	// Token: 0x040006AC RID: 1708
	private static Type tPacket = typeof(Packet);

	// Token: 0x040006AD RID: 1709
	private static Type[] packetTypes = (from t in Assembly.GetAssembly(typeof(Proxy)).GetTypes()
										 where PacketStructure.tPacket.IsAssignableFrom(t)
										 select t).ToArray<Type>();

	// Token: 0x040006AE RID: 1710
	[CompilerGenerated]
	private byte _wLyKBFmJlsIH8DtqnZeUZOuEITZ;

	// Token: 0x040006AF RID: 1711
	public PacketType PacketType;
	public Type Type;

	// Token: 0x040006B0 RID: 1712
	public Type _k9uWQCZd8WqDr6yiKRmrLtst3KX;

}
