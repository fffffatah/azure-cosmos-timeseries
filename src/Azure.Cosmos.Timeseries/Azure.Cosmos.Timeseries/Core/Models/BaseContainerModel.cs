namespace Azure.Cosmos.Timeseries.Core.Models
{
    public class BaseContainerModel
    {
        public string Id { get; set; }
        public string PartitionKey { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
