namespace SimplifyConditionalExpressions.Sol3ConsolidateDuplicateConditionalFragments
{
    internal class Product
    {
        private string _name;
        
        private double _price;

        private bool _isSpecialDeal;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public bool IsSpecialDeal
        {
            get { return _isSpecialDeal; }
            set { _isSpecialDeal = value; }
        }

        public Product(string name, double price, bool isSpecialDeal)
        {
            _name = name;
            _price = price;
            _isSpecialDeal = isSpecialDeal;
        }
    }
}