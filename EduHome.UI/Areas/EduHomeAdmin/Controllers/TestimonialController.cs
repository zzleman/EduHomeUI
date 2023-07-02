using AutoMapper;
using EduHome.Core.Entities;
using EduHome.UI.Areas.EduHomeAdmin.ViewModels.TestimonialViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EduHome.UI.Areas.EduHomeAdmin.Controllers;
[Area("EduHomeAdmin")]

public class TestimonialController : Controller
{
    private readonly AppDbContext _context;
    private readonly IMapper _mapper;

    public TestimonialController(AppDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<IActionResult> Index()
    {
        return View(await _context.Testimonials.ToListAsync());
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [AutoValidateAntiforgeryToken]
    public async Task<IActionResult> Create(TestimonialPostVM testimonialPost)
    {
        if (!ModelState.IsValid)
        {
            return View();
        }
        Testimonial testimonial = _mapper.Map<Testimonial>(testimonialPost);
        await _context.Testimonials.AddAsync(testimonial);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Delete(int Id)
    {
        Testimonial? testimonialDb = await _context.Testimonials.FindAsync(Id);
        if (testimonialDb == null)
        {
            return NotFound();
        }
        return View(testimonialDb);
    }

    [HttpPost]
    [ActionName("Delete")]
    [AutoValidateAntiforgeryToken]
    public async Task<IActionResult> DeletePost(int Id)
    {
        Testimonial? testimonialDb = await _context.Testimonials.FindAsync(Id);
        if (testimonialDb == null)
        {
            return NotFound();
        }
        _context.Testimonials.Remove(testimonialDb);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }


    public async Task<IActionResult> Update(int Id)
    {
        Testimonial? testimonialDb = await _context.Testimonials.FindAsync(Id);
        if (testimonialDb == null)
        {
            return NotFound();
        }
        return View(testimonialDb);
    }

    [HttpPost]
    [AutoValidateAntiforgeryToken]
    public async Task<IActionResult> Update(int Id, Testimonial testimonial)
    {
        if (Id != testimonial.Id)
        {
            return BadRequest();
        }
        if (!ModelState.IsValid)
        {
            return View(testimonial);
        }
        Testimonial? testimonialDb = await _context.Testimonials.AsNoTracking().FirstOrDefaultAsync(t => t.Id == Id);
        if (testimonialDb == null)
        {
            return NotFound();
        }
        _context.Entry<Testimonial>(testimonial).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

}