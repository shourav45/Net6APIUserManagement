using DataAccess.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace API.Controllers
{
    [Authorize]
    [Route("api/")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        public readonly ProfileService service;
        public ProfileController()
        {
            service = new ProfileService();
        }

        [HttpPost]
        [Route("profile/bank/info")]
        public async Task<IActionResult> AddUpdateBankingInfo(BankingInfoDTO data)
        {
            try
            {
                return getResponse(await service.AddUpdateBankingInfo(data));
            }
            catch (Exception ex) { return getResponse(ex); }
        }
        [HttpPost]
        [Route("profile/contact/info")]
        public async Task<IActionResult> AddUpdateContactInfo(ContactInfoDTO data)
        {
            try
            {
                return getResponse(await service.AddUpdateContactInfo(data));
            }
            catch (Exception ex) { return getResponse(ex); }
        }
        [HttpPost]
        [Route("profile/note/info")]
        public async Task<IActionResult> AddUpdateNoteInfo(NoteInfoDTO data)
        {
            try
            {
                return getResponse(await service.AddUpdateNoteInfo(data));
            }
            catch (Exception ex) { return getResponse(ex); }
        }
        [HttpPost]
        [Route("profile/certification/info")]
        public async Task<IActionResult> AddUpdateCertificationInfo(CertificationInfoDTO data)
        {
            try
            {
                return getResponse(await service.AddUpdateCertificationInfo(data));
            }
            catch (Exception ex) { return getResponse(ex); }
        }
        [HttpPost]
        [Route("profile/educational/info")]
        public async Task<IActionResult> AddUpdateEducationalInfo(EducationalInfoDTO data)
        {
            try
            {
                return getResponse(await service.AddUpdateEducationalInfo(data));
            }
            catch (Exception ex) { return getResponse(ex); }
        }

        [HttpPost]
        [Route("profile/employement/info")]
        public async Task<IActionResult> AddUpdateEmployementInfo(EmployementInfoDTO data)
        {
            try
            {
                return getResponse(await service.AddUpdateEmployementInfo(data));
            }
            catch (Exception ex) { return getResponse(ex); }
        }

    }
}
