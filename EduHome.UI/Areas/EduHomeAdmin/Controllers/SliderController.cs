using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EduHome.UI.Areas.EduHomeAdmin.Controllers;
[Area("EduHomeAdmin")]

public class SliderController : Controller
{
    private readonly AppDbContext _context;

    public SliderController(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        return View(await _context.Sliders.ToListAsync());
    }

    public IActionResult Create() {
        return View();
    }

    [HttpPost]
    public IActionResult Create(string Title, string SecondTitle, string Description, string More, string ImageBGPath)
    {
        return Content($"{Title} {SecondTitle} {Description} {More} {ImageBGPath}");
    }
}

