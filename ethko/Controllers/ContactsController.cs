using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ethko.Controllers
{
    [Authorize]
    public class ContactsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Companies()
        {
            return View();
        }

        public ActionResult ContactGroups()
        {
            return View();
        }

        public ActionResult CompaniesArchive()
        {
            return View();
        }

        public ActionResult ContactsArchive()
        {
            return View();
        }
    }
}
