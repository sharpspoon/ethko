using ethko.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Mvc;

namespace ethko.Controllers
{

    [Authorize]
    public class ContactsController : Controller
    {
        private Entities db = new Entities();
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

        public ActionResult GetContactIndividualViewModel()
        {
            return View(db.Contacts.ToList());
        }
    }
}
