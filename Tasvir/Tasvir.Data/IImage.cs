using System;
using System.Collections.Generic;
using System.Text;
using Tasvir.Data.Models;

namespace Tasvir.Data
{
    public interface IImage
    {
        IEnumerable<GalleryImage> GetAll();
        IEnumerable<GalleryImage> GetWithTag(string tag);
        GalleryImage GetById(int id);
    }
}
