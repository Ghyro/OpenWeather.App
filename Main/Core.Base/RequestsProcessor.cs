using System.Threading.Tasks;


namespace Core
{
    public sealed class RequestsProcessor
    {
        private readonly HandlerBuilder HandlerBuilder;

        public RequestsProcessor()
        {
            if (HandlerBuilder == null)
                HandlerBuilder = new HandlerBuilder();
        }

        public async Task<ProcessResponse> ProcessAsync(ProcessRequest processRequest, ProcessResponse processResponse)
            => await Task.Factory.StartNew(() => Process(processRequest, processResponse));

        private ProcessResponse Process(ProcessRequest processRequest, ProcessResponse processResponse)
        {
            // Add Validate

            HandlerBuilder.DoHandle(processRequest, processResponse);

            return processResponse;
        }
    }
}
