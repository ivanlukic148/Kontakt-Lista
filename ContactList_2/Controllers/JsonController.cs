using System;
using System.Web.Mvc;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ContactList_2.Controllers
{
    public class JsonController : Controller
    {
        //kontroler koji obavlja serijalizaciju
        protected new ActionResult Json(object data, JsonRequestBehavior behaviour = JsonRequestBehavior.AllowGet) {
            var jsonSerializerSettings = new JsonSerializerSettings { 
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };

            if (Request.RequestType == WebRequestMethods.Http.Get && behaviour == JsonRequestBehavior.DenyGet)
                throw new InvalidOperationException("GET is not permitted for this request");

            var jsonResult = new ContentResult { 
                Content = JsonConvert.SerializeObject(data, jsonSerializerSettings),
                ContentType = "application/json"
            };
            return jsonResult;
        }
	}
}