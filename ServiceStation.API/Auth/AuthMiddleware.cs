using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Threading.Tasks;
using ServiceStation.DTO;

namespace ServiceStation.API.Auth
{
    public class AuthMiddleware
    {
        private readonly RequestDelegate _next;

        public AuthMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            var token = context.Request.Headers["Authorization"].ToString();

            if (!string.IsNullOrWhiteSpace(token))
            {
                var user = string.IsNullOrEmpty(token) ? null : new TokenHandler().DecodeToken<LoginRequestModel>(token);

                if (user != null)
                {
                    using var databaseContext = new DatabaseContext();

                    var dbUser = databaseContext.Users.FirstOrDefault(item => item.Email == user.Email && item.Token == token);

                    if (dbUser != null)
                    {
                        context.Items["User"] = user;
                    }
                }
            }

            await _next(context);
        }
    }
}
