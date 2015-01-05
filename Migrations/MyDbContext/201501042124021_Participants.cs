namespace IdentitySample.Migrations.MyDbContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Participants : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Participants",
                c => new
                    {
                        ParticipantId = c.Int(nullable: false, identity: true),
                        ConversationId = c.Guid(nullable: false),
                        Conversation_ConversationId = c.Int(),
                    })
                .PrimaryKey(t => t.ParticipantId)
                .ForeignKey("dbo.Conversations", t => t.Conversation_ConversationId)
                .Index(t => t.Conversation_ConversationId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Participants", "Conversation_ConversationId", "dbo.Conversations");
            DropIndex("dbo.Participants", new[] { "Conversation_ConversationId" });
            DropTable("dbo.Participants");
        }
    }
}
