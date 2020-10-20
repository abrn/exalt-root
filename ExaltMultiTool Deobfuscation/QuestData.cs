using System;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x02000034 RID: 52
internal class QuestData : IDataObject, ICloneable
{
	// Token: 0x06000293 RID: 659 RVA: 0x00012144 File Offset: 0x00010344
	public QuestData()
	{
	}

	// Token: 0x06000294 RID: 660 RVA: 0x00012158 File Offset: 0x00010358
	public QuestData(PacketReader r)
	{
		this.Id = r.ReadString();
		this.Name = r.ReadString();
		this.Description = r.ReadString();
		this.Expiration = r.ReadString();
		this.Weight = r.ReadInt32();
		this.Category = r.ReadInt32();
		this.Requirements = new int[(int)r.ReadInt16()];
		for (int i = 0; i < this.Requirements.Length; i++)
		{
			this.Requirements[i] = r.ReadInt32();
		}
		this.Rewards = new int[(int)r.ReadInt16()];
		for (int j = 0; j < this.Rewards.Length; j++)
		{
			this.Rewards[j] = r.ReadInt32();
		}
		this.Completed = r.ReadBoolean();
		this.ItemOfChoice = r.ReadBoolean();
		this.Repeatable = r.ReadBoolean();
	}

	// Token: 0x06000295 RID: 661 RVA: 0x0001223C File Offset: 0x0001043C
	public IDataObject Read(PacketReader r)
	{
		this.Id = r.ReadString();
		this.Name = r.ReadString();
		this.Description = r.ReadString();
		this.Expiration = r.ReadString();
		this.Weight = r.ReadInt32();
		this.Category = r.ReadInt32();
		this.Requirements = new int[(int)r.ReadInt16()];
		for (int i = 0; i < this.Requirements.Length; i++)
		{
			this.Requirements[i] = r.ReadInt32();
		}
		this.Rewards = new int[(int)r.ReadInt16()];
		for (int j = 0; j < this.Rewards.Length; j++)
		{
			this.Rewards[j] = r.ReadInt32();
		}
		this.Completed = r.ReadBoolean();
		this.ItemOfChoice = r.ReadBoolean();
		this.Repeatable = r.ReadBoolean();
		return this;
	}

	// Token: 0x06000296 RID: 662 RVA: 0x0001231C File Offset: 0x0001051C
	public void Write(PacketWriter w)
	{
		w.Write(this.Id);
		w.Write(this.Name);
		w.Write(this.Description);
		w.Write(this.Expiration);
		w.Write(this.Weight);
		w.Write(this.Category);
		w.Write((short)this.Requirements.Length);
		foreach (int value in this.Requirements)
		{
			w.Write(value);
		}
		w.Write((short)this.Rewards.Length);
		foreach (int value2 in this.Rewards)
		{
			w.Write(value2);
		}
		w.Write(this.Completed);
		w.Write(this.ItemOfChoice);
		w.Write(this.Repeatable);
	}

	// Token: 0x06000297 RID: 663 RVA: 0x000123F4 File Offset: 0x000105F4
	public object Clone()
	{
		return new QuestData
		{
			Id = this.Id,
			Name = this.Name,
			Description = this.Description,
			Requirements = this.Requirements,
			Rewards = this.Rewards,
			Completed = this.Completed,
			ItemOfChoice = this.ItemOfChoice,
			Category = this.Category,
			Repeatable = this.Repeatable
		};
	}

	// Token: 0x06000298 RID: 664 RVA: 0x00012474 File Offset: 0x00010674
	public override string ToString()
	{
		string format = "{{ Id={0}, Name={1}, Description={2}, Requirements={3}, Rewards={4}, Completed={5}, ItemOfChoice={6}, Category={7}, Repeatable={8} }}";
		object[] array = new object[9];
		array[0] = this.Id;
		array[1] = this.Name;
		array[2] = this.Description;
		array[3] = from x in this.Requirements
				   select x.ToString() + " ";
		array[4] = from x in this.Rewards
				   select x.ToString() + " ";
		array[5] = this.Completed;
		array[6] = this.ItemOfChoice;
		array[7] = this.Category;
		array[8] = this.Repeatable;
		return string.Format(format, array);
	}

	// Token: 0x04000358 RID: 856
	public string Id;

	// Token: 0x04000359 RID: 857
	public string Name;

	// Token: 0x0400035A RID: 858
	public string Description;

	// Token: 0x0400035B RID: 859
	public string Expiration;

	// Token: 0x0400035C RID: 860
	public int[] Requirements;

	// Token: 0x0400035D RID: 861
	public int[] Rewards;

	// Token: 0x0400035E RID: 862
	public bool Completed;

	// Token: 0x0400035F RID: 863
	public bool ItemOfChoice;

	// Token: 0x04000360 RID: 864
	public bool Repeatable;

	// Token: 0x04000361 RID: 865
	public int Category;

	// Token: 0x04000362 RID: 866
	public int Weight;

}
