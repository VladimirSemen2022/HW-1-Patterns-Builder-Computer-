using HW_1_Patterns_Builder__Computer_.ComputerComponents.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_1_Patterns_Builder__Computer_.Components
{
    public class Processor : ComponentBase
    {
        public Processor()
        { }
        public Processor(string name, string manufacturer, string features, int cost) : base("Processor", name, manufacturer, features, cost)
        { }

        public ComponentBase LowConfiguration(string name = "Core i3-10105F", string manufacturer = "Intel", string features = "core: 4/8, 3.7GHz (6MB, Comet Lake, 65W, S1200)", int cost = 2800)
        {
            return new Processor(name, manufacturer, features, cost);
        }

        public ComponentBase MiddleConfiguration(string name = "Ryzen 5 5500", string manufacturer = "AMD", string features = "core: 6/12, 3.6GHz (16MB, 65W,  sAM4)", int cost = 5200)
        {
            return new Processor(name, manufacturer, features, cost);
        }

        public ComponentBase HighConfiguration(string name = "Ryzen 7 5800X3D", string manufacturer = "AMD", string features = "core: 8/16, 3.4GHz (96MB, 105W, sAM4)", int cost = 17000)
        {
            return new  Processor(name, manufacturer, features, cost);
        }

        public ComponentBase MyConfiguration(string name, string manufacturer, string features, int cost)
        {
            return new Processor(name, manufacturer, features, cost);
        }
    }
}
