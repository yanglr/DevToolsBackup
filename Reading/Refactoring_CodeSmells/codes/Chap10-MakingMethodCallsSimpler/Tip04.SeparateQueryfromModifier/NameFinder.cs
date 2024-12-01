namespace Tip04.SeparateQueryfromModifier
{
    internal class NameFinder
    {
        public void CheckSecurity(string[] people)
        {
            string foundName = FindMiscreant(people);
            FurtherProcess(foundName);
        }

        internal string FindMiscreant(string[] people)
        {
            for (int i = 0; i < people.Length; i++)
            {
                if (people[i].Equals("Don"))
                {
                    SendAlert();
                    return "Don";
                }

                if (people[i].Equals("John"))
                {
                    SendAlert();
                    return "John";
                }
            }

            return string.Empty;
        }

        private void SendAlert()
        {
            Console.WriteLine("The miscreant is found.");
        }

        private void FurtherProcess(string foundName)
        {
            Console.WriteLine($"Then length of {foundName} is: {foundName.Length}");
        }
    }
}