namespace IdentitySample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserId : DbMigration
    {
        public override void Up()
        {
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
                        UserId = c.Guid(nullable: false),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.VideoId)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .Index(t => t.User_Id);
            
            AddColumn("dbo.AspNetUsers", "UserId", c => c.Guid(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Streams", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Streams", new[] { "User_Id" });
            DropColumn("dbo.AspNetUsers", "UserId");
            DropTable("dbo.Streams");
        }
    }
}
