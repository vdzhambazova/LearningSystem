using System.Collections.Generic;
using System.Web.Mvc;
using LearningSystem.Models.ViewModels.Courses;
using LearningSystem.Services;

namespace LearningSystem.Web.Controllers
{
    [Authorize(Roles = "Student")]
    public class HomeController : Controller
    {
        private HomeService homeService;

        public HomeController()
        {
            this.homeService = new HomeService();
        }

        [AllowAnonymous]
        public ActionResult Index()
        {
            IEnumerable<CourseViewModel> cvms = this.homeService.GetAllCourses();

            return this.View(cvms);
        }
    }
}