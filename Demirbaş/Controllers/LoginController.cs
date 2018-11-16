using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Demirbaş.Classes;
using Demirbaş.DataModel;
namespace Demirbaş.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public ActionResult Login(string ReturnURL = "")
        {
            Session["User"] = "";
            ViewBag.ReturnUrl = ReturnURL;
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserLogin u, string ReturnUrl)
        {
            using (EquipmentsEntities data = new EquipmentsEntities())
            {
                LoginPanel k = data.LoginPanel.Where(p => p.KullanıcıAdi == u.UserName && p.Password == u.Password).FirstOrDefault();
                if (k == null)
                {
                    ModelState.AddModelError("", "UserId or password is invalid.");
                    return View();
                }
                else
                {
                    u.Password = "*";
                    u.UID = k.ID;
                    Session["User"] = u;
                }
            }
            return RedirectToLocal(ReturnUrl);
        }

        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (returnUrl != "" && returnUrl != null)
            {
                return Redirect(returnUrl);
            }
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Logout()
        {
            Session["User"] = null;
            return RedirectToAction("Login");
        }
        public ActionResult UserCreate()

        {
            return View();

        }
    }
}