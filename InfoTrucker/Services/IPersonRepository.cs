using System.Data.Entity;
using InfoTrucker.Entities;
using InfoTrucker.Infrastructure;
using InfoTrucker.Models;

namespace InfoTrucker.Services
{
    public interface IPersonRepository : IRepositoryBase<Person>
    {

    }

    public class PersonRepository : RepositoryBase<Person>, IPersonRepository
    {
        public PersonRepository(DbContext context) : base(context)
        {

        }





    }
}