
using AutoMapper;
using EduHome.Core.Entities;
using EduHome.UI.Areas.EduHomeAdmin.ViewModels.CourseViewModels;

namespace EduHome.UI.Mappers;

public class BlogProfile : Profile
{
    public BlogProfile()
    {
        CreateMap<CoursePostVM, Course>().ReverseMap();
    }
}



