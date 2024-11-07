namespace Tip4.InlineClass.Optimize
{
    internal class Shipment
    {
        public string ShippingCompany { get; set; }

        public string TrackingNumber { get; set; }

        public string GetTrackingInfo() => $"{ShippingCompany}: {TrackingNumber}";
    }
}

