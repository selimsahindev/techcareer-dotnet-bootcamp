using Microsoft.AspNetCore.Mvc;
using TechcareerDotnetBootcamp.Models;
using TechcareerDotnetBootcamp.Services;

namespace TechcareerDotnetBootcamp.Controllers
{
    [Route("api/[controller]")]
    public class WebUserController : ControllerBase
    {
        // GET: api/webuser
        [HttpGet]
        public IEnumerable<WebUser> Get()
        {

            return WebUserService.GetWebUsers();
        }
    }
}

