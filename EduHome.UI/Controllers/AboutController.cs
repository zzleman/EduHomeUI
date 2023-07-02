using EduHome.Core.Entities;
using EduHome.UI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EduHome.UI.Controllers;

public class AboutController : Controller
{
    private readonly AppDbContext _context;

    public AboutController(AppDbContext context)
    {
        _context = context;
    }
    public async Task<IActionResult> Index()
    {
        AboutVM aboutVM = new()
        {
            Abouts = await _context.Abouts.ToListAsync(),
            Teachers = await _context.Teachers.ToListAsync()

        };
        return View(aboutVM);
    }
}

