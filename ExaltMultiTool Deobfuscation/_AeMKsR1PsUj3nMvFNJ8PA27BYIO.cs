using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using ExaltMultiTool.Properties;

// Token: 0x0200001E RID: 30
internal class _AeMKsR1PsUj3nMvFNJ8PA27BYIO
{
	// Token: 0x060001EE RID: 494 RVA: 0x0000E840 File Offset: 0x0000CA40
	static _AeMKsR1PsUj3nMvFNJ8PA27BYIO()
	{
		if (File.Exists(_AeMKsR1PsUj3nMvFNJ8PA27BYIO._GApuxDco3FAKbIkPXnHBxsWFEou))
		{
			string text = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString() + ".old");
			string text2 = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString() + ".old");
			File.Move(_AeMKsR1PsUj3nMvFNJ8PA27BYIO._GApuxDco3FAKbIkPXnHBxsWFEou, text);
			File.Move(_AeMKsR1PsUj3nMvFNJ8PA27BYIO._pU9IrCjrnvlduh3CLjorrSfqFdo, text2);
			try
			{
				File.Delete(text);
				File.Delete(text2);
			}
			catch
			{
				Console.WriteLine("Old lib is in use...");
			}
		}
		File.WriteAllBytes(_AeMKsR1PsUj3nMvFNJ8PA27BYIO._GApuxDco3FAKbIkPXnHBxsWFEou, _VIgCTVMa1A4g21SK8I7wH9AJhr8A._zbwBPvIMxddujLrnbDDa5hmqEzo);
		File.WriteAllBytes(_AeMKsR1PsUj3nMvFNJ8PA27BYIO._pU9IrCjrnvlduh3CLjorrSfqFdo, _VIgCTVMa1A4g21SK8I7wH9AJhr8A._eiIGyc5VbJc9a14Nr8WuWRrNxog);
		AppDomain.CurrentDomain.ProcessExit += _AeMKsR1PsUj3nMvFNJ8PA27BYIO._iPfB1peMqsHMPW4BFgwB3Xlp6lt;
	}

	// Token: 0x060001EF RID: 495 RVA: 0x0000E954 File Offset: 0x0000CB54
	private static void _iPfB1peMqsHMPW4BFgwB3Xlp6lt(object sender, EventArgs e)
	{
		try
		{
			File.Delete(_AeMKsR1PsUj3nMvFNJ8PA27BYIO._GApuxDco3FAKbIkPXnHBxsWFEou);
			File.Delete(_AeMKsR1PsUj3nMvFNJ8PA27BYIO._pU9IrCjrnvlduh3CLjorrSfqFdo);
		}
		catch
		{
			Console.WriteLine("Lib is in use...");
		}
	}

	// Token: 0x060001F0 RID: 496 RVA: 0x0000E994 File Offset: 0x0000CB94
	public static bool _mNU0yVH4EShRKUXDCDDhYFIVI4O(bool steam)
	{
		bool result;
		try
		{
			_IHUllfO6Rr4ri1gTkx9LNb4zz7B._J0aIDoHCkWgcWw0uCooc5ephxRP j0aIDoHCkWgcWw0uCooc5ephxRP = _AeMKsR1PsUj3nMvFNJ8PA27BYIO._FPps3jZBoGO0bkCsDyvjeBfLxRd(steam ? Settings.Default.ExaltSteamPath : Settings.Default.ExaltLauncherPath, string.Empty);
			_AeMKsR1PsUj3nMvFNJ8PA27BYIO._bPv9QJwCvTSIRPd7nsvDiBgAO4f(j0aIDoHCkWgcWw0uCooc5ephxRP._HyvxStAm0VOjSioacl29yNsrDt, _AeMKsR1PsUj3nMvFNJ8PA27BYIO._pU9IrCjrnvlduh3CLjorrSfqFdo);
			_IHUllfO6Rr4ri1gTkx9LNb4zz7B.ResumeThread(j0aIDoHCkWgcWw0uCooc5ephxRP._1Q6OhWwzHCa01w0vHlMIlPGJi7C);
			result = true;
		}
		catch (Exception ex)
		{
			string str = "Failed to start Exalt Launcher:\n";
			Exception ex2 = ex;
			MessageBox.Show(str + ((ex2 != null) ? ex2.ToString() : null) + "\nLast Error: " + Marshal.GetLastWin32Error().ToString(), "RealmStock Multi-Tool", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			result = false;
		}
		return result;
	}

	// Token: 0x060001F1 RID: 497 RVA: 0x0000EA30 File Offset: 0x0000CC30
	public static bool _u7ga6IKB4PyD5qGeSHNJ0VnV5Ro(string guid, string password)
	{
		bool result;
		try
		{
			_IHUllfO6Rr4ri1gTkx9LNb4zz7B._J0aIDoHCkWgcWw0uCooc5ephxRP j0aIDoHCkWgcWw0uCooc5ephxRP = _AeMKsR1PsUj3nMvFNJ8PA27BYIO._FPps3jZBoGO0bkCsDyvjeBfLxRd(Settings.Default.ExaltGamePath, _AeMKsR1PsUj3nMvFNJ8PA27BYIO._X0E5ZXEqBHnem6VlBOADnPhjAoB(guid, password));
			_AeMKsR1PsUj3nMvFNJ8PA27BYIO._bPv9QJwCvTSIRPd7nsvDiBgAO4f(j0aIDoHCkWgcWw0uCooc5ephxRP._HyvxStAm0VOjSioacl29yNsrDt, _AeMKsR1PsUj3nMvFNJ8PA27BYIO._GApuxDco3FAKbIkPXnHBxsWFEou);
			_IHUllfO6Rr4ri1gTkx9LNb4zz7B.ResumeThread(j0aIDoHCkWgcWw0uCooc5ephxRP._1Q6OhWwzHCa01w0vHlMIlPGJi7C);
			result = true;
		}
		catch (Exception ex)
		{
			string str = "Failed to start Exalt Game:\n";
			Exception ex2 = ex;
			MessageBox.Show(str + ((ex2 != null) ? ex2.ToString() : null) + "\nLast Error: " + Marshal.GetLastWin32Error().ToString(), "RealmStock Multi-Tool", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			result = false;
		}
		return result;
	}

	// Token: 0x060001F2 RID: 498 RVA: 0x0000EAC0 File Offset: 0x0000CCC0
	private static _IHUllfO6Rr4ri1gTkx9LNb4zz7B._J0aIDoHCkWgcWw0uCooc5ephxRP _FPps3jZBoGO0bkCsDyvjeBfLxRd(string path, string args)
	{
		string text = Path.Combine(Path.GetDirectoryName(path), "UnityCrashHandler64.exe");
		string text2 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\RealmOfTheMadGod\\Production", "UnityCrashHandler64.exe");
		try
		{
			if (File.Exists(text))
			{
				File.Delete(text);
			}
			if (File.Exists(text2))
			{
				File.Delete(text2);
			}
		}
		catch (Exception innerException)
		{
			throw new Exception(string.Concat(new string[]
			{
				"PLEASE DELETE THE FOLLOWING FILES TO MAKE IT WORK:\n- ",
				text,
				"\n- ",
				text2,
				"\n\nOnly if they exist."
			}), innerException);
		}
		_IHUllfO6Rr4ri1gTkx9LNb4zz7B._vD19RcCHhrzDFjiXS4cc6afA2SM vD19RcCHhrzDFjiXS4cc6afA2SM = default(_IHUllfO6Rr4ri1gTkx9LNb4zz7B._vD19RcCHhrzDFjiXS4cc6afA2SM);
		_IHUllfO6Rr4ri1gTkx9LNb4zz7B._J0aIDoHCkWgcWw0uCooc5ephxRP j0aIDoHCkWgcWw0uCooc5ephxRP;
		if (!_IHUllfO6Rr4ri1gTkx9LNb4zz7B.CreateProcess(path, args, IntPtr.Zero, IntPtr.Zero, true, 4u, IntPtr.Zero, IntPtr.Zero, ref vD19RcCHhrzDFjiXS4cc6afA2SM, out j0aIDoHCkWgcWw0uCooc5ephxRP))
		{
			throw new Exception("CreateProcess");
		}
		_AeMKsR1PsUj3nMvFNJ8PA27BYIO._6aOF1kRdHAJ12JEKkgKBTV5DOgE.Add(j0aIDoHCkWgcWw0uCooc5ephxRP._NeMalFUiCtYfZtv1CSbtaExX3Xv);
		Console.WriteLine("Started Process: " + path);
		return j0aIDoHCkWgcWw0uCooc5ephxRP;
	}

	// Token: 0x060001F3 RID: 499 RVA: 0x0000EBB4 File Offset: 0x0000CDB4
	private static void _bPv9QJwCvTSIRPd7nsvDiBgAO4f(IntPtr pHandle, string path)
	{
		byte[] bytes = Encoding.Default.GetBytes(path);
		uint num = 0u;
		uint num2 = 0u;
		IntPtr procAddress = _IHUllfO6Rr4ri1gTkx9LNb4zz7B.GetProcAddress(_IHUllfO6Rr4ri1gTkx9LNb4zz7B.GetModuleHandleA("kernel32.dll"), "LoadLibraryA");
		if (procAddress == IntPtr.Zero)
		{
			throw new Exception("GetProcAddress");
		}
		IntPtr intPtr = _IHUllfO6Rr4ri1gTkx9LNb4zz7B.VirtualAllocEx(pHandle, IntPtr.Zero, (uint)bytes.Length, 12288u, 64u);
		if (intPtr == IntPtr.Zero)
		{
			throw new Exception("VirtualAllocEx");
		}
		if (!_IHUllfO6Rr4ri1gTkx9LNb4zz7B.WriteProcessMemory(pHandle, intPtr, bytes, (uint)bytes.Length, ref num))
		{
			throw new Exception("WriteProcessMemory");
		}
		IntPtr intPtr2 = _IHUllfO6Rr4ri1gTkx9LNb4zz7B.CreateRemoteThread(pHandle, IntPtr.Zero, 0u, procAddress, intPtr, 0u, ref num2);
		if (intPtr2 == IntPtr.Zero)
		{
			throw new Exception("CreateRemoteThread");
		}
		_IHUllfO6Rr4ri1gTkx9LNb4zz7B.WaitForSingleObject(intPtr2, uint.MaxValue);
		_IHUllfO6Rr4ri1gTkx9LNb4zz7B.CloseHandle(intPtr2);
		Console.WriteLine(string.Format("Injected Successfully: {0} {1}", pHandle, path));
	}

	// Token: 0x060001F4 RID: 500 RVA: 0x0000EC98 File Offset: 0x0000CE98
	private static string _X0E5ZXEqBHnem6VlBOADnPhjAoB(string guid, string password)
	{
		string text = Convert.ToBase64String(password);
		string text2 = Convert.ToBase64String(guid);
		return string.Concat(new string[]
		{
			"data:{platform:Deca,password:",
			text,
			",guid:",
			text2,
			",env:4}"
		});
	}

	// Token: 0x060001F5 RID: 501 RVA: 0x0000ECE0 File Offset: 0x0000CEE0
	private static string _KmFK1a4OjBt2lStFOJoewt8nHOD(string plainText)
	{
		return Convert.ToBase64String(Encoding.UTF8.GetBytes(plainText));
	}

	// Token: 0x04000266 RID: 614
	private static readonly string _GApuxDco3FAKbIkPXnHBxsWFEou = Path.Combine(Path.GetTempPath(), "rs.dll");

	// Token: 0x04000267 RID: 615
	private static readonly string _pU9IrCjrnvlduh3CLjorrSfqFdo = Path.Combine(Path.GetTempPath(), "rsl.dll");

	// Token: 0x04000268 RID: 616
	public static List<int> _6aOF1kRdHAJ12JEKkgKBTV5DOgE = new List<int>();
}
