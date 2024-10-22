using AutoMapper;
using LessonForControllers.Dtos;
using LessonForControllers.Models;

namespace LessonForControllers.Profiles;

public class TeacherProfile : Profile
{
    public TeacherProfile()
    {
        CreateMap<TeacherDto, Teacher>().ReverseMap();
        CreateMap<Teacher,TeacherGetDto>().ReverseMap();
    }
}                        // <---
//_mapper.Map<cevirceyim tip>(neyi cevirirem onu)