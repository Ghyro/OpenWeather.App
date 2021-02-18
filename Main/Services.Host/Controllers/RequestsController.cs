using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Services.Host.Controllers
{
    using Core;

    [Route("Services/[controller]")]
    [ApiController]
    public class RequestsController : ControllerBase
    {
        [HttpPost]
        public Task<ActionResult<ProcessResponse>> Process(ProcessRequest request)
        {
            throw new NotImplementedException();
        }
    }
}