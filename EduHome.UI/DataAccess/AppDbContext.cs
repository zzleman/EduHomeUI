﻿
using EduHome.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace EduHome.UI;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<Slider> Sliders { get; set; } = null!;
}

