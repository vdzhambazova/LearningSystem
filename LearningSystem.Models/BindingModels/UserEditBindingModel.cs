using System.ComponentModel.DataAnnotations;

namespace LearningSystem.Models.BindingModels
{
    public class UserEditBindingModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }
    }
}
