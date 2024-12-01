namespace Tip04.SeparateQueryfromModifier.Step1
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
                    return FoundPerson(people);
                }

                if (people[i].Equals("John"))
                {
                    SendAlert();
                    return FoundPerson(people);
                }
            }

            return string.Empty;
        }

        private string FoundPerson(string[] people)
        {
            for (int i = 0; i < people.Length; i++)
            {
                if (people[i].Equals("Don"))
                {
                    return "Don";
                }

                if (people[i].Equals("John"))
                {
                    return "John";
                }
            }
            return "";
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