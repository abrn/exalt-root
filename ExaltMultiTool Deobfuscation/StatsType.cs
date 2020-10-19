using System;

// Token: 0x02000039 RID: 57
internal class StatsType
{
	// Token: 0x060002AB RID: 683 RVA: 0x0001288C File Offset: 0x00010A8C
	private StatsType(byte type)
	{
		this.m_type = type;
	}

	// Token: 0x060002AC RID: 684 RVA: 0x000128A8 File Offset: 0x00010AA8
	public bool IsUTF()
	{
		return global::StatsType.Id(this, global::StatsType.AccountId) || global::StatsType.Id(this, global::StatsType._hX8BFqWLS62laclaj1NZp3sAf1lA) || global::StatsType.Id(this, global::StatsType._wUJcF2CyjsVZYwXoaniPlT3Zpag) || global::StatsType.Id(this, global::StatsType._nnw4mIJ2qnTBfbumuZegfJw1qcX) || global::StatsType.Id(this, global::StatsType._FsTBRomtbU9GTZxcDg64mHnlA6z) || global::StatsType.Id(this, global::StatsType._C70xyl0DG8J6CHk50QAawecBNb1);
	}

	// Token: 0x060002AD RID: 685 RVA: 0x00012904 File Offset: 0x00010B04
	public static implicit operator StatsType(int type)
	{
		if (type > 255)
		{
			throw new Exception("Not a valid StatData number.");
		}
		return new StatsType((byte)type);
	}


	// Token: 0x060002AF RID: 687 RVA: 0x00012958 File Offset: 0x00010B58
	public static implicit operator StatsType(byte type)
	{
		return new StatsType(type);
	}

	// Token: 0x060002B0 RID: 688 RVA: 0x00012970 File Offset: 0x00010B70
	public static bool _cdabW7ae4EGEYdLXJ4tAOcCD3GUA(StatsType type, int id)
	{
		if (id > 255)
		{
			throw new Exception("Not a valid StatData number.");
		}
		return type.m_type != (byte)id;
	}

	// Token: 0x060002B1 RID: 689 RVA: 0x000129A0 File Offset: 0x00010BA0
	public static bool _cdabW7ae4EGEYdLXJ4tAOcCD3GUA(StatsType type, byte id)
	{
		return type.m_type != id;
	}

	// Token: 0x060002B2 RID: 690 RVA: 0x000129BC File Offset: 0x00010BBC
	public static bool Id(StatsType type, StatsType id)
	{
		return type.m_type == id.m_type;
	}

	// Token: 0x060002B3 RID: 691 RVA: 0x000129D8 File Offset: 0x00010BD8
	public static bool Id(StatsType type, StatsType id)
	{
		return type.m_type != id.m_type;
	}

	// Token: 0x060002B4 RID: 692 RVA: 0x000129F8 File Offset: 0x00010BF8
	public static int _aB83fkaWIFXdehxJ8Dj9IX8iZ3m(StatsType type)
	{
		return (int)type.m_type;
	}

	// Token: 0x060002B5 RID: 693 RVA: 0x00012A0C File Offset: 0x00010C0C
	public static byte _aB83fkaWIFXdehxJ8Dj9IX8iZ3m(StatsType type)
	{
		return type.m_type;
	}

	// Token: 0x060002B6 RID: 694 RVA: 0x00012A20 File Offset: 0x00010C20
	public virtual int _wX8RvXN3IXqJQrAknBh7HAKvqJH()
	{
		return base.GetHashCode();
	}

	// Token: 0x060002B7 RID: 695 RVA: 0x00012A34 File Offset: 0x00010C34
	public virtual bool _IOycFREBBdMkXBWZnLb9HNamStob(object obj)
	{
		return obj is StatsType && global::StatsType.Id(this, (StatsType)obj);
	}

	// Token: 0x060002B8 RID: 696 RVA: 0x00012A58 File Offset: 0x00010C58
	public virtual string _Ye7Bzeo9ipi3HJQJeW2fYB88LbJ()
	{
		return this.m_type.ToString();
	}

	// Token: 0x040003DE RID: 990
	public static readonly StatsType _DVNBi2eQHLdmlmNyYH05WDcfCzq = new StatsType(0);

	// Token: 0x040003DF RID: 991
	public static readonly StatsType HP = new StatsType(1);

	// Token: 0x040003E0 RID: 992
	public static readonly StatsType _l5HAIp8OEZRguJkIVcZQDtTd8ME = new StatsType(2);

