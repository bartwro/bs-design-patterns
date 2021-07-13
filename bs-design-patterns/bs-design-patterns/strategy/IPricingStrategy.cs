namespace bs_design_patterns.strategy
{
    interface IPricingStrategy
    {
        decimal CalculateFinalPrice(decimal netPrice);
    }
}
