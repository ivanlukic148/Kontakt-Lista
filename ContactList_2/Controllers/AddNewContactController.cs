using ContactList_2.Models.ContactsMV;
using System.Net;
using System.Web.Mvc;

namespace ContactList_2.Controllers
{
    public class AddNewContactController : Controller
    {
        [HttpPost]
        public ActionResult Save(ContactsMV contact)
        {
            //ajax ce spremit studenta, ova metoda samo salje OK klijentu
            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }
	}
}