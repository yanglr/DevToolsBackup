namespace Tip04.SeparateQueryfromModifier.Step2
{
    internal class NameFinder
    {
        public void CheckSecurity(string[] people)
        {
            FindMiscreant(people);
            string foundName = FoundPerson(people);
            FurtherProcess(foundName);
        }

        internal void FindMiscreant(string[] people)
        {
            for (int i = 0; i < people.Length; i++)
            {
                if (people[i].Equals("Don"))
                {
                    SendAlert();
                    return;
                }

                if (people[i].Equals("John"))
                {
                    SendAlert();
                    return;
                }
            }

            return;
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