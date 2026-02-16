using Asp.NetPractice10.Data;
using Asp.NetPractice10.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Asp.NetPractice10.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationContext _context;
        public HomeController(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Users.ToListAsync());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
