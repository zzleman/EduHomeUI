
using AutoMapper;
using EduHome.Core.Entities;
using EduHome.UI.Areas.EduHomeAdmin.ViewModels.BlogViewModels;

namespace EduHome.UI.Mappers;

public class TestimonialProfile : Profile
{
    public TestimonialProfile()
    {
        CreateMap<TestimonialPostVM, Testimonial>().ReverseMap();
    }
}




