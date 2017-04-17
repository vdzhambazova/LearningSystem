using System;
using System.Web.Mvc;

namespace LearningSystem.Web.Areas.Blog
{
    public class BlogAreaRegistration : AreaRegistration
    {
        

        public override string AreaName => "Blog";
        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.Routes.MapMvcAttributeRoutes();
            context.MapRoute(
               name: "Blog",
               url: "blog/{controller}/{action}/{id}",
               defaults: new {action = "Index", id = UrlParameter.Optional }
           );
        }
    }
}