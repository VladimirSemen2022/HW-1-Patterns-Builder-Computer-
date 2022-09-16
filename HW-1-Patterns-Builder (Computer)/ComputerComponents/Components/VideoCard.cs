using HW_1_Patterns_Builder__Computer_.ComputerComponents.Components;

namespace HW_1_Patterns_Builder__Computer_.Components
{
    public class VideoCard: ComponentBase
    {
        public VideoCard()
        { }
        public VideoCard(string name, string manufacturer, string features, int cost) : base("VideoCard", name, manufacturer, features, cost)
        { }

        public ComponentBase LowConfiguration(string name = "Radeon RX 6400", string manufacturer = "GIGABYTE", string features = "2321 MGz, GDDR6 4GB, 64b 16000 МGz, PCI Express 4.0", int cost = 7300)
        {
            return new  VideoCard(name, manufacturer, features, cost);
        }

        public ComponentBase MiddleConfiguration(string name = "GeForce RTX 3060 Ti", string manufacturer = "ASUS", string features = "1785 MGz, GDDR6 8GB, 256b 14000 MGz, PCI Express 4.0 x16", int cost = 26000)
        {
            return new  VideoCard(name, manufacturer, features, cost);
        }

        public ComponentBase HighConfiguration(string name = "GeForce RTX 3080 Ti", string manufacturer = "ASUS", string features = "1695 MGz, GDDR6X 12GB, 384b 19000 MGz, PCI Express 4.0 x16", int cost = 60000)
        {
            return new VideoCard(name, manufacturer, features, cost);
        }

        public ComponentBase MyConfiguration(string name, string manufacturer, string features, int cost)
        {
            return new VideoCard(name, manufacturer, features, cost);
        }
    }
}
