using FacebookClone.Models;
using FacebookClone.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace FacebookClone.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        facecloneEntities db = new facecloneEntities();

        public ActionResult Index()
        {
            return View();
        }

    
        [HttpPost]
        public ActionResult Index(HomeIndex formData)
        { 
            
            table_user kayit = new table_user();
            string kadi, parola, pass;
            Boolean dogrulama = false;
            if (!ModelState.IsValid)
            {
                return View();
            }
            else
            {
                foreach(var err in db.table_user)
                {
                    kadi = err.kadi;
                    parola = err.password;
                    if(kadi == formData.kadi && parola == formData.parola)
                    {
                        FormsAuthentication.SetAuthCookie(err.kadi, true);
                        dogrulama = true;
                    }
                }
            }
            if (dogrulama == true)
            {
                return View("akis");
            }
            else
                return Content("Giris Yapilamadi");
            
           
        }
    }
}