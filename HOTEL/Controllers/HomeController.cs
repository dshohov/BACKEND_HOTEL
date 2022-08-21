using HOTEL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace HOTEL.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationContext db;
        public HomeController(ApplicationContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(Tour tour)
        {
            db.Tour.Add(tour);
            await db.SaveChangesAsync();
            return View();
        }
        public async Task<IActionResult> AdminTable()
        {
            return View(await db.Tour.ToListAsync());
        }


    }
}