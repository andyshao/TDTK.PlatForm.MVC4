using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TDTK.PlatForm.MVC4.BLL;
using TDTK.PlatForm.MVC4.DBUtility;
using TDTK.PlatForm.MVC4.Model;

namespace TDTK.PlatForm.MVC4.WebUI.Portal.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            if (Session["UserName"] != null)
            {
                ViewBag.userName = Session["UserName"].ToString();
            }
            return View();
        }


        public ActionResult GetTreeMenu()
        {
            Sys_MenuBLL menuBLL = new Sys_MenuBLL();
            Dictionary<Model.TreeRoot, List<Model.TreeItems>> d = menuBLL.GetTree("s0002");
            return Json(d.AsQueryable(), JsonRequestBehavior.AllowGet);
        }


    }
}
