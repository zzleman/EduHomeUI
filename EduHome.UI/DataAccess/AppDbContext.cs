﻿
using EduHome.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace EduHome.UI;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<Slider> Sliders { get; set; } = null!;
    public DbSet<NoticeBoard> NoticeBoards { get; set; } = null!;
    public DbSet<NoticeRight> NoticeRights { get; set; } = null!;
    public DbSet<Choose> Chooses { get; set; } = null!;
    public DbSet<Course> Courses { get; set; } = null!;
    public DbSet<Event> Events { get; set; } = null!;
    public DbSet<Blog> Blogs { get; set; } = null!;
    public DbSet<Testimonial> Testimonials { get; set; } = null!;
    public DbSet<About> Abouts { get; set; } = null!;
    public DbSet<Teacher> Teachers { get; set; } = null!;
    public DbSet<CourseDetail> CourseDetail { get; set; } = null!;
    public DbSet<EventDetail> EventDetail { get; set; } = null!;
    public DbSet<Speaker> Speakers { get; set; } = null!;
    public DbSet<BlogDetail> BlogDetail { get; set; } = null!;
}

