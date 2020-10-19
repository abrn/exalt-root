using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using ExaltMultiTool.Properties;

// Token: 0x020000A4 RID: 164
internal class AntiAFK
{
	// Token: 0x0600046A RID: 1130
	[DllImport("user32.dll")]
	private static extern bool PostMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

	// Token: 0x0600046B RID: 1131 RVA: 0x00017698 File Offset: 0x00015898
	public AntiAFK(Client client)
	{
		this.client = client;
	}

	// Token: 0x0600046C RID: 1132 RVA: 0x000176C8 File Offset: 0x000158C8
	public void move(MovePacket move)
	{
		if (!Settings.Default.EnableAntiAFK)
		{
			return;
		}
		DateTime now = DateTime.Now;
		if (this._lastLocation.X != move.NewPosition.X || this._lastLocation.Y != move.NewPosition.Y)
		{
			this._lastMove = now;
			this._lastLocation = move.NewPosition;
		}
		if (now.Subtract(this._lastMove) > TimeSpan.FromMinutes(5.0))
		{
			this._lastMove = now;
			Process[] processesByName = Process.GetProcessesByName("RotMG Exalt");
			if (processesByName.Any<Process>())
			{
				Console.WriteLine("Client: Activating Anti AFK");
				AntiAFK.PostMessage(processesByName.First<Process>().MainWindowHandle, 513u, 1, 1);
				Thread.Sleep(32);
				AntiAFK.PostMessage(processesByName.First<Process>().MainWindowHandle, 514u, 0, 1);
			}
		}
	}

	private Client client;
	// Token: 0x0400058E RID: 1422
	private const int WM_LBUTTONDOWN = 513;

	// Token: 0x0400058F RID: 1423
	private const int WM_LBUTTONUP = 514;

	// Token: 0x04000591 RID: 1425
	private DateTime _lastMove;

	// Token: 0x04000592 RID: 1426
	private Location _fakeMousePosition;
	private Location _lastLocation = Location.Empty;
}
