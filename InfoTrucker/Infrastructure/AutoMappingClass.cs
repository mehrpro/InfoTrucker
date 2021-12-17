using AutoMapper;
using InfoTrucker.DTO;
using InfoTrucker.Entities;

namespace InfoTrucker.Infrastructure
{
    public class AutoMappingClass : Profile
    {
        public AutoMappingClass()
        {
            CreateMap<NewPersonDTO, Person>().ReverseMap();
        }
    }
}