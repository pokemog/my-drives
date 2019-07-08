using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System;

namespace my_drives.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrivesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var drives = DriveInfo.GetDrives();
            var driveNames = new List<string>();

            foreach (var drive in drives)
            {
                driveNames.Add(drive.ToString());
            }
            
            return driveNames;
        }
    }
}