using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using LearningSystem.Models.EntityModels;
using LearningSystem.Models.ViewModels.Courses;

namespace LearningSystem.Services
{
    public class HomeService : Service
    {
        public IEnumerable<CourseViewModel> GetAllCourses()
        {
            IEnumerable<Course> courses =  this.Context.Courses.ToArray();
            IEnumerable<CourseViewModel> cvms = Mapper.Map<IEnumerable<Course>, IEnumerable<CourseViewModel>>(courses);

            return cvms;
        }
    }
}
