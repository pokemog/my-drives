using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System;
using MyDrives.Models;

namespace MyDrives.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrivesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Drive>> Get()
        {
            var drives = DriveInfo.GetDrives();
            var driveNames = new List<Drive>();

            foreach (var drive in drives)
            {
                driveNames.Add(new Drive()
                { 
                    DriveName = drive.Name,
                    VolumeLabel = drive.VolumeLabel,
                    TotalFreeSpace = drive.TotalFreeSpace
                });
            }

            return driveNames;
        }
    }
}