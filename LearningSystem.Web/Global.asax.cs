using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AutoMapper;
using LearningSystem.Models.EntityModels;
using LearningSystem.Models.ViewModels.Blog;
using LearningSystem.Models.ViewModels.Courses;
using LearningSystem.Models.ViewModels.Users;

namespace LearningSystem.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            ConfigureMapping();
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        private void ConfigureMapping()
        {
           Mapper.Initialize(expression =>
           {
               expression.CreateMap<Course, CourseViewModel>();
               expression.CreateMap<Course, CourseDetailsViewModel>();
               expression.CreateMap<ApplicationUser, UserProfileViewModel>();
               expression.CreateMap<Course, UsersCourseViewMode>();
               expression.CreateMap<ApplicationUser, UserEditViewModel>();
               expression.CreateMap<Article, ArticleViewModel>();
               expression.CreateMap<ApplicationUser, ArticleAuthorViewModel>();
           });
        }
    }
}
