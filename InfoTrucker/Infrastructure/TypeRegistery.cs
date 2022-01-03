using AutoMapper;
using AutoMapper.Configuration;
using InfoTrucker.Models;
using InfoTrucker.Services;
using StructureMap;

namespace InfoTrucker.Infrastructure
{
    public class TypeRegistery : Registry

    {
        public TypeRegistery()
        {
            For<IUnitofWork>().Use<AppDbContext>();
            For<IApplicationUserRepository>().Use<ApplicationUserRepository>();
            For<ICleamRepository>().Use<CleamRepository>();
            For<IExceptionSms>().Use<ExcptionSms>();
            For<IMenuGroupRepository>().Use<MenuGroupRepository>();
            For<IMenuItemRepository>().Use<MenuItemRepository>();
            For<IMessageGroupSubjectRepository>().Use<MessageGroupSubjectRepository>();
            For<IPersonRepository>().Use<PersonRepository>();
            For<IPublicTypeRepository>().Use<PublicTypeRepository>();
            For<ISendMessageRepository>().Use<SendMessageRepository>();
            For<ISmsConfigureRepository>().Use<SmsConfigureRepository>();

            var mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(typeof(AutoMappingClass));
            });
            var mapper = mapperConfiguration.CreateMapper();
            For<IMapper>().Use(mapper);


        }
    }
}