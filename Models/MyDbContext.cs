using IdentitySample.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IdentitySample.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext()
            : base("DefaultConnection")
        {
           
            
        }
        public DbSet<ApplicationUser> Users { get; set; }
        public DbSet<VideoViewModel> Musics { get; set; }
        public DbSet<VideoViewModel> Videos { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }

        //public System.Data.Entity.DbSet<WebApplicationNew.Models.ToDo> 
        //                     ToDoes { get; set; }

        //}
    }
}
