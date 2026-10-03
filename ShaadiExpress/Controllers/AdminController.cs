using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ShaadiExpress.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        [HttpGet]
        [Route("AddUser")]
        public IActionResult AddUser(string username, string password)
        {
            return Ok(1);
        }
    }
}
