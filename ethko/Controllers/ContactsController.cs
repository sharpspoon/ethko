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

        //////////
        //CONTACTS
        //////////
        //New
        public ActionResult New()
        {
            return View();
        }

        public Contact ConvertViewModelToModel(AddContactIndividualViewModel vm)
        {
            return new Contact()
            {
                FName = vm.FName,
                MName = vm.MName,
                LName = vm.LName,
                CellPhone = vm.CellPhone,
                WorkPhone = vm.WorkPhone,
                HomePhone = vm.HomePhone,
                Address = vm.Address,
                Address2 = vm.Address2,
                City = vm.City,
                State = vm.State,
                Zip = vm.Zip,
                Country = vm.Country,
                Email = vm.Email
            };
        }

        [HttpPost]
        public ActionResult New(AddContactIndividualViewModel model)
        {
            var contactModel = ConvertViewModelToModel(model);
            var user = User.Identity.GetUserName().ToString();
            using (Entities entities = new Entities())
            {
                entities.Contacts.Add(contactModel);
                contactModel.InsDate = DateTime.Now;
                contactModel.UserId = entities.AspNetUsers.Where(m => m.Email == user).Select(m => m.Id).First();
                entities.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        //View List
        [HttpGet]
        public ActionResult Index()
        {
            Entities entities = new Entities();
            IEnumerable<Contact> contacts = entities.Contacts.Where(m => m.Archived == 0).ToList();
            //var contactModel = ConvertViewModelToModel(contacts);
            return View(contacts.AsEnumerable());
        }

        //View Archive List
        [HttpGet]
        public ActionResult ContactsArchive()
        {
            Entities entities = new Entities();
            IEnumerable<Contact> contacts = entities.Contacts.Where(m => m.Archived == 1).ToList();
            //var contactModel = ConvertViewModelToModel(contacts);
            return View(contacts.AsEnumerable());
        }

        //View Specific Contact
        [HttpGet]
        public ActionResult ViewContact(int? ContactId)
        {
            Entities entities = new Entities();
            Contact contacts = entities.Contacts.Where(m => m.ContactId == ContactId).SingleOrDefault();
            return View(contacts);
        }

        //Delete Specific Contact
        [HttpGet]
        public ActionResult Delete(int? ContactId)
        {
            Entities entities = new Entities();
            Contact contacts = entities.Contacts.Where(m => m.ContactId == ContactId).SingleOrDefault();
            return View(contacts);
        }
        
        [HttpPost]
        public ActionResult DeleteConfirmed(int? ContactId)
        {
            Entities entities = new Entities();
            Contact contacts = entities.Contacts.Remove(entities.Contacts.Where(m => m.ContactId == ContactId).SingleOrDefault());
            return RedirectToAction("Index");
        }

        //////////
        //COMPANIES
        //////////
        //New
        public ActionResult NewCompany()
        {
            return View();
        }

        public Company ConvertViewModelToModel(AddCompanyViewModel vm)
        {
            return new Company()
            {
                Name = vm.Name,
                Email = vm.Email,
                Website = vm.Website,
                MainPhone = vm.MainPhone,
                FaxNumber = vm.FaxNumber,
                Address = vm.Address,
                Address2 = vm.Address2,
                City = vm.City,
                State = vm.State,
                Zip = vm.Zip,
                Country = vm.Country
            };
        }

        [HttpPost]
        public ActionResult NewCompany(AddCompanyViewModel model)
        {
            var user = User.Identity.GetUserName().ToString();
            var companyModel = ConvertViewModelToModel(model);

            using (Entities entities = new Entities())
            {
                entities.Companies.Add(companyModel);
                //var user = User.Identity.GetUserName().ToString();
                companyModel.InsDate = DateTime.Now;
                companyModel.FstUser = entities.AspNetUsers.Where(m => m.Email == user).Select(m => m.Id).First();
                entities.SaveChanges();
            }
            return RedirectToAction("Companies");
        }

        //View List
        [HttpGet]
        public ActionResult Companies()
        {
            Entities entities = new Entities();
            IEnumerable<Company> companies = entities.Companies.ToList();
            //var contactModel = ConvertViewModelToModel(contacts);
            return View(companies.AsEnumerable());
        }

        //View Archive List
        public ActionResult CompaniesArchive()
        {
            Entities entities = new Entities();
            IEnumerable<Company> companies = entities.Companies.Where(m => m.Archived == 1).ToList();
            //var contactModel = ConvertViewModelToModel(contacts);
            return View(companies.AsEnumerable());
        }


        //////////
        //GROUPS
        //////////
        //New
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
                contactGroupModel.InsDate = DateTime.Now;
                contactGroupModel.FstUser = entities.AspNetUsers.Where(m => m.Email == user).Select(m => m.Id).First();
                entities.SaveChanges();
            }
            return RedirectToAction("ContactGroups");
        }

        //View List
        [HttpGet]
        public ActionResult ContactGroups()
        {
            Entities entities = new Entities();
            IEnumerable<ContactGroup> contactGroups = entities.ContactGroups.ToList();
            //var contactModel = ConvertViewModelToModel(contacts);
            return View(contactGroups.AsEnumerable());
        }
    }
}
