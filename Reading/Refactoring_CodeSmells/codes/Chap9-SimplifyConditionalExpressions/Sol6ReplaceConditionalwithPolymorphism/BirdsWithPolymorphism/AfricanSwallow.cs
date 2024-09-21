namespace SimplifyConditionalExpressions.Sol6ReplaceConditionalWithPolymorphism.BirdsWithPolymorphism
{
    internal class AfricanSwallow : Bird
    {
        protected override double GetFlySpeed(int numberOfCoconuts)
        {
            return 40 - 2 * numberOfCoconuts;
        }
    }
}