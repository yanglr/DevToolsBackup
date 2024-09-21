namespace SimplifyConditionalExpressions.Sol4RemoveControlFlag.SimplifyWithReturn
{
    internal class NamesPickerV2
    {
        // To find two suspicious names, stop at once when one of them found.
        internal void CheckSecurity(string[] people)
        {
            string foundName = FoundName(people);
            FurtherProcess(foundName);
        }

        private string FoundName(string[] people)
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
                    if (people[i].Equals("John"))
                    {
                        SendAlert();
                        foundName = "John";
                    }
                }
            }

            return foundName;
        }

        private void SendAlert()
        {
            Console.WriteLine("The objective name is found.");
        }

        private void FurtherProcess(string foundName)
        {
            throw new NotImplementedException();
        }
    }
}