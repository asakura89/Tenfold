using System;
using System.Web.Mvc;

namespace Tenfold.Controllers {

    public class FeedbackController : Controller {
        [HttpGet]
        public ActionResult Index() => View();

        [HttpPost]
        public ActionResult Submit(Object data) {
            String person = Request.Form["person"];
            String positive = Request.Form["positive"];
            String improvement = Request.Form["improvement"];

            return RedirectToAction("Done");
        }

        [HttpGet]
        public ActionResult Done() => View();
    }
}