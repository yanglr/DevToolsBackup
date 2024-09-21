namespace SimplifyConditionalExpressions.Sol6ReplaceConditionalWithPolymorphism.BirdsWithPolymorphism
{
    internal abstract class Bird
    {

        public bool IsNailed { get; set; }

        public int Voltage { get; set; }

        protected abstract double GetFlySpeed(int numberOfCoconuts);
    }
}
