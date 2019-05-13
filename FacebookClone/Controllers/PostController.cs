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
        public ActionResult NewPost(PostNewPost formData)
        {
          //  Boolean dogrula = false;
            table_post kayit = new table_post();
            // table_user gonderen = new table_user();
            
            kayit.post_text = formData.Post_text;
            kayit.post_img_link = formData.Post_img_link;
            kayit.gonderen = Session["Kullanici"].ToString();

    
            db.table_post.Add(kayit);
            db.SaveChanges();

            //return View("akis");
            return RedirectToRoute("akis");

        }

        public ActionResult Akis()
        {
            facecloneEntities facecloneEntities = new facecloneEntities();
           
            return View(facecloneEntities.table_post.ToList());
        }
    }
}