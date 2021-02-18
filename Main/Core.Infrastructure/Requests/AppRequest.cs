namespace Core
{
    public abstract class AppRequest : IHasId
    {
        public string Id { get; set; }

        public string ActionId { get; set; }
    }
}
