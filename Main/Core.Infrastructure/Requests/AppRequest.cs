namespace Core
{
    public class AppRequest : IHasId
    {
        public string Id { get; set; }
    
        public string InstanceId { get; set; }
    
        public ActionType ActionType { get; set; }
    
        public RequestType RequestType { get; set; }
    }
}
