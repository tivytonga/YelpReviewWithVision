using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YelpReviewApp.Models
{

    public class YelpModel
    {
        public ReviewModel[] reviews { get; set; }
        public int total { get; set; }
        public string[] possible_languages { get; set; }
    }

}
