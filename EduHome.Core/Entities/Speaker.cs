using System.ComponentModel.DataAnnotations;
using EduHome.Core.Interfaces;

namespace EduHome.Core.Entities;

public class Speaker : IEntity
{
    public int Id { get; set; }

    public string Fullname { get; set; } = null!;

    public string Position { get; set; } = null!;

    public string WorkPlace { get; set; } = null!;

    public string ImagePath { get; set; } = null!;

    public int EventDetailId { get; set; }
    public EventDetail EventDetail { get; set; }
}
