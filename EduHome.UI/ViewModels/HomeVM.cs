﻿using System;
using EduHome.Core.Entities;

namespace EduHome.UI.ViewModels;

public class HomeVM
{
    public IEnumerable<Slider> Sliders { get; set; }
    public IEnumerable<NoticeBoard> NoticeBoards { get; set; }
    public IEnumerable<NoticeRight> NoticeRights { get; set; }
    public IEnumerable<Choose> Chooses { get; set; }
    public IEnumerable<Course>  Courses { get; set; }
    public IEnumerable<Event> Events { get; set; }
    public IEnumerable<Blog> Blogs { get; set; }
    public IEnumerable<Testimonial> Testimonials { get; set; }
}

