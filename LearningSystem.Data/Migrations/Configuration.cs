using System;
using System.Linq;
using LearningSystem.Models.EntityModels;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace LearningSystem.Data.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<LearningSystemContext>
    { 
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(LearningSystem.Data.LearningSystemContext context)
        {
            context.Courses.AddOrUpdate(course => course.Name, new Course[]
            {
                new Course()
                {
                    Name = "Programming basics - March 2016",
                    Description = "Курсът Programming basics дава начални умения по програмиране.",
                    StartDate = new DateTime(2016, 03, 23),
                    EndDate = new DateTime(2016, 06, 30)
                },
                new Course()
                {
                    Name = "Android Development - September 2016",
                    Description = "Курсът Android Development ще ви научи на основите на разработването на мобилни native приложения на Android.",
                    StartDate = new DateTime(2016, 09, 13),
                    EndDate = new DateTime(2016, 11, 24)
                },
                new Course()
                {
                    Name = "Entity Framework - December 2016",
                    Description = "Курсът Entity Framework ще ви запознае с водещата ORM платформа на .Net.",
                    StartDate = new DateTime(2016, 12, 23),
                    EndDate = new DateTime(2017, 04, 25)
                },
                new Course()
                {
                    Name = "Arduino - February 2017",
                    Description = "Курсът Arduino ще ви научи да програмирате Arduino платки.",
                    StartDate = new DateTime(2017, 05, 25),
                    EndDate = new DateTime(2017, 06, 04)
                },
            });

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
