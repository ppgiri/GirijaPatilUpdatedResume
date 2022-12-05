using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortfolioMVCproject.Controllers
{
    public class EducationController : Controller
    {
        // GET: Education
        public ActionResult Education()
        {
            ViewBag.SchoolName = "Guru Nanak Public School";
            ViewBag.SchoolBoard = "CBSE";
            ViewBag.SchoolScores = "8.9 CGPA";

            ViewBag.CollegeName = "Mahesh PU college";
            ViewBag.CollegeBoard = "State Board";
            ViewBag.CollegeScores = "70%";

            ViewBag.DegreeCollegeName = "Guru Nanak Dev Engineering College";
            ViewBag.DegreeDepartment = "BE CSE ";
            ViewBag.DegreeScores = "8.9 CGPA";


            return View();
        }
    }
}