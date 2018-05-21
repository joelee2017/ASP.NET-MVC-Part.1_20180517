using ASP.NET_MVC_專案分層架構_Part._1_20180517.Models.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASP.NET_MVC_專案分層架構_Part._1_20180517.Models.Repositiry
{
    public class CategoryRepository : GenericRepository<Categories>, ICategoryRepository
    {
        public Categories GetByID(int categoryID)
        {
            return this.Get(x => x.CategoryID == categoryID);
        }
    }
}