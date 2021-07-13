using System.Collections.Generic;
using System.Linq;

namespace bs_design_patterns.strategy
{
    class SampleContext
    {
        public IPricingStrategy Strategy { get; set; }
        public Dictionary<string, decimal> ProductIdToNetPriceMap { get; } = new Dictionary<string, decimal>();

        public decimal CalculateFinalPrice()
        {
            return ProductIdToNetPriceMap.Sum(x => Strategy.CalculateFinalPrice(x.Value));
        }
    }
}
