using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using SignalrStudy.Models;

namespace SignalrStudy.Controllers
{
    public class AccountController : Controller
    {
        ContextDbData db = new Models.ContextDbData();
        // GET: Account
        public ActionResult Login()
        {
            db.listUsers.Select(s => s.id);
            return View();
        }

        public ActionResult Index()
        {
            //var userId = Session["Userid"] == null ? "" : Session["Userid"];

            return View();
        }

        [HttpPost]
        public ActionResult Login(Users user)
        {
            var result = db.listUsers.SingleOrDefault(u => u.LoginId == user.LoginId && u.Pwd == user.Pwd);
            Session["Userid"] = result.id;
            string status = string.Empty;
            if (result != null)
            {
                result.status = 1;
                db.SaveChanges();
                return Redirect("Index");
            }

            return Json("登录失败", JsonRequestBehavior.AllowGet);
        }

    }
}