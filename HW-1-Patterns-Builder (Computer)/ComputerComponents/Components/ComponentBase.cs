namespace HW_1_Patterns_Builder__Computer_.ComputerComponents.Components
{
    public class ComponentBase
    {
        public string Component { get; set; }
        public string ComponentName { get; set; }
        public string Manufacturer { get; set; }
        public string Features { get; set; }
        public int Cost { get; set; }

        public ComponentBase()
        {
            Component = string.Empty;
            ComponentName = string.Empty;
            Manufacturer = string.Empty;
            Features = string.Empty;
            Cost = 0;
        }
        public ComponentBase(string component, string name, string manufacturer, string features, int cost)
        {
            Component = component;
            ComponentName = name;
            Manufacturer = manufacturer;
            Features = features;
            Cost = cost;
        }

        public override string ToString()
        {
            return $" {Component} - {ComponentName}, {Features}, Manufacturer - {Manufacturer}, cost - {Cost}";
        }
    }
}
