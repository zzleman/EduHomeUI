using System.ComponentModel.DataAnnotations;
using EduHome.Core.Interfaces;

namespace EduHome.Core.Entities;

public class Blog : IEntity
{
    public int Id { get; set; }

    public string Blogger { get; set; } = null!;

    public DateTime PostTime { get; set; }

    public int Comments { get; set; }

    public string Description { get; set; } = null!;

    public string ImagePath { get; set; } = null!;
}
