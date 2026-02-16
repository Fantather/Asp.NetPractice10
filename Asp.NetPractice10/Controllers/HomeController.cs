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

        public async Task<IActionResult> Details(int? id)
        {
            if (id != null)
            {
                var currentUser = await _context.Users.FirstOrDefaultAsync(p => p.Id == id);
                if (currentUser != null)
                {
                    return View(currentUser);
                }
            }
            return NotFound();
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id != null)
            {
                var currentUser = await _context.Users.FirstOrDefaultAsync(p => p.Id == id);
                if (currentUser != null)
                {
                    return View(currentUser);
                }
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(User user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        [ActionName("Delete")]
        public async Task<IActionResult> ConfirmDelete(int? id)
        {
            if (id != null)
            {
                var currentUser = await _context.Users.FirstOrDefaultAsync(p => p.Id == id);
                if (currentUser != null)
                {
                    return View(currentUser);
                }
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                var currentUser = await _context.Users.FirstOrDefaultAsync(p => p.Id == id);
                if (currentUser != null)
                {
                    _context.Users.Remove(currentUser);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            return NotFound();
        }
    }
}
