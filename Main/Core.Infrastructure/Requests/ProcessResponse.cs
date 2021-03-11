using System.Collections.Generic;


namespace Core
{
    public sealed class ProcessResponse : AppResponse
    {
        public List<AppResponse> Responses { get; set; }
    }
}
