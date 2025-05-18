using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Healthy_Recipes.Models
{
    public class Users : IdentityUser 
    {
        [Required]
        public string FullName { get; set; } = string.Empty;
    }
}
