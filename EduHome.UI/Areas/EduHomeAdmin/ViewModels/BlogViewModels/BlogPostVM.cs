using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduHome.UI.Areas.EduHomeAdmin.ViewModels.BlogViewModels;

public class BlogPostVM
{
    public int Id { get; set; }

    public string Blogger { get; set; } = null!;

    public DateTime PostTime { get; set; }

    public int Comments { get; set; }

    public string Description { get; set; } = null!;

    public string ImagePath { get; set; } = null!;
}



