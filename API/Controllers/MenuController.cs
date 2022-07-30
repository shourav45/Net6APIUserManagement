using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace API.Controllers
{
    [Authorize]
    [Route("api/")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly MenuService service;
        public MenuController()
        {
            service = new MenuService();
        }


        [HttpGet]
        [Route("menu/get/list")]
        public async Task<IActionResult> GetMenuList()
        {
            try
            {
                return getResponse(await service.GetMenuList());
            }
            catch (Exception ex) { return getResponse(ex); }
        }

        [HttpGet]
        [Route("menu/get/list/by/user/id/{id}")]
        public async Task<IActionResult> GetMenuListByUserID(int id)
        {
            try
            {
                return getResponse(await service.GetMenuListByUserID(id));
            }
            catch (Exception ex) { return getResponse(ex); }
        }

    }
}
