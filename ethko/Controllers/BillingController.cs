﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ethko.Controllers
{
    [Authorize]
    public class BillingController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
