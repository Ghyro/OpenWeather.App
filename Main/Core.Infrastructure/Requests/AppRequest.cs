namespace Core
{
    public abstract class AppRequest : IHasId
    {
        public string Id { get; set; }
    }
}
