namespace SimplifyConditionalExpressions.Sol6ReplaceConditionalwithPolymorphism.BirdsWithPolymorphism
{
    internal class AfricanSwallow : Bird
    {
        public override double GetFlySpeed(int numberOfCoconuts)
        {
            return 40 - 2 * numberOfCoconuts;
        }
    }
}