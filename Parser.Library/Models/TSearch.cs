using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parser.Library.Models
{
    public class TSearch
    {
        public float CompletedIn { get; set; }
        public long MaxId { get; set; }
        public string MaxIdStr { get; set; }
        public string NextPage { get; set; }
        public int Page { get; set; }
        public string Query { get; set; }
        public string RefreshUrl { get; set; }
        public List<Result> Results { get; set; }
        public int ResultsPerPage { get; set; }
        public int SinceId { get; set; }
        public string SinceIdStr { get; set; }
    }
}
