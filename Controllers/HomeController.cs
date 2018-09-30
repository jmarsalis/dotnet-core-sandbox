using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Versioning;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sandbox.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult Version()
        {
            var framework = Assembly
                .GetEntryAssembly()?
                .GetCustomAttribute<TargetFrameworkAttribute>()?
                .FrameworkName;

            /* 
            var stats = new
            {                
                OsPlatform = System.Runtime.InteropServices.RuntimeInformation.OSDescription,
                AspDotnetVersion = framework
            };
            */

            ViewData["OsPlatform"] = System.Runtime.InteropServices.RuntimeInformation.OSDescription;
            ViewData["AspDotNetVersion"] = framework;

            return View();
        }
    }
}
