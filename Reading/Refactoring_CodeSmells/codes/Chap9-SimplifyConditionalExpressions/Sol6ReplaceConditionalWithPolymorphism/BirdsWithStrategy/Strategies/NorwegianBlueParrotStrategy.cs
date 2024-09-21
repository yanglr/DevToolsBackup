using SimplifyConditionalExpressions.Sol6ReplaceConditionalWithPolymorphism.BirdsWithStrategy.Interfaces;

namespace SimplifyConditionalExpressions.Sol6ReplaceConditionalWithPolymorphism.BirdsWithStrategy.Strategies
{
    internal class NorwegianBlueBirdSpeedStrategy : IFlySpeedStrategy
    {
        public double GetFlySpeed(Bird bird, int numberOfCoconuts)
        {
            return bird.IsNailed ? 0 : 10 + bird.Voltage / 10;
        }
    }
}
