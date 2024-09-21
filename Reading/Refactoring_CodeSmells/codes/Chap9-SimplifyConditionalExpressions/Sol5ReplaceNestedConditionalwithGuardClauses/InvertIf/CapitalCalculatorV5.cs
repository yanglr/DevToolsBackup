namespace SimplifyConditionalExpressions.Sol5ReplaceNestedConditionalwithGuardClauses.InvertIf
{
    internal class CapitalCalculatorV5
    {
        internal double GetAdjustedCapital(FinancialInstrument finInstrument)
        {
            if (finInstrument.Capital <= 0.0)
            {
                return 0;
            }

            if (finInstrument.Rate <= 0.0 || finInstrument.Duration <= 0.0)
            {
                return 0;
            }

            return finInstrument.Income / finInstrument.Duration *
                finInstrument.AdjustmentFactor;
        }
    }
}