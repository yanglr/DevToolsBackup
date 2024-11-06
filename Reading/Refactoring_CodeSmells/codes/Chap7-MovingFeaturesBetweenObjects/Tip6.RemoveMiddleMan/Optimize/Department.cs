namespace Tip6.RemoveMiddleMan.Optimize
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