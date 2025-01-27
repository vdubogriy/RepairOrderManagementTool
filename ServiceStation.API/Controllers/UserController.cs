using Microsoft.AspNetCore.Mvc;
using ServiceStation.API.Auth;
using ServiceStation.DTO;
using System.Linq;
using System.Threading.Tasks;
using ServiceStation.AuthExtensions;
using ServiceStation.DatabaseModels;

namespace ServiceStation.API.Controllers
{
    [Route("user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public UserController(DatabaseContext context)
        {
            _context = context;
        }

        [Route("validate")]
        [HttpGet]
        public ActionResult<UserModel> Validate()
        {
            var userModel = new UserModel();

            var token = HttpContext.Request.Headers["Authorization"].ToString();

            var tokenUser = string.IsNullOrEmpty(token) ? null : new TokenHandler().DecodeToken<User>(token);

            if (tokenUser != null)
            {
                var user = _context.Users.FirstOrDefault(item => item.Email == tokenUser.Email && item.Token == token);

                if (user != null)
                {
                    userModel.Token = token;
                    userModel.Email = user.Email;
                    userModel.IsAuthenticated = true;
                }
            }

            return userModel;
        }

        [Route("login")]
        [HttpPost]
        public async Task<ActionResult<UserModel>> LoginAsync([FromBody] LoginRequestModel userRequestModel)
        {
            var user = _context.Users.ToList().FirstOrDefault(item => item.Email == userRequestModel.Email && userRequestModel.PasswordHash.VerifyPassword(item.PasswordHash));

            var userModel = new UserModel();

            if (user != null)
            {
                user.Token = new TokenHandler().GenerateToken(userRequestModel);

                userModel.Token = user.Token;
                userModel.Email = user.Email;
                userModel.IsAuthenticated = true;
                userModel.ServiceStationId = user.CarServiceStationId;

                await _context.SaveChangesAsync();
            }

            return userModel;
        }

        [Route("logout")]
        [HttpPost]
        public async Task<ActionResult<UserModel>> LogoutAsync()
        {
            var token = HttpContext.Request.Headers["Authorization"].ToString();

            var tokenUser = string.IsNullOrEmpty(token) ? null : new TokenHandler().DecodeToken<User>(token);

            if (tokenUser != null)
            {
                var user = _context.Users.FirstOrDefault(item => item.Email == tokenUser.Email && item.Token == token);

                if (user != null)
                {
                    user.Token = null;

                    _context.Users.Update(user);

                    await _context.SaveChangesAsync();
                }
            }

            return new UserModel { IsAuthenticated = false };
        }
    }
}
