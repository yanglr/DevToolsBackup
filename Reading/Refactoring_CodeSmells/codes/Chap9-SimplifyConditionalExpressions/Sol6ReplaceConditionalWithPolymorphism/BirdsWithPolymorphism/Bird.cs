namespace SimplifyConditionalExpressions.Sol6ReplaceConditionalWithPolymorphism.BirdsWithPolymorphism
{
    internal abstract class Bird
    {
        public bool IsNailed { get; set; }

        public double Voltage { get; set; }

        public abstract double GetFlySpeed(int numberOfCoconuts);
    }
}
