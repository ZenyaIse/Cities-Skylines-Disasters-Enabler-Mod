using ICities;
using ColossalFramework;

namespace DisastersEnablerMod
{
    public class Threading: ThreadingExtensionBase
    {
        public override void OnAfterSimulationFrame()
        {
            // If playing a scenario
            if (!string.IsNullOrEmpty(Singleton<SimulationManager>.instance.m_metaData.m_ScenarioAsset))
            {
                DisasterManager dm = Singleton<DisasterManager>.instance;

                // See DisasterManager.SimulationStepImpl for the details how random disasters are started.
                if (dm.m_randomDisasterCooldown == 0)
                {
                    dm.StartRandomDisaster();
                }
            }
        }
    }
}
