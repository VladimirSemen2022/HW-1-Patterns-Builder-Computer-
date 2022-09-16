using HW_1_Patterns_Builder__Computer_.Components;
using HW_1_Patterns_Builder__Computer_.ComputerComponents.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_1_Patterns_Builder__Computer_.Builder
{
    public interface IBuilder
    {
        void BuildLowConfiguration();

        void BuildMiddleConfiguration();

        void BuildHighConfiguration();

        void BuildMyConfiguration();
    }
}
