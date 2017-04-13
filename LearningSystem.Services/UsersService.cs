using System;
using System.Linq;
using LearningSystem.Models.EntityModels;

namespace LearningSystem.Services
{
    public class UsersService : Service
    { 
        public Student GetStudent(string studentName)
        {
            var user = this.Context.Users.FirstOrDefault(u => u.Name == studentName);
            Student student = this.Context.Students.FirstOrDefault(s => s.User.Id == user.Id);

            return student;
        }

        public void EnrollStudentInCourse(Student student, int courseId)
        {
            Course wantedCourse = this.Context.Courses.Find(courseId);
            student.Courses.Add(wantedCourse);
            this.Context.SaveChanges();
        }
    }
}
