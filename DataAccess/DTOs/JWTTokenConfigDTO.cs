using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTOs
{
    public static class JWTTokenConfigDTO
    {
        public static string JwtKey = "Yh2k7QSu4l8CZg5X3Pna9L0Miy4D3Bvt0JVr87UcOj69Kqw5R2N4FWs03Hdx";
        public static string JwtIssuer = "JWTAuthenticationServer";
        public static string JwtAudience = "JWTServicePostmanClient";
        public static string JwtSubject = "JWTServiceAccessToken";
    }
}
