using System;
using System.Drawing;
using System.Runtime.InteropServices;

// Token: 0x02000007 RID: 7
internal static class _IHUllfO6Rr4ri1gTkx9LNb4zz7B
{
	// Token: 0x0600002E RID: 46
	[DllImport("kernel32.dll")]
	public static extern IntPtr GetConsoleWindow();

	// Token: 0x0600002F RID: 47
	[DllImport("user32.dll")]
	public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

	// Token: 0x06000030 RID: 48
	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool CreatePipe(out IntPtr hReadPipe, out IntPtr hWritePipe, ref _IHUllfO6Rr4ri1gTkx9LNb4zz7B._X5PGIETLJH9wJVpdiCIS8hMxI0f lpPipeAttributes, int nSize);

	// Token: 0x06000031 RID: 49
	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr GetStdHandle(int nStdHandle);

	// Token: 0x06000032 RID: 50
	[DllImport("user32.dll", SetLastError = true)]
	public static extern bool SetProcessDPIAware();

	// Token: 0x06000033 RID: 51
	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool AllocConsole();

	// Token: 0x06000034 RID: 52
	[DllImport("user32.dll")]
	public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

	// Token: 0x06000035 RID: 53
	[DllImport("user32.dll")]
	public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

	// Token: 0x06000036 RID: 54
	[DllImport("Kernel32", SetLastError = true)]
	public static extern IntPtr OpenProcess(uint dwDesiredAccess, bool bInheritHandle, uint dwProcessId);

	// Token: 0x06000037 RID: 55
	[DllImport("kernel32", SetLastError = true)]
	public static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

	// Token: 0x06000038 RID: 56
	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr GetModuleHandleA(string lpModuleName);

