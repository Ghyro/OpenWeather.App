namespace Core
{
    public class Alert : IHasId
    {
        public string Id { get; set; }

        public string Message { get; set; }

        public SeverityType Severity { get; set; }
    }
}
