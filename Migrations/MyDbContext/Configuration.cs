namespace IdentitySample.Migrations.MyDbContext
{
    using IdentitySample.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<IdentitySample.Models.MyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\MyDbContext";
        }

        protected override void Seed(IdentitySample.Models.MyDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Conversations.AddOrUpdate(
              p => p.ConversationId,

              new Conversations { SenderId = new Guid("b358417c-dfae-49d5-ae85-1384519c1d8b"), RecipentId =  new Guid("5c39fd18-ce3a-45b9-82cb-5e07931f75a7"), Text="test text", Subject="The first message"  }

            );
            //
        }
    }
}
