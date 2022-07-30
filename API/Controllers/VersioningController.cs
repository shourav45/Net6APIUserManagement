using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace API.Controllers
{

   
    [Authorize]
    [ApiController]
    [Route("api/v{version:apiVersion}/")]
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    public class VersioningController : ControllerBase
    {
        private readonly UserService service;

        public VersioningController()
        {
            this.service = new UserService();
        }
        [MapToApiVersion("1.0")]
        [HttpGet]
        [Route("get/data")]
        public async Task<IActionResult> GetDatav1(string refcode)
        {
            try
            {
                return getResponse("Response From API v1");
            }
            catch (Exception ex) { return getResponse(ex); }
        }

        [MapToApiVersion("2.0")]
        [HttpGet]
        [Route("get/data")]
        public async Task<IActionResult> GetDatav2(string refcode)
        {
            try
            {
                return getResponse("Response From API v2");
            }
            catch (Exception ex) { return getResponse(ex); }
        }

       
    }
}
