﻿using ethko.Models;
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
        Entities entities = new Entities();
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
            var practiceAreas = new SelectList(entities.PracticeAreas.ToList(), "PracticeAreaName", "PracticeAreaName");
            ViewData["DBContactGroups"] = practiceAreas;
            return View();
        }

        public ActionResult NewPracticeArea()
        {
            return View();
        }

        public ActionResult DeletePracticeArea(int? PracticeAreaId)
        {
            if (PracticeAreaId == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Entities entities = new Entities();
            PracticeArea practiceAreas = entities.PracticeAreas.Where(m => m.PracticeAreaId == PracticeAreaId).Single();
            return View(practiceAreas);
        }

        public ActionResult DeleteConfirmed(int? PracticeAreaId)
        {
            if (PracticeAreaId == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PracticeArea practiceAreas = entities.PracticeAreas.Find(PracticeAreaId);
            entities.PracticeAreas.Remove(practiceAreas);
            entities.SaveChanges();
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
