using HW_1_Patterns_Builder__Computer_.ComputerComponents.Components;

namespace HW_1_Patterns_Builder__Computer_.Components
{
    public class RAM : ComponentBase
    {
        public RAM()
        { }
        public RAM(string name, string manufacturer, string features, int cost) : base("RAM", name, manufacturer, features, cost)
        { }

        public ComponentBase LowConfiguration(string name = "2×8 GB", string manufacturer = "AMD", string features = "DDR4 2666 MGz", int cost = 2000)
        {
            return new RAM(name, manufacturer, features, cost);
        }

        public ComponentBase MiddleConfiguration(string name = "2×16 GB", string manufacturer = "Kingston", string features = "DDR4 3600 MGz", int cost = 4500)
        {
            return new RAM(name, manufacturer, features, cost);
        }

        public ComponentBase HighConfiguration(string name = "2×32 GB", string manufacturer = "G.Skill", string features = "DDR4 3600 MGz", int cost = 10000)
        {
            return new RAM(name, manufacturer, features, cost);
        }

        public ComponentBase MyConfiguration(string name, string manufacturer, string features, int cost)
        {
            return new RAM(name, manufacturer, features, cost);
        }
    }
}
