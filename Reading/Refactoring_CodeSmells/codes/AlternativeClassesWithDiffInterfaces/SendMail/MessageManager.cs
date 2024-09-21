namespace AlternativeClassesWithDiffInterfaces.SendMail
{
    internal class MessageManager
    {
        public void DispatchMessage(string body, string recipient, string title)
        {
            Console.WriteLine($"Sending message to {recipient} with title '{title}' and body '{body}'.");
        }

        public void ReceiveMessage(string body, string title, string sender)
        {
            Console.WriteLine($"Receive message from {sender} with title '{title}' and body '{body}'.");
        }
    }
}

