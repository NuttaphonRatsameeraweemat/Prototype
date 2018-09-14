using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Prototype.Bll.Interfaces;
using Prototype.Bll.Models;

namespace Prototype.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        #region Fields

        /// <summary>
        /// The Login manager provides Login functionality.
        /// </summary>
        private ILogin _login;

        #endregion

        #region Constructors

        /// <summary>
        ///  Initializes a new instance of the <see cref="LoginController" /> class.
        /// </summary>
        /// <param name="config"></param>
        /// <param name="login"></param>
        public LoginController(IConfiguration config, ILogin login)
        {
            _login = login;
        }

        #endregion

        #region Methods

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Login([FromBody]LoginViewModel auth)
        {
            IActionResult response = Unauthorized();

            if (_login.Authenticate(auth))
            {
                var tokenString = _login.BuildToken(auth.Username);
                response = Ok(tokenString);
            }

            return response;
        }

        [HttpPost]
        [Route("GenearateCookieAuthen")]
        [AllowAnonymous]
        public IActionResult GenearateCookieAuthen([FromBody]LoginViewModel auth)
        {
            IActionResult response = Unauthorized();

            if (_login.Authenticate(auth))
            {
                var tokenString = _login.BuildToken(auth.Username);

                //Generate Cookies for authenticate.
                HttpContext.Response.Cookies.Append("access_token", tokenString, new Microsoft.AspNetCore.Http.CookieOptions()
                {
                    Path = "/",
                    HttpOnly = true, // to prevent XSS
                    Secure = false, // set to true in production
                    Expires = System.DateTime.UtcNow.AddMinutes(5) // token life time
                });

                response = Ok(tokenString);
            }

            return response;
        }

        #endregion

    }
}