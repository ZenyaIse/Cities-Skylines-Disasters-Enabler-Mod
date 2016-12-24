using ICities;
using ColossalFramework;

namespace DisastersEnablerMod
{
    public class Threading: ThreadingExtensionBase
    {
        private int randomDisasterCooldown_prevValue = 0;

        public override void OnAfterSimulationFrame()
        {
            // If playing a scenario
            if (!string.IsNullOrEmpty(Singleton<SimulationManager>.instance.m_metaData.m_ScenarioAsset))
            {
                DisasterManager dm = Singleton<DisasterManager>.instance;

                // See DisasterManager.SimulationStepImpl for the details how random disasters are started.
                if (randomDisasterCooldown_prevValue != 0 && dm.m_randomDisasterCooldown == 0)
                {
                    dm.StartRandomDisaster();
                }

                randomDisasterCooldown_prevValue = dm.m_randomDisasterCooldown;
            }
        }
    }
}
