using ASP.NET_MVC_專案分層架構_Part._1_20180517.Models;
using ASP.NET_MVC_專案分層架構_Part._1_20180517.Models.Interface;
using ASP.NET_MVC_專案分層架構_Part._1_20180517.Models.Repositiry;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_專案分層架構_Part._1_20180517.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryRepository categoryRepository;

        public CategoryController()
        {
            this.categoryRepository = new CategoryRepository();
        }

        // GET: Category
        public ActionResult Index()
        {
            var categories = this.categoryRepository.GetAll().ToList();
            return View(categories);
        }
        //========================================================================

        public ActionResult Details(int? id)
        {
            if(!id.HasValue)
            {
                return RedirectToAction("index");
            }
            else
            {
                var categories = this.categoryRepository.Get(id.Value);
                return View(categories);
            }
        }
        //==========================================================================

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Categories categories)
        {
            if(categories != null && ModelState.IsValid)
            {
                this.categoryRepository.Create(categories);
                return RedirectToAction("index");
            }
            else
            {
                return View(categories);
            }
        }
        //=========================================================================

        public ActionResult Edit(int? id)
        {
            if(!id.HasValue)
            {

                return RedirectToAction("index");
            }
            else
            {
                var category = this.categoryRepository.Get(id.Value);
                return View(category);
            }
        }

        [HttpPost]
        public ActionResult Edit(Categories categories)
        {
            if(categories != null && ModelState.IsValid)
            {
                this.categoryRepository.Update(categories);
                return View(categories);
            }
            else
            {
                return RedirectToAction("index");
            }
        }
        //==============================================================================

        public ActionResult Delete(int? id)
        {
            if(!id.HasValue)
            {
                return RedirectToAction("index");
            }
            else
            {
                var category = this.categoryRepository.Get(id.Value);
                return View(category);
            }
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                var category = this.categoryRepository.Get(id);
                this.categoryRepository.Delete(category);
            }
            catch(DataException)
            {
                return RedirectToAction("Delete", new { id = id });
            }
            return RedirectToAction("index");
        }
    }
}