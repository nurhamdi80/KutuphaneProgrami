using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KutuphaneProgrami.Controllers
{
    public class HataController : Controller
    {
        // GET: Hata
        public ActionResult SayfaBulunamadi()
        {
            return View();
        }
        public ActionResult ErisimIzniYok()
        {
            return View();
        }
        public ActionResult SunucuHatasi()
        {
            return View();
        }
    }
}