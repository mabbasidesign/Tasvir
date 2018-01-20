using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tasvir.Data.Models;
using Tasvir.Models;

namespace Tasvir.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            var hikingImageTag = new List<ImageTag>();
            var cityImageTag = new List<ImageTag>();

            var tag1 = new ImageTag()
            {
                Description = "Advanture",
                Id = 0,
            };

            var tag2 = new ImageTag()
            {
                Description = "Urban",
                Id = 1,
            };

            var tag3 = new ImageTag()
            {
                Description = "New Yourk",
                Id = 2,
            };

            hikingImageTag.Add(tag1);
            cityImageTag.AddRange(new List<ImageTag>{ tag2, tag3});

            var imageList = new List<GalleryImage>()
            {
                new GalleryImage()
                {
                    Title = "Hiking Image",
                    Url = "https://pixabay.com/get/eb30b70e2bfd063ed1534705fb0938c9bd22ffd41cb017459df3c878a5/sea-2561397_1920.jpg",
                    Created = DateTime.Now,
                    Tags = hikingImageTag
                },

                new GalleryImage()
                {
                    Title = "On the trail",
                    Url = "https://pixabay.com/get/e832b50d20f6003ed1534705fb0938c9bd22ffd41cb017459df7c778a7/trekking-1742821_1920.jpg",
                    Created = DateTime.Now,
                    Tags = hikingImageTag
                },

                new GalleryImage()
                {
                    Title = "Downtown",
                    Url = "https://pixabay.com/get/e83cb50e2ffc023ed1534705fb0938c9bd22ffd41cb017459df7c47da1/manali-1941783_1920.jpg",
                    Created = DateTime.Now,
                    Tags = cityImageTag
                }
            };

            var model = new GaleeryIndexModel
            {
                Images = imageList,
                SearchQuery = ""
            };
            return View(model);
        }
    }
}