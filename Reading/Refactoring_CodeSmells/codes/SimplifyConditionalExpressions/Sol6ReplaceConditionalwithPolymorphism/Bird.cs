namespace SimplifyConditionalExpressions.Sol6ReplaceConditionalwithPolymorphism
{
    internal abstract class Bird
    {
        public BirdType Type { get; set; }

        public bool IsNailed { get; set; }

        public int Voltage { get; set; }

        public abstract double GetFlySpeed(int numberOfCoconuts);
    }
}