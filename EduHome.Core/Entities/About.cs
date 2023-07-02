using System.ComponentModel.DataAnnotations;
using EduHome.Core.Interfaces;

namespace EduHome.Core.Entities;

public class About : IEntity
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string AltDescription { get; set; }

    public string ImagePath { get; set; } = null!;
}

