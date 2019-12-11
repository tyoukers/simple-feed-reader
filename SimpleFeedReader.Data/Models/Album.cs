using System;
using System.Collections.Generic;

namespace SimpleFeedReader.Data.Models
{
    public class Album
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string description { get; set; }

        public virtual IList<Artist> Artists { get; set; }

    }
}
