namespace SimplifyConditionalExpressions.Sol6ReplaceConditionalWithPolymorphism.BirdsWithPolymorphism
{
    internal class NorwegianBlueParrot : Bird
    {
        protected override double GetFlySpeed(int numberOfCoconuts)
        {
            return IsNailed ? 0 : 10 + Voltage / 10;
        }
    }
}