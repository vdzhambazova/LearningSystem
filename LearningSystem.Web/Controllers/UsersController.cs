using System.Web.Mvc;
using LearningSystem.Models.BindingModels;
using LearningSystem.Models.EntityModels;
using LearningSystem.Models.ViewModels.Users;
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
        [Route("enroll")]
        public ActionResult Enroll(int courseId)
        {
            string studentName = this.User.Identity.Name;
            Student student = this.usersService.GetStudent(studentName);
            this.usersService.EnrollStudentInCourse(student, courseId);

            return this.RedirectToAction("Profile");
        }

        [HttpGet]
        [Route("profile/{id}")]
        public ActionResult Profile()
        {
            string userName = this.User.Identity.Name;
            UserProfileViewModel upvm = this.usersService.GetProfile(userName);

            return this.View(upvm);
        }

        [HttpGet]
        [Route("edit")]
        public ActionResult Edit()
        {
            string userName = this.User.Identity.Name;
            UserEditViewModel uevm = this.usersService.GetEditUser(userName);

            return this.View(uevm) ;
        }

        [HttpPost]
        [Route("edit")]
        public ActionResult Edit(UserEditBindingModel bind)
        {
            string userName = this.User.Identity.Name;

            if (ModelState.IsValid)
            {
                this.usersService.EditUser(bind, userName);
                this.RedirectToAction("Profile");
            }

           
            UserEditViewModel uevm = this.usersService.GetEditUser(userName);

            return this.View(uevm);
        }
    }
}