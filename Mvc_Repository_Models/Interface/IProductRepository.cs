using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc_Repository_Models.Interface
{
    public interface IProductRepository : IRepository<Products>
    {
        Products GetByID(int productID);

        IEnumerable<Products> GetByCategory(int categoryID);
    }

}