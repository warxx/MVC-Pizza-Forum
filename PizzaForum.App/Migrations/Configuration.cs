namespace PizzaForum.App.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PizzaForum.App.Data.PizzaForumContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(PizzaForum.App.Data.PizzaForumContext context)
        {
        }
    }
}
