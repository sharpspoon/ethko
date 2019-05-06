using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ethko.Controllers
{
    [Authorize]
    public class LeadsController : Controller
    {
        public ActionResult Leads()
        {
            return View();
        }
    }
}
