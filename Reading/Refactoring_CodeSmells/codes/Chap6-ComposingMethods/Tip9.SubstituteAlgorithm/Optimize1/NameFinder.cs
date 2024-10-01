namespace Tip9.SubstituteAlgorithm.Optimize1
{
    internal class NameFinder
    {
        public string FindPerson(string[] people)
        {
            var candidates = new List<string> { "Don", "John", "Kent" };
            foreach (var person in people)
            {
                if (candidates.Contains(person))
                {
                    return person;
                }
            }
            return string.Empty;
        }
    }
}