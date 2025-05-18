using System.ComponentModel.DataAnnotations;

namespace Healthy_Recipes.ViewModels
{
    public class VerifyEmailViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
    }
}