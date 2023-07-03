using System.ComponentModel.DataAnnotations;
using EduHome.Core.Interfaces;

namespace EduHome.Core.Entities;

public class Course : IEntity
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string ImagePath { get; set; } = null!;

    public CourseDetail CourseDetailId { get; set; }
}
