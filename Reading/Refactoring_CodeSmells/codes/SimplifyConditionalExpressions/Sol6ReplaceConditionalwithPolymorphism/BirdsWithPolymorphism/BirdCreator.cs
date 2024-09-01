namespace SimplifyConditionalExpressions.Sol6ReplaceConditionalwithPolymorphism.BirdsWithPolymorphism
{
    internal class BirdCreator
    {
        internal static Bird Create(BirdType type)
        {
            switch (type)
            {
                case BirdType.European:
                    return new EuropeanSwallow();

                case BirdType.African:
                    return new AfricanSwallow();

                case BirdType.NorwegianBlue:
                    return new NorwegianBlueParrot();

                default:
                    throw new InvalidOperationException("Not supported type.");
            }
        }
    }
}