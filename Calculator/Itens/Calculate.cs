namespace UnitTexting.CalculateYield
{
    public static class Calculate
    {
        // this method calculates the growth rate in 1 year
        public static decimal[] CalculatesRateInTwelveMonths(decimal Rate)
        {
            return Enumerable.Range(1, 12).
                Select(
                    i => Decimal.Round(Rate * i, 2)
                ).ToArray();
        }


        // this method calculates Simple Interest
        public static decimal CalculatesSimpleInterest(decimal CashValue, decimal Rate, sbyte t)
        {
            return CashValue * Rate * t;
        }


        // this method calculates compound interest
        public static decimal CalculatesCompoundInterest(decimal CashValue, decimal Rate, sbyte t)
        {
            decimal M = Decimal.Round( CashValue * (decimal)Math.Pow((double)(1 + Rate), t), 2 );
            return M - CashValue;
        }
    }
}
