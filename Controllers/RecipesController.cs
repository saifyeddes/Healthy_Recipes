using Microsoft.AspNetCore.Mvc;
using Healthy_Recipes.Data;
using System.Linq;

namespace Healthy_Recipes.Controllers
{
    public class RecipesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RecipesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(string category)
        {
            var recipes = _context.Recipes.AsQueryable();
            if (!string.IsNullOrEmpty(category))
            {
                recipes = recipes.Where(r => r.Category == category);
            }
            return View(recipes.ToList());
        }

        public IActionResult Details(int id)
        {
            var recipe = _context.Recipes.Find(id);
            if (recipe == null)
            {
                return NotFound();
            }
            return View(recipe);
        }
    }
}