using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace ExaltMultiTool.Proxy.DataStructures
{
	public class ObjectStructure : IDataStructure<ushort>
	{
		internal static Dictionary<ushort, ObjectStructure> _gKKd0PApBLw4Hl4Oj4Z6UarwYVc(XDocument doc)
		{
			Dictionary<ushort, ObjectStructure> map = new Dictionary<ushort, ObjectStructure>();
			doc.Element("Objects").Elements("Object").ForEach(delegate (XElement obj)
			{
				ObjectStructure objectStructure = new ObjectStructure(obj);
				map[objectStructure.ID] = objectStructure;
			});
			return map;
		}

		public ushort ID { get; private set; }

		public string Name { get; private set; }

		public ObjectStructure(XElement obj)
		{
			this.ID = (ushort)obj.AttrDefault("type", "0x0").ParseHex();
			this.ObjectClass = obj.ElemDefault("Class", "GameObject");
			this.MaxHP = (ushort)obj.ElemDefault("MaxHitPoints", "0").ParseHex();
			this.XPMult = obj.ElemDefault("XpMult", "0").ParseFloat();
			this.Static = obj.HasElement("Static");
			this.OccupySquare = obj.HasElement("OccupySquare");
			this.EnemyOccupySquare = obj.HasElement("EnemyOccupySquare");
			this.FullOccupy = obj.HasElement("FullOccupy");
			this.BlocksSight = obj.HasElement("BlocksSight");
			this.ProtectFromGroundDamage = obj.HasElement("ProtectFromGroundDamage");
			this.ProtectFromSink = obj.HasElement("ProtectFromSink");
			this.Enemy = obj.HasElement("Enemy");
			this.Player = obj.HasElement("Player");
			this.Pet = obj.HasElement("Pet");
			this.DrawOnGround = obj.HasElement("DrawOnGround");
			this.Size = (ushort)obj.ElemDefault("Size", "0").ParseInt();
			this.ShadowSize = (ushort)obj.ElemDefault("ShadowSize", "0").ParseInt();
			this.Defense = (ushort)obj.ElemDefault("Defense", "0").ParseInt();
			this.Flying = obj.HasElement("Flying");
			this.God = obj.HasElement("God");
			this.Cube = obj.HasElement("Cube");
			this.Quest = obj.HasElement("Quest");
			this.Item = obj.HasElement("Item");
			this.Usable = obj.HasElement("Usable");
			this.Soulbound = obj.HasElement("Soulbound");
			this.MpCost = (ushort)obj.ElemDefault("MpCost", "0").ParseInt();
			List<ProjectileStructure> projs = new List<ProjectileStructure>();
			obj.Elements("Projectile").ForEach(delegate (XElement projectile)
			{
				projs.Add(new ProjectileStructure(projectile));
			});
			this.Projectiles = projs.ToArray();
			this.Name = obj.AttrDefault("id", "");
		}

		public override string ToString()
		{
			return string.Format("Object: {0} (0x{1:X})", this.Name, this.ID);
		}


		public string ObjectClass;

		public ushort MaxHP;

		public float XPMult;

		public bool Static;

		public bool OccupySquare;

		public bool EnemyOccupySquare;

		public bool FullOccupy;

		public bool BlocksSight;

		public bool ProtectFromGroundDamage;

		public bool ProtectFromSink;

		public bool Enemy;

		public bool Player;

		public bool Pet;

		public bool DrawOnGround;

		public ushort Size;

		public ushort ShadowSize;

		public ushort Defense;

		public bool Flying;

		public bool God;

		public bool Cube;

		public bool Quest;

		public bool Item;

		public bool Usable;

		public bool Soulbound;

		public ushort MpCost;

		public ProjectileStructure[] Projectiles;

	}
}
