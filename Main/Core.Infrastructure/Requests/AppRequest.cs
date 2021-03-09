using System.Runtime.Serialization;


namespace Core
{
    [DataContract(Name="AppReq")]
    public abstract class AppRequest : IHasId
    {
        [DataMember(Name = "Id")]
        public string Id { get; set; }

        [DataMember(Name = "InstanceId")]
        public string InstanceId { get; set; }
    }
}
