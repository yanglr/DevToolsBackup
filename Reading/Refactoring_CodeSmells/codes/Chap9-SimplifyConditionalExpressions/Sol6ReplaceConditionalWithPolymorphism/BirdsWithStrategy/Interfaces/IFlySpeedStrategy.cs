namespace SimplifyConditionalExpressions.Sol6ReplaceConditionalWithPolymorphism.BirdsWithStrategy.Interfaces
{
    internal interface IFlySpeedStrategy
    {
        double GetFlySpeed(Bird bird, int numberOfCoconuts);
    }
}