using AutoMapper;
using InfoTrucker.DTO;
using InfoTrucker.Entities;

namespace InfoTrucker.Infrastructure
{
    public class AutoMappingClass : Profile
    {
        public AutoMappingClass()
        {
            CreateMap<PersonListReportDTO, Person>().ReverseMap();
            CreateMap<NewPersonDTO, Person>().ReverseMap();
            CreateMap<Person, PersonListForEditDTO>().ForMember(dest => dest.FullName, opts => opts.MapFrom(src => src.FName + " " + src.LName));
        }
    }
}