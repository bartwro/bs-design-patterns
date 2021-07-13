namespace bs_design_patterns.strategy
{
    class DiscountPricingStrategy : IPricingStrategy
    {
        private readonly decimal tax;
        private readonly decimal discount;

        public DiscountPricingStrategy(decimal tax, decimal discount)
        {
            this.tax = tax;
            this.discount = discount;
        }

        public decimal CalculateFinalPrice(decimal netPrice)
        {
            return (1 - discount) * (netPrice * tax);
        }
    }
}
