using ethko.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using System.Data.Entity;

namespace ethko.Controllers
{
    [Authorize]
    public class CasesController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult PracticeAreas()
        {
            using (Entities entities = new Entities())
            {
                var practiceAreas = from p in entities.PracticeAreas
                                    select new GetPracticeAreasViewModel() { PracticeAreaId = p.PracticeAreaId.ToString(), PracticeAreaName = p.PracticeAreaName, InsDate = p.InsDate.ToString(), UserId = p.FstUser };
                return View(practiceAreas.ToList());
            }
        }

        public ActionResult CaseInsights()
        {
            return View();
        }

        public ActionResult Closed()
        {
            return View();
        }

        public ActionResult New()
        {
            return View();
        }

        public ActionResult NewPracticeArea()
        {
            return View();
        }

        public PracticeArea ConvertViewModelToModel(AddPracticeAreaViewModel vm)
        {
            return new PracticeArea()
            {
                PracticeAreaName = vm.PracticeAreaName
            };
        }

        [HttpPost]
        public ActionResult NewPracticeArea(AddPracticeAreaViewModel model)
        {
            var user = User.Identity.GetUserName().ToString();
            var practiceAreaModel = ConvertViewModelToModel(model);

            using (Entities entities = new Entities())
            {
                entities.PracticeAreas.Add(practiceAreaModel);
                practiceAreaModel.InsDate = DateTime.Now;
                practiceAreaModel.FstUser = entities.AspNetUsers.Where(m => m.Email == user).Select(m => m.Id).First();
                entities.SaveChanges();
            }
            return RedirectToAction("PracticeAreas");
        }
    }
}
