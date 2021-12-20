using Celeste.Mod;

namespace CelesteTestMod
{
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