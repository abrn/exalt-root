﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Xml.Linq;

// Token: 0x0200001F RID: 31
internal static class _tgqdT3pJTudczfEYT1tBjGKzLQP
{
	// Token: 0x060001F7 RID: 503 RVA: 0x0000ED14 File Offset: 0x0000CF14
	public static IEnumerable<T> _mDNyNFYbqpk6ULly4BYiq6ShWsn<T>(this IEnumerable<T> input, Action<T> action)
	{
		foreach (T obj in input)
		{
			action(obj);
		}
		return input;
	}

	// Token: 0x060001F8 RID: 504 RVA: 0x0000ED60 File Offset: 0x0000CF60
	public static bool _v94aD6xnI4gMG97iMJhl8NatmPCb(this XElement element, XName name)
	{
		return element.Elements(name).Any<XElement>();
	}

	// Token: 0x060001F9 RID: 505 RVA: 0x0000ED7C File Offset: 0x0000CF7C
	public static string _dVoQFhfIJiKdBRBcDjAJqgIL0zr(this XElement element, XName name, string @default)
	{
		if (!element.Attributes(name).Any<XAttribute>())
		{
			return @default;
		}
		return element.Attribute(name).Value;
	}

	// Token: 0x060001FA RID: 506 RVA: 0x0000EDA8 File Offset: 0x0000CFA8
	public static string _8rRj6CQ9yNEkKI0OZrX9anNCNMf(this XElement element, XName name, string @default)
	{
		if (!element.Elements(name).Any<XElement>())
		{
			return @default;
		}
		return element.Element(name).Value;
	}

	// Token: 0x060001FB RID: 507 RVA: 0x0000EDD4 File Offset: 0x0000CFD4
	public static int _PjGiPIR47idBfJxZRFhEG1Dqw2G(this string input)
	{
		return Convert.ToInt32(input, 16);
	}

	// Token: 0x060001FC RID: 508 RVA: 0x0000EDEC File Offset: 0x0000CFEC
	public static int _a1ahxRmg30qVKt3OG7FTQoZUDbA(this string input)
	{
		return int.Parse(input, CultureInfo.InvariantCulture);
	}

	// Token: 0x060001FD RID: 509 RVA: 0x0000EE04 File Offset: 0x0000D004
	public static float _06icv9EUXC4bpDlKqh4DypjGelR(this string input)
	{
		return float.Parse(input, CultureInfo.InvariantCulture);
	}
}
