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
            int tmp = 0;
            for (int i = 0; i < this._components.Count; i++)
            {
                str += this._components[i] + "\n";
                tmp += this._components[i].Cost;
            }
            str = str.Remove(str.Length - 2); // removing last ",c"

            return $"Computer components:\n{str}\n\nEqual cost of computer - {tmp}";
        }

        public List<ComponentBase> GetComponetsList()
        {
            return _components;
        }
    }
}
