using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace AuthenticationJWT.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class ProtectedController : ControllerBase
    {
        [Authorize]
        [HttpGet]
        public IActionResult Get()
        {
            // Protected action, only accessible with a valid token
            var username = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            return Ok($"Hello {username}! This is a protected resource.");
        }
    }
}
