using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ethko.Controllers
{
    [Authorize]
    public class CommentsController : Controller
    {
        public ActionResult Comments()
        {
            return View();
        }
    }
}
