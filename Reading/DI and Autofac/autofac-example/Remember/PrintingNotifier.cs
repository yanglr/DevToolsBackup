using System.IO;

namespace Remember
{
    class PrintingNotifier : IMemoDueNotifier
    {
        readonly TextWriter _writer;

        public PrintingNotifier(TextWriter writer)
        {
            _writer = writer;
        }

        public void MemoIsDue(Memo memo)
        {
            _writer.WriteLine("Memo '{0}' is due!", memo.Title);
        }
    }
}
