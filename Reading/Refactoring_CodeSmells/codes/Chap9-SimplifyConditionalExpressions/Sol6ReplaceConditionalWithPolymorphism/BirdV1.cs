namespace SimplifyConditionalExpressions.Sol6ReplaceConditionalWithPolymorphism
{
    internal abstract class Bird
    {
        public BirdType Type { get; set; }

        public bool IsNailed { get; set; }

        public int Voltage { get; set; }

        protected abstract double GetFlySpeed(int numberOfCoconuts);
    }
}
