namespace Azure.Cosmos.Timeseries.Core.Models.Tub
{
    public class Tub : BaseContainerModel
    {
        public string SensorId { get; set; }
        public string Type { get; set; }
        public double[] MeasuredAts { get; set; }
        public double[] Measurements { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
