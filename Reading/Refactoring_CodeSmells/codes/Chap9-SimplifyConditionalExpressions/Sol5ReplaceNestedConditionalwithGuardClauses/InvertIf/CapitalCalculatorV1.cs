namespace SimplifyConditionalExpressions.Sol5ReplaceNestedConditionalWithGuardClauses.InvertIf
{
    internal class CapitalCalculatorV1
    {
        internal double GetAdjustedCapital(FinancialInstrument finInstrument)
        {
            double result = 0.0;
            if (finInstrument.Capital > 0.0)
            {
                if (finInstrument.Duration > 0.0)
                {
                    if (finInstrument.Rate > 0.0)
                    {
                        result = finInstrument.Income / finInstrument.Duration *
                                 finInstrument.AdjustmentFactor;
                    }
                    else
                    {
                        result = - finInstrument.Income * finInstrument.AdjustmentFactor;
                    }
                }
            }

            return result;
        }
    }
}