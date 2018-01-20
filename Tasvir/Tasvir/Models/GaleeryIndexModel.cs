using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tasvir.Data.Models;

namespace Tasvir.Models
{
    public class GaleeryIndexModel
    {
        public IEnumerable<GalleryImage> Images { get; set; }
        public string SearchQuery { get; set; }
    }
}
