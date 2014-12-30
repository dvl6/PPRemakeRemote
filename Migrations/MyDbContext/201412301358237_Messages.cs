namespace IdentitySample.Migrations.MyDbContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Messages : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Conversations", "Subject", c => c.String(nullable: false));
            AlterColumn("dbo.Conversations", "Text", c => c.String(nullable: false));
            DropColumn("dbo.Messages", "Subject");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Messages", "Subject", c => c.String());
            AlterColumn("dbo.Conversations", "Text", c => c.String());
            AlterColumn("dbo.Conversations", "Subject", c => c.String());
        }
    }
}
