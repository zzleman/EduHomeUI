using System.ComponentModel.DataAnnotations;
using EduHome.Core.Interfaces;

namespace EduHome.Core.Entities;

public class NoticeBoard : IEntity
{
    public int Id { get; set; }
    [Required]
    public DateTime Date { get; set; }
    [Required,MaxLength(300)]
    public string Info { get; set; } = null!;
}

