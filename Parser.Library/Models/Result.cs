using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parser.Library.Models
{
    public class Result
    {
        public string Created_At { get; set; }
        public string From_User { get; set; }
        public long From_User_Id { get; set; }
        public string From_User_Id_Str { get; set; }
        public string From_User_Name { get; set; }
        public string Geo { get; set; }
        public long Id { get; set; }
        public string Id_Str { get; set; }
        public string Iso_Language_Code { get; set; }
        public Metadata Metadata { get; set; }
        public string Profile_Image_Url { get; set; }
        public string Profile_Image_Url_Https { get; set; }
        public string Source { get; set; }
        public string Text { get; set; }
    }
}
