using System.ComponentModel.DataAnnotations;
using EduHome.Core.Interfaces;

namespace EduHome.Core.Entities;

public class Teacher : IEntity
{
    public int Id { get; set; }

    public string Fullname { get; set; } = null!;

    public string Profession { get; set; } = null!;

    public string ImagePath { get; set; } = null!;
}
