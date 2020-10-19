using System;
using System.Collections.Concurrent;
using System.Net;
using System.Net.Sockets;

// Token: 0x02000022 RID: 34
internal class Proxy
{
	// Token: 0x14000001 RID: 1
	// (add) Token: 0x06000206 RID: 518 RVA: 0x0000EE1C File Offset: 0x0000D01C
	// (remove) Token: 0x06000207 RID: 519 RVA: 0x0000EE54 File Offset: 0x0000D054
	public event _Ps42O2MmsFVlJUilAWIvSAzROZ _Btb56r0Op4ZAUhxFOmSHdx4yyvB;

	// Token: 0x14000002 RID: 2
	// (add) Token: 0x06000208 RID: 520 RVA: 0x0000EE8C File Offset: 0x0000D08C
	// (remove) Token: 0x06000209 RID: 521 RVA: 0x0000EEC4 File Offset: 0x0000D0C4
	public event _Ps42O2MmsFVlJUilAWIvSAzROZ _hFu05GzdJqHXbAwtqBL9NTBAxUS;

	// Token: 0x14000003 RID: 3
	// (add) Token: 0x0600020A RID: 522 RVA: 0x0000EF00 File Offset: 0x0000D100
	// (remove) Token: 0x0600020B RID: 523 RVA: 0x0000EF38 File Offset: 0x0000D138
	public event _Ps42O2MmsFVlJUilAWIvSAzROZ _qGdzddO22NoijWY9im3O8jEA78d;

	// Token: 0x14000004 RID: 4
	// (add) Token: 0x0600020C RID: 524 RVA: 0x0000EF70 File Offset: 0x0000D170
	// (remove) Token: 0x0600020D RID: 525 RVA: 0x0000EFAC File Offset: 0x0000D1AC
	public event HotkeyHandler _wuIWyF7JKrmhDOnv8QncHvL3ChC;

	// Token: 0x0600020E RID: 526 RVA: 0x0000EFE4 File Offset: 0x0000D1E4
	public void _eF71c6Wm9DMjCayXZwHo3e5aDoP()
	{
		Console.WriteLine("Listener: Starting local listener....");
		this._15LfsipxJm1I78mh9UGesTHpsVC = new ConcurrentDictionary<string, ReconnectPacket>();
		this._nfgb8pFqFgUhAbKIn1asL966JOGA = new TcpListener(IPAddress.Parse("127.0.0.1"), 2050);
		this._nfgb8pFqFgUhAbKIn1asL966JOGA.Start();
		this._nfgb8pFqFgUhAbKIn1asL966JOGA.BeginAcceptTcpClient(new AsyncCallback(this._nfTgYJVtdPvFQP9il911kWtN5gC), null);
		Console.WriteLine("Listener: Started local listener.");
	}

	// Token: 0x0600020F RID: 527 RVA: 0x0000F050 File Offset: 0x0000D250
	private void _nfTgYJVtdPvFQP9il911kWtN5gC(IAsyncResult ar)
	{
		try
		{
			TcpClient client = this._nfgb8pFqFgUhAbKIn1asL966JOGA.EndAcceptTcpClient(ar);
			Client client2 = new Client(this, client);
			for (;;)
			{
				Console.WriteLine("Listener: Client recieved.");
				_Ps42O2MmsFVlJUilAWIvSAzROZ btb56r0Op4ZAUhxFOmSHdx4yyvB = this._Btb56r0Op4ZAUhxFOmSHdx4yyvB;
				if (btb56r0Op4ZAUhxFOmSHdx4yyvB == null)
				{
					break;
				}
				btb56r0Op4ZAUhxFOmSHdx4yyvB(client2);
			}
		}
		catch (Exception ex)
		{
			string str = "Listener: Failed to accept client!\nReason:\n";
			Exception ex2 = ex;
			Console.WriteLine(str + ((ex2 != null) ? ex2.ToString() : null));
		}
		try
		{
			TcpListener nfgb8pFqFgUhAbKIn1asL966JOGA = this._nfgb8pFqFgUhAbKIn1asL966JOGA;
			if (nfgb8pFqFgUhAbKIn1asL966JOGA != null)
			{
				nfgb8pFqFgUhAbKIn1asL966JOGA.BeginAcceptTcpClient(new AsyncCallback(this._nfTgYJVtdPvFQP9il911kWtN5gC), null);
			}
		}
		catch (Exception innerException)
		{
			throw new Exception("Failed to listen for clients!", innerException);
		}
	}

	// Token: 0x06000210 RID: 528 RVA: 0x0000F0FC File Offset: 0x0000D2FC
	public void _p0WXw9am2tv4jtnCVkyCMJHeDrR(Client client)
	{
		_Ps42O2MmsFVlJUilAWIvSAzROZ hFu05GzdJqHXbAwtqBL9NTBAxUS = this._hFu05GzdJqHXbAwtqBL9NTBAxUS;
		if (hFu05GzdJqHXbAwtqBL9NTBAxUS == null)
		{
			return;
		}
		hFu05GzdJqHXbAwtqBL9NTBAxUS(client);
	}

	// Token: 0x06000211 RID: 529 RVA: 0x0000F11C File Offset: 0x0000D31C
	public void FireClientDisconnected(Client client)
	{
		_Ps42O2MmsFVlJUilAWIvSAzROZ qGdzddO22NoijWY9im3O8jEA78d = this._qGdzddO22NoijWY9im3O8jEA78d;
		if (qGdzddO22NoijWY9im3O8jEA78d == null)
		{
			return;
		}
		qGdzddO22NoijWY9im3O8jEA78d(client);
	}

	// Token: 0x06000212 RID: 530 RVA: 0x0000F13C File Offset: 0x0000D33C
	public void _TDrFXcTAjgN5GbHg6KToDxTmgfK(int id)
	{
		HotkeyHandler wuIWyF7JKrmhDOnv8QncHvL3ChC = this._wuIWyF7JKrmhDOnv8QncHvL3ChC;
		if (wuIWyF7JKrmhDOnv8QncHvL3ChC == null)
		{
			return;
		}
		wuIWyF7JKrmhDOnv8QncHvL3ChC(id);
	}

	// Token: 0x0400026D RID: 621
	private TcpListener _nfgb8pFqFgUhAbKIn1asL966JOGA;

	// Token: 0x0400026E RID: 622
	public ConcurrentDictionary<string, ReconnectPacket> _15LfsipxJm1I78mh9UGesTHpsVC;
}
