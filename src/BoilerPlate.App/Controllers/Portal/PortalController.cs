using BoilerPlate.App.Extensions;
using System.Web.Mvc;

namespace BoilerPlate.App.Controllers.Portal
{
    public class PortalController : Controller
    {
        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {
            return View("~/Views/Portal/Site.cshtml");
        }
    }
}