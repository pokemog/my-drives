using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace my_drives.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrivesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] {
                "drive c",
                "drive d"
            };
        }
    }
}