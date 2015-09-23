using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TextMatch.Models
{
    public class CompareRequest
    {
        public string text { get; set; }
        public string subtext { get; set; }
    }
}