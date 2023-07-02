using AutoMapper;
using EduHome.Core.Entities;
using EduHome.UI.Areas.EduHomeAdmin.ViewModels.BlogViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EduHome.UI.Areas.EduHomeAdmin.Controllers;
[Area("EduHomeAdmin")]

public class BlogController : Controller
{
    private readonly AppDbContext _context;
    private readonly IMapper _mapper;

    public BlogController(AppDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<IActionResult> Index()
    {
        return View(await _context.Blogs.ToListAsync());
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [AutoValidateAntiforgeryToken]
    public async Task<IActionResult> Create(BlogPostVM blogPost)
    {
        if (!ModelState.IsValid)
        {
            return View();
        }
        Blog blog = _mapper.Map<Blog>(blogPost);
        await _context.Blogs.AddAsync(blog);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Delete(int Id)
    {
        Blog? blogdb = await _context.Blogs.FindAsync(Id);
        if (blogdb == null)
        {
            return NotFound();
        }
        return View(blogdb);
    }

    [HttpPost]
    [ActionName("Delete")]
    [AutoValidateAntiforgeryToken]
    public async Task<IActionResult> DeletePost(int Id)
    {
        Blog? blogdb = await _context.Blogs.FindAsync(Id);
        if (blogdb == null)
        {
            return NotFound();
        }
        _context.Blogs.Remove(blogdb);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }


    public async Task<IActionResult> Update(int Id)
    {
        Blog? blogdb = await _context.Blogs.FindAsync(Id);
        if (blogdb == null)
        {
            return NotFound();
        }
        return View(blogdb);
    }

    [HttpPost]
    [AutoValidateAntiforgeryToken]
    public async Task<IActionResult> Update(int Id, Blog blog)
    {
        if (Id != blog.Id)
        {
            return BadRequest();
        }
        if (!ModelState.IsValid)
        {
            return View(blog);
        }
        Blog? blogdb = await _context.Blogs.AsNoTracking().FirstOrDefaultAsync(b => b.Id == Id);
        if (blogdb == null)
        {
            return NotFound();
        }
        _context.Entry<Blog>(blog).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

}