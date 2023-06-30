using System;
using EduHome.Core.Entities;

namespace EduHome.UI.ViewModels;

public class HomeVM
{
    public IEnumerable<Slider> Sliders { get; set; }
    public IEnumerable<NoticeBoard> NoticeBoards { get; set; }
    public IEnumerable<Choose> Chooses { get; set; }
}

