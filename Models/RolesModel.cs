using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplicationNew.Models
{
    public class RolesModel
    {
        public class ViewerViewModel
        {
            [Display(Name = "Name")]
            public string Name { get; set; }

            [Display(Name = "Surname")]
            public string Surname { get; set; }

            [Display(Name = "Genre")]
            public string Genre{get;set;}

            [Display(Name = "Country")]
            public string Country;

        }

        public class BandViewModel
        {
            [Display(Name = "Artist/Band Name")]
            public string ProfileName { get; set; }

            [Display(Name = "Band Members")]
            [DataType(DataType.MultilineText)]
            public string BandMembers { get; set; }

            [Display(Name = "Country")]
            public string Country;

            [Display(Name = "IP Adress")]
            public string IPaddress { get; set; }
        }
        //public class Countries
        //{
        //    public int Id { get; set; }
        //    public string Country { get; set; }
        //}
    }
}