using System;
using System.IO;
using System.Reflection;
using System.Text;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000028 RID: 40
internal class Packet
{
	// Token: 0x170000D3 RID: 211
	// (get) Token: 0x06000243 RID: 579 RVA: 0x000108C8 File Offset: 0x0000EAC8
	public virtual PacketType Type
	{
		get
		{
			return PacketType.UNKNOWN;
		}
	}
	
	// Token: 0x06000244 RID: 580 RVA: 0x000108D8 File Offset: 0x0000EAD8
	public virtual void Read(PacketReader r)
	{
		this._data = r.ReadBytes((int)r.BaseStream.Length - 5);
		Console.WriteLine(string.Format("System: Read unknown packet ID {0} [{1}]\n{2}", this.Id, this._data.Length, string.Join<byte>(",", this._data)));
	}

	// Token: 0x06000245 RID: 581 RVA: 0x00010938 File Offset: 0x0000EB38
	public virtual void Write(PacketWriter w)
	{
		w.Write(this._data);
	}

	// Token: 0x06000246 RID: 582 RVA: 0x00010954 File Offset: 0x0000EB54
	public static Packet Create(PacketType type)
	{
		PacketStructure packetStructure = GameData.Packets.ByName(type.ToString());
		Packet packet = (Packet)Activator.CreateInstance(packetStructure.Type);
		packet.Id = packetStructure.ID;
		return packet;
	}

	// Token: 0x06000247 RID: 583 RVA: 0x00010998 File Offset: 0x0000EB98
	public static T Create<T>(PacketType type)
	{
		Packet packet = (Packet)Activator.CreateInstance(typeof(T));
		packet.Id = GameData.Packets.ByName(type.ToString()).ID;
		return (T)((object)Convert.ChangeType(packet, typeof(T)));
	}

	// Token: 0x06000248 RID: 584 RVA: 0x000109F0 File Offset: 0x0000EBF0
	public T To<T>()
	{
		return (T)((object)Convert.ChangeType(this, typeof(T)));
	}

	// Token: 0x06000249 RID: 585 RVA: 0x00010A14 File Offset: 0x0000EC14
	public static Packet Create(byte[] data)
	{
		Packet result;
		using (PacketReader packetReader = new PacketReader(new MemoryStream(data)))
		{
			int num = packetReader.ReadInt32();
			byte b = packetReader.ReadByte();
			PacketStructure packetStructure = GameData.Packets.ByID(b);
			Type type = (packetStructure == null) ? typeof(Packet) : packetStructure.Type;
			Packet packet = (Packet)Activator.CreateInstance(type);
			packet.Id = b;
			packet.Read(packetReader);
			if (packetReader.BaseStream.Position != (long)num)
			{
				Console.WriteLine(string.Format("System: Read packet {0} ({1}) with {2}/{3} bytes left!", new object[]
				{
						b,
						type,
						(long)num - packetReader.BaseStream.Position,
						num
				}));
			}
			result = packet;
		}
		return result;
	}

	// Token: 0x0600024A RID: 586 RVA: 0x00010B00 File Offset: 0x0000ED00
	public override string ToString()
	{
		FieldInfo[] fields = base.GetType().GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(this.Type.ToString() + "(" + this.Id.ToString() + ") Packet Instance");
		foreach (FieldInfo fieldInfo in fields)
		{
			StringBuilder stringBuilder2 = stringBuilder;
			string str = "\n\t";
			string name = fieldInfo.Name;
			string str2 = " => ";
			object value = fieldInfo.GetValue(this);
			stringBuilder2.Append(str + name + str2 + ((value != null) ? value.ToString() : null));
		}
		return stringBuilder.ToString();
	}

	// Token: 0x0600024B RID: 587 RVA: 0x00010BA0 File Offset: 0x0000EDA0
	public string ToStructure()
	{
		FieldInfo[] fields = base.GetType().GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(this.Type.ToString() + " [" + GameData.Packets.ByName(this.Type.ToString()).ID.ToString() + "] \nPacket Structure:\n{");
		foreach (FieldInfo fieldInfo in fields)
		{
			stringBuilder.Append("\n  " + fieldInfo.Name + " => " + fieldInfo.FieldType.Name);
		}
		stringBuilder.Append("\n}");
		return stringBuilder.ToString();
	}

	// Token: 0x040002AD RID: 685
	public bool Send = true;

	// Token: 0x040002AE RID: 686
	public byte Id;

	// Token: 0x040002B0 RID: 688
	private byte[] _data;
}
