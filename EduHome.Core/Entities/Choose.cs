using System.ComponentModel.DataAnnotations;
using EduHome.Core.Interfaces;

namespace EduHome.Core.Entities;

public class Choose : IEntity
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string AltTitle { get; set; } = null!;
}

