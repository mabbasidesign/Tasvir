﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tasvir.Data.Models;
using Tasvir.Models;
using Tasvir.Services;

namespace Tasvir.Controllers
{
    public class GalleryController : Controller
    {
        private readonly ImageService _imageService;
        public GalleryController(ImageService imgeService)
        {
            _imageService = imgeService;
        }

        public IActionResult Index()
        {
            var imageList = _imageService.GetAll();
            var model = new GaleeryIndexModel
            {
                Images = imageList,
                SearchQuery = ""
            };
            return View(model);
        }
    }
}