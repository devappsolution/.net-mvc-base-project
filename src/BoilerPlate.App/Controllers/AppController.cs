using System.Web.Mvc;

namespace BoilerPlate.App.Controllers
{
    public class AppController : Controller
    {
        [HttpGet]
        public ActionResult AppIndex()
        {
            return View("~/Views/ControleAcesso/Autenticar/Login.cshtml");
        }

        [HttpGet]
        public ActionResult AppView()
        {
            return View((string)RouteData.Values["view"]);
        }

        [HttpGet]
        public ActionResult AppResource()
        {
            return File(string.Format("~/{0}", RouteData.Values["resource"]), "application/octet-stream");
        }
    }
}
