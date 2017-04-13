using AutoMapper;
using LearningSystem.Models.EntityModels;
using LearningSystem.Models.ViewModels.Courses;

namespace LearningSystem.Services
{
    public class CourseSevice : Service
    {
        public CourseDetailsViewModel GetCourse(int id)
        {
            Course course = this.Context.Courses.Find(id);
            if (course == null)
            {
                return null;
            }

            CourseDetailsViewModel cdvm = Mapper.Map<Course, CourseDetailsViewModel>(course);

            return cdvm;
        }
    }
}
