using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u3ndahl.Models
{
    public class Program
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public Double time { get; set; }
        public string category { get; set; }
        public int channel { get; set; }
        public List<Program> programL { get; set; }


    }
}