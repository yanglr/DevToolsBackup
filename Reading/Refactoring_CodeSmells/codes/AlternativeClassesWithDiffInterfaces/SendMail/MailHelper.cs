namespace AlternativeClassesWithDiffInterfaces.SendMail
{
    internal class MailHelper
    {
        public void SendMail(string to, string subject, string body)
        {
            Console.WriteLine($"Sending email to {to} with subject '{subject}' and body '{body}'.");
        }

        public void ReceiveMail(string from, string subject, string body)
        {
            Console.WriteLine($"Receive email from {from} with subject '{subject}' and body '{body}'.");
        }
    }
}

