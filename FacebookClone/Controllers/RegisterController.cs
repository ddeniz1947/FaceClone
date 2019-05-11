
using FacebookClone.Models;
using FacebookClone.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FacebookClone.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        facecloneEntities db = new facecloneEntities();

        public ActionResult Reg()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Reg(RegisterReg model, RegisterReg formData)
        {
            
                table_user kayit = new table_user();
                kayit.kadi = model.Kadi;
                kayit.password = model.Parola;
                kayit.email = model.Email;
                kayit.name = model.Name;
                kayit.surname = model.Surname;
                kayit.telno = model.Telno;

                db.table_user.Add(kayit);

                db.SaveChanges();

                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                return View("olusturuldu");
         }
    }
}