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

        [HttpPost]
        public ActionResult Index(Contact contact)
        {
            using (Entities entities = new Entities())
            {
                entities.Contacts.Add(contact);
                var user = User.Identity.GetUserName().ToString();
                contact.UserId = entities.AspNetUsers.Where(m => m.Email == user).Select(m => m.Id).First();
                contact.ContactId = 1;
                entities.SaveChanges();
                int id = contact.ContactId;

            }
            return View(contact);
        }
    }
}
