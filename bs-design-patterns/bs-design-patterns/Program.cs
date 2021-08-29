using bs_design_patterns.flyweight;
using bs_design_patterns.mediator;
using bs_design_patterns.memento;
using bs_design_patterns.strategy;
using System;

namespace bs_design_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestTasks1.Main1();
            //MementoScenario();
            Example.Run();
            Console.ReadKey();
        }

        private static void MementoScenario()
        {
            var orig = new Memento.Originator();
            var ct = new Caretaker(orig);
            ct.ChangeOrig("1");
            ct.ChangeOrig("2");
            ct.ChangeOrig("3");
            ct.ChangeOrig("4");
            ct.ChangeOrig("5");
            ct.ChangeOrig("6");
            ct.ChangeOrig("7");
            while (true)
            {
                var key = Console.ReadKey().Key;
                if (key == ConsoleKey.U)
                {
                    ct.Undo();

                }
                else if (key == ConsoleKey.R)
                {
                    ct.Redo();
                }
                else if (key == ConsoleKey.Q)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong key, must be u(undo), r(redo) or q(quit)");
                }
                Console.WriteLine($"Actual value: {orig._state}");
            }
            Console.ReadKey();
        }

        private static void RunStrategy()
        {
            var sample = new SampleContext();
            sample.ProductIdToNetPriceMap.Add("1", 200.99m);
            sample.ProductIdToNetPriceMap.Add("2", 349m);
            sample.ProductIdToNetPriceMap.Add("3", 98m);
            sample.Strategy = new RegularPricingStrategy(0.23m);
            Console.WriteLine($"Regular price: {sample.CalculateFinalPrice()}");
            sample.Strategy = new DiscountPricingStrategy(0.23m, 0.3m);
            Console.WriteLine($"30% discounted price: {sample.CalculateFinalPrice()}");
        }

        private static void RunMediator()
        {
            var mediator = new ConcreteMediator();
            var c1 = mediator.CreateColleague<ConcreteColleague>();
            var c2 = mediator.CreateColleague<ConcreteColleague>();
            c1.SendMessage("hello from c1");
        }
    }
}
