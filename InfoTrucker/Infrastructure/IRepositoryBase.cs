using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace InfoTrucker.Infrastructure
{
    public interface IRepositoryBase<TEntity> : IDisposable where TEntity : class
    {
        //-------Definition Public Functions Models-----------//
        void Insert(TEntity entity);
        void Change(TEntity entity, bool nullabl);

        void Delete(object Id);
        void Delete(TEntity entity);
        void Delete(Expression<Func<TEntity, bool>> where); //lambda expression

        TEntity GetById(object Id);
        IEnumerable<TEntity> GetAll();
        TEntity Get(Expression<Func<TEntity, bool>> where);
        IEnumerable<TEntity> GetMany(Expression<Func<TEntity, bool>> where);

        //---------------Async Functions----------------//
        Task<List<TEntity>> GetAllAsync();
        Task<TEntity> GetFirstOrDefaultAsync(Expression<Func<TEntity, bool>> where);
        Task<TEntity> GetSingleOrDefaultAsync(Expression<Func<TEntity, bool>> where);
        Task<List<TEntity>> GetManyAsync(Expression<Func<TEntity, bool>> where);

    }

    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity>, IDisposable where TEntity : class
    {
        private readonly DbContext _context;

        private DbSet<TEntity> dbSet
        {
            get
            {
                return _context.Set<TEntity>();

            }
        }

        public RepositoryBase(DbContext context)
        {
            _context = context;
        }

        public void Delete(object Id)
        {
            var entity = GetById(Id);
            if (entity == null)
                throw new ArgumentException("on entity");
            dbSet.Remove(entity);
        }

        public void Delete(TEntity entity)
        {
            dbSet.Remove(entity);
        }

        public void Delete(Expression<Func<TEntity, bool>> where)
        {
            IEnumerable<TEntity> objects = dbSet.Where(where).AsEnumerable();
            foreach (TEntity obj in objects)
            {
                dbSet.Remove(obj);
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> where)
        {
            return dbSet.Where(where).FirstOrDefault();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return dbSet.ToList();
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await dbSet.ToListAsync();
        }

        public async Task<TEntity> GetFirstOrDefaultAsync(Expression<Func<TEntity, bool>> where)
        {
            return await dbSet.Where(where).FirstOrDefaultAsync();
        }

        public async Task<TEntity> GetSingleOrDefaultAsync(Expression<Func<TEntity, bool>> where)
        {
            return await dbSet.Where(where).SingleOrDefaultAsync();
        }

        public TEntity GetById(object Id)
        {
            return dbSet.Find(Id);
        }

        public IEnumerable<TEntity> GetMany(Expression<Func<TEntity, bool>> where)
        {
            return dbSet.Where(where).ToList();
        }

        public async Task<List<TEntity>> GetManyAsync(Expression<Func<TEntity, bool>> where)
        {
            return await dbSet.Where(where).ToListAsync();
        }

        public void Insert(TEntity entity)
        {
            dbSet.Add(entity);
        }

        public void Change(TEntity entity, bool nullabl)
        {
            if (!nullabl) _context.Entry(entity).State = EntityState.Detached;
            _context.Entry(entity).State = EntityState.Modified;
        }

        #region Dispose

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
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