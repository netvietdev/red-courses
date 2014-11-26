using System.Web.Mvc;

namespace RedCourses.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListCourses()
        {
            return PartialView();
        }

        public ActionResult ViewCourse()
        {
            return PartialView();
        }
    }
}
