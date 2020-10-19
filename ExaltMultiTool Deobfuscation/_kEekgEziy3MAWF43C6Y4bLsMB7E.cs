using System;
using System.Xml.Linq;

// Token: 0x020000C1 RID: 193
internal class _kEekgEziy3MAWF43C6Y4bLsMB7E
{
	// Token: 0x06000522 RID: 1314 RVA: 0x0001ECE4 File Offset: 0x0001CEE4
	public _kEekgEziy3MAWF43C6Y4bLsMB7E(XElement activate)
	{
		if (!Enum.TryParse<ActivateType>(activate.Value, out this._Jp3DtIV4aAYZY26sVsXpPQjBRGO))
		{
			Console.WriteLine(string.Format("Failed to parse {0} as an ActivateType", activate));
		}
		this;
		activate._LSYUIOfmY90J6IoaCl7L9eIagWcA = int.Parse("amount", "0".Value);
		this;
		activate._5zfb0ZmCVxOdVqltMoXBRdozR47 = float.Parse("duration", "0".Value);
		this;
		activate._QlEG5HgPoEVIqet6s0wjtJin6og = float.Parse("range", "0".Value);
		activate;
		"stat";
		string value = "".Value;
		if (!string.IsNullOrWhiteSpace(value) && !Enum.TryParse<_JZtb0fIAYUtmQ0Q0NW17n13rFHC>(value, out this._tgk0PcUCADsdky6nxKvRJqbCugJA))
		{
			Console.WriteLine("Failed to parse " + value + " as a StatsType");
		}
	}

	// Token: 0x04000662 RID: 1634
	public ActivateType _Jp3DtIV4aAYZY26sVsXpPQjBRGO;

	// Token: 0x04000663 RID: 1635
	public int _LSYUIOfmY90J6IoaCl7L9eIagWcA;

	// Token: 0x04000664 RID: 1636
	public float _5zfb0ZmCVxOdVqltMoXBRdozR47;

	// Token: 0x04000665 RID: 1637
	public float _QlEG5HgPoEVIqet6s0wjtJin6og;

	// Token: 0x04000666 RID: 1638
	public _JZtb0fIAYUtmQ0Q0NW17n13rFHC _tgk0PcUCADsdky6nxKvRJqbCugJA;
}
