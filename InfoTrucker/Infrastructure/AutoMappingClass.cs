using AutoMapper;
using InfoTrucker.DTO;
using InfoTrucker.Entities;

namespace InfoTrucker.Infrastructure
{
    public class AutoMappingClass : Profile
    {
        public AutoMappingClass()
        {
            CreateMap<PersonListForSmsDTO, Person>().ReverseMap()
                .ForMember(dest => dest.FullName, opts => opts.MapFrom(src => src.FName + " " + src.LName));

            CreateMap<PersonListReportDTO, Person>().ReverseMap();
            CreateMap<PersonListForSms, Person>().ReverseMap()
                .ForMember(dest => dest.FullName, opts => opts.MapFrom(src => src.FName + " " + src.LName));
            CreateMap<NewPersonDTO, Person>().ReverseMap();
            CreateMap<Person, PersonListForEditDTO>().
                ForMember(dest => dest.FullName, opts => opts.MapFrom(src => src.FName + " " + src.LName));
        }
    }
}