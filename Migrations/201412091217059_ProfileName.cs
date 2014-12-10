namespace IdentitySample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProfileName : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "ProfileName", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "ProfileName", c => c.String());
        }
    }
}
