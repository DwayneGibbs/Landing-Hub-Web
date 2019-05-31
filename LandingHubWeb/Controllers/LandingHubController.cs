using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LandingHubWeb.Controllers
{
    public class LandingHubController : Controller
    {
        // GET: LandingHub
        public ActionResult Index()
        {
            string GravatarEmail = System.Configuration.ConfigurationManager.AppSettings["GravatarEmailAddress"].ToString();

            Services.StringToMD5 stringToMD5 = new Services.StringToMD5();
            ViewBag.GravatarHashedEmail = "https://www.gravatar.com/avatar/" + stringToMD5.CreateMD5(GravatarEmail) + "?s=200.jpg";

            return View();
        }
    }
}