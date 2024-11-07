namespace Tip4.InlineClass
{
    internal class Shipment
    {
        public TrackingInformation TrackingInformation { get; set; }

        public string GetTrackingInfo() => TrackingInformation.Display();
    }
}