namespace bs_design_patterns.strategy
{
    class RegularPricingStrategy : IPricingStrategy
    {
        private readonly decimal tax;

        public RegularPricingStrategy(decimal tax)
        {
            this.tax = tax;
        }

        public decimal CalculateFinalPrice(decimal netPrice)
        {
            return netPrice * this.tax;
        }
    }
}
