using IdentitySample.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplicationNew.Models
{
    public class MyDbContext : IdentityDbContext<ApplicationUser>
    {
        public MyDbContext()
            : base("DefaultConnection")
        {
            //DbSet<WebApplicationNew.Models.RolesModel.Countries> Countries;
            DbSet<IdentitySample.Models.CountryViewModel> Counries;
        }


        //protected override void OnModelCreating(DbModelBuilder modelBuilder) { }

        //public System.Data.Entity.DbSet<WebApplicationNew.Models.ToDo> 
        //                     ToDoes { get; set; }

        //}
    }
}
