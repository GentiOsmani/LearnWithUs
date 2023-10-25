using MenagmentSystem.Data;
using MenagmentSystem.Entities;
using MenagmentSystem.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace MenagmentSystem.Controllers
{
    public class AccountController : Controller
    {
        private readonly MSDbContext _context;
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;

        public AccountController(MSDbContext context, UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _context = context;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        #region LOGIN
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            var user = await userManager.FindByEmailAsync(model.Email);
            var signin = await userManager.CheckPasswordAsync(user, model.Password);
            if (signin)
            {
                await signInManager.SignInAsync(user, false);
                return RedirectToAction("Index", "Course");
            }

            return View();
        }
        #endregion

        #region REGISTER
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            /*if (ModelState.IsValid)
            {
                // Passwords match, you can proceed with registration.
                // Your registration logic here.
                return RedirectToAction("Success"); // or any other action you want to redirect to.
            }*/

            var address = new Address
            {
                City = model.City,
                Street = model.Address
            };
            _context.Addresses.Add(address);
            _context.SaveChanges();
            var test1 = _context.Addresses.OrderByDescending(x => x.Id).Select(x => x.Id).FirstOrDefault();
            var user = new User
            {
                ProfilPicture = "http://",
                Age = model.Age,
                Email = model.Email,
                LastName = model.LastName,
                UserName = model.Email,
                Name = model.Name,
                Address = model.Address,
                City = model.City,
            };
            var test = await userManager.CreateAsync(user, model.Password);

            return RedirectToAction("Login", "Account");
        }
        #endregion
        [HttpGet]
        public async Task<IActionResult> SignOut()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

    }
}
