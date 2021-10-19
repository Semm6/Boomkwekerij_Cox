using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Cox_Boomkwekerijen.Models;

namespace Cox_Boomkwekerijen.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Assortiment()
        {
            return View("Assortiment");
        }

        public IActionResult Details()
        {
            return View("Details");
        }
    }
}
