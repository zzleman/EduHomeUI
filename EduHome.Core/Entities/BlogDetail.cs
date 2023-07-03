using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EduHome.Core.Interfaces;

namespace EduHome.Core.Entities;

public class BlogDetail : IEntity
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public Blog Blog { get; set; }

    public int BlogId { get; set; }
}
