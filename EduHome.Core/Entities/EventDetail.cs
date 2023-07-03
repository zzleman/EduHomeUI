using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EduHome.Core.Interfaces;

namespace EduHome.Core.Entities;

public class EventDetail : IEntity
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Venue { get; set; } = null!;

    public string Time { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string MainImgPath { get; set; } = null!;

    public DateTime Date { get; set; }

    public int EventId { get; set; }

    public Event Event { get; set; }

    public ICollection<Speaker> Speakers { get; set; }
}
