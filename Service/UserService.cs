using AutoMapper;
using DataAccess.DTOs;
using DataAccess.Models;
using DataAcess.Repository;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Authentication;
using System.Security.Claims;
using System.Text;
using Utility;
using Profile = DataAccess.Models.Profile;

namespace Service
{
    public class UserService
    {

        public async Task<bool> CheckMobileNoIsExist(string mobileno)
        {
            var UserprofileData = await new GenericRepository<DataAccess.Models.Profile>().FindOne(u => u.MobileNo == mobileno);
            if (UserprofileData != null) return true;
            else return false;
        }
        public async Task<bool> CheckEmailAddressIsExist(string email)
        {
            var UserprofileData = await new GenericRepository<DataAccess.Models.Profile>().FindOne(u => u.EmailAddress == email);
            if (UserprofileData != null) return true;
            else return false;
        }
        public async Task<DataAccess.Models.Profile> UserSignUp(ProfileCreateDTO profiledata)
        {
            DataAccess.Models.Profile UserProfileData = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<ProfileCreateDTO, DataAccess.Models.Profile>())).Map<ProfileCreateDTO, DataAccess.Models.Profile>(profiledata);

            UserProfileData = await new GenericRepository<DataAccess.Models.Profile>().Insert(UserProfileData);

            UserAccount userAccount = new UserAccount
            {
                Id = 0,
                ProfileId = UserProfileData.Id,
                IsDeleted = false,
                RoleId = profiledata.RoleID,
                UserPassword = new Crypto().HashPassword(profiledata.UserPassword),
                UpdatedOn = DateTime.UtcNow,
            };

            await new GenericRepository<UserAccount>().Insert(userAccount);

