using EduHome.Core.Entities;

using System;
using EduHome.Core.Entities;

namespace EduHome.UI.ViewModels;

public class EventDetailVM
{
    public Event Event { get; set; }
    public IEnumerable<EventDetail> EventDetail { get; set; } = null!;
    public IEnumerable<Speaker> Speakers { get; set; } = null!;
}

