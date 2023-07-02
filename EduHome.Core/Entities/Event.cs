using System.ComponentModel.DataAnnotations;
using EduHome.Core.Interfaces;

namespace EduHome.Core.Entities;

public class Event : IEntity
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    [DisplayFormat(DataFormatString = "{DD/MM:0}", ApplyFormatInEditMode = true)]
    [DataType(DataType.Time)]
    public DateTime Date { get; set; }

    public string Month { get; set; }

    [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true)]
    [DataType(DataType.Time)]
    public DateTime Start { get; set; }


    [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true)]
    [DataType(DataType.Time)]
    public DateTime End { get; set; }

    public string Location { get; set; } = null!;
}
