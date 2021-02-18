namespace Core.Infrastructure
{
    public class Alert : IHasId
    {
        public string Id { get; set; }

        public string _Message { get; set; }
    }
}
