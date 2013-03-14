using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*All Added References*/
using Parser.Library.Models;
using System.Net;
using System.Xml.Linq;

namespace ParserClient
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] API = { "http://search.twitter.com/search.json?q=wcf service", "http://themoneyconverter.com/rss-feed/JMD/rss.xml" };
            Channel channel = new Channel();
            var response = "";
            using (WebClient client = new WebClient())
            {
               response = client.DownloadString(new Uri(API[1]));
               
            }

            // Define Document 
            XDocument doc = new XDocument();

            // Define the roots of the xml collection file
            XElement root = new XElement("Modules");

            // Define the child of the root and assign a value to it
            XElement intro = new XElement("Module");
            intro.Value = "Introduction to LINQ";

            XElement cs = new XElement("Module");
            cs.Value = "LINQ and C#";

            // Add the children of the root to the root
            root.Add(intro);
            root.Add(cs);

            // Add the root to the document
            doc.Add(root);

            //XDocument rss = XDocument.Parse();
        }
    }
}
