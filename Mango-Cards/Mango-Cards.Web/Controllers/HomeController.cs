using System.Net;
using System.Web;
using System.Web.Mvc;
using Mango_Cards.Library.Services;
using Mango_Cards.Web.Infrastructure;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace Mango_Cards.Web.Controllers
{
    public class HomeController : Controller
    {
         private readonly ILoginLogService _loginLogService;

         public HomeController(ILoginLogService loginLogService)
        {
            _loginLogService = loginLogService;
            
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetMangoCard()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult LoginConfirmation()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}