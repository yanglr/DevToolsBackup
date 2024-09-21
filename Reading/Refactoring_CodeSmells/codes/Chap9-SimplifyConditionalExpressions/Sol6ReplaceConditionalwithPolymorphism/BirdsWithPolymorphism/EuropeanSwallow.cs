namespace SimplifyConditionalExpressions.Sol6ReplaceConditionalWithPolymorphism.BirdsWithPolymorphism
{
    internal class EuropeanSwallow : Bird
    {
        protected override double GetFlySpeed(int numberOfCoconuts)
        {
            return 35;
        }
    }
}