using System.Web.Mvc;
using ContactList_2.Models.ContactsMV;

namespace ContactList_2.Controllers
{
    public class HomeController : JsonController
    {
        private readonly ContactsMVBuilder _contactMVBuilder = new ContactsMVBuilder();
        public ActionResult Index()
        {
            return View("Index", "", Json(_contactMVBuilder.GetContactsMV(), JsonRequestBehavior.AllowGet));
        }
	}
}