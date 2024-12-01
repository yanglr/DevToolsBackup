namespace Tip04.SeparateQueryfromModifier.Step4
{
    internal class NameFinder
    {
        public void CheckSecurity(string[] people)
        {
            AlertForMiscreant(people);
            string foundName = FoundPerson(people);
            FurtherProcess(foundName);
        }

        internal void AlertForMiscreant(string[] people)
        {
            if (!string.IsNullOrEmpty(FoundPerson(people)))
            {
                SendAlert();
            };
        }

        private string FoundPerson(string[] people)
        {
            for (int i = 0; i < people.Length; i++)
            {
                string name = people[i];
                if (people[i].Equals("Don") || people[i].Equals("John"))
                {
                    return name;
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