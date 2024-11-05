namespace Tip4.InlineClass
{
    internal class TrackingInformation
    {
        private string _shippingCompany;
        private string _trackingNumber;

        public string ShippingCompany
        {
            get { return _shippingCompany; }
            set { _shippingCompany = value; }
        }

        public string TrackingNumber
        {
            get { return _trackingNumber; }
            set { _trackingNumber = value; }
        }

        public string Display()
        {
            return $"{ShippingCompany}: {TrackingNumber}";
        }
    }
}