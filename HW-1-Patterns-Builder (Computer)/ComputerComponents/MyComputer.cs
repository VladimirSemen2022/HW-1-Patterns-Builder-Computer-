using HW_1_Patterns_Builder__Computer_.ComputerComponents.Components;
using System.Collections.Generic;

namespace HW_1_Patterns_Builder__Computer_.Computer
{
    public class MyComputer
    {
        private List<ComponentBase> _components = new List<ComponentBase>();

        public void Add(ComponentBase component)
        {
            this._components.Add(component);
        }

        public string ListComponents()
        {
            string str = string.Empty;

            for (int i = 0; i < this._components.Count; i++)
            {
                str += this._components[i] + "\n";
            }
            str = str.Remove(str.Length - 2); // removing last ",c"

            return "Computer components:\n" + str + "\n";
        }

        public List<ComponentBase> GetComponetsList()
        {
            return _components;
        }
    }
}
