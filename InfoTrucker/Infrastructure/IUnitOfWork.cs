using System;
using System.Data.Entity;
using InfoTrucker.Services;

namespace InfoTrucker.Infrastructure
{
    public interface IUnitofWork<TContext> : IDisposable where TContext : DbContext
    {
        IPersonRepository Person { get; }
        IPublicTypeRepository PublicType { get; }
        void Commit();
    }

    public class UnitofWork<TContext> : IUnitofWork<TContext> where TContext : DbContext, new()
    {
        private readonly DbContext db;
        private IPersonRepository _person;
        private IPublicTypeRepository _public;
        public UnitofWork()
        {
            db = new TContext();
        }
        public void Commit()
        {
            db.SaveChanges();
        }

        public IPersonRepository Person => _person ?? (_person = new PersonRepository(db));
        public IPublicTypeRepository PublicType => _public ?? (_public = new PublicTypeRepository(db));



        #region Disposed
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        #endregion
    }
}