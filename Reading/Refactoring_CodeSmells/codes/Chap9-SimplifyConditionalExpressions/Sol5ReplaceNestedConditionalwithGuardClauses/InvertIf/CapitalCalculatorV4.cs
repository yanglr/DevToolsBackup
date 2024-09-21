﻿namespace SimplifyConditionalExpressions.Sol5ReplaceNestedConditionalwithGuardClauses.InvertIf
{
    internal class CapitalCalculatorV4
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