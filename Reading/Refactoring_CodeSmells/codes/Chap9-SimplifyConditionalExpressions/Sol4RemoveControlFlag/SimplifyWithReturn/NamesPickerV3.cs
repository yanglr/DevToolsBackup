namespace SimplifyConditionalExpressions.Sol4RemoveControlFlag.SimplifyWithReturn
{
    internal class NamesPickerV3
    {
        internal void CheckSecurity(string[] people)
        {
            string foundName = FindName(people);
            FurtherProcess(foundName);
        }

        private string FindName(string[] people)
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

            return "";
        }

        private void SendAlert()
        {
            Console.WriteLine("The objective name is found.");
        }

        private void FurtherProcess(string foundName)
        {
            Console.WriteLine($"Then length of {foundName} is: {foundName.Length}");
        }
    }
}