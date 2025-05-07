using Microsoft.AspNetCore.Identity;

namespace Healthy_Recipes.Models
{
    public class Users : IdentityUser 
    {
        public string FullName { get; set; }
    }
}
