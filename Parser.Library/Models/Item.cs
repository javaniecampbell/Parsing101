using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parser.Library.Models
{
    public class Item
    {
        public String Title { get; set; }
        public String Link { get; set; }
        public String PubDate { get; set; } // Optional
        public String Description { get; set; }
        public String Category { get; set; } // Optional
    }
}
