﻿using EduHome.Core.Entities;
using EduHome.UI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EduHome.UI.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _context;

    public HomeController(AppDbContext context)
    {
        _context = context;
    }
    public async Task<IActionResult> Index()
    {
        HomeVM homeVM = new()
        {
            Sliders = await _context.Sliders.ToListAsync(),
            NoticeBoards = await _context.NoticeBoards.ToListAsync(),
            NoticeRights = await _context.NoticeRights.ToListAsync(),
            Chooses = await _context.Chooses.ToListAsync(),
            Courses = await _context.Courses.ToListAsync(),
            Events = await _context.Events.ToListAsync(),
            Blogs = await _context.Blogs.ToListAsync(),
            Testimonials = await _context.Testimonials.ToListAsync()

        };
        return View(homeVM);
    }
}

