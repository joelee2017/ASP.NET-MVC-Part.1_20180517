using Mvc_Repository_Models;
using Mvc_Repository_Models.Interface;
using Mvc_Repository_Models.Repositiry;
using Mvc_Repository_Service.Interface;
using Mvc_Repository_Service.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc_Repository_Service
{
    public class CategoryService : ICategoryService
    {
        private IRepository<Categories> repository = new GenericRepository<Categories>();

        public IResult Create(Categories instance)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Categories instance)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(int categoryID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Categories> GetAll()
        {
            throw new NotImplementedException();
        }

        public Categories GetByID(int categoryID)
        {
            throw new NotImplementedException();
        }

        public bool IsExists(int categoryID)
        {
            throw new NotImplementedException();
        }
      
    }
}
