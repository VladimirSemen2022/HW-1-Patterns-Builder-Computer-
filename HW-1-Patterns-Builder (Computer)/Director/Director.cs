using HW_1_Patterns_Builder__Computer_.Builder;
using HW_1_Patterns_Builder__Computer_.Components;

namespace HW_1_Patterns_Builder__Computer_
{
    public class Director
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        }

        public void BuildLowConfiguration()
        {
            this._builder.BuildLowConfiguration();
        }

        public void BuildMiddleConfiguration()
        {
            this._builder.BuildMiddleConfiguration();
        }

        public void BuildHighConfiguration()
        {
            this._builder.BuildHighConfiguration();
        }
        public void BuildMyConfiguration()
        {
            this._builder.BuildMyConfiguration();
        }
    }
}
