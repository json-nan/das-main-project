using MainProject.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MainProject.Controllers
{

    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            List<Career> careers = db.Careers.Take(3).ToList();
            List<New> news = db.News.Take(3).ToList();

            dynamic model = new System.Dynamic.ExpandoObject();
            model.Careers = careers;
            model.News = news;

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}