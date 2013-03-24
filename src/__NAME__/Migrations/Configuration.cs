namespace __NAME__.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<__NAME__.Models.Context>
    {
        public Configuration()
        {
            /*
             * Note: You may want to use migrations instead of letting it happen for you automatically.
             * Set AutomaticMigrationsEnabled = false and remove the setting of 
             * AutomaticMigrationDataLossAllowed.
             * 
             * This will allow you to use Migrations like you may know how using the powershell
             * commandlets that come with Entity Framework.
             */
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(Models.Context context)
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
        }
    }
}
