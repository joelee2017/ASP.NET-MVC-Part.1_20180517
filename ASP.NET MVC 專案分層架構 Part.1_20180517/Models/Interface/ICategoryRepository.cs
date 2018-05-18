using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_MVC_專案分層架構_Part._1_20180517.Models.Interface
{
    public interface ICategoryRepository : IDisposable
    {
        void Create(Categories instance);

        void Update(Categories instance);

        void Delete(Categories instance);

        Categories Get(int categoryID);

        IQueryable<Categories> GetAll();

        void SaveChanges();
    }
}