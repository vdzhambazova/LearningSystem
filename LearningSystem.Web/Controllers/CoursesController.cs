using System.Web.Mvc;
using LearningSystem.Models.ViewModels.Courses;
using LearningSystem.Services;

namespace LearningSystem.Web.Controllers
{
    [Authorize(Roles = "Student")]
    [RoutePrefix("courses")]
    public class CoursesController : Controller
    {
        private CourseSevice courseSevice;

        public CoursesController()
        {
            this.courseSevice = new CourseSevice();
        }

        [HttpGet]
        [Route("details/{id}")]
        [AllowAnonymous]
        public ActionResult Details(int id)
        {
   
            CourseDetailsViewModel csvm = this.courseSevice.GetCourse(id);
            if (csvm == null)
            {
                return this.HttpNotFound();
            }

            return View(csvm);
        }
    }
}