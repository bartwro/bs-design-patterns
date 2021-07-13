using bs_design_patterns.mediator;
using bs_design_patterns.strategy;
using System;

namespace bs_design_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            RunStrategy();
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
