using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace Services.Host.Controllers
{
    using Core;

    [Route("Services/[controller]")]
    [ApiController]
    public class RequestsController : ControllerBase
    {
        private readonly RequestsProcessor _processor;

        public RequestsController()
        {
            if (_processor == null)
                _processor = new RequestsProcessor();
        } 

        [HttpPost]
        public async Task<ActionResult<ProcessResponse>> Process(ProcessRequest request)
        {
            if (request == null)
                return BadRequest();

            var processResponse = new ProcessResponse();

            await _processor.ProcessAsync(request, processResponse);

            return Ok(processResponse);
        }
    }
}
