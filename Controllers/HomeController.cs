using Microsoft.AspNetCore.Mvc;
using Healthy_Recipes.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Healthy_Recipes.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var recipes = _context.Recipes.ToList();
            return View(recipes);
        }

        public IActionResult About()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Subscribe(string email)
        {
            // TODO: Implémenter la logique d'inscription à la newsletter
            return RedirectToAction("Index");
        }
    }
}