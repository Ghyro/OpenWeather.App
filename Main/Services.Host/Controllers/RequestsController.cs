using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace Services.Host.Controllers
{
    using Core;

    [Route("Services/[controller]")]
    [ApiController]
    public class RequestsController : ControllerBase
    {
        private readonly RequestsProcessor Processor;

        public RequestsController()
        {
            if (Processor == null)
                Processor = new RequestsProcessor();
        }

        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Test Requests Controller";
        }

        [HttpPost]
        public async Task<ActionResult<ProcessResponse>> Process(ProcessRequest request)
        {
            if (request == null)
                return BadRequest();

            ProcessResponse processResponse = null;

            await Processor.ProcessAsync(request, processResponse);

            return Ok(processResponse);
        }
    }
}