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

        public ActionResult PracticeAreas()
        {
            return View();
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
    }
}
