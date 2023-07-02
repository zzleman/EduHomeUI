using AutoMapper;
using EduHome.Core.Entities;
using EduHome.UI.Areas.EduHomeAdmin.ViewModels.EventViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EduHome.UI.Areas.EduHomeAdmin.Controllers;
[Area("EduHomeAdmin")]

public class EventController : Controller
{
    private readonly AppDbContext _context;
    private readonly IMapper _mapper;

    public EventController(AppDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<IActionResult> Index()
    {
        return View(await _context.Events.ToListAsync());
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [AutoValidateAntiforgeryToken]
    public async Task<IActionResult> Create(EventPostVM eventPost)
    {
        if (!ModelState.IsValid)
        {
            return View();
        }
        Event evnt = _mapper.Map<Event>(eventPost);
        await _context.Events.AddAsync(evnt);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Delete(int Id)
    {
        Event? eventDb = await _context.Events.FindAsync(Id);
        if (eventDb == null)
        {
            return NotFound();
        }
        return View(eventDb);
    }

    [HttpPost]
    [ActionName("Delete")]
    [AutoValidateAntiforgeryToken]
    public async Task<IActionResult> DeletePost(int Id)
    {
        Event? eventDb = await _context.Events.FindAsync(Id);
        if (eventDb == null)
        {
            return NotFound();
        }
        _context.Events.Remove(eventDb);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }


    public async Task<IActionResult> Update(int Id)
    {
        Event? eventDb = await _context.Events.FindAsync(Id);
        if (eventDb == null)
        {
            return NotFound();
        }
        return View(eventDb);
    }

    [HttpPost]
    [AutoValidateAntiforgeryToken]
    public async Task<IActionResult> Update(int Id, Event evnt)
    {
        if (Id != evnt.Id)
        {
            return BadRequest();
        }
        if (!ModelState.IsValid)
        {
            return View(evnt);
        }
        Event? eventDb = await _context.Events.AsNoTracking().FirstOrDefaultAsync(e => e.Id == Id);
        if (eventDb == null)
        {
            return NotFound();
        }
        _context.Entry<Event>(evnt).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

}