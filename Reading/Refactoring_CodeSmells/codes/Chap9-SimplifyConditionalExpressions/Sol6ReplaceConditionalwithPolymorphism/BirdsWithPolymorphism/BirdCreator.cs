namespace SimplifyConditionalExpressions.Sol6ReplaceConditionalWithPolymorphism.BirdsWithPolymorphism
{
    internal class BirdCreator
    {
        internal static Bird Create(BirdType type)
        {
            switch (type)
            {
                case BirdType.EuropeanSwallow:
                    return new EuropeanSwallow();

                case BirdType.AfricanBird:
                    return new AfricanSwallow();

                case BirdType.NorwegianBlueParrot:
                    return new NorwegianBlueParrot();

                default:
                    throw new InvalidOperationException("Not supported type.");
            }
        }
    }
}