﻿using EduHome.Core.Entities;

using System;
using EduHome.Core.Entities;

namespace EduHome.UI.ViewModels;

public class AboutVM
{
    public IEnumerable<About> Abouts { get; set; }
    public IEnumerable<Teacher> Teachers { get; set; }
}

