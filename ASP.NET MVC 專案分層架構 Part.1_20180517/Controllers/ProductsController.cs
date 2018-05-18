using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ASP.NET_MVC_專案分層架構_Part._1_20180517.Models;
using ASP.NET_MVC_專案分層架構_Part._1_20180517.Models.Interface;
using ASP.NET_MVC_專案分層架構_Part._1_20180517.Models.Repositiry;

namespace ASP.NET_MVC_專案分層架構_Part._1_20180517.Controllers
{
    public class ProductsController : Controller
    {
        private IRepository<Products> productRepository;
        private IRepository<Categories> categoryRepository;

        public IEnumerable<Categories> Categories
        {
            get
            {
                return categoryRepository.GetAll();
            }
        }

        public ProductsController()
        {
            this.productRepository = new GenericRepository<Products>();
            this.categoryRepository = new GenericRepository<Categories>();
        }

        // GET: Products
        public ActionResult Index()
        {
            var products = productRepository.GetAll()
                .OrderByDescending(x => x.ProductID)
                .ToList();
            return View(products.ToList());
        }

        // GET: Products/Details/5
        public ActionResult Details(int id = 0)
        {
            Products products = productRepository.Get(x => x.ProductID == id);          
            if (products == null)
            {
                return HttpNotFound();
            }
            return View(products);
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            ViewBag.CategoryID = new SelectList(this.Categories, "CategoryID", "CategoryName");
            return View();
        }

        [HttpPost]
        public ActionResult Create(Products products)
        {
            if (ModelState.IsValid)
            {
                this.productRepository.Create(products);
                return RedirectToAction("Index");
            }

            ViewBag.CategoryID = new SelectList(this.Categories, "CategoryID", "CategoryName", products.CategoryID);
            return View(products);
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int id = 0)
        {
            Products products = this.productRepository.Get(x => x.ProductID == id);
            if (products == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoryID = new SelectList(this.Categories, "CategoryID", "CategoryName", products.CategoryID);
            return View(products);
        }

        [HttpPost]
        public ActionResult Edit(Products products)
        {
            if (ModelState.IsValid)
            {
                this.productRepository.Update(products);
                return RedirectToAction("Index");
            }
            ViewBag.CategoryID = new SelectList(this.Categories, "CategoryID", "CategoryName", products.CategoryID);
            return View(products);
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int id = 0)
        {
            Products products = this.productRepository.Get(x => x.ProductID == id);
            if (products == null)
            {
                return HttpNotFound();
            }
            return View(products);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Products products = this.productRepository.Get(x => x.ProductID == id);
            this.productRepository.Delete(products);
            return RedirectToAction("Index");
        }
    }
}
