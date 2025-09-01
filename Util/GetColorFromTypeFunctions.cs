namespace AnsiConsolePlugin.Util
{
	public class GetColorFromTypeFunctions
	{
		public static string GetColorFromInt(int X, string Type)
		{
			string[] typedList = Type switch
            {
                "Regular" => ANSICodeLists.ColorList,
                "Bold" => ANSICodeLists.BoldColorList,
                "Darkened" => ANSICodeLists.DarkenedColorList,
                "Italic" => ANSICodeLists.ItalicColorList,
                "Underlined" => ANSICodeLists.UnderlineColorList,
                "Flashy" => ANSICodeLists.FlashyColorList,
                "Highlighter" => ANSICodeLists.HighlighterColorList,
                "Invisible" => ANSICodeLists.InvisibleColorList,
                "Strikethrough" => ANSICodeLists.StrikethroughColorList,
                "Background" => ANSICodeLists.BackgroundColorList,
                "HighIntensityRegular" => ANSICodeLists.HighIntensityColorList,
                "HighIntensityBold" => ANSICodeLists.HighIntensityBoldColorList,
                "HighIntensityDarkened" => ANSICodeLists.HighIntensityDarkenedColorList,
                "HighIntensityItalic" => ANSICodeLists.HighIntensityItalicColorList,
                "HighIntensityUnderlined" => ANSICodeLists.HighIntensityUnderlineColorList,
                "HighIntensityFlashy" => ANSICodeLists.HighIntensityFlashyColorList,
                "HighIntensityHighlighter" => ANSICodeLists.HighIntensityHighlighterColorList,
                "HighIntensityInvisible" => ANSICodeLists.HighIntensityInvisibleColorList,
                "HighIntensityStrikethrough" => ANSICodeLists.HighIntensityStrikethroughColorList,
                "HighIntensityBackground" => ANSICodeLists.HighIntensityBackgroundColorList,
                _ => ANSICodeLists.ColorList,
            };
			
			return typedList[X];
		}
		
		public static string GetColorFromString(string Color, string Type)
		{
			int X = Color switch
			{
				"Black" => 0,
				"Red" => 1,
				"Green" => 2,
				"Yellow" => 3,
				"Blue" => 4,
				"Magenta" => 5,
				"Cyan" => 6,
				"White" => 7,
				_ => 7,
			};
			
			string[] typedList = Type switch
			{
				"Regular" => ANSICodeLists.ColorList,
				"Bold" => ANSICodeLists.BoldColorList,
				"Darkened" => ANSICodeLists.DarkenedColorList,
				"Italic" => ANSICodeLists.ItalicColorList,
				"Underlined" => ANSICodeLists.UnderlineColorList,
				"Flashy" => ANSICodeLists.FlashyColorList,
				"Highlighter" => ANSICodeLists.HighlighterColorList,
				"Invisible" => ANSICodeLists.InvisibleColorList,
				"Strikethrough" => ANSICodeLists.StrikethroughColorList,
				"Background" => ANSICodeLists.BackgroundColorList,
				"HighIntensityRegular" => ANSICodeLists.HighIntensityColorList,
				"HighIntensityBold" => ANSICodeLists.HighIntensityBoldColorList,
				"HighIntensityDarkened" => ANSICodeLists.HighIntensityDarkenedColorList,
				"HighIntensityItalic" => ANSICodeLists.HighIntensityItalicColorList,
				"HighIntensityUnderlined" => ANSICodeLists.HighIntensityUnderlineColorList,
				"HighIntensityFlashy" => ANSICodeLists.HighIntensityFlashyColorList,
				"HighIntensityHighlighter" => ANSICodeLists.HighIntensityHighlighterColorList,
				"HighIntensityInvisible" => ANSICodeLists.HighIntensityInvisibleColorList,
				"HighIntensityStrikethrough" => ANSICodeLists.HighIntensityStrikethroughColorList,
				"HighIntensityBackground" => ANSICodeLists.HighIntensityBackgroundColorList,
				_ => ANSICodeLists.ColorList,
			};
			
			return typedList[X];
		}
	}
}