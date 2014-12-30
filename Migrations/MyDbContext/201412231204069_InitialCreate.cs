namespace IdentitySample.Migrations.MyDbContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Conversations",
                c => new
                    {
                        ConversationId = c.Int(nullable: false, identity: true),
                        SenderId = c.Guid(nullable: false),
                        RecipentId = c.Guid(nullable: false),
                        Subject = c.String(),
                        Text = c.String(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ConversationId);
            
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        MessageId = c.Int(nullable: false, identity: true),
                        Subject = c.String(),
                        Text = c.String(),
                        SenderId = c.Guid(nullable: false),
                        Date = c.DateTime(nullable: false),
                        ConversationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MessageId)
                .ForeignKey("dbo.Conversations", t => t.ConversationId, cascadeDelete: true)
                .Index(t => t.ConversationId);
            
            CreateTable(
                "dbo.Musics",
                c => new
                    {
                        MusicId = c.Int(nullable: false, identity: true),
                        Genres = c.String(),
                        Title = c.String(),
                        Filename = c.String(),
                        UserId = c.Int(nullable: false),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.MusicId)
                .ForeignKey("dbo.ApplicationUsers", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.ApplicationUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        ProfileName = c.String(nullable: false, maxLength: 50),
                        BandMembers = c.String(),
                        Country = c.String(),
                        Name = c.String(),
                        Surname = c.String(),
                        Genre = c.String(),
                        Webpage = c.String(),
                        MusicStyles = c.String(),
                        Description = c.String(),
                        IPaddress = c.String(),
                        Paypal = c.String(),
                        Styles = c.String(),
                        NewPassword = c.String(),
                        ConfirmPassword = c.String(),
                        OldPassword = c.String(),
                        UserId = c.Guid(nullable: false),
                        Email = c.String(),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IdentityUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ApplicationUsers", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.IdentityUserLogins",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        LoginProvider = c.String(),
                        ProviderKey = c.String(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.ApplicationUsers", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.IdentityUserRoles",
                c => new
                    {
                        RoleId = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ApplicationUser_Id = c.String(maxLength: 128),
                        IdentityRole_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => new { t.RoleId, t.UserId })
                .ForeignKey("dbo.ApplicationUsers", t => t.ApplicationUser_Id)
                .ForeignKey("dbo.IdentityRoles", t => t.IdentityRole_Id)
                .Index(t => t.ApplicationUser_Id)
                .Index(t => t.IdentityRole_Id);
            
            CreateTable(
                "dbo.Streams",
                c => new
                    {
                        VideoId = c.Int(nullable: false, identity: true),
                        Genres = c.String(),
                        Title = c.String(),
                        Description = c.String(),
                        Filename = c.String(),
                        StreamDate = c.DateTime(nullable: false),
                        Frame = c.String(),
                        UserId = c.Guid(nullable: false),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.VideoId)
                .ForeignKey("dbo.ApplicationUsers", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.IdentityRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.IdentityUserRoles", "IdentityRole_Id", "dbo.IdentityRoles");
            DropForeignKey("dbo.Musics", "User_Id", "dbo.ApplicationUsers");
            DropForeignKey("dbo.Streams", "User_Id", "dbo.ApplicationUsers");
            DropForeignKey("dbo.IdentityUserRoles", "ApplicationUser_Id", "dbo.ApplicationUsers");
            DropForeignKey("dbo.IdentityUserLogins", "ApplicationUser_Id", "dbo.ApplicationUsers");
            DropForeignKey("dbo.IdentityUserClaims", "ApplicationUser_Id", "dbo.ApplicationUsers");
            DropForeignKey("dbo.Messages", "ConversationId", "dbo.Conversations");
            DropIndex("dbo.Streams", new[] { "User_Id" });
            DropIndex("dbo.IdentityUserRoles", new[] { "IdentityRole_Id" });
            DropIndex("dbo.IdentityUserRoles", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserLogins", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserClaims", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.Musics", new[] { "User_Id" });
            DropIndex("dbo.Messages", new[] { "ConversationId" });
            DropTable("dbo.IdentityRoles");
            DropTable("dbo.Streams");
            DropTable("dbo.IdentityUserRoles");
            DropTable("dbo.IdentityUserLogins");
            DropTable("dbo.IdentityUserClaims");
            DropTable("dbo.ApplicationUsers");
            DropTable("dbo.Musics");
            DropTable("dbo.Messages");
            DropTable("dbo.Conversations");
        }
    }
}
