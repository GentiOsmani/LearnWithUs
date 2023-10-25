using MenagmentSystem.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MenagmentSystem.Controllers
{
    public class UserController : Controller
    {
        private readonly MSDbContext context;

        public UserController(MSDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Profile()
        {
            var userEmail = User.Identity.Name;
            var user = await context.Users.FirstOrDefaultAsync(x => x.Email == userEmail);
            return View(user);
        }

        //
    }
}
