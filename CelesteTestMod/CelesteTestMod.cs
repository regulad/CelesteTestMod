using Celeste.Mod;

namespace CelesteTestMod
{
    [SettingName("CelesteTestMod Settings")]
    public class CelesteTestModuleSettings : EverestModuleSettings
    {
        
    }
    
    public class CelesteTestModule : EverestModule
    {
        public static CelesteTestModule Instance;

        public CelesteTestModule()
        {
            Instance = this;
        }

        public override void Load()
        {
        }

        public override void Unload()
        {   
        }
    }
}