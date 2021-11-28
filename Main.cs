using MelonLoader;

namespace TestMod
{
    public static class BuildInfo
    {
        public const string Name = "CrabRave"; // Name of the Mod.  (MUST BE SET)
        public const string Description = "Crab Game Hacking"; // Description for the Mod.  (Set as null if none)
        public const string Author = "Synical"; // Author of the Mod.  (MUST BE SET)
        public const string Company = null; // Company that made the Mod.  (Set as null if none)
        public const string Version = "1.0.0"; // Version of the Mod.  (MUST BE SET)
        public const string DownloadLink = null; // Download Link for the Mod.  (Set as null if none)
    }

    public class CrabRave : MelonMod
    {
        public Text watermark;
    
        public override void OnApplicationStart() // Runs after Game Initialization.
        {
            MelonLogger.Msg("CrabRave is now loaded!");
            watermark.text = "CrabRave 0.0.1 by @Synical#7052";
        }

        public override void OnApplicationLateStart() // Runs after OnApplicationStart.
        {
            MelonLogger.Msg("All credit goes to @Synical#7052");
        }
        
        public override void OnSceneWasInitialized(int buildindex, string sceneName) // Runs when a Scene has Initialized and is passed the Scene's Build Index and Name.
        {
            MelonLogger.Msg("OnSceneWasInitialized: " + buildindex.ToString() + " | " + sceneName);
        }

        public override void OnUpdate() // Runs once per frame.
        {
            
        }

        public override void OnGUI() // Can run multiple times per frame. Mostly used for Unity's IMGUI.
        {
            MelonLogger.Msg("OnGUI");
        }

        public override void OnApplicationQuit() // Runs when the Game is told to Close.
        {
            MelonLogger.Msg("CrabRave is shutting down...");
        }

    }
}
