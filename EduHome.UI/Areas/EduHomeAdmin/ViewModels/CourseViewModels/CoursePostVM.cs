using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduHome.UI.Areas.EduHomeAdmin.ViewModels.CourseViewModels;

public class CoursePostVM
{

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string ImagePath { get; set; } = null!;
}



