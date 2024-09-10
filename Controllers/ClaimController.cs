using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace PROG6212_POEPART1.Controllers
{
    public class ClaimController : Controller
    {
        private readonly Data.AppDbContext _context;

        public ClaimController(Data.AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Claim()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Claim(Claim claim)
        {
            if (ModelState.IsValid)
            {
                _context.Add(claim);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(claim);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
