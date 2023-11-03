using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Degrey_Huflit.Models;

namespace Degrey_Huflit.Controllers
{
    public class CategoriesController : Controller
    {
        DegreyStoreEntities database = new DegreyStoreEntities();

        // GET: Categories
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Category cate)
        {
            try
            {
                database.Categories.Add(cate);
                database.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return Content("Error Create New");
            }
        }

        public ActionResult Details(string id)
        {
            return View(database.Categories.Where(s => s.IDCate == id).FirstOrDefault());
        }

        public ActionResult Edit(string id)
        {
            return View(database.Categories.Where(s => s.IDCate == id).FirstOrDefault());
        }
        [HttpPost]
        public ActionResult Edit(string id, Category cate)
        {
            database.Entry(cate).State = System.Data.Entity.EntityState.Modified;
            database.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(string id)
        {
            return View(database.Categories.Where(s => s.IDCate == id).FirstOrDefault());
        }
        [HttpPost]
        public ActionResult Delete(string id, Category cate)
        {
            try
            {
                cate = database.Categories.Where(s => s.IDCate == id).FirstOrDefault();
                database.Categories.Remove(cate);
                database.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return Content("This data is using in other table, Error Delete!");
            }
        }
    }
}