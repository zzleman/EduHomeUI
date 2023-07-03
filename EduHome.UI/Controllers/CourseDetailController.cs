using EduHome.Core.Entities;
using EduHome.UI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EduHome.UI.Controllers;

public class CourseDetailController : Controller
{
    private readonly AppDbContext _context;

    public CourseDetailController(AppDbContext context)
    {
        _context = context;
    }
    public async Task<IActionResult> Index()
    {
        CourseDetailVM courseDetailVM = new()
        {
            CourseDetail = await _context.CourseDetail.ToListAsync()

        };
        return View(courseDetailVM);
    }
}

