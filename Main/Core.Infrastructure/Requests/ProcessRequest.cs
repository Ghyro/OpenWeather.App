using System.Collections.Generic;

namespace Core
{
    public sealed class ProcessRequest : AppRequest
    {
        public List<AppRequest> Requests { get; set; }
    }
}
