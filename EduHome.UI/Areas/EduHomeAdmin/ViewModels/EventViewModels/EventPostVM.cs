using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduHome.UI.Areas.EduHomeAdmin.ViewModels.EventViewModels;

public class EventPostVM
{

    public string Title { get; set; } = null!;

    public DateTime Date { get; set; }

    public DateTime End { get; set; }

    public string Location { get; set; } = null!;
}



