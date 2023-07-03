using EduHome.Core.Entities;
using EduHome.UI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EduHome.UI.Controllers;

public class EventDetailController : Controller
{
    private readonly AppDbContext _context;

    public EventDetailController(AppDbContext context)
    {
        _context = context;
    }
    public async Task<IActionResult> Index(int Id)
    {
        var evnt = await _context.Events.FindAsync(Id);
        var eventDetails = await _context.EventDetail.Where(e => e.EventId == Id).ToListAsync();
        var speakers = await _context.Speakers.Include(s => s.EventDetail).Where(s => s.EventDetail.EventId == Id).ToListAsync();

        var eventDetailVM = new EventDetailVM
        {
            Event = evnt,
            EventDetail = eventDetails,
            Speakers = speakers
        };

        return View(eventDetailVM);
    }
}

