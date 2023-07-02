using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduHome.UI.Areas.EduHomeAdmin.ViewModels.TestimonialViewModels;

public class TestimonialPostVM
{
    public int Id { get; set; }

    public string Fullname { get; set; } = null!;

    public string Position { get; set; }

    public string Profession { get; set; }

    public string Description { get; set; } = null!;

    public string ImagePath { get; set; } = null!;
}



