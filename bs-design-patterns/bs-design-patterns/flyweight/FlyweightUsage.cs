using System;
using System.Collections.Generic;
using System.Text;

namespace bs_design_patterns.flyweight
{
    public class FlyweightUsage
    {
        private static readonly EngineFactory _engineFactory = new EngineFactory();

        public static void Run()
        {
            var tucson = new Car();
            tucson.Make = "Hyundai";
            tucson.Model = "Tucson";
            tucson.Engine = _engineFactory.GetEngine("1.6 t-gdi 6mt", EngineType.Petrol, 150);

            var i30 = new Car();
            i30.Make = "Hyundai";
            i30.Model = "I30";
            i30.Engine = _engineFactory.GetEngine("1.6 t-gdi 6mt", EngineType.Petrol, 150); // engine will be shared, engine is flyweight, the same engine referenced by different car models

            Console.WriteLine(tucson.Engine.Power);
            Console.WriteLine(i30.Engine.Power);

            Console.WriteLine(tucson.Engine.GetHashCode());
            Console.WriteLine(i30.Engine.GetHashCode());
        }
    }
}
