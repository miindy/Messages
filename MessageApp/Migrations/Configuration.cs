namespace MessageApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using MessageApp.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<MessageApp.Models.MessageDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MessageApp.Models.MessageDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Messages.AddOrUpdate(i => i.Content,
                                new Message
                                {
                                    Content = "You have beautiful eyelashes",
                                    MessageDate = DateTime.Parse("2015-5-4"),
                                    Genre = "Physical",
                                    Stars = 4
                                },
               new Message
               {
                   Content = "You have awesome leggings",
                   MessageDate = DateTime.Parse("2015-5-4"),
                   Genre = "Possessions",
                   Stars = 3
               },
               new Message
               {
                   Content = "You are very kind",
                   MessageDate = DateTime.Parse("2015-5-4"),
                   Genre = "Personality",
                   Stars = 5
               },
               new Message
               {
                   Content = "You have gorgeous feet",
                   MessageDate = DateTime.Parse("2015-5-4"),
                   Genre = "Physical",
                   Stars = 4
               },
               new Message
               {
                   Content = "You are good at learning new things",
                   MessageDate = DateTime.Parse("2015-5-4"),
                   Genre = "Skills",
                   Stars = 3
               },
               new Message
               {
                   Content = "Your fingernails are a nice shape",
                   MessageDate = DateTime.Parse("2015-5-4"),
                   Genre = "Physical",
                   Stars = 2
               }
               );
        }
    }
}
