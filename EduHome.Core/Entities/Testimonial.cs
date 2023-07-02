using System.ComponentModel.DataAnnotations;
using EduHome.Core.Interfaces;

namespace EduHome.Core.Entities;

public class Testimonial : IEntity
{
    public int Id { get; set; }

    public string Fullname { get; set; } = null!;

    public string Position { get; set; }

    public string Profession { get; set; }

    public string Description { get; set; } = null!;

    public string ImagePath { get; set; } = null!;
}
