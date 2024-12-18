﻿namespace SimplifyConditionalExpressions.Sol5ReplaceNestedConditionalWithGuardClauses.InvertIf
{
    // Financial product
    internal class FinancialInstrument
    {
        private double _capital;

        private double _rate;

        private double _adjustmentFactor; // > 0

        private int _duration; // days

        private double _income;

        public double Capital
        {
            get { return _capital; }
            set { _capital = value; }
        }

        public double Rate
        {
            get { return _rate; }
            set { _rate = value; }
        }

        public int Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }

        public double Income
        {
            get { return _income; }
            set { _income = value; }
        }

        public double AdjustmentFactor
        {
            get { return _adjustmentFactor; }
            set { _adjustmentFactor = value; }
        }
    }
}