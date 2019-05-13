using FacebookClone.Models;
using FacebookClone.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FacebookClone.Controllers
{
    public class PostController : Controller
    {
        // GET: Post
        facecloneEntities db = new facecloneEntities();

        public ActionResult NewPost()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewPost(PostNewPost formData,HomeIndex formData2)
        {
            Boolean dogrula = false;
            table_post kayit = new table_post();
            table_user gonderen = new table_user();

            kayit.post_text = formData.post_text;
            kayit.post_img_link = formData.post_img_link;
            kayit.user = formData2.kadi;

    
            db.table_post.Add(kayit);
           db.SaveChanges();
            return View();

        }

        public ActionResult Akis(PostAkis formData)
        {
            table_post postlar = new table_post();
        
            /*
            using(var contex = new facecloneEntities())
            {
                List<table_post> post = contex.table_post.ToList();
            }
            */
            ViewData["mesaj"] = postlar.post_id + postlar.post_text + postlar.user;
            ViewData["img"] = postlar.post_img_link;

            return View();
        }
    }
}