	// Token: 0x040003E1 RID: 993
	public static readonly StatsType _QkkjT08Jq1EAHiSlsxNcrD5paX9 = new StatsType(3);

	// Token: 0x040003E2 RID: 994
	public static readonly StatsType MP = new StatsType(4);

	// Token: 0x040003E3 RID: 995
	public static readonly StatsType _TuTejl6BJwjzMlO6dSSYgBTEB8l = new StatsType(5);

	// Token: 0x040003E4 RID: 996
	public static readonly StatsType _JbADdSEurT8Fk6JbwEscBOG6VPt = new StatsType(6);

	// Token: 0x040003E5 RID: 997
	public static readonly StatsType _kVPIn7lal6qAksGnCpfbCxqF9pv = new StatsType(7);

	// Token: 0x040003E6 RID: 998
	public static readonly StatsType _kO6uiVaRgPa6zvwV2YgkaFawFeA = new StatsType(8);

	// Token: 0x040003E7 RID: 999
	public static readonly StatsType _idaesRih3T62YKfF1b0nKNMOdlo = new StatsType(9);

	// Token: 0x040003E8 RID: 1000
	public static readonly StatsType _Elnq8QyL4vGRCwYAWNqB3poZk3g = new StatsType(10);

	// Token: 0x040003E9 RID: 1001
	public static readonly StatsType _GIjfmXQzE3E0aenxsDaAxVhd1TS = new StatsType(11);

	// Token: 0x040003EA RID: 1002
	public static readonly StatsType _nf7bk3w6XqIyW0GRVPptSPegV0c = new StatsType(12);

	// Token: 0x040003EB RID: 1003
	public static readonly StatsType _wBDcV7WqlqU0RiUzd0JaYulVLop = new StatsType(13);

	// Token: 0x040003EC RID: 1004
	public static readonly StatsType _nyqBkmlRFF5A6f9gM44lyrdSwFI = new StatsType(14);

	// Token: 0x040003ED RID: 1005
	public static readonly StatsType _KbfKlNWj4mBtJIGPRsKYtTEOu9B = new StatsType(15);

	// Token: 0x040003EE RID: 1006
	public static readonly StatsType _SuGywcWU0SU5yC6EudAzgam1i0 = new StatsType(16);

	// Token: 0x040003EF RID: 1007
	public static readonly StatsType _WnxPmr6ftaysCv1lzG9xOGSBT1g = new StatsType(17);

	// Token: 0x040003F0 RID: 1008
	public static readonly StatsType _x6kfS9rjAQzo94A4reHQXK3nkaH = new StatsType(18);

	// Token: 0x040003F1 RID: 1009
	public static readonly StatsType _Ra9EqaM4zauDBI123vX3hnJcNZi = new StatsType(19);

	// Token: 0x040003F2 RID: 1010
	public static readonly StatsType _dI2A4xkFMBKB33bDL8Z5iBFtdKyA = new StatsType(20);

	// Token: 0x040003F3 RID: 1011
	public static readonly StatsType _I8uQpaQw1Wx940p3k48AjKZWpuM = new StatsType(21);

	// Token: 0x040003F4 RID: 1012
	public static readonly StatsType _QdxR2qr1IpaCFjLkbiV08vZVgcY = new StatsType(22);

	// Token: 0x040003F5 RID: 1013
	public static readonly StatsType _UJS9Gfx8k7FD8Uw5U6mVqjWLghC = new StatsType(26);

	// Token: 0x040003F6 RID: 1014
	public static readonly StatsType _WHCAkdeYqXMbNsGZ6LrBhVGy9y4 = new StatsType(27);

	// Token: 0x040003F7 RID: 1015
	public static readonly StatsType _pdtKFzngyBbdiv5VHFvMh7Hovb3 = new StatsType(28);

	// Token: 0x040003F8 RID: 1016
	public static readonly StatsType Effects = new StatsType(29);

	// Token: 0x040003F9 RID: 1017
	public static readonly StatsType _ArqZre4dIDTIIPy3xTszHel9Wqf = new StatsType(30);

	// Token: 0x040003FA RID: 1018
	public static readonly StatsType _Jp3DtIV4aAYZY26sVsXpPQjBRGO = new StatsType(31);

	// Token: 0x040003FB RID: 1019
	public static readonly StatsType _dGmzCdh4Iy5lfXnwU3VPMwSAUfc = new StatsType(32);

	// Token: 0x040003FC RID: 1020
	public static readonly StatsType _C4Vx4xiacBOR2Xl4J6go7jjlymk = new StatsType(33);

