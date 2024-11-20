using Microsoft.AspNetCore.Mvc;
using RepositoryDesignPattern.Core.Entities;
using RepositoryDesignPattern.Data.Contexts;
using RepositoryDesignPattern.Web.Models;
using System.Diagnostics;

namespace RepositoryDesignPattern.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly AppDbContext _appDbContext;



        public HomeController(ILogger<HomeController> logger, AppDbContext appDbContext)
        {
            _logger = logger;
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            return View(new Employee());
        }

        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            _appDbContext.Employees.Add(employee);
            _appDbContext.SaveChanges();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
