using Blog.Context;
using Blog.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class BlogController : Controller
    {
        BlogContext db = new BlogContext();

        // GET: Blog
        public ActionResult Index()
        {
            return View(db.Blogs.ToList());
        }

        // GET: Blog/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        // GET: Blog/Create           
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Blog/Create
        [HttpPost]
        public ActionResult Create(Blogg blog)
        {
            try
            {

                if(ModelState.IsValid)
                {
                    db.Blogs.Add(blog);
                    db.SaveChanges();
                    return RedirectToAction("Index");

                }
                return View(blog);
            }
            catch
            {
                return View();
            }
        }

        // GET: Blog/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Blog/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Blog/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Blog/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
