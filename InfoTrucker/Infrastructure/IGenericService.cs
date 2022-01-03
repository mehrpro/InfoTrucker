using System;
using System.Collections.Generic;

namespace InfoTrucker.Infrastructure
{
    public interface IGenericService<T>: IDisposable where T : class
    {        
        void Add(T entity);
        //void Update(T entity);
        void Delete(T entity);
        T Find(Func<T, bool> predicate);
        IList<T> GetAll();
        IList<T> GetAll(Func<T, bool> predicate);
    }
}