namespace SimplifyConditionalExpressions.Sol6ReplaceConditionalwithPolymorphism
{
    internal class BirdSpeedCalulatorV1
    {
        internal double GetFlySpeed(Bird bird, int numberOfCoconuts)
        {
            switch (bird.Type)
            {
                case BirdType.European:
                    return 35;

                case BirdType.African:
                    return 40 - 2 * numberOfCoconuts;

                case BirdType.NorwegianBlue:
                    return bird.IsNailed ? 0 : 10 + bird.Voltage / 10;
            }

            throw new InvalidOperationException("Should be unreachable");
        }
    }
}