using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using LearningSystem.Models.BindingModels;
using LearningSystem.Models.EntityModels;
using LearningSystem.Models.ViewModels.Courses;
using LearningSystem.Models.ViewModels.Users;

namespace LearningSystem.Services
{
    public class UsersService : Service
    { 
        public Student GetStudent(string studentName)
        {
            var user = this.Context.Users.FirstOrDefault(u => u.Email == studentName);
            Student student = this.Context.Students.FirstOrDefault(s => s.User.Id == user.Id);

            return student;
        }

        public void EnrollStudentInCourse(Student student, int courseId)
        {
            Course wantedCourse = this.Context.Courses.Find(courseId);
            student.Courses.Add(wantedCourse);
            this.Context.SaveChanges();
        }

        public UserProfileViewModel GetProfile(string userName)
        {       
            ApplicationUser user = this.Context.Users.FirstOrDefault(u => u.UserName == userName);
            UserProfileViewModel upvm = Mapper.Map<ApplicationUser, UserProfileViewModel>(user);
            Student student = this.Context.Students.FirstOrDefault(s => s.User.Name == user.Name);
            upvm.Courses = Mapper.Map<IEnumerable<Course>, IEnumerable<UsersCourseViewMode>>(student.Courses);

            return upvm;
        }

        public UserEditViewModel GetEditUser(string userName)
        {
            ApplicationUser user = this.Context.Users.FirstOrDefault(u => u.Name == userName);
            UserEditViewModel uevm = Mapper.Map<ApplicationUser, UserEditViewModel>(user);

            return uevm;
        }

        public void EditUser(UserEditBindingModel bind, string userName)
        {
            ApplicationUser user = this.Context.Users.FirstOrDefault(u => u.Name == userName);
            user.Name = bind.Name;
            user.Email = bind.Email;

            this.Context.SaveChanges();
        }
    }
}
