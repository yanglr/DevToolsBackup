namespace SimplifyConditionalExpressions.Sol5ReplaceNestedConditionalWithGuardClauses.InvertIf
{
    internal class CapitalCalculator
    {
        internal double GetAdjustedCapital(FinancialInstrument finInstrument)
        {
            if (finInstrument.Capital <= 0.0 || finInstrument.Duration <= 0.0) return 0;
            return finInstrument.Rate > 0.0
                ? finInstrument.Income / finInstrument.Duration *
                  finInstrument.AdjustmentFactor
                : -finInstrument.Income * finInstrument.AdjustmentFactor;
        }
    }
}