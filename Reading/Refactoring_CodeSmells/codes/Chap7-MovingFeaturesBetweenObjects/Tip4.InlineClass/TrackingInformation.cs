namespace Tip4.InlineClass
{
    internal class TrackingInformation
    {
        public string ShippingCompany { get; set; }

        public string TrackingNumber { get; set; }

        public string Display() => $"{ShippingCompany}: {TrackingNumber}";
    }
}