	// Token: 0x040003FD RID: 1021
	public static readonly StatsType _QlPvlus5BEskpbHZUyuhoX6RE4d = new StatsType(34);

	// Token: 0x040003FE RID: 1022
	public static readonly StatsType _TKbQLd6bI116m2Ua1V2GkjCjohg = new StatsType(35);

	// Token: 0x040003FF RID: 1023
	public static readonly StatsType _AIx8b5TcnS5VDiVLZjYLnwCifsd = new StatsType(36);

	// Token: 0x04000400 RID: 1024
	public static readonly StatsType _FL9LY7Mk276JhDgdIHNBrhF9kfX = new StatsType(37);

	// Token: 0x04000401 RID: 1025
	public static readonly StatsType _hX8BFqWLS62laclaj1NZp3sAf1lA = new StatsType(38);

	// Token: 0x04000402 RID: 1026
	public static readonly StatsType _56pdYv1LPTIA6NGeLxVI6h8jOT8 = new StatsType(39);

	// Token: 0x04000403 RID: 1027
	public static readonly StatsType _HBgSYnzV7X5AS2lwvHrCnUzYQVL = new StatsType(40);

	// Token: 0x04000404 RID: 1028
	public static readonly StatsType _S8A0z054r8lPjIFnB01cve0MFFD = new StatsType(41);

	// Token: 0x04000405 RID: 1029
	public static readonly StatsType _WIBaimemAZ90kJGyPlUmSPID1Rp = new StatsType(42);

	// Token: 0x04000406 RID: 1030
	public static readonly StatsType _Np0blcdLxgR3os01CWlAJdXPxbK = new StatsType(43);

	// Token: 0x04000407 RID: 1031
	public static readonly StatsType _1N9zOpwUjIFa2JWnmoTlZOoFWWW = new StatsType(44);

	// Token: 0x04000408 RID: 1032
	public static readonly StatsType _aHf5gCT3qdp0vdon5OU7NbeGfCb = new StatsType(45);

	// Token: 0x04000409 RID: 1033
	public static readonly StatsType _a19Kww8XtLvH56Cl4ErqzYwACOr = new StatsType(46);

	// Token: 0x0400040A RID: 1034
	public static readonly StatsType _7PsO1ZY2PoG3jMvyBfd2G7j6ygc = new StatsType(47);

	// Token: 0x0400040B RID: 1035
	public static readonly StatsType _4rfvEfTefqPghGJsKrqd7EtsEre = new StatsType(48);

	// Token: 0x0400040C RID: 1036
	public static readonly StatsType _bJyEvHBLdYV7m9rFbt33Pzb2sxA = new StatsType(49);

	// Token: 0x0400040D RID: 1037
	public static readonly StatsType _v8e0yLlSvUcBhpWcWa9eZykXXQD = new StatsType(50);

	// Token: 0x0400040E RID: 1038
	public static readonly StatsType _D3LajoXm4jGGTmV2Y1LI3FGsJjn = new StatsType(51);

	// Token: 0x0400040F RID: 1039
	public static readonly StatsType _4akWucPyC5kfaQPCwo1ZymNANi2 = new StatsType(52);

	// Token: 0x04000410 RID: 1040
	public static readonly StatsType _YEq14ZJh64oSIGyaFj5kn82EMRDA = new StatsType(53);

	// Token: 0x04000411 RID: 1041
	public static readonly StatsType _wUJcF2CyjsVZYwXoaniPlT3Zpag = new StatsType(54);

	// Token: 0x04000412 RID: 1042
	public static readonly StatsType _GwQlWzhgVAQa52xKJBrIYHUwuSg = new StatsType(55);

	// Token: 0x04000413 RID: 1043
	public static readonly StatsType _elsgOPOhrazwFqRBlSiBgics9eZ = new StatsType(56);

	// Token: 0x04000414 RID: 1044
	public static readonly StatsType _wtUCeGWgiFihItvjiXcbqM4OcaG = new StatsType(57);

	// Token: 0x04000415 RID: 1045
	public static readonly StatsType _o7pfCVIFMYowiMMXy0NnZe6rdAK = new StatsType(58);

	// Token: 0x04000416 RID: 1046
	public static readonly StatsType _jQToCmezajoMkD7AWz3F9w0fiQJ = new StatsType(59);

	// Token: 0x04000417 RID: 1047
	public static readonly StatsType _wgCanjC9leZxxY8STcR1KGRQhRd = new StatsType(60);

	// Token: 0x04000418 RID: 1048
	public static readonly StatsType _IETqTFGc9287W3IAM0SiEryfzal = new StatsType(61);

