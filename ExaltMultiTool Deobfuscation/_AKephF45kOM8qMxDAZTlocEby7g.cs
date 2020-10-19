using System;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;
using ExaltMultiTool.Properties;

// Token: 0x02000006 RID: 6
internal static class _AKephF45kOM8qMxDAZTlocEby7g
{
	// Token: 0x0600002B RID: 43 RVA: 0x0000A7EC File Offset: 0x000089EC
	[STAThread]
	private static void _TM39YXTm8oFYInd0OqOaKOqtE8g()
	{
		_IHUllfO6Rr4ri1gTkx9LNb4zz7B.SetProcessDPIAware();
		ServicePointManager.Expect100Continue = false;
		if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			string location = Assembly.GetExecutingAssembly().Location;
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.Verb = "runas";
			processStartInfo.FileName = location;
			try
			{
				Process.Start(processStartInfo);
			}
			catch (Win32Exception)
			{
				return;
			}
			return;
		}
		bool flag;
		using (new Mutex(true, "ExaltMultiTool", ref flag))
		{
			if (!flag)
			{
				MessageBox.Show("Another copy of Exalt Multi-Tool is already running!\nPlease close it. You may need to check Task Manager process list to find it.", "Exalt Multi-Tool", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			else
			{
				_IHUllfO6Rr4ri1gTkx9LNb4zz7B.ShowWindow(_IHUllfO6Rr4ri1gTkx9LNb4zz7B.GetConsoleWindow(), 0);
				Console.SetOut(_AKephF45kOM8qMxDAZTlocEby7g._63nAPmtLwQUd16dZsiPmECNiU9x);
				Console.SetError(_AKephF45kOM8qMxDAZTlocEby7g._63nAPmtLwQUd16dZsiPmECNiU9x);
				try
				{
					Settings.Default.Reload();
				}
				catch (ConfigurationErrorsException ex)
				{
					ConfigurationErrorsException ex2 = ex.InnerException as ConfigurationErrorsException;
					if (ex2 == null || string.IsNullOrEmpty(ex2.Filename))
					{
						string str = "Settings are corrupt! Please delete settings files in %appdata%.";
						ConfigurationErrorsException ex3 = ex;
						MessageBox.Show(str + ((ex3 != null) ? ex3.ToString() : null), "Exalt Multi-Tool", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						return;
					}
					File.Delete(ex2.Filename);
				}
				if (Settings.Default.ID == Guid.Empty)
				{
					Settings.Default.ID = Guid.NewGuid();
				}
				try
				{
					TcpListener tcpListener = new TcpListener(IPAddress.Parse("127.0.0.1"), 2050);
					tcpListener.Server.NoDelay = true;
					tcpListener.Start();
					tcpListener.Stop();
				}
				catch (Exception ex4)
				{
					string str2 = "Unable to bind to port 2050!\nPlease make sure no program is currently open and using that port!\nRESTART YOUR COMPUTER TO FIX THIS ISSUE!\n\nMore info:\n";
					Exception ex5 = ex4;
					MessageBox.Show(str2 + ((ex5 != null) ? ex5.ToString() : null), "Exalt Multi-Tool", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					return;
				}
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new _O8RCBX441Egsj4ff5BOJx95ggk8());
				_AKephF45kOM8qMxDAZTlocEby7g._FESbSf2FD6xzO1S5CPEQKFNWFtF();
			}
		}
	}

	// Token: 0x0600002C RID: 44 RVA: 0x0000AA08 File Offset: 0x00008C08
	public static void _FESbSf2FD6xzO1S5CPEQKFNWFtF()
	{
		try
		{
			string str = Uri.EscapeDataString(_AKephF45kOM8qMxDAZTlocEby7g._63nAPmtLwQUd16dZsiPmECNiU9x.ToString());
			using (WebClient webClient = new WebClient())
			{
				webClient.Headers.Add(HttpRequestHeader.Accept, "application/json, */*");
				webClient.Headers.Add(HttpRequestHeader.ContentType, "application/json");
				webClient.UploadString("https://realmstock.network/Public/ExaltReport" + string.Format("?identity={0}", Settings.Default.ID), "\"" + str + "\"");
			}
		}
		catch (Exception ex)
		{
			string str2 = "Failed to start logging! Please report this issue as the tool cannot function.\n\n";
			Exception ex2 = ex;
			MessageBox.Show(str2 + ((ex2 != null) ? ex2.ToString() : null), "Exalt Multi-Tool", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}

	// Token: 0x040000AB RID: 171
	private static StringWriter _63nAPmtLwQUd16dZsiPmECNiU9x = new StringWriter();
}
