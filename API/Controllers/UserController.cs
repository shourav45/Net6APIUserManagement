using DataAccess.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace API.Controllers
{
    [Route("api/")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService service;
        public UserController()
        {
            service = new UserService();
        }

        [HttpGet]
        [Route("user/email/is/exist")]
        public async Task<IActionResult> CheckEmailAddressIsExist(string email)
        {
            try
            {
                return getResponse(await service.CheckEmailAddressIsExist(email));
            }
            catch (Exception ex) { return getResponse(ex); }
        }

        [HttpGet]
        [Route("user/mobile/is/exist")]
        public async Task<IActionResult> CheckMobileNoIsExist(string mobilno)
        {
            try
            {
                return getResponse(await service.CheckMobileNoIsExist(mobilno));
            }
            catch (Exception ex) { return getResponse(ex); }
        }

        [HttpGet]
        [Route("get/user/role/list")]
        public async Task<IActionResult> GetUserRoleList()
        {
            try
            {
                return getResponse(await service.GetUserRoleList());
            }
            catch (Exception ex) { return getResponse(ex); }
        }

        [HttpPost]
        [Route("user/sign/up")]
        public async Task<IActionResult> UserSignUp(ProfileCreateDTO profiledata)
        {
            try
            {
                return getResponse(await service.UserSignUp(profiledata));
            }
            catch (Exception ex) { return getResponse(ex); }
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("user/login/token/refresh")]
        public async Task<IActionResult> UserLoginTokenRefresh()
        {
            try
            {
                return getResponse(await service.UserLoginTokenRefresh(Request.Headers["Authorization"].ToString()));
            }
            catch (Exception ex) { return getResponse(ex); }
        }
        
        [HttpPost]
        [Route("user/login/token")]
        public async Task<IActionResult> UserLoginToken(UserLoginDTO user)
        {
            try
            {
                return getResponse(await service.UserLoginToken(user));
            }
            catch (Exception ex) { return getResponse(ex); }
        }

        //[HttpPost]
        //[Route("user/account/create")]
        //public async Task<IActionResult> CreateUserAccount(UserAccountCreateDTO user)
        //{
        //    try
        //    {
        //        return getResponse(await service.CreateUserAccount(user));
        //    }
        //    catch (Exception ex) { return getResponse(ex); }
        //}

        [HttpPost]
        [Route("user/password/reset")]
        public async Task<IActionResult> ResetUserPassword(UserAccountDTO user)
        {
            try
            {
                return getResponse(await service.ResetUserPassword(user));
            }
            catch (Exception ex) { return getResponse(ex); }
        }

    }
}
