using System;
using System.Collections.Generic;
using System.Text;

namespace bs_design_patterns.flyweight
{
    /// <summary>
    /// this is flyweight object, common properties contained by separate class, factory creates few instances which will be referenced by many end objects
    /// </summary>
    public class Engine
    {
        public Engine(string name, int power, EngineType type)
        {
            this.Name = name;
            this.Power = power;
            this.Type = type;
        }

        public string Name
        {
            get;
        }

        public int Power
        {
            get;
        }

        public EngineType Type
        {
            get;
        }

    }
}
