using ethko.Models;
using Microsoft.AspNet.Identity;
using System;
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

        [HttpGet]
        public ActionResult ContactGroups()
        {
            Entities entities = new Entities();
            IEnumerable<ContactGroup> contactGroups = entities.ContactGroups.ToList();
            //var contactModel = ConvertViewModelToModel(contacts);
            return View(contactGroups.AsEnumerable());
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

        public ActionResult New()
        {
            return View();
        }

        public ActionResult NewGroup()
        {
            return View();
        }

        public ContactGroup ConvertViewModelToModel(AddContactGroupViewModel vm)
        {
            return new ContactGroup()
            {
                ContactGroupName = vm.ContactGroupName
            };
        }

        [HttpPost]
        public ActionResult NewGroup(AddContactGroupViewModel model)
        {
            var user = User.Identity.GetUserName().ToString();
            var contactGroupModel = ConvertViewModelToModel(model);

            using (Entities entities = new Entities())
            {
                entities.ContactGroups.Add(contactGroupModel);
                //var user = User.Identity.GetUserName().ToString();
                contactGroupModel.InsDate = DateTime.Now;
                contactGroupModel.FstUser = entities.AspNetUsers.Where(m => m.Email == user).Select(m => m.Id).First();
                entities.SaveChanges();

            }
            return View(model);
        }
    }
}
