using System.ComponentModel.DataAnnotations;
using EduHome.Core.Interfaces;

namespace EduHome.Core.Entities;

public class NoticeRight : IEntity
{
    public int Id { get; set; }
    [Required]
    public string? Title { get; set; }
    public string? Description { get; set; }

}