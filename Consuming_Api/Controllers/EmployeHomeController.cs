using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Consuming_Api.Controllers
{
    public class EmployeHomeController : Controller
    {
        // GET: EmployeHome
        public ActionResult Index()
        {
            return View();
        }
    }
}