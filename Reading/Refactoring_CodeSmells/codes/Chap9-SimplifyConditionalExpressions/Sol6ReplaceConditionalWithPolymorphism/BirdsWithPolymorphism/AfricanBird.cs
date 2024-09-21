namespace SimplifyConditionalExpressions.Sol6ReplaceConditionalWithPolymorphism.BirdsWithPolymorphism
{
    internal class AfricanBird : Bird
    {
        public override double GetFlySpeed(int numberOfCoconuts)
        {
            return 40 - 2 * numberOfCoconuts;
        }
    }
}