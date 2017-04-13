using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningSystem.Models.EntityModels;
using Microsoft.VisualBasic.ApplicationServices;

namespace LearningSystem.Services
{
    public class AccountService : Service
    {
        public void CreateStudent(ApplicationUser user)
        {
            Student student = new Student();
            student.User = user;
            this.Context.Students.Add(student);
        }
    }
}
