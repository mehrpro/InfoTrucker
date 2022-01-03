using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using InfoTrucker.Infrastructure;

namespace InfoTrucker.Services
{
    public class GenericService<TEntity> : IGenericService<TEntity>
        where TEntity : class
    {
        private IUnitOfWork _uow;
        private IDbSet<TEntity> _tEntities;

        public GenericService(IUnitOfWork uow)
        {
            _uow = uow;
            _tEntities = _uow.Set<TEntity>();
        }


        public virtual void Add(TEntity entity)
        {
            _tEntities.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            _tEntities.Remove(entity);
        }

        public TEntity Find(Func<TEntity, bool> predicate)
        {
            return _tEntities.Where(predicate).FirstOrDefault();
        }

        public IList<TEntity> GetAll()
        {
            return _tEntities.ToList();
        }

        public IList<TEntity> GetAll(Func<TEntity, bool> predicate)
        {
            return _tEntities.Where(predicate).ToList();
        }

        #region IDisposable Members
        public void Dispose()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}