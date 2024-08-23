using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.Mvc;

namespace LOGIN3.Models
{
    public class EducationDetails
    {
        //private readonly ApplicationDbContext
        public EducationDetails() { }

        public bool IsSslc { get; set; }
        public string SchoolName{ get; set; }

        public DateTime CompletionDate { get; set; }

        public int TotalMarks { get; set; }

        public IEnumerable<StatesDto> statesDto { get; set; }

        public IEnumerable<SelectListItem> StatesSelectList { get; set; }
        public IEnumerable<StatesDto> DistrictSelectList { get; set; }

        

    }
}