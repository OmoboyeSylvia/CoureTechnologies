using CoureTechnologies.Interface;
using CoureTechnologies.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoureTechnologies.Controllers
{
    public class UserController
    {
        [ApiController]
        [Route("api/[controller]")]
        public class AuthenticationController : Controller
        {
            private readonly ILogger<AuthenticationController> _logger;
            private readonly IUser _user;

            public AuthenticationController(IUser User, ILogger<AuthenticationController> logger)
            {
                _logger = logger;
                _user= User;
            }

            [HttpGet]
            [Route("~/api/Verify")]
            public async Task<IActionResult> UserCheck ([FromQuery] User user)
            {
                try
                {
                    var result = await _user.UserCheck(user);

                    return Ok(result);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
