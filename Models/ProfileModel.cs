using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IdentitySample.Models
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
        public class MusicViewModel
        {
            public int MusicId { get; set; }
            public string Genres { get; set; }
            public string Title { get; set; }
            
            public virtual int UserId { get; set; }
            public virtual ApplicationUser User { get; set; }
        }
        public class VideoViewModel
        {
            public int VideoId { get; set; }
            public string Genres { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }

            public virtual int UserId { get; set; }
            public virtual ApplicationUser User { get; set; }
        }
        //public class Countries
        //{
        //    public int Id { get; set; }
        //    public string Country { get; set; }
        //}
 }
