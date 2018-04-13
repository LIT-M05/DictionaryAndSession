using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CharacterCountingAndSession.Controllers
{
    public class SessionDemoController : Controller
    {
        public ActionResult Index()
        {
            int number = 0;
            if (Session["my-number"] != null)
            {
                number = (int) Session["my-number"];
            }
            number++;
            Session["my-number"] = number;
            return View(number);
        }
    }
}