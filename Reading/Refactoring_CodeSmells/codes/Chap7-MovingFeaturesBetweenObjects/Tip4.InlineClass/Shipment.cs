namespace Tip4.InlineClass
{
    internal class Shipment
    {
        private TrackingInformation _trackingInformation;

        public TrackingInformation TrackingInformation
        {
            get { return _trackingInformation; }
            set { _trackingInformation = value; }
        }

        public string ShippingCompany
        {
            get { return _trackingInformation.ShippingCompany; }
            set { _trackingInformation.ShippingCompany = value; }
        }

        public string TrackingNumber
        {
            get { return _trackingInformation.TrackingNumber; }
            set { _trackingInformation.TrackingNumber = value; }
        }
    }
}