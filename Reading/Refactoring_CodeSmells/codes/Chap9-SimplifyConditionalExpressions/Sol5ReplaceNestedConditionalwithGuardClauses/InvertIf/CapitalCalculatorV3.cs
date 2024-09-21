﻿namespace SimplifyConditionalExpressions.Sol5ReplaceNestedConditionalWithGuardClauses.InvertIf
{
    internal class CapitalCalculatorV3
    {
        internal double GetAdjustedCapital(FinancialInstrument finInstrument)
        {
            double result = 0.0;
            if (finInstrument.Capital <= 0.0)
            {
                return result;
            }

            if (finInstrument.Rate <= 0.0 || finInstrument.Duration <= 0.0)
            {
                return result;
            }

            result = finInstrument.Income / finInstrument.Duration *
                finInstrument.AdjustmentFactor;

            return result;
        }
    }
}