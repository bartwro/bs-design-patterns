using bs_design_patterns.mediator;
using System;

namespace bs_design_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var mediator = new ConcreteMediator();
            var c1 = mediator.CreateColleague<ConcreteColleague>();
            var c2 = mediator.CreateColleague<ConcreteColleague>();
            c1.SendMessage("hello from c1");
            Console.ReadKey();
        }
    }
}
