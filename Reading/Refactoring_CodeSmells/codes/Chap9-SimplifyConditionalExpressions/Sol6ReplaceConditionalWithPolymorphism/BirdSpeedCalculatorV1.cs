namespace SimplifyConditionalExpressions.Sol6ReplaceConditionalWithPolymorphism
{
    internal class BirdSpeedCalculator
    {
        internal double GetFlySpeed(Bird bird, int numberOfCoconuts)
        {
            switch (bird.Type)
            {
                case BirdType.EuropeanSwallow:
                    return 35;

                case BirdType.AfricanBird:
                    return 40 - 2 * numberOfCoconuts;

                case BirdType.NorwegianBlueParrot:
                    return bird.IsNailed ? 0 : 10 + bird.Voltage / 10;
            }

            throw new InvalidOperationException("Should be unreachable");
        }
    }

}