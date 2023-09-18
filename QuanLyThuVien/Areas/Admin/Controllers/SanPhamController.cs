using System;
using System.Collections.Generic;

using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace THCNPM.Areas.Admin.Controllers
{
    public class SanPhamController : Controller
    {


        public ActionResult QLSach()
        {
            return View();
        }
        public ActionResult QLSTTL(string maTheLoai)
        {
         
            return View();
        }

        public ActionResult AddBookView()
        {
            return View();
        }
        public ActionResult DeleteBookView()
        {
            return View();
        }

        public ActionResult ArrayBookView()
        {
            return View();
        }

        public ActionResult DetailBookView()
        {
            return View();
        }

        public ActionResult EditBookView()
        {
            return View();
        }
    }
}