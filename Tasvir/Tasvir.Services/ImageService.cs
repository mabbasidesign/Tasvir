using System;
using System.Collections.Generic;
using Tasvir.Data;
using System.Linq;
using Tasvir.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Tasvir.Services
{
    public class ImageService : IImage
    {
        private readonly TasvirDbContext _ctx;
        public ImageService(TasvirDbContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<GalleryImage> GetAll()
        {
            return _ctx.GalleryImages
                .Include(img => img.Tags)
                .ToList();
        }

        public GalleryImage GetById(int id)
        {
            return _ctx.GalleryImages.SingleOrDefault(img => img.Id == id);
        }

        public IEnumerable<GalleryImage> GetWithTag(string tag)
        {
            return GetAll()
                .Where(img => img.Tags.Any(t => t.Description == tag));
        }
    }
}
