using ICities;

namespace DisastersEnablerMod
{
    public class Mod : IUserMod
    {
        public string Name
        {
            get { return "Disaster Enabler Mod"; }
        }

        public string Description
        {
            get { return "Enables random disasters for scenarios."; }
        }
    }
}
