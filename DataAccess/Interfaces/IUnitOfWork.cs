using System;

namespace Library.Data.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<TEntity> GetRepository<TEntity>()
            where TEntity : class;

        int SaveChanges();
    }
}
