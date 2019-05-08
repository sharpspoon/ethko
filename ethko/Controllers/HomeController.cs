using ethko.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ethko.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public Contact ConvertViewModelToModel(AddContactIndividualViewModel vm)
        {
            return new Contact()
            {
                FName = vm.FName,
                LName = vm.LName,
                UserId = vm.UserId,
                Email = vm.Email
            };
        }

        [HttpPost]
        public ActionResult Index(AddContactIndividualViewModel model)
        {
            var contactModel = ConvertViewModelToModel(model);

            using (Entities entities = new Entities())
            {
                entities.Contacts.Add(contactModel);
                var user = User.Identity.GetUserName().ToString();
                contactModel.UserId = entities.AspNetUsers.Where(m => m.Email == user).Select(m => m.Id).First();
                entities.SaveChanges();

            }
            return View(model);
        }
    }
}
