using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AzureADTest2.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost]
        public IActionResult Callback([FromForm] string code, [FromForm] string state)
        {
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                return Redirect("/");
            } else
            {
                return Redirect("/");
            }
            
        }
    }
}
