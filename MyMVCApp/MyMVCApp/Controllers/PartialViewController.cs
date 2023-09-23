using Microsoft.AspNetCore.Mvc;

namespace MyMVCApp.Controllers
{
    public class PartialViewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Tabs()
        {
            ViewData["data1"] = "Tom and Jerry are good friends";
            return View();
        }
    }
}