	// Token: 0x06000039 RID: 57
	[DllImport("Kernel32", SetLastError = true)]
	public static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	// Token: 0x0600003A RID: 58
	[DllImport("Kernel32", SetLastError = true)]
	public static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [MarshalAs(UnmanagedType.AsAny)] object lpBuffer, uint nSize, ref uint lpNumberOfBytesWritten);

	// Token: 0x0600003B RID: 59
	[DllImport("Kernel32", SetLastError = true)]
	public static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, ref uint lpThreadId);

	// Token: 0x0600003C RID: 60
	[DllImport("Kernel32", SetLastError = true)]
	public static extern bool CloseHandle(IntPtr hObject);

	// Token: 0x0600003D RID: 61
	[DllImport("Kernel32", SetLastError = true)]
	public static extern bool WaitForSingleObject(IntPtr hHandle, uint dwMilliseconds);

	// Token: 0x0600003E RID: 62
	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool SetConsoleMode(IntPtr hConsoleHandle, int mode);

	// Token: 0x0600003F RID: 63
	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool GetConsoleMode(IntPtr handle, out int mode);

	// Token: 0x06000040 RID: 64
	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern uint ResumeThread(IntPtr hThread);

	// Token: 0x06000041 RID: 65
	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern bool CreateProcess(string lpApplicationName, string lpCommandLine, IntPtr lpProcessAttributes, IntPtr lpThreadAttributes, bool bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment, IntPtr lpCurrentDirectory, [In] ref _IHUllfO6Rr4ri1gTkx9LNb4zz7B._vD19RcCHhrzDFjiXS4cc6afA2SM lpStartupInfo, out _IHUllfO6Rr4ri1gTkx9LNb4zz7B._J0aIDoHCkWgcWw0uCooc5ephxRP lpProcessInformation);

	// Token: 0x06000042 RID: 66
	[DllImport("user32.dll")]
	private static extern bool GetClientRect(IntPtr hWnd, ref _IHUllfO6Rr4ri1gTkx9LNb4zz7B.Pos lpRect);

	// Token: 0x06000043 RID: 67
	[DllImport("user32.dll")]
	private static extern bool ClientToScreen(IntPtr hWnd, ref Point lpPoint);

	// Token: 0x06000044 RID: 68
	[DllImport("user32.dll")]
	public static extern IntPtr GetForegroundWindow();

	// Token: 0x06000045 RID: 69
	[DllImport("user32.dll")]
	public static extern bool SetForegroundWindow(IntPtr hWnd);

	// Token: 0x06000046 RID: 70
	[DllImport("user32.dll")]
	public static extern int GetWindowThreadProcessId(IntPtr hWnd, out int processId);

	// Token: 0x06000047 RID: 71 RVA: 0x0000AAF4 File Offset: 0x00008CF4
	public static Size getSize(IntPtr h)
	{
        Pos pos = default(Pos);
        GetClientRect(h, ref pos);
		return new Size
		{
			Width = pos.right - pos.left,
			Height = pos.bottom - pos.top
		};
	}

	// Token: 0x06000048 RID: 72 RVA: 0x0000AB44 File Offset: 0x00008D44
	public static Point point(IntPtr h)
	{
		Point empty = Point.Empty;
        ClientToScreen(h, ref empty);
		return empty;
	}

	// Token: 0x040000AC RID: 172
	public const int _VOy14xb8yJECyeRATqfJqGIPtH5 = 0;

	// Token: 0x040000AD RID: 173
	public const int _zlW6zSAsvXMC8AA0Ttd2TfTmamk = 5;

	// Token: 0x02000008 RID: 8
	internal struct _X5PGIETLJH9wJVpdiCIS8hMxI0f
	{
		// Token: 0x040000AE RID: 174
		public int _twSOCVya0PnbvxY8WvImX10r93y;

		// Token: 0x040000AF RID: 175
		public IntPtr _sTHZagMxcVmQQzCI5YHcN04uYUB;

		// Token: 0x040000B0 RID: 176
		public int _Up8HHus2ea1zJZyVXRCzrZcACYF;
	}

	// Token: 0x02000009 RID: 9
	internal enum _oaArE3vUrfGgVmSQLWMBejKk95f
	{
		// Token: 0x040000B2 RID: 178
		All = 2035711,
		// Token: 0x040000B3 RID: 179
		Terminate = 1,
		// Token: 0x040000B4 RID: 180
		CreateThread,
		// Token: 0x040000B5 RID: 181
		VirtualMemoryOperation = 8,
		// Token: 0x040000B6 RID: 182
		VirtualMemoryRead = 16,
		// Token: 0x040000B7 RID: 183
		VirtualMemoryWrite = 32,
		// Token: 0x040000B8 RID: 184
		DuplicateHandle = 64,
		// Token: 0x040000B9 RID: 185
		CreateProcess = 128,
		// Token: 0x040000BA RID: 186
		SetQuota = 256,
		// Token: 0x040000BB RID: 187
		SetInformation = 512,
		// Token: 0x040000BC RID: 188
		QueryInformation = 1024,
		// Token: 0x040000BD RID: 189
		QueryLimitedInformation = 4096,
		// Token: 0x040000BE RID: 190
		Synchronize = 1048576
	}

	// Token: 0x0200000A RID: 10
	internal enum _D4hbKtVww5trumbVLnvoivgVOUp
	{
		// Token: 0x040000C0 RID: 192
		MEM_COMMIT = 4096,
		// Token: 0x040000C1 RID: 193
		MEM_RESERVE = 8192,
		// Token: 0x040000C2 RID: 194
		MEM_RESET = 524288,
		// Token: 0x040000C3 RID: 195
		MEM_RESET_UNDO = 16777216,
		// Token: 0x040000C4 RID: 196
		SecCommit = 134217728
	}

	// Token: 0x0200000B RID: 11
	internal enum _8BJwnPW44Kb5PGC66MbgrnFM4Oe
	{
		// Token: 0x040000C6 RID: 198
		PAGE_EXECUTE = 16,
		// Token: 0x040000C7 RID: 199
		PAGE_EXECUTE_READ = 32,
		// Token: 0x040000C8 RID: 200
		PAGE_EXECUTE_READWRITE = 64,
		// Token: 0x040000C9 RID: 201
		PAGE_EXECUTE_WRITECOPY = 128,
		// Token: 0x040000CA RID: 202
		PAGE_NOACCESS = 1,
		// Token: 0x040000CB RID: 203
		PAGE_READONLY,
		// Token: 0x040000CC RID: 204
		PAGE_READWRITE = 4,
		// Token: 0x040000CD RID: 205
		PAGE_WRITECOPY = 8,
		// Token: 0x040000CE RID: 206
		PAGE_TARGETS_INVALID = 1073741824,
		// Token: 0x040000CF RID: 207
		PAGE_TARGETS_NO_UPDATE = 1073741824
	}

	// Token: 0x0200000C RID: 12
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct _vD19RcCHhrzDFjiXS4cc6afA2SM
	{
		// Token: 0x040000D0 RID: 208
		public int _wgxCoc0Fc4j3zDLCGz3jaf0mobBA;

		// Token: 0x040000D1 RID: 209
		public string _FIaU1wJ7218amRHM7RnCG1FIVet;

		// Token: 0x040000D2 RID: 210
		public string _OuATS2Ew9foiH7KbhAC2uqV6O5B;

		// Token: 0x040000D3 RID: 211
		public string _wR6PWJ68yV9FVW59OOj4AzCEJmI;

		// Token: 0x040000D4 RID: 212
		public int _1qkSLZTBOURwjAC8z6NhK8KSqdl;

		// Token: 0x040000D5 RID: 213
		public int _gBt8oLxcAPnGvr1g4oNjxmuvJ9D;

		// Token: 0x040000D6 RID: 214
		public int _nl0c0qQnFXYeV1h7ilVpcI4LPHb;

		// Token: 0x040000D7 RID: 215
		public int _Inm8D0YMlXjlSrvlKpkYduhuEjh;

		// Token: 0x040000D8 RID: 216
		public int _YJGlozIBdWFtPPD5EUgZRJHOirH;

		// Token: 0x040000D9 RID: 217
		public int _G0GEnVM8VPQqLpFCXnbOjmnYkmj;

		// Token: 0x040000DA RID: 218
		public int _wj4ds46bBes0FrSRsyEDJmTvlZE;

		// Token: 0x040000DB RID: 219
		public int _KhfIuTreIJCatLJzx6Yz833QDPh;

		// Token: 0x040000DC RID: 220
		public short _RAqGCsYJuhC7xiRkpziYGmLK5PL;

		// Token: 0x040000DD RID: 221
		public short _mimZNABM5CmdsXiP3uIliUl04uH;

		// Token: 0x040000DE RID: 222
		public IntPtr _zmrczc0vCl2u6zcBmZrPZTG39pc;

		// Token: 0x040000DF RID: 223
		public IntPtr _VYx12dUFCK8ebCE5hdoGofRFgt3;

		// Token: 0x040000E0 RID: 224
		public IntPtr _OAbsQmirmi9feL61AQEYa2Mjeln;

		// Token: 0x040000E1 RID: 225
		public IntPtr _v4glSZobB0RhGgXIdHCsM16r7gLA;
	}

	// Token: 0x0200000D RID: 13
	internal struct _J0aIDoHCkWgcWw0uCooc5ephxRP
	{
		// Token: 0x040000E2 RID: 226
		public IntPtr _HyvxStAm0VOjSioacl29yNsrDt;

		// Token: 0x040000E3 RID: 227
		public IntPtr _1Q6OhWwzHCa01w0vHlMIlPGJi7C;

		// Token: 0x040000E4 RID: 228
		public int _NeMalFUiCtYfZtv1CSbtaExX3Xv;

		// Token: 0x040000E5 RID: 229
		public int _XeXRBnW5gB44v8xh1ozVCXpJGQm;
	}

	// Token: 0x0200000E RID: 14
	private struct Pos
	{
		// Token: 0x06000049 RID: 73 RVA: 0x0000AB64 File Offset: 0x00008D64
		internal Pos(int left, int top, int right, int bottom)
		{
			this.left = left;
			this.top = top;
			this.right = right;
			this.bottom = bottom;
		}

		// Token: 0x040000E6 RID: 230
		public int left;

		// Token: 0x040000E7 RID: 231
		public int top;

		// Token: 0x040000E8 RID: 232
		public int right;

		// Token: 0x040000E9 RID: 233
		public int bottom;
	}
}
