using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using InfoTrucker.DTO;
using InfoTrucker.Entities;
using InfoTrucker.Infrastructure;
using InfoTrucker.Models;

namespace InfoTrucker.Services
{
    public interface IPersonRepository : IRepositoryBase<Person>
    {
        Task<int> LastPersonID();
    }

    public class PersonRepository : RepositoryBase<Person>, IPersonRepository
    {
        public PersonRepository(DbContext context) : base(context)
        {

        }


        public async Task<int> LastPersonID()
        {
            var rangeID = Enumerable.Range(1220001, 9998);
            var personIdQuery = await GetAllAsync();
            personIdQuery.ToArray();
            personIdQuery.Sort();
            var result = personIdQuery.Select(x => x.PersonID);
            if (result.Count() > 9998) return 0;
            if (result.Count() > 0) return rangeID.Except(result).Min();
            return 1220001;
        }

    }
}