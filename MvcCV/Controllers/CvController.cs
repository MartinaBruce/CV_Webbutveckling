using Microsoft.AspNetCore.Mvc;
using MvcCV.Models;

namespace MvcCV.Controllers
{
    public class CvController : Controller
    {

        public ActionResult Experience()
        {
            Companies companies = new Companies()
            {
                Company = "Företag1", 
                Title = "TeamLeader", 
                StartDate = DateTime.Parse("2020-2-12")

            };

  
            return View(companies);
        }

        public IActionResult Education()
        {
            ViewBag.courses = new List<string>()
            {
                "Webbutvekling backend",
                "Webbutvekling frontend",
                "databaser med SQL",
                "JavaScript "
            };

            ViewBag.coursesgym = new List<string>()
            {
                "beteendevetenskap",
                "Datavetenskap",

            };

            return View();
        }

    }
}
