namespace SimplifyConditionalExpressions.Sol4RemoveControlFlag.SimplifyWithReturn
{
    internal class NamesPickerV1
    {
        internal void CheckSecurity(string[] people)
        {
            string foundName = "";
            for (int i = 0; i < people.Length; i++)
            {
                if (foundName.Equals(""))
                {
                    if (people[i].Equals("Don"))
                    {
                        SendAlert();
                        foundName = "Don";
                    }
                    else if (people[i].Equals("John"))
                    {
                        SendAlert();
                        foundName = "John";
                    }
                }
            }

            FurtherProcess(foundName);
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