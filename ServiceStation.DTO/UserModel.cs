using ServiceStation.AuthExtensions;

namespace ServiceStation.DTO
{
    public class LoginRequestModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string PasswordHash => Password.ComputeHash();
    }

    public class UserModel
    {
        public string Email { get; set; }
        public string Token { get; set; }
        public bool IsAuthenticated { get; set; }
        public int? ServiceStationId { get; set; }
    }
}
