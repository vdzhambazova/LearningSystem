using System.Linq;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace LearningSystem.Data.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<LearningSystemContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LearningSystem.Data.LearningSystemContext context)
        {
            if (!context.Roles.Any(role => role.Name == "Student"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole("Student");
                manager.Create(role);
            }

            if (!context.Roles.Any(role => role.Name == "Admin"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole("Admin");
                manager.Create(role);
            }

            if (!context.Roles.Any(role => role.Name == "Trainer"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole("Trainer");
                manager.Create(role);
            }

            if (!context.Roles.Any(role => role.Name == "BlogAuthor"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole("BlogAuthor");
                manager.Create(role);
            }
        }
    }
}
