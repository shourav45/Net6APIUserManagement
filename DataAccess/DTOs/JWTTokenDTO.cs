namespace DataAccess.DTOs
{
    public class JWTTokenDTO
    {
        public string? FullName { get; set; }
        public string? MobileNo { get; set; }
        public string? Email { get; set; }
        public int? ProfileID { get; set; }
        public int? RoleID { get; set; }
        public string? RoleName { get; set; }
        public string? Token { get; set; }
        public Nullable<DateTime> TokenExpireOn { get; set; }
    }
}
