using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Windows.Documents;
using InfoTrucker.Entities;
using InfoTrucker.Infrastructure;

namespace InfoTrucker.Services
{
    public interface IPersonRepository
    {
        void Insert(Person person);
        IEnumerable<Person> GetAllEnumerable();
        Task<int> LastPersonID();
        Task Update(Person person);
        List<Person> PersonsListSending();
        Person Get(Expression<Func<Person, bool>> expression);

        Person GetById(int id);
        //Person Get(Func<Person, bool> predicate);
    }

    public class PersonRepository : IPersonRepository
    {
        private readonly IUnitofWork _unitofWork;
        private readonly IDbSet<Person> _persons;

        public PersonRepository(IUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;
            _persons = _unitofWork.Set<Person>();
        }


        public void Insert(Person person)
        {
            _persons.Add(person);
        }

        public IEnumerable<Person> GetAllEnumerable()
        {
            return _persons.AsEnumerable();
        }

        public async Task<int> LastPersonID()
        {
            var rangeID = Enumerable.Range(1220001, 9998);
            var personIdQuery = await _persons.ToListAsync();
            personIdQuery.ToArray();
            personIdQuery.Sort();
            var result = personIdQuery.Select(x => x.PersonID);
            if (result.Count() > 9998) return 0;
            if (result.Count() > 0) return rangeID.Except(result).Min();
            return 1220001;
        }

        public async Task Update(Person person)
        {
            var local = await _persons.FirstOrDefaultAsync(x => x.ID == person.ID);
            //Change(local, local == null);
        }

        public List<Person> PersonsListSending()
        {
            return _persons.ToList();
        }

        public Person Get(Expression<Func<Person, bool>> expression)
        {
            return _persons.FirstOrDefault(expression);
        }

        public Person GetById(int id)
        {
            return _persons.Find(id);
        }
    }
}