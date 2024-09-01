namespace SimplifyConditionalExpressions.Sol4RemoveControlFlag.SimplifyWithBreak
{
    internal class NamesFinderV4
    {
        // To find two suspicious names, stop at once when one of them found.
        internal void CheckSecurity(string[] people)
        {
            for (int i = 0; i < people.Length; i++)
            {
                if (people[i].Equals("Don"))
                {
                    SendAlert();
                    break;
                }
                if (people[i].Equals("John"))
                {
                    SendAlert();
                    break;
                }
            }
        }

        private void SendAlert()
        {
            Console.WriteLine("The objective name is found.");
        }
    }
}