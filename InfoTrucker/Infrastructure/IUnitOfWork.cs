using System;
using System.Data.Entity;
using InfoTrucker.Services;

namespace InfoTrucker.Infrastructure
{
    public interface IUnitofWork
    {
        IDbSet<TEntity> Set<TEntity>() where TEntity : class;
        int SaveChanges();
    }


}