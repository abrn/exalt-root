using System;
using System.Collections.Concurrent;
using System.Net;
using System.Net.Sockets;

internal class Proxy
{
	public event ConnectionHandler ClientBeginConnect;

	public event ConnectionHandler ClientConnected;

	public event ConnectionHandler ClientDisconnected;

	public event HotkeyHandler HotkeyPressed;

	public void Start()
	{
		Console.WriteLine("Listener: Starting local listener....");
		this.ClientDestinations = new ConcurrentDictionary<string, ReconnectPacket>();
		this._localListener = new TcpListener(IPAddress.Parse("127.0.0.1"), 2050);
		this._localListener.Start();
		this._localListener.BeginAcceptTcpClient(new AsyncCallback(this.LocalConnect), null);
		Console.WriteLine("Listener: Started local listener.");
	}

	private void LocalConnect(IAsyncResult ar)
	{
		try
		{
			TcpClient client = this._localListener.EndAcceptTcpClient(ar);
			Client client2 = new Client(this, client);
			Console.WriteLine("Listener: Client recieved.");
			ConnectionHandler clientBeginConnect = this.ClientBeginConnect;
			if (clientBeginConnect != null)
			{
				clientBeginConnect(client2);
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
			TcpListener localListener = this._localListener;
			if (localListener != null)
			{
				localListener.BeginAcceptTcpClient(new AsyncCallback(this.LocalConnect), null);
			}
		}
		catch (Exception ex3)
		{
			throw new Exception("Failed to listen for clients!", ex3);
		}
	}

	public void FireClientConnected(Client client)
	{
		ConnectionHandler clientConnected = this.ClientConnected;
		if (clientConnected == null)
		{
			return;
		}
		clientConnected(client);
	}

	public void FireClientDisconnected(Client client)
	{
		ConnectionHandler qGdzddO22NoijWY9im3O8jEA78d = this.ClientDisconnected;
		if (qGdzddO22NoijWY9im3O8jEA78d == null)
		{
			return;
		}
		qGdzddO22NoijWY9im3O8jEA78d(client);
	}

	public void FireHotkeyPressed(int id)
	{
		HotkeyHandler hotkeyPressed = this.HotkeyPressed;
		if (hotkeyPressed == null)
		{
			return;
		}
		hotkeyPressed(id);
	}

	private TcpListener _localListener;

	public ConcurrentDictionary<string, ReconnectPacket> ClientDestinations;
}
