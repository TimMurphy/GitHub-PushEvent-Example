using System;
using System.Web.Mvc;
using GitHub.PushEvent.Example.Models;

namespace GitHub.PushEvent.Example.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PushEvent(GitHubPushEvent pushEvent)
        {
            throw new NotImplementedException("pushevent");
        }
    }
}