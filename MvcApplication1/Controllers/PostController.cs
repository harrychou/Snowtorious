using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class PostController : Controller
    {
        //
        // GET: /Post/

        public ActionResult Index()
        {
            // list all posts
            var db = new BlogDataContext();
            var posts = db.Posts;
            return View(posts);
        }

        //
        // GET: /Post/Details/5

        public ActionResult Details(int id)
        {
            var db = new BlogDataContext();
            var post = db.Posts.FirstOrDefault(x => x.PK_PostID == id);
            return View(post);
        }

        //
        // GET: /Post/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Post/Create

        [HttpPost]
        public ActionResult Create(Post post)
        {
            var db = new BlogDataContext();
            try
            {
                // TODO: Add insert logic here
                db.Posts.InsertOnSubmit(post);
                db.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(post);
            }
        }

        //
        // GET: /Post/Edit/5
 
        public ActionResult Edit(int id)
        {
            var db = new BlogDataContext();
            var post = db.Posts.FirstOrDefault(x => x.PK_PostID == id);
            return View(post);
        }

        //
        // POST: /Post/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var db = new BlogDataContext();
            var post = db.Posts.FirstOrDefault(x => x.PK_PostID == id);

            try
            {
                // TODO: Add update logic here
                UpdateModel(post);
                db.SubmitChanges();
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View(post);
            }
        }
    }
}