	// Token: 0x04000419 RID: 1049
	public static readonly StatsType _nnw4mIJ2qnTBfbumuZegfJw1qcX = new StatsType(62);

	// Token: 0x0400041A RID: 1050
	public static readonly StatsType _LgHauWr40j3A6clN8gZvftMEHKs = new StatsType(63);

	// Token: 0x0400041B RID: 1051
	public static readonly StatsType _bwlhTiDZyjHndQbZAcaCfdCkLYc = new StatsType(64);

	// Token: 0x0400041C RID: 1052
	public static readonly StatsType _3u8EN6CszdX8qryhTPImIceBevb = new StatsType(65);

	// Token: 0x0400041D RID: 1053
	public static readonly StatsType _gwPaK86RAin19VkNd3FGQhjFbZF = new StatsType(66);

	// Token: 0x0400041E RID: 1054
	public static readonly StatsType _zZwsFzlGkDlCXrGmdYltfwHh4Vm = new StatsType(67);

	// Token: 0x0400041F RID: 1055
	public static readonly StatsType _yhMdrRpBrXbbQiNdStlpb7dXOp1A = new StatsType(68);

	// Token: 0x04000420 RID: 1056
	public static readonly StatsType _QKbxIHZBPI9Dq3OhZ51dNkkdQY7A = new StatsType(69);

	// Token: 0x04000421 RID: 1057
	public static readonly StatsType _V45DgbkdekLVCMtEzfZpb7LDuz3 = new StatsType(70);

	// Token: 0x04000422 RID: 1058
	public static readonly StatsType _5gFvVxLffbEYV6UfbYXgWt9k7uM = new StatsType(71);

	// Token: 0x04000423 RID: 1059
	public static readonly StatsType _vopOQhtijAp9Bk35wA0Sh1LiePA = new StatsType(72);

	// Token: 0x04000424 RID: 1060
	public static readonly StatsType _byTrm6qjjyHReLKfncrk5X6B2NC = new StatsType(73);

	// Token: 0x04000425 RID: 1061
	public static readonly StatsType _uLrbmPp2nSEJJD8G3aRNk2ZiYSC = new StatsType(74);

	// Token: 0x04000426 RID: 1062
	public static readonly StatsType _a2MDiylwgtMXzdWOqOvOl0hqJ9J = new StatsType(75);

	// Token: 0x04000427 RID: 1063
	public static readonly StatsType _L77q6EJufoAZNPrD4G9br8W6sBk = new StatsType(76);

	// Token: 0x04000428 RID: 1064
	public static readonly StatsType _3KKCmYZQVnHZQ4nggRv26Ot6Ct = new StatsType(77);

	// Token: 0x04000429 RID: 1065
	public static readonly StatsType _bfw0GuMqiQGEPHyCpXmy8P83nnB = new StatsType(78);

	// Token: 0x0400042A RID: 1066
	public static readonly StatsType _i1wpxbN1B15L7vPjaWvObujwWOB = new StatsType(79);

	// Token: 0x0400042B RID: 1067
	public static readonly StatsType _qRYx5j3OvH1oNGlfjLNr6zIbDjF = new StatsType(80);

	// Token: 0x0400042C RID: 1068
	public static readonly StatsType _3D5Tz3GgqzlJJub8hT9vh6ZEacI = new StatsType(81);

	// Token: 0x0400042D RID: 1069
	public static readonly StatsType _FsTBRomtbU9GTZxcDg64mHnlA6z = new StatsType(82);

	// Token: 0x0400042E RID: 1070
	public static readonly StatsType _pIDFg5WgQvsXX1BpXaNGcjoU9Gg = new StatsType(83);

	// Token: 0x0400042F RID: 1071
	public static readonly StatsType _qfr5A1mVxmt5uDhdLYhJrVtS1Qd = new StatsType(84);

	// Token: 0x04000430 RID: 1072
	public static readonly StatsType _kuuodESQpJiaO4qk81af2S2Jj5E = new StatsType(85);

	// Token: 0x04000431 RID: 1073
	public static readonly StatsType _gkVBK785v1ujMJ8mAZ3kXzyrywk = new StatsType(86);

	// Token: 0x04000432 RID: 1074
	public static readonly StatsType _rHM4iRSTN7H65Lz5eT4SXNOIldi = new StatsType(87);

	// Token: 0x04000433 RID: 1075
	public static readonly StatsType _h7SQBKhlzLQpu6GhaWW7KmtdVBM = new StatsType(88);

