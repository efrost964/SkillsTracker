using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SkillsTracker.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SkillsTracker.Controllers
{
    public class SkillsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Progress(string language1, string language2, string language3, string date)
        {
            ViewBag.cSharp = language1;
            ViewBag.python = language2;
            ViewBag.javaScript = language3;
            ViewBag.date = date;

            return View();
        }


    }
}