using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_MVC_專案分層架構_Part._1_20180517.Models.Interface
{
    public interface IProductRepository
    {
        void Create(Products instance);

        void Update(Products instance);

        void Delete(Products instance);

        Products Get(int productID);

        IQueryable<Products> GetAll();

        void SaveChanges();
    }
}