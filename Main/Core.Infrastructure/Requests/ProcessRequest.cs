using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Core
{
    [DataContract]
    public sealed class ProcessRequest : AppRequest
    {
        [DataMember(Name = "Requests", EmitDefaultValue = false)]
        public List<AppRequest> Requests { get; set; }
    }
}
