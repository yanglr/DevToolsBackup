using SimplifyConditionalExpressions.Sol6ReplaceConditionalWithPolymorphism.BirdsWithStrategy.Interfaces;

namespace SimplifyConditionalExpressions.Sol6ReplaceConditionalWithPolymorphism.BirdsWithStrategy.Strategies
{
    internal class EuropeanBirdSpeedStrategy : IFlySpeedStrategy
    {
        public double GetFlySpeed(Bird bird, int numberOfCoconuts)
        {
            return 35;
        }
    }
}
