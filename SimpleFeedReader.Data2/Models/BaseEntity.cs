using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFeedReader.Data2.Models
{
    internal class BaseEntity
    {
        public DateTime Created { get; internal set; }
        public DateTime Modified { get; internal set; }
    }
}
