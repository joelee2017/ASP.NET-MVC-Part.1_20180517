using ASP.NET_MVC_專案分層架構_Part._1_20180517.Models.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASP.NET_MVC_專案分層架構_Part._1_20180517.Models.Repositiry
{
    public class CategoryRepository : ICategoryRepository, IDisposable
    {
        protected NorthwindEntities db
        {
            get;
            private set;
        }

        public CategoryRepository()
        {
            this.db = new NorthwindEntities();
        }

        public void Create(Categories instance)
        {
           if(instance == null)
            {
                throw new ArgumentException("instance");
            }
           else
            {
                db.Categories.Add(instance);
                this.SaveChanges();
            }
        }

        public void Update(Categories instance)
        {
            if(instance == null)
            {
                throw new ArgumentException("instance");
            }
            else
            {
                db.Entry(instance).State = EntityState.Modified;
                this.SaveChanges();
            }
        }

        public void Delete(Categories instance)
        {
            if(instance == null)
            {
                throw new ArgumentNullException("instance");
            }
            else
            {
                db.Entry(instance).State = EntityState.Deleted;
                this.SaveChanges();
            }
        }             

        public Categories Get(int categoryID)
        {
            return db.Categories.FirstOrDefault(x => x.CategoryID == categoryID);
        }

        public IQueryable<Categories> GetAll()
        {
            return db.Categories.OrderBy(x => x.CategoryID);
        }

        public void SaveChanges()
        {
            this.db.SaveChanges();
        }
      

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if(disposing)
            {
                if(this.db != null)
                {
                    this.db.Dispose();
                    this.db = nll;
                }
            }
        }
    }
}