namespace Tip5.HideDelegate
{
    internal class Department
    {
        private string _manager;

        public Department(string manager)
        {
            _manager = manager;
        }

        internal string GetManager()
        {
            return _manager;
        }
    }
}