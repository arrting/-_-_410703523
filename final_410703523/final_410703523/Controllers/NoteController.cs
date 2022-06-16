using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace final_410703523.Controllers
{
    public class NoteController : Controller
    {
        // GET: Note
        public ActionResult Index(string name, int? number)
        {
            var result = "";
            if (number.HasValue)
            {
                if (number > 0 && number < 8)
                {
                    result = "correct";
                }
                else {
                    result = "ERROR";
                }
            }
            ViewBag.name = name;
            ViewBag.result = result;
            return View();
        }
    }
}