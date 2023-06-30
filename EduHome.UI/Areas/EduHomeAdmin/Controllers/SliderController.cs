using EduHome.Core.Entities;
using EduHome.UI.Areas.EduHomeAdmin.ViewModels.SliderViewModels;
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
    public async Task<IActionResult> Create(SliderPostVM sliderPost) 
    {
        if (!ModelState.IsValid)
        {
            return View();
        }
        Slider slider = new()
        {
            Title = sliderPost.Title,
            SecondTitle = sliderPost.SecondTitle,
            Description = sliderPost.Description,
            More = sliderPost.More,
            ImageBGPath = sliderPost.ImageBGPath
        };
        await _context.Sliders.AddAsync(slider);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Delete(int Id)
    {
        Slider? sliderdb = await _context.Sliders.FindAsync(Id);
        if (sliderdb == null)
        {
            return NotFound();
        }
        return View(sliderdb);
    }

}

