using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortfolioMVCproject.Controllers
{
    public class ExperienceController : Controller
    {
        // GET: Experience
        public ActionResult Experience()
        {
            ViewBag.ClientSideOne = "HTML";
            ViewBag.ClientsideTwo = "CSS";
            

            ViewBag.ServerSideOne = "Python";
            ViewBag.ServerSideTwo = ".Net";
            

            ViewBag.BackendOne = "SQL";
            ViewBag.BackendTwo = "MongoDB";
            


            return View();
        }
    }
}