using EduHome.Core.Interfaces;

namespace EduHome.Core.Entities;

public class Slider:IEntity
{
	public int Id { get; set; } 

    public string ImageBGPath{ get; set; } = null!;

    public string Title { get; set; } = null!;

    public string SecondTitle { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string More { get; set; } = null!;
}

