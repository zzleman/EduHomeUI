using AutoMapper;
using EduHome.Core.Entities;
using EduHome.UI.Areas.EduHomeAdmin.ViewModels.CourseViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EduHome.UI.Areas.EduHomeAdmin.Controllers;
[Area("EduHomeAdmin")]

public class CourseController : Controller
{
    private readonly AppDbContext _context;
    private readonly IMapper _mapper;

    public CourseController(AppDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<IActionResult> Index()
    {
        return View(await _context.Courses.ToListAsync());
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [AutoValidateAntiforgeryToken]
    public async Task<IActionResult> Create(CoursePostVM coursePost)
    {
        if (!ModelState.IsValid)
        {
            return View();
        }
        Course course = _mapper.Map<Course>(coursePost);
        await _context.Courses.AddAsync(course);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Delete(int Id)
    {
        Course? courseDb = await _context.Courses.FindAsync(Id);
        if (courseDb == null)
        {
            return NotFound();
        }
        return View(courseDb);
    }

    [HttpPost]
    [ActionName("Delete")]
    [AutoValidateAntiforgeryToken]
    public async Task<IActionResult> DeletePost(int Id)
    {
        Course? courseDb = await _context.Courses.FindAsync(Id);
        if (courseDb == null)
        {
            return NotFound();
        }
        _context.Courses.Remove(courseDb);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }


    public async Task<IActionResult> Update(int Id)
    {
        Course? courseDb = await _context.Courses.FindAsync(Id);
        if (courseDb == null)
        {
            return NotFound();
        }
        return View(courseDb);
    }

    [HttpPost]
    [AutoValidateAntiforgeryToken]
    public async Task<IActionResult> Update(int Id, Course course)
    {
        if (Id != course.Id)
        {
            return BadRequest();
        }
        if (!ModelState.IsValid)
        {
            return View(course);
        }
        Course? courseDb = await _context.Courses.AsNoTracking().FirstOrDefaultAsync(c => c.Id == Id);
        if (courseDb == null)
        {
            return NotFound();
        }
        _context.Entry<Course>(course).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

}