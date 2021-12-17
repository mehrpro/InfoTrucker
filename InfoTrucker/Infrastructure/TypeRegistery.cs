using AutoMapper;
using AutoMapper.Configuration;
using InfoTrucker.Models;
using StructureMap;

namespace InfoTrucker.Infrastructure
{
    public class TypeRegistery : Registry

    {
        public TypeRegistery()
        {
            For<UnitofWork<AppDbContext>>();
            var mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(typeof(AutoMappingClass));
            });
            var mapper = mapperConfiguration.CreateMapper();
            For<IMapper>().Use(mapper);


        }
    }
}