            return UserProfileData;
        }

        public async Task<List<Role>> GetUserRoleList()
        {
            return await new GenericRepository<Role>().Find(r=>r.RoleName != "Admin" && r.IsDeleted == false);
        }

        public async Task<JWTTokenDTO> UserLoginToken(UserLoginDTO userLoginData)
        {
            JWTTokenDTO TokenObject = new JWTTokenDTO();

            string UserValidationMessage = UserLoginValidation(userLoginData).Result.ToString();
            //IF USER IS NOT VALIDATE
            if (UserValidationMessage != "OK") throw new Exception(UserValidationMessage);
            else // USER IS VALID, CPROVIDE TOKEN
            {
                var profileData = await new GenericRepository<Profile>().FindOne(u => u.EmailAddress == userLoginData.RefString || u.MobileNo ==  userLoginData.RefString);
                var userAccountData = await new GenericRepository<UserAccount>().FindOne(u => u.ProfileId == profileData.Id);
                var userRole = await new GenericRepository<Role>().FindOne(u => u.Id == userAccountData.RoleId);

                //create claims details based on the user information
                var claims = new[] {
                        new Claim(JwtRegisteredClaimNames.Sub,JWTTokenConfigDTO.JwtSubject),
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                        new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                        new Claim("MobileNo", profileData.MobileNo),
                        new Claim("Email", profileData.EmailAddress),
                        new Claim("FullName", profileData.FullName),
                        new Claim("ProfileID", profileData.Id.ToString()),
                        new Claim("RoleID", userAccountData.RoleId.ToString()),
                        new Claim("RoleName",userRole.RoleName),
                        new Claim("UP", userAccountData.UserPassword)
                    };

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JWTTokenConfigDTO.JwtKey));
                var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var token = new JwtSecurityToken(JWTTokenConfigDTO.JwtIssuer, JWTTokenConfigDTO.JwtAudience,claims,
                    expires: DateTime.UtcNow.AddMinutes(60),
                    signingCredentials: signIn);

                TokenObject = new JWTTokenDTO
                {
                    MobileNo = profileData.MobileNo,
                    Email = profileData.EmailAddress,
                    FullName = profileData.FullName,
                    ProfileID = profileData.Id,
                    RoleID = userAccountData.RoleId,
                    RoleName = userRole.RoleName,
                    TokenExpireOn = DateTime.UtcNow.AddMinutes(60),
                    Token = new JwtSecurityTokenHandler().WriteToken(token)
                };
            }

            return TokenObject;
        }

        public async Task<JWTTokenDTO> UserLoginTokenRefresh(string ExpiredToken)
        {
            JWTTokenDTO TokenObject = new JWTTokenDTO();
            if (ExpiredToken.Length > 0)
            {
                ExpiredToken = ExpiredToken.Remove(0, 7);

                var handler = new JwtSecurityTokenHandler();
                var jsonToken = handler.ReadToken(ExpiredToken);
                var tokenS = jsonToken as JwtSecurityToken;

                var ProfileID = tokenS.Claims.First(claim => claim.Type == "ProfileID").Value;
                var UserPassword = tokenS.Claims.First(claim => claim.Type == "UP").Value;

                var profileData = await new GenericRepository<Profile>().FindOne(u => u.Id.ToString() == ProfileID);
                var userAccountData = await new GenericRepository<UserAccount>().FindOne(u => u.ProfileId.ToString() == ProfileID);
                var userRole = await new GenericRepository<Role>().FindOne(u => u.Id == userAccountData.RoleId);
                //create claims details based on the user information
                var claims = new[] {
                        new Claim(JwtRegisteredClaimNames.Sub, JWTTokenConfigDTO.JwtSubject),
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                        new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                        new Claim("MobileNo", profileData.MobileNo),
                        new Claim("Email", profileData.EmailAddress),
                        new Claim("FullName", profileData.FullName),
                        new Claim("ProfileID", profileData.Id.ToString()),
                        new Claim("RoleID", userAccountData.RoleId.ToString()),
                        new Claim("RoleName",userRole.RoleName),
                        new Claim("UP", userAccountData.UserPassword)
                    };

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JWTTokenConfigDTO.JwtKey));
                var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var token = new JwtSecurityToken(JWTTokenConfigDTO.JwtIssuer, JWTTokenConfigDTO.JwtAudience, claims,
                    expires: DateTime.UtcNow.AddMinutes(60),
                    signingCredentials: signIn);

                TokenObject = new JWTTokenDTO
                {
                    MobileNo = profileData.MobileNo,
                    Email = profileData.EmailAddress,
                    FullName = profileData.FullName,
                    ProfileID = profileData.Id,
                    RoleID = userAccountData.RoleId,
                    RoleName = userRole.RoleName,
                    TokenExpireOn = DateTime.UtcNow.AddMinutes(60),
                    Token = new JwtSecurityTokenHandler().WriteToken(token)
                };
            }

            return TokenObject;
        }


        private async Task<string> UserLoginValidation(UserLoginDTO user)
        {
            var profileData = await new GenericRepository<Profile>().FindOne(u => u.EmailAddress == user.RefString || u.MobileNo == user.RefString);
            if (profileData == null) throw new Exception("User Profile Not Found.");
            
            var userData = await new GenericRepository<UserAccount>().FindOne(u => u.ProfileId == profileData.Id);
            if (userData == null) throw new AuthenticationException("User Not Found.");
            
            else if (!new Crypto().VerifyHashedPassword(userData.UserPassword,user.UserPassword)) throw new AuthenticationException("Incorrect Password.");
            else return "OK";
        }

        public async Task<UserAccount> ResetUserPassword(UserAccountDTO user)
        {
            var userData = await new GenericRepository<UserAccount>().FindOne(u => u.ProfileId == user.ProfileId);

            if (userData == null) throw new Exception("User Not Found.");

            userData.UserPassword = new Crypto().HashPassword(user.UserPassword);

           return await new GenericRepository<UserAccount>().Update(userData, u => u.ProfileId == userData.ProfileId);
           
        }


        
    }
}
