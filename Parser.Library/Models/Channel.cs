using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parser.Library.Models
{
    public class Channel
    {
        public String Title { get; set; }
        public String Link { get; set; }
        public String Description { get; set; }
        public String LastBuildDate { get; set; } // Optional
        public String Language { get; set; } // Optional
        public String Copyright { get; set; } // Optional
        public String Docs { get; set; } // Optional
        // Optional
        public String TimeToLive { get; set; } // TTL Amount of minutes the feed is cache before refreshed from source
        public Image Image { get; set; }
        public IEnumerable<Item> Items { get; set; }
    }
}
