using EduHome.Core.Entities;
using EduHome.UI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EduHome.UI.Controllers;

public class BlogDetailController : Controller
{
    private readonly AppDbContext _context;

    public BlogDetailController(AppDbContext context)
    {
        _context = context;
    }
    public async Task<IActionResult> Index()
    {
        BlogDetailVM blogDetailVM = new()
        {
            BlogDetail = await _context.BlogDetail.ToListAsync()

        };
        return View(blogDetailVM);
    }
}

