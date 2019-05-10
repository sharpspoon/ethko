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
        public ActionResult Index(GetContactIndividualViewModel model)
        {
            var contactModel = ConvertViewModelToModel(model);
            return View(model);
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

        //public ActionResult GetContactIndividualViewModel()
        //{
        //    return View();
        //}
    }
}
