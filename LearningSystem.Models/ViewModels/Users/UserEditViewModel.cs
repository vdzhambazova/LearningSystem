using System.ComponentModel.DataAnnotations;

namespace LearningSystem.Models.ViewModels.Users
{
    public class UserEditViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }
    }
}
