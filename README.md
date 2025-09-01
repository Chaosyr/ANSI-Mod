# ANSI Mod

This mod essentially enables the ability to use ANSI in BepInEx for Windows 10+.

## Functions;

This mod Includes 2 Nifty functions for fetching a ANSI Code Color.

* GetColorFromInt; Takes a Int from 0-7, and a String related to the Type of Color System your after.
* GetColorFromString; Takes a String that represents the color, note in present theres only 7 shades, and a String related to the type of Color System your after.

## Defining The Function Variables;

For the Int in GetColorFromInt here's a Nifty table association for the values, similarly the Color in the table represents the colors that can be Inputted in GetColorFromString;

| Color | Int To Enter |
|:-:|:------------:|
| Black |      0       |
| Red |      1       |
| Green |      2       |
| Yellow |      3       |
| Blue |      4       |
| Magenta |      5       |
| Cyan |      6       |
| White |      7       |

For the Modes its a bit more Complex but heres a Run Down; 

| Type |                                               What It Does                                               | What To Enter |
|:-:|:--------------------------------------------------------------------------------------------------------:|:-:|
| Regular |                               This is essentially just the Mundane colors.                               | Regular |
| Bold |                        This will make the text and color bold and more prominent.                        | Bold |
| Darkened |              The opposite of Bold, it will make the text and color dark and less prominent.              | Darkened |
| Italic |                         This is will make the text along with the color Italic.                          | Italic |
| Underlined |                         This will make the text along with the color Underlined.                         | Underlined |
| Flashy |                      This will make the text along with the color Blink on and off.                      | Flashy |
| Highlighter | This will make the text the shade given and the background behind it the inverse of the shade specified. | Highlighter |
| Invisible |                         This will make the text invisible along with the color.                          | Invisible |
| Strikethrough |                    This will make the text look like it has a line going through it.                     | Strikethrough |
| Background |                   This will make the background behind the text the color associated.                    | Background |
Each of the above also has a High Intensity variant which is essentially just a brighter version of the given shade, it can be called by entering `HighIntensity` before the mode your entering for example `HighIntensityRegular`.

## Maintaining and or Updating/Porting:

Send a PR to the repository if you would like to update the mod in any way shape or form.

Porting is allowed as long as proper and full credits are instated and the provided Liscense is KEPT.

If you would like this mod/lib added into your community shoot me a message over on Discord at `@thincreator3483`

Also while im at it, if anything here is innacurate and or needs changes lemme know ^^

## Credits:

As of 1.0.0

* Creator - ANSICodeLists.cs, GetColorFromTypeFunctions.cs, and AnsiConsolePlugin.cs base. As well as the Thunderstore/GitHub relaed elements.
* Regretfully GPT - EnableNativeAnsi.cs