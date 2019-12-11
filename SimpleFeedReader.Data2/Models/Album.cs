using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SimpleFeedReader.Data2.Models
{
    public class Album
    {
        [Key]
        public int AlbumId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string description { get; set; }

        public virtual IList<Artist> Artists { get; set; }

    }
}
