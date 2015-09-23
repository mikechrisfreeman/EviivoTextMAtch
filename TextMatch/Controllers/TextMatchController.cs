using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TextMatch.Models;

namespace TextMatch.Controllers
{
    public class TextMatchController : Controller
    {
        //
        // GET: /TextMatch/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ContactModel model = new ContactModel()
            {
                AddressLine1 = "6 Algernon Road",
                AddressLine2 = "SE13 7AT",
                ContactNo = "0758 425 4386",
                Name = "Michael Freeman"
            };
            return View(model);
        }

    }
}
