using System;
using System.IO;
using ExaltMultiTool.Proxy.Networking.Packets;

// Token: 0x02000096 RID: 150
internal class ShowEffectPacket : Packet
{
	// Token: 0x1700012F RID: 303
	// (get) Token: 0x0600042E RID: 1070 RVA: 0x000165A8 File Offset: 0x000147A8
	public override PacketType Type
	{
		get
		{
			return PacketType.SHOWEFFECT;
		}
	}

	// Token: 0x0600042F RID: 1071 RVA: 0x000165B8 File Offset: 0x000147B8
	public override void Read(PacketReader r)
	{
		this.EffectType = (EffectType)r.ReadByte();
		byte b = r.ReadByte();
		this.TargetId = (((b & 64) != 0) ? CompressedInt.Read(r) : 0);
		this.PosA.X = (double)(((b & 2) != 0) ? r.ReadSingle() : 0f);
		this.PosA.Y = (double)(((b & 4) != 0) ? r.ReadSingle() : 0f);
		this.PostB.X = (double)(((b & 8) != 0) ? r.ReadSingle() : 0f);
		this.PostB.Y = (double)(((b & 16) != 0) ? r.ReadSingle() : 0f);
		this.Color = (((b & 1) != 0) ? ARGB.Read(r) : ShowEffectPacket.EmptyArgb);
		this.Duration = (((b & 32) != 0) ? r.ReadSingle() : 1f);
		if ((b & 128) != 0)
		{
			this.UnknownValue = r.ReadByte();
		}
	}

	// Token: 0x06000430 RID: 1072 RVA: 0x000166AC File Offset: 0x000148AC
	public override void Write(PacketWriter w)
	{
		using (MemoryStream memoryStream = new MemoryStream())
		{
			using (PacketWriter packetWriter = new PacketWriter(memoryStream))
			{
				byte b = 0;
				if (this.TargetId != 0)
				{
					b |= 64;
					CompressedInt.Write(packetWriter, this.TargetId);
				}
				if (this.PosA.X != 0.0)
				{
					b |= 2;
					packetWriter.Write((float)this.PosA.X);
				}
				if (this.PosA.Y != 0.0)
				{
					b |= 4;
					packetWriter.Write((float)this.PosA.Y);
				}
				if (this.PosB.X != 0.0)
				{
					b |= 8;
					packetWriter.Write((float)this.PosB.X);
				}
				if (this.PosB.Y != 0.0)
				{
					b |= 16;
					packetWriter.Write((float)this.PosB.Y);
				}
				if (this.Color.A != ShowEffectPacket.EmptyArgb.A || this.Color.R != ShowEffectPacket.EmptyArgb.R || this.Color.G != ShowEffectPacket.EmptyArgb.G || this.Color.B != ShowEffectPacket.EmptyArgb.B)
				{
					b |= 1;
					this.Color.Write(packetWriter);
				}
				if (this.Duration != 1f)
				{
					b |= 32;
					packetWriter.Write(this.Duration);
				}
				if (this.UnknownValue != 0)
				{
					b |= 128;
					packetWriter.Write(this.UnknownValue);
				}
				w.Write((byte)this.EffectType);
				w.Write(b);
				memoryStream.WriteTo(w.BaseStream);
			}
		}
	}


	// Token: 0x04000555 RID: 1365
	private const int EffectBitColor = 1;

	// Token: 0x04000556 RID: 1366
	private const int EffectBitPos1X = 2;

	// Token: 0x04000557 RID: 1367
	private const int EffectBitPos1Y = 4;

	// Token: 0x04000558 RID: 1368
	private const int EffectBitPos2X = 8;

	// Token: 0x04000559 RID: 1369
	private const int EffectBitPos2Y = 16;

	// Token: 0x0400055A RID: 1370
	private const int EffectBitPos1 = 6;

	// Token: 0x0400055B RID: 1371
	private const int EffectBitPos2 = 24;

	// Token: 0x0400055C RID: 1372
	private const int EffectBitDuration = 32;

	// Token: 0x0400055D RID: 1373
	private const int EffectBitId = 64;

	// Token: 0x0400055E RID: 1374
	private const int UnknownBitId = 128;

	// Token: 0x0400055F RID: 1375
	private static readonly ARGB EmptyArgb = new ARGB(uint.MaxValue);

	// Token: 0x04000560 RID: 1376
	public EffectType EffectType;

	// Token: 0x04000561 RID: 1377
	public int TargetId;

	// Token: 0x04000562 RID: 1378
	public Location PosA;

	// Token: 0x04000563 RID: 1379
	public Location PostB;

	// Token: 0x04000564 RID: 1380
	public ARGB Color;

	// Token: 0x04000565 RID: 1381
	public float Duration;

	// Token: 0x04000566 RID: 1382
	public byte UnknownValue;
}
