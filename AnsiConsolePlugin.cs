using BepInEx;
using BepInEx.Logging;
using AnsiConsolePlugin.Util;

namespace AnsiConsolePlugin
{
    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
    public class DraftingMod : BaseUnityPlugin
    {
        public const string PluginGuid = "creator.BepInEx.ANSI";
        public const string PluginName = "ANSI Mod";
        public const string PluginVersion = "1.0.0";

        // Define a Manual Log Source
        public static ManualLogSource Log = new ManualLogSource(PluginName);
        
        public void Awake()
        {
            try
            {
                EnableNativeAnsiUtil.EnableNativeAnsi();
            }
            catch
            {
                Log.LogError("Unable to enable ANSI Code Handling.");
            }
        }
    }
}