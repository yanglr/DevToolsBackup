namespace SimplifyConditionalExpressions.Sol3
{
    internal class Product
    {
        private double _price;

        private bool _isSpecialDeal;

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

        public Product(double price, bool isSpecialDeal)
        {
            _price = price;
            _isSpecialDeal = isSpecialDeal;
        }
    }
}