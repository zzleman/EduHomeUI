using System.ComponentModel.DataAnnotations;

namespace EduHome.UI.Areas.EduHomeAdmin.ViewModels.SliderViewModels;

public class SliderPostVM
{
    [Required(ErrorMessage = "Title Section cannoot be empty!"), StringLength(250)]
    public string ImageBGPath { get; set; } = null!;

    [Required, StringLength(50)]
    public string Title { get; set; } = null!;

    public string SecondTitle { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string More { get; set; } = null!;
}