	// Token: 0x04000434 RID: 1076
	public static readonly StatsType _v1VdlBs9asJcOAJqCHkCPfoJ4xt = new StatsType(89);

	// Token: 0x04000435 RID: 1077
	public static readonly StatsType _n3DumTkh6D6AmOoNOjhuS3aE3Df = new StatsType(90);

	// Token: 0x04000436 RID: 1078
	public static readonly StatsType _JbwgIwhSJEUkPZYplrD5RAtFilg = new StatsType(91);

	// Token: 0x04000437 RID: 1079
	public static readonly StatsType _uUILCMELCCdYja6fYx5dxKpKYcY = new StatsType(92);

	// Token: 0x04000438 RID: 1080
	public static readonly StatsType _m6zTriRASRqnzA8Ca2RmZOvyRubA = new StatsType(93);

	// Token: 0x04000439 RID: 1081
	public static readonly StatsType _z9AMbqEbazKA842DVtW38osXzUJ = new StatsType(94);

	// Token: 0x0400043A RID: 1082
	public static readonly StatsType _X8q6VXJQNDcYN8rbRgidYNYsq4b = new StatsType(95);

	// Token: 0x0400043B RID: 1083
	public static readonly StatsType _Vn1UXDYsa7sb8qGDESMjPifFRtx = new StatsType(96);

	// Token: 0x0400043C RID: 1084
	public static readonly StatsType _aG3ktVgN2Htvnpx3DoElnCGqDoJ = new StatsType(97);

	// Token: 0x0400043D RID: 1085
	public static readonly StatsType _WFGtnNajtt53aaUD5E9XE7isWrB = new StatsType(98);

	// Token: 0x0400043E RID: 1086
	public static readonly StatsType _qUbMqmpLqYSAwX0x5x1BlHuPS7u = new StatsType(99);

	// Token: 0x0400043F RID: 1087
	public static readonly StatsType _QBI2jhQvnUaBnSsGyyCIXilmTic = new StatsType(100);

	// Token: 0x04000440 RID: 1088
	public static readonly StatsType _cqtjiwjr5NUcNdltZBCKkSIoICc = new StatsType(101);

	// Token: 0x04000441 RID: 1089
	public static readonly StatsType _FzDgEIYYEHgbPsJEf1aBjFAs0zGA = new StatsType(102);

	// Token: 0x04000442 RID: 1090
	public static readonly StatsType _KgIxZv1DfWSX4neePUrew9DNJdg = new StatsType(103);

	// Token: 0x04000443 RID: 1091
	public static readonly StatsType _TSykLaOLGi7FNlma6uT6j5IDoWy = new StatsType(104);

	// Token: 0x04000444 RID: 1092
	public static readonly StatsType _4KSD8QCkzRw2gr2nRbmgpXNuMsC = new StatsType(105);

	// Token: 0x04000445 RID: 1093
	public static readonly StatsType _3G8wntdGYIGUW8pIokUjSxDOR2B = new StatsType(106);

	// Token: 0x04000446 RID: 1094
	public static readonly StatsType _43x3m61Shhegq5YzCk3F10X7ftI = new StatsType(107);

	// Token: 0x04000447 RID: 1095
	public static readonly StatsType _ZZxLWuBKcbiJh5XNFLhxkvNJw57 = new StatsType(108);

	// Token: 0x04000448 RID: 1096
	public static readonly StatsType _qtyaL2ya0NnEMajBZjmpDUQV6vv = new StatsType(109);

	// Token: 0x04000449 RID: 1097
	public static readonly StatsType _4VTGDUFZE79W3bUoaSP9kGdAG2j = new StatsType(110);

	// Token: 0x0400044A RID: 1098
	public static readonly StatsType _qOGTEltCbsuIoaAKt7cCbCBLWz1 = new StatsType(111);

	// Token: 0x0400044B RID: 1099
	public static readonly StatsType _HaurANT0NcbagteYz41kmOkEQFw = new StatsType(112);

	// Token: 0x0400044C RID: 1100
	public static readonly StatsType _EGcHS4vjvNVpGLRIvemh5EpmJyB = new StatsType(113);

	// Token: 0x0400044D RID: 1101
	public static readonly StatsType _jCgWNsgoNuPrPcGb5TKmrUWXEEn = new StatsType(114);

	// Token: 0x0400044E RID: 1102
	public static readonly StatsType _C70xyl0DG8J6CHk50QAawecBNb1 = new StatsType(115);

	// Token: 0x0400044F RID: 1103
	private byte m_type;
}
