using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using LearningSystem.Models.ViewModels.Courses;

namespace LearningSystem.Models.ViewModels.Users
{
    public class UserProfileViewModel
    {
        public string Name { get; set; }

        public string Email { get; set; }

        [Display(Name = "Birth Date")]
        public DateTime BirthDate { get; set; }

        public IEnumerable<UsersCourseViewMode> Courses { get; set; }
    }
}
