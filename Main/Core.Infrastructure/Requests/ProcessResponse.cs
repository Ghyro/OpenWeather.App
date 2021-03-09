using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Core
{
    [DataContract]
    public sealed class ProcessResponse : AppResponse
    {
        [DataMember(Name = "Responses")]
        public List<AppResponse> Responses { get; set; }
    }
}
