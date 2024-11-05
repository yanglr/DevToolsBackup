namespace Tip4.InlineClass.Optimize
{
    internal class Shipment
    {
        private string _shippingCompany;
        private string _trackingNumber;

        public string TrackingInfo
        {
            get { return $"{ShippingCompany}: {TrackingNumber}"; }
        }

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
    }
}