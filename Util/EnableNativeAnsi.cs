using System;
using System.Runtime.InteropServices;

namespace AnsiConsolePlugin.Util
{
	/// <summary>
	/// This is the class that handles enabling ANSI.
	/// </summary>
	public class EnableNativeAnsiUtil
	{
		/// <summary>
		/// A Function that when called Enables ANSI via Kernel level calls, it enables it via Virtual Terminal Processing.
		/// </summary>
		/// <returns>Either nothing happens if the OS is not Windows, or Enables Virtual Terminal Processing.</returns>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		public static void EnableNativeAnsi()
		{
			PlatformID platform = Environment.OSVersion.Platform;

			if (platform != PlatformID.Win32NT)
				return;

			IntPtr intStandardOut = FetchSTDHandle(-11);
			FetchSTDHandleValue(intStandardOut, out uint consoleMode);
			consoleMode |= 0x0004;
			SetSTDHandleValue(intStandardOut, consoleMode);
		}
		
		/// <summary>
		/// This function gets the STD Handle at the given Integer.
		/// </summary>
		/// <param name="location">The Integer of the STD Handle</param>
		/// <returns>An IntPtr representing the given STD Handle.</returns>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		[DllImport("kernel32.dll", EntryPoint = "GetStdHandle", SetLastError = true)]
		public static extern IntPtr FetchSTDHandle(int location);

		/// <summary>
		/// Takes an STD Handle and returns its value.
		/// </summary>
		/// <param name="passedHandle">This represents the STD Handle being passed in.</param>
		/// <param name="fetchedMode">This is a uint representing the Value of the Handle.</param>
		/// <returns>The setMode of the passed in Handle.</returns>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		[DllImport("kernel32.dll", EntryPoint = "GetConsoleMode", SetLastError = true)]
		public static extern bool FetchSTDHandleValue(IntPtr passedHandle, out uint fetchedMode);

		/// <summary>
		/// Takes an STD Handle and Assigns it a New Value.
		/// </summary>
		/// <param name="passedHandle">This represents the STD Handle being passed in.</param>
		/// <param name="setMode">This is a uint in which will act as the overrider for the Handles value.</param>
		/// <returns>An updated STD Handle.</returns>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		[DllImport("kernel32.dll", EntryPoint = "SetConsoleMode", SetLastError = true)]
		public static extern bool SetSTDHandleValue(IntPtr passedHandle, uint setMode);
	}
}