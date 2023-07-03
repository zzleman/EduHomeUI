using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EduHome.Core.Interfaces;

namespace EduHome.Core.Entities;

public class EventDetail : IEntity
{
    public int Id { get; set; }

    public string Venue { get; set; }

    public string Description { get; set; }

    public int EventId { get; set; }

    public Event Event { get; set; }
}
