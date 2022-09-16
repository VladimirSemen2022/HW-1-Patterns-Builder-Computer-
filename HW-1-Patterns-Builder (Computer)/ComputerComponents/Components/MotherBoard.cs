using HW_1_Patterns_Builder__Computer_.ComputerComponents.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_1_Patterns_Builder__Computer_.Components
{
    public class MotherBoard : ComponentBase
    {

        public MotherBoard()
        { }

        public MotherBoard(string name, string manufacturer, string features, int cost) : base("MotherBoard", name, manufacturer, features, cost)
        { }

        public ComponentBase LowConfiguration(string name = "H510", string manufacturer = "MSI", string features = "Socket 1200, LGA 1200, Micro-ATX", int cost = 2000)
        {
            return new  MotherBoard(name, manufacturer, features, cost);
        }

        public ComponentBase MiddleConfiguration(string name = "B550", string manufacturer = "ASUS", string features = "AM4, Micro-ATX", int cost = 3300)
        {
            return new  MotherBoard(name, manufacturer, features, cost);
        }

        public ComponentBase HighConfiguration(string name = "B550 AORUS ELITE V2", string manufacturer = "ASUS", string features = "AM4, Micro-ATX", int cost = 4000)
        {
            return new MotherBoard(name, manufacturer, features, cost);
        }

        public ComponentBase MyConfiguration(string name, string manufacturer, string features, int cost)
        {
            return new MotherBoard(name, manufacturer, features, cost);
        }
    }
}
