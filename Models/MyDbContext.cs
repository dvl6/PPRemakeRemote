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
        public DbSet<Music> Musics { get; set; }
        public DbSet<Stream> Shows { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Content>()
            //    .HasMany(c => c.Editors)
            //    .WithOptional()
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Content>()
            //    .HasRequired(c => c.Owner)
            //    .WithOptional()
            //    .WillCascadeOnDelete(false);

            modelBuilder.Entity<IdentityUserLogin>().HasKey<string>(l => l.UserId);
            modelBuilder.Entity<IdentityRole>().HasKey<string>(r => r.Id);
            modelBuilder.Entity<IdentityUserRole>().HasKey(r => new { r.RoleId, r.UserId });
        }
        //public override void Seed(MyDbContext context)
        //{
        //    context.Videos.Add(new Stream { VideoId = 1, UserId = new Guid("b358417c-dfae-49d5-ae85-1384519c1d8b")});
        //}
        //public System.Data.Entity.DbSet<WebApplicationNew.Models.ToDo> 
        //                     ToDoes { get; set; }

        //}
    }
}
