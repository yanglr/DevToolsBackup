namespace Tip5.HideDelegate.Optimize
{
    internal class Department
    {
        private readonly string _manager;
		
        public Department(string manager) // pass parameter using ctor
        {
            _manager = manager;
        }

        internal string GetManager()
        {
            return _manager;
        }
    }
}

