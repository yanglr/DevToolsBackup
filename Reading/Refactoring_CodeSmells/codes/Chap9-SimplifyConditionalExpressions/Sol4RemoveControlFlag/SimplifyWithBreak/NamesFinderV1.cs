﻿namespace SimplifyConditionalExpressions.Sol4RemoveControlFlag.SimplifyWithBreak
{
    internal class NamesFinderV1
    {
        // To find two suspicious names, stop at once when one of them found.
        internal void CheckSecurity(string[] people)
        {
            bool found = false;
            for (int i = 0; i < people.Length; i++)
            {
                if (!found)
                {
                    if (people[i].Equals("Don"))
                    {
                        SendAlert();
                        found = true;
                    }
                    if (people[i].Equals("John"))
                    {
                        SendAlert();
                        found = true;
                    }
                }
            }
        }
            
        private void SendAlert()
        {
            Console.WriteLine("The objective name is found.");
        }
    }
}