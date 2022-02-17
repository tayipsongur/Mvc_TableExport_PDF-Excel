using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Export.Controllers;
using Export.Models.Entity;
using Excel = Microsoft.Office.Interop.Excel;


namespace Export.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        KargoEntities db = new KargoEntities();
        public ActionResult Index()
        {


            var listele = db.Musteriler.ToList();

            return View(listele);
        }
    }
}