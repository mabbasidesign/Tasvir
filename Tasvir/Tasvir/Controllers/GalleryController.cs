using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tasvir.Models;

namespace Tasvir.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            var model = new GaleeryIndexModel
            {

            };
            return View(model);
        }
    }
}