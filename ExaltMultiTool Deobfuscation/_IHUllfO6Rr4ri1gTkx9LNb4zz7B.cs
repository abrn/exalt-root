using System;
using System.Drawing;
using System.Runtime.InteropServices;

internal static class _IHUllfO6Rr4ri1gTkx9LNb4zz7B
{
	[DllImport("kernel32.dll")]
	public static extern IntPtr GetConsoleWindow();

	[DllImport("user32.dll")]
	public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool CreatePipe(out IntPtr hReadPipe, out IntPtr hWritePipe, ref _IHUllfO6Rr4ri1gTkx9LNb4zz7B._X5PGIETLJH9wJVpdiCIS8hMxI0f lpPipeAttributes, int nSize);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr GetStdHandle(int nStdHandle);

	[DllImport("user32.dll", SetLastError = true)]
	public static extern bool SetProcessDPIAware();

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool AllocConsole();

	[DllImport("user32.dll")]
	public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

	[DllImport("user32.dll")]
	public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

	[DllImport("Kernel32", SetLastError = true)]
	public static extern IntPtr OpenProcess(uint dwDesiredAccess, bool bInheritHandle, uint dwProcessId);

	[DllImport("kernel32", SetLastError = true)]
	public static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr GetModuleHandleA(string lpModuleName);

	[DllImport("Kernel32", SetLastError = true)]
	public static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	[DllImport("Kernel32", SetLastError = true)]
	public static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [MarshalAs(UnmanagedType.AsAny)] object lpBuffer, uint nSize, ref uint lpNumberOfBytesWritten);

	[DllImport("Kernel32", SetLastError = true)]
	public static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, ref uint lpThreadId);

	[DllImport("Kernel32", SetLastError = true)]
	public static extern bool CloseHandle(IntPtr hObject);

	[DllImport("Kernel32", SetLastError = true)]
	public static extern bool WaitForSingleObject(IntPtr hHandle, uint dwMilliseconds);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool SetConsoleMode(IntPtr hConsoleHandle, int mode);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool GetConsoleMode(IntPtr handle, out int mode);

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern uint ResumeThread(IntPtr hThread);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern bool CreateProcess(string lpApplicationName, string lpCommandLine, IntPtr lpProcessAttributes, IntPtr lpThreadAttributes, bool bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment, IntPtr lpCurrentDirectory, [In] ref _IHUllfO6Rr4ri1gTkx9LNb4zz7B._vD19RcCHhrzDFjiXS4cc6afA2SM lpStartupInfo, out _IHUllfO6Rr4ri1gTkx9LNb4zz7B._J0aIDoHCkWgcWw0uCooc5ephxRP lpProcessInformation);

	[DllImport("user32.dll")]
	private static extern bool GetClientRect(IntPtr hWnd, ref _IHUllfO6Rr4ri1gTkx9LNb4zz7B.Pos lpRect);

	[DllImport("user32.dll")]
	private static extern bool ClientToScreen(IntPtr hWnd, ref Point lpPoint);

	[DllImport("user32.dll")]
	public static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll")]
	public static extern bool SetForegroundWindow(IntPtr hWnd);

	[DllImport("user32.dll")]
	public static extern int GetWindowThreadProcessId(IntPtr hWnd, out int processId);

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

	public static Point point(IntPtr h)
	{
		Point empty = Point.Empty;
        ClientToScreen(h, ref empty);
		return empty;
	}

	internal struct _X5PGIETLJH9wJVpdiCIS8hMxI0f
	{
		public int _twSOCVya0PnbvxY8WvImX10r93y;

		public IntPtr _sTHZagMxcVmQQzCI5YHcN04uYUB;

		public int _Up8HHus2ea1zJZyVXRCzrZcACYF;
	}

	internal enum ProcessAccessFlags
	{
		All = 2035711,
		Terminate = 1,
		CreateThread,
		VirtualMemoryOperation = 8,
		VirtualMemoryRead = 16,
		VirtualMemoryWrite = 32,
		DuplicateHandle = 64,
		CreateProcess = 128,
		SetQuota = 256,
		SetInformation = 512,
		QueryInformation = 1024,
		QueryLimitedInformation = 4096,
		Synchronize = 1048576
	}

	internal enum VirtualAllocEx
	{
		MEM_COMMIT = 4096,
		MEM_RESERVE = 8192,
		MEM_RESET = 524288,
		MEM_RESET_UNDO = 16777216,
		SecCommit = 134217728
	}

	internal enum WinNT
	{
		PAGE_EXECUTE = 16,
		PAGE_EXECUTE_READ = 32,
		PAGE_EXECUTE_READWRITE = 64,
		PAGE_EXECUTE_WRITECOPY = 128,
		PAGE_NOACCESS = 1,
		PAGE_READONLY,
		PAGE_READWRITE = 4,
		PAGE_WRITECOPY = 8,
		PAGE_TARGETS_INVALID = 1073741824,
		PAGE_TARGETS_NO_UPDATE = 1073741824
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct _vD19RcCHhrzDFjiXS4cc6afA2SM
	{
		public int _wgxCoc0Fc4j3zDLCGz3jaf0mobBA;

		public string _FIaU1wJ7218amRHM7RnCG1FIVet;

		public string _OuATS2Ew9foiH7KbhAC2uqV6O5B;

		public string _wR6PWJ68yV9FVW59OOj4AzCEJmI;

		public int _1qkSLZTBOURwjAC8z6NhK8KSqdl;

		public int _gBt8oLxcAPnGvr1g4oNjxmuvJ9D;

		public int _nl0c0qQnFXYeV1h7ilVpcI4LPHb;

		public int _Inm8D0YMlXjlSrvlKpkYduhuEjh;

		public int _YJGlozIBdWFtPPD5EUgZRJHOirH;

		public int _G0GEnVM8VPQqLpFCXnbOjmnYkmj;

		public int _wj4ds46bBes0FrSRsyEDJmTvlZE;

		public int _KhfIuTreIJCatLJzx6Yz833QDPh;

		public short _RAqGCsYJuhC7xiRkpziYGmLK5PL;

		public short _mimZNABM5CmdsXiP3uIliUl04uH;

		public IntPtr _zmrczc0vCl2u6zcBmZrPZTG39pc;

		public IntPtr _VYx12dUFCK8ebCE5hdoGofRFgt3;

		public IntPtr _OAbsQmirmi9feL61AQEYa2Mjeln;

		public IntPtr _v4glSZobB0RhGgXIdHCsM16r7gLA;
	}

	internal struct _J0aIDoHCkWgcWw0uCooc5ephxRP
	{
		public IntPtr _HyvxStAm0VOjSioacl29yNsrDt;

		public IntPtr _1Q6OhWwzHCa01w0vHlMIlPGJi7C;

		public int _NeMalFUiCtYfZtv1CSbtaExX3Xv;

		public int _XeXRBnW5gB44v8xh1ozVCXpJGQm;
	}

	private struct Pos
	{
		internal Pos(int left, int top, int right, int bottom)
		{
			this.left = left;
			this.top = top;
			this.right = right;
			this.bottom = bottom;
		}

		public int left;

		public int top;

		public int right;

		public int bottom;
	}
}
