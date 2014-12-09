using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;

namespace IdentitySample.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
        //[Display(Name = "Username")]
        //public string UserName { get; set; }
        [Display(Name = "Band/Artist Name")]
        [Required]
        [StringLength(50, MinimumLength=3)]
        public string ProfileName { get; set; }
        [Display(Name = "BandMembers")]
        [DataType(DataType.MultilineText)]
        public string BandMembers { get; set; }
        [Display(Name = "Country")]
        public String Country { get; set; }
        [Display(Name = "Name")]
        public String Name { get; set; }
        [Display(Name = "Surname")]
        public String Surname { get; set; }
        [Display(Name = "Genre")]
        public String Genre { get; set; }
        [Display(Name = "Web Page")]
        public String Webpage { get; set; }
        [Display(Name = "Music Styles")]
        public String MusicStyles { get; set; }
        [Display(Name = "Description")]
        public String Description { get; set; }
        [Display(Name = "IP Adress")]
        public String IPaddress { get; set; }
        [Display(Name = "Paypal")]
        public String Paypal { get; set; }
        [Display(Name = "Styles")]
        public String Styles { get; set; }
        
        [DataType(DataType.Password)]
        [Display(Name = "New Password")]
        public String NewPassword { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("NewPassword", ErrorMessage = "The password and confirmation password do not match.")]
        public String ConfirmPassword { get; set; }
        [Display(Name = "Old Password")]
        public String OldPassword { get; set; }
    }


    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: true)
        {
           
        }

        static ApplicationDbContext()
        {
            // Set the database intializer which is run once during application start
            // This seeds the database with admin user credentials and admin role
           // Database.SetInitializer<ApplicationDbContext>(new ApplicationDbInitializer());
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}