using SimplifyConditionalExpressions.Sol6ReplaceConditionalWithPolymorphism.BirdsWithStrategy.Interfaces;

namespace SimplifyConditionalExpressions.Sol6ReplaceConditionalWithPolymorphism.BirdsWithStrategy
{
    internal class Bird
    {
        private readonly IFlySpeedStrategy _flySpeedStrategy;
        public bool IsNailed { get; set; }

        public int Voltage { get; set; }

        public Bird(IFlySpeedStrategy flySpeedStrategy)
        {
            _flySpeedStrategy = flySpeedStrategy;
        }

        public double GetFlySpeed(int numberOfCoconuts)
        {
            return _flySpeedStrategy.GetFlySpeed(this, numberOfCoconuts);
        }
    }
}