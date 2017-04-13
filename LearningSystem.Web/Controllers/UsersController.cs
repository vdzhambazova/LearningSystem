using System.Web.Mvc;
using LearningSystem.Models.EntityModels;
using LearningSystem.Services;

namespace LearningSystem.Web.Controllers
{
    [Authorize(Roles="Student")]
    [RoutePrefix("users")]
    public class UsersController : Controller
    {
        private UsersService usersService;

        public UsersController()
        {
            this.usersService = new UsersService();
        }

        [HttpPost]
        [Route("enroll/{courseId}")]
        public ActionResult Enroll(int courseId)
        {
            string studentName = User.Identity.Name;
            Student student = this.usersService.GetStudent(studentName);
            this.usersService.EnrollStudentInCourse(student, courseId);

            return this.RedirectToAction("Details", "Courses", new {id = courseId});
        }
    }
}