using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOGIN3.Models
{
    public class StatesDto
    {
        public string StateID { get; set; }

        public string StateName { get; set; }
        public string DistrictID { get; set; }
        public string DistrictName { get; set; }
        public string DistrictStateID { get; set; }
    }
}