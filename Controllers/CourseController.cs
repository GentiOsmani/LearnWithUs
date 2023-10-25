using MenagmentSystem.Data;
using MenagmentSystem.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MenagmentSystem.Entities;
using System.Security.Authentication;

namespace MenagmentSystem.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }

        private readonly MSDbContext _context;
        public CourseController(MSDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult Search(string SearchInput)
        {
            var courses = _context.Courses
                    .Where(x => x.Name.ToLower().Contains(SearchInput.ToLower()))
                    .ToList();

            var model = new CourseViewModel
            {
                Courses = courses
            };

            return View("Index", model);
        }

        public IActionResult Edit() { return View(); }

        //create a variable that stores the search string
        //search for the courses where x.name.tolowercase.contain(variable).
        //return as a list
        //show the list as display
    }
}
