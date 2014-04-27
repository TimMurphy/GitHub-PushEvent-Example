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
        public EmptyResult PushEvent(GitHubPushEvent pushEvent)
        {
            return new EmptyResult();
        }
    }
}