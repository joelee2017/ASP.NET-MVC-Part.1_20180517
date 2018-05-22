using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc_Repository_Models.Interface
{
    public interface ICategoryRepository : IRepository<Categories>
    {
        Categories GetByID(int categoryID);
    }
}