using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWebAPI.Models
{
    public class PODetail
    {
        public string PONO { get; set; }
        public string PODATE { get; set; }
        public string SUPLNAME { get; set; }
        public string ITDESC { get; set; }
        public int QTY { get; set; }
        public double ITAMOUNT { get; set; }

    }
}