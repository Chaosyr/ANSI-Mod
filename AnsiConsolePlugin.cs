using System;
using System.Collections.Generic;
using AnsiConsolePlugin.Util;
using Mono.Cecil;

namespace AnsiConsolePlugin
{
    /// <summary>
    /// The Main Class of the Patcher.
    /// </summary>
    /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
    public class AnsiConsolePlugin
    {
        /// <summary>
        /// A blank set of TargetDLLs so that BepInEx patchers resolve correctly.
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        public static IEnumerable<string> TargetDLLs { get { yield break; }}
        
        /// <summary>
        /// Initializes the Patcher enabling UTF8 and VirtualTerminalProcessing if successfully Windows.
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        public static void Initialize()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine();
            Console.WriteLine("Enabled UTF8 Encoding on Output and Input, now attempting to enable ANSI!");
            try
            {
                EnableNativeAnsiUtil.EnableNativeAnsi();
                Console.WriteLine("We have enabled ANSI in the Terminal! This will last the entirety of the Console Session.");
            }
            catch
            {
                Console.WriteLine("Unable to enable ANSI Code Handling.");
            }
            Console.WriteLine("We are attempting a Test to see if this is working!");
            Test.TestMain();
        }

        /// <summary>
        /// A blank patch that way the BepInEx Patcher System resolves correctly.
        /// </summary>
        /// <param name="assembly">An assembly passed into the Patch.</param>
        public static void Patch(AssemblyDefinition assembly) {}
    }
}