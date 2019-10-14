using Microsoft.AspNetCore.Mvc;

namespace MasterClass.WebApi.Controllers
{
    [Route("api/_system")]
    public class DiagnosticController  : ControllerBase
    {
        [Route("healthcheck"), HttpGet, HttpHead]
        public IActionResult HealthCheck() => Ok("system_ok");
    }
}
