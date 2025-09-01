using System;
using System.Runtime.InteropServices;

namespace AnsiConsolePlugin.Util
{
	public class EnableNativeAnsiUtil
	{
		// Regrettfully this bit is written by AI, I couldn't figure out how to do it myself.
		public static void EnableNativeAnsi()
		{
			IntPtr intStandardOut = GetStdHandle(-11);
			GetConsoleMode(intStandardOut, out uint consoleMode);
			consoleMode |= 0x0004;
			SetConsoleMode(intStandardOut, consoleMode);
		}
		
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern IntPtr GetStdHandle(int nStdHandle);

		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern bool GetConsoleMode(IntPtr hConsoleHandle, out uint lpMode);

		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern bool SetConsoleMode(IntPtr hConsoleHandle, uint dwMode);
	}
}