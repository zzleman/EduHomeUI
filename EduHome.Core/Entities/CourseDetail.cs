using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EduHome.Core.Interfaces;

namespace EduHome.Core.Entities;

public class CourseDetail : IEntity
{
    public int Id { get; set; }

    public DateTime StartDate { get; set; }

    public string Duration { get; set; } = null!;

    public string ClassDuration { get; set; } = null!;

    public string Skill { get; set; }

    public string Language { get; set; }

    public int Students { get; set; }

    public string Assessments { get; set; }

    public int Fee { get; set; }

    public Course Course { get; set; }

    public int CourseId { get; set; }
}
