using System.Collections.Generic;
using System.Web.Mvc;
using LearningSystem.Models.ViewModels.Blog;
using LearningSystem.Services;

namespace LearningSystem.Web.Areas.Blog.Controllers
{
    [RouteArea("blog")]
    [Authorize(Roles = "Student")]
    public class BlogController : Controller
    {
        private BlogService blogService;

        public BlogController()
        {
            this.blogService = new BlogService();
        }
        
        [Route("AllArticles")]
        public ActionResult AllArticles()
        {
            IEnumerable<ArticleViewModel> avms = this.blogService.GetAllArticles();

            return this.View(avms);
        }
    }
}