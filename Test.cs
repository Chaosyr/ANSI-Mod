using System;
using Cecil_Libraries.ANSI_Utils.Lists;
using Cecil_Libraries.ANSI_Utils.Objects;
using Cecil_Libraries.ANSI_Utils.Util;

namespace AnsiConsolePlugin;

/// <summary>
/// This is our Test to ensure the System is working!!
/// </summary>
/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
public class Test
{
    /// <summary>
    /// The Text Color
    /// </summary>
    /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
    public static ColorRGB NeonGreen = new ColorRGB("Regular", ConvertFromXToRGB.ConverToRGBFromHex("#217727"));

    /// <summary>
    /// The Background Color
    /// </summary>
    /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
    public static ColorRGB NeonGreenBG =
        new ColorRGB("Regular", ConvertFromXToRGB.ConverToRGBFromHex("#1b1f1b"), background: true);

    /// <summary>
    /// A function that both makes defines the Logo and Prints it to the Terminal.
    /// </summary>
    /// <param name="args">Arguments passed in when the program is running, this does not take any, however.</param>
    /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
    public static void TestMain()
    {
        // Combine the two defined colors.
        string combinedColor = $"\x1B[0;38{NeonGreen.Extra};48{NeonGreenBG.Extra}m";

        // We utilize Pipes because they are consistent, the following are all of the Pipe characters that will work nicely.
        // ┌
        // ─
        // ┐
        // └
        // ┘
        // ╎
        // Note there may be more characters that could work!
        string logo = """
                      ┌──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐
                      │                                                                                                                                                  │
                      │          ┌─────┬─────┐   ┌         ┐   ┌─────────┐          ┌────────────┐   ┌         ┐   ┌───────────┐   ┌──────────┐   ┌─────┬─────┐          │
                      │                │         │         │   │                    │                │         │   │           │   │                    │                │
                      │                │         │         │   │                    │                │         │   │           │   │                    │                │
                      │                │         │         │   │                    │                │         │   │           │   │                    │                │
                      │                │         ├─────────┤   ├──────────          │       ┌────┐   ├─────────┤   │           │   └──────────┐         │                │
                      │                │         │         │   │                    │            │   │         │   │           │              │         │                │
                      │                │         │         │   │                    │            │   │         │   │           │              │         │                │
                      │                │         │         │   │                    │            │   │         │   │           │              │         │                │
                      │                └         └         ┘   └─────────┘          └────────────┘   └         ┘   └───────────┘   └──────────┘         └                │
                      │                                                                                                                                                  │
                      │                                ┌─────┬─────┐   ┌┐        ┐          ┌─────┬─────┐   ┌         ┐   ┌─────────┐                                    │
                      │                                      │         │ ╎       │                │         │         │   │                                              │
                      │                                      │         │  ╎      │                │         │         │   │                                              │
                      │                                      │         │   ╎     │                │         │         │   │                                              │
                      │                                      │         │    ╎    │                │         ├─────────┤   ├──────────                                    │
                      │                                      │         │     ╎   │                │         │         │   │                                              │
                      │                                      │         │      ╎  │                │         │         │   │                                              │
                      │                                      │         │       ╎ │                │         │         │   │                                              │
                      │                                └─────┴─────┘   └        └┘                └         └         ┘   └─────────┘                                    │
                      │                                                                                                                                                  │
                      │                                           ┌───────────┐   ┌───────────┐   ┌─────────┐     ┌─────────┐                                            │
                      │                                           │               │           │   │          ╎    │                                                      │
                      │                                           │               │           │   │           ╎   │                                                      │
                      │                                           │               │     │     │   │     │      │  │                                                      │
                      │                                           │               │    ─│─    │   │    ─│─     │  ├──────────                                            │
                      │                                           │               │     │     │   │     │      │  │                                                      │
                      │                                           │               │           │   │           ╎   │                                                      │
                      │                                           │               │           │   │          ╎    │                                                      │
                      │                                           └───────────┘   └───────────┘   └─────────┘     └─────────┘                                            │
                      │                                                                                                                                                  │
                      └──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘
                      """;

        // This section essentially prints out our Logo in a way that prints nicely for Terminals and shouldn't bleed.
        string[] lines = logo.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
        
        Console.WriteLine(combinedColor);

        foreach (var line in lines)
        {
            Console.WriteLine(line);
        }

        Console.Write(ANSICodeLists.ResetColor + "\n");
    }
}