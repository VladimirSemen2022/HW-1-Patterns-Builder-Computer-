using HW_1_Patterns_Builder__Computer_.ComputerComponents.Components;


namespace HW_1_Patterns_Builder__Computer_.Components
{
    public class HDD : ComponentBase
    {
        public HDD ()
        { }
        public HDD(string name, string manufacturer, string features, int cost) : base("Storage", name, manufacturer, features, cost)
        { }

        public ComponentBase LowConfiguration(string name="SSD", string manufacturer="Kingston", string features= " 2.5″ SATA, 500GB", int cost=1500)
        {
            return new  HDD(name, manufacturer, features, cost);
        }

        public ComponentBase MiddleConfiguration(string name = "SSD", string manufacturer = "Samsung", string features = "M.2 PCIe 3.0, 1TB", int cost = 3000)
        {
            return new  HDD(name, manufacturer, features, cost);
        }

        public ComponentBase HighConfiguration(string name = "SSD", string manufacturer = "Samsung", string features = "M.2 PCIe 4.0, 2TB", int cost = 11000)
        {
            return new  HDD(name, manufacturer, features, cost);
        }

        public ComponentBase MyConfiguration(string name, string manufacturer, string features, int cost)
        {
            return new HDD(name, manufacturer, features, cost);
        }
    }
}
