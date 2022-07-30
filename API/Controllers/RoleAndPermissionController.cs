using DataAccess.DTOs;
using DataAccess.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace API.Controllers
{
    [Route("api/")]
    [ApiController]
    public class RoleAndPermissionController : ControllerBase
    {
        private readonly RoleAndPermissionService service;

        public RoleAndPermissionController()
        {
            service = new RoleAndPermissionService();
        }

        [HttpPost]
        [Route("permission")]
        public async Task<IActionResult> AddUpdatePermission(Permission data)
        {
            try
            {
                return getResponse(await service.AddUpdatePermission(data));
            }
            catch (Exception ex) { return getResponse(ex); }
        }

        [HttpPost]
        [Route("role")]
        public async Task<IActionResult> AddUpdateRole(RoleDTO data)
        {
            try
            {
                return getResponse(await service.AddUpdateRole(data));
            }
            catch (Exception ex) { return getResponse(ex); }
        }

        [HttpPost]
        [Route("role/permission")]
        public async Task<IActionResult> AddUpdateRolePermission(RolePermission data)
        {
            try
            {
                return getResponse(await service.AddUpdateRolePermission(data));
            }
            catch (Exception ex) { return getResponse(ex); }
        }

        [HttpPost]
        [Route("user/permission")]
        public async Task<IActionResult> AddUpdateUserPermission(UserPermission data)
        {
            try
            {
                return getResponse(await service.AddUpdateUserPermission(data));
            }
            catch (Exception ex) { return getResponse(ex); }
        }
    }
}
