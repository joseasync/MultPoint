
using System;
using Microsoft.AspNetCore.Mvc;
using MultPoint.Models;

namespace MultPoint.Controllers
{
    [Route("[controller]")]
    public class StatusController : Controller
    {
        private static BasicCounter _counterStatus = new BasicCounter();

        [HttpGet]
        public object Get()
        {
            lock (_counterStatus)
            {
                _counterStatus.Increase();

                return new
                {
                    _counterStatus.StatusValue,
                    Environment.MachineName,
                    Sistema = Environment.OSVersion.VersionString


                };
            }
        }

    }
}