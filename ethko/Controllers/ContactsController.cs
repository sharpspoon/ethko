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
        private readonly Entities db = new Entities();

        public Contact ConvertViewModelToModel(GetContactIndividualViewModel vm)
        {
            return new Contact()
            {
                FName = vm.FName,
                LName = vm.LName,
                UserId = vm.UserId,
                Email = vm.Email
            };
        }

        [HttpGet]
        public ActionResult Index()
        {
            
            Entities entities = new Entities();
            IEnumerable<Contact> contacts = entities.Contacts.ToList();
            //var contactModel = ConvertViewModelToModel(contacts);
            return View(contacts.AsEnumerable());
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

        public ActionResult ViewContact()
        {
            return View();
        }
    }
}
