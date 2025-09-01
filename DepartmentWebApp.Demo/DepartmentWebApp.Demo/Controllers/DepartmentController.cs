using DepartmentWebApp.Demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace DepartmentWebApp.Demo.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly AppDbContext _context;

        public DepartmentController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var department = _context.DepSet.ToList();
            return View(department);
        }
    }
}
