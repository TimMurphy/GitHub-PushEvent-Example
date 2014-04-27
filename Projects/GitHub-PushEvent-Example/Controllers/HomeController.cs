using System;
using System.Web.Mvc;

namespace GitHub.PushEvent.Example.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PushEvent()
        {
            throw new NotImplementedException("pushevent");
        }
    }
}