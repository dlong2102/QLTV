using System;
using System.Collections.Generic;

using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;


namespace THCNPM.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home

        public ActionResult Index()
        {
            //var books = database.Books.ToList();
            //var docgia = database.DocGias.ToList();
            //var thedocgia =database.TheDocGias.ToList();
            //int sosachmuon = database.PhieuMuonTras.Count();

            //// Tạo ViewModel chứa danh sách sách và danh sách độc giả
            //var viewModel = new ViewModel
            //{
            //    Books = books,
            //    DocGias = docgia,
            //    TheDocGias = thedocgia,
            //    SoSachMuons = sosachmuon
            //};
            return View();
        }
    }
}