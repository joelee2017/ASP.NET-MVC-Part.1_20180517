using Mvc_Repository_Models;
using Mvc_Repository_Service.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc_Repository_Service.Interface
{
    public interface ICategoryService
    {
        IResult Create(Categories instance);

        IResult Update(Categories instance);

        IResult Delete(int categoryID);

        bool IsExists(int categoryID);

        Categories GetByID(int categoryID);

        IEnumerable<Categories> GetAll();
    }
}
