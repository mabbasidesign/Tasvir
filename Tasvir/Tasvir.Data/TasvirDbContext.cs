using Microsoft.EntityFrameworkCore;
using System;
using Tasvir.Data.Models;

namespace Tasvir.Data
{
    public class TasvirDbContext :DbContext
    {
        public TasvirDbContext(DbContextOptions options) : base (options)
        {

        }

        public DbSet<GalleryImage> GalleryImages { get; set; }
        public DbSet<ImageTag> ImageTags { get; set; }
    }
}
