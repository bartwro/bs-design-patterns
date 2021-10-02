using System;
using System.Collections.Generic;
using System.Text;

namespace bs_design_patterns.flyweight
{
    public class EngineFactory
    {
        private Dictionary<string, Engine> _cache = new Dictionary<string, Engine>();
        public Engine GetEngine(string name, EngineType type, int power)
        {
            if(_cache.ContainsKey(name))
            {
                return _cache[name];
            }
            else
            {
                //todo multithreading might be a problem, mabye - verify...
                _cache[name] = new Engine(name, power, type);
                return _cache[name];
            }
        }
    }
}
