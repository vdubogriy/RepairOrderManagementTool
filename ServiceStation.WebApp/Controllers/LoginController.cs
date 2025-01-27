using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ServiceStation.Desktop.Handler;
using ServiceStation.DTO;
using ServiceStation.WebApp.Models;

namespace ServiceStation.WebApp.Controllers
{
    public class LoginController : Controller
    {
        public readonly string ApiUrl;

        public LoginController(IConfiguration config)
        {
            ApiUrl = config["AppSettings:ApiUrl"];
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login([FromBody] LoginRequestModel loginRequestModel)
        {
            try
            {
                var apiHandler = new ServiceStationApiHandler(ApiUrl);

                var user = apiHandler.Login(loginRequestModel);

                return Json(user);
            }
            catch (System.Exception ex)
            {
                return View("Error", new ErrorViewModel { Error = ex.Message });
            }
        }

        public IActionResult ValidateUser()
        {
            try
            {
                var token = HttpContext.Request.Headers["Authorization"].ToString();

                var apiHandler = new ServiceStationApiHandler(ApiUrl, token);
                var userModel = apiHandler.ValidateUser();

                return Json(userModel);
            }
            catch (System.Exception ex)
            {
                return View("Error", new ErrorViewModel { Error = ex.Message });
            }
        }

        public IActionResult Logout()
        {
            try
            {
                var token = HttpContext.Request.Headers["Authorization"].ToString();

                var apiHandler = new ServiceStationApiHandler(ApiUrl, token);

                apiHandler.Logout();
            }
            catch (System.Exception ex)
            {
                return View("Error", new ErrorViewModel { Error = ex.Message });
            }

            return Redirect("/Login");
        }
    }
}
