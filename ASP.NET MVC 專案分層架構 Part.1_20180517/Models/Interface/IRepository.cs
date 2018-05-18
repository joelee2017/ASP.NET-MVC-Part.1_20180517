using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_MVC_專案分層架構_Part._1_20180517.Models.Interface
{
    public interface IRepository<TEntity>: IDisposable
        where TEntity : class
    {
        void Create(TEntity instance);

        void Update(TEntity instance);

        void Delete(TEntity instance);

        TEntity Get(int primaryID);

        IQueryable<TEntity> GetAll();

        void SaveChanges();
    }
}