
using AutoMapper;
using EduHome.Core.Entities;
using EduHome.UI.Areas.EduHomeAdmin.ViewModels.CourseViewModels;

namespace EduHome.UI.Mappers;

public class CourseProfile : Profile
{
    public CourseProfile()
    {
        CreateMap<CoursePostVM, Course>().ReverseMap();
    }
}

